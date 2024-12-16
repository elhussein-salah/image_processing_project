using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Numerics;
namespace image_processing
{
    public static class ImageProcessingUtils
    {


        public static Bitmap ApplyGaussianFilter(Bitmap inputImage)
        {
            // Define a 3x3 Gaussian kernel with standard weights
            double[,] kernel = {
            { 1, 2, 1 },
            { 2, 4, 2 },
            { 1, 2, 1 }
        };

            double kernelSum = 16.0; // Kernel sum for normalization

            int width = inputImage.Width;    // Image width
            int height = inputImage.Height;  // Image height
            Bitmap outputImage = new Bitmap(width, height); // Output image

            // Loop through each pixel, ignoring the border pixels (for 3x3 kernel)
            for (int y = 1; y < height - 1; y++)
            {
                for (int x = 1; x < width - 1; x++)
                {
                    double red = 0, green = 0, blue = 0;

                    // Apply the 3x3 kernel to the neighboring pixels
                    for (int ky = -1; ky <= 1; ky++)
                    {
                        for (int kx = -1; kx <= 1; kx++)
                        {
                            // Get the neighboring pixel
                            Color pixel = inputImage.GetPixel(x + kx, y + ky);
                            double weight = kernel[ky + 1, kx + 1]; // Weight from the kernel

                            // Multiply the pixel values by the kernel weight
                            red += pixel.R * weight;
                            green += pixel.G * weight;
                            blue += pixel.B * weight;
                        }
                    }

                    // Normalize the pixel values
                    int r = (int)(red / kernelSum);
                    int g = (int)(green / kernelSum);
                    int b = (int)(blue / kernelSum);

                    // Clamp values to the valid range [0, 255]
                    r = Math.Min(255, Math.Max(0, r));
                    g = Math.Min(255, Math.Max(0, g));
                    b = Math.Min(255, Math.Max(0, b));

                    // Set the new pixel value in the output image
                    outputImage.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            return outputImage; // Return the processed image
        }

        public static Bitmap HistogramEqualization(Bitmap inputImage)
        {
            // Assuming a grayscale image
            int width = inputImage.Width;
            int height = inputImage.Height;

            // Step 1: Calculate the histogram
            int[] histogram = new int[256];
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int intensity = inputImage.GetPixel(x, y).R;
                    histogram[intensity]++;
                }
            }

            // Step 2: Compute the cumulative distribution function (CDF)
            int[] cdf = new int[256];
            cdf[0] = histogram[0];
            for (int i = 1; i < 256; i++)
            {
                cdf[i] = cdf[i - 1] + histogram[i];
            }

            // Find the minimum non-zero value in the CDF
            int cdfMin = 0;
            for (int i = 0; i < 256; i++)
            {
                if (cdf[i] > 0)
                {
                    cdfMin = cdf[i];
                    break;
                }
            }

            // Step 3: Normalize the CDF to the range [0, 255]
            int totalPixels = width * height;
            int[] equalizedLUT = new int[256];
            for (int i = 0; i < 256; i++)
            {
                equalizedLUT[i] = (int)((cdf[i] - cdfMin) * 255.0 / (totalPixels - cdfMin));
                equalizedLUT[i] = Math.Max(0, Math.Min(255, equalizedLUT[i])); // Clamp values
            }

            // Step 4: Apply the LUT to create the equalized image
            Bitmap equalizedImage = new Bitmap(width, height);
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int intensity = inputImage.GetPixel(x, y).R;
                    int equalizedIntensity = equalizedLUT[intensity];
                    Color newPixel = Color.FromArgb(equalizedIntensity, equalizedIntensity, equalizedIntensity);
                    equalizedImage.SetPixel(x, y, newPixel);
                }
            }

            return equalizedImage;
        }
        public static Bitmap ContrastStretch(Bitmap inputImage, int newMin = 0, int newMax = 120)
        {
            // Create a new bitmap for the output
            Bitmap outputImage = new Bitmap(inputImage.Width, inputImage.Height);

            // Find the old min and max pixel intensity values
            int oldMin = 255, oldMax = 0;

            // Iterate over the image to find the min and max intensity
            for (int y = 0; y < inputImage.Height; y++)
            {
                for (int x = 0; x < inputImage.Width; x++)
                {
                    Color pixel = inputImage.GetPixel(x, y);
                    int intensity = pixel.R; // Assuming a grayscale image
                    if (intensity < oldMin) oldMin = intensity;
                    if (intensity > oldMax) oldMax = intensity;
                }
            }

            // Apply the contrast stretching formula
            for (int y = 0; y < inputImage.Height; y++)
            {
                for (int x = 0; x < inputImage.Width; x++)
                {
                    Color pixel = inputImage.GetPixel(x, y);
                    int intensity = pixel.R; // Assuming a grayscale image

                    // Contrast stretching formula
                    int stretchedValue = (int)((intensity - oldMin) * ((double)(newMax - newMin) / (oldMax - oldMin)) + newMin);

                    // Clamp the value to ensure it is within valid range
                    stretchedValue = Math.Max(0, Math.Min(255, stretchedValue));

                    // Set the new pixel value
                    Color newPixel = Color.FromArgb(stretchedValue, stretchedValue, stretchedValue);
                    outputImage.SetPixel(x, y, newPixel);
                }
            }

            return outputImage;
        }
        // Compute the minimum pixel value in a grayscale image
        public static Bitmap ApplyMinFilter(Bitmap inputImage)
        {
            // Fixed 3x3 kernel size (radius = 1)
            int kernelSize = 3;
            int radius = kernelSize / 2;

            int width = inputImage.Width;
            int height = inputImage.Height;
            Bitmap outputImage = new Bitmap(width, height);

            // Loop through each pixel in the image (excluding borders)
            for (int x = radius; x < width - radius; x++)
            {
                for (int y = radius; y < height - radius; y++)
                {
                    int minRed = 255, minGreen = 255, minBlue = 255;

                    // Loop through the 3x3 kernel area
                    for (int i = -radius; i <= radius; i++)
                    {
                        for (int j = -radius; j <= radius; j++)
                        {
                            int nx = x + i;
                            int ny = y + j;

                            // Get the color of the neighboring pixel
                            Color neighborPixel = inputImage.GetPixel(nx, ny);

                            // Find the minimum value of Red, Green, and Blue channels
                            minRed = Math.Min(minRed, neighborPixel.R);
                            minGreen = Math.Min(minGreen, neighborPixel.G);
                            minBlue = Math.Min(minBlue, neighborPixel.B);
                        }
                    }

                    // Set the minimum value for the current pixel in the output image
                    outputImage.SetPixel(x, y, Color.FromArgb(minRed, minGreen, minBlue));
                }
            }

            return outputImage;
        }

        // Compute the maximum pixel value in a grayscale image
        public static Bitmap ApplyMaxFilter(Bitmap inputImage)
        {
            // Fixed 3x3 kernel size (radius = 1)
            int kernelSize = 3;
            int radius = kernelSize / 2;

            int width = inputImage.Width;
            int height = inputImage.Height;
            Bitmap outputImage = new Bitmap(width, height);

            // Loop through each pixel in the image (excluding borders)
            for (int x = radius; x < width - radius; x++)
            {
                for (int y = radius; y < height - radius; y++)
                {
                    int maxRed = 0, maxGreen = 0, maxBlue = 0;

                    // Loop through the 3x3 kernel area
                    for (int i = -radius; i <= radius; i++)
                    {
                        for (int j = -radius; j <= radius; j++)
                        {
                            int nx = x + i;
                            int ny = y + j;

                            // Get the color of the neighboring pixel
                            Color neighborPixel = inputImage.GetPixel(nx, ny);

                            // Find the maximum value of Red, Green, and Blue channels
                            maxRed = Math.Max(maxRed, neighborPixel.R);
                            maxGreen = Math.Max(maxGreen, neighborPixel.G);
                            maxBlue = Math.Max(maxBlue, neighborPixel.B);
                        }
                    }

                    // Set the maximum value for the current pixel in the output image
                    outputImage.SetPixel(x, y, Color.FromArgb(maxRed, maxGreen, maxBlue));
                }
            }

            return outputImage;
        }
        // Compute the mean pixel value in a grayscale image
        public static Bitmap ApplyMeanFilter(Bitmap image)
        {
            // إعدادات الفلتر (نصف حجم الفلتر)
            int filterSize = 3; // حجم الفلتر (3x3)
            int offset = filterSize / 2;

            Bitmap result = new Bitmap(image);
            for (int i = offset; i < image.Width - offset; i++)
            {
                for (int j = offset; j < image.Height - offset; j++)
                {
                    int r = 0, g = 0, b = 0;

                    // تطبيق الفلتر على المنطقة المحيطة بالبكسل الحالي
                    for (int x = -offset; x <= offset; x++)
                    {
                        for (int y = -offset; y <= offset; y++)
                        {
                            Color pixelColor = image.GetPixel(i + x, j + y);
                            r += pixelColor.R;
                            g += pixelColor.G;
                            b += pixelColor.B;
                        }
                    }

                    // حساب المتوسط لكل قناة لونية (أحمر، أخضر، أزرق)
                    int avgR = r / (filterSize * filterSize);
                    int avgG = g / (filterSize * filterSize);
                    int avgB = b / (filterSize * filterSize);

                    // تعيين القيمة المعدلة للبكسل في الصورة الناتجة
                    result.SetPixel(i, j, Color.FromArgb(avgR, avgG, avgB));
                }
            }

            return result;
        }

        // Compute the median pixel value in a grayscale image
        public static Bitmap ApplyMedianFilter(Bitmap inputImage)
        {
            // Fixed 3x3 kernel size (radius = 1)
            int kernelSize = 3;
            int radius = kernelSize / 2;

            int width = inputImage.Width;
            int height = inputImage.Height;
            Bitmap outputImage = new Bitmap(width, height);

            // Loop through each pixel in the image (excluding borders)
            for (int x = radius; x < width - radius; x++)
            {
                for (int y = radius; y < height - radius; y++)
                {
                    // Create lists to store the RGB values of the neighboring pixels
                    var redValues = new System.Collections.Generic.List<int>();
                    var greenValues = new System.Collections.Generic.List<int>();
                    var blueValues = new System.Collections.Generic.List<int>();

                    // Loop through the 3x3 kernel area
                    for (int i = -radius; i <= radius; i++)
                    {
                        for (int j = -radius; j <= radius; j++)
                        {
                            int nx = x + i;
                            int ny = y + j;

                            // Get the color of the neighboring pixel
                            Color neighborPixel = inputImage.GetPixel(nx, ny);

                            // Add the RGB values of the neighbor to the lists
                            redValues.Add(neighborPixel.R);
                            greenValues.Add(neighborPixel.G);
                            blueValues.Add(neighborPixel.B);
                        }
                    }

                    // Find the median of the RGB values using LINQ
                    int medianRed = redValues.OrderBy(val => val).ElementAt(redValues.Count / 2);
                    int medianGreen = greenValues.OrderBy(val => val).ElementAt(greenValues.Count / 2);
                    int medianBlue = blueValues.OrderBy(val => val).ElementAt(blueValues.Count / 2);

                    // Set the median value for the current pixel in the output image
                    outputImage.SetPixel(x, y, Color.FromArgb(medianRed, medianGreen, medianBlue));
                }
            }

            return outputImage;
        }

        // Convert an RGB image to grayscale
        public static Bitmap RgbToGray(Image image)
        {
            Bitmap grayImage = new Bitmap(image.Width, image.Height);
            using (Graphics g = Graphics.FromImage(grayImage))
            {
                ColorMatrix colorMatrix = new ColorMatrix(new float[][]
                {
                new float[] { 0.3f, 0.3f, 0.3f, 0, 0 },
                new float[] { 0.59f, 0.59f, 0.59f, 0, 0 },
                new float[] { 0.11f, 0.11f, 0.11f, 0, 0 },
                new float[] { 0, 0, 0, 1, 0 },
                new float[] { 0, 0, 0, 0, 1 }
                });

                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(colorMatrix);

                g.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
            }
            return grayImage;
        }

        // Convert a grayscale image to binary using a threshold
        public static Bitmap GrayToBinary(Image image, byte threshold = 128)
        {
            Bitmap binaryImage = new Bitmap(image.Width, image.Height);
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixel = ((Bitmap)image).GetPixel(x, y);
                    byte gray = pixel.R;
                    byte binaryValue = (gray >= threshold) ? (byte)255 : (byte)0;
                    binaryImage.SetPixel(x, y, Color.FromArgb(binaryValue, binaryValue, binaryValue));
                }
            }
            return binaryImage;
        }

        // Convert an RGB image to binary using a threshold
        public static Image RgbToBinary(Image image, byte threshold)
        {
            Image grayImage = RgbToGray(image);
            return GrayToBinary(grayImage, threshold);
        }

        public static Bitmap LaplacianFilter(Image image)
        {
            Bitmap laplacian = new Bitmap(image.Width, image.Height);

            int[,] kernel =
            {
            {  0, -1,  0 },
            { -1,  4, -1 },
            {  0, -1,  0 }
        };

            int offset = 1;

            for (int y = offset; y < image.Height - offset; y++)
            {
                for (int x = offset; x < image.Width - offset; x++)
                {
                    int r = 0, g = 0, b = 0;

                    for (int ky = -offset; ky <= offset; ky++)
                    {
                        for (int kx = -offset; kx <= offset; kx++)
                        {
                            Color pixel = ((Bitmap)image).GetPixel(x + kx, y + ky);
                            int weight = kernel[ky + offset, kx + offset];

                            r += pixel.R * weight;
                            g += pixel.G * weight;
                            b += pixel.B * weight;
                        }
                    }

                    r = Math.Clamp(r, 0, 255);
                    g = Math.Clamp(g, 0, 255);
                    b = Math.Clamp(b, 0, 255);

                    laplacian.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            return laplacian;
        }

        public static Bitmap ApplyPrewittFilter(Image inputImage)
        {
            // Convert input image to Bitmap
            Bitmap inputBitmap = new Bitmap(inputImage);
            Bitmap outputBitmap = new Bitmap(inputBitmap.Width, inputBitmap.Height);

            // Define Prewitt kernels for horizontal and vertical edges
            int[,] prewittX = new int[,]
            {
            { -1, 0, 1 },
            { -1, 0, 1 },
            { -1, 0, 1 }
            };

            int[,] prewittY = new int[,]
            {
            { 1, 1, 1 },
            { 0, 0, 0 },
            { -1, -1, -1 }
            };

            // Loop through the image pixels (excluding borders)
            for (int x = 1; x < inputBitmap.Width - 1; x++)
            {
                for (int y = 1; y < inputBitmap.Height - 1; y++)
                {
                    int gradientX = 0;
                    int gradientY = 0;

                    // Apply kernels to the 3x3 neighborhood
                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            Color neighborPixel = inputBitmap.GetPixel(x + i, y + j);
                            int grayValue = (neighborPixel.R + neighborPixel.G + neighborPixel.B) / 3;

                            gradientX += prewittX[i + 1, j + 1] * grayValue;
                            gradientY += prewittY[i + 1, j + 1] * grayValue;
                        }
                    }

                    // Calculate gradient magnitude
                    int gradientMagnitude = (int)Math.Sqrt(gradientX * gradientX + gradientY * gradientY);

                    // Clamp values to the 0-255 range
                    gradientMagnitude = Math.Min(255, Math.Max(0, gradientMagnitude));

                    // Set the pixel in the output bitmap
                    outputBitmap.SetPixel(x, y, Color.FromArgb(gradientMagnitude, gradientMagnitude, gradientMagnitude));
                }
            }

            return outputBitmap; // Return as Image
        }

        // Apply a sharpening filter to an image
        public static Bitmap ApplySobelFilter(Bitmap inputImage)
        {
            int width = inputImage.Width;
            int height = inputImage.Height;
            Bitmap outputImage = new Bitmap(width, height);

            // Sobel operator kernels for horizontal and vertical edge detection
            int[,] Gx = new int[,] {
            {-1, 0, 1},
            {-2, 0, 2},
            {-1, 0, 1}
        };

            int[,] Gy = new int[,] {
            {-1, -2, -1},
            { 0,  0,  0},
            { 1,  2,  1}
        };

            // Loop through each pixel in the image (excluding borders)
            for (int x = 1; x < width - 1; x++)
            {
                for (int y = 1; y < height - 1; y++)
                {
                    int pixelXRed = 0, pixelYRed = 0;
                    int pixelXGreen = 0, pixelYGreen = 0;
                    int pixelXBlue = 0, pixelYBlue = 0;

                    // Apply the Sobel kernels to the 3x3 neighborhood of each pixel
                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            Color neighborPixel = inputImage.GetPixel(x + i, y + j);
                            int red = neighborPixel.R;
                            int green = neighborPixel.G;
                            int blue = neighborPixel.B;

                            // Apply the Gx kernel (horizontal edge detection)
                            pixelXRed += red * Gx[i + 1, j + 1];
                            pixelXGreen += green * Gx[i + 1, j + 1];
                            pixelXBlue += blue * Gx[i + 1, j + 1];

                            // Apply the Gy kernel (vertical edge detection)
                            pixelYRed += red * Gy[i + 1, j + 1];
                            pixelYGreen += green * Gy[i + 1, j + 1];
                            pixelYBlue += blue * Gy[i + 1, j + 1];
                        }
                    }

                    // Calculate the gradient magnitude (edge strength)
                    int edgeStrengthRed = (int)Math.Sqrt(pixelXRed * pixelXRed + pixelYRed * pixelYRed);
                    int edgeStrengthGreen = (int)Math.Sqrt(pixelXGreen * pixelXGreen + pixelYGreen * pixelYGreen);
                    int edgeStrengthBlue = (int)Math.Sqrt(pixelXBlue * pixelXBlue + pixelYBlue * pixelYBlue);

                    // Normalize the edge strength to fit within the 0-255 range
                    edgeStrengthRed = Math.Min(255, edgeStrengthRed);
                    edgeStrengthGreen = Math.Min(255, edgeStrengthGreen);
                    edgeStrengthBlue = Math.Min(255, edgeStrengthBlue);

                    // Set the new pixel value in the output image (sharp edges)
                    outputImage.SetPixel(x, y, Color.FromArgb(edgeStrengthRed, edgeStrengthGreen, edgeStrengthBlue));
                }
            }

            return outputImage;
        }

        public static Bitmap ApplyIncreaseBrightnessFilter(Bitmap original, int value = 10)
        {
            Bitmap newImage = new Bitmap(original.Width, original.Height);
            for (int y = 0; y < original.Height; y++)
            {
                for (int x = 0; x < original.Width; x++)
                {
                    Color pixel = original.GetPixel(x, y);

                    int red = Clamp(pixel.R + value, 0, 255);
                    int green = Clamp(pixel.G + value, 0, 255);
                    int blue = Clamp(pixel.B + value, 0, 255);

                    Color newPixel = Color.FromArgb(red, green, blue);
                    newImage.SetPixel(x, y, newPixel);
                }
            }
            return newImage;
        }
        public static Bitmap ApplyDecreaseBrightnessFilter(Bitmap original, int value = 10)
        {
            Bitmap newImage = new Bitmap(original.Width, original.Height);
            for (int y = 0; y < original.Height; y++)
            {
                for (int x = 0; x < original.Width; x++)
                {
                    Color pixel = original.GetPixel(x, y);

                    int red = Clamp(pixel.R - value, 0, 255);
                    int green = Clamp(pixel.G - value, 0, 255);
                    int blue = Clamp(pixel.B - value, 0, 255);

                    Color newPixel = Color.FromArgb(red, green, blue);
                    newImage.SetPixel(x, y, newPixel);
                }
            }
            return newImage;
        }
        // Function to apply an ideal low-pass filter to an image
        public static Bitmap ApplyIdealLowPassFilter(Bitmap inputImage, int cutoff = 100)
        {
            int width = inputImage.Width;    // Image width
            int height = inputImage.Height;  // Image height
            Bitmap outputImage = new Bitmap(width, height);

            // Loop through each pixel in the image
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    // Get the pixel value
                    Color pixel = inputImage.GetPixel(x, y);

                    // Calculate distance from the center of the image
                    double distance = Math.Sqrt(Math.Pow(x - width / 2, 2) + Math.Pow(y - height / 2, 2));

                    // If the distance is within the cutoff, keep the pixel, otherwise set it to black
                    if (distance <= cutoff)
                    {
                        outputImage.SetPixel(x, y, pixel); // Keep the same pixel
                    }
                    else
                    {
                        outputImage.SetPixel(x, y, Color.Black); // Set pixel to black
                    }
                }
            }
            return outputImage; // Return the filtered image
        }

        // Gaussian high-pass filter
        public static Bitmap ApplyGaussianHighPassFilter(Bitmap inputImage, double sigma = 50)
        {
            int width = inputImage.Width;
            int height = inputImage.Height;
            Bitmap outputImage = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixel = inputImage.GetPixel(x, y);

                    // Calculate distance from center
                    double distance = Math.Sqrt(Math.Pow(x - width / 2, 2) + Math.Pow(y - height / 2, 2));

                    // Apply Gaussian high-pass filter formula
                    double filter = 1 - Math.Exp(-Math.Pow(distance, 2) / (2 * Math.Pow(sigma, 2)));

                    int r = (int)(pixel.R * filter);
                    int g = (int)(pixel.G * filter);
                    int b = (int)(pixel.B * filter);

                    outputImage.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            return outputImage;
        }

        public static Bitmap ApplyButterworthLowPassFilter(Bitmap inputImage, double cutoff = 50.0, int order = 2)
        {
            int width = inputImage.Width;
            int height = inputImage.Height;
            Bitmap outputImage = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixel = inputImage.GetPixel(x, y);

                    // Calculate distance from center
                    double distance = Math.Sqrt(Math.Pow(x - width / 2, 2) + Math.Pow(y - height / 2, 2));

                    // Apply Butterworth formula
                    double filter = 1 / (1 + Math.Pow(distance / cutoff, 2 * order));

                    int r = (int)(pixel.R * filter);
                    int g = (int)(pixel.G * filter);
                    int b = (int)(pixel.B * filter);

                    outputImage.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            return outputImage;
        }


        public static int Clamp(int value, int min, int max)
        {
            return Math.Max(min, Math.Min(max, value));
        }


        // Rayleigh Noise Filter
        public static Bitmap ApplyRayleighNoise(Bitmap inputImage, double a = 4, double b = 7)
        {
            Random rand = new Random();
            Bitmap result = new Bitmap(inputImage);
            int width = inputImage.Width;
            int height = inputImage.Height;

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    double noise = Math.Sqrt(-2 * Math.Log(rand.NextDouble())) * Math.Sin(2 * Math.PI * rand.NextDouble()) * a;
                    Color pixelColor = inputImage.GetPixel(x, y);

                    int newR = Math.Min(255, Math.Max(0, pixelColor.R + (int)noise));
                    int newG = Math.Min(255, Math.Max(0, pixelColor.G + (int)noise));
                    int newB = Math.Min(255, Math.Max(0, pixelColor.B + (int)noise));

                    result.SetPixel(x, y, Color.FromArgb(newR, newG, newB));
                }
            }

            return result;
        }


        // Gaussian Noise Filter
        public static Bitmap ApplyGaussianNoise(Bitmap inputImage, double mean = 0.0, double stdDev = 10.0, double percentage = 0.05)
        {
            Random rand = new Random();
            Bitmap result = new Bitmap(inputImage);
            int width = inputImage.Width;
            int height = inputImage.Height;
            int totalPixels = (int)(width * height * percentage);

            for (int i = 0; i < totalPixels; i++)
            {
                int x = rand.Next(width);
                int y = rand.Next(height);

                double noise = mean + stdDev * rand.NextDouble();
                Color originalColor = inputImage.GetPixel(x, y);

                int newR = Math.Min(255, Math.Max(0, originalColor.R + (int)noise));
                int newG = Math.Min(255, Math.Max(0, originalColor.G + (int)noise));
                int newB = Math.Min(255, Math.Max(0, originalColor.B + (int)noise));

                result.SetPixel(x, y, Color.FromArgb(newR, newG, newB));
            }

            return result;
        }

        // MidPoint Filter
        public static Bitmap ApplyMidPointFilter(Bitmap inputImage)
        {
            Bitmap result = new Bitmap(inputImage);
            for (int x = 1; x < inputImage.Width - 1; x++)
            {
                for (int y = 1; y < inputImage.Height - 1; y++)
                {
                    int minR = 255, maxR = 0;
                    int minG = 255, maxG = 0;
                    int minB = 255, maxB = 0;

                    // Check neighboring pixels
                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            Color pixelColor = inputImage.GetPixel(x + i, y + j);
                            minR = Math.Min(minR, pixelColor.R);
                            maxR = Math.Max(maxR, pixelColor.R);
                            minG = Math.Min(minG, pixelColor.G);
                            maxG = Math.Max(maxG, pixelColor.G);
                            minB = Math.Min(minB, pixelColor.B);
                            maxB = Math.Max(maxB, pixelColor.B);
                        }
                    }

                    int midR = (minR + maxR) / 2;
                    int midG = (minG + maxG) / 2;
                    int midB = (minB + maxB) / 2;

                    result.SetPixel(x, y, Color.FromArgb(midR, midG, midB));
                }
            }
            return result;
        }

        // Line Detection Filter using Sobel Operator
        public static Bitmap ApplyLineDetection(Bitmap inputImage)
        {
            Bitmap result = new Bitmap(inputImage);
            int[,] sobelX = new int[,] { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };
            int[,] sobelY = new int[,] { { -1, -2, -1 }, { 0, 0, 0 }, { 1, 2, 1 } };

            for (int x = 1; x < inputImage.Width - 1; x++)
            {
                for (int y = 1; y < inputImage.Height - 1; y++)
                {
                    int pixelX = 0, pixelY = 0;

                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            Color color = inputImage.GetPixel(x + i, y + j);
                            int gray = (color.R + color.G + color.B) / 3;
                            pixelX += gray * sobelX[i + 1, j + 1];
                            pixelY += gray * sobelY[i + 1, j + 1];
                        }
                    }

                    int magnitude = (int)Math.Sqrt(pixelX * pixelX + pixelY * pixelY);
                    magnitude = Math.Min(255, magnitude);

                    result.SetPixel(x, y, Color.FromArgb(magnitude, magnitude, magnitude));
                }
            }
            return result;
        }

        // Point Sharpening Filter
        public static Bitmap ApplyPointSharpening(Bitmap inputImage)
        {
            Bitmap result = new Bitmap(inputImage);
            for (int x = 1; x < inputImage.Width - 1; x++)
            {
                for (int y = 1; y < inputImage.Height - 1; y++)
                {
                    Color pixelColor = inputImage.GetPixel(x, y);
                    int newR = Math.Min(255, pixelColor.R * 2);
                    int newG = Math.Min(255, pixelColor.G * 2);
                    int newB = Math.Min(255, pixelColor.B * 2);
                    result.SetPixel(x, y, Color.FromArgb(newR, newG, newB));
                }
            }
            return result;
        }

        // Apply Fourier Transform to an image (Discrete Fourier Transform)
        public static Bitmap ApplyFourierTransform(Bitmap inputImage)
        {
            Bitmap grayImage = ConvertToGray(inputImage);
            int width = grayImage.Width;
            int height = grayImage.Height;

            Complex[,] dftResult = new Complex[width, height];

            // Apply 2D DFT
            for (int u = 0; u < width; u++)
            {
                for (int v = 0; v < height; v++)
                {
                    Complex sum = Complex.Zero;
                    for (int x = 0; x < width; x++)
                    {
                        for (int y = 0; y < height; y++)
                        {
                            Color pixelColor = grayImage.GetPixel(x, y);
                            double pixelValue = pixelColor.R; // Grayscale image, use Red channel
                            double angle = -2 * Math.PI * ((u * x) / (double)width + (v * y) / (double)height);
                            Complex expValue = new Complex(Math.Cos(angle), Math.Sin(angle));
                            sum += pixelValue * expValue;
                        }
                    }
                    dftResult[u, v] = sum;
                }
            }

            // Shift the zero frequency component to the center
            Complex[,] shiftedDFT = ShiftDFT(dftResult);

            // Convert the magnitude spectrum to an image (to visualize it)
            Bitmap magnitudeImage = ConvertToMagnitudeImage(shiftedDFT);

            return magnitudeImage;
        }

        // Inverse Fourier Transform (IDFT)
        public static Bitmap ApplyInverseFourierTransform(Bitmap inputImage)
        {
            int width = inputImage.Width;
            int height = inputImage.Height;

            Complex[,] inverseDFT = new Complex[width, height];

            // Placeholder for inverse DFT computation (simplified)
            for (int u = 0; u < width; u++)
            {
                for (int v = 0; v < height; v++)
                {
                    Complex sum = Complex.Zero;
                    for (int x = 0; x < width; x++)
                    {
                        for (int y = 0; y < height; y++)
                        {
                            Color pixelColor = inputImage.GetPixel(x, y);
                            double angle = 2 * Math.PI * ((u * x) / (double)width + (v * y) / (double)height);
                            Complex expValue = new Complex(Math.Cos(angle), Math.Sin(angle));
                            sum += pixelColor.R * expValue;
                        }
                    }
                    inverseDFT[u, v] = sum / (width * height);
                }
            }

            // Convert inverse DFT result back to image
            Bitmap recoveredImage = ConvertToImageFromComplex(inverseDFT);

            return recoveredImage;
        }

        // Helper: Convert complex DFT result to magnitude image for visualization
        private static Bitmap ConvertToMagnitudeImage(Complex[,] dftResult)
        {
            int width = dftResult.GetLength(0);
            int height = dftResult.GetLength(1);
            Bitmap magnitudeImage = new Bitmap(width, height);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Complex dftValue = dftResult[x, y];
                    double magnitude = Math.Log(1 + dftValue.Magnitude);  // Log scale for better visualization
                    int pixelValue = (int)(magnitude * 255 / Math.Log(1 + dftValue.Magnitude));
                    pixelValue = Math.Min(255, pixelValue);  // Ensure pixel value stays in the valid range
                    magnitudeImage.SetPixel(x, y, Color.FromArgb(pixelValue, pixelValue, pixelValue));
                }
            }

            return magnitudeImage;
        }

        // Helper: Shift the zero-frequency components to the center of the image
        private static Complex[,] ShiftDFT(Complex[,] dftResult)
        {
            int width = dftResult.GetLength(0);
            int height = dftResult.GetLength(1);
            Complex[,] shiftedDFT = new Complex[width, height];

            int midX = width / 2;
            int midY = height / 2;

            for (int u = 0; u < width; u++)
            {
                for (int v = 0; v < height; v++)
                {
                    int newU = (u + midX) % width;
                    int newV = (v + midY) % height;
                    shiftedDFT[newU, newV] = dftResult[u, v];
                }
            }

            return shiftedDFT;
        }

        // Convert image to grayscale (helper function)
        private static Bitmap ConvertToGray(Bitmap inputImage)
        {
            Bitmap grayBitmap = new Bitmap(inputImage);
            for (int x = 0; x < inputImage.Width; x++)
            {
                for (int y = 0; y < inputImage.Height; y++)
                {
                    Color pixelColor = inputImage.GetPixel(x, y);
                    int grayValue = (int)(0.299 * pixelColor.R + 0.587 * pixelColor.G + 0.114 * pixelColor.B);
                    grayBitmap.SetPixel(x, y, Color.FromArgb(grayValue, grayValue, grayValue));
                }
            }
            return grayBitmap;
        }

        // Helper: Convert complex array back to Bitmap image
        private static Bitmap ConvertToImageFromComplex(Complex[,] complexArray)
        {
            int width = complexArray.GetLength(0);
            int height = complexArray.GetLength(1);
            Bitmap outputImage = new Bitmap(width, height);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Complex value = complexArray[x, y];
                    int pixelValue = (int)(value.Magnitude * 255);
                    pixelValue = Math.Min(255, Math.Max(0, pixelValue));
                    outputImage.SetPixel(x, y, Color.FromArgb(pixelValue, pixelValue, pixelValue));
                }
            }

            return outputImage;
        }

        public static Bitmap AddSaltAndPepperNoise(Bitmap inputImage, double saltProbability = 20, double pepperProbability = 30)
        {
            Random rand = new Random();
            Bitmap noisyImage = new Bitmap(inputImage);

            for (int x = 0; x < inputImage.Width; x++)
            {
                for (int y = 0; y < inputImage.Height; y++)
                {
                    double p = rand.NextDouble();
                    Color pixelColor = inputImage.GetPixel(x, y);

                    if (p < saltProbability)
                    {
                        noisyImage.SetPixel(x, y, Color.White);  // Add salt
                    }
                    else if (p > 1 - pepperProbability)
                    {
                        noisyImage.SetPixel(x, y, Color.Black);  // Add pepper
                    }
                    else
                    {
                        noisyImage.SetPixel(x, y, pixelColor);  // No noise
                    }
                }
            }

            return noisyImage;
        }

        public static Bitmap AddUniformNoise(Bitmap inputImage, int minValue = 10, int maxValue = 200)
        {
            Random rand = new Random();
            Bitmap noisyImage = new Bitmap(inputImage);

            for (int x = 0; x < inputImage.Width; x++)
            {
                for (int y = 0; y < inputImage.Height; y++)
                {
                    Color pixelColor = inputImage.GetPixel(x, y);
                    int noiseR = rand.Next(minValue, maxValue);
                    int noiseG = rand.Next(minValue, maxValue);
                    int noiseB = rand.Next(minValue, maxValue);

                    int r = Math.Min(Math.Max(pixelColor.R + noiseR, 0), 255);
                    int g = Math.Min(Math.Max(pixelColor.G + noiseG, 0), 255);
                    int b = Math.Min(Math.Max(pixelColor.B + noiseB, 0), 255);

                    noisyImage.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            return noisyImage;
        }

        public static Bitmap ApplyLineDetectionFilter(Bitmap inputImage)
        {
            Bitmap outputImage = new Bitmap(inputImage);
            int width = inputImage.Width;
            int height = inputImage.Height;

            // Sobel kernel for line detection
            int[,] kernelX = new int[,] {
        { -1, 0, 1 },
        { -2, 0, 2 },
        { -1, 0, 1 }
    };

            int[,] kernelY = new int[,] {
        { -1, -2, -1 },
        { 0, 0, 0 },
        { 1, 2, 1 }
    };

            for (int x = 1; x < width - 1; x++)
            {
                for (int y = 1; y < height - 1; y++)
                {
                    int gx = 0, gy = 0;

                    // Apply Sobel kernels to each pixel
                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            Color pixelColor = inputImage.GetPixel(x + i, y + j);
                            int grayValue = (int)(0.299 * pixelColor.R + 0.587 * pixelColor.G + 0.114 * pixelColor.B);
                            gx += grayValue * kernelX[i + 1, j + 1];
                            gy += grayValue * kernelY[i + 1, j + 1];
                        }
                    }

                    int magnitude = (int)Math.Min(Math.Sqrt(gx * gx + gy * gy), 255);
                    outputImage.SetPixel(x, y, Color.FromArgb(magnitude, magnitude, magnitude));
                }
            }

            return outputImage;
        }

        public static Bitmap ApplyExponentialNoise(Bitmap inputImage, double lambda = 1.0, double percentage = 0.05)
        {
            Random rand = new Random();
            Bitmap result = new Bitmap(inputImage);
            int width = inputImage.Width;
            int height = inputImage.Height;
            int totalPixels = (int)(width * height * percentage);

            for (int i = 0; i < totalPixels; i++)
            {
                int x = rand.Next(width);
                int y = rand.Next(height);

                double noise = -Math.Log(1 - rand.NextDouble()) / lambda;
                Color originalColor = inputImage.GetPixel(x, y);

                int newR = Math.Min(255, Math.Max(0, originalColor.R + (int)noise));
                int newG = Math.Min(255, Math.Max(0, originalColor.G + (int)noise));
                int newB = Math.Min(255, Math.Max(0, originalColor.B + (int)noise));

                result.SetPixel(x, y, Color.FromArgb(newR, newG, newB));
            }

            return result;
        }


        public static Bitmap AddGammaNoise(Bitmap inputImage, double shape = 2.0, double scale = 2.0, double percentage = 0.05)
        {
            Random rand = new Random();
            Bitmap result = new Bitmap(inputImage);
            int width = inputImage.Width;
            int height = inputImage.Height;
            int totalPixels = (int)(width * height * percentage);

            for (int i = 0; i < totalPixels; i++)
            {
                int x = rand.Next(width);
                int y = rand.Next(height);

                double gammaNoise = GenerateGammaNoise(rand, shape, scale);
                Color originalColor = inputImage.GetPixel(x, y);

                int newR = Math.Min(255, Math.Max(0, originalColor.R + (int)gammaNoise));
                int newG = Math.Min(255, Math.Max(0, originalColor.G + (int)gammaNoise));
                int newB = Math.Min(255, Math.Max(0, originalColor.B + (int)gammaNoise));

                result.SetPixel(x, y, Color.FromArgb(newR, newG, newB));
            }

            return result;
        }

        private static double GenerateGammaNoise(Random rand, double shape, double scale)
        {
            if (shape < 1)
            {
                shape += 1;
                double u = rand.NextDouble();
                return GenerateGammaNoise(rand, shape, scale) * Math.Pow(u, 1.0 / shape);
            }

            double d = shape - 1.0 / 3.0;
            double c = 1.0 / Math.Sqrt(9 * d);
            double v;

            do
            {
                double x;
                do
                {
                    x = rand.NextGaussian();
                    v = 1 + c * x;
                } while (v <= 0);

                v = v * v * v;
                double u = rand.NextDouble();

                if (u < 1 - 0.0331 * Math.Pow(x, 4))
                    break;

                if (Math.Log(u) < 0.5 * x * x + d * (1 - v + Math.Log(v)))
                    break;

            } while (true);

            return d * v * scale;
        }

        private static double NextGaussian(this Random rand)
        {
            double u1 = 1.0 - rand.NextDouble(); // Uniform(0,1] random doubles
            double u2 = 1.0 - rand.NextDouble();
            return Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2);
        }


        public static Bitmap ApplyHighBoostFilter(Bitmap image, double k = 1.5)
        {
            Bitmap result = new Bitmap(image.Width, image.Height);

            // Gaussian Blur to create low-frequency image
            Bitmap blurred = ApplyGaussianFilter(image);

            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color originalPixel = image.GetPixel(x, y);
                    Color blurredPixel = blurred.GetPixel(x, y);

                    // High-Boost formula: Result = Original + k * (Original - Blurred)
                    int newR = Math.Min(255, Math.Max(0, (int)(originalPixel.R + k * (originalPixel.R - blurredPixel.R))));
                    int newG = Math.Min(255, Math.Max(0, (int)(originalPixel.G + k * (originalPixel.G - blurredPixel.G))));
                    int newB = Math.Min(255, Math.Max(0, (int)(originalPixel.B + k * (originalPixel.B - blurredPixel.B))));

                    result.SetPixel(x, y, Color.FromArgb(newR, newG, newB));
                }
            }

            return result;
        }

        public static Bitmap ApplyLogTransform(Bitmap image, double c = 1.0)
        {
            Bitmap result = new Bitmap(image.Width, image.Height);

            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color pixel = image.GetPixel(x, y);

                    // Log transform formula: s = c * log(1 + r)
                    int newR = (int)(c * Math.Log(1 + pixel.R));
                    int newG = (int)(c * Math.Log(1 + pixel.G));
                    int newB = (int)(c * Math.Log(1 + pixel.B));

                    newR = Math.Min(255, Math.Max(0, newR));
                    newG = Math.Min(255, Math.Max(0, newG));
                    newB = Math.Min(255, Math.Max(0, newB));

                    result.SetPixel(x, y, Color.FromArgb(newR, newG, newB));
                }
            }

            return result;
        }


        public static Bitmap ApplyPowerLawTransform(Bitmap image, double gamma = 2.2, double c = 1.0)
        {
            Bitmap result = new Bitmap(image.Width, image.Height);

            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color pixel = image.GetPixel(x, y);

                    // Power-law transform formula: s = c * (r^gamma)
                    int newR = (int)(c * Math.Pow(pixel.R / 255.0, gamma) * 255);
                    int newG = (int)(c * Math.Pow(pixel.G / 255.0, gamma) * 255);
                    int newB = (int)(c * Math.Pow(pixel.B / 255.0, gamma) * 255);

                    newR = Math.Min(255, Math.Max(0, newR));
                    newG = Math.Min(255, Math.Max(0, newG));
                    newB = Math.Min(255, Math.Max(0, newB));

                    result.SetPixel(x, y, Color.FromArgb(newR, newG, newB));
                }
            }

            return result;
        }

        public static Bitmap ApplyIdealHighPassFilter(Bitmap image, double cutoffFrequency = 50.0)
        {
            int width = image.Width;
            int height = image.Height;
            Bitmap grayImage = RgbToGray(image); // Convert image to grayscale for simplicity
            Complex[,] dft = FourierTransform(grayImage); // Perform Fourier Transform

            // Apply Ideal High Pass Filter
            int centerX = width / 2;
            int centerY = height / 2;

            for (int u = 0; u < width; u++)
            {
                for (int v = 0; v < height; v++)
                {
                    double distance = Math.Sqrt(Math.Pow(u - centerX, 2) + Math.Pow(v - centerY, 2));
                    if (distance <= cutoffFrequency)
                    {
                        dft[u, v] = Complex.Zero; // Zero out low frequencies
                    }
                }
            }

            Bitmap result = InverseFourierTransform(dft); // Perform Inverse Fourier Transform
            return result;
        }


        public static Bitmap ApplyButterWorthHighPassFilter(Bitmap image, double cutoffFrequency = 50.0, int order = 2)
        {
            int width = image.Width;
            int height = image.Height;
            Bitmap grayImage = RgbToGray(image); // Convert image to grayscale for simplicity
            Complex[,] dft = FourierTransform(grayImage); // Perform Fourier Transform

            // Apply Butterworth High Pass Filter
            int centerX = width / 2;
            int centerY = height / 2;

            for (int u = 0; u < width; u++)
            {
                for (int v = 0; v < height; v++)
                {
                    double distance = Math.Sqrt(Math.Pow(u - centerX, 2) + Math.Pow(v - centerY, 2));
                    double butterworthFilter = 1 / (1 + Math.Pow(cutoffFrequency / distance, 2 * order));
                    dft[u, v] *= butterworthFilter; // Apply filter coefficient
                }
            }

            Bitmap result = InverseFourierTransform(dft); // Perform Inverse Fourier Transform
            return result;
        }



        private static Complex[,] FourierTransform(Bitmap image)
        {
            int width = image.Width;
            int height = image.Height;
            Complex[,] dft = new Complex[width, height];

            for (int u = 0; u < width; u++)
            {
                for (int v = 0; v < height; v++)
                {
                    Complex sum = Complex.Zero;
                    for (int x = 0; x < width; x++)
                    {
                        for (int y = 0; y < height; y++)
                        {
                            double pixelValue = image.GetPixel(x, y).R; // Grayscale value
                            double angle = -2 * Math.PI * ((u * x / (double)width) + (v * y / (double)height));
                            sum += new Complex(pixelValue * Math.Cos(angle), pixelValue * Math.Sin(angle));
                        }
                    }
                    dft[u, v] = sum;
                }
            }

            return dft;
        }


        private static Bitmap InverseFourierTransform(Complex[,] dft)
        {
            int width = dft.GetLength(0);
            int height = dft.GetLength(1);
            Bitmap result = new Bitmap(width, height);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Complex sum = Complex.Zero;
                    for (int u = 0; u < width; u++)
                    {
                        for (int v = 0; v < height; v++)
                        {
                            double angle = 2 * Math.PI * ((u * x / (double)width) + (v * y / (double)height));
                            sum += dft[u, v] * new Complex(Math.Cos(angle), Math.Sin(angle));
                        }
                    }
                    int pixelValue = (int)(sum.Magnitude / (width * height));
                    pixelValue = Math.Min(255, Math.Max(0, pixelValue));
                    result.SetPixel(x, y, Color.FromArgb(pixelValue, pixelValue, pixelValue));
                }
            }

            return result;
        }

        public static Bitmap ApplyWeightFilter(Bitmap image)
        {
            // إعدادات الفلتر
            int filterSize = 3;  // حجم الفلتر (3x3)
            int offset = filterSize / 2;

            // تعريف مصفوفة الأوزان (وزن أعلى في المنتصف وأوزان أقل حوله)
            float[,] weightMatrix = new float[,]
            {
            { 0.0625f, 0.125f, 0.0625f },
            { 0.125f, 0.25f, 0.125f },
            { 0.0625f, 0.125f, 0.0625f }
            };

            Bitmap result = new Bitmap(image);
            for (int i = offset; i < image.Width - offset; i++)
            {
                for (int j = offset; j < image.Height - offset; j++)
                {
                    float r = 0, g = 0, b = 0;

                    // تطبيق الفلتر على المنطقة المحيطة بالبكسل الحالي
                    for (int x = -offset; x <= offset; x++)
                    {
                        for (int y = -offset; y <= offset; y++)
                        {
                            Color pixelColor = image.GetPixel(i + x, j + y);

                            // ضرب كل قيمة لونية في الوزن المناسب
                            r += pixelColor.R * weightMatrix[x + offset, y + offset];
                            g += pixelColor.G * weightMatrix[x + offset, y + offset];
                            b += pixelColor.B * weightMatrix[x + offset, y + offset];
                        }
                    }

                    // تعيين القيمة المعدلة للبكسل في الصورة الناتجة
                    result.SetPixel(i, j, Color.FromArgb((int)r, (int)g, (int)b));
                }
            }

            return result;
        }


        public static Bitmap ApplyLineSharpeningFilter(Bitmap original)
        {
            // Create a new bitmap to store the sharpened image
            Bitmap sharpenedImage = new Bitmap(original.Width, original.Height);

            // Define the sharpening kernel (a simple line sharpening filter)
            int[,] kernel = new int[,] {
            {  0, -1,  0 },
            { -1,  5, -1 },
            {  0, -1,  0 }
        };

            // Apply the kernel to the image
            for (int x = 1; x < original.Width - 1; x++)
            {
                for (int y = 1; y < original.Height - 1; y++)
                {
                    int r = 0, g = 0, b = 0;

                    // Apply the kernel to the 3x3 region
                    for (int dx = -1; dx <= 1; dx++)
                    {
                        for (int dy = -1; dy <= 1; dy++)
                        {
                            Color pixelColor = original.GetPixel(x + dx, y + dy);

                            r += pixelColor.R * kernel[dx + 1, dy + 1];
                            g += pixelColor.G * kernel[dx + 1, dy + 1];
                            b += pixelColor.B * kernel[dx + 1, dy + 1];
                        }
                    }

                    // Clamp the values to be within 0-255 range
                    r = Math.Min(Math.Max(r, 0), 255);
                    g = Math.Min(Math.Max(g, 0), 255);
                    b = Math.Min(Math.Max(b, 0), 255);

                    // Set the new pixel value
                    sharpenedImage.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            return sharpenedImage;
        }


        public static Bitmap ApplyPointDetectionFilter(Bitmap original)
        {
            // Create a new bitmap to store the filtered image
            Bitmap pointDetectedImage = new Bitmap(original.Width, original.Height);

            // Define a simple edge detection kernel (Sobel operator)
            int[,] kernel = new int[,] {
            { -1, -1, -1 },
            { -1,  8, -1 },
            { -1, -1, -1 }
        };

            // Apply the kernel to the image
            for (int x = 1; x < original.Width - 1; x++)
            {
                for (int y = 1; y < original.Height - 1; y++)
                {
                    int r = 0, g = 0, b = 0;

                    // Apply the kernel to the 3x3 region of the image
                    for (int dx = -1; dx <= 1; dx++)
                    {
                        for (int dy = -1; dy <= 1; dy++)
                        {
                            Color pixelColor = original.GetPixel(x + dx, y + dy);

                            r += pixelColor.R * kernel[dx + 1, dy + 1];
                            g += pixelColor.G * kernel[dx + 1, dy + 1];
                            b += pixelColor.B * kernel[dx + 1, dy + 1];
                        }
                    }

                    // Clamp the values to be within the 0-255 range
                    r = Math.Min(Math.Max(r, 0), 255);
                    g = Math.Min(Math.Max(g, 0), 255);
                    b = Math.Min(Math.Max(b, 0), 255);

                    // Set the new pixel value
                    pointDetectedImage.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            return pointDetectedImage;
        }

        public static Bitmap ApplyNegativeFilter(Bitmap original)
        {
            // Create a new bitmap to store the negative image
            Bitmap negativeImage = new Bitmap(original.Width, original.Height);

            // Iterate through each pixel in the original image
            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    // Get the color of the current pixel
                    Color pixelColor = original.GetPixel(x, y);

                    // Invert the color by subtracting each component from 255
                    int r = 255 - pixelColor.R;
                    int g = 255 - pixelColor.G;
                    int b = 255 - pixelColor.B;

                    // Set the new color for the pixel in the negative image
                    negativeImage.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            return negativeImage;
        }
    }


}
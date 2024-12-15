using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
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
        public static double Mean(Bitmap image)
        {
            long total = 0;
            int pixelCount = image.Width * image.Height;
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    total += image.GetPixel(x, y).R;
                }
            }
            return (double)total / pixelCount;
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

        //Gamma
        public static Bitmap AddGammaNoise(Bitmap inputImage, double shape = 2 , double scale = 20.0)
        {
            Random random = new Random();
            int width = inputImage.Width;
            int height = inputImage.Height;
            Bitmap outputImage = new Bitmap(inputImage);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixel = inputImage.GetPixel(x, y);

                    // Generate Gamma noise
                    double noise = 0;
                    for (int i = 0; i < shape; i++)
                    {
                        noise += -Math.Log(1 - random.NextDouble());
                    }
                    noise *= scale;

                    int r = Math.Clamp((int)(pixel.R + noise), 0, 255);
                    int g = Math.Clamp((int)(pixel.G + noise), 0, 255);
                    int b = Math.Clamp((int)(pixel.B + noise), 0, 255);

                    outputImage.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            return outputImage;
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


    }
}
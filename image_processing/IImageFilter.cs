using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace image_processing
{
    public interface IImageFilter
    {
        Bitmap ApplyFilter(Bitmap image);
    }
    public class PrewittFilter : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap image)
        {
            return ImageProcessingUtils.ApplyPrewittFilter(image);
        }
    }

    public class LaplacianFilter : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap image)
        {
            return ImageProcessingUtils.LaplacianFilter(image);
        }
    }

    public class GrayToBinaryFilter : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap image)
        {
            return ImageProcessingUtils.GrayToBinary(image);
        }
    }

    public class RgbToGrayFilter : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap image)
        {
            return ImageProcessingUtils.RgbToGray(image);
        }
    }

    public class MedianFilter : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap image)
        {
            return ImageProcessingUtils.ApplyMedianFilter(image);
        }
    }

    public class SobelFilter : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap image)
        {
            return ImageProcessingUtils.ApplySobelFilter(image);
        }
    }

    public class ContrastStretchFilter : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap image)
        {
            return ImageProcessingUtils.ContrastStretch(image);
        }
    }

    public class HistogramEqualizationFilter : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap image)
        {
            return ImageProcessingUtils.HistogramEqualization(image);
        }
    }
public class DarkenFilter : IImageFilter
{
    public Bitmap ApplyFilter(Bitmap image)
    {
        return ImageProcessingUtils.ApplyDecreaseBrightnessFilter(image);
    }
}

public class LightenFilter : IImageFilter
{
    public Bitmap ApplyFilter(Bitmap image)
    {
        return ImageProcessingUtils.ApplyIncreaseBrightnessFilter(image);
    }
}
    public class GaussianFilter : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap image)
        {
            return ImageProcessingUtils.ApplyGaussianFilter(image);
        }
    }

    public class GaussianLowPassFilter : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap image)
        {
            return ImageProcessingUtils.ApplyIdealLowPassFilter(image);
        }
    }
    public class GaussianHighPassFilter : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap image)
        {
            return ImageProcessingUtils.ApplyGaussianHighPassFilter(image);
        }
    }
    public class GammaFilter : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap image)
        {
            return ImageProcessingUtils.AddGammaNoise(image);
        }
    }
    public class ButterworthLowPassFilter : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap image)
        {
            return ImageProcessingUtils.ApplyButterworthLowPassFilter(image);
        }
    }
}

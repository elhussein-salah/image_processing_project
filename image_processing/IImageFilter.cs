using System;
using System.Drawing;

namespace image_processing
{
    public interface IImageFilter
    {
        Bitmap ApplyFilter(Bitmap image);
    }

    // Existing Filters
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

    // New Filters
    public class PointSharpeningFilter : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap image)
        {
            return ImageProcessingUtils.ApplyPointSharpening(image);
        }
    }

    public class LineDetectionFilter : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap image)
        {
            return ImageProcessingUtils.ApplyLineDetection(image);
        }
    }

    public class MidPointFilter : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap image)
        {
            return ImageProcessingUtils.ApplyMidPointFilter(image);
        }
    }

    public class FourierTransformFilter : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap image)
        {
            return ImageProcessingUtils.ApplyFourierTransform(image);
        }
    }

    public class InverseFourierFilter : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap image)
        {
            return ImageProcessingUtils.ApplyInverseFourierTransform(image);
        }
    }

    public class IdealLowPassFilter : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap image)
        {
            return ImageProcessingUtils.ApplyIdealLowPassFilter(image);
        }
    }

    public class IdealHighPassFilter : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap image)
        {
            return ImageProcessingUtils.ApplyIdealHighPassFilter(image);
        }
    }

    public class ButterWorthLowPassFilter : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap image)
        {
            return ImageProcessingUtils.ApplyButterworthLowPassFilter(image);
        }
    }

    public class ButterWorthHighPassFilter : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap image)
        {
            return ImageProcessingUtils.ApplyButterWorthHighPassFilter(image);
        }
    }

    public class SaltPepperNoiseFilter : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap image)
        {
            return ImageProcessingUtils.AddSaltAndPepperNoise(image);
        }
    }

    public class UniformNoiseFilter : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap image)
        {
            return ImageProcessingUtils.AddUniformNoise(image);
        }
    }

    public class GaussianNoiseFilter : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap image)
        {
            return ImageProcessingUtils.ApplyGaussianNoise(image);
        }
    }

    public class RayleighNoiseFilter : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap image)
        {
            return ImageProcessingUtils.ApplyRayleighNoise(image);
        }
    }

    public class ExponentialNoiseFilter : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap image)
        {
            return ImageProcessingUtils.ApplyExponentialNoise(image);
        }
    }

    public class GammaNoiseFilter : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap image)
        {
            return ImageProcessingUtils.AddGammaNoise(image);
        }
    }

    // Additional New Filters
    public class MinFilter : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap image)
        {
            return ImageProcessingUtils.ApplyMinFilter(image);
        }
    }

    public class MaxFilter : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap image)
        {
            return ImageProcessingUtils.ApplyMaxFilter(image);
        }
    }

    //public class MedianFilterAdvanced : IImageFilter
    //{
    //    public Bitmap ApplyFilter(Bitmap image)
    //    {
    //        return ImageProcessingUtils.ApplyMedianFilterAdvanced(image);
    //    }
    //}

    public class HighBoostFilter : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap image)
        {
            return ImageProcessingUtils.ApplyHighBoostFilter(image);
        }
    }

    public class LogTransformFilter : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap image)
        {
            return ImageProcessingUtils.ApplyLogTransform(image);
        }
    }

    public class PowerLawTransformFilter : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap image)
        {
            return ImageProcessingUtils.ApplyPowerLawTransform(image);
        }
    }
    public class MeanFilter : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap image)
        {
            return ImageProcessingUtils.ApplyMeanFilter(image);
        }
    }
    public class WeightFilter : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap image)
        {
            return ImageProcessingUtils.ApplyWeightFilter(image);
        }
    }

    public class LineSharpeningFilter : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap image)
        {
            return ImageProcessingUtils.ApplyLineSharpeningFilter(image);
        }
    }

    public class PointDetectionFilter : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap image)
        {
            return ImageProcessingUtils.ApplyPointDetectionFilter(image);
        }
    }

    public class NegativeFilter : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap image)
        {
            return ImageProcessingUtils.ApplyNegativeFilter(image);
        }
    }

    public class GammaCorrectionFilter : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap image)
        {
            return ImageProcessingUtils.ApplyPowerLawTransform(image);
        }
    }
}

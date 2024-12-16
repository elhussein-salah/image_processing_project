using System;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Collections.Generic;
using System.Threading.Tasks;
using Emgu.CV.Cuda;
namespace image_processing
{
    public partial class Form1 : Form
    {
        Bitmap temp;
        private Stack<Bitmap> undoStack = new Stack<Bitmap>();

        // Stack لحفظ النسخ التي تم التراجع عنها (Redo)
        private Stack<Bitmap> redoStack = new Stack<Bitmap>();

        private Dictionary<RadioButton, IImageFilter> filters;
        public Form1()
        {
            InitializeComponent();

            filters = new Dictionary<RadioButton, IImageFilter>
            {
                //{ prewittFilterRadioBtn, new PrewittFilter() },
                //{ LaplacianRadiobtn, new LaplacianFilter() },
                //{ GrayToBinaryRediobtn, new GrayToBinaryFilter() },
                //{ RgbToGrayRediobtn, new RgbToGrayFilter() },
                //{ medianRadioBtn, new MedianFilter() },
                //{ SobelFilterRadioBtn, new SobelFilter() },
                //{ CERadioBtn, new ContrastStretchFilter() },
                //{ HERadioBtn, new HistogramEqualizationFilter() },
                //{ lightenRedioBtn, new LightenFilter() },
                //{ darkenRadioBtn, new DarkenFilter() },
                //{blurGaussianRadioButton,new GaussianFilter()},
                //new
                // Existing Filters
                { prewittFilterRadioBtn, new PrewittFilter() },
                { contrastStretchingRadioBtn, new ContrastStretchFilter() },
                { laplacianFilterRadioBtn, new LaplacianFilter() },
                { grayToBinaryRadioBtn, new GrayToBinaryFilter() },
                { rgbToGrayRadioBtn, new RgbToGrayFilter() },
                { gaussianFilterRadioBtn, new GaussianFilter() },
                { sobelFilterRadioBtn, new SobelFilter() },
                { histogramEqualizationRadioBtn, new HistogramEqualizationFilter() },
                { lightenRadioBtn, new LightenFilter() },
                { darkenRadioBtn, new DarkenFilter() },
                { medianFilterRadioBtn, new MedianFilter() },
                { meanFilterRadioBtn, new MeanFilter() },
                { weightFilterRadioBtn, new WeightFilter() },
                { pointDetectionRadioBtn, new PointDetectionFilter() },
                { pointSharpeningRadioBtn, new PointSharpeningFilter() },
                { lineSharpeningRadioBtn, new LineSharpeningFilter() },
                { minFilterRadioBtn, new MinFilter() },
                { uniformNoiseRadioBtn, new UniformNoiseFilter() },
                { gaussianNoiseRadioBtn, new GaussianNoiseFilter() },

                // New Filters (advanced)
                { negativeRadioBtn, new NegativeFilter() },
                //{ histogramRadioBtn, new HistogramFilter() },
                { logTransformRadioBtn, new LogTransformFilter() },
                { gammaCorrectionRadioBtn, new GammaCorrectionFilter() },
                //{ correlationRadioBtn, new CorrelationFilter() },
                { maxFilterRadioBtn, new MaxFilter() },
                { fourierTransformRadioBtn, new FourierTransformFilter() },
                { inverseFourierRadioBtn, new InverseFourierFilter() },
                { idealLowPassRadioBtn, new IdealLowPassFilter() },
                { idealHighPassRadioBtn, new IdealHighPassFilter() },
                { butterWorthLowPassRadioBtn, new ButterWorthLowPassFilter() },
                { butterWorthHighPassRadioBtn, new ButterWorthHighPassFilter() },
                { gaussianLowPassRadioBtn, new GaussianLowPassFilter() },
                { gaussianHighPassRadioBtn, new GaussianHighPassFilter() },
                { saltPepperNoiseRadioBtn, new SaltPepperNoiseFilter() },
                { rayleighNoiseRadioBtn, new RayleighNoiseFilter() },
                { exponentialNoiseRadioBtn, new ExponentialNoiseFilter() },
                { gammaNoiseRadioBtn, new GammaNoiseFilter() }

            };
        }



        private void Apply_Filter(object sender, EventArgs e)
        {
            if (undoStack.Count == 0)
                undoStack.Push((Bitmap)pictureBox1.Image);

            if (undoStack.Count > 0)
            {


                // Find the selected filter
                var activeFilter = filters.FirstOrDefault(f => f.Key.Checked).Value;

                if (activeFilter != null)
                {
                    temp = undoStack.Peek();
                    temp = activeFilter.ApplyFilter(temp);
                    undoStack.Push(temp);
                    redoStack.Clear();
                    pictureBox2.Image = temp;
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    MessageBox.Show("Please select a filter to apply.");
                }
            }
            else if (undoStack.Peek() == null)
            {
                MessageBox.Show("Please load an image first.");
            }
        }
        private void redoBtn_Click(object sender, EventArgs e)
        {
            if (redoStack.Count > 0)
            {
                undoStack.Push(redoStack.Pop()); // نقل الصورة الحالية إلى undoStack
                pictureBox2.Image = undoStack.Peek(); // عرض الصورة الجديدة من undoStack
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                MessageBox.Show("No more actions to redo.");
            }
        }

        private void undoBtn_Click(object sender, EventArgs e)
        {
            if (undoStack.Count > 1) // تأكد من وجود أكثر من صورة في الـ undoStack
            {
                redoStack.Push(undoStack.Pop()); // نقل الصورة الحالية إلى redoStack
                pictureBox2.Image = undoStack.Peek(); // عرض الصورة التالية في undoStack
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (undoStack.Count == 1) // إذا بقيت صورة واحدة فقط
            {
                MessageBox.Show("You have reached the original image."); // تحذير للمستخدم
                pictureBox2.Image = undoStack.Peek(); // عرض الصورة الأصلية
            }
            else
            {
                MessageBox.Show("No more actions to undo."); // إذا كان الـ undoStack فارغًا
            }
        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            // تحميل صورة باستخدام FileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.tif"
            };

            // Show the dialog and check if a file was selected
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file's path
                string filePath = openFileDialog.FileName;

                // Assign the file path to the textbox
                imagePath.Text = filePath;
                pictureBox1.ImageLocation = filePath;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                undoStack.Clear();
                redoStack.Clear();
                //undoStack.Push((Bitmap)pictureBox1.Image);

            }
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            // تأكد أن هناك صورة في PictureBox2
            if (pictureBox2.Image != null)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.tif";
                    saveFileDialog.Title = "Save an Image File";

                    // عرض الـ SaveFileDialog
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            // حفظ الصورة باستخدام المسار المحدد
                            pictureBox2.Image.Save(saveFileDialog.FileName);
                            MessageBox.Show("Image saved successfully!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred: {ex.Message}");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No image to export. Please apply a filter first.");
            }
        }

        private void medianRadioBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CERadioBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SobelFilterRadioBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rjRadioButton21_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void imagePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjRadioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rjRadioButton17_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void rjRadioButton23_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GrayToBinaryRediobtn_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

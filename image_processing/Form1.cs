using System;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Collections.Generic;
using System.Threading.Tasks;
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
                { prewittFilterRadioBtn, new PrewittFilter() },
                { LaplacianRadiobtn, new LaplacianFilter() },
                { GrayToBinaryRediobtn, new GrayToBinaryFilter() },
                { RgbToGrayRediobtn, new RgbToGrayFilter() },
                { medianRadioBtn, new MedianFilter() },
                { SobelFilterRadioBtn, new SobelFilter() },
                { CERadioBtn, new ContrastStretchFilter() },
                { HERadioBtn, new HistogramEqualizationFilter() },
                { lightenRedioBtn, new LightenFilter() },
                { darkenRadioBtn, new DarkenFilter() },
                {blurGaussianRadioButton,new GaussianFilter()}

            };
        }



        private void button3_Click(object sender, EventArgs e)
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
    }
}

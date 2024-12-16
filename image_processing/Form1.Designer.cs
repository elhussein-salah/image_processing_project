namespace image_processing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            button4 = new Button();
            groupBox1 = new GroupBox();
            button3 = new Button();
            gammaNoiseRadioBtn = new CustomControls.RJControls.RJRadioButton();
            exponentialNoiseRadioBtn = new CustomControls.RJControls.RJRadioButton();
            uniformNoiseRadioBtn = new CustomControls.RJControls.RJRadioButton();
            gaussianNoiseRadioBtn = new CustomControls.RJControls.RJRadioButton();
            textBox1 = new TextBox();
            idealLowPassRadioBtn = new CustomControls.RJControls.RJRadioButton();
            imagePath = new TextBox();
            btnImport = new Button();
            button1 = new Button();
            butterWorthLowPassRadioBtn = new CustomControls.RJControls.RJRadioButton();
            idealHighPassRadioBtn = new CustomControls.RJControls.RJRadioButton();
            maxFilterRadioBtn = new CustomControls.RJControls.RJRadioButton();
            gaussianLowPassRadioBtn = new CustomControls.RJControls.RJRadioButton();
            gaussianHighPassRadioBtn = new CustomControls.RJControls.RJRadioButton();
            saltPepperNoiseRadioBtn = new CustomControls.RJControls.RJRadioButton();
            inverseFourierRadioBtn = new CustomControls.RJControls.RJRadioButton();
            fourierTransformRadioBtn = new CustomControls.RJControls.RJRadioButton();
            pointSharpeningRadioBtn = new CustomControls.RJControls.RJRadioButton();
            lineSharpeningRadioBtn = new CustomControls.RJControls.RJRadioButton();
            gammaCorrectionRadioBtn = new CustomControls.RJControls.RJRadioButton();
            rjRadioButton12 = new CustomControls.RJControls.RJRadioButton();
            rjRadioButton5 = new CustomControls.RJControls.RJRadioButton();
            logTransformRadioBtn = new CustomControls.RJControls.RJRadioButton();
            histogramRadioBtn = new CustomControls.RJControls.RJRadioButton();
            negativeRadioBtn = new CustomControls.RJControls.RJRadioButton();
            weightFilterRadioBtn = new CustomControls.RJControls.RJRadioButton();
            rayleighNoiseRadioBtn = new CustomControls.RJControls.RJRadioButton();
            minFilterRadioBtn = new CustomControls.RJControls.RJRadioButton();
            histogramEqualizationRadioBtn = new CustomControls.RJControls.RJRadioButton();
            pointDetectionRadioBtn = new CustomControls.RJControls.RJRadioButton();
            butterWorthHighPassRadioBtn = new CustomControls.RJControls.RJRadioButton();
            lightenRadioBtn = new CustomControls.RJControls.RJRadioButton();
            darkenRadioBtn = new CustomControls.RJControls.RJRadioButton();
            prewittFilterRadioBtn = new CustomControls.RJControls.RJRadioButton();
            rgbToGrayRadioBtn = new CustomControls.RJControls.RJRadioButton();
            contrastStretchingRadioBtn = new CustomControls.RJControls.RJRadioButton();
            laplacianFilterRadioBtn = new CustomControls.RJControls.RJRadioButton();
            grayToBinaryRadioBtn = new CustomControls.RJControls.RJRadioButton();
            meanFilterRadioBtn = new CustomControls.RJControls.RJRadioButton();
            medianFilterRadioBtn = new CustomControls.RJControls.RJRadioButton();
            gaussianFilterRadioBtn = new CustomControls.RJControls.RJRadioButton();
            sobelFilterRadioBtn = new CustomControls.RJControls.RJRadioButton();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(757, 379);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(663, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(763, 913);
            panel2.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(3, 384);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(757, 378);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Showcard Gothic", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(322, 637);
            button2.Name = "button2";
            button2.Size = new Size(313, 63);
            button2.TabIndex = 14;
            button2.Text = "Undo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += undoBtn_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Showcard Gothic", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(3, 637);
            button4.Name = "button4";
            button4.Size = new Size(316, 63);
            button4.TabIndex = 15;
            button4.Text = "Redo";
            button4.UseVisualStyleBackColor = true;
            button4.Click += redoBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LavenderBlush;
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(gammaNoiseRadioBtn);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(exponentialNoiseRadioBtn);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(uniformNoiseRadioBtn);
            groupBox1.Controls.Add(gaussianNoiseRadioBtn);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(idealLowPassRadioBtn);
            groupBox1.Controls.Add(imagePath);
            groupBox1.Controls.Add(btnImport);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(butterWorthLowPassRadioBtn);
            groupBox1.Controls.Add(idealHighPassRadioBtn);
            groupBox1.Controls.Add(maxFilterRadioBtn);
            groupBox1.Controls.Add(gaussianLowPassRadioBtn);
            groupBox1.Controls.Add(gaussianHighPassRadioBtn);
            groupBox1.Controls.Add(saltPepperNoiseRadioBtn);
            groupBox1.Controls.Add(inverseFourierRadioBtn);
            groupBox1.Controls.Add(fourierTransformRadioBtn);
            groupBox1.Controls.Add(pointSharpeningRadioBtn);
            groupBox1.Controls.Add(lineSharpeningRadioBtn);
            groupBox1.Controls.Add(gammaCorrectionRadioBtn);
            groupBox1.Controls.Add(rjRadioButton12);
            groupBox1.Controls.Add(rjRadioButton5);
            groupBox1.Controls.Add(logTransformRadioBtn);
            groupBox1.Controls.Add(histogramRadioBtn);
            groupBox1.Controls.Add(negativeRadioBtn);
            groupBox1.Controls.Add(weightFilterRadioBtn);
            groupBox1.Controls.Add(rayleighNoiseRadioBtn);
            groupBox1.Controls.Add(minFilterRadioBtn);
            groupBox1.Controls.Add(histogramEqualizationRadioBtn);
            groupBox1.Controls.Add(pointDetectionRadioBtn);
            groupBox1.Controls.Add(butterWorthHighPassRadioBtn);
            groupBox1.Controls.Add(lightenRadioBtn);
            groupBox1.Controls.Add(darkenRadioBtn);
            groupBox1.Controls.Add(prewittFilterRadioBtn);
            groupBox1.Controls.Add(rgbToGrayRadioBtn);
            groupBox1.Controls.Add(contrastStretchingRadioBtn);
            groupBox1.Controls.Add(laplacianFilterRadioBtn);
            groupBox1.Controls.Add(grayToBinaryRadioBtn);
            groupBox1.Controls.Add(meanFilterRadioBtn);
            groupBox1.Controls.Add(medianFilterRadioBtn);
            groupBox1.Controls.Add(gaussianFilterRadioBtn);
            groupBox1.Controls.Add(sobelFilterRadioBtn);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(3, -13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(657, 926);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // button3
            // 
            button3.Font = new Font("Stencil", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(1, 706);
            button3.Name = "button3";
            button3.Size = new Size(626, 55);
            button3.TabIndex = 16;
            button3.Text = "Apply Filter ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Apply_Filter;
            // 
            // gammaNoiseRadioBtn
            // 
            gammaNoiseRadioBtn.AutoSize = true;
            gammaNoiseRadioBtn.CheckedColor = Color.Purple;
            gammaNoiseRadioBtn.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            gammaNoiseRadioBtn.ForeColor = Color.Black;
            gammaNoiseRadioBtn.Location = new Point(346, 541);
            gammaNoiseRadioBtn.MinimumSize = new Size(0, 21);
            gammaNoiseRadioBtn.Name = "gammaNoiseRadioBtn";
            gammaNoiseRadioBtn.Padding = new Padding(10, 0, 0, 0);
            gammaNoiseRadioBtn.Size = new Size(142, 26);
            gammaNoiseRadioBtn.TabIndex = 37;
            gammaNoiseRadioBtn.TabStop = true;
            gammaNoiseRadioBtn.Text = "Gamma_noise";
            gammaNoiseRadioBtn.UnCheckedColor = Color.Black;
            gammaNoiseRadioBtn.UseVisualStyleBackColor = true;
            // 
            // exponentialNoiseRadioBtn
            // 
            exponentialNoiseRadioBtn.AutoSize = true;
            exponentialNoiseRadioBtn.CheckedColor = Color.Purple;
            exponentialNoiseRadioBtn.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            exponentialNoiseRadioBtn.ForeColor = Color.Black;
            exponentialNoiseRadioBtn.Location = new Point(346, 518);
            exponentialNoiseRadioBtn.MinimumSize = new Size(0, 21);
            exponentialNoiseRadioBtn.Name = "exponentialNoiseRadioBtn";
            exponentialNoiseRadioBtn.Padding = new Padding(10, 0, 0, 0);
            exponentialNoiseRadioBtn.Size = new Size(174, 26);
            exponentialNoiseRadioBtn.TabIndex = 34;
            exponentialNoiseRadioBtn.TabStop = true;
            exponentialNoiseRadioBtn.Text = "Exponential_noise";
            exponentialNoiseRadioBtn.UnCheckedColor = Color.Black;
            exponentialNoiseRadioBtn.UseVisualStyleBackColor = true;
            exponentialNoiseRadioBtn.CheckedChanged += rjRadioButton23_CheckedChanged;
            // 
            // uniformNoiseRadioBtn
            // 
            uniformNoiseRadioBtn.AutoSize = true;
            uniformNoiseRadioBtn.CheckedColor = Color.Purple;
            uniformNoiseRadioBtn.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            uniformNoiseRadioBtn.ForeColor = Color.Black;
            uniformNoiseRadioBtn.Location = new Point(0, 493);
            uniformNoiseRadioBtn.MinimumSize = new Size(0, 21);
            uniformNoiseRadioBtn.Name = "uniformNoiseRadioBtn";
            uniformNoiseRadioBtn.Padding = new Padding(10, 0, 0, 0);
            uniformNoiseRadioBtn.Size = new Size(146, 26);
            uniformNoiseRadioBtn.TabIndex = 36;
            uniformNoiseRadioBtn.TabStop = true;
            uniformNoiseRadioBtn.Text = "uniform_noise";
            uniformNoiseRadioBtn.UnCheckedColor = Color.Black;
            uniformNoiseRadioBtn.UseVisualStyleBackColor = true;
            // 
            // gaussianNoiseRadioBtn
            // 
            gaussianNoiseRadioBtn.AutoSize = true;
            gaussianNoiseRadioBtn.CheckedColor = Color.Purple;
            gaussianNoiseRadioBtn.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            gaussianNoiseRadioBtn.ForeColor = Color.Black;
            gaussianNoiseRadioBtn.Location = new Point(0, 525);
            gaussianNoiseRadioBtn.MinimumSize = new Size(0, 21);
            gaussianNoiseRadioBtn.Name = "gaussianNoiseRadioBtn";
            gaussianNoiseRadioBtn.Padding = new Padding(10, 0, 0, 0);
            gaussianNoiseRadioBtn.Size = new Size(149, 26);
            gaussianNoiseRadioBtn.TabIndex = 35;
            gaussianNoiseRadioBtn.TabStop = true;
            gaussianNoiseRadioBtn.Text = "gaussian_noise";
            gaussianNoiseRadioBtn.UnCheckedColor = Color.Black;
            gaussianNoiseRadioBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(314, 608);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(313, 23);
            textBox1.TabIndex = 13;
            // 
            // idealLowPassRadioBtn
            // 
            idealLowPassRadioBtn.AutoSize = true;
            idealLowPassRadioBtn.CheckedColor = Color.Purple;
            idealLowPassRadioBtn.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            idealLowPassRadioBtn.ForeColor = Color.Black;
            idealLowPassRadioBtn.Location = new Point(346, 307);
            idealLowPassRadioBtn.MinimumSize = new Size(0, 21);
            idealLowPassRadioBtn.Name = "idealLowPassRadioBtn";
            idealLowPassRadioBtn.Padding = new Padding(10, 0, 0, 0);
            idealLowPassRadioBtn.Size = new Size(197, 26);
            idealLowPassRadioBtn.TabIndex = 24;
            idealLowPassRadioBtn.TabStop = true;
            idealLowPassRadioBtn.Text = "Ideal Low Pass Filter";
            idealLowPassRadioBtn.UnCheckedColor = Color.Black;
            idealLowPassRadioBtn.UseVisualStyleBackColor = true;
            // 
            // imagePath
            // 
            imagePath.Location = new Point(-2, 608);
            imagePath.Name = "imagePath";
            imagePath.Size = new Size(316, 23);
            imagePath.TabIndex = 10;
            imagePath.TextChanged += imagePath_TextChanged;
            // 
            // btnImport
            // 
            btnImport.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnImport.Location = new Point(-3, 568);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(316, 34);
            btnImport.TabIndex = 6;
            btnImport.Text = "import";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += importBtn_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(314, 568);
            button1.Name = "button1";
            button1.Size = new Size(316, 34);
            button1.TabIndex = 12;
            button1.Text = "export";
            button1.UseVisualStyleBackColor = true;
            button1.Click += exportBtn_Click;
            // 
            // butterWorthLowPassRadioBtn
            // 
            butterWorthLowPassRadioBtn.AutoSize = true;
            butterWorthLowPassRadioBtn.CheckedColor = Color.Purple;
            butterWorthLowPassRadioBtn.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            butterWorthLowPassRadioBtn.ForeColor = Color.Black;
            butterWorthLowPassRadioBtn.Location = new Point(346, 369);
            butterWorthLowPassRadioBtn.MinimumSize = new Size(0, 21);
            butterWorthLowPassRadioBtn.Name = "butterWorthLowPassRadioBtn";
            butterWorthLowPassRadioBtn.Padding = new Padding(10, 0, 0, 0);
            butterWorthLowPassRadioBtn.Size = new Size(261, 26);
            butterWorthLowPassRadioBtn.TabIndex = 22;
            butterWorthLowPassRadioBtn.TabStop = true;
            butterWorthLowPassRadioBtn.Text = "Butter Worth Low Pass Filter";
            butterWorthLowPassRadioBtn.UnCheckedColor = Color.Black;
            butterWorthLowPassRadioBtn.UseVisualStyleBackColor = true;
            // 
            // idealHighPassRadioBtn
            // 
            idealHighPassRadioBtn.AutoSize = true;
            idealHighPassRadioBtn.CheckedColor = Color.Purple;
            idealHighPassRadioBtn.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            idealHighPassRadioBtn.ForeColor = Color.Black;
            idealHighPassRadioBtn.Location = new Point(346, 338);
            idealHighPassRadioBtn.MinimumSize = new Size(0, 21);
            idealHighPassRadioBtn.Name = "idealHighPassRadioBtn";
            idealHighPassRadioBtn.Padding = new Padding(10, 0, 0, 0);
            idealHighPassRadioBtn.Size = new Size(202, 26);
            idealHighPassRadioBtn.TabIndex = 23;
            idealHighPassRadioBtn.TabStop = true;
            idealHighPassRadioBtn.Text = "Ideal High Pass Filter";
            idealHighPassRadioBtn.UnCheckedColor = Color.Black;
            idealHighPassRadioBtn.UseVisualStyleBackColor = true;
            // 
            // maxFilterRadioBtn
            // 
            maxFilterRadioBtn.AutoSize = true;
            maxFilterRadioBtn.CheckedColor = Color.Purple;
            maxFilterRadioBtn.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            maxFilterRadioBtn.ForeColor = Color.Black;
            maxFilterRadioBtn.Location = new Point(346, 209);
            maxFilterRadioBtn.MinimumSize = new Size(0, 21);
            maxFilterRadioBtn.Name = "maxFilterRadioBtn";
            maxFilterRadioBtn.Padding = new Padding(10, 0, 0, 0);
            maxFilterRadioBtn.Size = new Size(118, 26);
            maxFilterRadioBtn.TabIndex = 25;
            maxFilterRadioBtn.TabStop = true;
            maxFilterRadioBtn.Text = "Max Filter";
            maxFilterRadioBtn.UnCheckedColor = Color.Black;
            maxFilterRadioBtn.UseVisualStyleBackColor = true;
            // 
            // gaussianLowPassRadioBtn
            // 
            gaussianLowPassRadioBtn.AutoSize = true;
            gaussianLowPassRadioBtn.CheckedColor = Color.Purple;
            gaussianLowPassRadioBtn.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            gaussianLowPassRadioBtn.ForeColor = Color.Black;
            gaussianLowPassRadioBtn.Location = new Point(346, 422);
            gaussianLowPassRadioBtn.MinimumSize = new Size(0, 21);
            gaussianLowPassRadioBtn.Name = "gaussianLowPassRadioBtn";
            gaussianLowPassRadioBtn.Padding = new Padding(10, 0, 0, 0);
            gaussianLowPassRadioBtn.Size = new Size(226, 26);
            gaussianLowPassRadioBtn.TabIndex = 27;
            gaussianLowPassRadioBtn.TabStop = true;
            gaussianLowPassRadioBtn.Text = "Gaussian Low Pass Filter";
            gaussianLowPassRadioBtn.UnCheckedColor = Color.Black;
            gaussianLowPassRadioBtn.UseVisualStyleBackColor = true;
            // 
            // gaussianHighPassRadioBtn
            // 
            gaussianHighPassRadioBtn.AutoSize = true;
            gaussianHighPassRadioBtn.CheckedColor = Color.Purple;
            gaussianHighPassRadioBtn.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            gaussianHighPassRadioBtn.ForeColor = Color.Black;
            gaussianHighPassRadioBtn.Location = new Point(346, 444);
            gaussianHighPassRadioBtn.MinimumSize = new Size(0, 21);
            gaussianHighPassRadioBtn.Name = "gaussianHighPassRadioBtn";
            gaussianHighPassRadioBtn.Padding = new Padding(10, 0, 0, 0);
            gaussianHighPassRadioBtn.Size = new Size(231, 26);
            gaussianHighPassRadioBtn.TabIndex = 28;
            gaussianHighPassRadioBtn.TabStop = true;
            gaussianHighPassRadioBtn.Text = "Gaussian High Pass Filter";
            gaussianHighPassRadioBtn.UnCheckedColor = Color.Black;
            gaussianHighPassRadioBtn.UseVisualStyleBackColor = true;
            // 
            // saltPepperNoiseRadioBtn
            // 
            saltPepperNoiseRadioBtn.AutoSize = true;
            saltPepperNoiseRadioBtn.CheckedColor = Color.Purple;
            saltPepperNoiseRadioBtn.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            saltPepperNoiseRadioBtn.ForeColor = Color.Black;
            saltPepperNoiseRadioBtn.Location = new Point(346, 467);
            saltPepperNoiseRadioBtn.MinimumSize = new Size(0, 21);
            saltPepperNoiseRadioBtn.Name = "saltPepperNoiseRadioBtn";
            saltPepperNoiseRadioBtn.Padding = new Padding(10, 0, 0, 0);
            saltPepperNoiseRadioBtn.Size = new Size(125, 26);
            saltPepperNoiseRadioBtn.TabIndex = 29;
            saltPepperNoiseRadioBtn.TabStop = true;
            saltPepperNoiseRadioBtn.Text = "salt & pepper";
            saltPepperNoiseRadioBtn.UnCheckedColor = Color.Black;
            saltPepperNoiseRadioBtn.UseVisualStyleBackColor = true;
            // 
            // inverseFourierRadioBtn
            // 
            inverseFourierRadioBtn.AutoSize = true;
            inverseFourierRadioBtn.CheckedColor = Color.Purple;
            inverseFourierRadioBtn.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            inverseFourierRadioBtn.ForeColor = Color.Black;
            inverseFourierRadioBtn.Location = new Point(346, 271);
            inverseFourierRadioBtn.MinimumSize = new Size(0, 21);
            inverseFourierRadioBtn.Name = "inverseFourierRadioBtn";
            inverseFourierRadioBtn.Padding = new Padding(10, 0, 0, 0);
            inverseFourierRadioBtn.Size = new Size(236, 26);
            inverseFourierRadioBtn.TabIndex = 10;
            inverseFourierRadioBtn.TabStop = true;
            inverseFourierRadioBtn.Text = "Inverse Fourier Transform";
            inverseFourierRadioBtn.UnCheckedColor = Color.Black;
            inverseFourierRadioBtn.UseVisualStyleBackColor = true;
            // 
            // fourierTransformRadioBtn
            // 
            fourierTransformRadioBtn.AutoSize = true;
            fourierTransformRadioBtn.CheckedColor = Color.Purple;
            fourierTransformRadioBtn.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            fourierTransformRadioBtn.ForeColor = Color.Black;
            fourierTransformRadioBtn.Location = new Point(346, 240);
            fourierTransformRadioBtn.MinimumSize = new Size(0, 21);
            fourierTransformRadioBtn.Name = "fourierTransformRadioBtn";
            fourierTransformRadioBtn.Padding = new Padding(10, 0, 0, 0);
            fourierTransformRadioBtn.Size = new Size(177, 26);
            fourierTransformRadioBtn.TabIndex = 12;
            fourierTransformRadioBtn.TabStop = true;
            fourierTransformRadioBtn.Text = "Fourier Transform";
            fourierTransformRadioBtn.UnCheckedColor = Color.Black;
            fourierTransformRadioBtn.UseVisualStyleBackColor = true;
            // 
            // pointSharpeningRadioBtn
            // 
            pointSharpeningRadioBtn.AutoSize = true;
            pointSharpeningRadioBtn.CheckedColor = Color.Purple;
            pointSharpeningRadioBtn.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            pointSharpeningRadioBtn.ForeColor = Color.Black;
            pointSharpeningRadioBtn.Location = new Point(5, 397);
            pointSharpeningRadioBtn.MinimumSize = new Size(0, 21);
            pointSharpeningRadioBtn.Name = "pointSharpeningRadioBtn";
            pointSharpeningRadioBtn.Padding = new Padding(10, 0, 0, 0);
            pointSharpeningRadioBtn.Size = new Size(166, 26);
            pointSharpeningRadioBtn.TabIndex = 33;
            pointSharpeningRadioBtn.TabStop = true;
            pointSharpeningRadioBtn.Text = "Point Sharpening";
            pointSharpeningRadioBtn.UnCheckedColor = Color.Black;
            pointSharpeningRadioBtn.UseVisualStyleBackColor = true;
            // 
            // lineSharpeningRadioBtn
            // 
            lineSharpeningRadioBtn.AutoSize = true;
            lineSharpeningRadioBtn.CheckedColor = Color.Purple;
            lineSharpeningRadioBtn.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            lineSharpeningRadioBtn.ForeColor = Color.Black;
            lineSharpeningRadioBtn.Location = new Point(4, 429);
            lineSharpeningRadioBtn.MinimumSize = new Size(0, 21);
            lineSharpeningRadioBtn.Name = "lineSharpeningRadioBtn";
            lineSharpeningRadioBtn.Padding = new Padding(10, 0, 0, 0);
            lineSharpeningRadioBtn.Size = new Size(157, 26);
            lineSharpeningRadioBtn.TabIndex = 32;
            lineSharpeningRadioBtn.TabStop = true;
            lineSharpeningRadioBtn.Text = "Line sharpening";
            lineSharpeningRadioBtn.UnCheckedColor = Color.Black;
            lineSharpeningRadioBtn.UseVisualStyleBackColor = true;
            // 
            // gammaCorrectionRadioBtn
            // 
            gammaCorrectionRadioBtn.AutoSize = true;
            gammaCorrectionRadioBtn.CheckedColor = Color.Purple;
            gammaCorrectionRadioBtn.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            gammaCorrectionRadioBtn.ForeColor = Color.Black;
            gammaCorrectionRadioBtn.Location = new Point(346, 135);
            gammaCorrectionRadioBtn.MinimumSize = new Size(0, 21);
            gammaCorrectionRadioBtn.Name = "gammaCorrectionRadioBtn";
            gammaCorrectionRadioBtn.Padding = new Padding(10, 0, 0, 0);
            gammaCorrectionRadioBtn.Size = new Size(179, 26);
            gammaCorrectionRadioBtn.TabIndex = 18;
            gammaCorrectionRadioBtn.TabStop = true;
            gammaCorrectionRadioBtn.Text = "Gamma Correction";
            gammaCorrectionRadioBtn.UnCheckedColor = Color.Black;
            gammaCorrectionRadioBtn.UseVisualStyleBackColor = true;
            // 
            // rjRadioButton12
            // 
            rjRadioButton12.AutoSize = true;
            rjRadioButton12.CheckedColor = Color.Purple;
            rjRadioButton12.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            rjRadioButton12.ForeColor = Color.Black;
            rjRadioButton12.Location = new Point(346, 178);
            rjRadioButton12.MinimumSize = new Size(0, 21);
            rjRadioButton12.Name = "rjRadioButton12";
            rjRadioButton12.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton12.Size = new Size(124, 26);
            rjRadioButton12.TabIndex = 11;
            rjRadioButton12.TabStop = true;
            rjRadioButton12.Text = "Correlation";
            rjRadioButton12.UnCheckedColor = Color.Black;
            rjRadioButton12.UseVisualStyleBackColor = true;
            // 
            // rjRadioButton5
            // 
            rjRadioButton5.AutoSize = true;
            rjRadioButton5.BackColor = Color.LavenderBlush;
            rjRadioButton5.CheckedColor = Color.Purple;
            rjRadioButton5.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            rjRadioButton5.ForeColor = Color.Black;
            rjRadioButton5.Location = new Point(345, 16);
            rjRadioButton5.MinimumSize = new Size(0, 21);
            rjRadioButton5.Name = "rjRadioButton5";
            rjRadioButton5.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton5.Size = new Size(147, 26);
            rjRadioButton5.TabIndex = 20;
            rjRadioButton5.TabStop = true;
            rjRadioButton5.Text = "RGB to Binary";
            rjRadioButton5.TextAlign = ContentAlignment.TopRight;
            rjRadioButton5.UnCheckedColor = Color.Black;
            rjRadioButton5.UseVisualStyleBackColor = false;
            // 
            // logTransformRadioBtn
            // 
            logTransformRadioBtn.AutoSize = true;
            logTransformRadioBtn.CheckedColor = Color.Purple;
            logTransformRadioBtn.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            logTransformRadioBtn.ForeColor = Color.Black;
            logTransformRadioBtn.Location = new Point(346, 109);
            logTransformRadioBtn.MinimumSize = new Size(0, 21);
            logTransformRadioBtn.Name = "logTransformRadioBtn";
            logTransformRadioBtn.Padding = new Padding(10, 0, 0, 0);
            logTransformRadioBtn.Size = new Size(73, 26);
            logTransformRadioBtn.TabIndex = 14;
            logTransformRadioBtn.TabStop = true;
            logTransformRadioBtn.Text = "LOG";
            logTransformRadioBtn.UnCheckedColor = Color.Black;
            logTransformRadioBtn.UseVisualStyleBackColor = true;
            // 
            // histogramRadioBtn
            // 
            histogramRadioBtn.AutoSize = true;
            histogramRadioBtn.CheckedColor = Color.Purple;
            histogramRadioBtn.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            histogramRadioBtn.ForeColor = Color.Black;
            histogramRadioBtn.Location = new Point(346, 78);
            histogramRadioBtn.MinimumSize = new Size(0, 21);
            histogramRadioBtn.Name = "histogramRadioBtn";
            histogramRadioBtn.Padding = new Padding(10, 0, 0, 0);
            histogramRadioBtn.Size = new Size(117, 26);
            histogramRadioBtn.TabIndex = 15;
            histogramRadioBtn.TabStop = true;
            histogramRadioBtn.Text = "Histogram";
            histogramRadioBtn.UnCheckedColor = Color.Black;
            histogramRadioBtn.UseVisualStyleBackColor = true;
            // 
            // negativeRadioBtn
            // 
            negativeRadioBtn.AutoSize = true;
            negativeRadioBtn.CheckedColor = Color.Purple;
            negativeRadioBtn.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            negativeRadioBtn.ForeColor = Color.Black;
            negativeRadioBtn.Location = new Point(346, 47);
            negativeRadioBtn.MinimumSize = new Size(0, 21);
            negativeRadioBtn.Name = "negativeRadioBtn";
            negativeRadioBtn.Padding = new Padding(10, 0, 0, 0);
            negativeRadioBtn.Size = new Size(105, 26);
            negativeRadioBtn.TabIndex = 16;
            negativeRadioBtn.TabStop = true;
            negativeRadioBtn.Text = "Negative";
            negativeRadioBtn.UnCheckedColor = Color.Black;
            negativeRadioBtn.UseVisualStyleBackColor = true;
            // 
            // weightFilterRadioBtn
            // 
            weightFilterRadioBtn.AutoSize = true;
            weightFilterRadioBtn.CheckedColor = Color.Purple;
            weightFilterRadioBtn.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            weightFilterRadioBtn.ForeColor = Color.Black;
            weightFilterRadioBtn.Location = new Point(6, 341);
            weightFilterRadioBtn.MinimumSize = new Size(0, 21);
            weightFilterRadioBtn.Name = "weightFilterRadioBtn";
            weightFilterRadioBtn.Padding = new Padding(10, 0, 0, 0);
            weightFilterRadioBtn.Size = new Size(136, 26);
            weightFilterRadioBtn.TabIndex = 25;
            weightFilterRadioBtn.TabStop = true;
            weightFilterRadioBtn.Text = "Weight filter";
            weightFilterRadioBtn.UnCheckedColor = Color.Black;
            weightFilterRadioBtn.UseVisualStyleBackColor = true;
            // 
            // rayleighNoiseRadioBtn
            // 
            rayleighNoiseRadioBtn.AutoSize = true;
            rayleighNoiseRadioBtn.CheckedColor = Color.Purple;
            rayleighNoiseRadioBtn.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            rayleighNoiseRadioBtn.ForeColor = Color.Black;
            rayleighNoiseRadioBtn.Location = new Point(346, 492);
            rayleighNoiseRadioBtn.MinimumSize = new Size(0, 21);
            rayleighNoiseRadioBtn.Name = "rayleighNoiseRadioBtn";
            rayleighNoiseRadioBtn.Padding = new Padding(10, 0, 0, 0);
            rayleighNoiseRadioBtn.Size = new Size(148, 26);
            rayleighNoiseRadioBtn.TabIndex = 26;
            rayleighNoiseRadioBtn.TabStop = true;
            rayleighNoiseRadioBtn.Text = "rayleigh_noise";
            rayleighNoiseRadioBtn.UnCheckedColor = Color.Black;
            rayleighNoiseRadioBtn.UseVisualStyleBackColor = true;
            rayleighNoiseRadioBtn.CheckedChanged += rjRadioButton17_CheckedChanged;
            // 
            // minFilterRadioBtn
            // 
            minFilterRadioBtn.AutoSize = true;
            minFilterRadioBtn.CheckedColor = Color.Purple;
            minFilterRadioBtn.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            minFilterRadioBtn.ForeColor = Color.Black;
            minFilterRadioBtn.Location = new Point(4, 461);
            minFilterRadioBtn.MinimumSize = new Size(0, 21);
            minFilterRadioBtn.Name = "minFilterRadioBtn";
            minFilterRadioBtn.Padding = new Padding(10, 0, 0, 0);
            minFilterRadioBtn.Size = new Size(117, 26);
            minFilterRadioBtn.TabIndex = 31;
            minFilterRadioBtn.TabStop = true;
            minFilterRadioBtn.Text = "Min Filter";
            minFilterRadioBtn.UnCheckedColor = Color.Black;
            minFilterRadioBtn.UseVisualStyleBackColor = true;
            // 
            // histogramEqualizationRadioBtn
            // 
            histogramEqualizationRadioBtn.AutoSize = true;
            histogramEqualizationRadioBtn.CheckedColor = Color.Purple;
            histogramEqualizationRadioBtn.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            histogramEqualizationRadioBtn.ForeColor = Color.Black;
            histogramEqualizationRadioBtn.Location = new Point(5, 212);
            histogramEqualizationRadioBtn.MinimumSize = new Size(0, 21);
            histogramEqualizationRadioBtn.Name = "histogramEqualizationRadioBtn";
            histogramEqualizationRadioBtn.Padding = new Padding(10, 0, 0, 0);
            histogramEqualizationRadioBtn.Size = new Size(216, 26);
            histogramEqualizationRadioBtn.TabIndex = 24;
            histogramEqualizationRadioBtn.TabStop = true;
            histogramEqualizationRadioBtn.Text = "Histogram Equalization";
            histogramEqualizationRadioBtn.UnCheckedColor = Color.Black;
            histogramEqualizationRadioBtn.UseVisualStyleBackColor = true;
            // 
            // pointDetectionRadioBtn
            // 
            pointDetectionRadioBtn.AutoSize = true;
            pointDetectionRadioBtn.CheckedColor = Color.Purple;
            pointDetectionRadioBtn.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            pointDetectionRadioBtn.ForeColor = Color.Black;
            pointDetectionRadioBtn.Location = new Point(5, 369);
            pointDetectionRadioBtn.MinimumSize = new Size(0, 21);
            pointDetectionRadioBtn.Name = "pointDetectionRadioBtn";
            pointDetectionRadioBtn.Padding = new Padding(10, 0, 0, 0);
            pointDetectionRadioBtn.Size = new Size(156, 26);
            pointDetectionRadioBtn.TabIndex = 30;
            pointDetectionRadioBtn.TabStop = true;
            pointDetectionRadioBtn.Text = "Point Detection";
            pointDetectionRadioBtn.UnCheckedColor = Color.Black;
            pointDetectionRadioBtn.UseVisualStyleBackColor = true;
            pointDetectionRadioBtn.CheckedChanged += rjRadioButton21_CheckedChanged;
            // 
            // butterWorthHighPassRadioBtn
            // 
            butterWorthHighPassRadioBtn.AutoSize = true;
            butterWorthHighPassRadioBtn.CheckedColor = Color.Purple;
            butterWorthHighPassRadioBtn.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            butterWorthHighPassRadioBtn.ForeColor = Color.Black;
            butterWorthHighPassRadioBtn.Location = new Point(346, 397);
            butterWorthHighPassRadioBtn.MinimumSize = new Size(0, 21);
            butterWorthHighPassRadioBtn.Name = "butterWorthHighPassRadioBtn";
            butterWorthHighPassRadioBtn.Padding = new Padding(10, 0, 0, 0);
            butterWorthHighPassRadioBtn.Size = new Size(266, 26);
            butterWorthHighPassRadioBtn.TabIndex = 13;
            butterWorthHighPassRadioBtn.TabStop = true;
            butterWorthHighPassRadioBtn.Text = "Butter Worth High Pass Filter";
            butterWorthHighPassRadioBtn.UnCheckedColor = Color.Black;
            butterWorthHighPassRadioBtn.UseVisualStyleBackColor = true;
            butterWorthHighPassRadioBtn.CheckedChanged += rjRadioButton10_CheckedChanged;
            // 
            // lightenRadioBtn
            // 
            lightenRadioBtn.AutoSize = true;
            lightenRadioBtn.CheckedColor = Color.Purple;
            lightenRadioBtn.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            lightenRadioBtn.ForeColor = Color.Black;
            lightenRadioBtn.Location = new Point(5, 236);
            lightenRadioBtn.MinimumSize = new Size(0, 21);
            lightenRadioBtn.Name = "lightenRadioBtn";
            lightenRadioBtn.Padding = new Padding(10, 0, 0, 0);
            lightenRadioBtn.Size = new Size(95, 26);
            lightenRadioBtn.TabIndex = 23;
            lightenRadioBtn.TabStop = true;
            lightenRadioBtn.Text = "Lighten";
            lightenRadioBtn.UnCheckedColor = Color.Black;
            lightenRadioBtn.UseVisualStyleBackColor = true;
            // 
            // darkenRadioBtn
            // 
            darkenRadioBtn.AutoSize = true;
            darkenRadioBtn.CheckedColor = Color.Purple;
            darkenRadioBtn.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            darkenRadioBtn.ForeColor = Color.Black;
            darkenRadioBtn.Location = new Point(6, 259);
            darkenRadioBtn.MinimumSize = new Size(0, 21);
            darkenRadioBtn.Name = "darkenRadioBtn";
            darkenRadioBtn.Padding = new Padding(10, 0, 0, 0);
            darkenRadioBtn.Size = new Size(92, 26);
            darkenRadioBtn.TabIndex = 22;
            darkenRadioBtn.TabStop = true;
            darkenRadioBtn.Text = "Darken";
            darkenRadioBtn.UnCheckedColor = Color.Black;
            darkenRadioBtn.UseVisualStyleBackColor = true;
            // 
            // prewittFilterRadioBtn
            // 
            prewittFilterRadioBtn.AutoSize = true;
            prewittFilterRadioBtn.CheckedColor = Color.Purple;
            prewittFilterRadioBtn.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            prewittFilterRadioBtn.ForeColor = Color.Black;
            prewittFilterRadioBtn.Location = new Point(5, 18);
            prewittFilterRadioBtn.MinimumSize = new Size(0, 21);
            prewittFilterRadioBtn.Name = "prewittFilterRadioBtn";
            prewittFilterRadioBtn.Padding = new Padding(10, 0, 0, 0);
            prewittFilterRadioBtn.Size = new Size(273, 26);
            prewittFilterRadioBtn.TabIndex = 20;
            prewittFilterRadioBtn.TabStop = true;
            prewittFilterRadioBtn.Text = "Prewitt Filter (Edge Detection)";
            prewittFilterRadioBtn.UnCheckedColor = Color.Black;
            prewittFilterRadioBtn.UseVisualStyleBackColor = true;
            // 
            // rgbToGrayRadioBtn
            // 
            rgbToGrayRadioBtn.AutoSize = true;
            rgbToGrayRadioBtn.CheckedColor = Color.Purple;
            rgbToGrayRadioBtn.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            rgbToGrayRadioBtn.ForeColor = Color.Black;
            rgbToGrayRadioBtn.Location = new Point(5, 132);
            rgbToGrayRadioBtn.MinimumSize = new Size(0, 21);
            rgbToGrayRadioBtn.Name = "rgbToGrayRadioBtn";
            rgbToGrayRadioBtn.Padding = new Padding(10, 0, 0, 0);
            rgbToGrayRadioBtn.Size = new Size(133, 26);
            rgbToGrayRadioBtn.TabIndex = 18;
            rgbToGrayRadioBtn.TabStop = true;
            rgbToGrayRadioBtn.Text = "Rgb To Gray";
            rgbToGrayRadioBtn.UnCheckedColor = Color.Black;
            rgbToGrayRadioBtn.UseVisualStyleBackColor = true;
            // 
            // contrastStretchingRadioBtn
            // 
            contrastStretchingRadioBtn.AutoSize = true;
            contrastStretchingRadioBtn.CheckedColor = Color.Purple;
            contrastStretchingRadioBtn.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            contrastStretchingRadioBtn.ForeColor = Color.Black;
            contrastStretchingRadioBtn.Location = new Point(6, 47);
            contrastStretchingRadioBtn.MinimumSize = new Size(0, 21);
            contrastStretchingRadioBtn.Name = "contrastStretchingRadioBtn";
            contrastStretchingRadioBtn.Padding = new Padding(10, 0, 0, 0);
            contrastStretchingRadioBtn.Size = new Size(183, 26);
            contrastStretchingRadioBtn.TabIndex = 16;
            contrastStretchingRadioBtn.TabStop = true;
            contrastStretchingRadioBtn.Text = "Contrast Stretching";
            contrastStretchingRadioBtn.UnCheckedColor = Color.Black;
            contrastStretchingRadioBtn.UseVisualStyleBackColor = true;
            contrastStretchingRadioBtn.CheckedChanged += CERadioBtn_CheckedChanged;
            // 
            // laplacianFilterRadioBtn
            // 
            laplacianFilterRadioBtn.AutoSize = true;
            laplacianFilterRadioBtn.CheckedColor = Color.Purple;
            laplacianFilterRadioBtn.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            laplacianFilterRadioBtn.ForeColor = Color.Black;
            laplacianFilterRadioBtn.Location = new Point(5, 75);
            laplacianFilterRadioBtn.MinimumSize = new Size(0, 21);
            laplacianFilterRadioBtn.Name = "laplacianFilterRadioBtn";
            laplacianFilterRadioBtn.Padding = new Padding(10, 0, 0, 0);
            laplacianFilterRadioBtn.Size = new Size(158, 26);
            laplacianFilterRadioBtn.TabIndex = 15;
            laplacianFilterRadioBtn.TabStop = true;
            laplacianFilterRadioBtn.Text = "Laplacian Filter";
            laplacianFilterRadioBtn.UnCheckedColor = Color.Black;
            laplacianFilterRadioBtn.UseVisualStyleBackColor = true;
            // 
            // grayToBinaryRadioBtn
            // 
            grayToBinaryRadioBtn.AutoSize = true;
            grayToBinaryRadioBtn.CheckedColor = Color.Purple;
            grayToBinaryRadioBtn.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            grayToBinaryRadioBtn.ForeColor = Color.Black;
            grayToBinaryRadioBtn.Location = new Point(5, 103);
            grayToBinaryRadioBtn.MinimumSize = new Size(0, 21);
            grayToBinaryRadioBtn.Name = "grayToBinaryRadioBtn";
            grayToBinaryRadioBtn.Padding = new Padding(10, 0, 0, 0);
            grayToBinaryRadioBtn.Size = new Size(154, 26);
            grayToBinaryRadioBtn.TabIndex = 14;
            grayToBinaryRadioBtn.TabStop = true;
            grayToBinaryRadioBtn.Text = "Gray To Binary";
            grayToBinaryRadioBtn.UnCheckedColor = Color.Black;
            grayToBinaryRadioBtn.UseVisualStyleBackColor = true;
            grayToBinaryRadioBtn.CheckedChanged += GrayToBinaryRediobtn_CheckedChanged;
            // 
            // meanFilterRadioBtn
            // 
            meanFilterRadioBtn.AutoSize = true;
            meanFilterRadioBtn.CheckedColor = Color.Purple;
            meanFilterRadioBtn.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            meanFilterRadioBtn.ForeColor = Color.Black;
            meanFilterRadioBtn.Location = new Point(5, 315);
            meanFilterRadioBtn.MinimumSize = new Size(0, 21);
            meanFilterRadioBtn.Name = "meanFilterRadioBtn";
            meanFilterRadioBtn.Padding = new Padding(10, 0, 0, 0);
            meanFilterRadioBtn.Size = new Size(224, 26);
            meanFilterRadioBtn.TabIndex = 13;
            meanFilterRadioBtn.TabStop = true;
            meanFilterRadioBtn.Text = "Mean Filter (Smoothing)";
            meanFilterRadioBtn.UnCheckedColor = Color.Black;
            meanFilterRadioBtn.UseVisualStyleBackColor = true;
            // 
            // medianFilterRadioBtn
            // 
            medianFilterRadioBtn.AutoSize = true;
            medianFilterRadioBtn.CheckedColor = Color.Purple;
            medianFilterRadioBtn.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            medianFilterRadioBtn.ForeColor = Color.Black;
            medianFilterRadioBtn.Location = new Point(5, 287);
            medianFilterRadioBtn.MinimumSize = new Size(0, 21);
            medianFilterRadioBtn.Name = "medianFilterRadioBtn";
            medianFilterRadioBtn.Padding = new Padding(10, 0, 0, 0);
            medianFilterRadioBtn.Size = new Size(272, 26);
            medianFilterRadioBtn.TabIndex = 12;
            medianFilterRadioBtn.TabStop = true;
            medianFilterRadioBtn.Text = "Median Filter (Noise Removal)";
            medianFilterRadioBtn.UnCheckedColor = Color.Black;
            medianFilterRadioBtn.UseVisualStyleBackColor = true;
            medianFilterRadioBtn.CheckedChanged += medianRadioBtn_CheckedChanged;
            // 
            // gaussianFilterRadioBtn
            // 
            gaussianFilterRadioBtn.AutoSize = true;
            gaussianFilterRadioBtn.CheckedColor = Color.Purple;
            gaussianFilterRadioBtn.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            gaussianFilterRadioBtn.ForeColor = Color.Black;
            gaussianFilterRadioBtn.Location = new Point(5, 157);
            gaussianFilterRadioBtn.MinimumSize = new Size(0, 21);
            gaussianFilterRadioBtn.Name = "gaussianFilterRadioBtn";
            gaussianFilterRadioBtn.Padding = new Padding(10, 0, 0, 0);
            gaussianFilterRadioBtn.Size = new Size(249, 26);
            gaussianFilterRadioBtn.TabIndex = 11;
            gaussianFilterRadioBtn.TabStop = true;
            gaussianFilterRadioBtn.Text = "Gaussian Filter (Smoothing)";
            gaussianFilterRadioBtn.UnCheckedColor = Color.Black;
            gaussianFilterRadioBtn.UseVisualStyleBackColor = true;
            // 
            // sobelFilterRadioBtn
            // 
            sobelFilterRadioBtn.AutoSize = true;
            sobelFilterRadioBtn.CheckedColor = Color.Purple;
            sobelFilterRadioBtn.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            sobelFilterRadioBtn.ForeColor = Color.Black;
            sobelFilterRadioBtn.Location = new Point(4, 189);
            sobelFilterRadioBtn.MinimumSize = new Size(0, 21);
            sobelFilterRadioBtn.Name = "sobelFilterRadioBtn";
            sobelFilterRadioBtn.Padding = new Padding(10, 0, 0, 0);
            sobelFilterRadioBtn.Size = new Size(258, 26);
            sobelFilterRadioBtn.TabIndex = 10;
            sobelFilterRadioBtn.TabStop = true;
            sobelFilterRadioBtn.Text = "Sobel Filter (Edge Detection)";
            sobelFilterRadioBtn.UnCheckedColor = Color.Black;
            sobelFilterRadioBtn.UseVisualStyleBackColor = true;
            sobelFilterRadioBtn.CheckedChanged += SobelFilterRadioBtn_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LavenderBlush;
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(657, 749);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1427, 749);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "image processing";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Button button2;
        private Button button4;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private CustomControls.RJControls.RJRadioButton idealLowPassRadioBtn;
        private TextBox imagePath;
        private Button btnImport;
        private Button button1;
        private CustomControls.RJControls.RJRadioButton butterWorthLowPassRadioBtn;
        private CustomControls.RJControls.RJRadioButton idealHighPassRadioBtn;
        private CustomControls.RJControls.RJRadioButton maxFilterRadioBtn;
        private CustomControls.RJControls.RJRadioButton gaussianLowPassRadioBtn;
        private CustomControls.RJControls.RJRadioButton gaussianHighPassRadioBtn;
        private CustomControls.RJControls.RJRadioButton saltPepperNoiseRadioBtn;
        private CustomControls.RJControls.RJRadioButton inverseFourierRadioBtn;
        private CustomControls.RJControls.RJRadioButton fourierTransformRadioBtn;
        private CustomControls.RJControls.RJRadioButton pointSharpeningRadioBtn;
        private CustomControls.RJControls.RJRadioButton lineSharpeningRadioBtn;
        private CustomControls.RJControls.RJRadioButton gammaCorrectionRadioBtn;
        private CustomControls.RJControls.RJRadioButton rjRadioButton12;
        private CustomControls.RJControls.RJRadioButton rjRadioButton5;
        private CustomControls.RJControls.RJRadioButton logTransformRadioBtn;
        private CustomControls.RJControls.RJRadioButton histogramRadioBtn;
        private CustomControls.RJControls.RJRadioButton negativeRadioBtn;
        private CustomControls.RJControls.RJRadioButton weightFilterRadioBtn;
        private CustomControls.RJControls.RJRadioButton rayleighNoiseRadioBtn;
        private CustomControls.RJControls.RJRadioButton minFilterRadioBtn;
        private CustomControls.RJControls.RJRadioButton histogramEqualizationRadioBtn;
        private CustomControls.RJControls.RJRadioButton pointDetectionRadioBtn;
        private CustomControls.RJControls.RJRadioButton butterWorthHighPassRadioBtn;
        private CustomControls.RJControls.RJRadioButton lightenRadioBtn;
        private CustomControls.RJControls.RJRadioButton darkenRadioBtn;
        private CustomControls.RJControls.RJRadioButton prewittFilterRadioBtn;
        private CustomControls.RJControls.RJRadioButton rgbToGrayRadioBtn;
        private CustomControls.RJControls.RJRadioButton contrastStretchingRadioBtn;
        private CustomControls.RJControls.RJRadioButton laplacianFilterRadioBtn;
        private CustomControls.RJControls.RJRadioButton grayToBinaryRadioBtn;
        private CustomControls.RJControls.RJRadioButton meanFilterRadioBtn;
        private CustomControls.RJControls.RJRadioButton medianFilterRadioBtn;
        private CustomControls.RJControls.RJRadioButton gaussianFilterRadioBtn;
        private CustomControls.RJControls.RJRadioButton sobelFilterRadioBtn;
        private Panel panel1;
        private Button button3;
        private CustomControls.RJControls.RJRadioButton gammaNoiseRadioBtn;
        private CustomControls.RJControls.RJRadioButton exponentialNoiseRadioBtn;
        private CustomControls.RJControls.RJRadioButton uniformNoiseRadioBtn;
        private CustomControls.RJControls.RJRadioButton gaussianNoiseRadioBtn;
    }
}

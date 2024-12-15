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
            panel1 = new Panel();
            textBox1 = new TextBox();
            button1 = new Button();
            imagePath = new TextBox();
            btnImport = new Button();
            groupBox1 = new GroupBox();
            HERadioBtn = new CustomControls.RJControls.RJRadioButton();
            lightenRedioBtn = new CustomControls.RJControls.RJRadioButton();
            darkenRadioBtn = new CustomControls.RJControls.RJRadioButton();
            prewittFilterRadioBtn = new CustomControls.RJControls.RJRadioButton();
            RgbToGrayRediobtn = new CustomControls.RJControls.RJRadioButton();
            CERadioBtn = new CustomControls.RJControls.RJRadioButton();
            LaplacianRadiobtn = new CustomControls.RJControls.RJRadioButton();
            GrayToBinaryRediobtn = new CustomControls.RJControls.RJRadioButton();
            meanRadioBtn = new CustomControls.RJControls.RJRadioButton();
            medianRadioBtn = new CustomControls.RJControls.RJRadioButton();
            blurGaussianRadioButton = new CustomControls.RJControls.RJRadioButton();
            SobelFilterRadioBtn = new CustomControls.RJControls.RJRadioButton();
            applyBtn = new Button();
            openFileDialog1 = new OpenFileDialog();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            panel5 = new Panel();
            button4 = new Button();
            lowPassRadioBtn = new CustomControls.RJControls.RJRadioButton();
            groupBox2 = new GroupBox();
            rjRadioButton1 = new CustomControls.RJControls.RJRadioButton();
            rjRadioButton2 = new CustomControls.RJControls.RJRadioButton();
            rjRadioButton3 = new CustomControls.RJControls.RJRadioButton();
            rjRadioButton4 = new CustomControls.RJControls.RJRadioButton();
            rjRadioButton5 = new CustomControls.RJControls.RJRadioButton();
            rjRadioButton6 = new CustomControls.RJControls.RJRadioButton();
            rjRadioButton7 = new CustomControls.RJControls.RJRadioButton();
            rjRadioButton8 = new CustomControls.RJControls.RJRadioButton();
            rjRadioButton9 = new CustomControls.RJControls.RJRadioButton();
            rjRadioButton10 = new CustomControls.RJControls.RJRadioButton();
            rjRadioButton11 = new CustomControls.RJControls.RJRadioButton();
            rjRadioButton12 = new CustomControls.RJControls.RJRadioButton();
            rjRadioButton13 = new CustomControls.RJControls.RJRadioButton();
            rjRadioButton14 = new CustomControls.RJControls.RJRadioButton();
            rjRadioButton15 = new CustomControls.RJControls.RJRadioButton();
            rjRadioButton16 = new CustomControls.RJControls.RJRadioButton();
            rjRadioButton17 = new CustomControls.RJControls.RJRadioButton();
            rjRadioButton18 = new CustomControls.RJControls.RJRadioButton();
            rjRadioButton19 = new CustomControls.RJControls.RJRadioButton();
            rjRadioButton20 = new CustomControls.RJControls.RJRadioButton();
            rjRadioButton21 = new CustomControls.RJControls.RJRadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(490, 484);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Crimson;
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(325, 679);
            panel1.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(649, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(279, 23);
            textBox1.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(325, 12);
            button1.Name = "button1";
            button1.Size = new Size(97, 23);
            button1.TabIndex = 12;
            button1.Text = "export";
            button1.UseVisualStyleBackColor = true;
            button1.Click += exportBtn_Click;
            // 
            // imagePath
            // 
            imagePath.Location = new Point(407, 103);
            imagePath.Name = "imagePath";
            imagePath.Size = new Size(279, 23);
            imagePath.TabIndex = 10;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(407, 76);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(97, 23);
            btnImport.TabIndex = 6;
            btnImport.Text = "import";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += importBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rjRadioButton18);
            groupBox1.Controls.Add(rjRadioButton19);
            groupBox1.Controls.Add(lowPassRadioBtn);
            groupBox1.Controls.Add(rjRadioButton20);
            groupBox1.Controls.Add(HERadioBtn);
            groupBox1.Controls.Add(rjRadioButton21);
            groupBox1.Controls.Add(lightenRedioBtn);
            groupBox1.Controls.Add(darkenRadioBtn);
            groupBox1.Controls.Add(prewittFilterRadioBtn);
            groupBox1.Controls.Add(RgbToGrayRediobtn);
            groupBox1.Controls.Add(CERadioBtn);
            groupBox1.Controls.Add(LaplacianRadiobtn);
            groupBox1.Controls.Add(GrayToBinaryRediobtn);
            groupBox1.Controls.Add(meanRadioBtn);
            groupBox1.Controls.Add(medianRadioBtn);
            groupBox1.Controls.Add(blurGaussianRadioButton);
            groupBox1.Controls.Add(SobelFilterRadioBtn);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(313, 667);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // HERadioBtn
            // 
            HERadioBtn.AutoSize = true;
            HERadioBtn.CheckedColor = Color.Purple;
            HERadioBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            HERadioBtn.ForeColor = SystemColors.ActiveCaptionText;
            HERadioBtn.Location = new Point(6, 578);
            HERadioBtn.MinimumSize = new Size(0, 21);
            HERadioBtn.Name = "HERadioBtn";
            HERadioBtn.Padding = new Padding(10, 0, 0, 0);
            HERadioBtn.Size = new Size(177, 21);
            HERadioBtn.TabIndex = 24;
            HERadioBtn.TabStop = true;
            HERadioBtn.Text = "Histogram Equalization";
            HERadioBtn.UnCheckedColor = Color.Black;
            HERadioBtn.UseVisualStyleBackColor = true;
            // 
            // lightenRedioBtn
            // 
            lightenRedioBtn.AutoSize = true;
            lightenRedioBtn.CheckedColor = Color.Purple;
            lightenRedioBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lightenRedioBtn.ForeColor = SystemColors.ActiveCaptionText;
            lightenRedioBtn.Location = new Point(6, 605);
            lightenRedioBtn.MinimumSize = new Size(0, 21);
            lightenRedioBtn.Name = "lightenRedioBtn";
            lightenRedioBtn.Padding = new Padding(10, 0, 0, 0);
            lightenRedioBtn.Size = new Size(81, 21);
            lightenRedioBtn.TabIndex = 23;
            lightenRedioBtn.TabStop = true;
            lightenRedioBtn.Text = "Lighten";
            lightenRedioBtn.UnCheckedColor = Color.Black;
            lightenRedioBtn.UseVisualStyleBackColor = true;
            // 
            // darkenRadioBtn
            // 
            darkenRadioBtn.AutoSize = true;
            darkenRadioBtn.CheckedColor = Color.Purple;
            darkenRadioBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            darkenRadioBtn.ForeColor = SystemColors.ActiveCaptionText;
            darkenRadioBtn.Location = new Point(6, 632);
            darkenRadioBtn.MinimumSize = new Size(0, 21);
            darkenRadioBtn.Name = "darkenRadioBtn";
            darkenRadioBtn.Padding = new Padding(10, 0, 0, 0);
            darkenRadioBtn.Size = new Size(79, 21);
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
            prewittFilterRadioBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            prewittFilterRadioBtn.ForeColor = SystemColors.ActiveCaptionText;
            prewittFilterRadioBtn.Location = new Point(6, 22);
            prewittFilterRadioBtn.MinimumSize = new Size(0, 21);
            prewittFilterRadioBtn.Name = "prewittFilterRadioBtn";
            prewittFilterRadioBtn.Padding = new Padding(10, 0, 0, 0);
            prewittFilterRadioBtn.Size = new Size(217, 21);
            prewittFilterRadioBtn.TabIndex = 20;
            prewittFilterRadioBtn.TabStop = true;
            prewittFilterRadioBtn.Text = "Prewitt Filter (Edge Detection)";
            prewittFilterRadioBtn.UnCheckedColor = Color.Black;
            prewittFilterRadioBtn.UseVisualStyleBackColor = true;
            // 
            // RgbToGrayRediobtn
            // 
            RgbToGrayRediobtn.AutoSize = true;
            RgbToGrayRediobtn.CheckedColor = Color.Yellow;
            RgbToGrayRediobtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            RgbToGrayRediobtn.ForeColor = SystemColors.ActiveCaptionText;
            RgbToGrayRediobtn.Location = new Point(6, 130);
            RgbToGrayRediobtn.MinimumSize = new Size(0, 21);
            RgbToGrayRediobtn.Name = "RgbToGrayRediobtn";
            RgbToGrayRediobtn.Padding = new Padding(10, 0, 0, 0);
            RgbToGrayRediobtn.Size = new Size(110, 21);
            RgbToGrayRediobtn.TabIndex = 18;
            RgbToGrayRediobtn.TabStop = true;
            RgbToGrayRediobtn.Text = "Rgb To Gray";
            RgbToGrayRediobtn.UnCheckedColor = Color.Black;
            RgbToGrayRediobtn.UseVisualStyleBackColor = true;
            // 
            // CERadioBtn
            // 
            CERadioBtn.AutoSize = true;
            CERadioBtn.CheckedColor = Color.Yellow;
            CERadioBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            CERadioBtn.ForeColor = SystemColors.ActiveCaptionText;
            CERadioBtn.Location = new Point(6, 49);
            CERadioBtn.MinimumSize = new Size(0, 21);
            CERadioBtn.Name = "CERadioBtn";
            CERadioBtn.Padding = new Padding(10, 0, 0, 0);
            CERadioBtn.Size = new Size(168, 21);
            CERadioBtn.TabIndex = 16;
            CERadioBtn.TabStop = true;
            CERadioBtn.Text = "Contrast enhancment";
            CERadioBtn.UnCheckedColor = Color.Gray;
            CERadioBtn.UseVisualStyleBackColor = true;
            // 
            // LaplacianRadiobtn
            // 
            LaplacianRadiobtn.AutoSize = true;
            LaplacianRadiobtn.CheckedColor = Color.Yellow;
            LaplacianRadiobtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            LaplacianRadiobtn.ForeColor = SystemColors.ActiveCaptionText;
            LaplacianRadiobtn.Location = new Point(6, 76);
            LaplacianRadiobtn.MinimumSize = new Size(0, 21);
            LaplacianRadiobtn.Name = "LaplacianRadiobtn";
            LaplacianRadiobtn.Padding = new Padding(10, 0, 0, 0);
            LaplacianRadiobtn.Size = new Size(125, 21);
            LaplacianRadiobtn.TabIndex = 15;
            LaplacianRadiobtn.TabStop = true;
            LaplacianRadiobtn.Text = "Laplacian Filter";
            LaplacianRadiobtn.UnCheckedColor = Color.Black;
            LaplacianRadiobtn.UseVisualStyleBackColor = true;
            // 
            // GrayToBinaryRediobtn
            // 
            GrayToBinaryRediobtn.AutoSize = true;
            GrayToBinaryRediobtn.CheckedColor = Color.Yellow;
            GrayToBinaryRediobtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            GrayToBinaryRediobtn.ForeColor = SystemColors.ActiveCaptionText;
            GrayToBinaryRediobtn.Location = new Point(6, 103);
            GrayToBinaryRediobtn.MinimumSize = new Size(0, 21);
            GrayToBinaryRediobtn.Name = "GrayToBinaryRediobtn";
            GrayToBinaryRediobtn.Padding = new Padding(10, 0, 0, 0);
            GrayToBinaryRediobtn.Size = new Size(125, 21);
            GrayToBinaryRediobtn.TabIndex = 14;
            GrayToBinaryRediobtn.TabStop = true;
            GrayToBinaryRediobtn.Text = "Gray To Binary";
            GrayToBinaryRediobtn.UnCheckedColor = Color.Black;
            GrayToBinaryRediobtn.UseVisualStyleBackColor = true;
            // 
            // meanRadioBtn
            // 
            meanRadioBtn.AutoSize = true;
            meanRadioBtn.CheckedColor = Color.Yellow;
            meanRadioBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            meanRadioBtn.ForeColor = SystemColors.ActiveCaptionText;
            meanRadioBtn.Location = new Point(3, 211);
            meanRadioBtn.MinimumSize = new Size(0, 21);
            meanRadioBtn.Name = "meanRadioBtn";
            meanRadioBtn.Padding = new Padding(10, 0, 0, 0);
            meanRadioBtn.Size = new Size(183, 21);
            meanRadioBtn.TabIndex = 13;
            meanRadioBtn.TabStop = true;
            meanRadioBtn.Text = "Mean Filter (Smoothing)";
            meanRadioBtn.UnCheckedColor = Color.Black;
            meanRadioBtn.UseVisualStyleBackColor = true;
            // 
            // medianRadioBtn
            // 
            medianRadioBtn.AutoSize = true;
            medianRadioBtn.CheckedColor = Color.Yellow;
            medianRadioBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            medianRadioBtn.ForeColor = SystemColors.ActiveCaptionText;
            medianRadioBtn.Location = new Point(3, 351);
            medianRadioBtn.MinimumSize = new Size(0, 21);
            medianRadioBtn.Name = "medianRadioBtn";
            medianRadioBtn.Padding = new Padding(10, 0, 0, 0);
            medianRadioBtn.Size = new Size(217, 21);
            medianRadioBtn.TabIndex = 12;
            medianRadioBtn.TabStop = true;
            medianRadioBtn.Text = "Median Filter (Noise Removal)";
            medianRadioBtn.UnCheckedColor = Color.Black;
            medianRadioBtn.UseVisualStyleBackColor = true;
            medianRadioBtn.CheckedChanged += medianRadioBtn_CheckedChanged;
            // 
            // blurGaussianRadioButton
            // 
            blurGaussianRadioButton.AutoSize = true;
            blurGaussianRadioButton.CheckedColor = Color.Yellow;
            blurGaussianRadioButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            blurGaussianRadioButton.ForeColor = SystemColors.ActiveCaptionText;
            blurGaussianRadioButton.Location = new Point(6, 157);
            blurGaussianRadioButton.MinimumSize = new Size(0, 21);
            blurGaussianRadioButton.Name = "blurGaussianRadioButton";
            blurGaussianRadioButton.Padding = new Padding(10, 0, 0, 0);
            blurGaussianRadioButton.Size = new Size(203, 21);
            blurGaussianRadioButton.TabIndex = 11;
            blurGaussianRadioButton.TabStop = true;
            blurGaussianRadioButton.Text = "Gaussian Filter (Smoothing)";
            blurGaussianRadioButton.UnCheckedColor = Color.Black;
            blurGaussianRadioButton.UseVisualStyleBackColor = true;
            // 
            // SobelFilterRadioBtn
            // 
            SobelFilterRadioBtn.AutoSize = true;
            SobelFilterRadioBtn.CheckedColor = Color.Yellow;
            SobelFilterRadioBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            SobelFilterRadioBtn.ForeColor = SystemColors.ActiveCaptionText;
            SobelFilterRadioBtn.Location = new Point(3, 378);
            SobelFilterRadioBtn.MinimumSize = new Size(0, 21);
            SobelFilterRadioBtn.Name = "SobelFilterRadioBtn";
            SobelFilterRadioBtn.Padding = new Padding(10, 0, 0, 0);
            SobelFilterRadioBtn.Size = new Size(207, 21);
            SobelFilterRadioBtn.TabIndex = 10;
            SobelFilterRadioBtn.TabStop = true;
            SobelFilterRadioBtn.Text = "Sobel Filter (Edge Detection)";
            SobelFilterRadioBtn.UnCheckedColor = Color.Black;
            SobelFilterRadioBtn.UseVisualStyleBackColor = true;
            // 
            // applyBtn
            // 
            applyBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            applyBtn.Location = new Point(156, 263);
            applyBtn.Name = "applyBtn";
            applyBtn.Size = new Size(125, 40);
            applyBtn.TabIndex = 9;
            applyBtn.Text = "Apply Filter";
            applyBtn.UseVisualStyleBackColor = true;
            applyBtn.Click += button3_Click;
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
            panel2.Location = new Point(955, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1143, 679);
            panel2.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(674, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(466, 484);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(639, 198);
            button2.Name = "button2";
            button2.Size = new Size(322, 247);
            button2.TabIndex = 14;
            button2.Text = "Undo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += undoBtn_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Indigo;
            panel5.Controls.Add(textBox1);
            panel5.Controls.Add(button1);
            panel5.Controls.Add(btnImport);
            panel5.Controls.Add(imagePath);
            panel5.Location = new Point(325, 553);
            panel5.Name = "panel5";
            panel5.Size = new Size(962, 132);
            panel5.TabIndex = 13;
            // 
            // button4
            // 
            button4.Location = new Point(639, 0);
            button4.Name = "button4";
            button4.Size = new Size(322, 205);
            button4.TabIndex = 15;
            button4.Text = "Redo";
            button4.UseVisualStyleBackColor = true;
            button4.Click += redoBtn_Click;
            // 
            // lowPassRadioBtn
            // 
            lowPassRadioBtn.AutoSize = true;
            lowPassRadioBtn.CheckedColor = Color.Yellow;
            lowPassRadioBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lowPassRadioBtn.ForeColor = SystemColors.ActiveCaptionText;
            lowPassRadioBtn.Location = new Point(6, 184);
            lowPassRadioBtn.MinimumSize = new Size(0, 21);
            lowPassRadioBtn.Name = "lowPassRadioBtn";
            lowPassRadioBtn.Padding = new Padding(10, 0, 0, 0);
            lowPassRadioBtn.Size = new Size(126, 21);
            lowPassRadioBtn.TabIndex = 25;
            lowPassRadioBtn.TabStop = true;
            lowPassRadioBtn.Text = "Low-Pass Filter";
            lowPassRadioBtn.UnCheckedColor = Color.Black;
            lowPassRadioBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rjRadioButton14);
            groupBox2.Controls.Add(rjRadioButton15);
            groupBox2.Controls.Add(rjRadioButton16);
            groupBox2.Controls.Add(rjRadioButton17);
            groupBox2.Controls.Add(rjRadioButton1);
            groupBox2.Controls.Add(rjRadioButton2);
            groupBox2.Controls.Add(applyBtn);
            groupBox2.Controls.Add(rjRadioButton3);
            groupBox2.Controls.Add(rjRadioButton4);
            groupBox2.Controls.Add(rjRadioButton5);
            groupBox2.Controls.Add(rjRadioButton6);
            groupBox2.Controls.Add(rjRadioButton7);
            groupBox2.Controls.Add(rjRadioButton8);
            groupBox2.Controls.Add(rjRadioButton9);
            groupBox2.Controls.Add(rjRadioButton10);
            groupBox2.Controls.Add(rjRadioButton11);
            groupBox2.Controls.Add(rjRadioButton12);
            groupBox2.Controls.Add(rjRadioButton13);
            groupBox2.Location = new Point(325, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(319, 679);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            // 
            // rjRadioButton1
            // 
            rjRadioButton1.AutoSize = true;
            rjRadioButton1.CheckedColor = Color.Yellow;
            rjRadioButton1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            rjRadioButton1.ForeColor = SystemColors.ActiveCaptionText;
            rjRadioButton1.Location = new Point(6, 184);
            rjRadioButton1.MinimumSize = new Size(0, 21);
            rjRadioButton1.Name = "rjRadioButton1";
            rjRadioButton1.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton1.Size = new Size(126, 21);
            rjRadioButton1.TabIndex = 25;
            rjRadioButton1.TabStop = true;
            rjRadioButton1.Text = "Low-Pass Filter";
            rjRadioButton1.UnCheckedColor = Color.Black;
            rjRadioButton1.UseVisualStyleBackColor = true;
            // 
            // rjRadioButton2
            // 
            rjRadioButton2.AutoSize = true;
            rjRadioButton2.CheckedColor = Color.Purple;
            rjRadioButton2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            rjRadioButton2.ForeColor = SystemColors.ActiveCaptionText;
            rjRadioButton2.Location = new Point(6, 505);
            rjRadioButton2.MinimumSize = new Size(0, 21);
            rjRadioButton2.Name = "rjRadioButton2";
            rjRadioButton2.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton2.Size = new Size(177, 21);
            rjRadioButton2.TabIndex = 24;
            rjRadioButton2.TabStop = true;
            rjRadioButton2.Text = "Histogram Equalization";
            rjRadioButton2.UnCheckedColor = Color.Black;
            rjRadioButton2.UseVisualStyleBackColor = true;
            // 
            // rjRadioButton3
            // 
            rjRadioButton3.AutoSize = true;
            rjRadioButton3.CheckedColor = Color.Purple;
            rjRadioButton3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            rjRadioButton3.ForeColor = SystemColors.ActiveCaptionText;
            rjRadioButton3.Location = new Point(6, 532);
            rjRadioButton3.MinimumSize = new Size(0, 21);
            rjRadioButton3.Name = "rjRadioButton3";
            rjRadioButton3.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton3.Size = new Size(81, 21);
            rjRadioButton3.TabIndex = 23;
            rjRadioButton3.TabStop = true;
            rjRadioButton3.Text = "Lighten";
            rjRadioButton3.UnCheckedColor = Color.Black;
            rjRadioButton3.UseVisualStyleBackColor = true;
            // 
            // rjRadioButton4
            // 
            rjRadioButton4.AutoSize = true;
            rjRadioButton4.CheckedColor = Color.Purple;
            rjRadioButton4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            rjRadioButton4.ForeColor = SystemColors.ActiveCaptionText;
            rjRadioButton4.Location = new Point(6, 559);
            rjRadioButton4.MinimumSize = new Size(0, 21);
            rjRadioButton4.Name = "rjRadioButton4";
            rjRadioButton4.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton4.Size = new Size(79, 21);
            rjRadioButton4.TabIndex = 22;
            rjRadioButton4.TabStop = true;
            rjRadioButton4.Text = "Darken";
            rjRadioButton4.UnCheckedColor = Color.Black;
            rjRadioButton4.UseVisualStyleBackColor = true;
            // 
            // rjRadioButton5
            // 
            rjRadioButton5.AutoSize = true;
            rjRadioButton5.CheckedColor = Color.Purple;
            rjRadioButton5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            rjRadioButton5.ForeColor = SystemColors.ActiveCaptionText;
            rjRadioButton5.Location = new Point(6, 22);
            rjRadioButton5.MinimumSize = new Size(0, 21);
            rjRadioButton5.Name = "rjRadioButton5";
            rjRadioButton5.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton5.Size = new Size(217, 21);
            rjRadioButton5.TabIndex = 20;
            rjRadioButton5.TabStop = true;
            rjRadioButton5.Text = "Prewitt Filter (Edge Detection)";
            rjRadioButton5.UnCheckedColor = Color.Black;
            rjRadioButton5.UseVisualStyleBackColor = true;
            // 
            // rjRadioButton6
            // 
            rjRadioButton6.AutoSize = true;
            rjRadioButton6.CheckedColor = Color.Yellow;
            rjRadioButton6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            rjRadioButton6.ForeColor = SystemColors.ActiveCaptionText;
            rjRadioButton6.Location = new Point(6, 130);
            rjRadioButton6.MinimumSize = new Size(0, 21);
            rjRadioButton6.Name = "rjRadioButton6";
            rjRadioButton6.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton6.Size = new Size(110, 21);
            rjRadioButton6.TabIndex = 18;
            rjRadioButton6.TabStop = true;
            rjRadioButton6.Text = "Rgb To Gray";
            rjRadioButton6.UnCheckedColor = Color.Black;
            rjRadioButton6.UseVisualStyleBackColor = true;
            // 
            // rjRadioButton7
            // 
            rjRadioButton7.AutoSize = true;
            rjRadioButton7.CheckedColor = Color.Yellow;
            rjRadioButton7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            rjRadioButton7.ForeColor = SystemColors.ActiveCaptionText;
            rjRadioButton7.Location = new Point(6, 49);
            rjRadioButton7.MinimumSize = new Size(0, 21);
            rjRadioButton7.Name = "rjRadioButton7";
            rjRadioButton7.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton7.Size = new Size(168, 21);
            rjRadioButton7.TabIndex = 16;
            rjRadioButton7.TabStop = true;
            rjRadioButton7.Text = "Contrast enhancment";
            rjRadioButton7.UnCheckedColor = Color.Gray;
            rjRadioButton7.UseVisualStyleBackColor = true;
            // 
            // rjRadioButton8
            // 
            rjRadioButton8.AutoSize = true;
            rjRadioButton8.CheckedColor = Color.Yellow;
            rjRadioButton8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            rjRadioButton8.ForeColor = SystemColors.ActiveCaptionText;
            rjRadioButton8.Location = new Point(6, 76);
            rjRadioButton8.MinimumSize = new Size(0, 21);
            rjRadioButton8.Name = "rjRadioButton8";
            rjRadioButton8.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton8.Size = new Size(125, 21);
            rjRadioButton8.TabIndex = 15;
            rjRadioButton8.TabStop = true;
            rjRadioButton8.Text = "Laplacian Filter";
            rjRadioButton8.UnCheckedColor = Color.Black;
            rjRadioButton8.UseVisualStyleBackColor = true;
            // 
            // rjRadioButton9
            // 
            rjRadioButton9.AutoSize = true;
            rjRadioButton9.CheckedColor = Color.Yellow;
            rjRadioButton9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            rjRadioButton9.ForeColor = SystemColors.ActiveCaptionText;
            rjRadioButton9.Location = new Point(6, 103);
            rjRadioButton9.MinimumSize = new Size(0, 21);
            rjRadioButton9.Name = "rjRadioButton9";
            rjRadioButton9.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton9.Size = new Size(125, 21);
            rjRadioButton9.TabIndex = 14;
            rjRadioButton9.TabStop = true;
            rjRadioButton9.Text = "Gray To Binary";
            rjRadioButton9.UnCheckedColor = Color.Black;
            rjRadioButton9.UseVisualStyleBackColor = true;
            // 
            // rjRadioButton10
            // 
            rjRadioButton10.AutoSize = true;
            rjRadioButton10.CheckedColor = Color.Yellow;
            rjRadioButton10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            rjRadioButton10.ForeColor = SystemColors.ActiveCaptionText;
            rjRadioButton10.Location = new Point(6, 424);
            rjRadioButton10.MinimumSize = new Size(0, 21);
            rjRadioButton10.Name = "rjRadioButton10";
            rjRadioButton10.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton10.Size = new Size(183, 21);
            rjRadioButton10.TabIndex = 13;
            rjRadioButton10.TabStop = true;
            rjRadioButton10.Text = "Mean Filter (Smoothing)";
            rjRadioButton10.UnCheckedColor = Color.Black;
            rjRadioButton10.UseVisualStyleBackColor = true;
            // 
            // rjRadioButton11
            // 
            rjRadioButton11.AutoSize = true;
            rjRadioButton11.CheckedColor = Color.Yellow;
            rjRadioButton11.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            rjRadioButton11.ForeColor = SystemColors.ActiveCaptionText;
            rjRadioButton11.Location = new Point(6, 451);
            rjRadioButton11.MinimumSize = new Size(0, 21);
            rjRadioButton11.Name = "rjRadioButton11";
            rjRadioButton11.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton11.Size = new Size(217, 21);
            rjRadioButton11.TabIndex = 12;
            rjRadioButton11.TabStop = true;
            rjRadioButton11.Text = "Median Filter (Noise Removal)";
            rjRadioButton11.UnCheckedColor = Color.Black;
            rjRadioButton11.UseVisualStyleBackColor = true;
            // 
            // rjRadioButton12
            // 
            rjRadioButton12.AutoSize = true;
            rjRadioButton12.CheckedColor = Color.Yellow;
            rjRadioButton12.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            rjRadioButton12.ForeColor = SystemColors.ActiveCaptionText;
            rjRadioButton12.Location = new Point(6, 157);
            rjRadioButton12.MinimumSize = new Size(0, 21);
            rjRadioButton12.Name = "rjRadioButton12";
            rjRadioButton12.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton12.Size = new Size(203, 21);
            rjRadioButton12.TabIndex = 11;
            rjRadioButton12.TabStop = true;
            rjRadioButton12.Text = "Gaussian Filter (Smoothing)";
            rjRadioButton12.UnCheckedColor = Color.Black;
            rjRadioButton12.UseVisualStyleBackColor = true;
            // 
            // rjRadioButton13
            // 
            rjRadioButton13.AutoSize = true;
            rjRadioButton13.CheckedColor = Color.Yellow;
            rjRadioButton13.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            rjRadioButton13.ForeColor = SystemColors.ActiveCaptionText;
            rjRadioButton13.Location = new Point(6, 478);
            rjRadioButton13.MinimumSize = new Size(0, 21);
            rjRadioButton13.Name = "rjRadioButton13";
            rjRadioButton13.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton13.Size = new Size(207, 21);
            rjRadioButton13.TabIndex = 10;
            rjRadioButton13.TabStop = true;
            rjRadioButton13.Text = "Sobel Filter (Edge Detection)";
            rjRadioButton13.UnCheckedColor = Color.Black;
            rjRadioButton13.UseVisualStyleBackColor = true;
            // 
            // rjRadioButton14
            // 
            rjRadioButton14.AutoSize = true;
            rjRadioButton14.CheckedColor = Color.Purple;
            rjRadioButton14.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            rjRadioButton14.ForeColor = SystemColors.ActiveCaptionText;
            rjRadioButton14.Location = new Point(6, 345);
            rjRadioButton14.MinimumSize = new Size(0, 21);
            rjRadioButton14.Name = "rjRadioButton14";
            rjRadioButton14.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton14.Size = new Size(177, 21);
            rjRadioButton14.TabIndex = 29;
            rjRadioButton14.TabStop = true;
            rjRadioButton14.Text = "Histogram Equalization";
            rjRadioButton14.UnCheckedColor = Color.Black;
            rjRadioButton14.UseVisualStyleBackColor = true;
            // 
            // rjRadioButton15
            // 
            rjRadioButton15.AutoSize = true;
            rjRadioButton15.CheckedColor = Color.Purple;
            rjRadioButton15.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            rjRadioButton15.ForeColor = SystemColors.ActiveCaptionText;
            rjRadioButton15.Location = new Point(6, 372);
            rjRadioButton15.MinimumSize = new Size(0, 21);
            rjRadioButton15.Name = "rjRadioButton15";
            rjRadioButton15.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton15.Size = new Size(81, 21);
            rjRadioButton15.TabIndex = 28;
            rjRadioButton15.TabStop = true;
            rjRadioButton15.Text = "Lighten";
            rjRadioButton15.UnCheckedColor = Color.Black;
            rjRadioButton15.UseVisualStyleBackColor = true;
            // 
            // rjRadioButton16
            // 
            rjRadioButton16.AutoSize = true;
            rjRadioButton16.CheckedColor = Color.Purple;
            rjRadioButton16.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            rjRadioButton16.ForeColor = SystemColors.ActiveCaptionText;
            rjRadioButton16.Location = new Point(6, 399);
            rjRadioButton16.MinimumSize = new Size(0, 21);
            rjRadioButton16.Name = "rjRadioButton16";
            rjRadioButton16.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton16.Size = new Size(79, 21);
            rjRadioButton16.TabIndex = 27;
            rjRadioButton16.TabStop = true;
            rjRadioButton16.Text = "Darken";
            rjRadioButton16.UnCheckedColor = Color.Black;
            rjRadioButton16.UseVisualStyleBackColor = true;
            // 
            // rjRadioButton17
            // 
            rjRadioButton17.AutoSize = true;
            rjRadioButton17.CheckedColor = Color.Yellow;
            rjRadioButton17.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            rjRadioButton17.ForeColor = SystemColors.ActiveCaptionText;
            rjRadioButton17.Location = new Point(6, 318);
            rjRadioButton17.MinimumSize = new Size(0, 21);
            rjRadioButton17.Name = "rjRadioButton17";
            rjRadioButton17.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton17.Size = new Size(207, 21);
            rjRadioButton17.TabIndex = 26;
            rjRadioButton17.TabStop = true;
            rjRadioButton17.Text = "Sobel Filter (Edge Detection)";
            rjRadioButton17.UnCheckedColor = Color.Black;
            rjRadioButton17.UseVisualStyleBackColor = true;
            // 
            // rjRadioButton18
            // 
            rjRadioButton18.AutoSize = true;
            rjRadioButton18.CheckedColor = Color.Purple;
            rjRadioButton18.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            rjRadioButton18.ForeColor = SystemColors.ActiveCaptionText;
            rjRadioButton18.Location = new Point(3, 270);
            rjRadioButton18.MinimumSize = new Size(0, 21);
            rjRadioButton18.Name = "rjRadioButton18";
            rjRadioButton18.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton18.Size = new Size(177, 21);
            rjRadioButton18.TabIndex = 33;
            rjRadioButton18.TabStop = true;
            rjRadioButton18.Text = "Histogram Equalization";
            rjRadioButton18.UnCheckedColor = Color.Black;
            rjRadioButton18.UseVisualStyleBackColor = true;
            // 
            // rjRadioButton19
            // 
            rjRadioButton19.AutoSize = true;
            rjRadioButton19.CheckedColor = Color.Purple;
            rjRadioButton19.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            rjRadioButton19.ForeColor = SystemColors.ActiveCaptionText;
            rjRadioButton19.Location = new Point(3, 297);
            rjRadioButton19.MinimumSize = new Size(0, 21);
            rjRadioButton19.Name = "rjRadioButton19";
            rjRadioButton19.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton19.Size = new Size(81, 21);
            rjRadioButton19.TabIndex = 32;
            rjRadioButton19.TabStop = true;
            rjRadioButton19.Text = "Lighten";
            rjRadioButton19.UnCheckedColor = Color.Black;
            rjRadioButton19.UseVisualStyleBackColor = true;
            // 
            // rjRadioButton20
            // 
            rjRadioButton20.AutoSize = true;
            rjRadioButton20.CheckedColor = Color.Purple;
            rjRadioButton20.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            rjRadioButton20.ForeColor = SystemColors.ActiveCaptionText;
            rjRadioButton20.Location = new Point(3, 324);
            rjRadioButton20.MinimumSize = new Size(0, 21);
            rjRadioButton20.Name = "rjRadioButton20";
            rjRadioButton20.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton20.Size = new Size(79, 21);
            rjRadioButton20.TabIndex = 31;
            rjRadioButton20.TabStop = true;
            rjRadioButton20.Text = "Darken";
            rjRadioButton20.UnCheckedColor = Color.Black;
            rjRadioButton20.UseVisualStyleBackColor = true;
            // 
            // rjRadioButton21
            // 
            rjRadioButton21.AutoSize = true;
            rjRadioButton21.CheckedColor = Color.Yellow;
            rjRadioButton21.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            rjRadioButton21.ForeColor = SystemColors.ActiveCaptionText;
            rjRadioButton21.Location = new Point(3, 243);
            rjRadioButton21.MinimumSize = new Size(0, 21);
            rjRadioButton21.Name = "rjRadioButton21";
            rjRadioButton21.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton21.Size = new Size(207, 21);
            rjRadioButton21.TabIndex = 30;
            rjRadioButton21.TabStop = true;
            rjRadioButton21.Text = "Sobel Filter (Edge Detection)";
            rjRadioButton21.UnCheckedColor = Color.Black;
            rjRadioButton21.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(2096, 679);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "image processing";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Panel panel1;
        private GroupBox groupBox1;
        private Button btnImport;
        private Button applyBtn;
        private OpenFileDialog openFileDialog1;
        private TextBox imagePath;
        private Panel panel2;
        private PictureBox pictureBox2;
        private CustomControls.RJControls.RJRadioButton RgbToGrayRediobtn;
        private CustomControls.RJControls.RJRadioButton CERadioBtn;
        private CustomControls.RJControls.RJRadioButton LaplacianRadiobtn;
        private CustomControls.RJControls.RJRadioButton GrayToBinaryRediobtn;
        private CustomControls.RJControls.RJRadioButton meanRadioBtn;
        private CustomControls.RJControls.RJRadioButton medianRadioBtn;
        private CustomControls.RJControls.RJRadioButton blurGaussianRadioButton;
        private CustomControls.RJControls.RJRadioButton SobelFilterRadioBtn;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Panel panel5;
        private Button button4;
        private CustomControls.RJControls.RJRadioButton prewittFilterRadioBtn;
        private CustomControls.RJControls.RJRadioButton lightenRedioBtn;
        private CustomControls.RJControls.RJRadioButton darkenRadioBtn;
        private CustomControls.RJControls.RJRadioButton HERadioBtn;
        private CustomControls.RJControls.RJRadioButton lowPassRadioBtn;
        private CustomControls.RJControls.RJRadioButton rjRadioButton18;
        private CustomControls.RJControls.RJRadioButton rjRadioButton19;
        private CustomControls.RJControls.RJRadioButton rjRadioButton20;
        private CustomControls.RJControls.RJRadioButton rjRadioButton21;
        private GroupBox groupBox2;
        private CustomControls.RJControls.RJRadioButton rjRadioButton14;
        private CustomControls.RJControls.RJRadioButton rjRadioButton15;
        private CustomControls.RJControls.RJRadioButton rjRadioButton16;
        private CustomControls.RJControls.RJRadioButton rjRadioButton17;
        private CustomControls.RJControls.RJRadioButton rjRadioButton1;
        private CustomControls.RJControls.RJRadioButton rjRadioButton2;
        private CustomControls.RJControls.RJRadioButton rjRadioButton3;
        private CustomControls.RJControls.RJRadioButton rjRadioButton4;
        private CustomControls.RJControls.RJRadioButton rjRadioButton5;
        private CustomControls.RJControls.RJRadioButton rjRadioButton6;
        private CustomControls.RJControls.RJRadioButton rjRadioButton7;
        private CustomControls.RJControls.RJRadioButton rjRadioButton8;
        private CustomControls.RJControls.RJRadioButton rjRadioButton9;
        private CustomControls.RJControls.RJRadioButton rjRadioButton10;
        private CustomControls.RJControls.RJRadioButton rjRadioButton11;
        private CustomControls.RJControls.RJRadioButton rjRadioButton12;
        private CustomControls.RJControls.RJRadioButton rjRadioButton13;
    }
}

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
            textBox1 = new TextBox();
            rjRadioButton2 = new CustomControls.RJControls.RJRadioButton();
            imagePath = new TextBox();
            btnImport = new Button();
            button1 = new Button();
            rjRadioButton4 = new CustomControls.RJControls.RJRadioButton();
            rjRadioButton3 = new CustomControls.RJControls.RJRadioButton();
            rjRadioButton1 = new CustomControls.RJControls.RJRadioButton();
            rjRadioButton16 = new CustomControls.RJControls.RJRadioButton();
            rjRadioButton15 = new CustomControls.RJControls.RJRadioButton();
            rjRadioButton14 = new CustomControls.RJControls.RJRadioButton();
            rjRadioButton13 = new CustomControls.RJControls.RJRadioButton();
            rjRadioButton11 = new CustomControls.RJControls.RJRadioButton();
            rjRadioButton18 = new CustomControls.RJControls.RJRadioButton();
            rjRadioButton19 = new CustomControls.RJControls.RJRadioButton();
            rjRadioButton6 = new CustomControls.RJControls.RJRadioButton();
            rjRadioButton12 = new CustomControls.RJControls.RJRadioButton();
            rjRadioButton5 = new CustomControls.RJControls.RJRadioButton();
            rjRadioButton9 = new CustomControls.RJControls.RJRadioButton();
            rjRadioButton8 = new CustomControls.RJControls.RJRadioButton();
            rjRadioButton7 = new CustomControls.RJControls.RJRadioButton();
            lowPassRadioBtn = new CustomControls.RJControls.RJRadioButton();
            rjRadioButton17 = new CustomControls.RJControls.RJRadioButton();
            rjRadioButton20 = new CustomControls.RJControls.RJRadioButton();
            HERadioBtn = new CustomControls.RJControls.RJRadioButton();
            rjRadioButton21 = new CustomControls.RJControls.RJRadioButton();
            rjRadioButton10 = new CustomControls.RJControls.RJRadioButton();
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
            panel1 = new Panel();
            button3 = new Button();
            rjRadioButton22 = new CustomControls.RJControls.RJRadioButton();
            rjRadioButton23 = new CustomControls.RJControls.RJRadioButton();
            rjRadioButton24 = new CustomControls.RJControls.RJRadioButton();
            rjRadioButton25 = new CustomControls.RJControls.RJRadioButton();
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
            pictureBox1.Size = new Size(757, 445);
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
            pictureBox2.Location = new Point(3, 454);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(757, 456);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Showcard Gothic", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(328, 696);
            button2.Name = "button2";
            button2.Size = new Size(313, 144);
            button2.TabIndex = 14;
            button2.Text = "Undo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += undoBtn_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Showcard Gothic", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(9, 696);
            button4.Name = "button4";
            button4.Size = new Size(316, 144);
            button4.TabIndex = 15;
            button4.Text = "Redo";
            button4.UseVisualStyleBackColor = true;
            button4.Click += redoBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LavenderBlush;
            groupBox1.Controls.Add(rjRadioButton22);
            groupBox1.Controls.Add(rjRadioButton23);
            groupBox1.Controls.Add(rjRadioButton24);
            groupBox1.Controls.Add(rjRadioButton25);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(rjRadioButton2);
            groupBox1.Controls.Add(imagePath);
            groupBox1.Controls.Add(btnImport);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(rjRadioButton4);
            groupBox1.Controls.Add(rjRadioButton3);
            groupBox1.Controls.Add(rjRadioButton1);
            groupBox1.Controls.Add(rjRadioButton16);
            groupBox1.Controls.Add(rjRadioButton15);
            groupBox1.Controls.Add(rjRadioButton14);
            groupBox1.Controls.Add(rjRadioButton13);
            groupBox1.Controls.Add(rjRadioButton11);
            groupBox1.Controls.Add(rjRadioButton18);
            groupBox1.Controls.Add(rjRadioButton19);
            groupBox1.Controls.Add(rjRadioButton6);
            groupBox1.Controls.Add(rjRadioButton12);
            groupBox1.Controls.Add(rjRadioButton5);
            groupBox1.Controls.Add(rjRadioButton9);
            groupBox1.Controls.Add(rjRadioButton8);
            groupBox1.Controls.Add(rjRadioButton7);
            groupBox1.Controls.Add(lowPassRadioBtn);
            groupBox1.Controls.Add(rjRadioButton17);
            groupBox1.Controls.Add(rjRadioButton20);
            groupBox1.Controls.Add(HERadioBtn);
            groupBox1.Controls.Add(rjRadioButton21);
            groupBox1.Controls.Add(rjRadioButton10);
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
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(3, -13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(657, 926);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(322, 648);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(313, 23);
            textBox1.TabIndex = 13;
            // 
            // rjRadioButton2
            // 
            rjRadioButton2.AutoSize = true;
            rjRadioButton2.CheckedColor = Color.Purple;
            rjRadioButton2.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            rjRadioButton2.ForeColor = Color.Black;
            rjRadioButton2.Location = new Point(346, 328);
            rjRadioButton2.MinimumSize = new Size(0, 21);
            rjRadioButton2.Name = "rjRadioButton2";
            rjRadioButton2.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton2.Size = new Size(197, 26);
            rjRadioButton2.TabIndex = 24;
            rjRadioButton2.TabStop = true;
            rjRadioButton2.Text = "Ideal Low Pass Filter";
            rjRadioButton2.UnCheckedColor = Color.Black;
            rjRadioButton2.UseVisualStyleBackColor = true;
            // 
            // imagePath
            // 
            imagePath.Location = new Point(6, 648);
            imagePath.Name = "imagePath";
            imagePath.Size = new Size(316, 23);
            imagePath.TabIndex = 10;
            imagePath.TextChanged += imagePath_TextChanged;
            // 
            // btnImport
            // 
            btnImport.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnImport.Location = new Point(6, 608);
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
            button1.Location = new Point(322, 608);
            button1.Name = "button1";
            button1.Size = new Size(316, 34);
            button1.TabIndex = 12;
            button1.Text = "export";
            button1.UseVisualStyleBackColor = true;
            button1.Click += exportBtn_Click;
            // 
            // rjRadioButton4
            // 
            rjRadioButton4.AutoSize = true;
            rjRadioButton4.CheckedColor = Color.Purple;
            rjRadioButton4.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            rjRadioButton4.ForeColor = Color.Black;
            rjRadioButton4.Location = new Point(346, 390);
            rjRadioButton4.MinimumSize = new Size(0, 21);
            rjRadioButton4.Name = "rjRadioButton4";
            rjRadioButton4.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton4.Size = new Size(261, 26);
            rjRadioButton4.TabIndex = 22;
            rjRadioButton4.TabStop = true;
            rjRadioButton4.Text = "Butter Worth Low Pass Filter";
            rjRadioButton4.UnCheckedColor = Color.Black;
            rjRadioButton4.UseVisualStyleBackColor = true;
            // 
            // rjRadioButton3
            // 
            rjRadioButton3.AutoSize = true;
            rjRadioButton3.CheckedColor = Color.Purple;
            rjRadioButton3.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            rjRadioButton3.ForeColor = Color.Black;
            rjRadioButton3.Location = new Point(346, 359);
            rjRadioButton3.MinimumSize = new Size(0, 21);
            rjRadioButton3.Name = "rjRadioButton3";
            rjRadioButton3.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton3.Size = new Size(202, 26);
            rjRadioButton3.TabIndex = 23;
            rjRadioButton3.TabStop = true;
            rjRadioButton3.Text = "Ideal High Pass Filter";
            rjRadioButton3.UnCheckedColor = Color.Black;
            rjRadioButton3.UseVisualStyleBackColor = true;
            // 
            // rjRadioButton1
            // 
            rjRadioButton1.AutoSize = true;
            rjRadioButton1.CheckedColor = Color.Purple;
            rjRadioButton1.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            rjRadioButton1.ForeColor = Color.Black;
            rjRadioButton1.Location = new Point(346, 230);
            rjRadioButton1.MinimumSize = new Size(0, 21);
            rjRadioButton1.Name = "rjRadioButton1";
            rjRadioButton1.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton1.Size = new Size(118, 26);
            rjRadioButton1.TabIndex = 25;
            rjRadioButton1.TabStop = true;
            rjRadioButton1.Text = "Max Filter";
            rjRadioButton1.UnCheckedColor = Color.Black;
            rjRadioButton1.UseVisualStyleBackColor = true;
            // 
            // rjRadioButton16
            // 
            rjRadioButton16.AutoSize = true;
            rjRadioButton16.CheckedColor = Color.Purple;
            rjRadioButton16.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            rjRadioButton16.ForeColor = Color.Black;
            rjRadioButton16.Location = new Point(346, 443);
            rjRadioButton16.MinimumSize = new Size(0, 21);
            rjRadioButton16.Name = "rjRadioButton16";
            rjRadioButton16.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton16.Size = new Size(226, 26);
            rjRadioButton16.TabIndex = 27;
            rjRadioButton16.TabStop = true;
            rjRadioButton16.Text = "Gaussian Low Pass Filter";
            rjRadioButton16.UnCheckedColor = Color.Black;
            rjRadioButton16.UseVisualStyleBackColor = true;
            // 
            // rjRadioButton15
            // 
            rjRadioButton15.AutoSize = true;
            rjRadioButton15.CheckedColor = Color.Purple;
            rjRadioButton15.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            rjRadioButton15.ForeColor = Color.Black;
            rjRadioButton15.Location = new Point(346, 465);
            rjRadioButton15.MinimumSize = new Size(0, 21);
            rjRadioButton15.Name = "rjRadioButton15";
            rjRadioButton15.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton15.Size = new Size(231, 26);
            rjRadioButton15.TabIndex = 28;
            rjRadioButton15.TabStop = true;
            rjRadioButton15.Text = "Gaussian High Pass Filter";
            rjRadioButton15.UnCheckedColor = Color.Black;
            rjRadioButton15.UseVisualStyleBackColor = true;
            // 
            // rjRadioButton14
            // 
            rjRadioButton14.AutoSize = true;
            rjRadioButton14.CheckedColor = Color.Purple;
            rjRadioButton14.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            rjRadioButton14.ForeColor = Color.Black;
            rjRadioButton14.Location = new Point(346, 488);
            rjRadioButton14.MinimumSize = new Size(0, 21);
            rjRadioButton14.Name = "rjRadioButton14";
            rjRadioButton14.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton14.Size = new Size(125, 26);
            rjRadioButton14.TabIndex = 29;
            rjRadioButton14.TabStop = true;
            rjRadioButton14.Text = "salt & pepper";
            rjRadioButton14.UnCheckedColor = Color.Black;
            rjRadioButton14.UseVisualStyleBackColor = true;
            // 
            // rjRadioButton13
            // 
            rjRadioButton13.AutoSize = true;
            rjRadioButton13.CheckedColor = Color.Purple;
            rjRadioButton13.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            rjRadioButton13.ForeColor = Color.Black;
            rjRadioButton13.Location = new Point(346, 292);
            rjRadioButton13.MinimumSize = new Size(0, 21);
            rjRadioButton13.Name = "rjRadioButton13";
            rjRadioButton13.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton13.Size = new Size(236, 26);
            rjRadioButton13.TabIndex = 10;
            rjRadioButton13.TabStop = true;
            rjRadioButton13.Text = "Inverse Fourier Transform";
            rjRadioButton13.UnCheckedColor = Color.Black;
            rjRadioButton13.UseVisualStyleBackColor = true;
            // 
            // rjRadioButton11
            // 
            rjRadioButton11.AutoSize = true;
            rjRadioButton11.CheckedColor = Color.Purple;
            rjRadioButton11.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            rjRadioButton11.ForeColor = Color.Black;
            rjRadioButton11.Location = new Point(346, 261);
            rjRadioButton11.MinimumSize = new Size(0, 21);
            rjRadioButton11.Name = "rjRadioButton11";
            rjRadioButton11.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton11.Size = new Size(177, 26);
            rjRadioButton11.TabIndex = 12;
            rjRadioButton11.TabStop = true;
            rjRadioButton11.Text = "Fourier Transform";
            rjRadioButton11.UnCheckedColor = Color.Black;
            rjRadioButton11.UseVisualStyleBackColor = true;
            // 
            // rjRadioButton18
            // 
            rjRadioButton18.AutoSize = true;
            rjRadioButton18.CheckedColor = Color.Purple;
            rjRadioButton18.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            rjRadioButton18.ForeColor = Color.Black;
            rjRadioButton18.Location = new Point(5, 418);
            rjRadioButton18.MinimumSize = new Size(0, 21);
            rjRadioButton18.Name = "rjRadioButton18";
            rjRadioButton18.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton18.Size = new Size(166, 26);
            rjRadioButton18.TabIndex = 33;
            rjRadioButton18.TabStop = true;
            rjRadioButton18.Text = "Point Sharpening";
            rjRadioButton18.UnCheckedColor = Color.Black;
            rjRadioButton18.UseVisualStyleBackColor = true;
            // 
            // rjRadioButton19
            // 
            rjRadioButton19.AutoSize = true;
            rjRadioButton19.CheckedColor = Color.Purple;
            rjRadioButton19.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            rjRadioButton19.ForeColor = Color.Black;
            rjRadioButton19.Location = new Point(4, 450);
            rjRadioButton19.MinimumSize = new Size(0, 21);
            rjRadioButton19.Name = "rjRadioButton19";
            rjRadioButton19.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton19.Size = new Size(157, 26);
            rjRadioButton19.TabIndex = 32;
            rjRadioButton19.TabStop = true;
            rjRadioButton19.Text = "Line sharpening";
            rjRadioButton19.UnCheckedColor = Color.Black;
            rjRadioButton19.UseVisualStyleBackColor = true;
            // 
            // rjRadioButton6
            // 
            rjRadioButton6.AutoSize = true;
            rjRadioButton6.CheckedColor = Color.Purple;
            rjRadioButton6.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            rjRadioButton6.ForeColor = Color.Black;
            rjRadioButton6.Location = new Point(346, 156);
            rjRadioButton6.MinimumSize = new Size(0, 21);
            rjRadioButton6.Name = "rjRadioButton6";
            rjRadioButton6.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton6.Size = new Size(179, 26);
            rjRadioButton6.TabIndex = 18;
            rjRadioButton6.TabStop = true;
            rjRadioButton6.Text = "Gamma Correction";
            rjRadioButton6.UnCheckedColor = Color.Black;
            rjRadioButton6.UseVisualStyleBackColor = true;
            // 
            // rjRadioButton12
            // 
            rjRadioButton12.AutoSize = true;
            rjRadioButton12.CheckedColor = Color.Purple;
            rjRadioButton12.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            rjRadioButton12.ForeColor = Color.Black;
            rjRadioButton12.Location = new Point(346, 199);
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
            rjRadioButton5.Location = new Point(345, 37);
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
            // rjRadioButton9
            // 
            rjRadioButton9.AutoSize = true;
            rjRadioButton9.CheckedColor = Color.Purple;
            rjRadioButton9.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            rjRadioButton9.ForeColor = Color.Black;
            rjRadioButton9.Location = new Point(346, 130);
            rjRadioButton9.MinimumSize = new Size(0, 21);
            rjRadioButton9.Name = "rjRadioButton9";
            rjRadioButton9.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton9.Size = new Size(73, 26);
            rjRadioButton9.TabIndex = 14;
            rjRadioButton9.TabStop = true;
            rjRadioButton9.Text = "LOG";
            rjRadioButton9.UnCheckedColor = Color.Black;
            rjRadioButton9.UseVisualStyleBackColor = true;
            // 
            // rjRadioButton8
            // 
            rjRadioButton8.AutoSize = true;
            rjRadioButton8.CheckedColor = Color.Purple;
            rjRadioButton8.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            rjRadioButton8.ForeColor = Color.Black;
            rjRadioButton8.Location = new Point(346, 99);
            rjRadioButton8.MinimumSize = new Size(0, 21);
            rjRadioButton8.Name = "rjRadioButton8";
            rjRadioButton8.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton8.Size = new Size(117, 26);
            rjRadioButton8.TabIndex = 15;
            rjRadioButton8.TabStop = true;
            rjRadioButton8.Text = "Histogram";
            rjRadioButton8.UnCheckedColor = Color.Black;
            rjRadioButton8.UseVisualStyleBackColor = true;
            // 
            // rjRadioButton7
            // 
            rjRadioButton7.AutoSize = true;
            rjRadioButton7.CheckedColor = Color.Purple;
            rjRadioButton7.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            rjRadioButton7.ForeColor = Color.Black;
            rjRadioButton7.Location = new Point(346, 68);
            rjRadioButton7.MinimumSize = new Size(0, 21);
            rjRadioButton7.Name = "rjRadioButton7";
            rjRadioButton7.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton7.Size = new Size(105, 26);
            rjRadioButton7.TabIndex = 16;
            rjRadioButton7.TabStop = true;
            rjRadioButton7.Text = "Negative";
            rjRadioButton7.UnCheckedColor = Color.Black;
            rjRadioButton7.UseVisualStyleBackColor = true;
            // 
            // lowPassRadioBtn
            // 
            lowPassRadioBtn.AutoSize = true;
            lowPassRadioBtn.CheckedColor = Color.Purple;
            lowPassRadioBtn.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            lowPassRadioBtn.ForeColor = Color.Black;
            lowPassRadioBtn.Location = new Point(6, 362);
            lowPassRadioBtn.MinimumSize = new Size(0, 21);
            lowPassRadioBtn.Name = "lowPassRadioBtn";
            lowPassRadioBtn.Padding = new Padding(10, 0, 0, 0);
            lowPassRadioBtn.Size = new Size(136, 26);
            lowPassRadioBtn.TabIndex = 25;
            lowPassRadioBtn.TabStop = true;
            lowPassRadioBtn.Text = "Weight filter";
            lowPassRadioBtn.UnCheckedColor = Color.Black;
            lowPassRadioBtn.UseVisualStyleBackColor = true;
            // 
            // rjRadioButton17
            // 
            rjRadioButton17.AutoSize = true;
            rjRadioButton17.CheckedColor = Color.Purple;
            rjRadioButton17.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            rjRadioButton17.ForeColor = Color.Black;
            rjRadioButton17.Location = new Point(346, 513);
            rjRadioButton17.MinimumSize = new Size(0, 21);
            rjRadioButton17.Name = "rjRadioButton17";
            rjRadioButton17.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton17.Size = new Size(148, 26);
            rjRadioButton17.TabIndex = 26;
            rjRadioButton17.TabStop = true;
            rjRadioButton17.Text = "rayleigh_noise";
            rjRadioButton17.UnCheckedColor = Color.Black;
            rjRadioButton17.UseVisualStyleBackColor = true;
            rjRadioButton17.CheckedChanged += rjRadioButton17_CheckedChanged;
            // 
            // rjRadioButton20
            // 
            rjRadioButton20.AutoSize = true;
            rjRadioButton20.CheckedColor = Color.Purple;
            rjRadioButton20.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            rjRadioButton20.ForeColor = Color.Black;
            rjRadioButton20.Location = new Point(4, 482);
            rjRadioButton20.MinimumSize = new Size(0, 21);
            rjRadioButton20.Name = "rjRadioButton20";
            rjRadioButton20.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton20.Size = new Size(117, 26);
            rjRadioButton20.TabIndex = 31;
            rjRadioButton20.TabStop = true;
            rjRadioButton20.Text = "Min Filter";
            rjRadioButton20.UnCheckedColor = Color.Black;
            rjRadioButton20.UseVisualStyleBackColor = true;
            // 
            // HERadioBtn
            // 
            HERadioBtn.AutoSize = true;
            HERadioBtn.CheckedColor = Color.Purple;
            HERadioBtn.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            HERadioBtn.ForeColor = Color.Black;
            HERadioBtn.Location = new Point(5, 233);
            HERadioBtn.MinimumSize = new Size(0, 21);
            HERadioBtn.Name = "HERadioBtn";
            HERadioBtn.Padding = new Padding(10, 0, 0, 0);
            HERadioBtn.Size = new Size(216, 26);
            HERadioBtn.TabIndex = 24;
            HERadioBtn.TabStop = true;
            HERadioBtn.Text = "Histogram Equalization";
            HERadioBtn.UnCheckedColor = Color.Black;
            HERadioBtn.UseVisualStyleBackColor = true;
            // 
            // rjRadioButton21
            // 
            rjRadioButton21.AutoSize = true;
            rjRadioButton21.CheckedColor = Color.Purple;
            rjRadioButton21.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            rjRadioButton21.ForeColor = Color.Black;
            rjRadioButton21.Location = new Point(5, 390);
            rjRadioButton21.MinimumSize = new Size(0, 21);
            rjRadioButton21.Name = "rjRadioButton21";
            rjRadioButton21.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton21.Size = new Size(156, 26);
            rjRadioButton21.TabIndex = 30;
            rjRadioButton21.TabStop = true;
            rjRadioButton21.Text = "Point Detection";
            rjRadioButton21.UnCheckedColor = Color.Black;
            rjRadioButton21.UseVisualStyleBackColor = true;
            rjRadioButton21.CheckedChanged += rjRadioButton21_CheckedChanged;
            // 
            // rjRadioButton10
            // 
            rjRadioButton10.AutoSize = true;
            rjRadioButton10.CheckedColor = Color.Purple;
            rjRadioButton10.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            rjRadioButton10.ForeColor = Color.Black;
            rjRadioButton10.Location = new Point(346, 421);
            rjRadioButton10.MinimumSize = new Size(0, 21);
            rjRadioButton10.Name = "rjRadioButton10";
            rjRadioButton10.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton10.Size = new Size(266, 26);
            rjRadioButton10.TabIndex = 13;
            rjRadioButton10.TabStop = true;
            rjRadioButton10.Text = "Butter Worth High Pass Filter";
            rjRadioButton10.UnCheckedColor = Color.Black;
            rjRadioButton10.UseVisualStyleBackColor = true;
            rjRadioButton10.CheckedChanged += rjRadioButton10_CheckedChanged;
            // 
            // lightenRedioBtn
            // 
            lightenRedioBtn.AutoSize = true;
            lightenRedioBtn.CheckedColor = Color.Purple;
            lightenRedioBtn.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            lightenRedioBtn.ForeColor = Color.Black;
            lightenRedioBtn.Location = new Point(5, 257);
            lightenRedioBtn.MinimumSize = new Size(0, 21);
            lightenRedioBtn.Name = "lightenRedioBtn";
            lightenRedioBtn.Padding = new Padding(10, 0, 0, 0);
            lightenRedioBtn.Size = new Size(95, 26);
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
            darkenRadioBtn.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            darkenRadioBtn.ForeColor = Color.Black;
            darkenRadioBtn.Location = new Point(6, 280);
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
            prewittFilterRadioBtn.Location = new Point(5, 39);
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
            // RgbToGrayRediobtn
            // 
            RgbToGrayRediobtn.AutoSize = true;
            RgbToGrayRediobtn.CheckedColor = Color.Purple;
            RgbToGrayRediobtn.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            RgbToGrayRediobtn.ForeColor = Color.Black;
            RgbToGrayRediobtn.Location = new Point(5, 153);
            RgbToGrayRediobtn.MinimumSize = new Size(0, 21);
            RgbToGrayRediobtn.Name = "RgbToGrayRediobtn";
            RgbToGrayRediobtn.Padding = new Padding(10, 0, 0, 0);
            RgbToGrayRediobtn.Size = new Size(133, 26);
            RgbToGrayRediobtn.TabIndex = 18;
            RgbToGrayRediobtn.TabStop = true;
            RgbToGrayRediobtn.Text = "Rgb To Gray";
            RgbToGrayRediobtn.UnCheckedColor = Color.Black;
            RgbToGrayRediobtn.UseVisualStyleBackColor = true;
            // 
            // CERadioBtn
            // 
            CERadioBtn.AutoSize = true;
            CERadioBtn.CheckedColor = Color.Purple;
            CERadioBtn.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            CERadioBtn.ForeColor = Color.Black;
            CERadioBtn.Location = new Point(6, 68);
            CERadioBtn.MinimumSize = new Size(0, 21);
            CERadioBtn.Name = "CERadioBtn";
            CERadioBtn.Padding = new Padding(10, 0, 0, 0);
            CERadioBtn.Size = new Size(183, 26);
            CERadioBtn.TabIndex = 16;
            CERadioBtn.TabStop = true;
            CERadioBtn.Text = "Contrast Stretching";
            CERadioBtn.UnCheckedColor = Color.Black;
            CERadioBtn.UseVisualStyleBackColor = true;
            CERadioBtn.CheckedChanged += CERadioBtn_CheckedChanged;
            // 
            // LaplacianRadiobtn
            // 
            LaplacianRadiobtn.AutoSize = true;
            LaplacianRadiobtn.CheckedColor = Color.Purple;
            LaplacianRadiobtn.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            LaplacianRadiobtn.ForeColor = Color.Black;
            LaplacianRadiobtn.Location = new Point(5, 96);
            LaplacianRadiobtn.MinimumSize = new Size(0, 21);
            LaplacianRadiobtn.Name = "LaplacianRadiobtn";
            LaplacianRadiobtn.Padding = new Padding(10, 0, 0, 0);
            LaplacianRadiobtn.Size = new Size(158, 26);
            LaplacianRadiobtn.TabIndex = 15;
            LaplacianRadiobtn.TabStop = true;
            LaplacianRadiobtn.Text = "Laplacian Filter";
            LaplacianRadiobtn.UnCheckedColor = Color.Black;
            LaplacianRadiobtn.UseVisualStyleBackColor = true;
            // 
            // GrayToBinaryRediobtn
            // 
            GrayToBinaryRediobtn.AutoSize = true;
            GrayToBinaryRediobtn.CheckedColor = Color.Purple;
            GrayToBinaryRediobtn.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            GrayToBinaryRediobtn.ForeColor = Color.Black;
            GrayToBinaryRediobtn.Location = new Point(5, 124);
            GrayToBinaryRediobtn.MinimumSize = new Size(0, 21);
            GrayToBinaryRediobtn.Name = "GrayToBinaryRediobtn";
            GrayToBinaryRediobtn.Padding = new Padding(10, 0, 0, 0);
            GrayToBinaryRediobtn.Size = new Size(154, 26);
            GrayToBinaryRediobtn.TabIndex = 14;
            GrayToBinaryRediobtn.TabStop = true;
            GrayToBinaryRediobtn.Text = "Gray To Binary";
            GrayToBinaryRediobtn.UnCheckedColor = Color.Black;
            GrayToBinaryRediobtn.UseVisualStyleBackColor = true;
            // 
            // meanRadioBtn
            // 
            meanRadioBtn.AutoSize = true;
            meanRadioBtn.CheckedColor = Color.Purple;
            meanRadioBtn.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            meanRadioBtn.ForeColor = Color.Black;
            meanRadioBtn.Location = new Point(5, 336);
            meanRadioBtn.MinimumSize = new Size(0, 21);
            meanRadioBtn.Name = "meanRadioBtn";
            meanRadioBtn.Padding = new Padding(10, 0, 0, 0);
            meanRadioBtn.Size = new Size(224, 26);
            meanRadioBtn.TabIndex = 13;
            meanRadioBtn.TabStop = true;
            meanRadioBtn.Text = "Mean Filter (Smoothing)";
            meanRadioBtn.UnCheckedColor = Color.Black;
            meanRadioBtn.UseVisualStyleBackColor = true;
            // 
            // medianRadioBtn
            // 
            medianRadioBtn.AutoSize = true;
            medianRadioBtn.CheckedColor = Color.Purple;
            medianRadioBtn.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            medianRadioBtn.ForeColor = Color.Black;
            medianRadioBtn.Location = new Point(5, 308);
            medianRadioBtn.MinimumSize = new Size(0, 21);
            medianRadioBtn.Name = "medianRadioBtn";
            medianRadioBtn.Padding = new Padding(10, 0, 0, 0);
            medianRadioBtn.Size = new Size(272, 26);
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
            blurGaussianRadioButton.CheckedColor = Color.Purple;
            blurGaussianRadioButton.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            blurGaussianRadioButton.ForeColor = Color.Black;
            blurGaussianRadioButton.Location = new Point(5, 178);
            blurGaussianRadioButton.MinimumSize = new Size(0, 21);
            blurGaussianRadioButton.Name = "blurGaussianRadioButton";
            blurGaussianRadioButton.Padding = new Padding(10, 0, 0, 0);
            blurGaussianRadioButton.Size = new Size(249, 26);
            blurGaussianRadioButton.TabIndex = 11;
            blurGaussianRadioButton.TabStop = true;
            blurGaussianRadioButton.Text = "Gaussian Filter (Smoothing)";
            blurGaussianRadioButton.UnCheckedColor = Color.Black;
            blurGaussianRadioButton.UseVisualStyleBackColor = true;
            // 
            // SobelFilterRadioBtn
            // 
            SobelFilterRadioBtn.AutoSize = true;
            SobelFilterRadioBtn.CheckedColor = Color.Purple;
            SobelFilterRadioBtn.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            SobelFilterRadioBtn.ForeColor = Color.Black;
            SobelFilterRadioBtn.Location = new Point(4, 210);
            SobelFilterRadioBtn.MinimumSize = new Size(0, 21);
            SobelFilterRadioBtn.Name = "SobelFilterRadioBtn";
            SobelFilterRadioBtn.Padding = new Padding(10, 0, 0, 0);
            SobelFilterRadioBtn.Size = new Size(258, 26);
            SobelFilterRadioBtn.TabIndex = 10;
            SobelFilterRadioBtn.TabStop = true;
            SobelFilterRadioBtn.Text = "Sobel Filter (Edge Detection)";
            SobelFilterRadioBtn.UnCheckedColor = Color.Black;
            SobelFilterRadioBtn.UseVisualStyleBackColor = true;
            SobelFilterRadioBtn.CheckedChanged += SobelFilterRadioBtn_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LavenderBlush;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(657, 913);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // button3
            // 
            button3.Font = new Font("Stencil", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(12, 846);
            button3.Name = "button3";
            button3.Size = new Size(626, 55);
            button3.TabIndex = 16;
            button3.Text = "Apply Filter ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Apply_Filter;
            // 
            // rjRadioButton22
            // 
            rjRadioButton22.AutoSize = true;
            rjRadioButton22.CheckedColor = Color.Purple;
            rjRadioButton22.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            rjRadioButton22.ForeColor = Color.Black;
            rjRadioButton22.Location = new Point(346, 562);
            rjRadioButton22.MinimumSize = new Size(0, 21);
            rjRadioButton22.Name = "rjRadioButton22";
            rjRadioButton22.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton22.Size = new Size(142, 26);
            rjRadioButton22.TabIndex = 37;
            rjRadioButton22.TabStop = true;
            rjRadioButton22.Text = "Gamma_noise";
            rjRadioButton22.UnCheckedColor = Color.Black;
            rjRadioButton22.UseVisualStyleBackColor = true;
            // 
            // rjRadioButton23
            // 
            rjRadioButton23.AutoSize = true;
            rjRadioButton23.CheckedColor = Color.Purple;
            rjRadioButton23.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            rjRadioButton23.ForeColor = Color.Black;
            rjRadioButton23.Location = new Point(346, 539);
            rjRadioButton23.MinimumSize = new Size(0, 21);
            rjRadioButton23.Name = "rjRadioButton23";
            rjRadioButton23.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton23.Size = new Size(174, 26);
            rjRadioButton23.TabIndex = 34;
            rjRadioButton23.TabStop = true;
            rjRadioButton23.Text = "Exponential_noise";
            rjRadioButton23.UnCheckedColor = Color.Black;
            rjRadioButton23.UseVisualStyleBackColor = true;
            rjRadioButton23.CheckedChanged += rjRadioButton23_CheckedChanged;
            // 
            // rjRadioButton24
            // 
            rjRadioButton24.AutoSize = true;
            rjRadioButton24.CheckedColor = Color.Purple;
            rjRadioButton24.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            rjRadioButton24.ForeColor = Color.Black;
            rjRadioButton24.Location = new Point(0, 514);
            rjRadioButton24.MinimumSize = new Size(0, 21);
            rjRadioButton24.Name = "rjRadioButton24";
            rjRadioButton24.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton24.Size = new Size(146, 26);
            rjRadioButton24.TabIndex = 36;
            rjRadioButton24.TabStop = true;
            rjRadioButton24.Text = "uniform_noise";
            rjRadioButton24.UnCheckedColor = Color.Black;
            rjRadioButton24.UseVisualStyleBackColor = true;
            // 
            // rjRadioButton25
            // 
            rjRadioButton25.AutoSize = true;
            rjRadioButton25.CheckedColor = Color.Purple;
            rjRadioButton25.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            rjRadioButton25.ForeColor = Color.Black;
            rjRadioButton25.Location = new Point(0, 546);
            rjRadioButton25.MinimumSize = new Size(0, 21);
            rjRadioButton25.Name = "rjRadioButton25";
            rjRadioButton25.Padding = new Padding(10, 0, 0, 0);
            rjRadioButton25.Size = new Size(149, 26);
            rjRadioButton25.TabIndex = 35;
            rjRadioButton25.TabStop = true;
            rjRadioButton25.Text = "gaussian_noise";
            rjRadioButton25.UnCheckedColor = Color.Black;
            rjRadioButton25.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1427, 913);
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
        private CustomControls.RJControls.RJRadioButton rjRadioButton2;
        private TextBox imagePath;
        private Button btnImport;
        private Button button1;
        private CustomControls.RJControls.RJRadioButton rjRadioButton4;
        private CustomControls.RJControls.RJRadioButton rjRadioButton3;
        private CustomControls.RJControls.RJRadioButton rjRadioButton1;
        private CustomControls.RJControls.RJRadioButton rjRadioButton16;
        private CustomControls.RJControls.RJRadioButton rjRadioButton15;
        private CustomControls.RJControls.RJRadioButton rjRadioButton14;
        private CustomControls.RJControls.RJRadioButton rjRadioButton13;
        private CustomControls.RJControls.RJRadioButton rjRadioButton11;
        private CustomControls.RJControls.RJRadioButton rjRadioButton18;
        private CustomControls.RJControls.RJRadioButton rjRadioButton19;
        private CustomControls.RJControls.RJRadioButton rjRadioButton6;
        private CustomControls.RJControls.RJRadioButton rjRadioButton12;
        private CustomControls.RJControls.RJRadioButton rjRadioButton5;
        private CustomControls.RJControls.RJRadioButton rjRadioButton9;
        private CustomControls.RJControls.RJRadioButton rjRadioButton8;
        private CustomControls.RJControls.RJRadioButton rjRadioButton7;
        private CustomControls.RJControls.RJRadioButton lowPassRadioBtn;
        private CustomControls.RJControls.RJRadioButton rjRadioButton17;
        private CustomControls.RJControls.RJRadioButton rjRadioButton20;
        private CustomControls.RJControls.RJRadioButton HERadioBtn;
        private CustomControls.RJControls.RJRadioButton rjRadioButton21;
        private CustomControls.RJControls.RJRadioButton rjRadioButton10;
        private CustomControls.RJControls.RJRadioButton lightenRedioBtn;
        private CustomControls.RJControls.RJRadioButton darkenRadioBtn;
        private CustomControls.RJControls.RJRadioButton prewittFilterRadioBtn;
        private CustomControls.RJControls.RJRadioButton RgbToGrayRediobtn;
        private CustomControls.RJControls.RJRadioButton CERadioBtn;
        private CustomControls.RJControls.RJRadioButton LaplacianRadiobtn;
        private CustomControls.RJControls.RJRadioButton GrayToBinaryRediobtn;
        private CustomControls.RJControls.RJRadioButton meanRadioBtn;
        private CustomControls.RJControls.RJRadioButton medianRadioBtn;
        private CustomControls.RJControls.RJRadioButton blurGaussianRadioButton;
        private CustomControls.RJControls.RJRadioButton SobelFilterRadioBtn;
        private Panel panel1;
        private Button button3;
        private CustomControls.RJControls.RJRadioButton rjRadioButton22;
        private CustomControls.RJControls.RJRadioButton rjRadioButton23;
        private CustomControls.RJControls.RJRadioButton rjRadioButton24;
        private CustomControls.RJControls.RJRadioButton rjRadioButton25;
    }
}

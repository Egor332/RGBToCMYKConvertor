namespace RGBToCMYKConvertor
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
            curvePictureBox = new PictureBox();
            cyanRadioButton = new RadioButton();
            magentaRadioButton = new RadioButton();
            yellowRadioButton = new RadioButton();
            blackRadioButton = new RadioButton();
            allCurvesCheckBox = new CheckBox();
            reduction0Button = new Button();
            reduction100Button = new Button();
            UCRButton = new Button();
            GCRButton = new Button();
            changeButton = new Button();
            saveCurveButton = new Button();
            loadCurveButton = new Button();
            savePicturesButton = new Button();
            originalPictureBox = new PictureBox();
            cyanPictureBox = new PictureBox();
            magentaPictureBox = new PictureBox();
            yellowPictureBox = new PictureBox();
            blackPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)curvePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)originalPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cyanPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)magentaPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yellowPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)blackPictureBox).BeginInit();
            SuspendLayout();
            // 
            // curvePictureBox
            // 
            curvePictureBox.BackColor = SystemColors.ControlLight;
            curvePictureBox.Location = new Point(14, 16);
            curvePictureBox.Margin = new Padding(3, 4, 3, 4);
            curvePictureBox.Name = "curvePictureBox";
            curvePictureBox.Size = new Size(440, 513);
            curvePictureBox.TabIndex = 0;
            curvePictureBox.TabStop = false;
            curvePictureBox.Paint += curvePictureBox_Paint;
            curvePictureBox.MouseDown += curvePictureBox_MouseDown;
            curvePictureBox.MouseMove += curvePictureBox_MouseMove;
            // 
            // cyanRadioButton
            // 
            cyanRadioButton.AutoSize = true;
            cyanRadioButton.Location = new Point(14, 537);
            cyanRadioButton.Margin = new Padding(3, 4, 3, 4);
            cyanRadioButton.Name = "cyanRadioButton";
            cyanRadioButton.Size = new Size(62, 24);
            cyanRadioButton.TabIndex = 1;
            cyanRadioButton.TabStop = true;
            cyanRadioButton.Text = "Cyan";
            cyanRadioButton.UseVisualStyleBackColor = true;
            cyanRadioButton.CheckedChanged += cyanRadioButton_CheckedChanged;
            // 
            // magentaRadioButton
            // 
            magentaRadioButton.AutoSize = true;
            magentaRadioButton.Location = new Point(14, 571);
            magentaRadioButton.Margin = new Padding(3, 4, 3, 4);
            magentaRadioButton.Name = "magentaRadioButton";
            magentaRadioButton.Size = new Size(89, 24);
            magentaRadioButton.TabIndex = 2;
            magentaRadioButton.TabStop = true;
            magentaRadioButton.Text = "Magenta";
            magentaRadioButton.UseVisualStyleBackColor = true;
            magentaRadioButton.CheckedChanged += magentaRadioButton_CheckedChanged;
            // 
            // yellowRadioButton
            // 
            yellowRadioButton.AutoSize = true;
            yellowRadioButton.Location = new Point(14, 604);
            yellowRadioButton.Margin = new Padding(3, 4, 3, 4);
            yellowRadioButton.Name = "yellowRadioButton";
            yellowRadioButton.Size = new Size(73, 24);
            yellowRadioButton.TabIndex = 3;
            yellowRadioButton.TabStop = true;
            yellowRadioButton.Text = "Yellow";
            yellowRadioButton.UseVisualStyleBackColor = true;
            yellowRadioButton.CheckedChanged += yellowRadioButton_CheckedChanged;
            // 
            // blackRadioButton
            // 
            blackRadioButton.AutoSize = true;
            blackRadioButton.Location = new Point(14, 637);
            blackRadioButton.Margin = new Padding(3, 4, 3, 4);
            blackRadioButton.Name = "blackRadioButton";
            blackRadioButton.Size = new Size(65, 24);
            blackRadioButton.TabIndex = 4;
            blackRadioButton.TabStop = true;
            blackRadioButton.Text = "Black";
            blackRadioButton.UseVisualStyleBackColor = true;
            blackRadioButton.CheckedChanged += blackRadioButton_CheckedChanged;
            // 
            // allCurvesCheckBox
            // 
            allCurvesCheckBox.AutoSize = true;
            allCurvesCheckBox.Location = new Point(14, 671);
            allCurvesCheckBox.Margin = new Padding(3, 4, 3, 4);
            allCurvesCheckBox.Name = "allCurvesCheckBox";
            allCurvesCheckBox.Size = new Size(132, 24);
            allCurvesCheckBox.TabIndex = 5;
            allCurvesCheckBox.Text = "Show all curves";
            allCurvesCheckBox.UseVisualStyleBackColor = true;
            allCurvesCheckBox.CheckedChanged += allCurvesCheckBox_CheckedChanged;
            // 
            // reduction0Button
            // 
            reduction0Button.Location = new Point(171, 537);
            reduction0Button.Margin = new Padding(3, 4, 3, 4);
            reduction0Button.Name = "reduction0Button";
            reduction0Button.Size = new Size(126, 31);
            reduction0Button.TabIndex = 6;
            reduction0Button.Text = "0% reduction";
            reduction0Button.UseVisualStyleBackColor = true;
            reduction0Button.Click += reduction0Button_Click;
            // 
            // reduction100Button
            // 
            reduction100Button.Location = new Point(171, 576);
            reduction100Button.Margin = new Padding(3, 4, 3, 4);
            reduction100Button.Name = "reduction100Button";
            reduction100Button.Size = new Size(126, 31);
            reduction100Button.TabIndex = 7;
            reduction100Button.Text = "100% reduction";
            reduction100Button.UseVisualStyleBackColor = true;
            reduction100Button.Click += reduction100Button_Click;
            // 
            // UCRButton
            // 
            UCRButton.Location = new Point(171, 615);
            UCRButton.Margin = new Padding(3, 4, 3, 4);
            UCRButton.Name = "UCRButton";
            UCRButton.Size = new Size(126, 31);
            UCRButton.TabIndex = 8;
            UCRButton.Text = "UCR";
            UCRButton.UseVisualStyleBackColor = true;
            UCRButton.Click += UCRButton_Click;
            // 
            // GCRButton
            // 
            GCRButton.Location = new Point(171, 653);
            GCRButton.Margin = new Padding(3, 4, 3, 4);
            GCRButton.Name = "GCRButton";
            GCRButton.Size = new Size(126, 31);
            GCRButton.TabIndex = 9;
            GCRButton.Text = "GCR";
            GCRButton.UseVisualStyleBackColor = true;
            GCRButton.Click += GCRButton_Click;
            // 
            // changeButton
            // 
            changeButton.Location = new Point(304, 576);
            changeButton.Margin = new Padding(3, 4, 3, 4);
            changeButton.Name = "changeButton";
            changeButton.Size = new Size(127, 31);
            changeButton.TabIndex = 11;
            changeButton.Text = "Change picture";
            changeButton.UseVisualStyleBackColor = true;
            changeButton.Click += changeButton_Click;
            // 
            // saveCurveButton
            // 
            saveCurveButton.Location = new Point(304, 615);
            saveCurveButton.Margin = new Padding(3, 4, 3, 4);
            saveCurveButton.Name = "saveCurveButton";
            saveCurveButton.Size = new Size(127, 31);
            saveCurveButton.TabIndex = 12;
            saveCurveButton.Text = "Save  curves";
            saveCurveButton.UseVisualStyleBackColor = true;
            saveCurveButton.Click += saveCurveButton_Click;
            // 
            // loadCurveButton
            // 
            loadCurveButton.Location = new Point(304, 653);
            loadCurveButton.Margin = new Padding(3, 4, 3, 4);
            loadCurveButton.Name = "loadCurveButton";
            loadCurveButton.Size = new Size(127, 31);
            loadCurveButton.TabIndex = 13;
            loadCurveButton.Text = "Load curves";
            loadCurveButton.UseVisualStyleBackColor = true;
            loadCurveButton.Click += loadCurveButton_Click;
            // 
            // savePicturesButton
            // 
            savePicturesButton.Location = new Point(171, 713);
            savePicturesButton.Margin = new Padding(3, 4, 3, 4);
            savePicturesButton.Name = "savePicturesButton";
            savePicturesButton.Size = new Size(86, 84);
            savePicturesButton.TabIndex = 15;
            savePicturesButton.Text = "Save pictures";
            savePicturesButton.UseVisualStyleBackColor = true;
            savePicturesButton.Click += savePicturesButton_Click;
            // 
            // originalPictureBox
            // 
            originalPictureBox.Location = new Point(481, 16);
            originalPictureBox.Margin = new Padding(3, 4, 3, 4);
            originalPictureBox.Name = "originalPictureBox";
            originalPictureBox.Size = new Size(331, 240);
            originalPictureBox.TabIndex = 16;
            originalPictureBox.TabStop = false;
            originalPictureBox.Paint += originalPictureBox_Paint;
            // 
            // cyanPictureBox
            // 
            cyanPictureBox.Location = new Point(481, 287);
            cyanPictureBox.Margin = new Padding(3, 4, 3, 4);
            cyanPictureBox.Name = "cyanPictureBox";
            cyanPictureBox.Size = new Size(331, 240);
            cyanPictureBox.TabIndex = 17;
            cyanPictureBox.TabStop = false;
            cyanPictureBox.Paint += cyanPictureBox_Paint;
            // 
            // magentaPictureBox
            // 
            magentaPictureBox.Location = new Point(819, 287);
            magentaPictureBox.Margin = new Padding(3, 4, 3, 4);
            magentaPictureBox.Name = "magentaPictureBox";
            magentaPictureBox.Size = new Size(331, 240);
            magentaPictureBox.TabIndex = 18;
            magentaPictureBox.TabStop = false;
            magentaPictureBox.Paint += magentaPictureBox_Paint;
            // 
            // yellowPictureBox
            // 
            yellowPictureBox.Location = new Point(481, 537);
            yellowPictureBox.Margin = new Padding(3, 4, 3, 4);
            yellowPictureBox.Name = "yellowPictureBox";
            yellowPictureBox.Size = new Size(331, 240);
            yellowPictureBox.TabIndex = 19;
            yellowPictureBox.TabStop = false;
            yellowPictureBox.Paint += yellowPictureBox_Paint;
            // 
            // blackPictureBox
            // 
            blackPictureBox.Location = new Point(819, 537);
            blackPictureBox.Margin = new Padding(3, 4, 3, 4);
            blackPictureBox.Name = "blackPictureBox";
            blackPictureBox.Size = new Size(331, 240);
            blackPictureBox.TabIndex = 20;
            blackPictureBox.TabStop = false;
            blackPictureBox.Paint += blackPictureBox_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 813);
            Controls.Add(blackPictureBox);
            Controls.Add(yellowPictureBox);
            Controls.Add(magentaPictureBox);
            Controls.Add(cyanPictureBox);
            Controls.Add(originalPictureBox);
            Controls.Add(savePicturesButton);
            Controls.Add(loadCurveButton);
            Controls.Add(saveCurveButton);
            Controls.Add(changeButton);
            Controls.Add(GCRButton);
            Controls.Add(UCRButton);
            Controls.Add(reduction100Button);
            Controls.Add(reduction0Button);
            Controls.Add(allCurvesCheckBox);
            Controls.Add(blackRadioButton);
            Controls.Add(yellowRadioButton);
            Controls.Add(magentaRadioButton);
            Controls.Add(cyanRadioButton);
            Controls.Add(curvePictureBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)curvePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)originalPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)cyanPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)magentaPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)yellowPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)blackPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox curvePictureBox;
        private RadioButton cyanRadioButton;
        private RadioButton magentaRadioButton;
        private RadioButton yellowRadioButton;
        private RadioButton blackRadioButton;
        private CheckBox allCurvesCheckBox;
        private Button reduction0Button;
        private Button reduction100Button;
        private Button UCRButton;
        private Button GCRButton;
        private Button changeButton;
        private Button saveCurveButton;
        private Button loadCurveButton;
        private Button savePicturesButton;
        private PictureBox originalPictureBox;
        private PictureBox cyanPictureBox;
        private PictureBox magentaPictureBox;
        private PictureBox yellowPictureBox;
        private PictureBox blackPictureBox;
    }
}

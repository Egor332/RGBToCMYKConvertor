﻿namespace RGBToCMYKConvertor
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
            showAllPicturesButton = new Button();
            changeButton = new Button();
            saveCurveButton = new Button();
            loadCurveButton = new Button();
            savePicturesButton = new Button();
            ((System.ComponentModel.ISupportInitialize)curvePictureBox).BeginInit();
            SuspendLayout();
            // 
            // curvePictureBox
            // 
            curvePictureBox.Location = new Point(12, 12);
            curvePictureBox.Name = "curvePictureBox";
            curvePictureBox.Size = new Size(385, 385);
            curvePictureBox.TabIndex = 0;
            curvePictureBox.TabStop = false;
            curvePictureBox.Paint += curvePictureBox_Paint;
            curvePictureBox.MouseDown += curvePictureBox_MouseDown;
            curvePictureBox.MouseMove += curvePictureBox_MouseMove;
            // 
            // cyanRadioButton
            // 
            cyanRadioButton.AutoSize = true;
            cyanRadioButton.Location = new Point(12, 403);
            cyanRadioButton.Name = "cyanRadioButton";
            cyanRadioButton.Size = new Size(52, 19);
            cyanRadioButton.TabIndex = 1;
            cyanRadioButton.TabStop = true;
            cyanRadioButton.Text = "Cyan";
            cyanRadioButton.UseVisualStyleBackColor = true;
            cyanRadioButton.CheckedChanged += cyanRadioButton_CheckedChanged;
            // 
            // magentaRadioButton
            // 
            magentaRadioButton.AutoSize = true;
            magentaRadioButton.Location = new Point(12, 428);
            magentaRadioButton.Name = "magentaRadioButton";
            magentaRadioButton.Size = new Size(72, 19);
            magentaRadioButton.TabIndex = 2;
            magentaRadioButton.TabStop = true;
            magentaRadioButton.Text = "Magenta";
            magentaRadioButton.UseVisualStyleBackColor = true;
            magentaRadioButton.CheckedChanged += magentaRadioButton_CheckedChanged;
            // 
            // yellowRadioButton
            // 
            yellowRadioButton.AutoSize = true;
            yellowRadioButton.Location = new Point(12, 453);
            yellowRadioButton.Name = "yellowRadioButton";
            yellowRadioButton.Size = new Size(59, 19);
            yellowRadioButton.TabIndex = 3;
            yellowRadioButton.TabStop = true;
            yellowRadioButton.Text = "Yellow";
            yellowRadioButton.UseVisualStyleBackColor = true;
            yellowRadioButton.CheckedChanged += yellowRadioButton_CheckedChanged;
            // 
            // blackRadioButton
            // 
            blackRadioButton.AutoSize = true;
            blackRadioButton.Location = new Point(12, 478);
            blackRadioButton.Name = "blackRadioButton";
            blackRadioButton.Size = new Size(53, 19);
            blackRadioButton.TabIndex = 4;
            blackRadioButton.TabStop = true;
            blackRadioButton.Text = "Black";
            blackRadioButton.UseVisualStyleBackColor = true;
            blackRadioButton.CheckedChanged += blackRadioButton_CheckedChanged;
            // 
            // allCurvesCheckBox
            // 
            allCurvesCheckBox.AutoSize = true;
            allCurvesCheckBox.Location = new Point(12, 503);
            allCurvesCheckBox.Name = "allCurvesCheckBox";
            allCurvesCheckBox.Size = new Size(107, 19);
            allCurvesCheckBox.TabIndex = 5;
            allCurvesCheckBox.Text = "Show all curves";
            allCurvesCheckBox.UseVisualStyleBackColor = true;
            allCurvesCheckBox.CheckedChanged += allCurvesCheckBox_CheckedChanged;
            // 
            // reduction0Button
            // 
            reduction0Button.Location = new Point(150, 403);
            reduction0Button.Name = "reduction0Button";
            reduction0Button.Size = new Size(110, 23);
            reduction0Button.TabIndex = 6;
            reduction0Button.Text = "0% reduction";
            reduction0Button.UseVisualStyleBackColor = true;
            // 
            // reduction100Button
            // 
            reduction100Button.Location = new Point(150, 432);
            reduction100Button.Name = "reduction100Button";
            reduction100Button.Size = new Size(110, 23);
            reduction100Button.TabIndex = 7;
            reduction100Button.Text = "100% reduction";
            reduction100Button.UseVisualStyleBackColor = true;
            // 
            // UCRButton
            // 
            UCRButton.Location = new Point(150, 461);
            UCRButton.Name = "UCRButton";
            UCRButton.Size = new Size(110, 23);
            UCRButton.TabIndex = 8;
            UCRButton.Text = "UCR";
            UCRButton.UseVisualStyleBackColor = true;
            // 
            // GCRButton
            // 
            GCRButton.Location = new Point(150, 490);
            GCRButton.Name = "GCRButton";
            GCRButton.Size = new Size(110, 23);
            GCRButton.TabIndex = 9;
            GCRButton.Text = "GCR";
            GCRButton.UseVisualStyleBackColor = true;
            // 
            // showAllPicturesButton
            // 
            showAllPicturesButton.Location = new Point(266, 403);
            showAllPicturesButton.Name = "showAllPicturesButton";
            showAllPicturesButton.Size = new Size(111, 23);
            showAllPicturesButton.TabIndex = 10;
            showAllPicturesButton.Text = "Show all pictures";
            showAllPicturesButton.UseVisualStyleBackColor = true;
            // 
            // changeButton
            // 
            changeButton.Location = new Point(266, 432);
            changeButton.Name = "changeButton";
            changeButton.Size = new Size(111, 23);
            changeButton.TabIndex = 11;
            changeButton.Text = "Change picture";
            changeButton.UseVisualStyleBackColor = true;
            // 
            // saveCurveButton
            // 
            saveCurveButton.Location = new Point(266, 461);
            saveCurveButton.Name = "saveCurveButton";
            saveCurveButton.Size = new Size(111, 23);
            saveCurveButton.TabIndex = 12;
            saveCurveButton.Text = "Save  curve";
            saveCurveButton.UseVisualStyleBackColor = true;
            // 
            // loadCurveButton
            // 
            loadCurveButton.Location = new Point(266, 490);
            loadCurveButton.Name = "loadCurveButton";
            loadCurveButton.Size = new Size(111, 23);
            loadCurveButton.TabIndex = 13;
            loadCurveButton.Text = "Load curve";
            loadCurveButton.UseVisualStyleBackColor = true;
            // 
            // savePicturesButton
            // 
            savePicturesButton.Location = new Point(150, 535);
            savePicturesButton.Name = "savePicturesButton";
            savePicturesButton.Size = new Size(75, 63);
            savePicturesButton.TabIndex = 15;
            savePicturesButton.Text = "Save pictures";
            savePicturesButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 610);
            Controls.Add(savePicturesButton);
            Controls.Add(loadCurveButton);
            Controls.Add(saveCurveButton);
            Controls.Add(changeButton);
            Controls.Add(showAllPicturesButton);
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
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)curvePictureBox).EndInit();
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
        private Button showAllPicturesButton;
        private Button changeButton;
        private Button saveCurveButton;
        private Button loadCurveButton;
        private Button savePicturesButton;
    }
}

﻿namespace MindriX
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            progressBar1 = new ProgressBar();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 50F);
            label1.Location = new Point(31, -120);
            label1.Name = "label1";
            label1.Size = new Size(817, 89);
            label1.TabIndex = 0;
            label1.Text = "Almost there… Stay tuned!";
            // 
            // progressBar1
            // 
            progressBar1.Cursor = Cursors.AppStarting;
            progressBar1.Location = new Point(108, 530);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(651, 51);
            progressBar1.TabIndex = 1;
            progressBar1.Value = 15;
            progressBar1.Click += progressBar1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 60F);
            label2.Location = new Point(26, 508);
            label2.Name = "label2";
            label2.Size = new Size(790, 212);
            label2.TabIndex = 2;
            label2.Text = "Welcome to MindriX \r\n The Future Awaits";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(106, 36);
            label3.Name = "label3";
            label3.Size = new Size(254, 74);
            label3.TabIndex = 3;
            label3.Text = "GoodMorning, \r\n[Name + LastName]";
            label3.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(884, 516);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Name = "Main";
            Text = "Main";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ProgressBar progressBar1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
    }
}
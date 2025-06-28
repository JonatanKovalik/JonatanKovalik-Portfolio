namespace MindriX
{
    partial class SiginUp
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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button2 = new Button();
            label3 = new Label();
            button3 = new Button();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(120, 326);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(229, 23);
            textBox2.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(130, 278);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(229, 23);
            textBox1.TabIndex = 17;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 192);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(318, 391);
            button2.Name = "button2";
            button2.Size = new Size(117, 44);
            button2.TabIndex = 16;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(17, 326);
            label3.Name = "label3";
            label3.Size = new Size(97, 28);
            label3.TabIndex = 14;
            label3.Text = "Password:";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 128);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(7, 391);
            button3.Name = "button3";
            button3.Size = new Size(117, 44);
            button3.TabIndex = 13;
            button3.Text = "Return";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(17, 279);
            label2.Name = "label2";
            label2.Size = new Size(107, 28);
            label2.TabIndex = 12;
            label2.Text = "UserName:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.Location = new Point(4, 32);
            label1.Name = "label1";
            label1.Size = new Size(383, 54);
            label1.TabIndex = 11;
            label1.Text = "Sign Up to MindriX";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(17, 141);
            label4.Name = "label4";
            label4.Size = new Size(68, 28);
            label4.TabIndex = 19;
            label4.Text = "Name:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(86, 141);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(229, 23);
            textBox3.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(17, 184);
            label5.Name = "label5";
            label5.Size = new Size(103, 28);
            label5.TabIndex = 21;
            label5.Text = "Last name:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(120, 184);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(229, 23);
            textBox4.TabIndex = 22;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(86, 232);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(229, 23);
            textBox5.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(17, 233);
            label6.Name = "label6";
            label6.Size = new Size(63, 28);
            label6.TabIndex = 23;
            label6.Text = "Email:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Light", 12F, FontStyle.Bold);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(15, 106);
            label7.Name = "label7";
            label7.Size = new Size(299, 21);
            label7.TabIndex = 25;
            label7.Text = "Error you didn't fill in all the textboxes";
            // 
            // SiginUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 447);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SiginUp";
            Text = "Sign Up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private TextBox textBox1;
        private Button button2;
        private Label label3;
        private Button button3;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label6;
        private Label label7;
    }
}
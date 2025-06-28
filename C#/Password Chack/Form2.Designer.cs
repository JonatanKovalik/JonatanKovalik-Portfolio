namespace Password_Chack
{
    partial class Form2
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
            panel1 = new Panel();
            label4 = new Label();
            button1 = new Button();
            PasswordInput = new TextBox();
            UserNameinput = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 255);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(PasswordInput);
            panel1.Controls.Add(UserNameinput);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 450);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label4.Location = new Point(11, 10);
            label4.Name = "label4";
            label4.Size = new Size(195, 28);
            label4.TabIndex = 8;
            label4.Text = "Created by Jonatan";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            button1.Location = new Point(299, 334);
            button1.Name = "button1";
            button1.Size = new Size(194, 52);
            button1.TabIndex = 7;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // PasswordInput
            // 
            PasswordInput.Location = new Point(193, 271);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.Size = new Size(242, 23);
            PasswordInput.TabIndex = 6;
            // 
            // UserNameinput
            // 
            UserNameinput.Location = new Point(219, 169);
            UserNameinput.Name = "UserNameinput";
            UserNameinput.Size = new Size(242, 23);
            UserNameinput.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label3.Location = new Point(41, 257);
            label3.Name = "label3";
            label3.Size = new Size(146, 37);
            label3.TabIndex = 3;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label2.Location = new Point(41, 155);
            label2.Name = "label2";
            label2.Size = new Size(172, 37);
            label2.TabIndex = 2;
            label2.Text = "User Name: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.Location = new Point(105, 53);
            label1.Name = "label1";
            label1.Size = new Size(619, 54);
            label1.TabIndex = 0;
            label1.Text = "Welcome Login to your account";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 411);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox PasswordInput;
        private TextBox UserNameinput;
        private Button button1;
        private Label label4;
    }
}
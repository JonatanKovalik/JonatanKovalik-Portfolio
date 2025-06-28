using System;
using System.Windows.Forms;

namespace MindriX
{
    public partial class SiginUp : Form
    {
        public SiginUp()
        {
            InitializeComponent();
            label7.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                Form1.UserName = textBox1.Text;
                Form1.Password = textBox2.Text;
                Form1.Email = textBox5.Text;
                Form1.LastName = textBox4.Text;
                Form1.Name = textBox3.Text;

                Form1 form1 = new Form1();
                this.Hide();
                form1.Show();
            }
            else
            {
                label7.Visible = true;
            }
        }

        private bool IsValidInput()
        {
            if (string.IsNullOrEmpty(textBox1.Text) ||
                string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox3.Text) ||
                string.IsNullOrEmpty(textBox4.Text) ||
                string.IsNullOrEmpty(textBox5.Text))
            {
                label7.Text = "Please fill in all the fields";
                return false;
            }

            if (textBox1.TextLength < 4)
            {
                label7.Text = "Username needs to be at least 4 characters long";
                return false;
            }

            if (textBox2.TextLength < 8)
            {
                label7.Text = "Password needs to be at least 8 characters long";
                return false;
            }

            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}

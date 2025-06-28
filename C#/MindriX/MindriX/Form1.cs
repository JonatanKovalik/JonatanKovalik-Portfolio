using System;
using System.Windows.Forms;

namespace MindriX
{
    public partial class Form1 : Form
    {
        public static string UserName;
        public static string Password;
        public static string Email;
        public static string Name;
        public static string LastName;

        public Form1()
        {
            InitializeComponent();
            label4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == UserName && textBox2.Text == Password)
            {
                Main main = new Main();
                this.Hide();
                main.Show();
            }
            else
            {
                label4.Visible = true;
                label4.Text = "Invalid username or password";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SiginUp siginUp = new SiginUp();
            this.Hide();
            siginUp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
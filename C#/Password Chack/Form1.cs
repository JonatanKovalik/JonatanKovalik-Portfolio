using System.Diagnostics;
using System.Threading;

namespace Password_Chack
{
    public partial class Form1 : Form
    {
        public static string usernamestatic = "";
        public static string Passwordstatic = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string UserName = textBox1.Text;
            string Password = textBox2.Text;
            Debug.WriteLine("User Name: " + UserName + " Password: " + Password); 
            usernamestatic = UserName;
            Passwordstatic = Password; 
            Thread.Sleep(1000);
            Debug.WriteLine("Transform");
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

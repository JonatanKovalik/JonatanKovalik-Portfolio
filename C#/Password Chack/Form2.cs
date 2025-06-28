using System.Diagnostics;
using System.Windows.Forms;

namespace Password_Chack
{
    public partial class Form2 : Form
    {
        public static int timetry = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserNameinput.Text == Form1.usernamestatic && PasswordInput.Text == Form1.Passwordstatic)
            {
                Debug.WriteLine("Loging successful");
                Form4 form4 = new Form4();
                form4.Show();
                this.Hide();
            }
            else
            {
                Debug.WriteLine("Failed");
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
        }
    }
}

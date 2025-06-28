using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Chack
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            ShowAndCloseAsync(); // Call the async method
        }

        private async void ShowAndCloseAsync()
        {
            int timewait = 0;
            await Task.Delay(1500); 
            while (timewait < 3000) 
            {
                await Task.Delay(1000); 
                timewait += 1;
                Debug.WriteLine(timewait);
            }
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        private void label1_Click(object sender, EventArgs e) { }
    }
}

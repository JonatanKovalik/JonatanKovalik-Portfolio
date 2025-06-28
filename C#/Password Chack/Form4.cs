using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Chack
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            RunLoopAsync();
        }

        private async void RunLoopAsync()
        {
            while (true) 
            {
                //Debug.WriteLine("Running...");
                await Task.Delay(1000);
            }
        }
    }
}

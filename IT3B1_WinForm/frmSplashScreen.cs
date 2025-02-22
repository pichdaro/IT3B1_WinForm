using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT3B1_WinForm
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }
        int loadingTime = 3000; //value in milliseconds
        int timerInterval = 10; //value in milliseconds
        int counter;

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = counter;
            counter++;
            if (counter == (loadingTime/timerInterval)) 
            {
                this.Close();
                timer1.Stop();
            }
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Interval = timerInterval; // value in milliseconds
            timer1.Start();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = loadingTime / timerInterval;
        }
    }
}

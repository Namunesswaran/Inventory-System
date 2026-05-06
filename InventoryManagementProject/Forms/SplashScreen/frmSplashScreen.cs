using InventoryManagementProject.Forms.Authentication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementProject.Forms.SplashScreen
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        int progress = 0;
        private void splashTimer_Tick(object sender, EventArgs e)
        {
            progress += 2;
            progressBar.Value = progress;

            if (progress >= 100)
            {
                splashTimer.Stop();
                this.Hide();
                new frmLogin().Show(); 
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace egepoly
{
    public partial class introForm : Form
    {
        byte sure = 0;
        int gecikme = 0;
        public introForm()
        {
            InitializeComponent();
        }
        private void fadeOut_Tick(object sender, EventArgs e)
        {
            
            if (gecikme > 30 && this.Opacity != 1)
            {
                sure++;
                this.Opacity = sure / 100D;
            }
            else
                gecikme++;

            if(this.Opacity >= 1)
            {
                gecikme++;
                if(gecikme > 300)
                {
                    this.Dispose();
                    menuForm menu = new menuForm();
                    menu.Show();
                    introBackground.kapat = true;
                }
            }
        }
    }
}

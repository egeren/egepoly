using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace egepoly
{
    public partial class introBackground : Form
    {
        public static bool kapat = false;
        Form bg = new introForm();
        public introBackground()
        {
            InitializeComponent();
        }

        private void introBackground_Load(object sender, EventArgs e)
        {
            media.URL = "Musics/mainMenu.wav";
            media.Ctlcontrols.play();
            bg.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(kapat)
            {
                timer1.Dispose();
                this.Hide();
            }
        }
    }
}

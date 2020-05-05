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
    public partial class satinAl : Form
    {
        public static Oyuncu oyuncu;
        public static Binalar bina;
        public satinAl()
        {
            InitializeComponent();
        }
        
        private void satinAl_Load(object sender, EventArgs e)
        {
            sehirAdiLabel.Text = bina.isim + "(Seviye " + bina.seviye + ")";
            degerLabel.Text = bina.deger.ToString();
            if(bina.sahip != null)
            {
                buttonPicture.BackgroundImage = Properties.Resources.yukseltButton;
            }

        }

        private void kapatPicture_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Dispose();
        }

        private void buttonPicture_Click(object sender, EventArgs e)
        {
            if (buttonPicture.BackgroundImage == Properties.Resources.satinAlButton)
            {
                bina.sahip = oyuncu;
                oyuncu.paraDegistir(-bina.deger);
                this.DialogResult = DialogResult.Yes;
            }
            else
            {
                bina.seviye++;
                oyuncu.paraDegistir(-bina.deger);
                this.DialogResult = DialogResult.Retry;
            }
            this.Dispose();
        }
    }
}

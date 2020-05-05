using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace egepoly
{
    public class Oyuncu
    {
        public int para;
        public int pozisyon = 0;
        public bool turSirasi, hapis;
        public PictureBox resim = new PictureBox();

        public Oyuncu(PictureBox resim)
        {
            this.para = 50000;
            this.turSirasi = false;
            this.resim = resim;
            this.hapis = false;
        }

        public void paraDegistir(int para)
        {
            this.para += para;
        }
        
    }
    public class Binalar
    {
        public int konum, deger,seviye;
        public string isim;
        public bool satinAlinabilir;
        public Oyuncu sahip;
        public Binalar(int konum, string isim, int deger, bool satinAlinabilir)
        {
            this.konum = konum;
            this.isim = isim;
            this.deger = deger;
            this.sahip = null;
            this.satinAlinabilir = satinAlinabilir;
            this.seviye = 0;
        }

        public void sahipSec(Oyuncu sahip)
        {
            this.sahip = sahip;
        }
    }
}

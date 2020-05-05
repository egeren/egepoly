using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace egepoly
{
    public partial class gameForm : Form
    {
        int sure = 0;
        int ortadakiPara = 0;
        Oyuncu oyuncu;
        Oyuncu AI;
        int atilanZar = 0;
        List<Binalar> yer = new List<Binalar>();
        Random zar = new Random();
        char[] sayi = new char[2];
        Form karart = new Form();
        PrivateFontCollection zarFont = new PrivateFontCollection(); // custom font eklemek
        public gameForm()
        {
            InitializeComponent();
            zarFont.AddFontFile("Fonts/Dice.ttf");

        }

        private void gameForm_Load(object sender, EventArgs e)
        {
            #region responsive ui ayarları
            playerZar.Font = new Font(zarFont.Families[0], this.Width/15);
            zarAtLabel.Font = new Font("Futura Condensed", this.Width/30);
            oyuncuParaLabel.Font = new Font("Segoe UI", this.Width / 80);
            aiParaLabel.Font = new Font("Segoe UI", this.Width / 80);
            karart.Size = this.Size;
            karart.Location = this.Location;
            karart.FormBorderStyle = FormBorderStyle.None;
            karart.BackColor = Color.Black;
            karart.Opacity = 0.5;
            playerBoard.Controls.Add(oyuncuParaLayout); // layout'un playerboard üstüne gözükmesi için
            aiBoard.Controls.Add(aiParaLayout);         // den den
            boardPanel.Controls.Add(board);
            board.Controls.Add(lokasyonlarLayout);
            //board.Controls.Add();
            #endregion
            oyunuHazirla();
            /*satinAl satin = new satinAl();
            karart.Show();
            satin.ShowDialog();*/
            
        }
        private void gameForm_SizeChanged(object sender, EventArgs e)
        {
            playerZar.Font = new Font(zarFont.Families[0], this.Width / 15);
            zarAtLabel.Font = new Font("Futura Condensed", this.Width / 30);
            oyuncuParaLabel.Font = new Font("Segoe UI", this.Width / 80);
            aiParaLabel.Font = new Font("Segoe UI", this.Width / 80);
        }

        public void oyunuHazirla()
        {
            oyuncu = new Oyuncu(oyuncuResim);
            AI = new Oyuncu(aiResim);
            oyuncu.turSirasi = true;
            #region Bina Ekleme
            yer.Add(new Binalar(0, "Başlangıç", 0, false));
            yer.Add(new Binalar(1, "Karataş", 8000, true));
            yer.Add(new Binalar(2, "Kamu Fonu", 0, false));
            yer.Add(new Binalar(3, "Altıntaş", 10000, true));
            yer.Add(new Binalar(4, "Vergi Dairesi",0, false));
            yer.Add(new Binalar(5, "Hilal İstasyonu",10000, true));
            yer.Add(new Binalar(6, "Tepecik", 14000, true));
            yer.Add(new Binalar(7, "Şans", 0, false));
            yer.Add(new Binalar(8, "Maltepe", 17000, true));
            yer.Add(new Binalar(9, "Kadifekale", 14000, true));
            yer.Add(new Binalar(10, "Hapishane", 0, false));
            yer.Add(new Binalar(11, "Gaziemir", 16000, true));
            yer.Add(new Binalar(12, "Elektrik Dairesi" , 0, false));
            yer.Add(new Binalar(13, "Kuşadası", 24000, true));
            yer.Add(new Binalar(14, "Buca", 16000, true));
            yer.Add(new Binalar(15, "Üçyol İstasyonu", 10000, true));
            yer.Add(new Binalar(16, "Çeşme", 30000, true));
            yer.Add(new Binalar(17, "Kamu Fonu", 0, false));
            yer.Add(new Binalar(18, "Fahrettin Altay", 25000, true));
            yer.Add(new Binalar(19, "Poligon", 39000, true));
            yer.Add(new Binalar(20, "Parayı Topla", 0, false));
            yer.Add(new Binalar(21, "Karşıyaka", 37000, true));
            yer.Add(new Binalar(22, "Şans",0, false));
            yer.Add(new Binalar(23, "Göztepe", 23000, true));
            yer.Add(new Binalar(24, "Bahçelievler", 26000, true));
            yer.Add(new Binalar(25, "Çankaya İstasyonu", 12000, true));
            yer.Add(new Binalar(26, "Konak", 35000, true));
            yer.Add(new Binalar(27, "İzmirspor", 37000, true));
            yer.Add(new Binalar(28, "Devlet Su İşleri", 0, false));
            yer.Add(new Binalar(29, "Hatay", 53000, true));
            yer.Add(new Binalar(30, "Kodes'e git!", 0, false));
            yer.Add(new Binalar(31, "Bornova", 60000, true));
            yer.Add(new Binalar(32, "Beşiktaş", 54000, true));
            yer.Add(new Binalar(33, "Kamu Fonu", 0, false));
            yer.Add(new Binalar(34, "Bebek", 72000, true));
            yer.Add(new Binalar(35, "Alsancak İstasyonu", 15000, true));
            yer.Add(new Binalar(36, "Şans", 0, false));
            yer.Add(new Binalar(37, "Alsancak", 83000, true));
            yer.Add(new Binalar(38, "Toplu Vergi", 0, false));
            yer.Add(new Binalar(39, "Etiler", 96000, true));
            #endregion
            //MessageBox.Show(yer[0].isim.ToString());
        }
        public void guncelle()
        {
            oyuncuParaLabel.Text = oyuncu.para + " ₺";
            aiParaLabel.Text = AI.para + " ₺";
        }
        private void playerZar_Click(object sender, EventArgs e)
        {
            zarTimer.Start();
        }

        void siraDegistir()
        {
            if(oyuncu.turSirasi)
            {
                oyuncu.turSirasi = false;
                AI.turSirasi = true;
            }
            else
            {
                oyuncu.turSirasi = true;
                AI.turSirasi = false;
            }
        }

        Oyuncu oynamaSirasi()
        {
            if (oyuncu.turSirasi)
                return oyuncu;
            else
                return AI;
        }

        void ilerle(Oyuncu oyuncu, int adim)
        {
            bool ai = false;
            if(oyuncu.pozisyon == 39)
            {
                oyuncu.pozisyon = 0;
            }
            else
                oyuncu.pozisyon++;
            TableLayoutPanel bolge = lokasyonlarLayout.Controls.Find("bolge" + oyuncu.pozisyon, false).First() as TableLayoutPanel;
            if(oynamaSirasi() == AI)
            {
                ai = true;
            }
            if (!ai)
            {
                if (oyuncu.pozisyon > 10 && oyuncu.pozisyon < 20)
                    bolge.Controls.Add(oyuncu.resim, 0, 1);
                else if (oyuncu.pozisyon >= 20 && oyuncu.pozisyon < 30)
                    bolge.Controls.Add(oyuncu.resim, 1, 0);
                else if (oyuncu.pozisyon > 30)
                    bolge.Controls.Add(oyuncu.resim, 0, 1);
                else if (oyuncu.pozisyon == 0)
                    bolge.Controls.Add(oyuncu.resim, 0, 0);
                else
                    bolge.Controls.Add(oyuncu.resim, 0,0);
            }
            else
            {
                if (oyuncu.pozisyon > 10 && oyuncu.pozisyon < 20)
                    bolge.Controls.Add(oyuncu.resim, 0, 2);
                else if (oyuncu.pozisyon >= 20 && oyuncu.pozisyon < 30)
                    bolge.Controls.Add(oyuncu.resim, 2, 0);
                else if (oyuncu.pozisyon > 30)
                    bolge.Controls.Add(oyuncu.resim, 0, 2);
                else if (oyuncu.pozisyon == 0)
                    bolge.Controls.Add(oyuncu.resim, 1, 0);
                else
                    bolge.Controls.Add(oyuncu.resim, 1, 0);
            }
        }

        void soruSor(Oyuncu oyuncu)
        {
            switch (oyuncu.pozisyon)
            {
                case 0:
                    oyuncu.paraDegistir(8000);
                    break;
                case 2:
                    MessageBox.Show("kamu fonu");
                    break;
                case 4:
                    ortadakiPara = Convert.ToInt32(oyuncu.para * 0.07);
                    oyuncu.paraDegistir(-Convert.ToInt32(oyuncu.para * 0.07));
                    break;
                case 7:
                    MessageBox.Show("şans");
                    break;
                case 10:
                    oyuncu.hapis = true;
                    break;
                case 12:
                    ortadakiPara = Convert.ToInt32(oyuncu.para * 0.07);
                    oyuncu.paraDegistir(-Convert.ToInt32(oyuncu.para * 0.07));
                    break;
                case 17:
                    MessageBox.Show("kamu fonu");
                    break;
                case 20:
                    oyuncu.paraDegistir(ortadakiPara);
                    ortadakiPara = 0;
                    break;
                case 22:
                    MessageBox.Show("şans");
                    break;
                case 28:
                    ortadakiPara = Convert.ToInt32(oyuncu.para * 0.07);
                    oyuncu.paraDegistir(-Convert.ToInt32(oyuncu.para * 0.07));
                    break;
                case 30:
                    MessageBox.Show("kodese git");
                    break;
                case 33:
                    MessageBox.Show("kamu fonu");
                    break;
                case 36:
                    MessageBox.Show("şans");
                    break;
                case 38:
                    ortadakiPara = Convert.ToInt32(oyuncu.para * 0.15);
                    oyuncu.paraDegistir(-Convert.ToInt32(oyuncu.para * 0.15));
                    break;
                default:
                    satinAl soru = new satinAl();
                    satinAl.oyuncu = oyuncu;
                    satinAl.bina = yer[oyuncu.pozisyon];
                    karart.Show();
                    soru.ShowDialog();
                    break;
            }
            
        }
        
        private void zarTimer_Tick(object sender, EventArgs e)
        {
            if (sure > 1500)
            {
                zarTimer.Stop();
                ilerleTimer.Start();
                sure = 0;
            }
            else
                sure += 150;

            sayi[0] = char.Parse(zar.Next(1, 7).ToString());
            sayi[1] = char.Parse(zar.Next(1, 7).ToString());
            playerZar.Text = new string(sayi);
            atilanZar = int.Parse(sayi[0].ToString());
            atilanZar += int.Parse(sayi[1].ToString());
        }

        private void ilerleTimer_Tick(object sender, EventArgs e)
        {
            if (atilanZar != 0)
                ilerle(oynamaSirasi(), 1);
            else
            { 
                ilerleTimer.Stop();
                soruSor(oynamaSirasi());
                this.BringToFront();
                karart.Hide();
                guncelle();
                siraDegistir();
            }
            
            atilanZar--;
            
        }

        private void test1_Click(object sender, EventArgs e)
        {
            ilerle(oyuncu, 1);
        }

        private void test2_Click(object sender, EventArgs e)
        {
            ilerle(AI, 1);
        }
    }
}

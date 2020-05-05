using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace egepoly
{
    public partial class menuForm : Form
    {
        public menuForm()
        {
            InitializeComponent();
        }

        private void menuForm_Load(object sender, EventArgs e)
        {
            
        }

        private void cikisBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void oyunaBaslaBtn_Click(object sender, EventArgs e)
        {
            gameForm oyun = new gameForm();
            this.Hide();
            oyun.Show();
        }
    }
}

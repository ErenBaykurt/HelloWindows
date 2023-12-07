using GameLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWindows
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
            
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == string.Empty || txtSoyad.Text == string.Empty )
            {
                MessageBox.Show("Ad Soyad Zorunlu!");
            }
            else
            {
                
                Level seviye;
                if (rdKolay.Checked)
                {
                    seviye = Level.Kolay;
                }
                else if (rdOrta.Checked)
                {
                    seviye = Level.Orta;
                }
                else if (rdZor.Checked)
                {
                    seviye = Level.Zor;
                }
                else
                {
                    MessageBox.Show("Lütfen Zorluk Seçiniz");
                    return;
                }
                //GameInfo gameInfo = new GameInfo()
                //{
                    //ad = txtad.text.trim(),
                    //soyad = txtsoyad.text.trim(),
                  //  seviye = seviye,
                //};
                frmOyun frmOyun = new frmOyun(new GameInfo { Ad=txtAd.Text.Trim(),Soyad =txtSoyad.Text.Trim(),Seviye=seviye});
                frmOyun.Show();
            }
        }
    }
}

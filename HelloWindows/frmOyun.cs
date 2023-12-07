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
    public partial class frmOyun : Form
    {
       
        public frmOyun( GameInfo gameInfo)
        {
            InitializeComponent();
            lblAdSoyad.Text = $"{gameInfo.Ad} {gameInfo.Soyad}";
            switch (gameInfo.Seviye)
            {
                case Level.Kolay:
                    this.Size = new Size(300, 300);
                    break;
                case Level.Orta:
                    this.Size = new Size(500, 500);
                    break;
                case Level.Zor:
                    this.Size = new Size(800, 800);
                    break;
                default:
                    break;
            }
        }
        Random rnd = new Random();
        int Skor = 0;
        int sure = 10;



        private void btnYakala_MouseMove(object sender, MouseEventArgs e)
        {
            Button b=(Button)sender;

            b.Location = new Point(rnd.Next(this.ClientSize.Width-btnYakala.Width-pnlBilgi.Width), rnd.Next(this.ClientSize.Height-btnYakala.Height));
            if (b.Name == "btnYakala")
            {
                Skor++;
            }
            else
            {
                Skor-=5;
            }
            
            lblSkor.Text = Skor.ToString();
            if (!tmrSure.Enabled)
            {
                tmrSure.Start();
            }
            if (Skor % (sure+1) == 0)
            {
                var btn = new Button();
                btn.Size = new Size(50,50);
                btn.BackColor = Color.Red;
                btn.Location = new Point(rnd.Next(this.ClientSize.Width - btnYakala.Width - pnlBilgi.Width), rnd.Next(this.ClientSize.Height - btnYakala.Height));
                btn.MouseMove += btnYakala_MouseMove;
                this.Controls.Add(btn);
            }
        }

        private void Btn_MouseMove(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void frmOyun_SizeChanged(object sender, EventArgs e)
        {
            pnlBilgi.Location = new Point(this.ClientSize.Width - pnlBilgi.Width, 0);
            pnlBilgi.Height = this.ClientSize.Height;
        }

        private void tmrSure_Tick(object sender, EventArgs e)
        {
            lblSure.Text = sure.ToString();
           
            if( sure < 0)
            {
                tmrSure.Stop();
                MessageBox.Show("Süreniz Doldu");
                foreach(Control item in this.Controls)
                {
                    if (item is Button)
                    {
                       item.Enabled = false;
                    }
                }
            }
            sure--;
        }

       
    }
}

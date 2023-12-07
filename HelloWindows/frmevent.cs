using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWindows
{
    public partial class frmevent : Form
    {
        int sonuc = 0;
        public frmevent()
        {
            InitializeComponent();

            Random random = new Random();
            
            btnsayi1.Text=random.Next(0,50).ToString();
            btnsayi2.Text = random.Next(0, 50).ToString();
            btnsayi3.Text = random.Next(0, 50).ToString();
        }


        private void frmevent_MouseMove(object sender, MouseEventArgs e)
        {
            lblText.Text = "Gazili Olmak Ayrıcalıktır";
            lblKoordinat.Text =e.Location.ToString();
        }

        private void frmevent_MouseLeave(object sender, EventArgs e)
        {
            lblText.Text= string.Empty;
        }
        private void Topla(object sender, EventArgs e)
        {
            Button btn =(Button)sender;
            sonuc +=int.Parse( btn.Text);
          
        }

        private void btnSonuc_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Sonuç={sonuc}");
        }

    }
}

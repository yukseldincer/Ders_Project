using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metotlar2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            YilDoldur();
            AyDoldur();
            GunDoldur();

        }

        private void GunDoldur(string seciliAy = "")
        {
            if (seciliAy=="")
            {
                
            }
            else if (seciliAy=="Şubat")
            {
                GunSayisi(28); 
            }
            else
            {
                GunSayisi(31);
            }
        }//ok

        private void GunSayisi(int gunSayisi)
        {
            cbGun.Items.Clear();
            for (int i = 1; i <= gunSayisi; i++)
            {
                cbGun.Items.Add(i);
            }
        }//ok

        private void AyDoldur()
        {
            DateTime simdikiZaman = DateTime.Now;
            for (int i = 0; i < 12; i++)
            {
                string ay = simdikiZaman.ToString("MMMM");
                cbAy.Items.Add(ay);
                simdikiZaman = simdikiZaman.AddMonths(1);
            }
        }//ok

        private void YilDoldur()
        {
            for (int yil = 2000; yil < 2016; yil++)
            {
                cbYıl.Items.Add(yil);
            }
        }//ok

        private void btnGorevEkle_Click(object sender, EventArgs e)
        {
            GorevListesineEKle();
            GorevListesiniTazele();
        }

        private void GorevListesineEKle()
        {
        }

        private void GorevListesiniTazele()
        {

        }
        public class Gorev
        {
            public int yil;
            public string ay;
            public int gun;
            public string gorev;
        }

        private void cbAy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seciliAy = cbAy.SelectedItem.ToString();
            GunDoldur(seciliAy);
        }
    }
}

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

namespace Method03
{
    public partial class Form1 : Form
    {
        #region GlobalDegiskenler
        ArrayList gorevListesi = new ArrayList();
        #endregion
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            YillariDoldur();
            AylariDoldur();
            GunleriDoldur();
        }
        private void btnGorevEkle_Click(object sender, EventArgs e)
        {
            GorevListesineEkle();
            GorevListesiniTazele();
        }
        private void cbAy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seciliAy = cbAy.SelectedItem.ToString();
            GunleriDoldur(seciliAy);
        }
        // lbGorevListesi gorevListesi arrayi ile foreach kullanılarak doldurulacak
        private void GorevListesiniTazele()
        {
            throw new NotImplementedException();
        }
        // gorevListesi arrayi Gorev classı ile doldurulacak
        private void GorevListesineEkle()
        {
            gorevListesi.Add(new Gorev 
            { 
                ay = "",
                yil = 0,
                gun = 0,
                gorev = ""
            });
        }
        // seciliAy "" sa cbGun bos olacak, eğer secili ay varsa o aya gore (if else)
        // subat ayı ise 28, digerlerinde 31
        private void GunleriDoldur(string seciliAy = "")
        {
            throw new NotImplementedException();
        }
        // Datetime a 1 ay ekleyerek for dongusu ile dolacak. Toplam 12 ay var
        private void AylariDoldur()
        {
            DateTime suankiZaman = DateTime.Now;
            for (int i = 0; i < 12; i++)
            {
                //http://www.csharp-examples.net/string-format-datetime/
                //String format ile ayın ismi alınır
                string ay = suankiZaman.ToString("MMMM");
                cbAy.Items.Add(ay);
                suankiZaman = suankiZaman.AddMonths(1);
            }
        }
        // 2000 ile 2015 arasında for dongusu ile dolacak
        private void YillariDoldur()
        {
            throw new NotImplementedException();
        }
    }

    public class Gorev
    {
        public int yil;
        public string ay;
        public int gun;
        public string gorev;
    }
}

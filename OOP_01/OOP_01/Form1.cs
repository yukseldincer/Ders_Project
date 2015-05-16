using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Ogrenci ogr = new Ogrenci();
            //ogr.ogrenciNo = 6;
            //MessageBox.Show(ogr.ogrenciNo.ToString());

            //Rectangle rect = new Rectangle();
            //double area = rect.Height * rect.Width;

            //Dikdortgen dikdort = new Dikdortgen(10, 20);
            //area = dikdort.GetArea();
            //MessageBox.Show(area.ToString());

            Personel prs = new Personel("15", "Yüksel", "Dinçer");
            MessageBox.Show(prs.PersonelBilgisiGetir().ToString());

            Personel prs2 = new Personel();
            prs2.personelNo = "16";
            prs2.ad = "Ahmet";
            prs2.soyad = "Kambur";

            MessageBox.Show(prs2.PersonelBilgisiGetir().ToString());

        }
    }
}

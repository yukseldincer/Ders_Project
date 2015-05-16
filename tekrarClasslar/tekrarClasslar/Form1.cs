using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tekrarClasslar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dikdortgen dik1 = new Dikdortgen(10,20);
            int alan = dik1.AlanHesapla();
            Point pozisyon = dik1.PozisyonuGetir();

            Ucgen uc1 = new Ucgen();
            uc1.taban = 20;
            uc1.yukseklik = 40;
            int alan2 = uc1.AlanHesapla();
            Point pozisyon2 = uc1.PozisyonuGetir();

            Cember cember1 = new Cember();
            cember1.yaricap = 15;
            int calan = cember1.AlanHesapla();
            Point cpozisyon = cember1.PozisyonuGetir();
        }
    }
}

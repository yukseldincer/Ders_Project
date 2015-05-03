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

namespace Methodlar02
{
    public partial class Form1 : Form
    {
        ArrayList tasitCinsiListesi = new ArrayList();
        ArrayList markaListesi = new ArrayList();
        ArrayList tasitlar = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tasitCinsiDoldur();
            markaDoldur();
            tasitlarDoldur();
        }

        private void tasitlarDoldur()
        {
            /*lbTasit.Items.Add("CLK 180");
            lbTasit.Items.Add("AXOR");
            lbTasit.Items.Add("Sultan");
            lbTasit.Items.Add("Şahin");
            lbTasit.Items.Add("Doğan");
            lbTasit.Items.Add("Kartal");
            lbTasit.Items.Add("Doblo");
            lbTasit.Items.Add("Kangoo");
            lbTasit.Items.Add("Linea");
            lbTasit.Items.Add("Fatih");*/
        }

        private void markaDoldur()
        {
            markaListesi.Add("Mercedes");
            markaListesi.Add("BMC");
            markaListesi.Add("Otokar");
            markaListesi.Add("Tofaş");
            markaListesi.Add("Fiat");
            markaListesi.Add("Renault");
        }

        private void tasitCinsiDoldur()
        {
            tasitCinsiListesi.Add("Otomobil");
            tasitCinsiListesi.Add("Kamyonet");
            tasitCinsiListesi.Add("Kamyon");
            tasitCinsiListesi.Add("Minibis");
            tasitCinsiListesi.Add("Kamyon");
        }
        public class Tasit
        {
            public string tasitCinsi;
            public string marka;
            public string yakit;
            public string isim;
        }
    }
}

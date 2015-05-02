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

namespace randomDeger
{
    public partial class Form1 : Form
    {
        ArrayList rgl = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int uret = rnd.Next(0, 101);
                rgl.Add(uret);
                lbSayilar.Items.Add(uret);

        }

        private void btnIlk_Click(object sender, EventArgs e)
        {
            rgl.Sort();
            MessageBox.Show(rgl[0].ToString());
        }

        private void btnSon_Click(object sender, EventArgs e)
        {

            rgl.Reverse();
            MessageBox.Show(rgl[0].ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btn3Bol_Click(object sender, EventArgs e)
        {
            ArrayList uceBolunenSayilarDizisi = new ArrayList();
            foreach (int sayi in rgl)
            {
                if (sayi % 3 == 0)
                {
                    uceBolunenSayilarDizisi.Add(sayi);
                }
                lbUceBolunen.Items.Add(sayi);
            }
            
            }

        private void btn3BolBuyuk_Click(object sender, EventArgs e)
        {
            ArrayList uceBolunenSayilarDizisi = new ArrayList();
            foreach (int sayi in rgl)
	{
        if (sayi % 3 == 0)
        {
            uceBolunenSayilarDizisi.Add(sayi);
        }
        if (uceBolunenSayilarDizisi.Count>0)
        {
            uceBolunenSayilarDizisi.Reverse();
            MessageBox.Show(uceBolunenSayilarDizisi[0].ToString());
        }
        else
        {
            MessageBox.Show("3 Bölünen Sayı Yok");
        }
	}

        }
        }
    }


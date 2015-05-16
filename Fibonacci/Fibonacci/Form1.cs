using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonacci
{
    public partial class Form1 : Form
    {
        #region GlobalDegiskenler

        int[] fibonacciDizisi;

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            int ilkDeger = Convert.ToInt32(nudIlkEleman.Value);//
            int diziUzunluğu = Convert.ToInt32(nudDiziUzunluk.Value);//
            FibonacciDizisiniDoldur(ilkDeger, diziUzunluğu);

            int elamanIndex = Convert.ToInt32(nudDiziElemanı.Value);//
            int seciliDiziElemani = DiziElemaniniGetir(elamanIndex);
            MessageBox.Show(seciliDiziElemani.ToString());
        }

        private int DiziElemaniniGetir(int elamanIndex)
        {
            if (elamanIndex < 0)
                return 0;
            else
                return fibonacciDizisi[elamanIndex];
        }

        private void FibonacciDizisiniDoldur(int ilkDeger, int diziUzunluğu)
        {
            fibonacciDizisi = new int[diziUzunluğu];
            
            //fibonacciDizisi[0] = ilkDeger;
            //lbDiziListesi.Items.Add(ilkDeger);

            //fibonacciDizisi[1] = ilkDeger + fibonacciDizisi[0];
            //lbDiziListesi.Items.Add(ilkDeger + fibonacciDizisi[0]);

            //for (int i = 2; i < diziUzunluğu; i++)
            //{
            //    int deger = DiziElemaniniGetir(i - 1) + DiziElemaniniGetir(i - 2);
            //    fibonacciDizisi[i] = deger;
            //    lbDiziListesi.Items.Add(deger);
            //}

            for (int i = 1; i < diziUzunluğu; i++)
            {
                fibonacciDizisi[i] = fiboHesapla(i);
                lbDiziListesi.Items.Add(fibonacciDizisi[i]);
            }
        }

        public int fiboHesapla(int sayi)
        {
            if (sayi == 1 || sayi == 0)
                return 1;

            return fiboHesapla(sayi - 1) + fiboHesapla(sayi - 2);
        }
    }
}

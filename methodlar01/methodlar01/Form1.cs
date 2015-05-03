using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace methodlar01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AylarıDoldur(1);
            
        }
        #region Methodlar
        //private oldugunda sadece mevcut clastan ulaşılabilen bir methot olur
        // public oldugunda ise heryerden erişilebilir.
        private bool AylarıDoldur(int seciliAyinIndexi)
        {
            try
            {
                DateTime simdikiZaman = DateTime.Now;
                for (int i = 0; i < 12; i++)
                {
                    string ay = simdikiZaman.ToString("MMMM");
                    cbAylar.Items.Add(ay);
                    simdikiZaman = simdikiZaman.AddMonths(1);
                }
                /* cbAylar.Items.Add("Ocak");
                 cbAylar.Items.Add("Şubat");
                 cbAylar.Items.Add("Mart");
                 cbAylar.Items.Add("Nisan");
                 cbAylar.Items.Add("Mayıs");
                 cbAylar.Items.Add("Haziran");
                 cbAylar.Items.Add("Temmuz");
                 cbAylar.Items.Add("Ağustos");
                 cbAylar.Items.Add("Eylül");
                 cbAylar.Items.Add("Ekim");
                 cbAylar.Items.Add("Kasım");
                 cbAylar.Items.Add("Aralık");
                 cbAylar.SelectedIndex = seciliAyinIndexi;*/
                return true;
            }
            catch
            {
                return false;
                
            }
           
        }
        #endregion
    }
}
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

namespace Arrayler02
{
    public partial class Form1 : Form
    {
        ArrayList sehirler = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSehirler_Click(object sender, EventArgs e)
        {
            string[] array =new string[3];

            List<string> array3 = new List<string>();

            Dictionary<int, string> array4 = new Dictionary<int, string>();

            ArrayList array5 = new ArrayList();

            
            string mesajYazisi = "";
            for (int i = 0; i < sehirler.Count; i++)
            {
                object sehir = sehirler[i];
                mesajYazisi =mesajYazisi + i.ToString() + "." + sehir.ToString() + Environment.NewLine;
            }
            foreach (object sehir in sehirler)
            {
                
            }
            MessageBox.Show(mesajYazisi);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            sehirler.Add("İzmir");
            sehirler.Add("İstanbul");
            sehirler.Add("Ankara");
            sehirler.Add("Adana");
        }

        private void btnIlk_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sehirler[0].ToString());
        }

        private void btnIki_Click(object sender, EventArgs e)
        {
            int lastIndex = sehirler.Count - 1;
            MessageBox.Show(sehirler[lastIndex].ToString());
        }

        private void btnSirala_Click(object sender, EventArgs e)
        {
            sehirler.Sort();
        }

        private void btnTersSirala_Click(object sender, EventArgs e)
        {
            sehirler.Reverse();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Hayvan> hayvanlar = new List<Hayvan>();

            Hayvan hayvan = new Hayvan
            {
                Ad = "Hayvan1",
                DogumTarihi = DateTime.Now.AddYears(-3)
            };
            hayvanlar.Add(hayvan);

            Yilan yilan = new Yilan();
            yilan.Ad = "Yılan";
            yilan.DogumTarihi = DateTime.Now.AddYears(-13);
            hayvanlar.Add(yilan);
           
 
            hayvanlar.Add(new Kedi("Minnoş",DateTime.Now.AddYears(-6)));
            foreach (Hayvan h in hayvanlar)
            {
                MessageBox.Show(h.DetaylariGetir());
            }
        }
    }
}

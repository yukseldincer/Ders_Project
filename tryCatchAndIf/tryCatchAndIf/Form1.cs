using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tryCatchAndIf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        bool ilkiHatalimi = true;
        private void btnkontrol_Click(object sender, EventArgs e)
        {
            try
            {
            int sayi1 = Convert.ToInt32(txt1.Text);
            ilkiHatalimi = false;
            int sayi2 = Convert.ToInt32(txt2.Text);
            }
            #region FormatExpection
            catch (FormatException fex)
            {
                if (ilkiHatalimi)
                {
                    int cevrilenSayi;
                    if (int.TryParse(txt2.Text, out cevrilenSayi))
                    {
                        MessageBox.Show("Birinci Degerin Formatı Yanış\n"+ fex.Message);
                    }
                    else
                    {
                        MessageBox.Show("Herikiside Degeri Format Yanlış\n"+ fex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("İkinici Degerin Formatı Yanlış\n"+ fex.Message);
                    ilkiHatalimi = true;
                }
            #endregion
            }
            catch (OverflowException oex)
            {
                MessageBox.Show("DogruDuzgun deger git\n"+oex.Message);
            }
            catch (Exception)
            {
                if (ilkiHatalimi)
                {
                    int cevrilenSayi;
                    if (int.TryParse(txt2.Text, out cevrilenSayi))
                    {
                        MessageBox.Show("Birinci Deger Yanış");
                    }
                    else
                    {
                        MessageBox.Show("Herikiside Yanlış");
                    }
                }
                else
                {
                    MessageBox.Show("İkinici Sayı Yanlış");
                    ilkiHatalimi = true;
                }
                
            }
            finally
            {
                MessageBox.Show("İşlem Bitti");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal KazanılanPara = 0;
        
        Random rnd = new Random();
        private void button3_Click(object sender, EventArgs e)
        {
            if ((rdnBeyaz.Checked|rdnKahve.Checked|radioButton1.Checked)&(cmbMisli.Text!="")&(comboBox1.SelectedItem!=null))
            {
                timer1.Start();
            }
            else
	{
               MessageBox.Show("Boş Alan Bırakmayınız");
	}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            kahveAt.Left += rnd.Next(5, 16);
            beyazAt.Left += rnd.Next(5, 16);
            
            int misli=Convert.ToInt32(comboBox1.Text);
            if (beyazAt.Left+beyazAt.Width>=label1.Left && beyazAt.Left>kahveAt.Left)
            {
                timer1.Stop();
                if (rdnBeyaz.Checked)
                {
                    KazanılanPara += 3.20m * Convert.ToDecimal(cmbMisli.Text) * misli;
                    MessageBox.Show("Kazandınız\nAlacagınız Para:" + " " + KazanılanPara);
                }
                else
                {
                    KazanılanPara -= 3.20m * Convert.ToDecimal(cmbMisli.Text) * misli;
                    MessageBox.Show("Kaybettin\nKalan Para" + " " + KazanılanPara);
                }
                beyazAt.Left = 0;
                kahveAt.Left = 0;
            }
            else if(kahveAt.Left+kahveAt.Width>=label1.Left && kahveAt.Left>beyazAt.Left)
            {
                timer1.Stop();
                if (rdnKahve.Checked)
                {
                    KazanılanPara += 1.70m * Convert.ToDecimal(cmbMisli.Text) * misli;
                    MessageBox.Show("Kazandınız\nAlacagınız Para:" + " " + KazanılanPara);
                }
                else
                {
                    KazanılanPara -= 1.70m * Convert.ToDecimal(cmbMisli.Text) * misli;
                    MessageBox.Show("Kaybettin\nKalan Para" + " " + KazanılanPara);
                }
                beyazAt.Left = 0;
                kahveAt.Left = 0;
            }
            else if (beyazAt.Left+beyazAt.Width==label1.Left && kahveAt.Left+kahveAt.Width==label1.Left)
            {
                timer1.Stop();
                if (radioButton1.Checked)
                {
                    KazanılanPara += 2.20m * Convert.ToDecimal(cmbMisli.Text) * misli;
                    MessageBox.Show("Kazandın\nKalan Para" + " " + KazanılanPara);
                }
                beyazAt.Left = 0;
                kahveAt.Left = 0;
            }
            textBox2.Text = KazanılanPara.ToString();
            }
    
            }
        
    }


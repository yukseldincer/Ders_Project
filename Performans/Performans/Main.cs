using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Performans
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            GitCb();
        }

        private void GitCb()
        {
            cbDeparman.Items.Add("Evrak Kontrol");
            cbDeparman.Items.Add("Data Girişi");
            cbDeparman.Items.Add("Tasnif");
            cbDeparman.Items.Add("Tarama");
            cbDeparman.Items.Add("Toplama");
            cbDeparman.Items.Add("İndex");
            cbDeparman.Items.Add("MNP");
        }
        private void btnGit_Click(object sender, EventArgs e)
        {
            GitDepartmanSec();


        }

        private void GitDepartmanSec()
        {
            if (cbDeparman.SelectedIndex==0)
            {
                evrakKontrol ekform = new evrakKontrol();
                ekform.Show();
            }
            else if (cbDeparman.SelectedIndex==1)
            {
                dataGirisi dgform = new dataGirisi();
                dgform.Show();
            }
            else if (cbDeparman.SelectedIndex==2)
            {
                tasnif tsform = new tasnif();
                tsform.Show();
            }
            else if (cbDeparman.SelectedIndex==3)
            {
                tarama trform = new tarama();
                trform.Show();
            }
            else if (cbDeparman.SelectedIndex==4)
            {
                toplama tpform = new toplama();
                tpform.Show();
            }
            else if (cbDeparman.SelectedIndex==5)
            {
                index iform = new index();
                iform.Show();
            }
            else if (cbDeparman.SelectedIndex==6)
            {
                mnp mform = new mnp();
                mform.Show();
            }
            else
            {
                MessageBox.Show("Peformans Girmek\n İstediğiniz Departmanı Seçiniz");
            }
        }



    }
}

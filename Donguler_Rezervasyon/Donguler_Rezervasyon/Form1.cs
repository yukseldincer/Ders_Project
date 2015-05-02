using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donguler_Rezervasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int btnX;
        int btnY;
        private void btnKoltuklariYerlestir_Click(object sender, EventArgs e)
        {
            btnX = Convert.ToInt32(nubXSirasi.Value);
            btnY = Convert.ToInt32(nubYSirasi.Value);
            GitUret(btnX, btnY);
        }

        private void GitUret(int btnX, int btnY)
        {
            for (int x = 0; x < btnX; x++)
            {
                for (int y = 0; y < btnY; y++)
                {
                    Button bt = new Button();
                    bt.Location = GitLokasyon(x, y);
                    bt.Text = "-";
                    bt.Click += bt_Click;
                    Koltuk kt = new Koltuk();
                    kt.xKonumu = x;
                    kt.yKonumu = y;
                    kt.cinsiyetTipi = CinsiyetTipi.TanimliDegil;
                    bt.Tag = kt;
                    bt.Size = new System.Drawing.Size(50, 50);
                    scAnaPanel.Panel2.Controls.Add(bt);
                }
            }
        }
        class Koltuk
        {
            public int yKonumu;
            public int xKonumu;
            public CinsiyetTipi cinsiyetTipi;
        }

        enum CinsiyetTipi
        {
            TanimliDegil = 0,
            erkek = 1,
            kadin = 2,
            hicbiri = 3
        }
        void bt_Click(object sender, EventArgs e)
        {
            Button bt = (sender as Button);// null degerli kullanamazsın
            Koltuk kt = ((Koltuk)bt.Tag);
            CinsiyetTipi cinsiyetTipi = kt.cinsiyetTipi;
            int xKonumu = kt.xKonumu;
            int yKonumu = kt.yKonumu;

            Koltuk yankt = GitKoltukGetir(kt);
            if (cinsiyetTipi == CinsiyetTipi.TanimliDegil)
            {
                if (rbErkek.Checked)
                {
                    if (yankt.cinsiyetTipi == CinsiyetTipi.erkek || yankt.cinsiyetTipi == CinsiyetTipi.TanimliDegil || yankt.cinsiyetTipi == CinsiyetTipi.hicbiri)
                    {
                        bt.Text = "E";
                        kt.cinsiyetTipi = CinsiyetTipi.erkek;
                        bt.Tag = kt;
                        bt.BackColor = Color.Blue;
                    }
                    else
                    {
                        DialogResult mesajSonucu = MessageBox.Show("Farklı Cinsiyetler Yanyana Oturamaz", "Cinsiyet Farklılığı", MessageBoxButtons.YesNo);
                        if (mesajSonucu == System.Windows.Forms.DialogResult.Yes)
                        {
                            bt.Text = "E";
                            kt.cinsiyetTipi = CinsiyetTipi.erkek;
                            bt.Tag = kt;
                            bt.BackColor = Color.Blue;
                        }
                    }
                }
                else if (rbBayan.Checked)
                {
                    if (yankt.cinsiyetTipi == CinsiyetTipi.kadin || yankt.cinsiyetTipi == CinsiyetTipi.TanimliDegil || yankt.cinsiyetTipi == CinsiyetTipi.hicbiri)
                    {


                        bt.Text = "K";
                        kt.cinsiyetTipi = CinsiyetTipi.kadin;
                        bt.Tag = kt;
                        bt.BackColor = Color.Pink;
                    }
                    else
                    {
                        DialogResult mesajSonucu = MessageBox.Show("Farklı Cinsiyetler Yanyana Oturamaz", "Cinsiyet Farklılığı", MessageBoxButtons.YesNo);
                        if (mesajSonucu == System.Windows.Forms.DialogResult.Yes)
                        {
                            bt.Text = "K";
                            kt.cinsiyetTipi = CinsiyetTipi.kadin;
                            bt.Tag = kt;
                            bt.BackColor = Color.Pink;
                        }
                    }
                }
                else if (rbHicbiri.Checked)
                {
                    bt.Text = "H";
                    kt.cinsiyetTipi = CinsiyetTipi.hicbiri;
                    bt.Tag = kt;
                    bt.BackColor = Color.Purple;
                }
                else
                {
                    bt.Text = "-";
                    kt.cinsiyetTipi = CinsiyetTipi.TanimliDegil;
                    bt.Tag = kt;
                    bt.BackColor = Color.Empty;
                }
            }
            else
            {
                bt.Text = "-";
                kt.cinsiyetTipi = CinsiyetTipi.TanimliDegil;
                bt.Tag = kt;
                bt.BackColor = Color.Empty;
            }
        }



        private Koltuk GitKoltukGetir(Koltuk kt)
        {
            Koltuk yankt = new Koltuk();
            foreach (Control cnt in scAnaPanel.Panel2.Controls)
            {
                if (cnt is Button)
                {
                    Button bt = (cnt as Button);
                    Koltuk dgkt = ((Koltuk)bt.Tag);
                    if (kt.yKonumu == dgkt.yKonumu)
                    {
                        int artisSaysi;
                        if (kt.xKonumu % 2 == 0)
                        {
                            artisSaysi = 1;
                        }
                        else
                        {
                            artisSaysi = -1;
                        }
                        if (dgkt.xKonumu == kt.xKonumu + artisSaysi)
                        {
                            yankt = dgkt;
                            break;
                        }
                    }
                }
            }
            return yankt;
        }
        private Point GitLokasyon(int x, int y)
        {
            int panelX = (x * 50);
            int panelY = (y * 50);
            Point p = new Point();
            p.X = panelX;
            p.Y = panelY;

            return p;
        }

        private void scAnaPanel_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbKoltukTipi.SelectedIndex = 2;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbKoltuk_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbKoltuk.SelectedItem == "Pencere")
            {
                foreach (Control cnt in scAnaPanel.Panel2.Controls)
                {
                    if (cnt is Button)
                    {
                        Button bt = (cnt as Button);
                        Koltuk koltuk = ((Koltuk)bt.Tag);
                        bt.Enabled = true;
                        if (koltuk.xKonumu == 1 || koltuk.xKonumu == 2)
                        {
                            bt.Enabled = false;
                        }

                    }
                }
            }

            else if (cbKoltuk.SelectedItem == "Koridor")
            {
                foreach (Control cnt in scAnaPanel.Panel2.Controls)
                {
                    if (cnt is Button)
                    {
                        Button bt = (cnt as Button);
                        Koltuk koltuk = ((Koltuk)bt.Tag);
                        bt.Enabled = true;
                        if (koltuk.xKonumu == 0 || koltuk.xKonumu == 3)
                        {
                            bt.Enabled = false;
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Koltuk Tipi Seçiniz");
            }
        }

        private void lbKoltukTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbKoltukTipi.SelectedIndex == 2)
            {
                foreach (Control cnt in scAnaPanel.Panel2.Controls)
                {
                    if (cnt is Button)
                    {
                        Button bt = (cnt as Button);
                        Koltuk koltuk = ((Koltuk)bt.Tag);
                        Koltuk yankt = GitKoltukGetir(koltuk);
                        if (yankt.cinsiyetTipi == CinsiyetTipi.hicbiri || yankt.cinsiyetTipi == CinsiyetTipi.kadin || yankt.cinsiyetTipi == CinsiyetTipi.hicbiri)
                        {
                            bt.Enabled = true;
                        }
                        else
                        {
                            bt.Enabled = false;
                        }
                    }
                }
            }
            else if (lbKoltukTipi.SelectedIndex == 0)
            {
                foreach (Control cnt in scAnaPanel.Panel2.Controls)
                {
                    if (cnt is Button)
                    {
                        Button bt = (cnt as Button);
                        Koltuk koltuk = ((Koltuk)bt.Tag);
                        Koltuk yankt = GitKoltukGetir(koltuk);
                        if (yankt.cinsiyetTipi == CinsiyetTipi.hicbiri || yankt.cinsiyetTipi == CinsiyetTipi.kadin)
                        {
                            bt.Enabled = true;
                        }
                        else
                        {
                            bt.Enabled = false;
                        }
                    }
                }
            }
            else if (lbKoltukTipi.SelectedIndex==1)
            {
                foreach (Control cnt in scAnaPanel.Panel2.Controls)
                {
                    if (cnt is Button)
                    {
                        Button bt = (cnt as Button);
                        Koltuk koltuk = ((Koltuk)bt.Tag);
                        Koltuk yankt = GitKoltukGetir(koltuk);
                        if (yankt.cinsiyetTipi == CinsiyetTipi.hicbiri || yankt.cinsiyetTipi == CinsiyetTipi.erkek)
                        {
                            bt.Enabled = true;
                        }
                        else
                        {
                            bt.Enabled = false;
                        }
                    }
                }
            }
        }
    }
}

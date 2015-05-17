﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ParaTransferi paraTransferi = new ParaTransferi();
            paraTransferi.TransferBeklemedemi += paraTransferi_TransferBeklemedemi;
            paraTransferi.TransferDurumu = TransferStatus.Tamamlandı;
            paraTransferi.TransferDurumu = TransferStatus.Beklemede;
        }

        void paraTransferi_TransferBeklemedemi(ParaTransferi paraTransferi)
        {
            MessageBox.Show("Transfer Beklemeye Alındı");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_04
{
    public delegate void TransferBeklemedemiHandler(ParaTransferi paraTransferi);
    public class ParaTransferi
    {
        public event TransferBeklemedemiHandler TransferBeklemedemi;
        public int Id { get; set; }
        public double Miktar { get; set; }

        private TransferStatus transferDurumu;
        public TransferStatus TransferDurumu
        {
            get
            {
                return this.transferDurumu;
            }
            set
            {
                this.transferDurumu = value;
                if (this.transferDurumu == TransferStatus.Beklemede)
                {
                        TransferBeklemedemi.Invoke(this);
                }
            }

        }
        public enum TransferStatus
        {
            Tamamlandı = 0,
            Beklemede = 1,
            Iptal = 2
        }
    }
}

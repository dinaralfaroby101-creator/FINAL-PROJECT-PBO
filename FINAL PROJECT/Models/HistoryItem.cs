using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT.Models
{
    public class HistoryItem
    {
        public int IdTransaksi { get; set; }

        public string KodeSlot { get; set; }

        public string PlatNomor { get; set; }

        public string JenisKendaraan { get; set; }

        public DateTime WaktuMasuk { get; set; }

        public DateTime WaktuKeluar { get; set; }

        public int DurasiParkir { get; set; }

        public decimal TotalBiaya { get; set; }

        public string MetodePembayaran { get; set; }

        public string Petugas { get; set; }

        public string StatusTransaksi { get; set; }
    }
}
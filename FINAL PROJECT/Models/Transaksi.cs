using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT.Models
{
    public class Transaksi
    {
        public int IdTransaksi { get; set; }

        public int IdKendaraan { get; set; }

        public int IdSlot { get; set; }

        public int IdUser { get; set; }

        public int IdTarif { get; set; }

        public int IdMetodePembayaran { get; set; }

        public DateTime WaktuMasuk { get; set; }

        public DateTime? WaktuKeluar { get; set; }

        public decimal? TotalBiaya { get; set; }

        public string StatusTransaksi { get; set; }
    }
}

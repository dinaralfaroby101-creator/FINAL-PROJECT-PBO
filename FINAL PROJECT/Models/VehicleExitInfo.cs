using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT.Models
{
    public class VehicleExitInfo
    {
        public int IdTransaksi { get; set; }

        public string PlatNomor { get; set; }

        public string JenisKendaraan { get; set; }

        public string KodeSlot { get; set; }

        public string NamaPetugas { get; set; }

        public DateTime WaktuMasuk { get; set; }

        public int DurasiMenit { get; set; }
    }
}

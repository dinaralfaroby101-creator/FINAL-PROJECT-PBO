using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT.Models
{
    public class MonitoringItem
    {
        public string KodeSlot { get; set; }

        public string StatusSlot { get; set; }

        public string JenisKendaraan { get; set; }

        public string PlatNomor { get; set; }

        public DateTime WaktuMasuk { get; set; }

        public string NamaPetugas { get; set; }
    }
}
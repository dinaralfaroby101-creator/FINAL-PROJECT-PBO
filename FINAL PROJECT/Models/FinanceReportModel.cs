using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT.Models
{
    public class FinanceReportModel
    {
        public decimal PendapatanHariIni { get; set; }

        public int TotalTransaksi { get; set; }

        public decimal RataRataTransaksi { get; set; }

        public int TotalKendaraan { get; set; }
    }
}
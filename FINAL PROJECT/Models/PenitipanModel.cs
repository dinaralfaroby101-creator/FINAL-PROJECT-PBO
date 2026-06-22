using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT.Models
{
    public class PenitipanModel
    {
        public int IdPenitipan { get; set; }

        public string NamaPemilik { get; set; }

        public string NamaBarang { get; set; }

        public int JumlahBarang { get; set; }

        public DateTime WaktuMasuk { get; set; }

        private string _statusPenitipan;

        public string StatusPenitipan
        {
            get;
            set;
        }

        public void AmbilBarang()
        {
            _statusPenitipan = "diambil";
        }
    }
}

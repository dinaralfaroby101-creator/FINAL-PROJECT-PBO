using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT.Models
{
    public class Kendaraan
    {
        public int IdKendaraan { get; set; }

        private string _platNomor;

        public string PlatNomor
        {
            get => _platNomor;

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _platNomor =
                        value.ToUpper();
                }
            }
        }

        public string JenisKendaraan { get; set; }

        public int IdMerkKendaraan { get; set; }
    }
}

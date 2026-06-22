using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT.Models
{
    public class ParkingSlotModels
    {
        private string _kodeSlot;
        private string _statusSlot;

        public int IdSlot { get; set; }

        public string KodeSlot
        {
            get => _kodeSlot;

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _kodeSlot = value.ToUpper();
                }
            }
        }

        public string StatusSlot
        {
            get => _statusSlot;

            set
            {
                if (value == "kosong" ||
                    value == "terisi" ||
                    value == "maintenance")
                {
                    _statusSlot = value;
                }
            }
        }
    }
}
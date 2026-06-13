using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT.Models
{
    public class MonitoringArea
    {
        public string Area { get; set; }

        public int TotalSlot { get; set; }

        public int SlotTerisi { get; set; }

        public int SlotKosong
        {
            get
            {
                return TotalSlot - SlotTerisi;
            }
        }
    }
}
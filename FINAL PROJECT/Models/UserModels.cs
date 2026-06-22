using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT.Models
{
    public class UserModels
    {
        public int IdUser { get; set; }

        private string _username;

        public string Username
        {
            get => _username;

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _username = value;
                }
            }
        }

        public string NamaLengkap { get; set; }

        public string Role { get; set; }

        public string StatusUser { get; set; }
    }
}

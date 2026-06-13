using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROJECT.Models
{
    public abstract class User
    {
        public int IdUser { get; set; }

        public string Username { get; set; }

        public string PasswordAkun { get; set; }

        public string NamaLengkap { get; set; }

        public string StatusUser { get; set; }

        public DateTime? LastLogin { get; set; }

        public abstract string GetRole();
    }
}

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

        private string _passwordAkun;

        public string PasswordAkun
        {
            get
            {
                return "********";
            }
            private set
            {
                _passwordAkun = value;
            }
        }

        public void ChangePassword(
            string passwordBaru)
        {
            if (passwordBaru.Length >= 8)
            {
                _passwordAkun = passwordBaru;
            }
        }

        public string NamaLengkap { get; set; }

        public string StatusUser { get; set; }

        public DateTime? LastLogin { get; set; }

        public abstract string GetRole();


    }
}

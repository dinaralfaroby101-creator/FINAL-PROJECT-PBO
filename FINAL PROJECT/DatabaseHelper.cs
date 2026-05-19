using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Npgsql;
using System.Threading.Tasks;

namespace FINAL_PROJECT
{
    static class DatabaseHelper
    {
        private static string connectionString =
            "Host=localhost;Port=5432;Database=Final_project_PBO;Username=postgres;Password=dinarjosjis";
        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
    }
    }
}

using FINAL_PROJECT.Database;
using Npgsql;
using System.Data;

namespace FINAL_PROJECT.Services
{
    public class UserService
    {
        public DataTable GetUsers()
        {
            DataTable dt = new DataTable();

            using (NpgsqlConnection conn =
                DatabaseHelper.Instance.GetConnection())
            {
                string query = @"
                SELECT
                    id_user,
                    nama_lengkap,
                    username,
                    role,
                    status_user,
                    last_login
                FROM users";

                using (NpgsqlDataAdapter da =
                    new NpgsqlDataAdapter(query, conn))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }

        public void TambahUser(
            string nama,
            string username,
            string password,
            string role)
        {
            using (NpgsqlConnection conn =
                DatabaseHelper.Instance.GetConnection())
            {
                string query = @"
                INSERT INTO users
                (
                    nama_lengkap,
                    username,
                    password_akun,
                    role,
                    status_user,
                    last_login
                )
                VALUES
                (
                    @nama,
                    @username,
                    @password,
                    @role,
                    'Active',
                    NOW()
                )";

                using (NpgsqlCommand cmd =
                    new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nama", nama);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@role", role);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

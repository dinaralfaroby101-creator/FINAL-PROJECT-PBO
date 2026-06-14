using FINAL_PROJECT.Data;
using FINAL_PROJECT.Interfaces;
using FINAL_PROJECT.Models;
using FINAL_PROJECT.Repositories;
using Npgsql;
using System.Data;

namespace FINAL_PROJECT.Services
{
    public class UserServices
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



        private readonly UserRepository
           _repository =
           new UserRepository();

        public List<UserModels> GetAll()
        {
            return _repository.GetAllUsers();
        }

        public void DeleteUser(int id)
        {
            _repository.DeleteUser(id);
        }

        public List<UserModels> Search(string keyword)
        {
            return _repository.Search(keyword);
        }




        public List<UserModels>
    GetByRole(string role)
        {
            return _repository
                .GetByRole(role);
        }




        public UserStatisticModel
    GetStatistic()
        {
            return _repository
                .GetStatistic();
        }
    }
}

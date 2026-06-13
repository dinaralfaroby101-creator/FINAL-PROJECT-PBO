using FINAL_PROJECT.Data;
using FINAL_PROJECT.Interfaces;
using FINAL_PROJECT.Models;
using Npgsql;

namespace FINAL_PROJECT.Repositories
{
    public class UserRepository : IRepository<User>
    {
        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(User entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(User entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public User Login(
    string username,
    string password)
        {
            using var conn =
                DatabaseHelper.Instance.GetConnection();

            string sql = @"
    SELECT *
    FROM users
    WHERE username=@username
    AND password_akun=@password";

            using var cmd =
                new NpgsqlCommand(sql, conn);

            cmd.Parameters.AddWithValue(
                "@username",
                username);

            cmd.Parameters.AddWithValue(
                "@password",
                password);

            using var reader =
                cmd.ExecuteReader();

            if (!reader.Read())
                return null;

            string role =
                reader["role"].ToString();

            if (role == "admin")
            {
                return new Admin
                {
                    IdUser =
                        Convert.ToInt32(reader["id_user"]),

                    Username =
                        reader["username"].ToString(),

                    NamaLengkap =
                        reader["nama_lengkap"].ToString(),

                    StatusUser =
                        reader["status_user"].ToString()
                };
            }

            return new Petugas
            {
                IdUser =
                    Convert.ToInt32(reader["id_user"]),

                Username =
                    reader["username"].ToString(),

                NamaLengkap =
                    reader["nama_lengkap"].ToString(),

                StatusUser =
                    reader["status_user"].ToString()
            };
        }
    }
}
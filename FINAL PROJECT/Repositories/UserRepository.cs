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




        public void DeleteUser(int id)
        {
            using var conn =
                DatabaseHelper.Instance.GetConnection();

            string sql = @"
        DELETE FROM users
        WHERE id_user=@id";

            using var cmd =
                new NpgsqlCommand(sql, conn);

            cmd.Parameters.AddWithValue(
                "@id",
                id);

            cmd.ExecuteNonQuery();
        }





        public List<UserModels> GetAllUsers()
        {
            List<UserModels> list = new();

            using var conn =
                DatabaseHelper.Instance.GetConnection();

            string sql = @"
        SELECT *
        FROM users
        ORDER BY id_user";

            using var cmd =
                new NpgsqlCommand(sql, conn);

            using var rd =
                cmd.ExecuteReader();

            while (rd.Read())
            {
                list.Add(
                    new UserModels
                    {
                        IdUser =
                            Convert.ToInt32(rd["id_user"]),

                        Username =
                            rd["username"].ToString(),

                        NamaLengkap =
                            rd["nama_lengkap"].ToString(),

                        Role =
                            rd["role"].ToString(),

                        StatusUser =
                            rd["status_user"].ToString()
                    });
            }

            return list;
        }






        public List<UserModels> Search(string keyword)
        {
            List<UserModels> list = new();

            using var conn =
                DatabaseHelper.Instance.GetConnection();

            string sql = @"
            SELECT *
            FROM users
            WHERE username ILIKE @search
            ORDER BY id_user";

            using var cmd = new NpgsqlCommand(sql, conn);

            cmd.Parameters.AddWithValue(
                "@search",
                "%" + keyword + "%");

            using var rd =
                cmd.ExecuteReader();

            while (rd.Read())
            {
                list.Add(
                    new UserModels
                    {
                        IdUser =
                            Convert.ToInt32(rd["id_user"]),

                        Username =
                            rd["username"].ToString(),

                        NamaLengkap =
                            rd["nama_lengkap"].ToString(),

                        Role =
                            rd["role"].ToString(),

                        StatusUser =
                            rd["status_user"].ToString()
                    });
            }

            return list;
        }




        public List<UserModels> GetByRole(string role)
        {
            List<UserModels> list =
                new();

            using var conn =
                DatabaseHelper.Instance.GetConnection();

            string sql = @"
    SELECT *
    FROM users
    WHERE role = @role::role_user_enum
    ORDER BY id_user";

            using var cmd =
                new NpgsqlCommand(sql, conn);

            cmd.Parameters.AddWithValue(
                "@role",
                role);

            using var rd =
                cmd.ExecuteReader();

            while (rd.Read())
            {
                list.Add(
                    new UserModels
                    {
                        IdUser =
                            Convert.ToInt32(
                                rd["id_user"]),

                        Username =
                            rd["username"]
                            .ToString(),

                        NamaLengkap =
                            rd["nama_lengkap"]
                            .ToString(),

                        Role =
                            rd["role"]
                            .ToString(),

                        StatusUser =
                            rd["status_user"]
                            .ToString()
                    });
            }

            return list;
        }






        public UserStatisticModel
    GetStatistic()
        {
            using var conn =
                DatabaseHelper.Instance.GetConnection();

            return new UserStatisticModel
            {
                TotalUser =
                    Convert.ToInt32(
                        new NpgsqlCommand(
                            "SELECT COUNT(*) FROM users",
                            conn)
                        .ExecuteScalar()),

                TotalAdmin =
                    Convert.ToInt32(
                        new NpgsqlCommand(
                            "SELECT COUNT(*) FROM users WHERE role='admin'",
                            conn)
                        .ExecuteScalar()),

                TotalPetugas =
                    Convert.ToInt32(
                        new NpgsqlCommand(
                            "SELECT COUNT(*) FROM users WHERE role='petugas'",
                            conn)
                        .ExecuteScalar()),

                TotalAktif =
                    Convert.ToInt32(
                        new NpgsqlCommand(
                            "SELECT COUNT(*) FROM users WHERE status_user='Active'",
                            conn)
                        .ExecuteScalar())
            };
        }





       
    }
}
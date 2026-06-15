using System;
using Npgsql;

namespace FINAL_PROJECT.Data   // sesuaikan nama project kamu
{
    public class DatabaseHelper
    {
        // ── Ganti sesuai PostgreSQL kamu ──
        private const string Host = "localhost";
        private const int Port = 5432;
        private const string Database = "project-akhir";
        private const string Username = "postgres";
        private const string Password = "gymtio2402";   // ganti ini
        // ──────────────────────────────────

        public static string ConnectionString =>
            $"Host={Host};Port={Port};Database={Database};" +
            $"Username={Username};Password={Password};";

        // Singleton Instance
        private static DatabaseHelper? _instance;
        public static DatabaseHelper Instance => _instance ??= new DatabaseHelper();

        private DatabaseHelper() { }

        public NpgsqlConnection GetConnection()
        {
            var conn = new NpgsqlConnection(ConnectionString);
            conn.Open();
            return conn;
        }

        public bool TestConnection()
        {
            try
            {
                using var conn = GetConnection();
                return conn.State == System.Data.ConnectionState.Open;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[DB ERROR] {ex.Message}");
                return false;
            }
        }
    }
}
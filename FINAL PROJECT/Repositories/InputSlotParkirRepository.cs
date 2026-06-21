using FINAL_PROJECT.Data;
using FINAL_PROJECT.Models;
using Npgsql;

namespace FINAL_PROJECT.Repositories
{
    public class InputSlotParkirRepository
    {
        public bool Insert(
            string kode,
            string status)
        {
            using var conn =
                DatabaseHelper.Instance.GetConnection();

            string sql = @"
                INSERT INTO slot_parkir
                (
                    kode_slot,
                    status_slot
                )
                VALUES
                (
                    @kode,
                    @status::status_slot_enum
                )";

            using var cmd =
                new NpgsqlCommand(sql, conn);

            cmd.Parameters.AddWithValue(
                "@kode", kode);

            cmd.Parameters.AddWithValue(
                "@status", status);

            return cmd.ExecuteNonQuery() > 0;
        }

        public bool Update(
            int id,
            string kode,
            string status)
        {
            using var conn =
                DatabaseHelper.Instance.GetConnection();

            string sql = @"
                UPDATE slot_parkir
                SET
                    kode_slot=@kode,
                    status_slot=@status::status_slot_enum
                WHERE id_slot=@id";

            using var cmd =
                new NpgsqlCommand(sql, conn);

            cmd.Parameters.AddWithValue(
                "@id", id);

            cmd.Parameters.AddWithValue(
                "@kode", kode);

            cmd.Parameters.AddWithValue(
                "@status", status);

            return cmd.ExecuteNonQuery() > 0;
        }
    }
}
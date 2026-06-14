using FINAL_PROJECT.Data;
using Npgsql;

namespace FINAL_PROJECT.Repositories
{
    public class VehicleEntryRepository
    {
        public string GetAvailableSlot(
            string area)
        {
            using var conn =
                DatabaseHelper.Instance.GetConnection();

            string sql = @"
                SELECT kode_slot
                FROM slot_parkir
                WHERE kode_slot LIKE @area
                AND status_slot='kosong'
                ORDER BY kode_slot
                LIMIT 1";

            using var cmd =
                new NpgsqlCommand(sql, conn);

            cmd.Parameters.AddWithValue(
                "@area",
                area + "-%");

            object result =
                cmd.ExecuteScalar();

            return result?.ToString();
        }



        public int GetOrCreateMerk(
    string namaMerk)
        {
            using var conn =
                DatabaseHelper.Instance.GetConnection();

            string cekSql = @"
        SELECT id_merk_kendaraan
        FROM merk_kendaraan
        WHERE LOWER(nama_merk)
              = LOWER(@merk)";

            using var cekCmd =
                new NpgsqlCommand(cekSql, conn);

            cekCmd.Parameters.AddWithValue(
                "@merk",
                namaMerk);

            object result =
                cekCmd.ExecuteScalar();

            if (result != null)
            {
                return Convert.ToInt32(result);
            }

            string insertSql = @"
        INSERT INTO merk_kendaraan
        (
            nama_merk,
            negara_asal
        )
        VALUES
        (
            @merk,
            'Belum Diketahui'
        )
        RETURNING id_merk_kendaraan";

            using var insertCmd =
                new NpgsqlCommand(insertSql, conn);

            insertCmd.Parameters.AddWithValue(
                "@merk",
                namaMerk);

            return Convert.ToInt32(
                insertCmd.ExecuteScalar());
        }





        public int GetOrCreateVehicle(
    string platNomor,
    string jenisKendaraan,
    int idMerk)
        {
            using var conn =
                DatabaseHelper.Instance.GetConnection();

            string cekSql = @"
        SELECT id_kendaraan
        FROM kendaraan
        WHERE LOWER(plat_nomor)
              = LOWER(@plat)";

            using var cekCmd =
                new NpgsqlCommand(cekSql, conn);

            cekCmd.Parameters.AddWithValue(
                "@plat",
                platNomor);

            object result =
                cekCmd.ExecuteScalar();

            if (result != null)
            {
                return Convert.ToInt32(result);
            }

            string insertSql = @"
        INSERT INTO kendaraan
        (
            plat_nomor,
            jenis_kendaraan,
            id_merk_kendaraan
        )
        VALUES
        (
            @plat,
            CAST(@jenis AS jenis_kendaraan_enum),
            @idMerk
        )
        RETURNING id_kendaraan";

            using var insertCmd =
                new NpgsqlCommand(insertSql, conn);

            insertCmd.Parameters.AddWithValue(
                "@plat",
                platNomor);

            insertCmd.Parameters.AddWithValue(
                "@jenis",
                jenisKendaraan);

            insertCmd.Parameters.AddWithValue(
                "@idMerk",
                idMerk);

            return Convert.ToInt32(
                insertCmd.ExecuteScalar());
        }




        public void CreateTransaction(
    string platNomor,
    string kodeSlot,
    int idPetugas)
        {
            using var conn =
                DatabaseHelper.Instance.GetConnection();

            string sql =
                "CALL tambah_transaksi(@plat,@slot,@petugas)";

            using var cmd =
                new NpgsqlCommand(sql, conn);

            cmd.Parameters.AddWithValue(
                "@plat",
                platNomor);

            cmd.Parameters.AddWithValue(
                "@slot",
                kodeSlot);

            cmd.Parameters.AddWithValue(
                "@petugas",
                idPetugas);

            cmd.ExecuteNonQuery();
        }
    }
}
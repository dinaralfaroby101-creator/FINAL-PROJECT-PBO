using FINAL_PROJECT.Data;
using FINAL_PROJECT.Models;
using Npgsql;

namespace FINAL_PROJECT.Repositories
{
    public class VehicleExitRepository
    {
        public VehicleExitInfo
            GetVehicleInfo(
                string platNomor)
        {
            using var conn =
                DatabaseHelper.Instance.GetConnection();

            string sql = @"
                SELECT *
                FROM v_monitoring_slot
                WHERE LOWER(plat_nomor)
                      = LOWER(@plat)
                LIMIT 1";

            using var cmd =
                new NpgsqlCommand(sql, conn);

            cmd.Parameters.AddWithValue(
                "@plat",
                platNomor);

            using var rd =
                cmd.ExecuteReader();

            if (rd.Read())
            {
                return new VehicleExitInfo
                {
                    IdTransaksi =
                        Convert.ToInt32(
                            rd["id_transaksi"]),

                    PlatNomor =
                        rd["plat_nomor"].ToString(),

                    JenisKendaraan =
                        rd["jenis_kendaraan"].ToString(),

                    KodeSlot =
                        rd["kode_slot"].ToString(),

                    NamaPetugas =
                        rd["nama_petugas"].ToString(),

                    WaktuMasuk =
                        Convert.ToDateTime(
                            rd["waktu_masuk"]),

                    DurasiMenit =
                        Convert.ToInt32(
                            rd["durasi_parkir_sekarang"])
                };
            }

            return null;
        }







        public decimal ExitVehicle(
            int idTransaksi,
            int idMetodePembayaran)
        {
            using var conn =
                DatabaseHelper.Instance.GetConnection();

            string sql = @"
                SELECT hitung_biaya_parkir(
                    @idTransaksi,
                    @idMetode
                )";

            using var cmd =
                new NpgsqlCommand(sql, conn);

            cmd.Parameters.AddWithValue(
                "@idTransaksi",
                idTransaksi);

            cmd.Parameters.AddWithValue(
                "@idMetode",
                idMetodePembayaran);

            return Convert.ToDecimal(
                cmd.ExecuteScalar());
        }
    }
}
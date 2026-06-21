using FINAL_PROJECT.Data;
using FINAL_PROJECT.Models;
using Npgsql;

namespace FINAL_PROJECT.Repositories
{
    public class HistoryRepository
    {
        public List<HistoryItem>
            GetHistoryData()
        {
            List<HistoryItem> list =
                new();

            using var conn =
                DatabaseHelper.Instance.GetConnection();

            string sql = @"
            SELECT *
            FROM v_riwayat_transaksi
            ORDER BY waktu_keluar DESC";

            using var cmd =
                new NpgsqlCommand(sql, conn);

            using var reader =
                cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(
                    new HistoryItem
                    {
                        IdTransaksi =
                            Convert.ToInt32(
                                reader["id_transaksi"]),

                        KodeSlot =
                            reader["kode_slot"]
                            .ToString(),

                        PlatNomor =
                            reader["plat_nomor"]
                            .ToString(),

                        JenisKendaraan =
                            reader["jenis_kendaraan"]
                            .ToString(),

                        WaktuMasuk =
                            Convert.ToDateTime(
                                reader["waktu_masuk"]),

                        WaktuKeluar =
                            Convert.ToDateTime(
                                reader["waktu_keluar"]),

                        DurasiParkir =
                            Convert.ToInt32(
                                reader["durasi_parkir"]),

                        TotalBiaya =
                            Convert.ToDecimal(
                                reader["total_biaya"]),

                        MetodePembayaran =
                            reader["metode_pembayaran"]
                            .ToString(),

                        Petugas =
                            reader["petugas"]
                            .ToString(),

                        StatusTransaksi =
                            reader["status_transaksi"]
                            .ToString()
                    });
            }

            return list;
        }
    }
}
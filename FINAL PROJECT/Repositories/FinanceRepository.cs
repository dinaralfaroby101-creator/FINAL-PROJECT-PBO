using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FINAL_PROJECT.Data;
using FINAL_PROJECT.Models;
using Npgsql;

namespace FINAL_PROJECT.Repositories
{
    public class FinanceReportRepository
    {

        public FinanceReportModel GetStatistic()
        {
            using var conn =
                DatabaseHelper.Instance.GetConnection();

            FinanceReportModel model =
                new FinanceReportModel();

            model.PendapatanHariIni =
                Convert.ToDecimal(
                    new NpgsqlCommand(
                        @"SELECT COALESCE(
                    SUM(total_biaya),0)
                  FROM transaksi
                  WHERE status_transaksi='selesai'
                  AND DATE(waktu_keluar)=CURRENT_DATE",
                        conn)
                    .ExecuteScalar());

            model.TotalTransaksi =
                Convert.ToInt32(
                    new NpgsqlCommand(
                        @"SELECT COUNT(*)
                  FROM transaksi
                  WHERE status_transaksi='selesai'
                  AND DATE(waktu_keluar)=CURRENT_DATE",
                        conn)
                    .ExecuteScalar());

            model.RataRataTransaksi =
                Convert.ToDecimal(
                    new NpgsqlCommand(
                        @"SELECT COALESCE(
                    AVG(total_biaya),0)
                  FROM transaksi
                  WHERE status_transaksi='selesai'
                  AND DATE(waktu_keluar)=CURRENT_DATE",
                        conn)
                    .ExecuteScalar());

            model.TotalKendaraan =
                model.TotalTransaksi;

            return model;

        }







        public List<PendapatanChartModel>
    GetChartPendapatan(
        int jumlahHari)
        {
            List<PendapatanChartModel>
                list = new();

            using var conn =
                DatabaseHelper.Instance.GetConnection();

            string sql = @"
        SELECT
            DATE(waktu_keluar) AS tanggal,
            COALESCE(
                SUM(total_biaya),0
            ) AS total
        FROM transaksi
        WHERE status_transaksi='selesai'
        AND waktu_keluar >= @tanggalAwal
        GROUP BY DATE(waktu_keluar)
        ORDER BY tanggal";

            using var cmd =
                new NpgsqlCommand(sql, conn);

            cmd.Parameters.AddWithValue(
                "@tanggalAwal",
                DateTime.Today.AddDays(
                    -jumlahHari));

            using var rd =
                cmd.ExecuteReader();

            while (rd.Read())
            {
                DateOnly tanggal =
    (DateOnly)rd["tanggal"];

                list.Add(
                    new PendapatanChartModel
                    {
                        Label =
                            tanggal.ToString("dd/MM"),

                        Total =
                            Convert.ToDecimal(
                                rd["total"])
                    });
            }

            return list;
        }






        public List<KendaraanChartModel>
    GetDataKendaraan(
        int jumlahHari)
        {
            List<KendaraanChartModel>
                list = new();

            using var conn =
                DatabaseHelper.Instance.GetConnection();

            string sql = @"
        SELECT
            k.jenis_kendaraan,
            COUNT(*) AS jumlah
        FROM transaksi t
        JOIN kendaraan k
            ON t.id_kendaraan =
               k.id_kendaraan
        WHERE t.status_transaksi='selesai'
        AND t.waktu_keluar >=
            @tanggalAwal
        GROUP BY k.jenis_kendaraan";

            using var cmd =
                new NpgsqlCommand(sql, conn);

            cmd.Parameters.AddWithValue(
                "@tanggalAwal",
                DateTime.Today.AddDays(
                    -jumlahHari));

            using var rd =
                cmd.ExecuteReader();

            while (rd.Read())
            {
                list.Add(
                    new KendaraanChartModel
                    {
                        JenisKendaraan =
                            rd["jenis_kendaraan"]
                            .ToString(),

                        Jumlah =
                            Convert.ToInt32(
                                rd["jumlah"])
                    });
            }

            return list;
        }






        public List<MetodePembayaranChartModel>
    GetMetodePembayaran(
        int jumlahHari)
        {
            List<MetodePembayaranChartModel>
                list = new();

            using var conn =
                DatabaseHelper.Instance.GetConnection();

            string sql = @"
        SELECT
            m.nama_metode,
            COALESCE(
                SUM(t.total_biaya),0
            ) AS total
        FROM metode_pembayaran m
        LEFT JOIN transaksi t
            ON t.id_metode_pembayaran =
               m.id_metode_pembayaran
        AND t.status_transaksi='selesai'
        AND t.waktu_keluar >=
            @tanggalAwal
        GROUP BY
            m.id_metode_pembayaran,
            m.nama_metode";

            using var cmd =
                new NpgsqlCommand(sql, conn);

            cmd.Parameters.AddWithValue(
                "@tanggalAwal",
                DateTime.Today.AddDays(
                    -jumlahHari));

            using var rd =
                cmd.ExecuteReader();

            while (rd.Read())
            {
                list.Add(
                    new MetodePembayaranChartModel
                    {
                        NamaMetode =
                            rd["nama_metode"]
                            .ToString(),

                        Total =
                            Convert.ToDecimal(
                                rd["total"])
                    });
            }

            return list;
        }




    }
   
    
}


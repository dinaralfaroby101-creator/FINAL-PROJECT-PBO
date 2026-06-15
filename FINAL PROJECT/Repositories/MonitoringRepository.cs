using FINAL_PROJECT.Data;
using FINAL_PROJECT.Models;
using Npgsql;

namespace FINAL_PROJECT.Repositories
{
public class MonitoringRepository
    {
        public List<MonitoringSlot>
            GetMonitoringSlots()
        {
            List<MonitoringSlot> data =
                new();

            using var conn =
                DatabaseHelper.Instance.GetConnection();

            string sql = @"
SELECT *
FROM v_monitoring_slot
ORDER BY kode_slot";

            using var cmd =
                new NpgsqlCommand(sql, conn);

            using var rd =
                cmd.ExecuteReader();

            while (rd.Read())
            {
                data.Add(
                    new MonitoringSlot
                    {
                        KodeSlot =
                            rd["kode_slot"].ToString(),

                        StatusSlot =
                            rd["status_slot"].ToString(),

                        JenisKendaraan =
                            rd["jenis_kendaraan"].ToString(),

                        PlatNomor =
                            rd["plat_nomor"].ToString(),

                        WaktuMasuk = Convert.ToDateTime
                            (rd["waktu_masuk"]),

                        NamaPetugas =
                            rd["nama_petugas"].ToString(),

                        
                    });
            }

            return data;
        }



        public MonitoringArea
    GetAreaStatistic(string area)
        {
            MonitoringArea data =
                new MonitoringArea();

            using var conn =
                DatabaseHelper.Instance.GetConnection();

            string sql = @"
SELECT
COUNT(*) total,
COUNT(*) FILTER
(WHERE status_slot='terisi')
terisi
FROM slot_parkir
WHERE kode_slot LIKE @area";

            using var cmd =
                new NpgsqlCommand(sql, conn);

            cmd.Parameters.AddWithValue(
                "@area",
                area + "-%");

            using var rd =
                cmd.ExecuteReader();

            if (rd.Read())
            {
                data.Area = area;

                data.TotalSlot =
                    Convert.ToInt32(
                        rd["total"]);

                data.SlotTerisi =
                    Convert.ToInt32(
                        rd["terisi"]);
            }

            return data;
        }

        
    }
}
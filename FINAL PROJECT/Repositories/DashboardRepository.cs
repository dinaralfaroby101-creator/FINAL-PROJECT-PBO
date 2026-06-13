using FINAL_PROJECT.Data;
using FINAL_PROJECT.Models;
using Npgsql;

namespace FINAL_PROJECT.Repositories
{
    public class DashboardRepository
    {
        public DashboardSummary GetDashboardSummary()
        {
            DashboardSummary data =
                new DashboardSummary();

            using var conn =
                DatabaseHelper.Instance.GetConnection();

            string sqlArea =
                "SELECT COUNT(DISTINCT LEFT(kode_slot,1)) FROM slot_parkir";

            using var cmdArea =
                new NpgsqlCommand(sqlArea, conn);

            data.TotalArea =
                Convert.ToInt32(
                    cmdArea.ExecuteScalar());

            string sqlTotal =
                "SELECT COUNT(*) FROM slot_parkir";

            using var cmdTotal =
                new NpgsqlCommand(sqlTotal, conn);

            data.TotalSlot =
                Convert.ToInt32(
                    cmdTotal.ExecuteScalar());

            string sqlTerisi =
                "SELECT COUNT(*) FROM slot_parkir WHERE status_slot='terisi'";

            using var cmdTerisi =
                new NpgsqlCommand(sqlTerisi, conn);

            data.SlotTerisi =
                Convert.ToInt32(
                    cmdTerisi.ExecuteScalar());

            string sqlKosong =
                "SELECT COUNT(*) FROM slot_parkir WHERE status_slot='kosong'";

            using var cmdKosong =
                new NpgsqlCommand(sqlKosong, conn);

            data.SlotKosong =
                Convert.ToInt32(
                    cmdKosong.ExecuteScalar());

            return data;
        }


        public AreaSummary GetAreaSummary(
    string area)
        {
            AreaSummary data =
                new AreaSummary();

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

            using var reader =
                cmd.ExecuteReader();

            if (reader.Read())
            {
                data.Area = area;

                data.TotalSlot =
                    Convert.ToInt32(
                        reader["total"]);

                data.Terisi =
                    Convert.ToInt32(
                        reader["terisi"]);

                data.Kosong =
                    data.TotalSlot -
                    data.Terisi;

                data.Persentase =
                    data.TotalSlot == 0
                    ? 0
                    : data.Terisi * 100
                      / data.TotalSlot;
            }

            return data;
        }
    }
}
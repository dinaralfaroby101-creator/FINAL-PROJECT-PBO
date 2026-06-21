using FINAL_PROJECT.Data;
using FINAL_PROJECT.Models;
using Npgsql;

namespace FINAL_PROJECT.Repositories
{
    public class ParkingDataRepository
    {
        public List<ParkingSlotModels>
            GetAll()
        {
            List<ParkingSlotModels> list =
                new();

            using var conn =
                DatabaseHelper.Instance.GetConnection();

            string sql =
                @"SELECT *
                  FROM slot_parkir
                  ORDER BY id_slot";

            using var cmd =
                new NpgsqlCommand(sql, conn);

            using var rd =
                cmd.ExecuteReader();

            while (rd.Read())
            {
                list.Add(
                    new ParkingSlotModels
                    {
                        IdSlot =
                            Convert.ToInt32(
                                rd["id_slot"]),

                        KodeSlot =
                            rd["kode_slot"]
                            .ToString(),

                        StatusSlot =
                            rd["status_slot"]
                            .ToString()
                    });
            }

            return list;
        }





        public ParkingStatisticModel
        GetStatistic()
        {
            ParkingStatisticModel data =
                new();

            using var conn =
                DatabaseHelper.Instance.GetConnection();

            data.TotalSlot =
                Convert.ToInt32(
                    new NpgsqlCommand(
                        "SELECT COUNT(*) FROM slot_parkir",
                        conn)
                    .ExecuteScalar());

            data.SlotKosong =
                Convert.ToInt32(
                    new NpgsqlCommand(
                        "SELECT COUNT(*) FROM slot_parkir WHERE status_slot='kosong'",
                        conn)
                    .ExecuteScalar());

            data.SlotTerisi =
                Convert.ToInt32(
                    new NpgsqlCommand(
                        "SELECT COUNT(*) FROM slot_parkir WHERE status_slot='terisi'",
                        conn)
                    .ExecuteScalar());

            data.SlotMaintenance =
                Convert.ToInt32(
                    new NpgsqlCommand(
                        "SELECT COUNT(*) FROM slot_parkir WHERE status_slot='maintenance'",
                        conn)
                    .ExecuteScalar());

            return data;
        }





        public List<ParkingSlotModels>
        Search(string keyword)
        {
            List<ParkingSlotModels> list =
                new();

            using var conn =
                DatabaseHelper.Instance.GetConnection();

            string sql = @"
            SELECT *
            FROM slot_parkir
            WHERE kode_slot
            ILIKE @search
            ORDER BY id_slot";

            using var cmd =
                new NpgsqlCommand(sql, conn);

            cmd.Parameters.AddWithValue(
                "@search",
                "%" + keyword + "%");

            using var rd =
                cmd.ExecuteReader();

            while (rd.Read())
            {
                list.Add(
                    new ParkingSlotModels
                    {
                        IdSlot =
                            Convert.ToInt32(
                                rd["id_slot"]),

                        KodeSlot =
                            rd["kode_slot"]
                            .ToString(),

                        StatusSlot =
                            rd["status_slot"]
                            .ToString()
                    });
            }

            return list;
        }

        public List<ParkingSlotModels>
        GetByArea(string area)
        {
            List<ParkingSlotModels> list =
                new();

            using var conn =
                DatabaseHelper.Instance.GetConnection();

            string sql = @"
            SELECT *
            FROM slot_parkir
            WHERE kode_slot LIKE @area
            ORDER BY id_slot";

            using var cmd =
                new NpgsqlCommand(sql, conn);

            cmd.Parameters.AddWithValue(
                "@area",
                area + "-%");

            using var rd =
                cmd.ExecuteReader();

            while (rd.Read())
            {
                list.Add(
                    new ParkingSlotModels
                    {
                        IdSlot =
                            Convert.ToInt32(
                                rd["id_slot"]),

                        KodeSlot =
                            rd["kode_slot"]
                            .ToString(),

                        StatusSlot =
                            rd["status_slot"]
                            .ToString()
                    });
            }

            return list;
        }
    }
}
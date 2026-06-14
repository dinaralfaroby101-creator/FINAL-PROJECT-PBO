using FINAL_PROJECT.Data;
using FINAL_PROJECT.Models;
using Npgsql;

namespace FINAL_PROJECT.Repositories
{
    public class VehicleRepository
    {
        public List<VehicleDataModel>
            GetAllVehicle()
        {
            List<VehicleDataModel> data =
                new();

            using var conn =
                DatabaseHelper.Instance.GetConnection();

            string sql = @"
                SELECT
                    k.id_kendaraan,
                    k.plat_nomor,
                    k.jenis_kendaraan,
                    mk.nama_merk,
                    mk.negara_asal
                FROM kendaraan k
                JOIN merk_kendaraan mk
                    ON k.id_merk_kendaraan =
                       mk.id_merk_kendaraan
                ORDER BY k.plat_nomor";

            using var cmd =
                new NpgsqlCommand(sql, conn);

            using var rd =
                cmd.ExecuteReader();

            while (rd.Read())
            {
                data.Add(
                    new VehicleDataModel
                    {
                        IdKendaraan =
                            Convert.ToInt32(
                                rd["id_kendaraan"]),

                        PlatNomor =
                            rd["plat_nomor"].ToString(),

                        JenisKendaraan =
                            rd["jenis_kendaraan"].ToString(),

                        NamaMerk =
                            rd["nama_merk"].ToString(),

                        NegaraAsal =
                            rd["negara_asal"].ToString()
                    });
            }

            return data;
        }




        public int GetTotalVehicle()
        {
            using var conn =
                DatabaseHelper.Instance.GetConnection();

            string sql =
                "SELECT COUNT(*) FROM kendaraan";

            using var cmd =
                new NpgsqlCommand(sql, conn);

            return Convert.ToInt32(
                cmd.ExecuteScalar());
        }




        public int GetTotalMotor()
        {
            using var conn =
                DatabaseHelper.Instance.GetConnection();

            string sql = @"
        SELECT COUNT(*)
        FROM kendaraan
        WHERE jenis_kendaraan='motor'";

            using var cmd =
                new NpgsqlCommand(sql, conn);

            return Convert.ToInt32(
                cmd.ExecuteScalar());
        }





        public int GetTotalMobil()
        {
            using var conn =
                DatabaseHelper.Instance.GetConnection();

            string sql = @"
        SELECT COUNT(*)
        FROM kendaraan
        WHERE jenis_kendaraan='mobil'";

            using var cmd =
                new NpgsqlCommand(sql, conn);

            return Convert.ToInt32(
                cmd.ExecuteScalar());
        }





        public int GetTotalBus()
        {
            using var conn =
                DatabaseHelper.Instance.GetConnection();

            string sql = @"
        SELECT COUNT(*)
        FROM kendaraan
        WHERE jenis_kendaraan='bus'";

            using var cmd =
                new NpgsqlCommand(sql, conn);

            return Convert.ToInt32(
                cmd.ExecuteScalar());
        }





        public List<VehicleDataModel>
    SearchVehicle(string keyword)
        {
            List<VehicleDataModel> data =
                new();

            using var conn =
                DatabaseHelper.Instance.GetConnection();

            string sql = @"
        SELECT
            k.id_kendaraan,
            k.plat_nomor,
            k.jenis_kendaraan,
            mk.nama_merk,
            mk.negara_asal
        FROM kendaraan k
        JOIN merk_kendaraan mk
            ON k.id_merk_kendaraan =
               mk.id_merk_kendaraan
        WHERE LOWER(k.plat_nomor)
              LIKE LOWER(@keyword)
        ORDER BY k.plat_nomor";

            using var cmd =
                new NpgsqlCommand(sql, conn);

            cmd.Parameters.AddWithValue(
                "@keyword",
                "%" + keyword + "%");

            using var rd =
                cmd.ExecuteReader();

            while (rd.Read())
            {
                data.Add(
                    new VehicleDataModel
                    {
                        IdKendaraan =
                            Convert.ToInt32(
                                rd["id_kendaraan"]),

                        PlatNomor =
                            rd["plat_nomor"].ToString(),

                        JenisKendaraan =
                            rd["jenis_kendaraan"].ToString(),

                        NamaMerk =
                            rd["nama_merk"].ToString(),

                        NegaraAsal =
                            rd["negara_asal"].ToString()
                    });
            }

            return data;
        }
    }
}
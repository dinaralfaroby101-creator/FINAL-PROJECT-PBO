using FINAL_PROJECT.Data;
using FINAL_PROJECT.Models;
using Npgsql;

namespace FINAL_PROJECT.Repositories
{
    public class PenitipanRepository
    {
        public List<PenitipanModel>
            GetAll()
        {
            List<PenitipanModel> list =
                new();

            using var conn =
                DatabaseHelper.Instance.GetConnection();

            string sql = @"
                SELECT
                    p.id_penitipan,
                    p.nama_pemilik,
                    b.nama_barang,
                    p.jumlah_barang,
                    p.waktu_masuk,
                    p.status_penitipan
                FROM penitipan p
                JOIN barang b
                ON p.id_barang = b.id_barang
                ORDER BY p.id_penitipan";

            using var cmd =
                new NpgsqlCommand(sql, conn);

            using var rd =
                cmd.ExecuteReader();

            while (rd.Read())
            {
                list.Add(
                    new PenitipanModel
                    {
                        IdPenitipan =
                            Convert.ToInt32(
                                rd["id_penitipan"]),

                        NamaPemilik =
                            rd["nama_pemilik"]
                            .ToString(),

                        NamaBarang =
                            rd["nama_barang"]
                            .ToString(),

                        JumlahBarang =
                            Convert.ToInt32(
                                rd["jumlah_barang"]),

                        WaktuMasuk =
                            Convert.ToDateTime(
                                rd["waktu_masuk"]),

                        StatusPenitipan =
                            rd["status_penitipan"]
                            .ToString()
                    });
            }

            return list;
        }



        public PenitipanStatisticModel
   GetStatistic()
        {
            using var conn =
                DatabaseHelper.Instance.GetConnection();

            return new PenitipanStatisticModel
            {
                TotalPenitipan =
                    Convert.ToInt32(
                        new NpgsqlCommand(
                            "SELECT COUNT(*) FROM penitipan",
                            conn)
                        .ExecuteScalar()),

                Dititipkan =
                    Convert.ToInt32(
                        new NpgsqlCommand(
                            @"SELECT COUNT(*)
                      FROM penitipan
                      WHERE status_penitipan='dititipkan'",
                            conn)
                        .ExecuteScalar()),

                Diambil =
                    Convert.ToInt32(
                        new NpgsqlCommand(
                            @"SELECT COUNT(*)
                      FROM penitipan
                      WHERE status_penitipan='diambil'",
                            conn)
                        .ExecuteScalar())
            };
        }






        public List<PenitipanModel>
    Search(string keyword)
        {
            List<PenitipanModel> list =
                new();

            using var conn =
                DatabaseHelper.Instance.GetConnection();

            string sql = @"
        SELECT
            p.id_penitipan,
            p.nama_pemilik,
            b.nama_barang,
            p.jumlah_barang,
            p.waktu_masuk,
            p.status_penitipan
        FROM penitipan p
        JOIN barang b
            ON p.id_barang=b.id_barang
        WHERE
            CAST(p.id_penitipan AS TEXT)
                ILIKE @search
            OR
            p.nama_pemilik
                ILIKE @search
            OR
            b.nama_barang
                ILIKE @search
        ORDER BY p.id_penitipan DESC";

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
                    new PenitipanModel
                    {
                        IdPenitipan =
                            Convert.ToInt32(
                                rd["id_penitipan"]),

                        NamaPemilik =
                            rd["nama_pemilik"]
                            .ToString(),

                        NamaBarang =
                            rd["nama_barang"]
                            .ToString(),

                        JumlahBarang =
                            Convert.ToInt32(
                                rd["jumlah_barang"]),

                        WaktuMasuk =
                            Convert.ToDateTime(
                                rd["waktu_masuk"]),

                        StatusPenitipan =
                            rd["status_penitipan"]
                            .ToString()
                    });
            }

            return list;
        }



        public List<PenitipanModel>
    GetHistory()
        {
            List<PenitipanModel> list =
                new();

            using var conn =
                DatabaseHelper.Instance.GetConnection();

            string sql = @"
        SELECT *
        FROM v_riwayat_penitipan
        ORDER BY id_penitipan DESC";

            using var cmd =
                new NpgsqlCommand(sql, conn);

            using var rd =
                cmd.ExecuteReader();

            while (rd.Read())
            {
                list.Add(
                    new PenitipanModel
                    {
                        IdPenitipan =
                            Convert.ToInt32(
                                rd["id_penitipan"]),

                        NamaPemilik =
                            rd["nama_pemilik"]
                            .ToString(),

                        NamaBarang =
                            rd["nama_barang"]
                            .ToString(),

                        JumlahBarang =
                            Convert.ToInt32(
                                rd["jumlah_barang"]),

                        WaktuMasuk =
                            Convert.ToDateTime(
                                rd["waktu_masuk"]),

                        StatusPenitipan =
                            rd["status_penitipan"]
                            .ToString()
                    });
            }

            return list;
        }








        public void TambahPenitipan(
    string namaBarang,
    string kategori,
    string pemilik,
    int jumlah)
        {
            using var conn =
                DatabaseHelper.Instance.GetConnection();

            string queryBarang = @"
        INSERT INTO barang
        (
            nama_barang,
            kategori_barang
        )
        VALUES
        (
            @nama_barang,
            @kategori_barang
        )
        RETURNING id_barang";

            using var cmdBarang =
                new NpgsqlCommand(
                    queryBarang,
                    conn);

            cmdBarang.Parameters.AddWithValue(
                "@nama_barang",
                namaBarang);

            cmdBarang.Parameters.AddWithValue(
                "@kategori_barang",
                kategori);

            int idBarang =
                Convert.ToInt32(
                    cmdBarang.ExecuteScalar());

            string queryPenitipan = @"
        INSERT INTO penitipan
        (
            id_admin,
            id_barang,
            nama_pemilik,
            jumlah_barang,
            waktu_masuk,
            status_penitipan
        )
        VALUES
        (
            1,
            @barang,
            @pemilik,
            @jumlah,
            NOW(),
            'dititipkan'
        )";

            using var cmd =
                new NpgsqlCommand(
                    queryPenitipan,
                    conn);

            cmd.Parameters.AddWithValue(
                "@barang",
                idBarang);

            cmd.Parameters.AddWithValue(
                "@pemilik",
                pemilik);

            cmd.Parameters.AddWithValue(
                "@jumlah",
                jumlah);

            cmd.ExecuteNonQuery();
        }



        public void AmbilBarang(
    int idPenitipan)
        {
            using var conn =
                DatabaseHelper.Instance.GetConnection();

            string sql = @"
        UPDATE penitipan
        SET
            status_penitipan='diambil',
            waktu_diambil=NOW()
        WHERE id_penitipan=@id";

            using var cmd =
                new NpgsqlCommand(sql, conn);

            cmd.Parameters.AddWithValue(
                "@id",
                idPenitipan);

            cmd.ExecuteNonQuery();
        }



        public void DeletePenitipan(
    int idPenitipan)
        {
            using var conn =
                DatabaseHelper.Instance.GetConnection();

            string sql = @"
        DELETE FROM penitipan
        WHERE id_penitipan=@id";

            using var cmd =
                new NpgsqlCommand(sql, conn);

            cmd.Parameters.AddWithValue(
                "@id",
                idPenitipan);

            cmd.ExecuteNonQuery();
        }
    }
}
// ============================================================
//  SPARK - Repositories.cs
//  Semua operasi CRUD ke PostgreSQL
//  Pola: Repository Pattern (1 class per tabel utama)
// ============================================================

using System;
using System.Collections.Generic;
using Npgsql;
using FINAL_PROJECT.Models;
using FINAL_PROJECT.Database;

namespace FINAL_PROJECT.Repositories
{
    // ============================================================
    //  USER REPOSITORY
    // ============================================================
    public class UserRepository
    {
        // ── LOGIN ────────────────────────────────────────────────
        /// <summary>
        /// Cari user berdasarkan username.
        /// Validasi password hash di layer service/form.
        /// </summary>
        public User? FindByUsername(string username)
        {
            using var conn = DatabaseHelper.Instance.GetConnection();
            using var cmd  = new NpgsqlCommand(
                "SELECT id_user, username, password_hash, nama_lengkap, role, is_active, created_at " +
                "FROM users WHERE username = @un AND is_active = TRUE", conn);
            cmd.Parameters.AddWithValue("un", username);

            using var reader = cmd.ExecuteReader();
            if (!reader.Read()) return null;

            return MapToUser(reader);
        }

        // ── CREATE ───────────────────────────────────────────────
        public int Insert(User user, string passwordHash)
        {
            using var conn = DatabaseHelper.Instance.GetConnection();
            using var cmd  = new NpgsqlCommand(
                "INSERT INTO users (username, password_hash, nama_lengkap, role) " +
                "VALUES (@un, @ph, @nl, @role::role_user) RETURNING id_user", conn);
            cmd.Parameters.AddWithValue("un",   user.Username);
            cmd.Parameters.AddWithValue("ph",   passwordHash);
            cmd.Parameters.AddWithValue("nl",   user.NamaLengkap);
            cmd.Parameters.AddWithValue("role", user.Role.ToString().ToLower());

            return (int)(cmd.ExecuteScalar() ?? 0);
        }

        // ── READ ALL ─────────────────────────────────────────────
        public List<User> GetAll()
        {
            var list = new List<User>();
            using var conn = DatabaseHelper.Instance.GetConnection();
            using var cmd  = new NpgsqlCommand(
                "SELECT id_user, username, password_hash, nama_lengkap, role, is_active, created_at " +
                "FROM users ORDER BY role, nama_lengkap", conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read()) list.Add(MapToUser(reader));
            return list;
        }

        // ── UPDATE ───────────────────────────────────────────────
        public bool Update(User user)
        {
            using var conn = DatabaseHelper.Instance.GetConnection();
            using var cmd  = new NpgsqlCommand(
                "UPDATE users SET nama_lengkap=@nl, role=@role::role_user, is_active=@ia " +
                "WHERE id_user=@id", conn);
            cmd.Parameters.AddWithValue("nl",   user.NamaLengkap);
            cmd.Parameters.AddWithValue("role", user.Role.ToString().ToLower());
            cmd.Parameters.AddWithValue("ia",   user.IsActive);
            cmd.Parameters.AddWithValue("id",   user.IdUser);
            return cmd.ExecuteNonQuery() > 0;
        }

        // ── DELETE (soft delete) ─────────────────────────────────
        public bool Deactivate(int idUser)
        {
            using var conn = DatabaseHelper.Instance.GetConnection();
            using var cmd  = new NpgsqlCommand(
                "UPDATE users SET is_active=FALSE WHERE id_user=@id", conn);
            cmd.Parameters.AddWithValue("id", idUser);
            return cmd.ExecuteNonQuery() > 0;
        }

        // ── MAPPING ──────────────────────────────────────────────
        private static User MapToUser(NpgsqlDataReader r)
        {
            var role = r.GetString(4).ToLower() switch
            {
                "admin"   => RoleUser.Admin,
                "manager" => RoleUser.Manager,
                _         => RoleUser.Petugas
            };

            User user = role switch
            {
                RoleUser.Admin   => new Admin(),
                RoleUser.Manager => new Manager(),
                _                => new Petugas()
            };

            user.IdUser       = r.GetInt32(0);
            user.Username     = r.GetString(1);
            user.PasswordHash = r.GetString(2);
            user.NamaLengkap  = r.GetString(3);
            user.IsActive     = r.GetBoolean(5);
            user.CreatedAt    = r.GetDateTime(6);
            return user;
        }
    }

    // ============================================================
    //  SLOT PARKIR REPOSITORY
    // ============================================================
    public class SlotParkirRepository
    {
        // ── READ: semua slot ─────────────────────────────────────
        public List<SlotParkir> GetAll()
        {
            var list = new List<SlotParkir>();
            using var conn = DatabaseHelper.Instance.GetConnection();
            using var cmd  = new NpgsqlCommand(
                "SELECT id_slot, kode_slot, jenis_kendaraan, status, lantai, created_at, updated_at " +
                "FROM slot_parkir ORDER BY kode_slot", conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read()) list.Add(MapSlot(reader));
            return list;
        }

        // ── READ: slot kosong by jenis ───────────────────────────
        public List<SlotParkir> GetKosong(JenisKendaraan jenis)
        {
            var list = new List<SlotParkir>();
            using var conn = DatabaseHelper.Instance.GetConnection();
            using var cmd  = new NpgsqlCommand(
                "SELECT id_slot, kode_slot, jenis_kendaraan, status, lantai, created_at, updated_at " +
                "FROM slot_parkir " +
                "WHERE jenis_kendaraan=@jk::jenis_kendaraan AND status='kosong' " +
                "ORDER BY kode_slot", conn);
            cmd.Parameters.AddWithValue("jk", jenis.ToString().ToLower());
            using var reader = cmd.ExecuteReader();
            while (reader.Read()) list.Add(MapSlot(reader));
            return list;
        }

        // ── READ: monitoring real-time (dari view) ───────────────
        public List<SlotParkir> GetMonitoring()
        {
            var list = new List<SlotParkir>();
            using var conn = DatabaseHelper.Instance.GetConnection();
            using var cmd  = new NpgsqlCommand(
                "SELECT id_slot, kode_slot, jenis_kendaraan, status, lantai, " +
                "       plat_nomor, waktu_masuk, nama_petugas " +
                "FROM v_monitoring_slot", conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var s = new SlotParkir
                {
                    IdSlot         = reader.GetInt32(0),
                    KodeSlot       = reader.GetString(1),
                    JenisKendaraan = ParseJenis(reader.GetString(2)),
                    Status         = ParseStatus(reader.GetString(3)),
                    Lantai         = reader.GetString(4),
                    PlatNomorAktif = reader.IsDBNull(5) ? null : reader.GetString(5),
                    WaktuMasukAktif= reader.IsDBNull(6) ? null : reader.GetDateTime(6),
                    NamaPetugas    = reader.IsDBNull(7) ? null : reader.GetString(7)
                };
                list.Add(s);
            }
            return list;
        }

        // ── CREATE ───────────────────────────────────────────────
        public int Insert(SlotParkir slot)
        {
            using var conn = DatabaseHelper.Instance.GetConnection();
            using var cmd  = new NpgsqlCommand(
                "INSERT INTO slot_parkir (kode_slot, jenis_kendaraan, lantai) " +
                "VALUES (@ks, @jk::jenis_kendaraan, @lt) RETURNING id_slot", conn);
            cmd.Parameters.AddWithValue("ks", slot.KodeSlot);
            cmd.Parameters.AddWithValue("jk", slot.JenisKendaraan.ToString().ToLower());
            cmd.Parameters.AddWithValue("lt", slot.Lantai);
            return (int)(cmd.ExecuteScalar() ?? 0);
        }

        // ── UPDATE ───────────────────────────────────────────────
        public bool UpdateStatus(int idSlot, StatusSlot status)
        {
            using var conn = DatabaseHelper.Instance.GetConnection();
            using var cmd  = new NpgsqlCommand(
                "UPDATE slot_parkir SET status=@st::status_slot WHERE id_slot=@id", conn);
            cmd.Parameters.AddWithValue("st", status.ToString().ToLower());
            cmd.Parameters.AddWithValue("id", idSlot);
            return cmd.ExecuteNonQuery() > 0;
        }

        // ── DELETE ───────────────────────────────────────────────
        public bool Delete(int idSlot)
        {
            using var conn = DatabaseHelper.Instance.GetConnection();
            using var cmd  = new NpgsqlCommand(
                "DELETE FROM slot_parkir WHERE id_slot=@id AND status='kosong'", conn);
            cmd.Parameters.AddWithValue("id", idSlot);
            return cmd.ExecuteNonQuery() > 0;
        }

        private static SlotParkir MapSlot(NpgsqlDataReader r) => new SlotParkir
        {
            IdSlot         = r.GetInt32(0),
            KodeSlot       = r.GetString(1),
            JenisKendaraan = ParseJenis(r.GetString(2)),
            Status         = ParseStatus(r.GetString(3)),
            Lantai         = r.GetString(4),
            CreatedAt      = r.GetDateTime(5),
            UpdatedAt      = r.GetDateTime(6)
        };

        private static JenisKendaraan ParseJenis(string s) =>
            s == "mobil" ? JenisKendaraan.Mobil : JenisKendaraan.Motor;

        private static StatusSlot ParseStatus(string s) => s switch
        {
            "terisi"      => StatusSlot.Terisi,
            "maintenance" => StatusSlot.Maintenance,
            _             => StatusSlot.Kosong
        };
    }

    // ============================================================
    //  TRANSAKSI REPOSITORY
    // ============================================================
    public class TransaksiRepository
    {
        // ── CREATE: kendaraan masuk ──────────────────────────────
        public int KendaraanMasuk(int idSlot, int idPetugas, string platNomor, JenisKendaraan jenis)
        {
            using var conn = DatabaseHelper.Instance.GetConnection();
            using var tx   = conn.BeginTransaction();
            try
            {
                // Insert transaksi
                using var cmdTx = new NpgsqlCommand(
                    "INSERT INTO transaksi (id_slot, id_petugas, plat_nomor, jenis_kendaraan) " +
                    "VALUES (@sl, @pt, @pn, @jk::jenis_kendaraan) RETURNING id_transaksi", conn, tx);
                cmdTx.Parameters.AddWithValue("sl", idSlot);
                cmdTx.Parameters.AddWithValue("pt", idPetugas);
                cmdTx.Parameters.AddWithValue("pn", platNomor.ToUpper());
                cmdTx.Parameters.AddWithValue("jk", jenis.ToString().ToLower());
                int idTransaksi = (int)(cmdTx.ExecuteScalar() ?? 0);

                // Update slot jadi terisi
                using var cmdSlot = new NpgsqlCommand(
                    "UPDATE slot_parkir SET status='terisi' WHERE id_slot=@id", conn, tx);
                cmdSlot.Parameters.AddWithValue("id", idSlot);
                cmdSlot.ExecuteNonQuery();

                tx.Commit();
                return idTransaksi;
            }
            catch
            {
                tx.Rollback();
                throw;
            }
        }

        // ── UPDATE: kendaraan keluar (pakai function PostgreSQL) ─
        public decimal KendaraanKeluar(int idTransaksi)
        {
            using var conn = DatabaseHelper.Instance.GetConnection();
            using var cmd  = new NpgsqlCommand(
                "SELECT hitung_biaya_parkir(@id)", conn);
            cmd.Parameters.AddWithValue("id", idTransaksi);
            return (decimal)(cmd.ExecuteScalar() ?? 0m);
        }

        // ── READ: transaksi aktif (semua) ────────────────────────
        public List<Transaksi> GetAktif()
        {
            var list = new List<Transaksi>();
            using var conn = DatabaseHelper.Instance.GetConnection();
            using var cmd  = new NpgsqlCommand(
                "SELECT t.id_transaksi, t.id_slot, t.id_petugas, t.plat_nomor, " +
                "       t.jenis_kendaraan, t.waktu_masuk, t.status, " +
                "       s.kode_slot, u.nama_lengkap " +
                "FROM transaksi t " +
                "JOIN slot_parkir s ON s.id_slot = t.id_slot " +
                "JOIN users u       ON u.id_user  = t.id_petugas " +
                "WHERE t.status = 'aktif' " +
                "ORDER BY t.waktu_masuk DESC", conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Transaksi
                {
                    IdTransaksi    = reader.GetInt32(0),
                    IdSlot         = reader.GetInt32(1),
                    IdPetugas      = reader.GetInt32(2),
                    PlatNomor      = reader.GetString(3),
                    JenisKendaraan = reader.GetString(4) == "mobil"
                                         ? JenisKendaraan.Mobil : JenisKendaraan.Motor,
                    WaktuMasuk     = reader.GetDateTime(5),
                    Status         = StatusTransaksi.Aktif,
                    KodeSlot       = reader.GetString(7),
                    NamaPetugas    = reader.GetString(8)
                });
            }
            return list;
        }

        // ── READ: riwayat by rentang tanggal (untuk manager) ─────
        public List<Transaksi> GetByPeriode(DateTime dari, DateTime sampai)
        {
            var list = new List<Transaksi>();
            using var conn = DatabaseHelper.Instance.GetConnection();
            using var cmd  = new NpgsqlCommand(
                "SELECT t.id_transaksi, t.plat_nomor, t.jenis_kendaraan, " +
                "       t.waktu_masuk, t.waktu_keluar, t.durasi_menit, t.total_biaya, " +
                "       t.status, s.kode_slot, u.nama_lengkap " +
                "FROM transaksi t " +
                "JOIN slot_parkir s ON s.id_slot  = t.id_slot " +
                "JOIN users u       ON u.id_user   = t.id_petugas " +
                "WHERE t.waktu_masuk BETWEEN @dari AND @sampai " +
                "ORDER BY t.waktu_masuk DESC", conn);
            cmd.Parameters.AddWithValue("dari",   dari);
            cmd.Parameters.AddWithValue("sampai", sampai.Date.AddDays(1));
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Transaksi
                {
                    IdTransaksi    = reader.GetInt32(0),
                    PlatNomor      = reader.GetString(1),
                    JenisKendaraan = reader.GetString(2) == "mobil"
                                         ? JenisKendaraan.Mobil : JenisKendaraan.Motor,
                    WaktuMasuk     = reader.GetDateTime(3),
                    WaktuKeluar    = reader.IsDBNull(4) ? null : reader.GetDateTime(4),
                    DurasiMenit    = reader.IsDBNull(5) ? null : reader.GetInt32(5),
                    TotalBiaya     = reader.IsDBNull(6) ? null : reader.GetDecimal(6),
                    KodeSlot       = reader.GetString(8),
                    NamaPetugas    = reader.GetString(9)
                });
            }
            return list;
        }
    }

    // ============================================================
    //  TARIF REPOSITORY
    // ============================================================
    public class TarifRepository
    {
        public List<Tarif> GetAll()
        {
            var list = new List<Tarif>();
            using var conn = DatabaseHelper.Instance.GetConnection();
            using var cmd  = new NpgsqlCommand(
                "SELECT id_tarif, jenis_kendaraan, tarif_per_jam, tarif_minimum, updated_at " +
                "FROM tarif ORDER BY jenis_kendaraan", conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Tarif
                {
                    IdTarif        = reader.GetInt32(0),
                    JenisKendaraan = reader.GetString(1) == "mobil"
                                         ? JenisKendaraan.Mobil : JenisKendaraan.Motor,
                    TarifPerJam    = reader.GetDecimal(2),
                    TarifMinimum   = reader.GetDecimal(3),
                    UpdatedAt      = reader.GetDateTime(4)
                });
            }
            return list;
        }

        public Tarif? GetByJenis(JenisKendaraan jenis)
        {
            using var conn = DatabaseHelper.Instance.GetConnection();
            using var cmd  = new NpgsqlCommand(
                "SELECT id_tarif, jenis_kendaraan, tarif_per_jam, tarif_minimum, updated_at " +
                "FROM tarif WHERE jenis_kendaraan=@jk::jenis_kendaraan", conn);
            cmd.Parameters.AddWithValue("jk", jenis.ToString().ToLower());
            using var reader = cmd.ExecuteReader();
            if (!reader.Read()) return null;
            return new Tarif
            {
                IdTarif        = reader.GetInt32(0),
                JenisKendaraan = jenis,
                TarifPerJam    = reader.GetDecimal(2),
                TarifMinimum   = reader.GetDecimal(3),
                UpdatedAt      = reader.GetDateTime(4)
            };
        }

        // Hanya manager yang boleh update tarif (validasi di form/service)
        public bool Update(Tarif tarif, int idManager)
        {
            using var conn = DatabaseHelper.Instance.GetConnection();
            using var cmd  = new NpgsqlCommand(
                "UPDATE tarif SET tarif_per_jam=@pj, tarif_minimum=@min, " +
                "updated_by=@mgr, updated_at=NOW() " +
                "WHERE id_tarif=@id", conn);
            cmd.Parameters.AddWithValue("pj",  tarif.TarifPerJam);
            cmd.Parameters.AddWithValue("min", tarif.TarifMinimum);
            cmd.Parameters.AddWithValue("mgr", idManager);
            cmd.Parameters.AddWithValue("id",  tarif.IdTarif);
            return cmd.ExecuteNonQuery() > 0;
        }
    }

    // ============================================================
    //  LAPORAN REPOSITORY (Manager)
    // ============================================================
    public class LaporanRepository
    {
        // Generate laporan & simpan ke tabel laporan
        public int Generate(DateTime dari, DateTime sampai, int idManager)
        {
            using var conn = DatabaseHelper.Instance.GetConnection();

            // Ambil data agregasi dari transaksi
            using var cmdAgg = new NpgsqlCommand(
                "SELECT COUNT(*), " +
                "       COUNT(*) FILTER (WHERE jenis_kendaraan='motor'), " +
                "       COUNT(*) FILTER (WHERE jenis_kendaraan='mobil'), " +
                "       COALESCE(SUM(total_biaya),0) " +
                "FROM transaksi " +
                "WHERE status='selesai' AND DATE(waktu_masuk) BETWEEN @dari AND @sampai", conn);
            cmdAgg.Parameters.AddWithValue("dari",   dari.Date);
            cmdAgg.Parameters.AddWithValue("sampai", sampai.Date);

            using var r = cmdAgg.ExecuteReader();
            r.Read();
            int     total    = r.GetInt32(0);
            int     motor    = r.GetInt32(1);
            int     mobil    = r.GetInt32(2);
            decimal revenue  = r.GetDecimal(3);
            r.Close();

            string judul = $"Laporan {dari:dd/MM/yyyy} - {sampai:dd/MM/yyyy}";

            using var cmdIns = new NpgsqlCommand(
                "INSERT INTO laporan (judul, periode_dari, periode_sampai, " +
                "    total_kendaraan, total_motor, total_mobil, total_revenue, dibuat_oleh) " +
                "VALUES (@jdl, @dr, @sp, @tk, @tm, @tb, @rev, @mgr) RETURNING id_laporan", conn);
            cmdIns.Parameters.AddWithValue("jdl", judul);
            cmdIns.Parameters.AddWithValue("dr",  dari.Date);
            cmdIns.Parameters.AddWithValue("sp",  sampai.Date);
            cmdIns.Parameters.AddWithValue("tk",  total);
            cmdIns.Parameters.AddWithValue("tm",  motor);
            cmdIns.Parameters.AddWithValue("tb",  mobil);
            cmdIns.Parameters.AddWithValue("rev", revenue);
            cmdIns.Parameters.AddWithValue("mgr", idManager);

            return (int)(cmdIns.ExecuteScalar() ?? 0);
        }

        public List<Laporan> GetAll()
        {
            var list = new List<Laporan>();
            using var conn = DatabaseHelper.Instance.GetConnection();
            using var cmd  = new NpgsqlCommand(
                "SELECT l.id_laporan, l.judul, l.periode_dari, l.periode_sampai, " +
                "       l.total_kendaraan, l.total_motor, l.total_mobil, l.total_revenue, " +
                "       l.created_at, u.nama_lengkap " +
                "FROM laporan l " +
                "LEFT JOIN users u ON u.id_user = l.dibuat_oleh " +
                "ORDER BY l.created_at DESC", conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Laporan
                {
                    IdLaporan      = reader.GetInt32(0),
                    Judul          = reader.GetString(1),
                    PeriodeDari    = reader.GetDateTime(2),
                    PeriodeSampai  = reader.GetDateTime(3),
                    TotalKendaraan = reader.GetInt32(4),
                    TotalMotor     = reader.GetInt32(5),
                    TotalMobil     = reader.GetInt32(6),
                    TotalRevenue   = reader.GetDecimal(7),
                    CreatedAt      = reader.GetDateTime(8),
                    NamaManager    = reader.IsDBNull(9) ? "-" : reader.GetString(9)
                });
            }
            return list;
        }
    }
}

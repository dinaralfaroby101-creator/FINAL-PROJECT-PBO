// ============================================================
//  SPARK - Models.cs
//  Class OOP yang merepresentasikan tabel di database
// ============================================================

using System;

namespace FINAL_PROJECT.Models
{
    // ── ENUM ─────────────────────────────────────────────────
    public enum JenisKendaraan { Motor, Mobil }
    public enum RoleUser       { Admin, Manager, Petugas }
    public enum StatusSlot     { Kosong, Terisi, Maintenance }
    public enum StatusTransaksi{ Aktif, Selesai, Dibatalkan }

    // ============================================================
    //  BASE CLASS - User (abstraksi OOP)
    // ============================================================
    public abstract class User
    {
        public int    IdUser      { get; set; }
        public string Username    { get; set; } = string.Empty;
        public string PasswordHash{ get; set; } = string.Empty;
        public string NamaLengkap { get; set; } = string.Empty;
        public RoleUser Role      { get; protected set; }
        public bool   IsActive    { get; set; } = true;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Polymorphism: setiap role punya dashboard berbeda
        public abstract string GetDashboardTitle();

        public override string ToString() => $"[{Role}] {NamaLengkap} ({Username})";
    }

    // ============================================================
    //  ADMIN - kelola sistem & user
    // ============================================================
    public class Admin : User
    {
        public Admin() { Role = RoleUser.Admin; }

        public override string GetDashboardTitle() => "Dashboard Administrator";
    }

    // ============================================================
    //  MANAGER - analitik & revenue
    // ============================================================
    public class Manager : User
    {
        public Manager() { Role = RoleUser.Manager; }

        public override string GetDashboardTitle() => "Dashboard Manager - Revenue & Analitik";
    }

    // ============================================================
    //  PETUGAS - operasional lapangan
    // ============================================================
    public class Petugas : User
    {
        public int?      IdShiftAktif { get; set; }
        public DateTime? WaktuMasukShift { get; set; }

        public Petugas() { Role = RoleUser.Petugas; }

        public override string GetDashboardTitle() => "Dashboard Petugas - Operasional Parkir";

        public bool SedangBertugas => IdShiftAktif.HasValue;
    }

    // ============================================================
    //  SLOT PARKIR
    // ============================================================
    public class SlotParkir
    {
        public int             IdSlot          { get; set; }
        public string          KodeSlot        { get; set; } = string.Empty;
        public JenisKendaraan  JenisKendaraan  { get; set; }
        public StatusSlot      Status          { get; set; } = StatusSlot.Kosong;
        public string          Lantai          { get; set; } = "1";
        public DateTime        CreatedAt       { get; set; }
        public DateTime        UpdatedAt       { get; set; }

        // Data dari view monitoring (opsional, isi saat join)
        public string?   PlatNomorAktif  { get; set; }
        public DateTime? WaktuMasukAktif { get; set; }
        public string?   NamaPetugas     { get; set; }

        public bool IsKosong => Status == StatusSlot.Kosong;

        public override string ToString() => $"{KodeSlot} [{JenisKendaraan}] - {Status}";
    }

    // ============================================================
    //  TARIF
    // ============================================================
    public class Tarif
    {
        public int            IdTarif        { get; set; }
        public JenisKendaraan JenisKendaraan { get; set; }
        public decimal        TarifPerJam    { get; set; }
        public decimal        TarifMinimum   { get; set; }
        public int?           UpdatedBy      { get; set; }
        public DateTime       UpdatedAt      { get; set; }

        /// <summary>Hitung estimasi biaya dari durasi dalam menit.</summary>
        public decimal HitungBiaya(int durasiMenit)
        {
            double jam   = Math.Ceiling(durasiMenit / 60.0);
            decimal biaya = (decimal)jam * TarifPerJam;
            return Math.Max(biaya, TarifMinimum);
        }
    }

    // ============================================================
    //  TRANSAKSI
    // ============================================================
    public class Transaksi
    {
        public int             IdTransaksi    { get; set; }
        public int             IdSlot         { get; set; }
        public int             IdPetugas      { get; set; }
        public string          PlatNomor      { get; set; } = string.Empty;
        public JenisKendaraan  JenisKendaraan { get; set; }
        public DateTime        WaktuMasuk     { get; set; }
        public DateTime?       WaktuKeluar    { get; set; }
        public int?            DurasiMenit    { get; set; }
        public decimal?        TotalBiaya     { get; set; }
        public StatusTransaksi Status         { get; set; } = StatusTransaksi.Aktif;
        public string?         Catatan        { get; set; }
        public DateTime        CreatedAt      { get; set; }

        // Join data (isi dari query)
        public string? KodeSlot      { get; set; }
        public string? NamaPetugas   { get; set; }

        public bool MasihAktif => Status == StatusTransaksi.Aktif;

        /// <summary>Hitung durasi dari waktu masuk sampai sekarang (untuk yang masih aktif).</summary>
        public int DurasiSekarangMenit =>
            (int)(DateTime.Now - WaktuMasuk).TotalMinutes;

        public override string ToString() =>
            $"[{IdTransaksi}] {PlatNomor} - {JenisKendaraan} | Masuk: {WaktuMasuk:dd/MM/yyyy HH:mm}";
    }

    // ============================================================
    //  SHIFT LOG
    // ============================================================
    public class ShiftLog
    {
        public int      IdShift          { get; set; }
        public int      IdPetugas        { get; set; }
        public DateTime WaktuMasuk       { get; set; }
        public DateTime?WaktuKeluar      { get; set; }
        public int      TotalTransaksi   { get; set; }
        public decimal  TotalPendapatan  { get; set; }

        // Join
        public string? NamaPetugas { get; set; }

        public bool MasihAktif => !WaktuKeluar.HasValue;
    }

    // ============================================================
    //  LAPORAN
    // ============================================================
    public class Laporan
    {
        public int      IdLaporan       { get; set; }
        public string   Judul           { get; set; } = string.Empty;
        public DateTime PeriodeDari     { get; set; }
        public DateTime PeriodeSampai   { get; set; }
        public int      TotalKendaraan  { get; set; }
        public int      TotalMotor      { get; set; }
        public int      TotalMobil      { get; set; }
        public decimal  TotalRevenue    { get; set; }
        public int?     DibuatOleh      { get; set; }
        public DateTime CreatedAt       { get; set; }

        // Join
        public string? NamaManager { get; set; }
    }
}

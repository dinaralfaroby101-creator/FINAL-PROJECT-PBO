using FINAL_PROJECT.Data;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace FINAL_PROJECT.forms
{

    public partial class FinanceReport : Form
    {
        public FinanceReport()
        {
            InitializeComponent();
        }

        private int GetJumlahHari(string filter)
        {
            switch (filter)
            {
                case "7 Hari":
                    return 7;

                case "1 Bulan":
                    return 30;

                case "3 Bulan":
                    return 90;

                default:
                    return 7;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FinanceReport finance = new FinanceReport();
            finance.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Hide();
        }

        private void btnParkingData_Click(object sender, EventArgs e)
        {
            ParkingData park = new ParkingData();
            park.Show();
            this.Hide();
        }

        private void btnUserData_Click(object sender, EventArgs e)
        {
            UserData user = new UserData();
            user.Show();
            this.Hide();
        }

        private void btnBagStorage_Click(object sender, EventArgs e)
        {
            BagStorage bag = new BagStorage();
            bag.Show();
            this.Hide();
        }

        private void btnMonitoring_Click(object sender, EventArgs e)
        {
            Monitoring monitor = new Monitoring();
            monitor.Show();
            this.Hide();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.Show();
            this.Hide();
        }

        private void FinanceReport_Load(object sender, EventArgs e)
        {
            // Filter Diagram Batang
            cboFilterDBatang.Items.Add("7 Hari");
            cboFilterDBatang.Items.Add("1 Bulan");
            cboFilterDBatang.Items.Add("3 Bulan");

            // Filter Metode Pembayaran
            cboFilterMetode.Items.Add("7 Hari");
            cboFilterMetode.Items.Add("1 Bulan");
            cboFilterMetode.Items.Add("3 Bulan");

            // Filter Kendaraan
            cboFilterKendaraan.Items.Add("7 Hari");
            cboFilterKendaraan.Items.Add("1 Bulan");
            cboFilterKendaraan.Items.Add("3 Bulan");

            // Default = 7 Hari
            cboFilterDBatang.SelectedIndex = 0;
            cboFilterMetode.SelectedIndex = 0;
            cboFilterKendaraan.SelectedIndex = 0;

            // Card Statistik
            LoadPendapatanHariIni();
            LoadTotalTransaksi();
            LoadRataRataTransaksi();
            LoadTotalKendaraan();

            // Chart Pendapatan
            BuatChartPendapatan(7);

            // Chart Metode Pembayaran
            LoadMetodePembayaran(7);
            BuatChartMetode(7);

            // Chart Kendaraan
            LoadDataKendaraan(7);
            BuatChartKendaraan(7);
        }

        private void panelConten_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelPendapatan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void polarChart1_Load(object sender, EventArgs e)
        {

        }

        private void BuatChartPendapatan(int jumlahHari)
        {
            using var conn =
                DatabaseHelper.Instance.GetConnection();

            string sql = @"
SELECT
    DATE(waktu_keluar) AS tanggal,
    SUM(total_biaya) AS pendapatan
FROM transaksi
WHERE status_transaksi='selesai'
AND waktu_keluar >= CURRENT_DATE - @hari
GROUP BY DATE(waktu_keluar)
ORDER BY tanggal";

            using var cmd =
                new NpgsqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@hari", jumlahHari);

            List<double> values = new();
            List<string> labels = new();

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                values.Add(
                    Convert.ToDouble(
                        reader["pendapatan"]));

                DateOnly tanggal =
    (DateOnly)reader["tanggal"];

                labels.Add(
                    tanggal.ToString("dd/MM"));
            }

            var chart = new CartesianChart
            {
                Dock = DockStyle.Fill,

                Series = new ISeries[]
                {
            new ColumnSeries<double>
            {
                Values = values
            }
                },

                XAxes = new[]
                {
            new Axis
            {
                Labels = labels
            }
        }
            };

            panelChartPendapatan.Controls.Clear();
            panelChartPendapatan.Controls.Add(chart);
        }


        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BuatChartMetode(int jumlahHari)
        {
            try
            {
                using var conn =
                    DatabaseHelper.Instance.GetConnection();

                DateTime tanggalAwal =
                    DateTime.Today.AddDays(-jumlahHari);

                string query = @"
SELECT
    m.nama_metode,
    COALESCE(SUM(t.total_biaya),0) AS total
FROM metode_pembayaran m
LEFT JOIN transaksi t
    ON t.id_metode_pembayaran = m.id_metode_pembayaran
    AND t.status_transaksi = 'selesai'
    AND t.waktu_keluar >= @tanggalAwal
GROUP BY m.id_metode_pembayaran, m.nama_metode
ORDER BY m.id_metode_pembayaran";

                using var cmd =
                    new NpgsqlCommand(query, conn);

                cmd.Parameters.AddWithValue(
                    "@tanggalAwal",
                    tanggalAwal);

                using var rd =
                    cmd.ExecuteReader();

                List<ISeries> series =
                    new List<ISeries>();

                while (rd.Read())
                {
                    string namaMetode =
                        rd["nama_metode"].ToString();

                    double total =
                        Convert.ToDouble(rd["total"]);

                    series.Add(
                        new PieSeries<double>
                        {
                            Name = namaMetode,
                            Values = new double[]
                            {
                        total
                            }
                        });
                }

                var pie = new PieChart
                {
                    Dock = DockStyle.Fill,
                    Series = series.ToArray()
                };

                panelChartMetode.Controls.Clear();
                panelChartMetode.Controls.Add(pie);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void LoadMetodePembayaran(int jumlahHari)
        {
            using var conn = DatabaseHelper.Instance.GetConnection();

            DateTime tanggalAwal =
                DateTime.Today.AddDays(-jumlahHari);

            string sql = @"
    SELECT
        m.nama_metode,
        COALESCE(SUM(t.total_biaya),0) total
    FROM metode_pembayaran m
    LEFT JOIN transaksi t
        ON t.id_metode_pembayaran = m.id_metode_pembayaran
        AND t.status_transaksi='selesai'
        AND t.waktu_keluar >= @tanggalAwal
    GROUP BY m.nama_metode";

            using var cmd =
                new NpgsqlCommand(sql, conn);

            cmd.Parameters.AddWithValue(
                "@tanggalAwal",
                tanggalAwal);

            using var reader = cmd.ExecuteReader();

            decimal totalKeseluruhan = 0;

            while (reader.Read())
            {
                string metode = reader["nama_metode"].ToString();
                decimal total = Convert.ToDecimal(reader["total"]);

                totalKeseluruhan += total;

                switch (metode)
                {
                    case "QRIS":
                        lblJumlahQris.Text = total.ToString("N0");
                        break;

                    case "Tunai":
                        lblJumlahDebit.Text = total.ToString("N0");
                        break;

                    case "E-Wallet":
                        lblJumlahEwallet.Text = total.ToString("N0");
                        break;
                }
            }

            lblTotal.Text = totalKeseluruhan.ToString("N0");
        }

        private void BuatChartKendaraan(int jumlahHari)
        {
            double motor = 0;
            double mobil = 0;
            double bus = 0;

            using var conn =
                DatabaseHelper.Instance.GetConnection();

            DateTime tanggalAwal =
                DateTime.Today.AddDays(-jumlahHari);

            string sql = @"
    SELECT
        k.jenis_kendaraan,
        COUNT(*) AS jumlah
    FROM transaksi t
    JOIN kendaraan k
        ON t.id_kendaraan = k.id_kendaraan
    WHERE t.status_transaksi='selesai'
    AND t.waktu_keluar >= @tanggalAwal
    GROUP BY k.jenis_kendaraan";

            using var cmd =
                new NpgsqlCommand(sql, conn);

            cmd.Parameters.AddWithValue(
                "@tanggalAwal",
                tanggalAwal);

            using var reader =
                cmd.ExecuteReader();

            while (reader.Read())
            {
                string jenis =
                    reader["jenis_kendaraan"].ToString();

                double jumlah =
                    Convert.ToDouble(
                        reader["jumlah"]);

                if (jenis == "motor")
                    motor = jumlah;

                else if (jenis == "mobil")
                    mobil = jumlah;

                else if (jenis == "bus")
                    bus = jumlah;
            }

            var pie = new PieChart
            {
                Dock = DockStyle.Fill,

                Series = new ISeries[]
                {
            new PieSeries<double>
            {
                Name = "Motor",
                Values = new[] { motor }
            },

            new PieSeries<double>
            {
                Name = "Mobil",
                Values = new[] { mobil }
            },

            new PieSeries<double>
            {
                Name = "Bus",
                Values = new[] { bus }
            }
                }
            };

            panelChartKendaraan.Controls.Clear();
            panelChartKendaraan.Controls.Add(pie);
        }


        private void LoadPendapatanHariIni()
        {
            using var conn = DatabaseHelper.Instance.GetConnection();

            string sql = @"
    SELECT COALESCE(SUM(total_biaya),0)
    FROM transaksi
    WHERE status_transaksi='selesai'
    AND DATE(waktu_keluar)=CURRENT_DATE";

            using var cmd = new NpgsqlCommand(sql, conn);

            decimal total = Convert.ToDecimal(cmd.ExecuteScalar());

            lblPendapatanHarian.Text =
                total.ToString("N0");
        }

        private void LoadTotalTransaksi()
        {
            using var conn = DatabaseHelper.Instance.GetConnection();

            string sql = @"
    SELECT COUNT(*)
    FROM transaksi
    WHERE status_transaksi='selesai'
    AND DATE(waktu_keluar)=CURRENT_DATE";

            using var cmd = new NpgsqlCommand(sql, conn);

            int jumlah = Convert.ToInt32(cmd.ExecuteScalar());

            lblJumlahAdmin.Text = jumlah.ToString();
        }

        private void LoadRataRataTransaksi()
        {
            using var conn = DatabaseHelper.Instance.GetConnection();

            string sql = @"
    SELECT COALESCE(AVG(total_biaya),0)
    FROM transaksi
    WHERE status_transaksi='selesai'
    AND DATE(waktu_keluar)=CURRENT_DATE";

            using var cmd = new NpgsqlCommand(sql, conn);

            decimal rata =
                Convert.ToDecimal(cmd.ExecuteScalar());

            lblRatarataTransaksi.Text =
                rata.ToString("N0");
        }

        private void LoadTotalKendaraan()
        {
            using var conn = DatabaseHelper.Instance.GetConnection();

            string sql = @"
    SELECT COUNT(*)
    FROM transaksi
    WHERE status_transaksi='selesai'
    AND DATE(waktu_keluar)=CURRENT_DATE";

            using var cmd = new NpgsqlCommand(sql, conn);

            int total =
                Convert.ToInt32(cmd.ExecuteScalar());

            lblJumlahKendaraan.Text =
                total.ToString();
        }

        private void LoadDataKendaraan(int jumlahHari)
        {
            using var conn = DatabaseHelper.Instance.GetConnection();

            DateTime tanggalAwal =
                DateTime.Today.AddDays(-jumlahHari);

            string sql = @"
    SELECT
        k.jenis_kendaraan,
        COUNT(*) AS jumlah
    FROM transaksi t
    JOIN kendaraan k
        ON t.id_kendaraan = k.id_kendaraan
    WHERE t.status_transaksi='selesai'
    AND t.waktu_keluar >= @tanggalAwal
    GROUP BY k.jenis_kendaraan";

            using var cmd = new NpgsqlCommand(sql, conn);

            cmd.Parameters.AddWithValue(
                "@tanggalAwal",
                tanggalAwal);

            using var reader = cmd.ExecuteReader();

            int total = 0;

            while (reader.Read())
            {
                string jenis =
                    reader["jenis_kendaraan"].ToString();

                int jumlah =
                    Convert.ToInt32(reader["jumlah"]);

                total += jumlah;

                switch (jenis)
                {
                    case "bus":
                        lblJumlahBus.Text =
                            jumlah.ToString();
                        break;

                    case "mobil":
                        lblJumlahMobil.Text =
                            jumlah.ToString();
                        break;

                    case "motor":
                        lblJumlahMotor.Text =
                            jumlah.ToString();
                        break;
                }
            }

            lblTotalKendaraan.Text =
                total.ToString();
        }

        private void cboFilterMetode_SelectedIndexChanged(
    object sender,
    EventArgs e)
        {
            int hari =
                GetJumlahHari(
                    cboFilterMetode.Text);

            LoadMetodePembayaran(hari);

            BuatChartMetode(7);
        }

        private void cboFilterKendaraan_SelectedIndexChanged(
    object sender,
    EventArgs e)
        {
            int hari =
                GetJumlahHari(
                    cboFilterKendaraan.Text);

            LoadDataKendaraan(hari);

            BuatChartKendaraan(hari);
        }


        private void cboFilterDBatang_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int hari =
        GetJumlahHari(
            cboFilterDBatang.Text);

            BuatChartPendapatan(hari);
        }

        private void cboFilterMetode_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int hari =
        GetJumlahHari(
            cboFilterMetode.Text);

            LoadMetodePembayaran(hari);

            BuatChartMetode(hari);
        }

        private void cboFilterKendaraan_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int hari =
        GetJumlahHari(
            cboFilterKendaraan.Text);

            LoadDataKendaraan(hari);

            BuatChartKendaraan(hari);
        }
    }
}

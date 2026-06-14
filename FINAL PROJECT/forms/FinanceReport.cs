using FINAL_PROJECT.Controllers;
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
            LoadStatistic();

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

        private void BuatChartPendapatan(
    int jumlahHari)
        {
            FinanceReportController controller =
                new FinanceReportController();

            var data =
                controller.GetChartPendapatan(
                    jumlahHari);

            panelChartPendapatan.Controls.Clear();

            List<double> values =
                new();

            List<string> labels =
                new();

            foreach (var item in data)
            {
                values.Add(
                    Convert.ToDouble(
                        item.Total));

                labels.Add(
                    item.Label);
            }

            var chart =
                new CartesianChart
                {
                    Dock = DockStyle.Fill,

                    Series = new ISeries[]
                    {
                new ColumnSeries<double>
                {
                    Values =
                        values.ToArray(),

                    Name =
                        "Pendapatan"
                }
                    },

                    XAxes = new Axis[]
                    {
                new Axis
                {
                    Labels =
                        labels.ToArray(),

                    Name =
                        "Tanggal"
                }
                    },

                    YAxes = new Axis[]
                    {
                new Axis
                {
                    Name =
                        "Pendapatan",

                    Labeler =
                        value =>
                        "Rp " +
                        value.ToString("N0")
                }
                    }
                };

            panelChartPendapatan.Controls.Add(
                chart);
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

        private void LoadMetodePembayaran(
    int jumlahHari)
        {
            FinanceReportController controller =
                new FinanceReportController();

            var data =
                controller.GetMetodePembayaran(
                    jumlahHari);

            decimal totalKeseluruhan = 0;

            foreach (var item in data)
            {
                totalKeseluruhan += item.Total;

                switch (
                    item.NamaMetode)
                {
                    case "QRIS":

                        lblJumlahQris.Text =
                            item.Total
                            .ToString("N0");

                        break;

                    case "Tunai":

                        lblJumlahDebit.Text =
                            item.Total
                            .ToString("N0");

                        break;

                    case "E-Wallet":

                        lblJumlahEwallet.Text =
                            item.Total
                            .ToString("N0");

                        break;
                }
            }

            lblTotal.Text =
                totalKeseluruhan
                .ToString("N0");
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




        private void LoadDataKendaraan(
    int jumlahHari)
        {
            FinanceReportController
                controller =
                new FinanceReportController();

            var data =
                controller.GetDataKendaraan(
                    jumlahHari);

            int total = 0;

            foreach (var item in data)
            {
                total += item.Jumlah;

                switch (
                    item.JenisKendaraan)
                {
                    case "bus":
                        lblJumlahBus.Text =
                            item.Jumlah
                            .ToString();
                        break;

                    case "mobil":
                        lblJumlahMobil.Text =
                            item.Jumlah
                            .ToString();
                        break;

                    case "motor":
                        lblJumlahMotor.Text =
                            item.Jumlah
                            .ToString();
                        break;
                }
            }

            lblTotalKendaraan.Text =
                total.ToString();
        }

        private void cboFilterMetode_SelectedIndexChanged_1(
    object sender,
    EventArgs e)
        {
            FinanceReportController controller =
                new FinanceReportController();

            int hari =
                controller.GetJumlahHari(
                    cboFilterMetode.Text);

            LoadMetodePembayaran(hari);

            BuatChartMetode(hari);
        }

        private void cboFilterKendaraan_SelectedIndexChanged_1(
    object sender,
    EventArgs e)
        {
            FinanceReportController controller =
                new FinanceReportController();

            int hari =
                controller.GetJumlahHari(
                    cboFilterKendaraan.Text);

            LoadDataKendaraan(hari);

            BuatChartKendaraan(hari);
        }


        private void cboFilterDBatang_SelectedIndexChanged_1(
    object sender,
    EventArgs e)
        {
            FinanceReportController controller =
                new FinanceReportController();

            int hari =
                controller.GetJumlahHari(
                    cboFilterDBatang.Text);

            BuatChartPendapatan(hari);
        }

        


        private void LoadStatistic()
        {
            FinanceReportController controller =
                new FinanceReportController();

            var data =
                controller.GetStatistic();

            lblPendapatanHarian.Text =
                data.PendapatanHariIni.ToString("N0");

            lblJumlahAdmin.Text =
                data.TotalTransaksi.ToString();

            lblRatarataTransaksi.Text =
                data.RataRataTransaksi.ToString("N0");

            lblJumlahKendaraan.Text =
                data.TotalKendaraan.ToString();
        }
    }
}

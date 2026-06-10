using FINAL_PROJECT.Database;
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
            BuatChartPendapatan();
            BuatChartMetode();

            //LoadMetodePembayaran();
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

        private void BuatChartPendapatan()
        {
            try
            {
                using var conn =
                    DatabaseHelper.Instance.GetConnection();

                string query = @"
        SELECT
            DATE(waktu_keluar) AS tanggal,
            SUM(total_biaya) AS pendapatan
        FROM transaksi
        WHERE status_transaksi = 'selesai'
        GROUP BY DATE(waktu_keluar)
        ORDER BY tanggal";

                using var cmd =
                    new NpgsqlCommand(query, conn);

                using var rd =
                    cmd.ExecuteReader();

                List<double> values =
                    new List<double>();

                List<string> labels =
                    new List<string>();

                while (rd.Read())
                {
                    var tanggal =
                        (DateOnly)rd["tanggal"];

                    labels.Add(
                        tanggal.ToString("dd MMM"));

                    values.Add(
                        Convert.ToDouble(rd["pendapatan"]));
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BuatChartMetode()
        {
            try
            {
                using var conn =
                    DatabaseHelper.Instance.GetConnection();

                string query = @"
        SELECT
    m.nama_metode,
    COALESCE(SUM(t.total_biaya),0) AS total
FROM metode_pembayaran m
LEFT JOIN transaksi t
    ON t.id_metode_pembayaran = m.id_metode_pembayaran
    AND t.status_transaksi = 'selesai'
GROUP BY m.id_metode_pembayaran, m.nama_metode
ORDER BY m.id_metode_pembayaran";

                using var cmd =
                    new NpgsqlCommand(query, conn);

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

        private void LoadMetodePembayaran()
        {
            try
            {
                using var conn =
                    DatabaseHelper.Instance.GetConnection();

                string query = @"
        SELECT
            mp.nama_metode,
            COALESCE(SUM(t.total_biaya),0) AS total
        FROM transaksi t
        JOIN metode_pembayaran mp
            ON t.id_metode_pembayaran =
               mp.id_metode_pembayaran
        WHERE t.status_transaksi='selesai'
        GROUP BY mp.nama_metode";

                using var cmd =
                    new NpgsqlCommand(query, conn);

                using var rd =
                    cmd.ExecuteReader();

                decimal qris = 0;
                decimal tunai = 0;
                decimal ewallet = 0;

                while (rd.Read())
                {
                    string metode =
                        rd["nama_metode"].ToString();

                    decimal total =
                        Convert.ToDecimal(rd["total"]);

                    if (metode == "QRIS")
                        qris = total;

                    else if (metode == "Tunai")
                        tunai = total;

                    else if (metode == "E-Wallet")
                        ewallet = total;
                }

                lblJumlahQris.Text =
                    "Rp. " + qris.ToString("N0");

                lblJumlahDebit.Text =
                    "Rp. " + tunai.ToString("N0");

                lblJumlahEwallet.Text =
                    "Rp. " + ewallet.ToString("N0");

                lblTotal.Text =
                    "Rp. " +
                    (qris + tunai + ewallet)
                    .ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BuatChartKendaraan()
        {
            var pie = new PieChart
            {
                Dock = DockStyle.Fill,

                Series = new ISeries[]
        {
            new PieSeries<double>
            {
                Name = "QRIS",
                Values = new double[] { 40 }
            },

            new PieSeries<double>
            {
                Name = "Tunai",
                Values = new double[] { 35 }
            },

            new PieSeries<double>
            {
                Name = "E-Wallet",
                Values = new double[] { 25 }
            }
        }
            };

            panelChartKendaraan.Controls.Clear();
            panelChartKendaraan.Controls.Add(pie);
        }
    }
}

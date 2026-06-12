using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FINAL_PROJECT.Data;
using Npgsql;

namespace FINAL_PROJECT.forms

{
    public partial class MonitoringPetugas : Form
    {
        public MonitoringPetugas()
        {
            InitializeComponent();
        }
        private void LoadMonitoring()
        {
            try
            {
                using var conn =
                    DatabaseHelper.Instance.GetConnection();

                string query = @"
        SELECT *
        FROM v_monitoring_slot
        ORDER BY kode_slot";

                using var cmd =
                    new NpgsqlCommand(query, conn);

                using var rd =
                    cmd.ExecuteReader();

                panel11.Controls.Clear();
                panel10.Controls.Clear();
                panelBus.Controls.Clear();

                while (rd.Read())
                {
                    Label lbl = new Label();

                    lbl.Width = 70;
                    lbl.Height = 40;
                    lbl.TextAlign =
                        ContentAlignment.MiddleCenter;

                    lbl.BorderStyle =
                        BorderStyle.FixedSingle;

                    lbl.Text =
                        rd["kode_slot"].ToString();

                    bool terisi =
                        rd["status_slot"]
                        .ToString()
                        .ToLower() == "terisi";

                    lbl.BackColor =
                        terisi
                        ? Color.Red
                        : Color.LightGreen;

                    string jenis =
                        rd["jenis_kendaraan"]
                        .ToString()
                        .ToLower();

                    if (jenis == "motor")
                        panel11.Controls.Add(lbl);

                    else if (jenis == "mobil")
                        panel10.Controls.Add(lbl);

                    else if (jenis == "bus")
                        panelBus.Controls.Add(lbl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            HistoryPetugas historyp = new HistoryPetugas();
            historyp.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Monitoring monitor = new Monitoring();
            monitor.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            DashboardPetugas dashp = new DashboardPetugas();
            dashp.Show();
            this.Hide();
        }

        private void btnParkingdata_Click(object sender, EventArgs e)
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

        private void btnFinanceReport_Click(object sender, EventArgs e)
        {
            FinanceReport finance = new FinanceReport();
            finance.Show();
            this.Hide();
        }

        private void LoadGridMonitoring()
        {
            try
            {
                using var conn =
                    DatabaseHelper.Instance.GetConnection();

                string query = @"
        SELECT
            kode_slot AS ""Kode Slot"",
            status_slot AS ""Status"",
            jenis_kendaraan AS ""Jenis Kendaraan"",
            plat_nomor AS ""Plat Nomor"",
            waktu_masuk AS ""Waktu Masuk"",
            nama_petugas AS ""Petugas"",
            status_user AS ""Status Petugas""
        FROM v_monitoring_slot
        ORDER BY kode_slot";

                DataTable dt = new DataTable();

                using var da =
                    new NpgsqlDataAdapter(query, conn);

                da.Fill(dt);

                dgvListMonitoring.DataSource = dt;

                dgvListMonitoring
                    .AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgvListMonitoring.ReadOnly = true;
                dgvListMonitoring.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Monitoring_Load(object sender, EventArgs e)
        {
            LoadMonitoring();
            LoadGridMonitoring();
            LoadStatistic();
            LoadJumlahSlot();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadMonitoring();
            LoadGridMonitoring();

            LoadStatistic();
        }

        private void PanelMonitoring_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void LoadStatistic()
        {
            try
            {
                using var conn =
                    DatabaseHelper.Instance.GetConnection();

                LoadAreaStatistic(
                    conn,
                    "A",
                    lblAreaAterisi,
                    lblAreaA);

                LoadAreaStatistic(
                    conn,
                    "B",
                    lblAreaBterisi,
                    lblAreaB);

                LoadAreaStatistic(
                    conn,
                    "C",
                    lblAreaCterisi,
                    lblAreaC);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadAreaStatistic(
            NpgsqlConnection conn,
            string area,
            Label lblTerisi,
            Label lblTotal)
        {
            string query = @"
    SELECT
        COUNT(*) FILTER
        (WHERE status_slot = 'terisi') AS terisi,
        COUNT(*) AS total
    FROM slot_parkir
    WHERE kode_slot LIKE @area";

            using var cmd =
                new NpgsqlCommand(query, conn);

            cmd.Parameters.AddWithValue(
                "@area",
                area + "-%");

            using var rd =
                cmd.ExecuteReader();

            if (rd.Read())
            {
                lblTerisi.Text =
                    rd["terisi"].ToString();

                lblTotal.Text =
                    rd["total"].ToString();
            }

            rd.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblAreaAterisi_Click(object sender, EventArgs e)
        {

        }

        private void lblAreaBterisi_Click(object sender, EventArgs e)
        {

        }

        private void lblAreaCterisi_Click(object sender, EventArgs e)
        {

        }

        private void LoadJumlahSlot()
        {
            using var conn =
                DatabaseHelper.Instance.GetConnection();

            string query = @"
    SELECT
        LEFT(kode_slot,1) area,
        COUNT(*) total,
        SUM(
            CASE
                WHEN status_slot='terisi'
                THEN 1
                ELSE 0
            END
        ) terisi
    FROM slot_parkir
    GROUP BY LEFT(kode_slot,1)";

            using var cmd =
                new NpgsqlCommand(query, conn);

            using var rd =
                cmd.ExecuteReader();

            while (rd.Read())
            {
                string area =
                    rd["area"].ToString();

                string total =
                    rd["total"].ToString();

                string terisi =
                    rd["terisi"].ToString();

                if (area == "A")
                {
                    lblAreaA.Text = total;
                    lblAreaAterisi.Text = terisi;
                }
                else if (area == "B")
                {
                    lblAreaB.Text = total;
                    lblAreaBterisi.Text = terisi;
                }
                else if (area == "C")
                {
                    lblAreaC.Text = total;
                    lblAreaCterisi.Text = terisi;
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVehicleData_Click(object sender, EventArgs e)
        {
            VehicleData vd = new VehicleData();
            vd.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Yakin ingin logout?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                login login = new login();
                login.Show();

                this.Hide();
            }
        }
    }

}

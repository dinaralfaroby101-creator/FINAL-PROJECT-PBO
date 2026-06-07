using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FINAL_PROJECT.Database;
using Npgsql;

namespace FINAL_PROJECT
{
    public partial class Monitoring : Form
    {
        public Monitoring()
        {
            InitializeComponent();
        }
        private void LoadMonitoring()
        {
            flowMotor.Controls.Clear();
            flowMobil.Controls.Clear();
            flowBus.Controls.Clear();

            try
            {
                using var conn =
                DatabaseHelper.Instance.GetConnection();

                string query =
                "SELECT * FROM v_monitoring_slot";

                using var cmd =
                new NpgsqlCommand(query, conn);

                using var rd =
                cmd.ExecuteReader();

                while (rd.Read())
                {
                    ParkingSlot slot =
                    new ParkingSlot();

                    bool occupied =
                    rd["status"].ToString() == "terisi";

                    slot.SetStatus(occupied);

                    string jenis =
                    rd["jenis_kendaraan"]?.ToString();

                    if (jenis == "motor")
                    {
                        flowMotor.Controls.Add(slot);
                    }
                    else if (jenis == "mobil")
                    {
                        flowMobil.Controls.Add(slot);
                    }
                    else if (jenis == "bus")
                    {
                        flowBus.Controls.Add(slot);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            status AS ""Status"",
            jenis_kendaraan AS ""Kendaraan"",
            plat_nomor AS ""Plat Nomor"",
            ROUND(
                durasi_menit_sekarang::numeric,
                0
            ) AS ""Durasi"",
            nama_petugas AS ""Petugas""
        FROM v_monitoring_slot
        ORDER BY kode_slot";

                using var da =
                new NpgsqlDataAdapter(query, conn);

                DataTable dt =
                new DataTable();

                da.Fill(dt);

                dgvMonitoring.DataSource = dt;

                dgvMonitoring.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.Show();
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
            Dashboard dash = new Dashboard();
            dash.Show();
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

        private void Monitoring_Load(object sender, EventArgs e)
        {
            LoadMonitoring();
            LoadGridMonitoring();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadMonitoring();
            LoadGridMonitoring();
        }

        private void PanelMonitoring_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

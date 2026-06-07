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

                panel11.Controls.Clear();
                panel10.Controls.Clear();
                panelBus.Controls.Clear();

                while (rd.Read())
                {
                    Label lbl = new Label();

                    lbl.AutoSize = false;
                    lbl.Width = 100;
                    lbl.Height = 40;

                    lbl.Text =
                        rd["kode_slot"].ToString();

                    lbl.TextAlign =
                        ContentAlignment.MiddleCenter;

                    bool occupied =
                        rd["status"].ToString()?.ToLower() == "terisi";

                    lbl.BackColor =
                        occupied
                        ? Color.Red
                        : Color.LightGreen;

                    string jenis =
                        rd["jenis_kendaraan"]?.ToString()?.ToLower();

                    if (jenis == "motor")
                    {
                        panel11.Controls.Add(lbl);
                    }
                    else if (jenis == "mobil")
                    {
                        panel10.Controls.Add(lbl);
                    }
                    else if (jenis == "bus")
                    {
                        panelBus.Controls.Add(lbl);
                    }
                }
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

        private void LoadGridMonitoring()
        {
            try
            {
                using var conn =
                    DatabaseHelper.Instance.GetConnection();

                string query =
                @"SELECT
                kode_slot,
                status,
                jenis_kendaraan,
                plat_nomor,
                waktu_masuk
                FROM parking_slot 
                ORDER BY kode_slot";

                using var da =
                    new NpgsqlDataAdapter(query, conn);

                DataTable dt = new DataTable();

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

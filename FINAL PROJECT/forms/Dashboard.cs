using FINAL_PROJECT.Data;
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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panelParking_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel27_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void btnParkingData_Click(object sender, EventArgs e)
        {
            ParkingData park = new ParkingData();
            park.Show();
            this.Hide();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

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

        private void btnFinanceReport_Click(object sender, EventArgs e)
        {
            FinanceReport finance = new FinanceReport();
            finance.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
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

        private void lblDashboard_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void LoadJumlahArea()
        {
            using var conn = DatabaseHelper.Instance.GetConnection();

            string sql = @"
    SELECT COUNT(DISTINCT LEFT(kode_slot,1))
    FROM slot_parkir";

            using var cmd = new NpgsqlCommand(sql, conn);

            lblParkingArea.Text =
                cmd.ExecuteScalar().ToString();
        }

        private void LoadTotalSlot()
        {
            using var conn = DatabaseHelper.Instance.GetConnection();

            string sql =
                "SELECT COUNT(*) FROM slot_parkir";

            using var cmd =
                new NpgsqlCommand(sql, conn);

            lblTotalSlot.Text =
                cmd.ExecuteScalar().ToString();
        }

        private void LoadSlotTerisi()
        {
            using var conn =
                DatabaseHelper.Instance.GetConnection();

            string sql = @"
    SELECT COUNT(*)
    FROM slot_parkir
    WHERE status_slot='terisi'";

            using var cmd =
                new NpgsqlCommand(sql, conn);

            lblTerisi.Text =
                cmd.ExecuteScalar().ToString();
        }

        private void LoadSlotKosong()
        {
            using var conn =
                DatabaseHelper.Instance.GetConnection();

            string sql = @"
    SELECT COUNT(*)
    FROM slot_parkir
    WHERE status_slot='kosong'";

            using var cmd =
                new NpgsqlCommand(sql, conn);

            lblTersedia.Text =
                cmd.ExecuteScalar().ToString();
        }




        private void LoadAreaA()
        {
            using var conn =
                DatabaseHelper.Instance.GetConnection();

            string sql = @"
    SELECT
        COUNT(*) total,
        COUNT(*) FILTER
        (WHERE status_slot='terisi') terisi
    FROM slot_parkir
    WHERE kode_slot LIKE 'A-%'";

            using var cmd =
                new NpgsqlCommand(sql, conn);

            using var rd =
                cmd.ExecuteReader();

            if (rd.Read())
            {
                int total =
                    Convert.ToInt32(rd["total"]);

                int terisi =
                    Convert.ToInt32(rd["terisi"]);

                int kosong =
                    total - terisi;

                int persen =
                    total == 0 ? 0 :
                    (terisi * 100) / total;

                progressBarA.Maximum = total;
                progressBarA.Value = terisi;

                lblPersenA.Text =
                    persen + "%";

                lblSlotA.Text =
                    "Slot " + total;

                lblTerisiA.Text =
                    "Terisi " + terisi;

                lblTersediaA.Text =
                    "Tersedia " + kosong;
            }
        }

        private void LoadAreaB()
        {
            using var conn =
                DatabaseHelper.Instance.GetConnection();

            string sql = @"
    SELECT
        COUNT(*) total,
        COUNT(*) FILTER
        (WHERE status_slot='terisi') terisi
    FROM slot_parkir
    WHERE kode_slot LIKE 'B-%'";

            using var cmd =
                new NpgsqlCommand(sql, conn);

            using var rd =
                cmd.ExecuteReader();

            if (rd.Read())
            {
                int total =
                    Convert.ToInt32(rd["total"]);

                int terisi =
                    Convert.ToInt32(rd["terisi"]);

                int kosong =
                    total - terisi;

                int persen =
                    total == 0 ? 0 :
                    (terisi * 100) / total;

                progressBarB.Maximum = total;
                progressBarB.Value = terisi;

                lblPersenB.Text =
                    persen + "%";

                lblSlotB.Text =
                    "Slot " + total;

                lblTerisiB.Text =
                    "Terisi " + terisi;

                lblTersediaB.Text =
                    "Tersedia " + kosong;
            }
        }

        private void LoadAreaC()
        {
            using var conn =
                DatabaseHelper.Instance.GetConnection();

            string sql = @"
    SELECT
        COUNT(*) total,
        COUNT(*) FILTER
        (WHERE status_slot='terisi') terisi
    FROM slot_parkir
    WHERE kode_slot LIKE 'C-%'";

            using var cmd =
                new NpgsqlCommand(sql, conn);

            using var rd =
                cmd.ExecuteReader();

            if (rd.Read())
            {
                int total =
                    Convert.ToInt32(rd["total"]);

                int terisi =
                    Convert.ToInt32(rd["terisi"]);

                int kosong =
                    total - terisi;

                int persen =
                    total == 0 ? 0 :
                    (terisi * 100) / total;

                progressBarC.Maximum = total;
                progressBarC.Value = terisi;

                lblPersenC.Text =
                    persen + "%";

                lblSlotC.Text =
                    "Slot " + total;

                lblTerisiC.Text =
                    "Terisi " + terisi;

                lblTersediaC.Text =
                    "Tersedia " + kosong;
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadJumlahArea();

            LoadTotalSlot();

            LoadSlotTerisi();

            LoadSlotKosong();

            LoadAreaA();

            LoadAreaB();

            LoadAreaC();
        }

    }
}

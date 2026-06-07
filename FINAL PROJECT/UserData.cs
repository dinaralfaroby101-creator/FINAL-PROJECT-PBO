using FINAL_PROJECT.Database;
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

namespace FINAL_PROJECT
{
    public partial class UserData : Form
    {
        public UserData()
        {
            InitializeComponent();
        }

        private void LoadUserData()
        {
            using (var conn = DatabaseHelper.Instance.GetConnection())
            {
                string query =
                @"SELECT
            user_id,
            fullname,
            username,
            role,
            status
          FROM users";

                NpgsqlDataAdapter da =
                    new NpgsqlDataAdapter(query, conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvUser.DataSource = dt;
            }
        }

        private void UserData_Load(object sender, EventArgs e)
        {
            LoadUserData();
            UpdateStatistic();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UserData user = new UserData();
            user.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ParkingData park = new ParkingData();
            park.Show();
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void cbxUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UpdateStatistic()
        {
            using (var conn = DatabaseHelper.Instance.GetConnection())
            {
                string total =
                    "SELECT COUNT(*) FROM users";

                string admin =
                    "SELECT COUNT(*) FROM users WHERE role='Admin'";

                string petugas =
                    "SELECT COUNT(*) FROM users WHERE role='Petugas'";

                string aktif =
                    "SELECT COUNT(*) FROM users WHERE status='Aktif'";

                lblJumlahUser.Text =
                    new NpgsqlCommand(total, conn)
                    .ExecuteScalar().ToString();

                lblJumlahAdmin.Text =
                    new NpgsqlCommand(admin, conn)
                    .ExecuteScalar().ToString();

                lblJumlahPetugas.Text =
                    new NpgsqlCommand(petugas, conn)
                    .ExecuteScalar().ToString();

                lblJumlahUserAktif.Text =
                    new NpgsqlCommand(aktif, conn)
                    .ExecuteScalar().ToString();
            }
        }

        private void btnTambahUser_Click(object sender, EventArgs e)
        {
            InputUser_ form = new InputUser_();

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadUserData();
                UpdateStatistic();
            }
        }

        private void txtSearch_TextChanged(
        object sender,
        EventArgs e)
        {
            using (var conn =
                DatabaseHelper.Instance.GetConnection())
            {
                string query =
                @"SELECT *
          FROM users
          WHERE username ILIKE @search";

                NpgsqlDataAdapter da =
                    new NpgsqlDataAdapter(query, conn);

                da.SelectCommand.Parameters.AddWithValue(
                    "@search",
                    "%" + txtCariUsername.Text + "%");

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvUser.DataSource = dt;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UpdateStatistic()
        {
            using (var conn = DatabaseHelper.Instance.GetConnection())
            {
                string total =
                    "SELECT COUNT(*) FROM users";

                string admin =
                    "SELECT COUNT(*) FROM users WHERE role='Admin'";

                string petugas =
                    "SELECT COUNT(*) FROM users WHERE role='Petugas'";

                string aktif =
                    "SELECT COUNT(*) FROM users WHERE status='Aktif'";

                lblJumlahUser.Text =
                    new NpgsqlCommand(total, conn)
                    .ExecuteScalar().ToString();

                lblJumlahAdmin.Text =
                    new NpgsqlCommand(admin, conn)
                    .ExecuteScalar().ToString();

                lblJumlahPetugas.Text =
                    new NpgsqlCommand(petugas, conn)
                    .ExecuteScalar().ToString();

                lblJumlahUserAktif.Text =
                    new NpgsqlCommand(aktif, conn)
                    .ExecuteScalar().ToString();
            }
        }

        private void btnTambahUser_Click(object sender, EventArgs e)
        {
            InputUser_ form = new InputUser_();

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadUserData();
                UpdateStatistic();
            }
        }

        private void txtSearch_TextChanged(
        object sender,
        EventArgs e)
        {
            using (var conn =
                DatabaseHelper.Instance.GetConnection())
            {
                string query =
                @"SELECT *
          FROM users
          WHERE username ILIKE @search";

                NpgsqlDataAdapter da =
                    new NpgsqlDataAdapter(query, conn);

                da.SelectCommand.Parameters.AddWithValue(
                    "@search",
                    "%" + txtCariUsername.Text + "%");

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvUser.DataSource = dt;
            }
        }
    }
}

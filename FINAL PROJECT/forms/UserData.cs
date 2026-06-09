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

namespace FINAL_PROJECT.forms
{
    public partial class UserData : Form
    {
        public UserData()
        {
            InitializeComponent();

            txtCariUsername.TextChanged +=
              txtSearch_TextChanged;
            button1.Click += button1_Click;

        }

        private void LoadUserData()
        {
            using (var conn = DatabaseHelper.Instance.GetConnection())
            {
                string query =
                @"SELECT
                id_user,
                username,
                password_akun,
                nama_lengkap,
                role,
                status_user,
                last_login
                FROM users
                ORDER BY id_user";

                NpgsqlDataAdapter da =
                    new NpgsqlDataAdapter(query, conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvUser.DataSource = dt;

                dgvUser.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgvUser.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                dgvUser.AllowUserToAddRows = false;

                if (!dgvUser.Columns.Contains("Edit"))
                {
                    DataGridViewButtonColumn edit =
                        new DataGridViewButtonColumn();

                    edit.Name = "Edit";
                    edit.Text = "Edit";
                    edit.UseColumnTextForButtonValue = true;

                    dgvUser.Columns.Add(edit);
                }

                if (!dgvUser.Columns.Contains("Delete"))
                {
                    DataGridViewButtonColumn delete =
                        new DataGridViewButtonColumn();

                    delete.Name = "Delete";
                    delete.Text = "Delete";
                    delete.UseColumnTextForButtonValue = true;

                    dgvUser.Columns.Add(delete);
                }
            }
        }

        private void UserData_Load(object sender, EventArgs e)
        {
            LoadUserData();
            UpdateStatistic();
            dgvUser.Dock = DockStyle.Fill;
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

        private void cbxUser_SelectedIndexChanged(
    object sender,
    EventArgs e)
        {
            using (var conn =
                DatabaseHelper.Instance.GetConnection())
            {
                string query =
                @"SELECT
                id_user,
                username,
                password_akun,
                nama_lengkap,
                role,
                status_user,
                last_login
              FROM users";

                if (cbxUser.Text != "Semua User")
                {
                    query += " WHERE role = @role";
                }

                NpgsqlDataAdapter da =
                    new NpgsqlDataAdapter(query, conn);

                if (cbxUser.Text != "Semua User")
                {
                    da.SelectCommand.Parameters.AddWithValue(
                        "@role",
                        cbxUser.Text);
                }

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
                    "SELECT COUNT(*) FROM users WHERE role='admin'";

                string petugas =
                    "SELECT COUNT(*) FROM users WHERE role='petugas'";

                string aktif =
                    "SELECT COUNT(*) FROM users WHERE status_user='Active'";

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

        private void dgvUser_CellContentClick(
        object sender,
        DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int id =
                Convert.ToInt32(
                dgvUser.Rows[e.RowIndex]
                .Cells["id_user"].Value);

            if (dgvUser.Columns[e.ColumnIndex].Name == "Delete")
            {
                DeleteUser(id);
            }

            if (dgvUser.Columns[e.ColumnIndex].Name == "Edit")
            {
                EditUser(id);
            }
        }

        private void DeleteUser(int id)
        {
            DialogResult result =
                MessageBox.Show(
                "Hapus user ini ?",
                "Konfirmasi",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
                return;

            using (var conn =
                DatabaseHelper.Instance.GetConnection())
            {
                string query =
                    "DELETE FROM users WHERE id_user=@id";

                using (var cmd =
                    new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }
            }

            LoadUserData();
            UpdateStatistic();
        }

        private void EditUser(int id)
        {
            MessageBox.Show(
                "Edit User ID : " + id);
        }

        private void button1_Click(
            object sender,
            EventArgs e)
        {
            DialogResult result =
                MessageBox.Show(
                "Yakin logout?",
                "Logout",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                login login =
                    new login();

                login.Show();

                this.Hide();
            }
        }
    }
}

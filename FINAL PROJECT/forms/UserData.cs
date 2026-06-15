using FINAL_PROJECT.Controller;
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
                string query = @"
        SELECT
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

                // Reset DataGridView
                dgvUser.Columns.Clear();

                // Generate kolom otomatis
                dgvUser.AutoGenerateColumns = true;

                // Masukkan data
                dgvUser.DataSource = dt;

                // Pengaturan tabel
                dgvUser.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgvUser.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                dgvUser.AllowUserToAddRows = false;

                dgvUser.ReadOnly = true;

                // Header kolom
                if (dgvUser.Columns.Count > 0)
                {
                    dgvUser.Columns[0].HeaderText = "ID";
                    dgvUser.Columns[1].HeaderText = "Username";
                    dgvUser.Columns[2].HeaderText = "Password";
                    dgvUser.Columns[3].HeaderText = "Nama Lengkap";
                    dgvUser.Columns[4].HeaderText = "Role";
                    dgvUser.Columns[5].HeaderText = "Status";
                    dgvUser.Columns[6].HeaderText = "Last Login";
                }

                // OPTIONAL: sembunyikan password
                dgvUser.Columns[2].Visible = false;
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
            UserController controller =
                new UserController();

            if (cbxUser.Text ==
                "Semua User")
            {
                LoadUserData();
            }
            else
            {
                dgvUser.DataSource =
                    controller.GetByRole(
                        cbxUser.Text);
            }
        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UpdateStatistic()
        {
            UserController controller =
                new UserController();

            var data =
                controller.GetStatistic();

            lblJumlahUser.Text =
                data.TotalUser.ToString();

            lblJumlahAdmin.Text =
                data.TotalAdmin.ToString();

            lblJumlahPetugas.Text =
                data.TotalPetugas.ToString();

            lblJumlahUserAktif.Text =
                data.TotalAktif.ToString();
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
            UserController controller =
                new UserController();

            dgvUser.DataSource =
                controller.Search(
                    txtCariUsername.Text);
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

            UserController controller =
                new UserController();

            controller.DeleteUser(id);

            LoadUserData();
            UpdateStatistic();
        }




        private void EditUser(int id)
        {
            InputUser_ form =
                new InputUser_(id);

            if (form.ShowDialog() ==
                DialogResult.OK)
            {
                LoadUserData();
                UpdateStatistic();
            }
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

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(
                    dataGridView1.SelectedRows[0].Cells["ID"].Value);

                FormEditUser frm = new FormEditUser(id);
                frm.ShowDialog();

                LoadUserData(); // refresh data setelah edit
            }
            else
            {
                MessageBox.Show("Pilih user yang ingin diedit!");
            }
        }
    }
}

using FINAL_PROJECT.Data;
using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace FINAL_PROJECT.forms
{
    public partial class ParkingData : Form
    {
        public ParkingData()
        {
            InitializeComponent();
        }

        private void ParkingData_Load(object sender, EventArgs e)
        {
            LoadParkingData();
            UpdateStatistic();
        }

        // ==========================
        // LOAD DATA GRID
        // ==========================
        private void LoadParkingData()
        {
            using (var conn = DatabaseHelper.Instance.GetConnection())
            {
                string query =
                    "SELECT * FROM slot_parkir ORDER BY id_slot";

                NpgsqlDataAdapter da =
                    new NpgsqlDataAdapter(query, conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;

                dataGridView1.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                // tombol edit
                if (!dataGridView1.Columns.Contains("Edit"))
                {
                    DataGridViewButtonColumn edit =
                        new DataGridViewButtonColumn();

                    edit.Name = "Edit";
                    edit.HeaderText = "Edit";
                    edit.Text = "Edit";
                    edit.UseColumnTextForButtonValue = true;

                    dataGridView1.Columns.Add(edit);
                }

                // tombol delete
                if (!dataGridView1.Columns.Contains("Delete"))
                {
                    DataGridViewButtonColumn hapus =
                        new DataGridViewButtonColumn();

                    hapus.Name = "Delete";
                    hapus.HeaderText = "Delete";
                    hapus.Text = "Delete";
                    hapus.UseColumnTextForButtonValue = true;

                    dataGridView1.Columns.Add(hapus);
                }
            }
        }

        // ==========================
        // UPDATE CARD STATISTIK
        // ==========================
        private void UpdateStatistic()
        {
            using (var conn = DatabaseHelper.Instance.GetConnection())
            {
                string total =
                    "SELECT COUNT(*) FROM slot_parkir";

                string kosong =
                    "SELECT COUNT(*) FROM slot_parkir WHERE status_slot='kosong'";

                string terisi =
                    "SELECT COUNT(*) FROM slot_parkir WHERE status_slot='terisi'";

                string maintenance =
                    "SELECT COUNT(*) FROM slot_parkir WHERE status_slot='maintenance'";

                label6.Text =
                    new NpgsqlCommand(total, conn)
                    .ExecuteScalar()
                    .ToString();

                label9.Text =
                    new NpgsqlCommand(kosong, conn)
                    .ExecuteScalar()
                    .ToString();

                label12.Text =
                    new NpgsqlCommand(terisi, conn)
                    .ExecuteScalar()
                    .ToString();

                label15.Text =
                    new NpgsqlCommand(maintenance, conn)
                    .ExecuteScalar()
                    .ToString();
            }
        }

        // ==========================
        // TAMBAH SLOT
        // ==========================
        private void button1_Click_1(object sender, EventArgs e)
        {
            SLotParkir form = new SLotParkir();

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadParkingData();
                UpdateStatistic();
            }
        }

        // ==========================
        // SEARCH
        // ==========================
        private void txtSearch_TextChanged(
            object sender,
            EventArgs e)
        {
            SearchData();
        }

        private void SearchData()
        {
            using (var conn = DatabaseHelper.Instance.GetConnection())
            {
                string query =
                    @"SELECT *
                      FROM slot_parkir
                      WHERE kode_slot ILIKE @search";

                NpgsqlDataAdapter da =
                    new NpgsqlDataAdapter(query, conn);

                da.SelectCommand.Parameters.AddWithValue(
                    "@search",
                    "%" + txtSearch.Text + "%");

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        // ==========================
        // BUTTON EDIT & DELETE
        // ==========================
        private void dataGridView1_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int id =
                Convert.ToInt32(
                dataGridView1.Rows[e.RowIndex]
                .Cells["id_slot"].Value);

            string namaKolom =
                dataGridView1.Columns[e.ColumnIndex].Name;

            if (namaKolom == "Delete")
            {
                DeleteData(id);
            }

            if (namaKolom == "Edit")
            {
                EditData(id);
            }
        }

        // ==========================
        // DELETE DATA
        // ==========================
        private void DeleteData(int id)
        {
            DialogResult result =
                MessageBox.Show(
                "Yakin hapus data?",
                "Konfirmasi",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
                return;

            using (var conn = DatabaseHelper.Instance.GetConnection())
            {
                string query =
                    "DELETE FROM slot_parkir WHERE id_slot=@id";

                using (var cmd =
                    new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue(
                        "@id",
                        id);

                    cmd.ExecuteNonQuery();
                }
            }

            LoadParkingData();
            UpdateStatistic();
        }

        // ==========================
        // EDIT DATA
        // ==========================
        private void EditData(int id)
        {
            MessageBox.Show(
                "Fitur Edit Slot ID : " + id +
                "\nBelum dibuat");
        }

        // ==========================
        // LOGOUT
        // ==========================
        private void btnLogOut_Click(
            object sender,
            EventArgs e)
        {
            DialogResult result =
                MessageBox.Show(
                "Yakin ingin logout?",
                "Logout",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                login login = new login();
                login.Show();
                this.Hide();
            }
        }

        // ==========================
        // MENU NAVIGASI
        // ==========================
        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void btnUserData_Click(object sender, EventArgs e)
        {
            new UserData().Show();
            this.Hide();
        }

        private void btnBagStorage_Click(object sender, EventArgs e)
        {
            new BagStorage().Show();
            this.Hide();
        }

        private void btnMonitoring_Click(object sender, EventArgs e)
        {
            new Monitoring().Show();
            this.Hide();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            new History().Show();
            this.Hide();
        }

        private void btnFinanceReport_Click(object sender, EventArgs e)
        {
            new FinanceReport().Show();
            this.Hide();
        }


        private void panelSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnParkingData_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}



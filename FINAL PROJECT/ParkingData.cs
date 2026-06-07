using FINAL_PROJECT.Database;
using FINAL_PROJECT.Models;
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
    public partial class ParkingData : Form
    {
        public ParkingData()
        {
            InitializeComponent();
        }

        private void LoadParkingData()
        {
            using (var conn = DatabaseHelper.Instance.GetConnection())
            {
                string query = "SELECT * FROM parking_slot ORDER BY id";

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;

                if (!dataGridView1.Columns.Contains("Edit"))
                {
                    DataGridViewButtonColumn edit =
                        new DataGridViewButtonColumn();

                    edit.Name = "Edit";
                    edit.Text = "Edit";
                    edit.UseColumnTextForButtonValue = true;

                    dataGridView1.Columns.Add(edit);
                }

                if (!dataGridView1.Columns.Contains("Delete"))
                {
                    DataGridViewButtonColumn hapus =
                        new DataGridViewButtonColumn();

                    hapus.Name = "Delete";
                    hapus.Text = "Delete";
                    hapus.UseColumnTextForButtonValue = true;

                    dataGridView1.Columns.Add(hapus);
                }
            }
        }

        private void UpdateStatistic()
        {
            using (var conn = DatabaseHelper.Instance.GetConnection())
            {
                string totalQuery =
                    "SELECT COUNT(*) FROM parking_slot";

                string kosongQuery =
                    "SELECT COUNT(*) FROM parking_slot WHERE status='Kosong'";

                string terisiQuery =
                    "SELECT COUNT(*) FROM parking_slot WHERE status='Terisi'";

                string maintenanceQuery =
                    "SELECT COUNT(*) FROM parking_slot WHERE status='Maintenance'";

                label6.Text =
                    new NpgsqlCommand(totalQuery, conn)
                    .ExecuteScalar().ToString();

                label9.Text =
                    new NpgsqlCommand(kosongQuery, conn)
                    .ExecuteScalar().ToString();

                label12.Text =
                    new NpgsqlCommand(terisiQuery, conn)
                    .ExecuteScalar().ToString();

                label15.Text =
                    new NpgsqlCommand(maintenanceQuery, conn)
                    .ExecuteScalar().ToString();
            }
        }

        private void ParkingData_Load(object sender, EventArgs e)
        {
            LoadParkingData();
            UpdateStatistic();
        }
        private void dgvParking_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }
        private void dgvParking_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            Dashboard Dashboard = new Dashboard();
            Dashboard.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SLotParkir form = new SLotParkir();

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadParkingData();
                UpdateStatistic();
            }
        }

        private void panelSidebar_Paint(object sender, PaintEventArgs e)
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

        private void btnParkingData_Click(object sender, EventArgs e)
        {
            ParkingData park = new ParkingData();
            park.Show();
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
                Form1 login = new Form1();
                login.Show();

                this.Hide();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SearchData()
        {
            using (var conn = DatabaseHelper.Instance.GetConnection())
            {
                string query =
                @"SELECT *
          FROM parking_slot
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

        private void txtSearch_TextChanged(
        object sender,
        EventArgs e)
        {
            SearchData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int id =
                Convert.ToInt32(
                    dataGridView1.Rows[e.RowIndex]
                    .Cells["id"].Value);

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                DeleteData(id);
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                EditData(id);
            }
        }

        private void DeleteData(int id)
        {
            using (var conn1 = DatabaseHelper.Instance.GetConnection())
            {
                DialogResult result =
                MessageBox.Show(
                "Hapus data ini ?",
                "Konfirmasi",
                MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                    return;

                using (var conn = DatabaseHelper.Instance.GetConnection())
                {
                    string query =
                        "DELETE FROM parking_slot WHERE id=@id";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();
                    }
                }

                LoadParkingData();
                UpdateStatistic();
            }
        }

        private void EditData(int id)
        {
            MessageBox.Show("Edit Data ID : " + id);
        }

        private string GetArea(string kodeSlot)
        {
            if (kodeSlot.StartsWith("A"))
                return "Area A";

            if (kodeSlot.StartsWith("B"))
                return "Area B";

            if (kodeSlot.StartsWith("C"))
                return "Area C";

            return "-";
        }
    }

}

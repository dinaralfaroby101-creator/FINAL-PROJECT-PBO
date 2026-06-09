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

namespace FINAL_PROJECT.forms
{
    public partial class BagStorage : Form
    {
        public BagStorage()
        {
            InitializeComponent();
        }

        private void BagStorage_Load(object sender, EventArgs e)
        {
            LoadSummary();
            LoadGridBagStorage();

            txtIdPenitipan.PlaceholderText =
    "Cari ID Penitipan";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Dashboard Dashboard = new Dashboard();
            Dashboard.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ParkingData park = new ParkingData();
            park.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BagStorage bag = new BagStorage();
            bag.Show();
            this.Hide();
        }

        private void btnUserData_Click(object sender, EventArgs e)
        {
            UserData user = new UserData();
            user.Show();
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

        private void btnTambahUser_Click(object sender, EventArgs e)
        {
            inputpenitipan frm = new inputpenitipan();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadSummary();
                LoadGridBagStorage();
            }
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadSummary()
        {
            try
            {
                using var conn =
                    DatabaseHelper.Instance.GetConnection();

                // Total Dititipkan
                string q1 = @"
SELECT COUNT(*)
FROM penitipan";

                using (var cmd = new NpgsqlCommand(q1, conn))
                {
                    lblJumlahDititipkan.Text =
    cmd.ExecuteScalar().ToString();
                }

                // Dititipkan Hari Ini
                string q2 = @"

SELECT COUNT(*)
FROM penitipan
WHERE DATE(waktu_masuk)=CURRENT_DATE";

                using (var cmd = new NpgsqlCommand(q2, conn))
                {
                    lbltotalDititipkanHariIni.Text =
    cmd.ExecuteScalar().ToString();
                }

                // Sudah Diambil
                string q3 = @"
SELECT COUNT(*)
FROM penitipan
WHERE status_penitipan='diambil'";

                using (var cmd = new NpgsqlCommand(q3, conn))
                {
                    lblJumlahDiambil.Text =
    cmd.ExecuteScalar().ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void LoadGridBagStorage()
        {
            try
            {
                using var conn =
                    DatabaseHelper.Instance.GetConnection();

                string query = @"
        SELECT
            p.id_penitipan        AS ""ID"",
            b.nama_barang         AS ""Nama Barang"",
            b.kategori_barang     AS ""Kategori"",
            p.nama_pemilik        AS ""Pemilik"",
            p.jumlah_barang       AS ""Jumlah"",
            p.waktu_masuk         AS ""Waktu Masuk"",
            p.waktu_diambil       AS ""Waktu Diambil"",
            p.status_penitipan    AS ""Status""
        FROM penitipan p
        LEFT JOIN barang b
            ON p.id_barang = b.id_barang
        ORDER BY p.id_penitipan DESC";

                DataTable dt = new DataTable();

                using var da =
                    new NpgsqlDataAdapter(query, conn);

                da.Fill(dt);

                dgvLoker.DataSource = dt;

                dgvLoker.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgvLoker.ReadOnly = true;
                dgvLoker.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtIdPenitipan_TextChanged(
    object sender,
    EventArgs e)
        {
            CariPenitipan();
        }

        private void CariPenitipan()
        {
            try
            {
                using var conn =
                    DatabaseHelper.Instance.GetConnection();

                string query = @"
        SELECT
            p.id_penitipan      AS ""ID"",
            b.nama_barang       AS ""Nama Barang"",
            b.kategori_barang   AS ""Kategori"",
            p.nama_pemilik      AS ""Pemilik"",
            p.jumlah_barang     AS ""Jumlah"",
            p.waktu_masuk       AS ""Waktu Masuk"",
            p.waktu_diambil     AS ""Waktu Diambil"",
            p.status_penitipan  AS ""Status""
        FROM penitipan p
        LEFT JOIN barang b
            ON p.id_barang = b.id_barang
        WHERE CAST(p.id_penitipan AS TEXT)
            ILIKE @cari
        ORDER BY p.id_penitipan DESC";

                DataTable dt = new DataTable();

                using var cmd =
                    new NpgsqlCommand(query, conn);

                cmd.Parameters.AddWithValue(
                    "@cari",
                    "%" + txtIdPenitipan.Text + "%");

                using var da =
                    new NpgsqlDataAdapter(cmd);

                da.Fill(dt);

                dgvLoker.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

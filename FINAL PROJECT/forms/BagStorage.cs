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
using FINAL_PROJECT.Controllers;

namespace FINAL_PROJECT.forms
{
    public partial class BagStorage : Form
    {
        public BagStorage()
        {
            InitializeComponent();
            dgvPenitipan.CellContentClick +=
        dgvPenitipan_CellContentClick;
        }

        private void BagStorage_Load(object sender, EventArgs e)
        {
            //LoadSummary();
            //LoadGridBagStorage();
            LoadData();
            LoadStatistic();
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

        

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void txtIdPenitipan_TextChanged(
    object sender,
    EventArgs e)
        {
            PenitipanController controller =
                new PenitipanController();

            dgvPenitipan.DataSource =
                controller.Search(
                    txtIdPenitipan.Text);
        }

        

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }


        private void LoadData()
        {
            PenitipanController controller =
                new PenitipanController();

            dgvPenitipan.DataSource =
                controller.GetAll();

            if (!dgvPenitipan.Columns.Contains("Ambil"))
            {
                DataGridViewButtonColumn btn =
                    new DataGridViewButtonColumn();

                btn.Name = "Ambil";
                btn.HeaderText = "Ambil";
                btn.Text = "Ambil";

                btn.UseColumnTextForButtonValue = true;

                dgvPenitipan.Columns.Add(btn);
            }

            if (!dgvPenitipan.Columns.Contains("Delete"))
            {
                DataGridViewButtonColumn btnDelete =
                    new DataGridViewButtonColumn();

                btnDelete.Name = "Delete";
                btnDelete.HeaderText = "Delete";
                btnDelete.Text = "Delete";

                btnDelete.UseColumnTextForButtonValue = true;

                dgvPenitipan.Columns.Add(btnDelete);
            }

            dgvPenitipan.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;


        }

        private void btnTambahBarang_Click(
    object sender,
    EventArgs e)
        {
            inputpenitipan form =
                new inputpenitipan();

            if (form.ShowDialog() ==
                DialogResult.OK)
            {
                LoadData();
                LoadStatistic();
            }
        }



        private void LoadStatistic()
        {
            PenitipanController controller =
                new PenitipanController();

            var data =
                controller.GetStatistic();

            lblTotalPenitipan.Text =
                data.TotalPenitipan.ToString();

            lblDititipkan.Text =
                data.Dititipkan.ToString();

            lblJumlahDiambil.Text =
                data.Diambil.ToString();
        }




        private void dgvPenitipan_CellContentClick(
    object sender,
    DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            string namaKolom =
                dgvPenitipan.Columns[e.ColumnIndex]
                .Name;

            int idPenitipan =
                Convert.ToInt32(
                    dgvPenitipan.Rows[e.RowIndex]
                    .Cells["IdPenitipan"]
                    .Value);

            if (namaKolom == "Ambil")
            {
                AmbilBarang(idPenitipan);
            }

            if (namaKolom == "Delete")
            {
                DeletePenitipan(idPenitipan);
            }
        }


        private void DeletePenitipan(
    int idPenitipan)
        {
            DialogResult result =
                MessageBox.Show(
                    "Yakin ingin menghapus data penitipan?",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            try
            {
                PenitipanController controller =
                    new PenitipanController();

                controller.DeletePenitipan(
                    idPenitipan);

                MessageBox.Show(
                    "Data penitipan berhasil dihapus");

                LoadData();
                LoadStatistic();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message);
            }
        }




        private void AmbilBarang(
    int idPenitipan)
        {
            DialogResult result =
                MessageBox.Show(
                    "Barang sudah diambil?",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
                return;

            PenitipanController controller =
                new PenitipanController();

            controller.AmbilBarang(
                idPenitipan);

            MessageBox.Show(
                "Status berhasil diubah");

            LoadData();
            LoadStatistic();
        }

        private void LoadHistory()
        {
            PenitipanController controller =
                new PenitipanController();

            dgvPenitipan.DataSource =
                controller.GetHistory();

            dgvPenitipan.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void RiwayatPenitipan_Load(
    object sender,
    EventArgs e)
        {
            LoadHistory();
        }
    }
}

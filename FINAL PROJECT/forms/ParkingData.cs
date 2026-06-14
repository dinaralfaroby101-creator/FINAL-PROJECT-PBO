using FINAL_PROJECT.Controllers;
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



        // ==========================
        // LOAD DATA GRID
        // ==========================
        private void LoadParkingData()
        {
            ParkingDataController controller =
                new ParkingDataController();

            dataGridView1.DataSource =
                controller.GetAll();

            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        // ==========================
        // UPDATE CARD STATISTIK
        // ==========================
        private void UpdateStatistic()
        {
            ParkingDataController controller =
                new ParkingDataController();

            var data =
                controller.GetStatistic();

            label6.Text =
                data.TotalSlot.ToString();

            label9.Text =
                data.SlotKosong.ToString();

            label12.Text =
                data.SlotTerisi.ToString();

            label15.Text =
                data.SlotMaintenance.ToString();
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
            ParkingDataController controller =
                new ParkingDataController();

            dataGridView1.DataSource =
                controller.Search(
                    txtSearch.Text);
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

            ParkingDataController controller =
    new ParkingDataController();

            controller.Delete(id);

            LoadParkingData();
            UpdateStatistic();

            LoadParkingData();
            UpdateStatistic();
        }

        // ==========================
        // EDIT DATA
        // ==========================
        private void EditData(int id)
        {
            SLotParkir form =
                new SLotParkir(id);

            if (form.ShowDialog()
                == DialogResult.OK)
            {
                LoadParkingData();
                UpdateStatistic();
            }
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

        private void ParkingData_Load(
    object sender,
    EventArgs e)
        {
            LoadParkingData();
            UpdateStatistic();

            cmbArea.Items.Clear();

            cmbArea.Items.Add(
                "Semua Area");

            cmbArea.Items.Add(
                "Area A");

            cmbArea.Items.Add(
                "Area B");

            cmbArea.Items.Add(
                "Area C");

            cmbArea.SelectedIndex = 0;
        }

        private void cmbArea_SelectedIndexChanged(
    object sender,
    EventArgs e)
        {
            ParkingDataController controller =
                new ParkingDataController();

            if (cmbArea.Text ==
                "Semua Area")
            {
                dataGridView1.DataSource =
                    controller.GetAll();
            }
            else
            {
                string area =
                    cmbArea.Text
                    .Replace("Area ", "");

                dataGridView1.DataSource =
                    controller.GetByArea(area);
            }
        }
    }
}



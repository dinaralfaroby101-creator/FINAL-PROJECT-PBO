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
using FINAL_PROJECT.Controllers;

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



        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadDashboard();

            LoadDashboard();
            LoadArea();
        }

        private void LoadDashboard()
        {
            DashboardController controller =
                new DashboardController();

            var data =
                controller.GetDashboardSummary();

            lblParkingArea.Text =
                data.TotalArea.ToString();

            lblTotalSlot.Text =
                data.TotalSlot.ToString();

            lblTerisi.Text =
                data.SlotTerisi.ToString();

            lblTersedia.Text =
                data.SlotKosong.ToString();
        }


        private void LoadArea()
        {
            DashboardController controller =
                new DashboardController();

            var areaA =
                controller.GetAreaSummary("A");

            var areaB =
                controller.GetAreaSummary("B");

            var areaC =
                controller.GetAreaSummary("C");

            // Area A

            progressBarA.Maximum =
                areaA.TotalSlot;

            progressBarA.Value =
                areaA.Terisi;

            lblSlotA.Text =
                $"Slot {areaA.TotalSlot}";

            lblTerisiA.Text =
                $"Terisi {areaA.Terisi}";

            lblTersediaA.Text =
                $"Tersedia {areaA.Kosong}";

            lblPersenA.Text =
                areaA.Persentase + "%";


            // Area B

            progressBarB.Maximum =
                areaB.TotalSlot;

            progressBarB.Value =
                areaB.Terisi;

            lblSlotB.Text =
                $"Slot {areaB.TotalSlot}";

            lblTerisiB.Text =
                $"Terisi {areaB.Terisi}";

            lblTersediaB.Text =
                $"Tersedia {areaB.Kosong}";

            lblPersenB.Text =
                areaB.Persentase + "%";


            // Area C

            progressBarC.Maximum =
                areaC.TotalSlot;

            progressBarC.Value =
                areaC.Terisi;

            lblSlotC.Text =
                $"Slot {areaC.TotalSlot}";

            lblTerisiC.Text =
                $"Terisi {areaC.Terisi}";

            lblTersediaC.Text =
                $"Tersedia {areaC.Kosong}";

            lblPersenC.Text =
                areaC.Persentase + "%";
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}

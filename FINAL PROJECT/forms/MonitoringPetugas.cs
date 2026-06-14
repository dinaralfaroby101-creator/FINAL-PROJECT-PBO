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
    public partial class MonitoringPetugas : Form
    {
        public MonitoringPetugas()
        {
            InitializeComponent();
        }
        private void LoadMonitoring()
        {
            MonitoringController controller =
                new MonitoringController();

            var data =
                controller.GetMonitoringSlots();

            panel11.Controls.Clear();
            panel10.Controls.Clear();
            panelBus.Controls.Clear();

            foreach (var item in data)
            {
                Label lbl = new Label();

                lbl.Width = 70;
                lbl.Height = 40;

                lbl.TextAlign =
                    ContentAlignment.MiddleCenter;

                lbl.BorderStyle =
                    BorderStyle.FixedSingle;

                lbl.Text =
                    item.KodeSlot;

                bool terisi =
                    item.StatusSlot
                    .ToLower() == "terisi";

                lbl.BackColor =
                    terisi
                    ? Color.Red
                    : Color.LightGreen;

                string jenis =
                    item.JenisKendaraan
                    .ToLower();

                if (jenis == "motor")
                    panel11.Controls.Add(lbl);

                else if (jenis == "mobil")
                    panel10.Controls.Add(lbl);

                else if (jenis == "bus")
                    panelBus.Controls.Add(lbl);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            HistoryPetugas historyp = new HistoryPetugas();
            historyp.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            DashboardPetugas dashp = new DashboardPetugas();
            dashp.Show();
            this.Hide();
        }

        private void btnParkingdata_Click(object sender, EventArgs e)
        {
            ParkingData park = new ParkingData();
            park.Show();
            this.Hide();
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

        private void btnFinanceReport_Click(object sender, EventArgs e)
        {
            FinanceReport finance = new FinanceReport();
            finance.Show();
            this.Hide();
        }

        private void LoadGridMonitoring()
        {
            MonitoringController controller =
                new MonitoringController();

            dgvListMonitoring.DataSource =
                controller.GetMonitoringSlots();

            dgvListMonitoring.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvListMonitoring.ReadOnly = true;

            dgvListMonitoring.AllowUserToAddRows =
                false;
        }

        private void Monitoring_Load(object sender, EventArgs e)
        {
            LoadMonitoring();
            LoadGridMonitoring();
            LoadStatistic();
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadMonitoring();
            LoadGridMonitoring();

            LoadStatistic();
        }

        private void PanelMonitoring_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void LoadStatistic()
        {
            MonitoringController controller =
                new MonitoringController();

            var areaA =
                controller.GetAreaStatistic("A");

            var areaB =
                controller.GetAreaStatistic("B");

            var areaC =
                controller.GetAreaStatistic("C");

            lblAreaA.Text =
                areaA.TotalSlot.ToString();

            lblAreaAterisi.Text =
                areaA.SlotTerisi.ToString();

            lblAreaB.Text =
                areaB.TotalSlot.ToString();

            lblAreaBterisi.Text =
                areaB.SlotTerisi.ToString();

            lblAreaC.Text =
                areaC.TotalSlot.ToString();

            lblAreaCterisi.Text =
                areaC.SlotTerisi.ToString();
        }



        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblAreaAterisi_Click(object sender, EventArgs e)
        {

        }

        private void lblAreaBterisi_Click(object sender, EventArgs e)
        {

        }

        private void lblAreaCterisi_Click(object sender, EventArgs e)
        {

        }

        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVehicleData_Click(object sender, EventArgs e)
        {
            VehicleData vd = new VehicleData();
            vd.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
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
    }

}

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
    public partial class VehicleData : Form
    {
        public VehicleData()
        {
            InitializeComponent();
        }

        private void VehicleData_Load(
    object sender,
    EventArgs e)
        {
            LoadVehicleData();
            LoadStatistic();
        }


        private void LoadStatistic()
        {
            VehicleController controller =
                new VehicleController();

            lblTotKendaraan.Text =
                controller.GetTotalVehicle()
                .ToString();

            lblTotalMotor.Text =
                controller.GetTotalMotor()
                .ToString();

            lblTotalMobil.Text =
                controller.GetTotalMobil()
                .ToString();

            lblTotalBus.Text =
                controller.GetTotalBus()
                .ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnMonitoringPetugas_Click(object sender, EventArgs e)
        {
            MonitoringPetugas monitorp = new MonitoringPetugas();
            monitorp.Show();
            this.Hide();
        }

        private void panelSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVehicleEntry_Click(object sender, EventArgs e)
        {
            vechileentry vde = new vechileentry();
            vde.Show();
            this.Hide();
        }

        private void btnVehicleExit_Click(object sender, EventArgs e)
        {
            vehicleexit vdx = new vehicleexit();
            vdx.Show();
            this.Hide();
        }

        private void btnVehicleData_Click(object sender, EventArgs e)
        {

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

        private void btnHistoryPetugas_Click(object sender, EventArgs e)
        {
            HistoryPetugas historyp = new HistoryPetugas();
            historyp.Show();
            this.Hide();
        }

        private void btnDashboardPetugas_Click(object sender, EventArgs e)
        {
            DashboardPetugas dashp = new DashboardPetugas();
            dashp.Show();
            this.Hide();
        }



        private void LoadVehicleData()
        {
            VehicleController controller =
                new VehicleController();

            gdvVehicleData.DataSource =
                controller.GetAllVehicle();

            gdvVehicleData.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            gdvVehicleData.ReadOnly = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            VehicleController controller =
        new VehicleController();

            gdvVehicleData.DataSource =
                controller.SearchVehicle(
                    textBox1.Text);
        }

        private void gdvVehicleData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

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
    public partial class VehicleData : Form
    {
        public VehicleData()
        {
            InitializeComponent();
        }

        private void VehicleData_Load(object sender, EventArgs e)
        {

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

        private void PanelArea_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

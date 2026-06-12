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
    public partial class HistoryPetugas : Form
    {
        public HistoryPetugas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FinanceReport finance = new FinanceReport();
            finance.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            DashboardPetugas dashp = new DashboardPetugas();
            dashp.Show();
            this.Hide();
        }

        private void btnParkingData_Click(object sender, EventArgs e)
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

        private void btnMonitoring_Click(object sender, EventArgs e)
        {
            MonitoringPetugas monitorp = new MonitoringPetugas();
            monitorp.Show();
            this.Hide();
        }

        private void History_Load(object sender, EventArgs e)
        {
            dgvHistory.Rows.Add(
                "c1921AC",
                "C",
                "Motor",
                "789180",
                "15.00",
                "16.00",
                "1 jam",
                "Rp3000",
                "QRIS",
                "✔"
            );

            dgvHistory.Rows.Add(
                "b1920AC",
                "B",
                "Mobil",
                "789180",
                "15.30",
                "18.00",
                "2 jam",
                "Rp12000",
                "QRIS",
                "✔"
            );
        }

        private void dgvHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

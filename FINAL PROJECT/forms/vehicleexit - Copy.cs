using FINAL_PROJECT.forms;
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
    public partial class vehicleexit : Form
    {
        public vehicleexit()
        {
            InitializeComponent();
        }

        private void vehicleexit_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblBiayaTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblPetugasTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnVehicleEntry_Click(object sender, EventArgs e)
        {
            vechileentry vde = new vechileentry();
            vde.Show();
            this.Hide();
        }

        private void btnVehicleData_Click(object sender, EventArgs e)
        {
            VehicleData vd = new VehicleData();
            vd.Show();
            this.Hide();
        }
    }
}

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
    public partial class vechileentry : Form
    {
        public vechileentry()
        {
            InitializeComponent();
        }

        private void cboJenisKendaraan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void dtpMasuk_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblKodeSlot_Click(object sender, EventArgs e)
        {

        }

        private void txtPlatNomor_TextChanged(object sender, EventArgs e)
        {

        }

        private void vechileentry_Load(object sender, EventArgs e)
        {

        }

        private void btnVehicleData_Click(object sender, EventArgs e)
        {
            VehicleData vd = new VehicleData();
            vd.Show();
            this.Hide();
        }

        private void btnVehicleExit_Click(object sender, EventArgs e)
        {
            vehicleexit vdx = new vehicleexit();
            vdx.Show();
            this.Hide();
        }
    }
}

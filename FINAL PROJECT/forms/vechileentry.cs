using FINAL_PROJECT.Controllers;
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

        private void vechileentry_Load(
                        object sender,
                        EventArgs e)
        {
            cboJenisKendaraan.Items.Clear();

            cboJenisKendaraan.Items.Add("motor");
            cboJenisKendaraan.Items.Add("mobil");
            cboJenisKendaraan.Items.Add("bus");

            cboAreaParkir.Items.Clear();

            cboAreaParkir.Items.Add("A");
            cboAreaParkir.Items.Add("B");
            cboAreaParkir.Items.Add("C");

            cboJenisKendaraan.SelectedIndex = 0;
            cboAreaParkir.SelectedIndex = 0;
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

        private void btnSimpan_Click(
    object sender,
    EventArgs e)
        {
            try
            {
                VehicleEntryController controller =
                    new VehicleEntryController();

                string slot =
                    controller.GetAvailableSlot(
                        cboAreaParkir.Text);

                if (string.IsNullOrEmpty(slot))
                {
                    MessageBox.Show(
                        "Slot parkir penuh!");
                    return;
                }

                int idMerk =
                    controller.GetOrCreateMerk(
                        txtMerkKendaraan.Text);

                int idKendaraan =
                    controller.GetOrCreateVehicle(
                        txtPlatNomor.Text,
                        cboJenisKendaraan.Text,
                        idMerk);

                // sementara pakai ID petugas tetap
                int idPetugas = 4;

                controller.CreateTransaction(
                    txtPlatNomor.Text,
                    slot,
                    idPetugas);

                MessageBox.Show(
                    "Kendaraan berhasil masuk.\n" +
                    "Slot : " + slot);

                txtPlatNomor.Clear();
                txtMerkKendaraan.Clear();

                cboJenisKendaraan.SelectedIndex = 0;
                cboAreaParkir.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            VehicleData vd =
        new VehicleData();

            vd.Show();

            this.Hide();
        }
    }

}

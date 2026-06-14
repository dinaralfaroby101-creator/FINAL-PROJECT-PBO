using FINAL_PROJECT.Controllers;
using FINAL_PROJECT.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_PROJECT
{
    public partial class vehicleexit : Form
    {
        private int _idTransaksi;

        public vehicleexit()
        {
            InitializeComponent();
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


        private void btnCari_Click(
    object sender,
    EventArgs e)
        {
            VehicleExitController controller =
                new VehicleExitController();

            var data =
                controller.GetVehicleInfo(
                    txtPlatNoKendaraan.Text);

            if (data == null)
            {
                MessageBox.Show(
                    "Kendaraan tidak ditemukan!");

                return;
            }

            _idTransaksi =
                 data.IdTransaksi;

            lblPlatNomor.Text =
                data.PlatNomor;

            lblMasuk.Text =
                data.WaktuMasuk
                .ToString("dd/MM/yyyy HH:mm");

            lblDurasi.Text =
                data.DurasiMenit + " menit";

            lblSlot.Text =
                data.KodeSlot;

            // nanti kita ganti label1
            lblPetugas.Text =
                data.NamaPetugas;

            string area =
                data.KodeSlot.Substring(0, 1);

            lblArea.Text =
                area;

            lblJenisArea.Text =
                $"Area {area} ({data.JenisKendaraan})";
        }



        private void vehicleexit_Load(
    object sender,
    EventArgs e)
        {
            cboMetodePembayaran.Items.Clear();

            cboMetodePembayaran.Items.Add("QRIS");
            cboMetodePembayaran.Items.Add("E-Wallet");
            cboMetodePembayaran.Items.Add("Debit");

            cboMetodePembayaran.SelectedIndex = 0;
        }



        private int GetMetodeId()
        {
            switch (
                cboMetodePembayaran.Text)
            {
                case "QRIS":
                    return 1;

                case "E-Wallet":
                    return 2;

                case "Debit":
                    return 3;

                default:
                    return 1;
            }
        }



        private void btnKonfirmasi_Click(
    object sender,
    EventArgs e)
        {
            try
            {
                if (_idTransaksi == 0)
                {
                    MessageBox.Show(
                        "Cari kendaraan terlebih dahulu!");

                    return;
                }

                VehicleExitController controller =
                    new VehicleExitController();

                decimal biaya =
                    controller.ExitVehicle(
                        _idTransaksi,
                        GetMetodeId());

                lblBiaya.Text =
                    "Rp " +
                    biaya.ToString("N0");

                MessageBox.Show(
                    "Kendaraan berhasil keluar\n" +
                    "Biaya : Rp " +
                    biaya.ToString("N0"));

                _idTransaksi = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

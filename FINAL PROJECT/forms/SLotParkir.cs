using FINAL_PROJECT.Controllers;
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

namespace FINAL_PROJECT.forms
{
    public partial class SLotParkir : Form
    {

        public SLotParkir()
        {
            InitializeComponent();
        }

        private void SLotParkir_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void btnSimpan_Click_1(
        object sender,
        EventArgs e)
        {
            try
            {
                SlotParkirController controller =
                    new SlotParkirController();

                bool berhasil =
                    controller.Insert(
                        txtKode.Text,
                        cmbStatus.Text.ToLower());

                if (berhasil)
                {
                    MessageBox.Show(
                        "Data berhasil disimpan");

                    DialogResult =
                        DialogResult.OK;

                    Close();
                }
            }
            catch (PostgresException ex)
            {
                if (ex.SqlState == "23505")
                {
                    MessageBox.Show(
                        "Slot parkir sudah tersedia!",
                        "Peringatan",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message);
            }
        }
        private void btnBatal_Click(
        object sender,
        EventArgs e)
        {
            Close();
        }
    }
}
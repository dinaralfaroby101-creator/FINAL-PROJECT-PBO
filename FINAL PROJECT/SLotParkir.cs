using FINAL_PROJECT.Database;
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

namespace FINAL_PROJECT
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
        private void btnSimpan_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (var conn = DatabaseHelper.Instance.GetConnection())
                {
                    string query =
                        @"INSERT INTO slot_parkir
                        (
                            kode_slot,
                            status_slot
                        )
                        VALUES
                        (
                            @kode,
                            @status::status_slot_enum
                        )";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                             "@kode",
                             txtKode.Text);

                        cmd.Parameters.AddWithValue(
                            "@status",
                            cmbStatus.Text.ToLower());

                        // INI YANG KURANG
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data berhasil disimpan");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
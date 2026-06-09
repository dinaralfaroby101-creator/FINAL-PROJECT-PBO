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

namespace FINAL_PROJECT.forms
{
    public partial class inputpenitipan : Form
    {
        public inputpenitipan()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                using var conn =
                    DatabaseHelper.Instance.GetConnection();

                // 1. Simpan barang dulu
                string queryBarang = @"
        INSERT INTO barang
        (
            nama_barang,
            kategori_barang
        )
        VALUES
        (
            @nama_barang,
            @kategori_barang
        )
        RETURNING id_barang;";

                using var cmdBarang =
                    new NpgsqlCommand(queryBarang, conn);

                cmdBarang.Parameters.AddWithValue(
                    "@nama_barang",
                    txtNamaBarang.Text);

                cmdBarang.Parameters.AddWithValue(
                    "@kategori_barang",
                    txtKategoriBarang.Text);

                int idBarang =
                    Convert.ToInt32(
                        cmdBarang.ExecuteScalar());

                // 2. Simpan penitipan
                string queryPenitipan = @"
        INSERT INTO penitipan
        (
            id_admin,
            id_barang,
            nama_pemilik,
            jumlah_barang,
            waktu_masuk,
            status_penitipan
        )
        VALUES
        (
            @admin,
            @barang,
            @pemilik,
            @jumlah,
            NOW(),
            'dititipkan'
        );";

                using var cmd =
                    new NpgsqlCommand(queryPenitipan, conn);

                cmd.Parameters.AddWithValue("@admin", 1);

                cmd.Parameters.AddWithValue(
                    "@barang",
                    idBarang);

                cmd.Parameters.AddWithValue(
                    "@pemilik",
                    txtNamaPemilik.Text);

                cmd.Parameters.AddWithValue(
                    "@jumlah",
                    Convert.ToInt32(txtJumlahBarang.Text));

                cmd.ExecuteNonQuery();

                MessageBox.Show(
                    "Data penitipan berhasil disimpan");

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

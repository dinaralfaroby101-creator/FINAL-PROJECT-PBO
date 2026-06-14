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

        private int _idSlot;

        public SLotParkir()
        {
            InitializeComponent();
        }

        public SLotParkir(int idSlot)
        {
            InitializeComponent();

            _idSlot = idSlot;

            LoadDataSlot();
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
                using var conn =
                    DatabaseHelper.Instance.GetConnection();

                string query;

                if (_idSlot > 0)
                {
                    query = @"
            UPDATE slot_parkir
            SET
                kode_slot=@kode,
                status_slot=
                @status::status_slot_enum
            WHERE id_slot=@id";
                }
                else
                {
                    query = @"
            INSERT INTO slot_parkir
            (
                kode_slot,
                status_slot
            )
            VALUES
            (
                @kode,
                @status::status_slot_enum
            )";
                }

                using var cmd =
                    new NpgsqlCommand(query, conn);

                cmd.Parameters.AddWithValue(
                    "@kode",
                    txtKode.Text);

                cmd.Parameters.AddWithValue(
                    "@status",
                    cmbStatus.Text.ToLower());

                if (_idSlot > 0)
                {
                    cmd.Parameters.AddWithValue(
                        "@id",
                        _idSlot);
                }

                cmd.ExecuteNonQuery();

                MessageBox.Show(
                    "Data berhasil disimpan");

                DialogResult =
                    DialogResult.OK;

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message);
            }
        }

            
        

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void LoadDataSlot()
        {
            using var conn =
                DatabaseHelper.Instance.GetConnection();

            string sql = @"
        SELECT *
        FROM slot_parkir
        WHERE id_slot=@id";

            using var cmd =
                new NpgsqlCommand(sql, conn);

            cmd.Parameters.AddWithValue(
                "@id",
                _idSlot);

            using var rd =
                cmd.ExecuteReader();

            if (rd.Read())
            {
                txtKode.Text =
                    rd["kode_slot"].ToString();

                cmbStatus.Text =
                    rd["status_slot"].ToString();
            }
        }
    }
}
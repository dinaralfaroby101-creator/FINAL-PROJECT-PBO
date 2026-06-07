using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using FINAL_PROJECT.Database;

namespace FINAL_PROJECT
{
    public partial class InputUser_ : Form
    {
        public InputUser_()
        {
            InitializeComponent();
        }

        private void lblInputUser_Click(object sender, EventArgs e)
        {

        }

        private void txtNamaUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = DatabaseHelper.Instance.GetConnection())
                {
                    string query =
                    @"INSERT INTO users
            (
                fullname,
                username,
                password,
                role,
                status
            )
            VALUES
            (
                @fullname,
                @username,
                @password,
                @role,
                @status
            )";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@fullname", txtNamaUser.Text);
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                        cmd.Parameters.AddWithValue("@role", cmbRole.Text);
                        cmd.Parameters.AddWithValue("@status", "Tidak Aktif");

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("User berhasil ditambahkan");

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

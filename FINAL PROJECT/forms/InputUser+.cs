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
using FINAL_PROJECT.Data;

namespace FINAL_PROJECT.forms

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
                    string query = @"
            INSERT INTO users
            (
                username,
                password_akun,
                nama_lengkap,
                role,
                status_user
            )
            VALUES
            (
                @username,
                @password,
                @nama,
                @role::role_user_enum,
                @status::status_user_enum
            )";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username",
                                                    txtUsername.Text);
                        cmd.Parameters.AddWithValue("@username",
                            txtUsername.Text);

                        cmd.Parameters.AddWithValue("@password",
                            txtPassword.Text);

                        cmd.Parameters.AddWithValue("@nama",
                            txtNamaUser.Text);

                        cmd.Parameters.AddWithValue("@role",
                            cmbRole.Text.ToLower());

                        cmd.Parameters.AddWithValue("@status",
                            "Offline");


                        MessageBox.Show(
    "cmbRole.Text = [" + cmbRole.Text + "]"
);
                        MessageBox.Show(
    "Lower = [" + cmbRole.Text.ToLower() + "]"
);
                        cmd.ExecuteNonQuery();

                    }
                }

                MessageBox.Show("User berhasil ditambahkan");


                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());


            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

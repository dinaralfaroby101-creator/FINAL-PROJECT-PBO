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

        private int _idUser = 0;
    
        public InputUser_()
        {
            InitializeComponent();
        }

        public InputUser_(int idUser)
        {
            InitializeComponent();

            _idUser = idUser;

            LoadUser();
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

        private void btnSimpan_Click(
    object sender,
    EventArgs e)
        {
            try
            {
                if (
                    string.IsNullOrWhiteSpace(
                        txtNamaUser.Text)
                    ||
                    string.IsNullOrWhiteSpace(
                        txtUsername.Text)
                    ||
                    string.IsNullOrWhiteSpace(
                        txtPassword.Text)
                    ||
                    cmbRole.SelectedIndex == -1
                )
                {
                    MessageBox.Show(
                        "Semua data wajib diisi");

                    return;
                }

                using (var conn =
                    DatabaseHelper.Instance.GetConnection())
                {
                    string query;

                    if (_idUser == 0)
                    {
                        query = @"
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
                    }
                    else
                    {
                        query = @"
                UPDATE users
                SET
                    username = @username,
                    password_akun = @password,
                    nama_lengkap = @nama,
                    role = @role::role_user_enum
                WHERE id_user = @id";
                    }

                    using (var cmd =
                        new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@username",
                            txtUsername.Text);

                        cmd.Parameters.AddWithValue(
                            "@password",
                            txtPassword.Text);

                        cmd.Parameters.AddWithValue(
                            "@nama",
                            txtNamaUser.Text);

                        cmd.Parameters.AddWithValue(
                            "@role",
                            cmbRole.Text.ToLower());

                        if (_idUser == 0)
                        {
                            cmd.Parameters.AddWithValue(
                                "@status",
                                "Offline");
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(
                                "@id",
                                _idUser);
                        }

                        cmd.ExecuteNonQuery();
                    }
                }

                if (_idUser == 0)
                {
                    MessageBox.Show(
                        "User berhasil ditambahkan");
                }
                else
                {
                    MessageBox.Show(
                        "User berhasil diupdate");
                }

                this.DialogResult =
                    DialogResult.OK;

                this.Close();
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




        private void LoadUser()
        {
            using (var conn =
                DatabaseHelper.Instance.GetConnection())
            {
                string query = @"
            SELECT *
            FROM users
            WHERE id_user=@id";

                using (var cmd =
                    new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue(
                        "@id",
                        _idUser);

                    using (var rd =
                        cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            txtNamaUser.Text =
                                rd["nama_lengkap"].ToString();

                            txtUsername.Text =
                                rd["username"].ToString();

                            txtPassword.Text =
                                rd["password_akun"].ToString();

                            cmbRole.Text =
                                rd["role"].ToString();
                        }
                    }
                }
            }

            lbl.Text = "Edit User";
        }
    }
}

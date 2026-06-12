using FINAL_PROJECT.Data;
using Npgsql;// bukan SPARK.Database

namespace FINAL_PROJECT.forms
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bool ok = DatabaseHelper.Instance.TestConnection();
            if (ok)
                MessageBox.Show("Koneksi berhasil!", "SPARK",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Gagal konek ke database!\nCek konfigurasi di DatabaseHelper.cs",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }
        bool showPassword = false;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (!showPassword)
            {
                txtPassword.UseSystemPasswordChar = false;

                icon_Mata.BackgroundImage = Properties.Resources.eye_open;
                showPassword = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;

                icon_Mata.BackgroundImage = Properties.Resources.eye_close;
                showPassword = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using var conn =
                    DatabaseHelper.Instance.GetConnection();

                string sql = @"
        SELECT
            role,
            nama_lengkap
        FROM users
        WHERE username = @username
        AND password_akun = @password";

                using var cmd =
                    new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue(
                    "@username",
                    txtUsername.Text.Trim());

                cmd.Parameters.AddWithValue(
                    "@password",
                    txtPassword.Text.Trim());

                using var reader =
                    cmd.ExecuteReader();

                if (!reader.Read())
                {
                    MessageBox.Show(
                        "Username atau Password salah!",
                        "Login",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                string role =
                    reader["role"].ToString();

                string nama =
                    reader["nama_lengkap"].ToString();

                reader.Close();

                // Update Last Login
                string updateLogin = @"
        UPDATE users
        SET last_login = NOW()
        WHERE username = @username";

                using var cmdUpdate =
                    new NpgsqlCommand(updateLogin, conn);

                cmdUpdate.Parameters.AddWithValue(
                    "@username",
                    txtUsername.Text.Trim());

                cmdUpdate.ExecuteNonQuery();

                // Update Status User
                string updateStatus = @"
        UPDATE users
        SET status_user = 'Active'
        WHERE username = @username";

                using var cmdStatus =
                    new NpgsqlCommand(updateStatus, conn);

                cmdStatus.Parameters.AddWithValue(
                    "@username",
                    txtUsername.Text.Trim());

                cmdStatus.ExecuteNonQuery();

                // Login sesuai role
                if (role == "admin")
                {
                    Dashboard dashboard =
                        new Dashboard();

                    dashboard.Show();
                    this.Hide();
                }
                else if (role == "petugas")
                {
                    DashboardPetugas petugas =
                        new DashboardPetugas();

                    petugas.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(
                        "Role tidak dikenali!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


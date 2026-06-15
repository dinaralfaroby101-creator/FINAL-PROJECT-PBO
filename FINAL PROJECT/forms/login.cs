using FINAL_PROJECT.Data;
using Npgsql;
using FINAL_PROJECT.Controllers;
using FINAL_PROJECT.Models;
using FINAL_PROJECT;

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
            if (ok) ;

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
                LoginController controller =
                    new LoginController();

                User user =
                    controller.Login(
                        txtUsername.Text.Trim(),
                        txtPassword.Text.Trim());

                if (user == null)
                {
                    MessageBox.Show(
                        "Username atau Password salah!",
                        "Login",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // SIMPAN SESSION USER LOGIN
                Session.IdUser = user.IdUser;
                Session.Username = user.Username;
                Session.NamaLengkap = user.NamaLengkap;
                Session.Role = user.GetRole();

                // PINDAH FORM SESUAI ROLE
                if (user is Admin)
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else if (user is Petugas)
                {
                    DashboardPetugas petugas = new DashboardPetugas();
                    petugas.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


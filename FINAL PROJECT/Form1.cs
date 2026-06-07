using FINAL_PROJECT.Database;   // bukan SPARK.Database

namespace FINAL_PROJECT
{
    public partial class Form1 : Form
    {
        public Form1()
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
            if (txtUsername.Text == "admin" && txtPassword.Text == "123")
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password salah!");
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


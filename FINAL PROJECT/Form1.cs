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
    }
}


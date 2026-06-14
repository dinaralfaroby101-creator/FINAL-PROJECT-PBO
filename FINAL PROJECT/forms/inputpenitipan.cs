using FINAL_PROJECT.Controllers;
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
    public partial class inputpenitipan : Form
    {
        public inputpenitipan()
        {
            InitializeComponent();
            btnBatal.Click += btnBatal_Click;
        }

        private void btnSimpan_Click(
    object sender,
    EventArgs e)
        {
            PenitipanController controller =
                new PenitipanController();

            controller.TambahPenitipan(
                txtNamaBarang.Text,
                txtKategoriBarang.Text,
                txtNamaPemilik.Text,
                Convert.ToInt32(
                    txtJumlahBarang.Text));

            MessageBox.Show(
                "Data berhasil disimpan");

            DialogResult = DialogResult.OK;

            Close();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

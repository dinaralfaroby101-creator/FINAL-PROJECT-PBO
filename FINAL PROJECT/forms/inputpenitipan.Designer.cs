namespace FINAL_PROJECT.forms

{
    partial class inputpenitipan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNamaPemilik = new TextBox();
            txtKategoriBarang = new TextBox();
            btnBatal = new Button();
            btnSimpan = new Button();
            lblArea = new Label();
            lblStatus = new Label();
            lblKendaraan = new Label();
            lbl = new Label();
            txtNamaBarang = new TextBox();
            txtJumlahBarang = new TextBox();
            SuspendLayout();
            // 
            // txtNamaPemilik
            // 
            txtNamaPemilik.BackColor = SystemColors.Window;
            txtNamaPemilik.Location = new Point(966, 250);
            txtNamaPemilik.Margin = new Padding(4, 5, 4, 5);
            txtNamaPemilik.Name = "txtNamaPemilik";
            txtNamaPemilik.Size = new Size(181, 31);
            txtNamaPemilik.TabIndex = 69;
            // 
            // txtKategoriBarang
            // 
            txtKategoriBarang.BackColor = SystemColors.Window;
            txtKategoriBarang.Location = new Point(966, 164);
            txtKategoriBarang.Margin = new Padding(4, 5, 4, 5);
            txtKategoriBarang.Name = "txtKategoriBarang";
            txtKategoriBarang.Size = new Size(181, 31);
            txtKategoriBarang.TabIndex = 68;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.Red;
            btnBatal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBatal.Location = new Point(988, 662);
            btnBatal.Margin = new Padding(4, 5, 4, 5);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(161, 55);
            btnBatal.TabIndex = 66;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.Chartreuse;
            btnSimpan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpan.Location = new Point(772, 662);
            btnSimpan.Margin = new Padding(4, 5, 4, 5);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(161, 55);
            btnSimpan.TabIndex = 65;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += this.btnSimpan_Click;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.BackColor = SystemColors.ActiveCaption;
            lblArea.Font = new Font("Dubai", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblArea.ForeColor = Color.Black;
            lblArea.Location = new Point(773, 161);
            lblArea.Margin = new Padding(4, 0, 4, 0);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(170, 39);
            lblArea.TabIndex = 64;
            lblArea.Text = "Kategori Barang";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = SystemColors.ActiveCaption;
            lblStatus.Font = new Font("Dubai", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.Black;
            lblStatus.Location = new Point(773, 326);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(158, 39);
            lblStatus.TabIndex = 63;
            lblStatus.Text = "Jumlah Barang";
            // 
            // lblKendaraan
            // 
            lblKendaraan.AutoSize = true;
            lblKendaraan.BackColor = SystemColors.ActiveCaption;
            lblKendaraan.Font = new Font("Dubai", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKendaraan.ForeColor = Color.Black;
            lblKendaraan.Location = new Point(773, 246);
            lblKendaraan.Margin = new Padding(4, 0, 4, 0);
            lblKendaraan.Name = "lblKendaraan";
            lblKendaraan.Size = new Size(147, 39);
            lblKendaraan.TabIndex = 62;
            lblKendaraan.Text = "Nama Pemilik";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.BackColor = SystemColors.ActiveCaption;
            lbl.Font = new Font("Dubai", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl.ForeColor = Color.Black;
            lbl.Location = new Point(773, 84);
            lbl.Margin = new Padding(4, 0, 4, 0);
            lbl.Name = "lbl";
            lbl.Size = new Size(146, 39);
            lbl.TabIndex = 61;
            lbl.Text = "Nama Barang";
            // 
            // txtNamaBarang
            // 
            txtNamaBarang.BackColor = SystemColors.Window;
            txtNamaBarang.Location = new Point(966, 84);
            txtNamaBarang.Margin = new Padding(4, 5, 4, 5);
            txtNamaBarang.Name = "txtNamaBarang";
            txtNamaBarang.Size = new Size(181, 31);
            txtNamaBarang.TabIndex = 60;
            // 
            // txtJumlahBarang
            // 
            txtJumlahBarang.BackColor = SystemColors.Window;
            txtJumlahBarang.Location = new Point(966, 330);
            txtJumlahBarang.Margin = new Padding(4, 5, 4, 5);
            txtJumlahBarang.Name = "txtJumlahBarang";
            txtJumlahBarang.Size = new Size(181, 31);
            txtJumlahBarang.TabIndex = 70;
            // 
            // inputpenitipan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 801);
            Controls.Add(txtJumlahBarang);
            Controls.Add(txtNamaPemilik);
            Controls.Add(txtKategoriBarang);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Controls.Add(lblArea);
            Controls.Add(lblStatus);
            Controls.Add(lblKendaraan);
            Controls.Add(lbl);
            Controls.Add(txtNamaBarang);
            Name = "inputpenitipan";
            Text = "inputpenitipan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNamaPemilik;
        private TextBox txtKategoriBarang;
        private Button btnBatal;
        private Button btnSimpan;
        private Label lblArea;
        private Label lblStatus;
        private Label lblKendaraan;
        private Label lbl;
        private TextBox txtNamaBarang;
        private TextBox txtJumlahBarang;
    }
}
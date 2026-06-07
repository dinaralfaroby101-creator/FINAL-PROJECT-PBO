namespace FINAL_PROJECT
{
    partial class SLotParkir
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
            lblMasuk = new Label();
            cmsJenisKendaraan = new ComboBox();
            dtpMasuk = new DateTimePicker();
            txtPlatNomer = new TextBox();
            lblPlatNomer = new Label();
            lblArea = new Label();
            lblStatus = new Label();
            lblKendaraan = new Label();
            lblKodeSlot = new Label();
            txtKode = new TextBox();
            btnBatal = new Button();
            btnSimpan = new Button();
            lblInputSLot = new Label();
            cmbArea = new ComboBox();
            cmbStatus = new ComboBox();
            SuspendLayout();
            // 
            // lblMasuk
            // 
            lblMasuk.AutoSize = true;
            lblMasuk.BackColor = SystemColors.ActiveCaption;
            lblMasuk.Font = new Font("Dubai", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMasuk.ForeColor = Color.Black;
            lblMasuk.Location = new Point(758, 593);
            lblMasuk.Margin = new Padding(4, 0, 4, 0);
            lblMasuk.Name = "lblMasuk";
            lblMasuk.Size = new Size(149, 39);
            lblMasuk.TabIndex = 36;
            lblMasuk.Text = "Waktu Masuk";
            // 
            // cmsJenisKendaraan
            // 
            cmsJenisKendaraan.FormattingEnabled = true;
            cmsJenisKendaraan.Items.AddRange(new object[] { "Bus", "Mobil", "Motor" });
            cmsJenisKendaraan.Location = new Point(951, 308);
            cmsJenisKendaraan.Margin = new Padding(4, 5, 4, 5);
            cmsJenisKendaraan.Name = "cmsJenisKendaraan";
            cmsJenisKendaraan.Size = new Size(183, 33);
            cmsJenisKendaraan.TabIndex = 35;
            cmsJenisKendaraan.SelectedIndexChanged += comboStatus_SelectedIndexChanged;
            // 
            // dtpMasuk
            // 
            dtpMasuk.Location = new Point(951, 597);
            dtpMasuk.Margin = new Padding(4, 5, 4, 5);
            dtpMasuk.Name = "dtpMasuk";
            dtpMasuk.Size = new Size(181, 31);
            dtpMasuk.TabIndex = 33;
            dtpMasuk.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // txtPlatNomer
            // 
            txtPlatNomer.BackColor = SystemColors.Window;
            txtPlatNomer.Location = new Point(951, 518);
            txtPlatNomer.Margin = new Padding(4, 5, 4, 5);
            txtPlatNomer.Name = "txtPlatNomer";
            txtPlatNomer.Size = new Size(181, 31);
            txtPlatNomer.TabIndex = 30;
            // 
            // lblPlatNomer
            // 
            lblPlatNomer.AutoSize = true;
            lblPlatNomer.BackColor = SystemColors.ActiveCaption;
            lblPlatNomer.Font = new Font("Dubai", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlatNomer.ForeColor = Color.Black;
            lblPlatNomer.Location = new Point(758, 518);
            lblPlatNomer.Margin = new Padding(4, 0, 4, 0);
            lblPlatNomer.Name = "lblPlatNomer";
            lblPlatNomer.Size = new Size(125, 39);
            lblPlatNomer.TabIndex = 29;
            lblPlatNomer.Text = "Plat Nomer";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.BackColor = SystemColors.ActiveCaption;
            lblArea.Font = new Font("Dubai", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblArea.ForeColor = Color.Black;
            lblArea.Location = new Point(758, 217);
            lblArea.Margin = new Padding(4, 0, 4, 0);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(62, 39);
            lblArea.TabIndex = 27;
            lblArea.Text = "Area";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = SystemColors.ActiveCaption;
            lblStatus.Font = new Font("Dubai", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.Black;
            lblStatus.Location = new Point(758, 382);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(79, 39);
            lblStatus.TabIndex = 25;
            lblStatus.Text = "Status";
            // 
            // lblKendaraan
            // 
            lblKendaraan.AutoSize = true;
            lblKendaraan.BackColor = SystemColors.ActiveCaption;
            lblKendaraan.Font = new Font("Dubai", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKendaraan.ForeColor = Color.Black;
            lblKendaraan.Location = new Point(758, 302);
            lblKendaraan.Margin = new Padding(4, 0, 4, 0);
            lblKendaraan.Name = "lblKendaraan";
            lblKendaraan.Size = new Size(173, 39);
            lblKendaraan.TabIndex = 23;
            lblKendaraan.Text = "Jenis Kendaraan";
            // 
            // lblKodeSlot
            // 
            lblKodeSlot.AutoSize = true;
            lblKodeSlot.BackColor = SystemColors.ActiveCaption;
            lblKodeSlot.Font = new Font("Dubai", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKodeSlot.ForeColor = Color.Black;
            lblKodeSlot.Location = new Point(758, 140);
            lblKodeSlot.Margin = new Padding(4, 0, 4, 0);
            lblKodeSlot.Name = "lblKodeSlot";
            lblKodeSlot.Size = new Size(117, 39);
            lblKodeSlot.TabIndex = 22;
            lblKodeSlot.Text = "Kode SLot";
            // 
            // txtKode
            // 
            txtKode.BackColor = SystemColors.Window;
            txtKode.Location = new Point(951, 140);
            txtKode.Margin = new Padding(4, 5, 4, 5);
            txtKode.Name = "txtKode";
            txtKode.Size = new Size(181, 31);
            txtKode.TabIndex = 21;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.Red;
            btnBatal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBatal.Location = new Point(973, 718);
            btnBatal.Margin = new Padding(4, 5, 4, 5);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(161, 55);
            btnBatal.TabIndex = 38;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.Chartreuse;
            btnSimpan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpan.Location = new Point(757, 718);
            btnSimpan.Margin = new Padding(4, 5, 4, 5);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(161, 55);
            btnSimpan.TabIndex = 37;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click_1;
            // 
            // lblInputSLot
            // 
            lblInputSLot.AutoSize = true;
            lblInputSLot.Font = new Font("Palatino Linotype", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInputSLot.Location = new Point(763, 33);
            lblInputSLot.Margin = new Padding(4, 0, 4, 0);
            lblInputSLot.Name = "lblInputSLot";
            lblInputSLot.Size = new Size(341, 56);
            lblInputSLot.TabIndex = 39;
            lblInputSLot.Text = "Input Slot Parkir";
            lblInputSLot.Click += label1_Click;
            // 
            // cmbArea
            // 
            cmbArea.FormattingEnabled = true;
            cmbArea.Items.AddRange(new object[] { "Area A", "Area B", "Area C" });
            cmbArea.Location = new Point(951, 223);
            cmbArea.Margin = new Padding(4, 5, 4, 5);
            cmbArea.Name = "cmbArea";
            cmbArea.Size = new Size(183, 33);
            cmbArea.TabIndex = 40;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Kosong", "Terisi" });
            cmbStatus.Location = new Point(951, 388);
            cmbStatus.Margin = new Padding(4, 5, 4, 5);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(183, 33);
            cmbStatus.TabIndex = 42;
            // 
            // SLotParkir
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1910, 824);
            Controls.Add(cmbStatus);
            Controls.Add(cmbArea);
            Controls.Add(lblInputSLot);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Controls.Add(lblMasuk);
            Controls.Add(cmsJenisKendaraan);
            Controls.Add(dtpMasuk);
            Controls.Add(txtPlatNomer);
            Controls.Add(lblPlatNomer);
            Controls.Add(lblArea);
            Controls.Add(lblStatus);
            Controls.Add(lblKendaraan);
            Controls.Add(lblKodeSlot);
            Controls.Add(txtKode);
            Name = "SLotParkir";
            Text = "SLotParkir";
            Load += SLotParkir_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMasuk;
        private ComboBox cmsJenisKendaraan;
        private DateTimePicker dtpMasuk;
        private TextBox txtPlatNomer;
        private Label lblPlatNomer;
        private Label lblArea;
        private Label lblStatus;
        private Label lblKendaraan;
        private Label lblKodeSlot;
        private TextBox txtKode;
        private Button btnBatal;
        private Button btnSimpan;
        private Label lblInputSLot;
        private ComboBox cmbArea;
        private ComboBox cmbStatus;
    }
}
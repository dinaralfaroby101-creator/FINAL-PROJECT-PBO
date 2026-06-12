namespace FINAL_PROJECT.forms
{
    partial class vechileentry
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
            panelSidebar = new Panel();
            btnVehicleEntry = new Button();
            btnVehicleExit = new Button();
            btnVehicleData = new Button();
            btnLogOut = new Button();
            btnHistoryPetugas = new Button();
            btnMonitoringPetugas = new Button();
            lblSPpetugas = new Label();
            picLogo = new PictureBox();
            btnDashboardPetugas = new Button();
            txtPlatNomor = new TextBox();
            cboJenisKendaraan = new ComboBox();
            txtMerkKendaraan = new TextBox();
            cboAreaParkir = new ComboBox();
            dtpMasuk = new DateTimePicker();
            txtIdPetugas = new TextBox();
            txtCatatan = new TextBox();
            lblPlat = new Label();
            lblKendaraan = new Label();
            lblMerk = new Label();
            lblArea = new Label();
            lblWaktu = new Label();
            lblCatatan = new Label();
            lblPetugas = new Label();
            pictureBox1 = new PictureBox();
            btnBatal = new Button();
            btnSimpan = new Button();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.Navy;
            panelSidebar.Controls.Add(btnVehicleEntry);
            panelSidebar.Controls.Add(btnVehicleExit);
            panelSidebar.Controls.Add(btnVehicleData);
            panelSidebar.Controls.Add(btnLogOut);
            panelSidebar.Controls.Add(btnHistoryPetugas);
            panelSidebar.Controls.Add(btnMonitoringPetugas);
            panelSidebar.Controls.Add(lblSPpetugas);
            panelSidebar.Controls.Add(picLogo);
            panelSidebar.Controls.Add(btnDashboardPetugas);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Margin = new Padding(4);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(350, 824);
            panelSidebar.TabIndex = 2;
            // 
            // btnVehicleEntry
            // 
            btnVehicleEntry.BackColor = Color.DeepSkyBlue;
            btnVehicleEntry.Location = new Point(81, 273);
            btnVehicleEntry.Margin = new Padding(4);
            btnVehicleEntry.Name = "btnVehicleEntry";
            btnVehicleEntry.Size = new Size(229, 49);
            btnVehicleEntry.TabIndex = 16;
            btnVehicleEntry.Text = "Vehicle Entry";
            btnVehicleEntry.UseVisualStyleBackColor = false;
            // 
            // btnVehicleExit
            // 
            btnVehicleExit.Location = new Point(81, 335);
            btnVehicleExit.Margin = new Padding(4);
            btnVehicleExit.Name = "btnVehicleExit";
            btnVehicleExit.Size = new Size(229, 46);
            btnVehicleExit.TabIndex = 15;
            btnVehicleExit.Text = "Vehicle Exit";
            btnVehicleExit.UseVisualStyleBackColor = true;
            btnVehicleExit.Click += btnVehicleExit_Click;
            // 
            // btnVehicleData
            // 
            btnVehicleData.BackColor = Color.White;
            btnVehicleData.Location = new Point(35, 199);
            btnVehicleData.Margin = new Padding(4);
            btnVehicleData.Name = "btnVehicleData";
            btnVehicleData.Size = new Size(275, 62);
            btnVehicleData.TabIndex = 13;
            btnVehicleData.Text = "Vehicle Data";
            btnVehicleData.UseVisualStyleBackColor = false;
            btnVehicleData.Click += btnVehicleData_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(35, 610);
            btnLogOut.Margin = new Padding(4);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(275, 62);
            btnLogOut.TabIndex = 12;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            // 
            // btnHistoryPetugas
            // 
            btnHistoryPetugas.Location = new Point(35, 499);
            btnHistoryPetugas.Margin = new Padding(4);
            btnHistoryPetugas.Name = "btnHistoryPetugas";
            btnHistoryPetugas.Size = new Size(275, 62);
            btnHistoryPetugas.TabIndex = 10;
            btnHistoryPetugas.Text = "History";
            btnHistoryPetugas.UseVisualStyleBackColor = true;
            // 
            // btnMonitoringPetugas
            // 
            btnMonitoringPetugas.Location = new Point(35, 407);
            btnMonitoringPetugas.Margin = new Padding(4);
            btnMonitoringPetugas.Name = "btnMonitoringPetugas";
            btnMonitoringPetugas.Size = new Size(275, 62);
            btnMonitoringPetugas.TabIndex = 9;
            btnMonitoringPetugas.Text = "Monitoring";
            btnMonitoringPetugas.UseVisualStyleBackColor = true;
            // 
            // lblSPpetugas
            // 
            lblSPpetugas.AutoSize = true;
            lblSPpetugas.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSPpetugas.ForeColor = Color.White;
            lblSPpetugas.Location = new Point(81, 15);
            lblSPpetugas.Margin = new Padding(4, 0, 4, 0);
            lblSPpetugas.Name = "lblSPpetugas";
            lblSPpetugas.Size = new Size(243, 76);
            lblSPpetugas.TabIndex = 0;
            lblSPpetugas.Text = "SMART PARKING\r\nPETUGAS";
            lblSPpetugas.TextAlign = ContentAlignment.TopCenter;
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new Point(6, 15);
            picLogo.Margin = new Padding(4);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(80, 78);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 5;
            picLogo.TabStop = false;
            // 
            // btnDashboardPetugas
            // 
            btnDashboardPetugas.BackColor = Color.White;
            btnDashboardPetugas.Location = new Point(35, 112);
            btnDashboardPetugas.Margin = new Padding(4);
            btnDashboardPetugas.Name = "btnDashboardPetugas";
            btnDashboardPetugas.Size = new Size(275, 62);
            btnDashboardPetugas.TabIndex = 1;
            btnDashboardPetugas.Text = "Dashboard";
            btnDashboardPetugas.UseVisualStyleBackColor = false;
            // 
            // txtPlatNomor
            // 
            txtPlatNomor.Location = new Point(533, 143);
            txtPlatNomor.Name = "txtPlatNomor";
            txtPlatNomor.Size = new Size(315, 31);
            txtPlatNomor.TabIndex = 3;
            txtPlatNomor.TextChanged += txtPlatNomor_TextChanged;
            // 
            // cboJenisKendaraan
            // 
            cboJenisKendaraan.FormattingEnabled = true;
            cboJenisKendaraan.Location = new Point(533, 281);
            cboJenisKendaraan.Name = "cboJenisKendaraan";
            cboJenisKendaraan.Size = new Size(315, 33);
            cboJenisKendaraan.TabIndex = 4;
            cboJenisKendaraan.SelectedIndexChanged += cboJenisKendaraan_SelectedIndexChanged;
            // 
            // txtMerkKendaraan
            // 
            txtMerkKendaraan.Location = new Point(533, 418);
            txtMerkKendaraan.Name = "txtMerkKendaraan";
            txtMerkKendaraan.Size = new Size(315, 31);
            txtMerkKendaraan.TabIndex = 5;
            // 
            // cboAreaParkir
            // 
            cboAreaParkir.FormattingEnabled = true;
            cboAreaParkir.Location = new Point(533, 555);
            cboAreaParkir.Name = "cboAreaParkir";
            cboAreaParkir.Size = new Size(315, 33);
            cboAreaParkir.TabIndex = 6;
            // 
            // dtpMasuk
            // 
            dtpMasuk.Location = new Point(934, 143);
            dtpMasuk.Margin = new Padding(4, 5, 4, 5);
            dtpMasuk.Name = "dtpMasuk";
            dtpMasuk.Size = new Size(315, 31);
            dtpMasuk.TabIndex = 34;
            dtpMasuk.ValueChanged += dtpMasuk_ValueChanged;
            // 
            // txtIdPetugas
            // 
            txtIdPetugas.Location = new Point(934, 418);
            txtIdPetugas.Name = "txtIdPetugas";
            txtIdPetugas.Size = new Size(315, 31);
            txtIdPetugas.TabIndex = 35;
            // 
            // txtCatatan
            // 
            txtCatatan.Location = new Point(934, 281);
            txtCatatan.Name = "txtCatatan";
            txtCatatan.Size = new Size(315, 31);
            txtCatatan.TabIndex = 36;
            // 
            // lblPlat
            // 
            lblPlat.AutoSize = true;
            lblPlat.BackColor = SystemColors.ActiveCaption;
            lblPlat.Font = new Font("Dubai", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlat.ForeColor = Color.Black;
            lblPlat.Location = new Point(533, 98);
            lblPlat.Margin = new Padding(4, 0, 4, 0);
            lblPlat.Name = "lblPlat";
            lblPlat.Size = new Size(88, 39);
            lblPlat.TabIndex = 37;
            lblPlat.Text = "No Plat";
            lblPlat.Click += lblKodeSlot_Click;
            // 
            // lblKendaraan
            // 
            lblKendaraan.AutoSize = true;
            lblKendaraan.BackColor = SystemColors.ActiveCaption;
            lblKendaraan.Font = new Font("Dubai", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKendaraan.ForeColor = Color.Black;
            lblKendaraan.Location = new Point(533, 236);
            lblKendaraan.Margin = new Padding(4, 0, 4, 0);
            lblKendaraan.Name = "lblKendaraan";
            lblKendaraan.Size = new Size(173, 39);
            lblKendaraan.TabIndex = 38;
            lblKendaraan.Text = "Jenis Kendaraan";
            // 
            // lblMerk
            // 
            lblMerk.AutoSize = true;
            lblMerk.BackColor = SystemColors.ActiveCaption;
            lblMerk.Font = new Font("Dubai", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMerk.ForeColor = Color.Black;
            lblMerk.Location = new Point(533, 374);
            lblMerk.Margin = new Padding(4, 0, 4, 0);
            lblMerk.Name = "lblMerk";
            lblMerk.Size = new Size(174, 39);
            lblMerk.TabIndex = 39;
            lblMerk.Text = "Merk Kendaraan";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.BackColor = SystemColors.ActiveCaption;
            lblArea.Font = new Font("Dubai", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblArea.ForeColor = Color.Black;
            lblArea.Location = new Point(533, 512);
            lblArea.Margin = new Padding(4, 0, 4, 0);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(124, 39);
            lblArea.TabIndex = 40;
            lblArea.Text = "Area Parkir";
            // 
            // lblWaktu
            // 
            lblWaktu.AutoSize = true;
            lblWaktu.BackColor = SystemColors.ActiveCaption;
            lblWaktu.Font = new Font("Dubai", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWaktu.ForeColor = Color.Black;
            lblWaktu.Location = new Point(934, 98);
            lblWaktu.Margin = new Padding(4, 0, 4, 0);
            lblWaktu.Name = "lblWaktu";
            lblWaktu.Size = new Size(133, 39);
            lblWaktu.TabIndex = 41;
            lblWaktu.Text = "Masuk Pada";
            // 
            // lblCatatan
            // 
            lblCatatan.AutoSize = true;
            lblCatatan.BackColor = SystemColors.ActiveCaption;
            lblCatatan.Font = new Font("Dubai", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCatatan.ForeColor = Color.Black;
            lblCatatan.Location = new Point(934, 373);
            lblCatatan.Margin = new Padding(4, 0, 4, 0);
            lblCatatan.Name = "lblCatatan";
            lblCatatan.Size = new Size(91, 39);
            lblCatatan.TabIndex = 42;
            lblCatatan.Text = "Catatan";
            // 
            // lblPetugas
            // 
            lblPetugas.AutoSize = true;
            lblPetugas.BackColor = SystemColors.ActiveCaption;
            lblPetugas.Font = new Font("Dubai", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPetugas.ForeColor = Color.Black;
            lblPetugas.Location = new Point(934, 236);
            lblPetugas.Margin = new Padding(4, 0, 4, 0);
            lblPetugas.Name = "lblPetugas";
            lblPetugas.Size = new Size(117, 39);
            lblPetugas.TabIndex = 43;
            lblPetugas.Text = "Petugas Id";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1383, 98);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(366, 534);
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.Red;
            btnBatal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBatal.Location = new Point(1599, 684);
            btnBatal.Margin = new Padding(4, 5, 4, 5);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(161, 55);
            btnBatal.TabIndex = 46;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.Chartreuse;
            btnSimpan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpan.Location = new Point(1383, 684);
            btnSimpan.Margin = new Padding(4, 5, 4, 5);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(161, 55);
            btnSimpan.TabIndex = 45;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            // 
            // vechileentry
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1910, 824);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Controls.Add(pictureBox1);
            Controls.Add(lblPetugas);
            Controls.Add(lblCatatan);
            Controls.Add(lblWaktu);
            Controls.Add(lblArea);
            Controls.Add(lblMerk);
            Controls.Add(lblKendaraan);
            Controls.Add(lblPlat);
            Controls.Add(txtCatatan);
            Controls.Add(txtIdPetugas);
            Controls.Add(dtpMasuk);
            Controls.Add(cboAreaParkir);
            Controls.Add(txtMerkKendaraan);
            Controls.Add(cboJenisKendaraan);
            Controls.Add(txtPlatNomor);
            Controls.Add(panelSidebar);
            Name = "vechileentry";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "vechileentry";
            Load += vechileentry_Load;
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelSidebar;
        private Button btnVehicleEntry;
        private Button btnVehicleExit;
        private Button btnVehicleData;
        private Button btnLogOut;
        private Button btnHistoryPetugas;
        private Button btnMonitoringPetugas;
        private Label lblSPpetugas;
        private PictureBox picLogo;
        private Button btnDashboardPetugas;
        private TextBox txtPlatNomor;
        private ComboBox cboJenisKendaraan;
        private TextBox txtMerkKendaraan;
        private ComboBox cboAreaParkir;
        private DateTimePicker dtpMasuk;
        private TextBox txtIdPetugas;
        private TextBox txtCatatan;
        private Label lblPlat;
        private Label lblKendaraan;
        private Label lblMerk;
        private Label lblArea;
        private Label lblWaktu;
        private Label lblCatatan;
        private Label lblPetugas;
        private PictureBox pictureBox1;
        private Button btnBatal;
        private Button btnSimpan;
    }
}
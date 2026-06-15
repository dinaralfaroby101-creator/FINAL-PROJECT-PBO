namespace FINAL_PROJECT
{
    partial class vehicleexit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vehicleexit));
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
            lblcariKendaraan = new Label();
            txtPlatNoKendaraan = new TextBox();
            btnCari = new Button();
            panel1 = new Panel();
            label1 = new Label();
            cboMetodePembayaran = new ComboBox();
            lblPetugas = new Label();
            lblPetugasTitle = new Label();
            lblSlot = new Label();
            lblSlotTitle = new Label();
            lblBiaya = new Label();
            lblBiayaTitle = new Label();
            lblDurasi = new Label();
            lblDurasiTitle = new Label();
            lblMasuk = new Label();
            lblMasukTitle = new Label();
            picKendaraan = new PictureBox();
            lblJenisArea = new Label();
            lblPlatNomor = new Label();
            lblArea = new Label();
            btnKonfirmasi = new Button();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picKendaraan).BeginInit();
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
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(280, 659);
            panelSidebar.TabIndex = 3;
            // 
            // btnVehicleEntry
            // 
            btnVehicleEntry.BackColor = Color.White;
            btnVehicleEntry.Location = new Point(65, 218);
            btnVehicleEntry.Name = "btnVehicleEntry";
            btnVehicleEntry.Size = new Size(183, 39);
            btnVehicleEntry.TabIndex = 16;
            btnVehicleEntry.Text = "Vehicle Entry";
            btnVehicleEntry.UseVisualStyleBackColor = false;
            btnVehicleEntry.Click += btnVehicleEntry_Click;
            // 
            // btnVehicleExit
            // 
            btnVehicleExit.BackColor = Color.DeepSkyBlue;
            btnVehicleExit.Location = new Point(65, 268);
            btnVehicleExit.Name = "btnVehicleExit";
            btnVehicleExit.Size = new Size(183, 37);
            btnVehicleExit.TabIndex = 15;
            btnVehicleExit.Text = "Vehicle Exit";
            btnVehicleExit.UseVisualStyleBackColor = false;
            // 
            // btnVehicleData
            // 
            btnVehicleData.BackColor = Color.White;
            btnVehicleData.Location = new Point(28, 159);
            btnVehicleData.Name = "btnVehicleData";
            btnVehicleData.Size = new Size(220, 50);
            btnVehicleData.TabIndex = 13;
            btnVehicleData.Text = "Vehicle Data";
            btnVehicleData.UseVisualStyleBackColor = false;
            btnVehicleData.Click += btnVehicleData_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(28, 488);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(220, 50);
            btnLogOut.TabIndex = 12;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            // 
            // btnHistoryPetugas
            // 
            btnHistoryPetugas.Location = new Point(28, 399);
            btnHistoryPetugas.Name = "btnHistoryPetugas";
            btnHistoryPetugas.Size = new Size(220, 50);
            btnHistoryPetugas.TabIndex = 10;
            btnHistoryPetugas.Text = "History";
            btnHistoryPetugas.UseVisualStyleBackColor = true;
            // 
            // btnMonitoringPetugas
            // 
            btnMonitoringPetugas.Location = new Point(28, 326);
            btnMonitoringPetugas.Name = "btnMonitoringPetugas";
            btnMonitoringPetugas.Size = new Size(220, 50);
            btnMonitoringPetugas.TabIndex = 9;
            btnMonitoringPetugas.Text = "Monitoring";
            btnMonitoringPetugas.UseVisualStyleBackColor = true;
            // 
            // lblSPpetugas
            // 
            lblSPpetugas.AutoSize = true;
            lblSPpetugas.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSPpetugas.ForeColor = Color.White;
            lblSPpetugas.Location = new Point(65, 12);
            lblSPpetugas.Name = "lblSPpetugas";
            lblSPpetugas.Size = new Size(199, 62);
            lblSPpetugas.TabIndex = 0;
            lblSPpetugas.Text = "SMART PARKING\r\nPETUGAS";
            lblSPpetugas.TextAlign = ContentAlignment.TopCenter;
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new Point(5, 12);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(64, 62);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 5;
            picLogo.TabStop = false;
            // 
            // btnDashboardPetugas
            // 
            btnDashboardPetugas.BackColor = Color.White;
            btnDashboardPetugas.Location = new Point(28, 90);
            btnDashboardPetugas.Name = "btnDashboardPetugas";
            btnDashboardPetugas.Size = new Size(220, 50);
            btnDashboardPetugas.TabIndex = 1;
            btnDashboardPetugas.Text = "Dashboard";
            btnDashboardPetugas.UseVisualStyleBackColor = false;
            // 
            // lblcariKendaraan
            // 
            lblcariKendaraan.AutoSize = true;
            lblcariKendaraan.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcariKendaraan.Location = new Point(421, 90);
            lblcariKendaraan.Margin = new Padding(2, 0, 2, 0);
            lblcariKendaraan.Name = "lblcariKendaraan";
            lblcariKendaraan.Size = new Size(159, 23);
            lblcariKendaraan.TabIndex = 4;
            lblcariKendaraan.Text = "Plat No Kendaraan";
            // 
            // txtPlatNoKendaraan
            // 
            txtPlatNoKendaraan.Location = new Point(421, 117);
            txtPlatNoKendaraan.Margin = new Padding(2, 2, 2, 2);
            txtPlatNoKendaraan.Name = "txtPlatNoKendaraan";
            txtPlatNoKendaraan.Size = new Size(365, 27);
            txtPlatNoKendaraan.TabIndex = 5;
            // 
            // btnCari
            // 
            btnCari.BackColor = Color.BlueViolet;
            btnCari.FlatStyle = FlatStyle.Flat;
            btnCari.ForeColor = Color.White;
            btnCari.Location = new Point(811, 115);
            btnCari.Margin = new Padding(2, 2, 2, 2);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(96, 28);
            btnCari.TabIndex = 6;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = false;
            btnCari.Click += btnCari_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cboMetodePembayaran);
            panel1.Controls.Add(lblPetugas);
            panel1.Controls.Add(lblPetugasTitle);
            panel1.Controls.Add(lblSlot);
            panel1.Controls.Add(lblSlotTitle);
            panel1.Controls.Add(lblBiaya);
            panel1.Controls.Add(lblBiayaTitle);
            panel1.Controls.Add(lblDurasi);
            panel1.Controls.Add(lblDurasiTitle);
            panel1.Controls.Add(lblMasuk);
            panel1.Controls.Add(lblMasukTitle);
            panel1.Controls.Add(picKendaraan);
            panel1.Controls.Add(lblJenisArea);
            panel1.Controls.Add(lblPlatNomor);
            panel1.Controls.Add(lblArea);
            panel1.Location = new Point(390, 159);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(829, 378);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(323, 338);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 14;
            label1.Text = "Metode Pembayaran";
            // 
            // cboMetodePembayaran
            // 
            cboMetodePembayaran.FormattingEnabled = true;
            cboMetodePembayaran.Location = new Point(482, 336);
            cboMetodePembayaran.Margin = new Padding(2, 2, 2, 2);
            cboMetodePembayaran.Name = "cboMetodePembayaran";
            cboMetodePembayaran.Size = new Size(110, 28);
            cboMetodePembayaran.TabIndex = 9;
            // 
            // lblPetugas
            // 
            lblPetugas.AutoSize = true;
            lblPetugas.Location = new Point(443, 297);
            lblPetugas.Margin = new Padding(2, 0, 2, 0);
            lblPetugas.Name = "lblPetugas";
            lblPetugas.Size = new Size(15, 20);
            lblPetugas.TabIndex = 13;
            lblPetugas.Text = "-";
            // 
            // lblPetugasTitle
            // 
            lblPetugasTitle.AutoSize = true;
            lblPetugasTitle.Location = new Point(323, 297);
            lblPetugasTitle.Margin = new Padding(2, 0, 2, 0);
            lblPetugasTitle.Name = "lblPetugasTitle";
            lblPetugasTitle.Size = new Size(60, 20);
            lblPetugasTitle.TabIndex = 12;
            lblPetugasTitle.Text = "Petugas";
            lblPetugasTitle.Click += lblPetugasTitle_Click;
            // 
            // lblSlot
            // 
            lblSlot.AutoSize = true;
            lblSlot.Location = new Point(443, 254);
            lblSlot.Margin = new Padding(2, 0, 2, 0);
            lblSlot.Name = "lblSlot";
            lblSlot.Size = new Size(15, 20);
            lblSlot.TabIndex = 11;
            lblSlot.Text = "-";
            // 
            // lblSlotTitle
            // 
            lblSlotTitle.AutoSize = true;
            lblSlotTitle.Location = new Point(324, 254);
            lblSlotTitle.Margin = new Padding(2, 0, 2, 0);
            lblSlotTitle.Name = "lblSlotTitle";
            lblSlotTitle.Size = new Size(35, 20);
            lblSlotTitle.TabIndex = 10;
            lblSlotTitle.Text = "Slot";
            // 
            // lblBiaya
            // 
            lblBiaya.AutoSize = true;
            lblBiaya.Location = new Point(443, 219);
            lblBiaya.Margin = new Padding(2, 0, 2, 0);
            lblBiaya.Name = "lblBiaya";
            lblBiaya.Size = new Size(15, 20);
            lblBiaya.TabIndex = 9;
            lblBiaya.Text = "-";
            // 
            // lblBiayaTitle
            // 
            lblBiayaTitle.AutoSize = true;
            lblBiayaTitle.Location = new Point(323, 219);
            lblBiayaTitle.Margin = new Padding(2, 0, 2, 0);
            lblBiayaTitle.Name = "lblBiayaTitle";
            lblBiayaTitle.Size = new Size(45, 20);
            lblBiayaTitle.TabIndex = 8;
            lblBiayaTitle.Text = "Biaya";
            lblBiayaTitle.Click += lblBiayaTitle_Click;
            // 
            // lblDurasi
            // 
            lblDurasi.AutoSize = true;
            lblDurasi.Location = new Point(443, 182);
            lblDurasi.Margin = new Padding(2, 0, 2, 0);
            lblDurasi.Name = "lblDurasi";
            lblDurasi.Size = new Size(15, 20);
            lblDurasi.TabIndex = 7;
            lblDurasi.Text = "-";
            // 
            // lblDurasiTitle
            // 
            lblDurasiTitle.AutoSize = true;
            lblDurasiTitle.Location = new Point(323, 181);
            lblDurasiTitle.Margin = new Padding(2, 0, 2, 0);
            lblDurasiTitle.Name = "lblDurasiTitle";
            lblDurasiTitle.Size = new Size(51, 20);
            lblDurasiTitle.TabIndex = 6;
            lblDurasiTitle.Text = "Durasi";
            // 
            // lblMasuk
            // 
            lblMasuk.AutoSize = true;
            lblMasuk.Location = new Point(443, 141);
            lblMasuk.Margin = new Padding(2, 0, 2, 0);
            lblMasuk.Name = "lblMasuk";
            lblMasuk.Size = new Size(15, 20);
            lblMasuk.TabIndex = 5;
            lblMasuk.Text = "-";
            // 
            // lblMasukTitle
            // 
            lblMasukTitle.AutoSize = true;
            lblMasukTitle.Location = new Point(322, 141);
            lblMasukTitle.Margin = new Padding(2, 0, 2, 0);
            lblMasukTitle.Name = "lblMasukTitle";
            lblMasukTitle.Size = new Size(51, 20);
            lblMasukTitle.TabIndex = 4;
            lblMasukTitle.Text = "Masuk";
            // 
            // picKendaraan
            // 
            picKendaraan.Location = new Point(90, 141);
            picKendaraan.Margin = new Padding(2, 2, 2, 2);
            picKendaraan.Name = "picKendaraan";
            picKendaraan.Size = new Size(176, 112);
            picKendaraan.SizeMode = PictureBoxSizeMode.Zoom;
            picKendaraan.TabIndex = 3;
            picKendaraan.TabStop = false;
            picKendaraan.Click += pictureBox1_Click;
            // 
            // lblJenisArea
            // 
            lblJenisArea.AutoSize = true;
            lblJenisArea.Location = new Point(18, 51);
            lblJenisArea.Margin = new Padding(2, 0, 2, 0);
            lblJenisArea.Name = "lblJenisArea";
            lblJenisArea.Size = new Size(106, 20);
            lblJenisArea.TabIndex = 2;
            lblJenisArea.Text = "Area B (Mobil)";
            // 
            // lblPlatNomor
            // 
            lblPlatNomor.AutoSize = true;
            lblPlatNomor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlatNomor.Location = new Point(50, 14);
            lblPlatNomor.Margin = new Padding(2, 0, 2, 0);
            lblPlatNomor.Name = "lblPlatNomor";
            lblPlatNomor.Size = new Size(99, 28);
            lblPlatNomor.TabIndex = 1;
            lblPlatNomor.Text = "B1920AC";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.BackColor = Color.LightBlue;
            lblArea.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblArea.Location = new Point(15, 13);
            lblArea.Margin = new Padding(2, 0, 2, 0);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(29, 32);
            lblArea.TabIndex = 0;
            lblArea.Text = "B";
            // 
            // btnKonfirmasi
            // 
            btnKonfirmasi.BackColor = Color.BlueViolet;
            btnKonfirmasi.FlatStyle = FlatStyle.Flat;
            btnKonfirmasi.ForeColor = Color.White;
            btnKonfirmasi.Location = new Point(755, 542);
            btnKonfirmasi.Margin = new Padding(2, 2, 2, 2);
            btnKonfirmasi.Name = "btnKonfirmasi";
            btnKonfirmasi.Size = new Size(200, 36);
            btnKonfirmasi.TabIndex = 8;
            btnKonfirmasi.Text = "Konfirmasi";
            btnKonfirmasi.UseVisualStyleBackColor = false;
            btnKonfirmasi.Click += btnKonfirmasi_Click;
            // 
            // vehicleexit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1528, 659);
            Controls.Add(btnKonfirmasi);
            Controls.Add(panel1);
            Controls.Add(btnCari);
            Controls.Add(txtPlatNoKendaraan);
            Controls.Add(lblcariKendaraan);
            Controls.Add(panelSidebar);
            DoubleBuffered = true;
            Margin = new Padding(2, 2, 2, 2);
            Name = "vehicleexit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "vehicleexit";
            Load += vehicleexit_Load;
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picKendaraan).EndInit();
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
        private Label lblcariKendaraan;
        private TextBox txtPlatNoKendaraan;
        private Button btnCari;
        private Panel panel1;
        private Label lblArea;
        private PictureBox picKendaraan;
        private Label lblJenisArea;
        private Label lblPlatNomor;
        private Label lblMasukTitle;
        private Label lblSlotTitle;
        private Label lblBiaya;
        private Label lblBiayaTitle;
        private Label lblDurasi;
        private Label lblDurasiTitle;
        private Label lblMasuk;
        private Label lblPetugas;
        private Label lblPetugasTitle;
        private Label lblSlot;
        private Button btnKonfirmasi;
        private Label label1;
        private ComboBox cboMetodePembayaran;
    }
}
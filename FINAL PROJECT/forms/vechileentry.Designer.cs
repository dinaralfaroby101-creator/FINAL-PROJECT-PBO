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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vechileentry));
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
            lblPlat = new Label();
            lblKendaraan = new Label();
            lblMerk = new Label();
            lblArea = new Label();
            pictureBox1 = new PictureBox();
            btnBatal = new Button();
            btnSimpan = new Button();
            pictureBox2 = new PictureBox();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            panelSidebar.TabIndex = 2;
            // 
            // btnVehicleEntry
            // 
            btnVehicleEntry.BackColor = Color.DeepSkyBlue;
            btnVehicleEntry.Location = new Point(65, 218);
            btnVehicleEntry.Name = "btnVehicleEntry";
            btnVehicleEntry.Size = new Size(183, 39);
            btnVehicleEntry.TabIndex = 16;
            btnVehicleEntry.Text = "Vehicle Entry";
            btnVehicleEntry.UseVisualStyleBackColor = false;
            // 
            // btnVehicleExit
            // 
            btnVehicleExit.Location = new Point(65, 268);
            btnVehicleExit.Name = "btnVehicleExit";
            btnVehicleExit.Size = new Size(183, 37);
            btnVehicleExit.TabIndex = 15;
            btnVehicleExit.Text = "Vehicle Exit";
            btnVehicleExit.UseVisualStyleBackColor = true;
            btnVehicleExit.Click += btnVehicleExit_Click;
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
            // txtPlatNomor
            // 
            txtPlatNomor.Location = new Point(427, 154);
            txtPlatNomor.Margin = new Padding(2, 2, 2, 2);
            txtPlatNomor.Name = "txtPlatNomor";
            txtPlatNomor.Size = new Size(253, 27);
            txtPlatNomor.TabIndex = 3;
            txtPlatNomor.TextChanged += txtPlatNomor_TextChanged;
            // 
            // cboJenisKendaraan
            // 
            cboJenisKendaraan.FormattingEnabled = true;
            cboJenisKendaraan.Location = new Point(427, 264);
            cboJenisKendaraan.Margin = new Padding(2, 2, 2, 2);
            cboJenisKendaraan.Name = "cboJenisKendaraan";
            cboJenisKendaraan.Size = new Size(253, 28);
            cboJenisKendaraan.TabIndex = 4;
            cboJenisKendaraan.SelectedIndexChanged += cboJenisKendaraan_SelectedIndexChanged;
            // 
            // txtMerkKendaraan
            // 
            txtMerkKendaraan.Location = new Point(427, 374);
            txtMerkKendaraan.Margin = new Padding(2, 2, 2, 2);
            txtMerkKendaraan.Name = "txtMerkKendaraan";
            txtMerkKendaraan.Size = new Size(253, 27);
            txtMerkKendaraan.TabIndex = 5;
            // 
            // cboAreaParkir
            // 
            cboAreaParkir.FormattingEnabled = true;
            cboAreaParkir.Location = new Point(427, 483);
            cboAreaParkir.Margin = new Padding(2, 2, 2, 2);
            cboAreaParkir.Name = "cboAreaParkir";
            cboAreaParkir.Size = new Size(253, 28);
            cboAreaParkir.TabIndex = 6;
            // 
            // lblPlat
            // 
            lblPlat.AutoSize = true;
            lblPlat.BackColor = SystemColors.ActiveCaption;
            lblPlat.Font = new Font("Dubai", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlat.ForeColor = Color.Black;
            lblPlat.Location = new Point(427, 118);
            lblPlat.Name = "lblPlat";
            lblPlat.Size = new Size(73, 32);
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
            lblKendaraan.Location = new Point(427, 228);
            lblKendaraan.Name = "lblKendaraan";
            lblKendaraan.Size = new Size(143, 32);
            lblKendaraan.TabIndex = 38;
            lblKendaraan.Text = "Jenis Kendaraan";
            // 
            // lblMerk
            // 
            lblMerk.AutoSize = true;
            lblMerk.BackColor = SystemColors.ActiveCaption;
            lblMerk.Font = new Font("Dubai", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMerk.ForeColor = Color.Black;
            lblMerk.Location = new Point(427, 338);
            lblMerk.Name = "lblMerk";
            lblMerk.Size = new Size(144, 32);
            lblMerk.TabIndex = 39;
            lblMerk.Text = "Merk Kendaraan";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.BackColor = SystemColors.ActiveCaption;
            lblArea.Font = new Font("Dubai", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblArea.ForeColor = Color.Black;
            lblArea.Location = new Point(427, 449);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(103, 32);
            lblArea.TabIndex = 40;
            lblArea.Text = "Area Parkir";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1012, 90);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(293, 427);
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.Red;
            btnBatal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBatal.Location = new Point(1185, 558);
            btnBatal.Margin = new Padding(3, 4, 3, 4);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(129, 44);
            btnBatal.TabIndex = 46;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.Chartreuse;
            btnSimpan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpan.Location = new Point(1012, 558);
            btnSimpan.Margin = new Padding(3, 4, 3, 4);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(129, 44);
            btnSimpan.TabIndex = 45;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.logo;
            pictureBox2.Location = new Point(1012, 90);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(302, 427);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // vechileentry
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1528, 659);
            Controls.Add(pictureBox2);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Controls.Add(pictureBox1);
            Controls.Add(lblArea);
            Controls.Add(lblMerk);
            Controls.Add(lblKendaraan);
            Controls.Add(lblPlat);
            Controls.Add(cboAreaParkir);
            Controls.Add(txtMerkKendaraan);
            Controls.Add(cboJenisKendaraan);
            Controls.Add(txtPlatNomor);
            Controls.Add(panelSidebar);
            DoubleBuffered = true;
            Margin = new Padding(2, 2, 2, 2);
            Name = "vechileentry";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "vechileentry";
            Load += vechileentry_Load;
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Label lblPlat;
        private Label lblKendaraan;
        private Label lblMerk;
        private Label lblArea;
        private PictureBox pictureBox1;
        private Button btnBatal;
        private Button btnSimpan;
        private PictureBox pictureBox2;
    }
}
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
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
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
            txtPlatNomor.Location = new Point(523, 199);
            txtPlatNomor.Name = "txtPlatNomor";
            txtPlatNomor.Size = new Size(315, 31);
            txtPlatNomor.TabIndex = 3;
            // 
            // cboJenisKendaraan
            // 
            cboJenisKendaraan.FormattingEnabled = true;
            cboJenisKendaraan.Location = new Point(523, 257);
            cboJenisKendaraan.Name = "cboJenisKendaraan";
            cboJenisKendaraan.Size = new Size(315, 33);
            cboJenisKendaraan.TabIndex = 4;
            cboJenisKendaraan.SelectedIndexChanged += cboJenisKendaraan_SelectedIndexChanged;
            // 
            // txtMerkKendaraan
            // 
            txtMerkKendaraan.Location = new Point(523, 317);
            txtMerkKendaraan.Name = "txtMerkKendaraan";
            txtMerkKendaraan.Size = new Size(315, 31);
            txtMerkKendaraan.TabIndex = 5;
            // 
            // vechileentry
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1910, 824);
            Controls.Add(txtMerkKendaraan);
            Controls.Add(cboJenisKendaraan);
            Controls.Add(txtPlatNomor);
            Controls.Add(panelSidebar);
            Name = "vechileentry";
            Text = "vechileentry";
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
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
    }
}
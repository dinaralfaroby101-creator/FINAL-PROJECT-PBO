using FINAL_PROJECT.Data;

namespace FINAL_PROJECT.forms
{
    partial class UserData
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserData));
            panelSidebar = new Panel();
            button1 = new Button();
            btnFinanceReport = new Button();
            btnHistory = new Button();
            btnMonitoring = new Button();
            btnBagStorage = new Button();
            btnUserData = new Button();
            btnParkingData = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            btnDashboard = new Button();
            lblUserData = new Label();
            panel5 = new Panel();
            lblJumlahPetugas = new Label();
            lblTotalPetugas = new Label();
            pictureBox5 = new PictureBox();
            panel6 = new Panel();
            lblJumlahUserAktif = new Label();
            lblUserAktif = new Label();
            pictureBox6 = new PictureBox();
            panel4 = new Panel();
            lblSemuaAdmin = new Label();
            lblJumlahAdmin = new Label();
            lblTotalAdmin = new Label();
            pictureBox4 = new PictureBox();
            panel3 = new Panel();
            lblSemuaUser = new Label();
            lblJumlahUser = new Label();
            lblTotalUser = new Label();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            btnTambahUser = new Button();
            cbxUser = new ComboBox();
            cbxStatus = new ComboBox();
            panel7 = new Panel();
            dgvUser = new DataGridView();
            databaseHelperBindingSource = new BindingSource(components);
            panelUSername = new Panel();
            pictureBox2 = new PictureBox();
            txtCariUsername = new TextBox();
            panel1 = new Panel();
            btnEditUser = new Button();
            label19 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)databaseHelperBindingSource).BeginInit();
            panelUSername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.Navy;
            panelSidebar.Controls.Add(label8);
            panelSidebar.Controls.Add(label7);
            panelSidebar.Controls.Add(label6);
            panelSidebar.Controls.Add(label5);
            panelSidebar.Controls.Add(label4);
            panelSidebar.Controls.Add(label3);
            panelSidebar.Controls.Add(label1);
            panelSidebar.Controls.Add(label19);
            panelSidebar.Controls.Add(button1);
            panelSidebar.Controls.Add(btnFinanceReport);
            panelSidebar.Controls.Add(btnHistory);
            panelSidebar.Controls.Add(btnMonitoring);
            panelSidebar.Controls.Add(btnBagStorage);
            panelSidebar.Controls.Add(btnUserData);
            panelSidebar.Controls.Add(btnParkingData);
            panelSidebar.Controls.Add(label2);
            panelSidebar.Controls.Add(pictureBox1);
            panelSidebar.Controls.Add(btnDashboard);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(280, 641);
            panelSidebar.TabIndex = 23;
            // 
            // button1
            // 
            button1.Location = new Point(28, 482);
            button1.Name = "button1";
            button1.Size = new Size(220, 50);
            button1.TabIndex = 12;
            button1.Text = "Log Out";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnFinanceReport
            // 
            btnFinanceReport.Location = new Point(28, 426);
            btnFinanceReport.Name = "btnFinanceReport";
            btnFinanceReport.Size = new Size(220, 50);
            btnFinanceReport.TabIndex = 11;
            btnFinanceReport.Text = "Finance Report";
            btnFinanceReport.UseVisualStyleBackColor = true;
            btnFinanceReport.Click += btnFinanceReport_Click;
            // 
            // btnHistory
            // 
            btnHistory.Location = new Point(28, 370);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(220, 50);
            btnHistory.TabIndex = 10;
            btnHistory.Text = "History";
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnMonitoring
            // 
            btnMonitoring.Location = new Point(28, 314);
            btnMonitoring.Name = "btnMonitoring";
            btnMonitoring.Size = new Size(220, 50);
            btnMonitoring.TabIndex = 9;
            btnMonitoring.Text = "Monitoring";
            btnMonitoring.UseVisualStyleBackColor = true;
            btnMonitoring.Click += btnMonitoring_Click;
            // 
            // btnBagStorage
            // 
            btnBagStorage.Location = new Point(28, 258);
            btnBagStorage.Name = "btnBagStorage";
            btnBagStorage.Size = new Size(220, 50);
            btnBagStorage.TabIndex = 8;
            btnBagStorage.Text = "Bag Storage";
            btnBagStorage.UseVisualStyleBackColor = true;
            btnBagStorage.Click += btnBagStorage_Click;
            // 
            // btnUserData
            // 
            btnUserData.BackColor = Color.DeepSkyBlue;
            btnUserData.Location = new Point(28, 202);
            btnUserData.Name = "btnUserData";
            btnUserData.Size = new Size(220, 50);
            btnUserData.TabIndex = 7;
            btnUserData.Text = "User Data";
            btnUserData.UseVisualStyleBackColor = false;
            btnUserData.Click += button6_Click;
            // 
            // btnParkingData
            // 
            btnParkingData.Location = new Point(28, 146);
            btnParkingData.Name = "btnParkingData";
            btnParkingData.Size = new Size(220, 50);
            btnParkingData.TabIndex = 6;
            btnParkingData.Text = "Parking Data";
            btnParkingData.UseVisualStyleBackColor = true;
            btnParkingData.Click += button7_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(65, 12);
            label2.Name = "label2";
            label2.Size = new Size(199, 62);
            label2.TabIndex = 0;
            label2.Text = "SMART PARKING\r\nADMIN";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(5, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.White;
            btnDashboard.Location = new Point(28, 90);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(220, 50);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click_1;
            // 
            // lblUserData
            // 
            lblUserData.AutoSize = true;
            lblUserData.BackColor = Color.Transparent;
            lblUserData.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserData.Location = new Point(19, 12);
            lblUserData.Name = "lblUserData";
            lblUserData.Size = new Size(175, 46);
            lblUserData.TabIndex = 24;
            lblUserData.Text = "User Data";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(lblJumlahPetugas);
            panel5.Controls.Add(lblTotalPetugas);
            panel5.Controls.Add(pictureBox5);
            panel5.Location = new Point(493, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(240, 120);
            panel5.TabIndex = 7;
            // 
            // lblJumlahPetugas
            // 
            lblJumlahPetugas.AutoSize = true;
            lblJumlahPetugas.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJumlahPetugas.Location = new Point(96, 44);
            lblJumlahPetugas.Name = "lblJumlahPetugas";
            lblJumlahPetugas.Size = new Size(38, 31);
            lblJumlahPetugas.TabIndex = 2;
            lblJumlahPetugas.Text = "85";
            // 
            // lblTotalPetugas
            // 
            lblTotalPetugas.AutoSize = true;
            lblTotalPetugas.Location = new Point(92, 23);
            lblTotalPetugas.Name = "lblTotalPetugas";
            lblTotalPetugas.Size = new Size(60, 20);
            lblTotalPetugas.TabIndex = 1;
            lblTotalPetugas.Text = "Petugas";
            lblTotalPetugas.Click += label13_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(17, 23);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(69, 62);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(lblJumlahUserAktif);
            panel6.Controls.Add(lblUserAktif);
            panel6.Controls.Add(pictureBox6);
            panel6.Location = new Point(739, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(240, 120);
            panel6.TabIndex = 8;
            // 
            // lblJumlahUserAktif
            // 
            lblJumlahUserAktif.AutoSize = true;
            lblJumlahUserAktif.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJumlahUserAktif.Location = new Point(96, 44);
            lblJumlahUserAktif.Name = "lblJumlahUserAktif";
            lblJumlahUserAktif.Size = new Size(26, 31);
            lblJumlahUserAktif.TabIndex = 2;
            lblJumlahUserAktif.Text = "3";
            // 
            // lblUserAktif
            // 
            lblUserAktif.AutoSize = true;
            lblUserAktif.Location = new Point(92, 23);
            lblUserAktif.Name = "lblUserAktif";
            lblUserAktif.Size = new Size(73, 20);
            lblUserAktif.TabIndex = 1;
            lblUserAktif.Text = "User Aktif";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(17, 23);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(69, 62);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(lblSemuaAdmin);
            panel4.Controls.Add(lblJumlahAdmin);
            panel4.Controls.Add(lblTotalAdmin);
            panel4.Controls.Add(pictureBox4);
            panel4.Location = new Point(247, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(240, 120);
            panel4.TabIndex = 6;
            // 
            // lblSemuaAdmin
            // 
            lblSemuaAdmin.AutoSize = true;
            lblSemuaAdmin.Location = new Point(92, 75);
            lblSemuaAdmin.Name = "lblSemuaAdmin";
            lblSemuaAdmin.Size = new Size(0, 20);
            lblSemuaAdmin.TabIndex = 3;
            // 
            // lblJumlahAdmin
            // 
            lblJumlahAdmin.AutoSize = true;
            lblJumlahAdmin.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJumlahAdmin.Location = new Point(96, 44);
            lblJumlahAdmin.Name = "lblJumlahAdmin";
            lblJumlahAdmin.Size = new Size(26, 31);
            lblJumlahAdmin.TabIndex = 2;
            lblJumlahAdmin.Text = "4";
            // 
            // lblTotalAdmin
            // 
            lblTotalAdmin.AutoSize = true;
            lblTotalAdmin.Location = new Point(92, 23);
            lblTotalAdmin.Name = "lblTotalAdmin";
            lblTotalAdmin.Size = new Size(53, 20);
            lblTotalAdmin.TabIndex = 1;
            lblTotalAdmin.Text = "Admin";
            lblTotalAdmin.Click += label10_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(17, 23);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(69, 62);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(lblSemuaUser);
            panel3.Controls.Add(lblJumlahUser);
            panel3.Controls.Add(lblTotalUser);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(240, 120);
            panel3.TabIndex = 5;
            panel3.Paint += panel3_Paint;
            // 
            // lblSemuaUser
            // 
            lblSemuaUser.AutoSize = true;
            lblSemuaUser.Location = new Point(92, 75);
            lblSemuaUser.Name = "lblSemuaUser";
            lblSemuaUser.Size = new Size(87, 20);
            lblSemuaUser.TabIndex = 3;
            lblSemuaUser.Text = "Semua User";
            // 
            // lblJumlahUser
            // 
            lblJumlahUser.AutoSize = true;
            lblJumlahUser.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJumlahUser.Location = new Point(96, 44);
            lblJumlahUser.Name = "lblJumlahUser";
            lblJumlahUser.Size = new Size(50, 31);
            lblJumlahUser.TabIndex = 2;
            lblJumlahUser.Text = "135";
            // 
            // lblTotalUser
            // 
            lblTotalUser.AutoSize = true;
            lblTotalUser.Location = new Point(92, 23);
            lblTotalUser.Name = "lblTotalUser";
            lblTotalUser.Size = new Size(75, 20);
            lblTotalUser.TabIndex = 1;
            lblTotalUser.Text = "Total User";
            lblTotalUser.Click += label5_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(17, 23);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(69, 62);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Location = new Point(121, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(987, 127);
            panel2.TabIndex = 25;
            // 
            // btnTambahUser
            // 
            btnTambahUser.BackColor = Color.DodgerBlue;
            btnTambahUser.FlatStyle = FlatStyle.Flat;
            btnTambahUser.ForeColor = Color.White;
            btnTambahUser.Location = new Point(125, 223);
            btnTambahUser.Name = "btnTambahUser";
            btnTambahUser.Size = new Size(148, 29);
            btnTambahUser.TabIndex = 26;
            btnTambahUser.Text = "+ Tambah User";
            btnTambahUser.UseVisualStyleBackColor = false;
            btnTambahUser.Click += btnTambahUser_Click;
            // 
            // cbxUser
            // 
            cbxUser.FormattingEnabled = true;
            cbxUser.Items.AddRange(new object[] { "Semua User", "admin", "petugas" });
            cbxUser.Location = new Point(447, 224);
            cbxUser.Name = "cbxUser";
            cbxUser.Size = new Size(151, 28);
            cbxUser.TabIndex = 27;
            cbxUser.Text = "Semua User";
            cbxUser.SelectedIndexChanged += cbxUser_SelectedIndexChanged;
            // 
            // cbxStatus
            // 
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Items.AddRange(new object[] { "Semua Status", "Online", "Offline" });
            cbxStatus.Location = new Point(604, 225);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(151, 28);
            cbxStatus.TabIndex = 28;
            cbxStatus.Text = "Semua Status";
            // 
            // panel7
            // 
            panel7.Controls.Add(dgvUser);
            panel7.Location = new Point(121, 269);
            panel7.Name = "panel7";
            panel7.Size = new Size(989, 336);
            panel7.TabIndex = 29;
            // 
            // dgvUser
            // 
            dgvUser.AutoGenerateColumns = false;
            dgvUser.BackgroundColor = SystemColors.ControlLightLight;
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.DataSource = databaseHelperBindingSource;
            dgvUser.Location = new Point(3, 3);
            dgvUser.Name = "dgvUser";
            dgvUser.RowHeadersWidth = 51;
            dgvUser.Size = new Size(982, 436);
            dgvUser.TabIndex = 0;
            dgvUser.CellContentClick += dgvUser_CellContentClick;
            // 
            // databaseHelperBindingSource
            // 
            databaseHelperBindingSource.DataSource = typeof(DatabaseHelper);
            // 
            // panelUSername
            // 
            panelUSername.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelUSername.BackColor = Color.White;
            panelUSername.BorderStyle = BorderStyle.FixedSingle;
            panelUSername.Controls.Add(pictureBox2);
            panelUSername.Controls.Add(txtCariUsername);
            panelUSername.Location = new Point(858, 217);
            panelUSername.Name = "panelUSername";
            panelUSername.Size = new Size(250, 40);
            panelUSername.TabIndex = 13;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // txtCariUsername
            // 
            txtCariUsername.BorderStyle = BorderStyle.None;
            txtCariUsername.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCariUsername.ForeColor = Color.Gray;
            txtCariUsername.Location = new Point(73, 7);
            txtCariUsername.Name = "txtCariUsername";
            txtCariUsername.Size = new Size(180, 23);
            txtCariUsername.TabIndex = 3;
            txtCariUsername.Text = "Cari Username";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnEditUser);
            panel1.Controls.Add(panelUSername);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(cbxStatus);
            panel1.Controls.Add(cbxUser);
            panel1.Controls.Add(btnTambahUser);
            panel1.Controls.Add(lblUserData);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(283, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1253, 641);
            panel1.TabIndex = 30;
            // 
            // btnEditUser
            // 
            btnEditUser.BackColor = Color.DarkOrange;
            btnEditUser.Location = new Point(762, 225);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(94, 29);
            btnEditUser.TabIndex = 4;
            btnEditUser.Text = "Edit User";
            btnEditUser.UseVisualStyleBackColor = false;
            btnEditUser.Click += btnEditUser_Click;
            // 
            // label19
            // 
            label19.BackColor = Color.White;
            label19.Image = (Image)resources.GetObject("label19.Image");
            label19.Location = new Point(35, 97);
            label19.Name = "label19";
            label19.Size = new Size(42, 38);
            label19.TabIndex = 20;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(35, 152);
            label1.Name = "label1";
            label1.Size = new Size(42, 38);
            label1.TabIndex = 21;
            // 
            // label3
            // 
            label3.BackColor = Color.DeepSkyBlue;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(35, 208);
            label3.Name = "label3";
            label3.Size = new Size(42, 38);
            label3.TabIndex = 22;
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(35, 263);
            label4.Name = "label4";
            label4.Size = new Size(42, 38);
            label4.TabIndex = 23;
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Image = (Image)resources.GetObject("label5.Image");
            label5.Location = new Point(35, 319);
            label5.Name = "label5";
            label5.Size = new Size(42, 38);
            label5.TabIndex = 24;
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Image = (Image)resources.GetObject("label6.Image");
            label6.Location = new Point(35, 375);
            label6.Name = "label6";
            label6.Size = new Size(42, 38);
            label6.TabIndex = 25;
            // 
            // label7
            // 
            label7.BackColor = Color.White;
            label7.Image = (Image)resources.GetObject("label7.Image");
            label7.Location = new Point(35, 431);
            label7.Name = "label7";
            label7.Size = new Size(42, 38);
            label7.TabIndex = 26;
            // 
            // label8
            // 
            label8.BackColor = Color.White;
            label8.Image = (Image)resources.GetObject("label8.Image");
            label8.Location = new Point(35, 487);
            label8.Name = "label8";
            label8.Size = new Size(42, 38);
            label8.TabIndex = 27;
            // 
            // UserData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1536, 641);
            Controls.Add(panelSidebar);
            Controls.Add(panel1);
            Name = "UserData";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserData";
            Load += UserData_Load;
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)databaseHelperBindingSource).EndInit();
            panelUSername.ResumeLayout(false);
            panelUSername.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Button button1;
        private Button btnFinanceReport;
        private Button btnHistory;
        private Button btnMonitoring;
        private Button btnBagStorage;
        private Button btnUserData;
        private Button btnParkingData;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btnDashboard;
        private Label lblUserData;
        private Panel panel5;
        private Label lblJumlahPetugas;
        private Label lblTotalPetugas;
        private PictureBox pictureBox5;
        private Panel panel6;
        private Label lblJumlahUserAktif;
        private Label lblUserAktif;
        private PictureBox pictureBox6;
        private Panel panel4;
        private Label lblSemuaAdmin;
        private Label lblJumlahAdmin;
        private Label lblTotalAdmin;
        private PictureBox pictureBox4;
        private Panel panel3;
        private Label lblSemuaUser;
        private Label lblJumlahUser;
        private Label lblTotalUser;
        private PictureBox pictureBox3;
        private Panel panel2;
        private Button btnTambahUser;
        private ComboBox cbxUser;
        private ComboBox cbxStatus;
        private Panel panel7;
        private DataGridView dgvUser;
        private BindingSource databaseHelperBindingSource;
        private Panel panelUSername;
        private PictureBox pictureBox2;
        private TextBox txtCariUsername;
        private Panel panel1;
        private Button btnEditUser;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label19;
    }
}
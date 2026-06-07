namespace FINAL_PROJECT
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
            comboBox2 = new ComboBox();
            panel7 = new Panel();
            dgvUser = new DataGridView();
            databaseHelperBindingSource = new BindingSource(components);
            panelUSername = new Panel();
            pictureBox2 = new PictureBox();
            txtCariUsername = new TextBox();
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
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.Navy;
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
            panelSidebar.Margin = new Padding(4);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(350, 801);
            panelSidebar.TabIndex = 23;
            // 
            // button1
            // 
            button1.Location = new Point(35, 602);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(275, 62);
            button1.TabIndex = 12;
            button1.Text = "Log Out";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnFinanceReport
            // 
            btnFinanceReport.Location = new Point(35, 532);
            btnFinanceReport.Margin = new Padding(4);
            btnFinanceReport.Name = "btnFinanceReport";
            btnFinanceReport.Size = new Size(275, 62);
            btnFinanceReport.TabIndex = 11;
            btnFinanceReport.Text = "Finance Report";
            btnFinanceReport.UseVisualStyleBackColor = true;
            btnFinanceReport.Click += btnFinanceReport_Click;
            // 
            // btnHistory
            // 
            btnHistory.Location = new Point(35, 462);
            btnHistory.Margin = new Padding(4);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(275, 62);
            btnHistory.TabIndex = 10;
            btnHistory.Text = "History";
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnMonitoring
            // 
            btnMonitoring.Location = new Point(35, 392);
            btnMonitoring.Margin = new Padding(4);
            btnMonitoring.Name = "btnMonitoring";
            btnMonitoring.Size = new Size(275, 62);
            btnMonitoring.TabIndex = 9;
            btnMonitoring.Text = "Monitoring";
            btnMonitoring.UseVisualStyleBackColor = true;
            btnMonitoring.Click += btnMonitoring_Click;
            // 
            // btnBagStorage
            // 
            btnBagStorage.Location = new Point(35, 322);
            btnBagStorage.Margin = new Padding(4);
            btnBagStorage.Name = "btnBagStorage";
            btnBagStorage.Size = new Size(275, 62);
            btnBagStorage.TabIndex = 8;
            btnBagStorage.Text = "Bag Storage";
            btnBagStorage.UseVisualStyleBackColor = true;
            btnBagStorage.Click += btnBagStorage_Click;
            // 
            // btnUserData
            // 
            btnUserData.BackColor = Color.DeepSkyBlue;
            btnUserData.Location = new Point(35, 252);
            btnUserData.Margin = new Padding(4);
            btnUserData.Name = "btnUserData";
            btnUserData.Size = new Size(275, 62);
            btnUserData.TabIndex = 7;
            btnUserData.Text = "User Data";
            btnUserData.UseVisualStyleBackColor = false;
            btnUserData.Click += button6_Click;
            // 
            // btnParkingData
            // 
            btnParkingData.Location = new Point(35, 182);
            btnParkingData.Margin = new Padding(4);
            btnParkingData.Name = "btnParkingData";
            btnParkingData.Size = new Size(275, 62);
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
            label2.Location = new Point(81, 15);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(243, 76);
            label2.TabIndex = 0;
            label2.Text = "SMART PARKING\r\nADMIN";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(6, 15);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.White;
            btnDashboard.Location = new Point(35, 112);
            btnDashboard.Margin = new Padding(4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(275, 62);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click_1;
            // 
            // lblUserData
            // 
            lblUserData.AutoSize = true;
            lblUserData.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserData.Location = new Point(379, 11);
            lblUserData.Margin = new Padding(4, 0, 4, 0);
            lblUserData.Name = "lblUserData";
            lblUserData.Size = new Size(209, 54);
            lblUserData.TabIndex = 24;
            lblUserData.Text = "User Data";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(lblJumlahPetugas);
            panel5.Controls.Add(lblTotalPetugas);
            panel5.Controls.Add(pictureBox5);
            panel5.Location = new Point(616, 4);
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new Size(300, 150);
            panel5.TabIndex = 7;
            // 
            // lblJumlahPetugas
            // 
            lblJumlahPetugas.AutoSize = true;
            lblJumlahPetugas.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJumlahPetugas.Location = new Point(120, 55);
            lblJumlahPetugas.Margin = new Padding(4, 0, 4, 0);
            lblJumlahPetugas.Name = "lblJumlahPetugas";
            lblJumlahPetugas.Size = new Size(47, 38);
            lblJumlahPetugas.TabIndex = 2;
            lblJumlahPetugas.Text = "85";
            // 
            // lblTotalPetugas
            // 
            lblTotalPetugas.AutoSize = true;
            lblTotalPetugas.Location = new Point(115, 29);
            lblTotalPetugas.Margin = new Padding(4, 0, 4, 0);
            lblTotalPetugas.Name = "lblTotalPetugas";
            lblTotalPetugas.Size = new Size(74, 25);
            lblTotalPetugas.TabIndex = 1;
            lblTotalPetugas.Text = "Petugas";
            lblTotalPetugas.Click += label13_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(21, 29);
            pictureBox5.Margin = new Padding(4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(86, 78);
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
            panel6.Location = new Point(924, 4);
            panel6.Margin = new Padding(4);
            panel6.Name = "panel6";
            panel6.Size = new Size(300, 150);
            panel6.TabIndex = 8;
            // 
            // lblJumlahUserAktif
            // 
            lblJumlahUserAktif.AutoSize = true;
            lblJumlahUserAktif.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJumlahUserAktif.Location = new Point(120, 55);
            lblJumlahUserAktif.Margin = new Padding(4, 0, 4, 0);
            lblJumlahUserAktif.Name = "lblJumlahUserAktif";
            lblJumlahUserAktif.Size = new Size(32, 38);
            lblJumlahUserAktif.TabIndex = 2;
            lblJumlahUserAktif.Text = "3";
            // 
            // lblUserAktif
            // 
            lblUserAktif.AutoSize = true;
            lblUserAktif.Location = new Point(115, 29);
            lblUserAktif.Margin = new Padding(4, 0, 4, 0);
            lblUserAktif.Name = "lblUserAktif";
            lblUserAktif.Size = new Size(89, 25);
            lblUserAktif.TabIndex = 1;
            lblUserAktif.Text = "User Aktif";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(21, 29);
            pictureBox6.Margin = new Padding(4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(86, 78);
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
            panel4.Location = new Point(309, 4);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 150);
            panel4.TabIndex = 6;
            // 
            // lblSemuaAdmin
            // 
            lblSemuaAdmin.AutoSize = true;
            lblSemuaAdmin.Location = new Point(115, 94);
            lblSemuaAdmin.Margin = new Padding(4, 0, 4, 0);
            lblSemuaAdmin.Name = "lblSemuaAdmin";
            lblSemuaAdmin.Size = new Size(0, 25);
            lblSemuaAdmin.TabIndex = 3;
            // 
            // lblJumlahAdmin
            // 
            lblJumlahAdmin.AutoSize = true;
            lblJumlahAdmin.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJumlahAdmin.Location = new Point(120, 55);
            lblJumlahAdmin.Margin = new Padding(4, 0, 4, 0);
            lblJumlahAdmin.Name = "lblJumlahAdmin";
            lblJumlahAdmin.Size = new Size(32, 38);
            lblJumlahAdmin.TabIndex = 2;
            lblJumlahAdmin.Text = "4";
            // 
            // lblTotalAdmin
            // 
            lblTotalAdmin.AutoSize = true;
            lblTotalAdmin.Location = new Point(115, 29);
            lblTotalAdmin.Margin = new Padding(4, 0, 4, 0);
            lblTotalAdmin.Name = "lblTotalAdmin";
            lblTotalAdmin.Size = new Size(65, 25);
            lblTotalAdmin.TabIndex = 1;
            lblTotalAdmin.Text = "Admin";
            lblTotalAdmin.Click += label10_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(21, 29);
            pictureBox4.Margin = new Padding(4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(86, 78);
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
            panel3.Location = new Point(1, 4);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 150);
            panel3.TabIndex = 5;
            panel3.Paint += panel3_Paint;
            // 
            // lblSemuaUser
            // 
            lblSemuaUser.AutoSize = true;
            lblSemuaUser.Location = new Point(115, 94);
            lblSemuaUser.Margin = new Padding(4, 0, 4, 0);
            lblSemuaUser.Name = "lblSemuaUser";
            lblSemuaUser.Size = new Size(106, 25);
            lblSemuaUser.TabIndex = 3;
            lblSemuaUser.Text = "Semua User";
            // 
            // lblJumlahUser
            // 
            lblJumlahUser.AutoSize = true;
            lblJumlahUser.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJumlahUser.Location = new Point(120, 55);
            lblJumlahUser.Margin = new Padding(4, 0, 4, 0);
            lblJumlahUser.Name = "lblJumlahUser";
            lblJumlahUser.Size = new Size(62, 38);
            lblJumlahUser.TabIndex = 2;
            lblJumlahUser.Text = "135";
            // 
            // lblTotalUser
            // 
            lblTotalUser.AutoSize = true;
            lblTotalUser.Location = new Point(115, 29);
            lblTotalUser.Margin = new Padding(4, 0, 4, 0);
            lblTotalUser.Name = "lblTotalUser";
            lblTotalUser.Size = new Size(89, 25);
            lblTotalUser.TabIndex = 1;
            lblTotalUser.Text = "Total User";
            lblTotalUser.Click += label5_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(21, 29);
            pictureBox3.Margin = new Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(86, 78);
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
            panel2.Location = new Point(465, 112);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1233, 158);
            panel2.TabIndex = 25;
            // 
            // btnTambahUser
            // 
            btnTambahUser.BackColor = Color.DodgerBlue;
            btnTambahUser.FlatStyle = FlatStyle.Flat;
            btnTambahUser.ForeColor = Color.White;
            btnTambahUser.Location = new Point(465, 309);
            btnTambahUser.Margin = new Padding(4);
            btnTambahUser.Name = "btnTambahUser";
            btnTambahUser.Size = new Size(185, 36);
            btnTambahUser.TabIndex = 26;
            btnTambahUser.Text = "+ Tambah User";
            btnTambahUser.UseVisualStyleBackColor = false;
            btnTambahUser.Click += btnTambahUser_Click;
            // 
            // cbxUser
            // 
            cbxUser.FormattingEnabled = true;
            cbxUser.Items.AddRange(new object[] { "Semua User", "Admin", "Petugas" });
            cbxUser.Location = new Point(754, 309);
            cbxUser.Margin = new Padding(4);
            cbxUser.Name = "cbxUser";
            cbxUser.Size = new Size(188, 33);
            cbxUser.TabIndex = 27;
            cbxUser.Text = "Semua User";
            cbxUser.SelectedIndexChanged += cbxUser_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Semua Status", "Online", "Offline" });
            comboBox2.Location = new Point(1019, 309);
            comboBox2.Margin = new Padding(4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(188, 33);
            comboBox2.TabIndex = 28;
            comboBox2.Text = "Semua Status";
            // 
            // panel7
            // 
            panel7.Controls.Add(dgvUser);
            panel7.Location = new Point(462, 366);
            panel7.Margin = new Padding(4);
            panel7.Name = "panel7";
            panel7.Size = new Size(1236, 420);
            panel7.TabIndex = 29;
            // 
            // dgvUser
            // 
            dgvUser.AutoGenerateColumns = false;
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.DataSource = databaseHelperBindingSource;
            dgvUser.Location = new Point(5, 4);
            dgvUser.Margin = new Padding(4);
            dgvUser.Name = "dgvUser";
            dgvUser.RowHeadersWidth = 51;
            dgvUser.Size = new Size(1228, 545);
            dgvUser.TabIndex = 0;
            dgvUser.CellContentClick += dgvUser_CellContentClick;
            // 
            // databaseHelperBindingSource
            // 
            databaseHelperBindingSource.DataSource = typeof(Database.DatabaseHelper);
            // 
            // panelUSername
            // 
            panelUSername.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelUSername.BackColor = Color.White;
            panelUSername.BorderStyle = BorderStyle.FixedSingle;
            panelUSername.Controls.Add(pictureBox2);
            panelUSername.Controls.Add(txtCariUsername);
            panelUSername.Location = new Point(1382, 299);
            panelUSername.Margin = new Padding(4);
            panelUSername.Name = "panelUSername";
            panelUSername.Size = new Size(312, 50);
            panelUSername.TabIndex = 13;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(4, 4);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // txtCariUsername
            // 
            txtCariUsername.BorderStyle = BorderStyle.None;
            txtCariUsername.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCariUsername.ForeColor = Color.Gray;
            txtCariUsername.Location = new Point(51, 9);
            txtCariUsername.Margin = new Padding(4);
            txtCariUsername.Name = "txtCariUsername";
            txtCariUsername.Size = new Size(225, 28);
            txtCariUsername.TabIndex = 3;
            txtCariUsername.Text = "Cari Username";
            // 
            // UserData
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 801);
            Controls.Add(panelUSername);
            Controls.Add(panel7);
            Controls.Add(comboBox2);
            Controls.Add(cbxUser);
            Controls.Add(btnTambahUser);
            Controls.Add(panel2);
            Controls.Add(lblUserData);
            Controls.Add(panelSidebar);
            Margin = new Padding(4);
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
            ResumeLayout(false);
            PerformLayout();
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
        private ComboBox comboBox2;
        private Panel panel7;
        private DataGridView dgvUser;
        private BindingSource databaseHelperBindingSource;
        private Panel panelUSername;
        private PictureBox pictureBox2;
        private TextBox txtCariUsername;
    }
}
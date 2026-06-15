namespace FINAL_PROJECT.forms
{
    partial class History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            label1 = new Label();
            label3 = new Label();
            panelContent = new Panel();
            dgvHistory = new DataGridView();
            txtSearch = new TextBox();
            cbJenis = new ComboBox();
            cbPetugas = new ComboBox();
            dateTimePicker2 = new DateTimePicker();
            dtMasuk = new DateTimePicker();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
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
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(280, 641);
            panelSidebar.TabIndex = 25;
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
            btnFinanceReport.Click += button2_Click;
            // 
            // btnHistory
            // 
            btnHistory.BackColor = Color.DeepSkyBlue;
            btnHistory.Location = new Point(28, 370);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(220, 50);
            btnHistory.TabIndex = 10;
            btnHistory.Text = "History";
            btnHistory.UseVisualStyleBackColor = false;
            btnHistory.Click += button3_Click;
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
            btnBagStorage.BackColor = Color.White;
            btnBagStorage.Location = new Point(28, 258);
            btnBagStorage.Name = "btnBagStorage";
            btnBagStorage.Size = new Size(220, 50);
            btnBagStorage.TabIndex = 8;
            btnBagStorage.Text = "Bag Storage";
            btnBagStorage.UseVisualStyleBackColor = false;
            btnBagStorage.Click += btnBagStorage_Click;
            // 
            // btnUserData
            // 
            btnUserData.BackColor = Color.White;
            btnUserData.Location = new Point(28, 202);
            btnUserData.Name = "btnUserData";
            btnUserData.Size = new Size(220, 50);
            btnUserData.TabIndex = 7;
            btnUserData.Text = "User Data";
            btnUserData.UseVisualStyleBackColor = false;
            btnUserData.Click += btnUserData_Click;
            // 
            // btnParkingData
            // 
            btnParkingData.Location = new Point(28, 146);
            btnParkingData.Name = "btnParkingData";
            btnParkingData.Size = new Size(220, 50);
            btnParkingData.TabIndex = 6;
            btnParkingData.Text = "Parking Data";
            btnParkingData.UseVisualStyleBackColor = true;
            btnParkingData.Click += btnParkingData_Click;
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
            btnDashboard.Click += btnDashboard_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 7);
            label1.Name = "label1";
            label1.Size = new Size(163, 54);
            label1.TabIndex = 26;
            label1.Text = "History";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 67);
            label3.Name = "label3";
            label3.Size = new Size(163, 23);
            label3.TabIndex = 27;
            label3.Text = "Dashboard / History";
            // 
            // panelContent
            // 
            panelContent.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelContent.BackColor = Color.White;
            panelContent.BackgroundImage = (Image)resources.GetObject("panelContent.BackgroundImage");
            panelContent.BackgroundImageLayout = ImageLayout.Stretch;
            panelContent.Controls.Add(dgvHistory);
            panelContent.Controls.Add(label3);
            panelContent.Controls.Add(txtSearch);
            panelContent.Controls.Add(label1);
            panelContent.Controls.Add(cbJenis);
            panelContent.Controls.Add(cbPetugas);
            panelContent.Controls.Add(dateTimePicker2);
            panelContent.Controls.Add(dtMasuk);
            panelContent.Location = new Point(280, 0);
            panelContent.Margin = new Padding(240, 110, 3, 3);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1256, 641);
            panelContent.TabIndex = 28;
            // 
            // dgvHistory
            // 
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistory.BackgroundColor = Color.White;
            dgvHistory.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvHistory.DefaultCellStyle = dataGridViewCellStyle2;
            dgvHistory.Location = new Point(17, 165);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.RowHeadersVisible = false;
            dgvHistory.RowHeadersWidth = 51;
            dgvHistory.RowTemplate.Height = 45;
            dgvHistory.Size = new Size(1227, 383);
            dgvHistory.TabIndex = 5;
            dgvHistory.CellContentClick += dgvHistory_CellContentClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(677, 121);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Cari Kode Transaksi";
            txtSearch.Size = new Size(250, 27);
            txtSearch.TabIndex = 4;
            // 
            // cbJenis
            // 
            cbJenis.FormattingEnabled = true;
            cbJenis.Items.AddRange(new object[] { "Semua Jenis", "Motor", "Mobil", "Bus" });
            cbJenis.Location = new Point(396, 123);
            cbJenis.Name = "cbJenis";
            cbJenis.Size = new Size(180, 28);
            cbJenis.TabIndex = 3;
            cbJenis.SelectedIndexChanged += cbJenis_SelectedIndexChanged;
            // 
            // cbPetugas
            // 
            cbPetugas.FormattingEnabled = true;
            cbPetugas.Items.AddRange(new object[] { "Semua Petugas", "Admin", "Petugas 1", "Petugas 2" });
            cbPetugas.Location = new Point(210, 123);
            cbPetugas.Name = "cbPetugas";
            cbPetugas.Size = new Size(180, 28);
            cbPetugas.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(20, 121);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(160, 27);
            dateTimePicker2.TabIndex = 1;
            // 
            // dtMasuk
            // 
            dtMasuk.AccessibleDescription = "waktu";
            dtMasuk.AccessibleName = "waktu masuk";
            dtMasuk.CustomFormat = "";
            dtMasuk.Format = DateTimePickerFormat.Short;
            dtMasuk.Location = new Point(20, 90);
            dtMasuk.Name = "dtMasuk";
            dtMasuk.Size = new Size(160, 27);
            dtMasuk.TabIndex = 0;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1536, 641);
            Controls.Add(panelContent);
            Controls.Add(panelSidebar);
            Name = "History";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "History";
            Load += History_Load;
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
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
        private Label label1;
        private Label label3;
        private Panel panelContent;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dtMasuk;
        private ComboBox cbPetugas;
        private TextBox txtSearch;
        private ComboBox cbJenis;
        private DataGridView dgvHistory;
    }
}
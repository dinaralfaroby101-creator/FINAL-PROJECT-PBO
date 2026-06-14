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
            panelSidebar.Margin = new Padding(4, 4, 4, 4);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(350, 801);
            panelSidebar.TabIndex = 25;
            // 
            // button1
            // 
            button1.Location = new Point(35, 602);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(275, 62);
            button1.TabIndex = 12;
            button1.Text = "Log Out";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnFinanceReport
            // 
            btnFinanceReport.Location = new Point(35, 532);
            btnFinanceReport.Margin = new Padding(4, 4, 4, 4);
            btnFinanceReport.Name = "btnFinanceReport";
            btnFinanceReport.Size = new Size(275, 62);
            btnFinanceReport.TabIndex = 11;
            btnFinanceReport.Text = "Finance Report";
            btnFinanceReport.UseVisualStyleBackColor = true;
            btnFinanceReport.Click += button2_Click;
            // 
            // btnHistory
            // 
            btnHistory.BackColor = Color.DeepSkyBlue;
            btnHistory.Location = new Point(35, 462);
            btnHistory.Margin = new Padding(4, 4, 4, 4);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(275, 62);
            btnHistory.TabIndex = 10;
            btnHistory.Text = "History";
            btnHistory.UseVisualStyleBackColor = false;
            btnHistory.Click += button3_Click;
            // 
            // btnMonitoring
            // 
            btnMonitoring.Location = new Point(35, 392);
            btnMonitoring.Margin = new Padding(4, 4, 4, 4);
            btnMonitoring.Name = "btnMonitoring";
            btnMonitoring.Size = new Size(275, 62);
            btnMonitoring.TabIndex = 9;
            btnMonitoring.Text = "Monitoring";
            btnMonitoring.UseVisualStyleBackColor = true;
            btnMonitoring.Click += btnMonitoring_Click;
            // 
            // btnBagStorage
            // 
            btnBagStorage.BackColor = Color.White;
            btnBagStorage.Location = new Point(35, 322);
            btnBagStorage.Margin = new Padding(4, 4, 4, 4);
            btnBagStorage.Name = "btnBagStorage";
            btnBagStorage.Size = new Size(275, 62);
            btnBagStorage.TabIndex = 8;
            btnBagStorage.Text = "Bag Storage";
            btnBagStorage.UseVisualStyleBackColor = false;
            btnBagStorage.Click += btnBagStorage_Click;
            // 
            // btnUserData
            // 
            btnUserData.BackColor = Color.White;
            btnUserData.Location = new Point(35, 252);
            btnUserData.Margin = new Padding(4, 4, 4, 4);
            btnUserData.Name = "btnUserData";
            btnUserData.Size = new Size(275, 62);
            btnUserData.TabIndex = 7;
            btnUserData.Text = "User Data";
            btnUserData.UseVisualStyleBackColor = false;
            btnUserData.Click += btnUserData_Click;
            // 
            // btnParkingData
            // 
            btnParkingData.Location = new Point(35, 182);
            btnParkingData.Margin = new Padding(4, 4, 4, 4);
            btnParkingData.Name = "btnParkingData";
            btnParkingData.Size = new Size(275, 62);
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
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
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
            btnDashboard.Margin = new Padding(4, 4, 4, 4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(275, 62);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(371, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(195, 65);
            label1.TabIndex = 26;
            label1.Text = "History";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(371, 79);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(199, 30);
            label3.TabIndex = 27;
            label3.Text = "Dashboard / History";
            // 
            // panelContent
            // 
            panelContent.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelContent.BackColor = Color.White;
            panelContent.Controls.Add(dgvHistory);
            panelContent.Controls.Add(txtSearch);
            panelContent.Controls.Add(cbJenis);
            panelContent.Controls.Add(cbPetugas);
            panelContent.Controls.Add(dateTimePicker2);
            panelContent.Controls.Add(dtMasuk);
            panelContent.Location = new Point(350, 112);
            panelContent.Margin = new Padding(300, 138, 4, 4);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1566, 689);
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
            dgvHistory.Location = new Point(21, 95);
            dgvHistory.Margin = new Padding(4, 4, 4, 4);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.RowHeadersVisible = false;
            dgvHistory.RowHeadersWidth = 51;
            dgvHistory.RowTemplate.Height = 45;
            dgvHistory.Size = new Size(1534, 590);
            dgvHistory.TabIndex = 5;
            dgvHistory.CellContentClick += dgvHistory_CellContentClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(848, 31);
            txtSearch.Margin = new Padding(4, 4, 4, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Cari Kode Transaksi";
            txtSearch.Size = new Size(312, 31);
            txtSearch.TabIndex = 4;
            // 
            // cbJenis
            // 
            cbJenis.FormattingEnabled = true;
            cbJenis.Items.AddRange(new object[] { "Semua Jenis", "Motor", "Mobil", "Bus" });
            cbJenis.Location = new Point(495, 30);
            cbJenis.Margin = new Padding(4, 4, 4, 4);
            cbJenis.Name = "cbJenis";
            cbJenis.Size = new Size(224, 33);
            cbJenis.TabIndex = 3;
            // 
            // cbPetugas
            // 
            cbPetugas.FormattingEnabled = true;
            cbPetugas.Items.AddRange(new object[] { "Semua Petugas", "Admin", "Petugas 1", "Petugas 2" });
            cbPetugas.Location = new Point(262, 30);
            cbPetugas.Margin = new Padding(4, 4, 4, 4);
            cbPetugas.Name = "cbPetugas";
            cbPetugas.Size = new Size(224, 33);
            cbPetugas.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(21, 54);
            dateTimePicker2.Margin = new Padding(4, 4, 4, 4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(199, 31);
            dateTimePicker2.TabIndex = 1;
            // 
            // dtMasuk
            // 
            dtMasuk.AccessibleDescription = "waktu";
            dtMasuk.AccessibleName = "waktu masuk";
            dtMasuk.CustomFormat = "";
            dtMasuk.Format = DateTimePickerFormat.Short;
            dtMasuk.Location = new Point(21, 12);
            dtMasuk.Margin = new Padding(4, 4, 4, 4);
            dtMasuk.Name = "dtMasuk";
            dtMasuk.Size = new Size(199, 31);
            dtMasuk.TabIndex = 0;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 801);
            Controls.Add(panelContent);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panelSidebar);
            Margin = new Padding(4, 4, 4, 4);
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
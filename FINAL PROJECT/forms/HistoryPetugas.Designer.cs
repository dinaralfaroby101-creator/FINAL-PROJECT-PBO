namespace FINAL_PROJECT.forms
{
    partial class HistoryPetugas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryPetugas));
            panelSidebar = new Panel();
            btnVehicleData = new Button();
            button1 = new Button();
            btnHistory = new Button();
            btnMonitoring = new Button();
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
            label20 = new Label();
            label12 = new Label();
            label4 = new Label();
            label13 = new Label();
            label15 = new Label();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.Navy;
            panelSidebar.Controls.Add(label15);
            panelSidebar.Controls.Add(label13);
            panelSidebar.Controls.Add(label4);
            panelSidebar.Controls.Add(label12);
            panelSidebar.Controls.Add(label20);
            panelSidebar.Controls.Add(btnVehicleData);
            panelSidebar.Controls.Add(button1);
            panelSidebar.Controls.Add(btnHistory);
            panelSidebar.Controls.Add(btnMonitoring);
            panelSidebar.Controls.Add(label2);
            panelSidebar.Controls.Add(pictureBox1);
            panelSidebar.Controls.Add(btnDashboard);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(280, 641);
            panelSidebar.TabIndex = 25;
            // 
            // btnVehicleData
            // 
            btnVehicleData.BackColor = Color.White;
            btnVehicleData.Location = new Point(28, 166);
            btnVehicleData.Name = "btnVehicleData";
            btnVehicleData.Size = new Size(220, 50);
            btnVehicleData.TabIndex = 14;
            btnVehicleData.Text = "Vehicle Data";
            btnVehicleData.UseVisualStyleBackColor = false;
            btnVehicleData.Click += btnVehicleData_Click;
            // 
            // button1
            // 
            button1.Location = new Point(28, 482);
            button1.Name = "button1";
            button1.Size = new Size(220, 50);
            button1.TabIndex = 12;
            button1.Text = "Log Out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnHistory
            // 
            btnHistory.BackColor = Color.DeepSkyBlue;
            btnHistory.Location = new Point(28, 315);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(220, 50);
            btnHistory.TabIndex = 10;
            btnHistory.Text = "History";
            btnHistory.UseVisualStyleBackColor = false;
            btnHistory.Click += button3_Click;
            // 
            // btnMonitoring
            // 
            btnMonitoring.Location = new Point(28, 241);
            btnMonitoring.Name = "btnMonitoring";
            btnMonitoring.Size = new Size(220, 50);
            btnMonitoring.TabIndex = 9;
            btnMonitoring.Text = "Monitoring";
            btnMonitoring.UseVisualStyleBackColor = true;
            btnMonitoring.Click += btnMonitoring_Click;
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
            label2.Text = "SMART PARKING\r\nPETUGAS";
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
            label1.Location = new Point(17, 6);
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
            label3.Location = new Point(17, 60);
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
            panelContent.Size = new Size(1253, 641);
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
            dgvHistory.Location = new Point(14, 153);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.RowHeadersVisible = false;
            dgvHistory.RowHeadersWidth = 51;
            dgvHistory.RowTemplate.Height = 45;
            dgvHistory.Size = new Size(1227, 437);
            dgvHistory.TabIndex = 5;
            dgvHistory.CellContentClick += dgvHistory_CellContentClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(994, 102);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Cari Kode Transaksi";
            txtSearch.Size = new Size(250, 27);
            txtSearch.TabIndex = 4;
            // 
            // cbJenis
            // 
            cbJenis.FormattingEnabled = true;
            cbJenis.Items.AddRange(new object[] { "Semua Jenis", "Motor", "Mobil", "Bus" });
            cbJenis.Location = new Point(396, 110);
            cbJenis.Name = "cbJenis";
            cbJenis.Size = new Size(180, 28);
            cbJenis.TabIndex = 3;
            // 
            // cbPetugas
            // 
            cbPetugas.FormattingEnabled = true;
            cbPetugas.Items.AddRange(new object[] { "Semua Petugas", "Admin", "Petugas 1", "Petugas 2" });
            cbPetugas.Location = new Point(210, 110);
            cbPetugas.Name = "cbPetugas";
            cbPetugas.Size = new Size(180, 28);
            cbPetugas.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(17, 120);
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
            dtMasuk.Location = new Point(17, 86);
            dtMasuk.Name = "dtMasuk";
            dtMasuk.Size = new Size(160, 27);
            dtMasuk.TabIndex = 0;
            // 
            // label20
            // 
            label20.BackColor = Color.White;
            label20.Image = (Image)resources.GetObject("label20.Image");
            label20.Location = new Point(38, 489);
            label20.Name = "label20";
            label20.Size = new Size(42, 38);
            label20.TabIndex = 23;
            // 
            // label12
            // 
            label12.BackColor = Color.DeepSkyBlue;
            label12.Image = (Image)resources.GetObject("label12.Image");
            label12.Location = new Point(38, 320);
            label12.Name = "label12";
            label12.Size = new Size(42, 38);
            label12.TabIndex = 24;
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(38, 247);
            label4.Name = "label4";
            label4.Size = new Size(42, 38);
            label4.TabIndex = 25;
            // 
            // label13
            // 
            label13.BackColor = Color.White;
            label13.Image = (Image)resources.GetObject("label13.Image");
            label13.Location = new Point(38, 170);
            label13.Name = "label13";
            label13.Size = new Size(42, 38);
            label13.TabIndex = 26;
            // 
            // label15
            // 
            label15.BackColor = Color.White;
            label15.Image = (Image)resources.GetObject("label15.Image");
            label15.Location = new Point(38, 96);
            label15.Name = "label15";
            label15.Size = new Size(42, 38);
            label15.TabIndex = 27;
            // 
            // HistoryPetugas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1536, 641);
            Controls.Add(panelContent);
            Controls.Add(panelSidebar);
            Name = "HistoryPetugas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "History";
            Load += HistoryPetugas_Load;
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
        private Button btnHistory;
        private Button btnMonitoring;
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
        private Button btnVehicleData;
        private Label label20;
        private Label label12;
        private Label label4;
        private Label label13;
        private Label label15;
    }
}
namespace FINAL_PROJECT
{
    partial class FinanceReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinanceReport));
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
            panelConten = new Panel();
            panelSearch = new Panel();
            label3 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            PanelPendapatan = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelConten.SuspendLayout();
            panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            PanelPendapatan.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
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
            panelSidebar.TabIndex = 26;
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
            btnFinanceReport.BackColor = Color.DeepSkyBlue;
            btnFinanceReport.Location = new Point(28, 426);
            btnFinanceReport.Name = "btnFinanceReport";
            btnFinanceReport.Size = new Size(220, 50);
            btnFinanceReport.TabIndex = 11;
            btnFinanceReport.Text = "Finance Report";
            btnFinanceReport.UseVisualStyleBackColor = false;
            btnFinanceReport.Click += button2_Click;
            // 
            // btnHistory
            // 
            btnHistory.BackColor = Color.White;
            btnHistory.Location = new Point(28, 370);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(220, 50);
            btnHistory.TabIndex = 10;
            btnHistory.Text = "History";
            btnHistory.UseVisualStyleBackColor = false;
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
            // panelConten
            // 
            panelConten.BackColor = Color.WhiteSmoke;
            panelConten.Controls.Add(panel2);
            panelConten.Controls.Add(panel1);
            panelConten.Controls.Add(PanelPendapatan);
            panelConten.Controls.Add(panelSearch);
            panelConten.Controls.Add(label3);
            panelConten.Controls.Add(label1);
            panelConten.Dock = DockStyle.Fill;
            panelConten.Location = new Point(280, 0);
            panelConten.Name = "panelConten";
            panelConten.Size = new Size(1256, 641);
            panelConten.TabIndex = 27;
            panelConten.Paint += panelConten_Paint;
            // 
            // panelSearch
            // 
            panelSearch.BackColor = Color.White;
            panelSearch.BorderStyle = BorderStyle.FixedSingle;
            panelSearch.Controls.Add(textBox1);
            panelSearch.Controls.Add(pictureBox2);
            panelSearch.Location = new Point(613, 34);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(250, 40);
            panelSearch.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(6, 50);
            label3.Name = "label3";
            label3.Size = new Size(235, 23);
            label3.TabIndex = 1;
            label3.Text = "Dashboard / Finance Report";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 9);
            label1.Name = "label1";
            label1.Size = new Size(230, 41);
            label1.TabIndex = 0;
            label1.Text = "Finance Report";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(45, 9);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Cari Sesuatu Disini..";
            textBox1.Size = new Size(146, 20);
            textBox1.TabIndex = 4;
            // 
            // PanelPendapatan
            // 
            PanelPendapatan.BackColor = Color.White;
            PanelPendapatan.Controls.Add(pictureBox3);
            PanelPendapatan.Location = new Point(78, 90);
            PanelPendapatan.Name = "PanelPendapatan";
            PanelPendapatan.Size = new Size(220, 125);
            PanelPendapatan.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox4);
            panel1.Location = new Point(304, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 125);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox5);
            panel2.Location = new Point(530, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 125);
            panel2.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(5, 19);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(82, 78);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(5, 19);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(82, 78);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(5, 19);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(82, 78);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            // 
            // FinanceReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1536, 641);
            Controls.Add(panelConten);
            Controls.Add(panelSidebar);
            Name = "FinanceReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FinanceReport";
            Load += FinanceReport_Load;
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelConten.ResumeLayout(false);
            panelConten.PerformLayout();
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            PanelPendapatan.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
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
        private Panel panelConten;
        private Label label1;
        private Panel panelSearch;
        private Label label3;
        private TextBox textBox1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Panel panel1;
        private Panel PanelPendapatan;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
    }
}
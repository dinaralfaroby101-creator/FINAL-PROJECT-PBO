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
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // FinanceReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1536, 641);
            Controls.Add(panelSidebar);
            Name = "FinanceReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FinanceReport";
            Load += FinanceReport_Load;
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}
namespace FINAL_PROJECT
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panelSidebar = new Panel();
            btnDashBoard = new Button();
            panelContent = new Panel();
            picLogo = new PictureBox();
            label1 = new Label();
            btnParkingData = new Button();
            btnUserData = new Button();
            btnBagStorage = new Button();
            btnMonitoring = new Button();
            btnHistory = new Button();
            btnFinanceReport = new Button();
            btnLogOut = new Button();
            lblDashboard = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            panelSidebar.SuspendLayout();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.Navy;
            panelSidebar.Controls.Add(btnLogOut);
            panelSidebar.Controls.Add(btnFinanceReport);
            panelSidebar.Controls.Add(btnHistory);
            panelSidebar.Controls.Add(btnMonitoring);
            panelSidebar.Controls.Add(btnBagStorage);
            panelSidebar.Controls.Add(btnUserData);
            panelSidebar.Controls.Add(btnParkingData);
            panelSidebar.Controls.Add(label1);
            panelSidebar.Controls.Add(picLogo);
            panelSidebar.Controls.Add(btnDashBoard);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(280, 640);
            panelSidebar.TabIndex = 0;
            // 
            // btnDashBoard
            // 
            btnDashBoard.Location = new Point(28, 90);
            btnDashBoard.Name = "btnDashBoard";
            btnDashBoard.Size = new Size(220, 50);
            btnDashBoard.TabIndex = 1;
            btnDashBoard.Text = "Dashboard";
            btnDashBoard.UseVisualStyleBackColor = true;
            btnDashBoard.Click += button1_Click;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.WhiteSmoke;
            panelContent.Controls.Add(pictureBox1);
            panelContent.Controls.Add(textBox1);
            panelContent.Controls.Add(label2);
            panelContent.Controls.Add(lblDashboard);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(280, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1254, 640);
            panelContent.TabIndex = 1;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(65, 12);
            label1.Name = "label1";
            label1.Size = new Size(199, 62);
            label1.TabIndex = 0;
            label1.Text = "SMART PARKING\r\nADMIN";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // btnParkingData
            // 
            btnParkingData.Location = new Point(28, 146);
            btnParkingData.Name = "btnParkingData";
            btnParkingData.Size = new Size(220, 50);
            btnParkingData.TabIndex = 6;
            btnParkingData.Text = "Parking Data";
            btnParkingData.UseVisualStyleBackColor = true;
            // 
            // btnUserData
            // 
            btnUserData.Location = new Point(28, 202);
            btnUserData.Name = "btnUserData";
            btnUserData.Size = new Size(220, 50);
            btnUserData.TabIndex = 7;
            btnUserData.Text = "User Data";
            btnUserData.UseVisualStyleBackColor = true;
            // 
            // btnBagStorage
            // 
            btnBagStorage.Location = new Point(28, 258);
            btnBagStorage.Name = "btnBagStorage";
            btnBagStorage.Size = new Size(220, 50);
            btnBagStorage.TabIndex = 8;
            btnBagStorage.Text = "Bag Storage";
            btnBagStorage.UseVisualStyleBackColor = true;
            // 
            // btnMonitoring
            // 
            btnMonitoring.Location = new Point(28, 314);
            btnMonitoring.Name = "btnMonitoring";
            btnMonitoring.Size = new Size(220, 50);
            btnMonitoring.TabIndex = 9;
            btnMonitoring.Text = "Monitoring";
            btnMonitoring.UseVisualStyleBackColor = true;
            // 
            // btnHistory
            // 
            btnHistory.Location = new Point(28, 370);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(220, 50);
            btnHistory.TabIndex = 10;
            btnHistory.Text = "History";
            btnHistory.UseVisualStyleBackColor = true;
            // 
            // btnFinanceReport
            // 
            btnFinanceReport.Location = new Point(28, 426);
            btnFinanceReport.Name = "btnFinanceReport";
            btnFinanceReport.Size = new Size(220, 50);
            btnFinanceReport.TabIndex = 11;
            btnFinanceReport.Text = "Finance Report";
            btnFinanceReport.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(28, 482);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(220, 50);
            btnLogOut.TabIndex = 12;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboard.Location = new Point(0, 12);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(231, 46);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "DASHBOARD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 52);
            label2.Name = "label2";
            label2.Size = new Size(250, 20);
            label2.TabIndex = 1;
            label2.Text = "Selamat Datang di Dasboard Admin";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(698, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 27);
            textBox1.TabIndex = 2;
            textBox1.Text = "Cari sesuatu...";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1019, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1534, 640);
            Controls.Add(panelContent);
            Controls.Add(panelSidebar);
            Name = "Dashboard";
            Text = "Dashboard";
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Button btnDashBoard;
        private Panel panelContent;
        private Label label1;
        private PictureBox picLogo;
        private Button btnFinanceReport;
        private Button btnHistory;
        private Button btnMonitoring;
        private Button btnBagStorage;
        private Button btnUserData;
        private Button btnParkingData;
        private Button btnLogOut;
        private Label lblDashboard;
        private TextBox textBox1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}
namespace FINAL_PROJECT.forms

{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            panelLeft = new Panel();
            pictureBox1 = new PictureBox();
            panelRight = new Panel();
            button1 = new Button();
            icon_Mata = new PictureBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            logoSpark = new PictureBox();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icon_Mata).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoSpark).BeginInit();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackgroundImage = (Image)resources.GetObject("panelLeft.BackgroundImage");
            panelLeft.Controls.Add(pictureBox1);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(507, 641);
            panelLeft.TabIndex = 0;
            panelLeft.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.logoSP;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(193, 258);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 128);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.Transparent;
            panelRight.BackgroundImage = (Image)resources.GetObject("panelRight.BackgroundImage");
            panelRight.Controls.Add(button1);
            panelRight.Controls.Add(icon_Mata);
            panelRight.Controls.Add(txtPassword);
            panelRight.Controls.Add(txtUsername);
            panelRight.Controls.Add(label2);
            panelRight.Controls.Add(label1);
            panelRight.Controls.Add(logoSpark);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(507, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(1029, 641);
            panelRight.TabIndex = 1;
            panelRight.Paint += panel2_Paint;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(531, 466);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // icon_Mata
            // 
            icon_Mata.BackgroundImage = Properties.Resources.eye_close;
            icon_Mata.BackgroundImageLayout = ImageLayout.Zoom;
            icon_Mata.Location = new Point(649, 425);
            icon_Mata.Name = "icon_Mata";
            icon_Mata.Size = new Size(28, 23);
            icon_Mata.TabIndex = 5;
            icon_Mata.TabStop = false;
            icon_Mata.Click += pictureBox2_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(508, 421);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(141, 27);
            txtPassword.TabIndex = 4;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(508, 370);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(141, 27);
            txtUsername.TabIndex = 3;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(438, 324);
            label2.Name = "label2";
            label2.Size = new Size(312, 20);
            label2.TabIndex = 2;
            label2.Text = "Smart Parking Allocation  Revenue Kontrol ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(544, 292);
            label1.Name = "label1";
            label1.Size = new Size(76, 22);
            label1.TabIndex = 1;
            label1.Text = "SPARK";
            // 
            // logoSpark
            // 
            logoSpark.BackgroundImage = Properties.Resources.logo;
            logoSpark.BackgroundImageLayout = ImageLayout.Zoom;
            logoSpark.Location = new Point(508, 148);
            logoSpark.Name = "logoSpark";
            logoSpark.Size = new Size(141, 128);
            logoSpark.TabIndex = 0;
            logoSpark.TabStop = false;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1536, 641);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            Margin = new Padding(2);
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            Load += Form1_Load;
            panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)icon_Mata).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoSpark).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft;
        private Panel panelRight;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private PictureBox logoSpark;
        private PictureBox icon_Mata;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button button1;
    }
}

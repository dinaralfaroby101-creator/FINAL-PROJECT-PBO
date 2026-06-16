namespace FINAL_PROJECT.forms
{
    partial class InputUser_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputUser_));
            cmbRole = new ComboBox();
            lbl = new Label();
            btnBatal = new Button();
            btnSimpan = new Button();
            lblArea = new Label();
            lblStatus = new Label();
            lblKendaraan = new Label();
            txtNamaUser = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblInputSLot = new Label();
            SuspendLayout();
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "admin", "petugas" });
            cmbRole.Location = new Point(773, 308);
            cmbRole.Margin = new Padding(3, 4, 3, 4);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(147, 28);
            cmbRole.TabIndex = 57;
            cmbRole.SelectedIndexChanged += cmbRole_SelectedIndexChanged;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.BackColor = SystemColors.ActiveCaption;
            lbl.Font = new Font("Dubai", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl.ForeColor = Color.Black;
            lbl.Location = new Point(618, 110);
            lbl.Name = "lbl";
            lbl.Size = new Size(60, 32);
            lbl.TabIndex = 44;
            lbl.Text = "Nama";
            lbl.Click += lblInputUser_Click;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.Red;
            btnBatal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBatal.Location = new Point(790, 572);
            btnBatal.Margin = new Padding(3, 4, 3, 4);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(129, 44);
            btnBatal.TabIndex = 54;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.Chartreuse;
            btnSimpan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpan.Location = new Point(618, 572);
            btnSimpan.Margin = new Padding(3, 4, 3, 4);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(129, 44);
            btnSimpan.TabIndex = 53;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.BackColor = SystemColors.ActiveCaption;
            lblArea.Font = new Font("Dubai", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblArea.ForeColor = Color.Black;
            lblArea.Location = new Point(618, 171);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(94, 32);
            lblArea.TabIndex = 47;
            lblArea.Text = "Username";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = SystemColors.ActiveCaption;
            lblStatus.Font = new Font("Dubai", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.Black;
            lblStatus.Location = new Point(618, 303);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(48, 32);
            lblStatus.TabIndex = 46;
            lblStatus.Text = "Role";
            // 
            // lblKendaraan
            // 
            lblKendaraan.AutoSize = true;
            lblKendaraan.BackColor = SystemColors.ActiveCaption;
            lblKendaraan.Font = new Font("Dubai", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKendaraan.ForeColor = Color.Black;
            lblKendaraan.Location = new Point(618, 239);
            lblKendaraan.Name = "lblKendaraan";
            lblKendaraan.Size = new Size(90, 32);
            lblKendaraan.TabIndex = 45;
            lblKendaraan.Text = "Password";
            // 
            // txtNamaUser
            // 
            txtNamaUser.BackColor = SystemColors.Window;
            txtNamaUser.Location = new Point(773, 110);
            txtNamaUser.Margin = new Padding(3, 4, 3, 4);
            txtNamaUser.Name = "txtNamaUser";
            txtNamaUser.Size = new Size(146, 27);
            txtNamaUser.TabIndex = 43;
            txtNamaUser.TextChanged += txtNamaUser_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.Window;
            txtUsername.Location = new Point(773, 174);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(146, 27);
            txtUsername.TabIndex = 58;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Window;
            txtPassword.Location = new Point(773, 242);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(146, 27);
            txtPassword.TabIndex = 59;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // lblInputSLot
            // 
            lblInputSLot.AutoSize = true;
            lblInputSLot.Font = new Font("Palatino Linotype", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInputSLot.Location = new Point(670, 22);
            lblInputSLot.Name = "lblInputSLot";
            lblInputSLot.Size = new Size(186, 46);
            lblInputSLot.TabIndex = 60;
            lblInputSLot.Text = "Input User\r\n";
            // 
            // InputUser_
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1536, 641);
            Controls.Add(lblInputSLot);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(cmbRole);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Controls.Add(lblArea);
            Controls.Add(lblStatus);
            Controls.Add(lblKendaraan);
            Controls.Add(lbl);
            Controls.Add(txtNamaUser);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "InputUser_";
            Text = "InputUser_";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbRole;
        private ComboBox cmbArea;
        private Label lbl;
        private Button btnBatal;
        private Button btnSimpan;
        private Label lblMasuk;
        private ComboBox cmsJenisKendaraan;
        private DateTimePicker dtpMasuk;
        private TextBox txtPlatNomer;
        private Label lblPlatNomer;
        private Label lblArea;
        private Label lblStatus;
        private Label lblKendaraan;
        private Label lblKodeSlot;
        private TextBox txtNamaUser;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblInputSLot;
    }
}
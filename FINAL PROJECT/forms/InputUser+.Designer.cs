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
            cmbRole = new ComboBox();
            lbl = new Label();
            btnBatal = new Button();
            btnSimpan = new Button();
            lblArea = new Label();
            lblStatus = new Label();
            lblKendaraan = new Label();
            this.lbl = new Label();
            txtNamaUser = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "admin", "petugas" });
            cmbRole.Location = new Point(966, 385);
            cmbRole.Margin = new Padding(4, 5, 4, 5);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(183, 33);
            cmbRole.TabIndex = 57;
            cmbRole.SelectedIndexChanged += cmbRole_SelectedIndexChanged;
            // 
            // lblInputUser
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Palatino Linotype", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl.Location = new Point(767, 30);
            lbl.Margin = new Padding(4, 0, 4, 0);
            lbl.Name = "lblInputUser";
            lbl.Size = new Size(388, 56);
            lbl.TabIndex = 55;
            lbl.Text = "Input Tambah User";
            lbl.Click += lblInputUser_Click;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.Red;
            btnBatal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBatal.Location = new Point(988, 715);
            btnBatal.Margin = new Padding(4, 5, 4, 5);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(161, 55);
            btnBatal.TabIndex = 54;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.Chartreuse;
            btnSimpan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpan.Location = new Point(772, 715);
            btnSimpan.Margin = new Padding(4, 5, 4, 5);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(161, 55);
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
            lblArea.Location = new Point(773, 214);
            lblArea.Margin = new Padding(4, 0, 4, 0);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(113, 39);
            lblArea.TabIndex = 47;
            lblArea.Text = "Username";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = SystemColors.ActiveCaption;
            lblStatus.Font = new Font("Dubai", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.Black;
            lblStatus.Location = new Point(773, 379);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(58, 39);
            lblStatus.TabIndex = 46;
            lblStatus.Text = "Role";
            // 
            // lblKendaraan
            // 
            lblKendaraan.AutoSize = true;
            lblKendaraan.BackColor = SystemColors.ActiveCaption;
            lblKendaraan.Font = new Font("Dubai", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKendaraan.ForeColor = Color.Black;
            lblKendaraan.Location = new Point(773, 299);
            lblKendaraan.Margin = new Padding(4, 0, 4, 0);
            lblKendaraan.Name = "lblKendaraan";
            lblKendaraan.Size = new Size(108, 39);
            lblKendaraan.TabIndex = 45;
            lblKendaraan.Text = "Password";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = SystemColors.ActiveCaption;
            this.lbl.Font = new Font("Dubai", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lbl.ForeColor = Color.Black;
            this.lbl.Location = new Point(773, 137);
            this.lbl.Margin = new Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new Size(73, 39);
            this.lbl.TabIndex = 44;
            this.lbl.Text = "Nama";
            // 
            // txtNamaUser
            // 
            txtNamaUser.BackColor = SystemColors.Window;
            txtNamaUser.Location = new Point(966, 137);
            txtNamaUser.Margin = new Padding(4, 5, 4, 5);
            txtNamaUser.Name = "txtNamaUser";
            txtNamaUser.Size = new Size(181, 31);
            txtNamaUser.TabIndex = 43;
            txtNamaUser.TextChanged += txtNamaUser_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.Window;
            txtUsername.Location = new Point(966, 217);
            txtUsername.Margin = new Padding(4, 5, 4, 5);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(181, 31);
            txtUsername.TabIndex = 58;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Window;
            txtPassword.Location = new Point(966, 303);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(181, 31);
            txtPassword.TabIndex = 59;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // InputUser_
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 801);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(cmbRole);
            Controls.Add(lbl);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Controls.Add(lblArea);
            Controls.Add(lblStatus);
            Controls.Add(lblKendaraan);
            Controls.Add(this.lbl);
            Controls.Add(txtNamaUser);
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
    }
}
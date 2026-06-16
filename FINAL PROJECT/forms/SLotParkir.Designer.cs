namespace FINAL_PROJECT.forms
{
    partial class SLotParkir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SLotParkir));
            cmsJenisKendaraan = new ComboBox();
            lblArea = new Label();
            lblStatus = new Label();
            lblKendaraan = new Label();
            lblKodeSlot = new Label();
            txtKode = new TextBox();
            btnBatal = new Button();
            btnSimpan = new Button();
            lblInputSLot = new Label();
            cmbArea = new ComboBox();
            cmbStatus = new ComboBox();
            SuspendLayout();
            // 
            // cmsJenisKendaraan
            // 
            cmsJenisKendaraan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmsJenisKendaraan.FormattingEnabled = true;
            cmsJenisKendaraan.Items.AddRange(new object[] { "Bus", "Mobil", "Motor" });
            cmsJenisKendaraan.Location = new Point(761, 246);
            cmsJenisKendaraan.Margin = new Padding(3, 4, 3, 4);
            cmsJenisKendaraan.Name = "cmsJenisKendaraan";
            cmsJenisKendaraan.Size = new Size(147, 28);
            cmsJenisKendaraan.TabIndex = 35;
            cmsJenisKendaraan.SelectedIndexChanged += comboStatus_SelectedIndexChanged;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.BackColor = SystemColors.ActiveCaption;
            lblArea.Font = new Font("Dubai", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblArea.ForeColor = Color.Black;
            lblArea.Location = new Point(606, 174);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(51, 32);
            lblArea.TabIndex = 27;
            lblArea.Text = "Area";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = SystemColors.ActiveCaption;
            lblStatus.Font = new Font("Dubai", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.Black;
            lblStatus.Location = new Point(606, 306);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(65, 32);
            lblStatus.TabIndex = 25;
            lblStatus.Text = "Status";
            // 
            // lblKendaraan
            // 
            lblKendaraan.AutoSize = true;
            lblKendaraan.BackColor = SystemColors.ActiveCaption;
            lblKendaraan.Font = new Font("Dubai", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKendaraan.ForeColor = Color.Black;
            lblKendaraan.Location = new Point(606, 242);
            lblKendaraan.Name = "lblKendaraan";
            lblKendaraan.Size = new Size(143, 32);
            lblKendaraan.TabIndex = 23;
            lblKendaraan.Text = "Jenis Kendaraan";
            // 
            // lblKodeSlot
            // 
            lblKodeSlot.AutoSize = true;
            lblKodeSlot.BackColor = SystemColors.ActiveCaption;
            lblKodeSlot.Font = new Font("Dubai", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKodeSlot.ForeColor = Color.Black;
            lblKodeSlot.Location = new Point(606, 112);
            lblKodeSlot.Name = "lblKodeSlot";
            lblKodeSlot.Size = new Size(96, 32);
            lblKodeSlot.TabIndex = 22;
            lblKodeSlot.Text = "Kode SLot";
            // 
            // txtKode
            // 
            txtKode.BackColor = SystemColors.Window;
            txtKode.Location = new Point(761, 112);
            txtKode.Margin = new Padding(3, 4, 3, 4);
            txtKode.Name = "txtKode";
            txtKode.Size = new Size(146, 27);
            txtKode.TabIndex = 21;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.Red;
            btnBatal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBatal.Location = new Point(778, 574);
            btnBatal.Margin = new Padding(3, 4, 3, 4);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(129, 44);
            btnBatal.TabIndex = 38;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.Chartreuse;
            btnSimpan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpan.Location = new Point(606, 574);
            btnSimpan.Margin = new Padding(3, 4, 3, 4);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(129, 44);
            btnSimpan.TabIndex = 37;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click_1;
            // 
            // lblInputSLot
            // 
            lblInputSLot.AutoSize = true;
            lblInputSLot.Font = new Font("Palatino Linotype", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInputSLot.Location = new Point(610, 26);
            lblInputSLot.Name = "lblInputSLot";
            lblInputSLot.Size = new Size(281, 46);
            lblInputSLot.TabIndex = 39;
            lblInputSLot.Text = "Input Slot Parkir";
            lblInputSLot.Click += label1_Click;
            // 
            // cmbArea
            // 
            cmbArea.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbArea.FormattingEnabled = true;
            cmbArea.Items.AddRange(new object[] { "Area A", "Area B", "Area C" });
            cmbArea.Location = new Point(761, 178);
            cmbArea.Margin = new Padding(3, 4, 3, 4);
            cmbArea.Name = "cmbArea";
            cmbArea.Size = new Size(147, 28);
            cmbArea.TabIndex = 40;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Kosong", "Terisi" });
            cmbStatus.Location = new Point(761, 310);
            cmbStatus.Margin = new Padding(3, 4, 3, 4);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(147, 28);
            cmbStatus.TabIndex = 42;
            // 
            // SLotParkir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1528, 659);
            Controls.Add(cmbStatus);
            Controls.Add(cmbArea);
            Controls.Add(lblInputSLot);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Controls.Add(cmsJenisKendaraan);
            Controls.Add(lblArea);
            Controls.Add(lblStatus);
            Controls.Add(lblKendaraan);
            Controls.Add(lblKodeSlot);
            Controls.Add(txtKode);
            Margin = new Padding(2);
            Name = "SLotParkir";
            Text = "SLotParkir";
            Load += SLotParkir_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmsJenisKendaraan;
        private Label lblArea;
        private Label lblStatus;
        private Label lblKendaraan;
        private Label lblKodeSlot;
        private TextBox txtKode;
        private Button btnBatal;
        private Button btnSimpan;
        private Label lblInputSLot;
        private ComboBox cmbArea;
        private ComboBox cmbStatus;
    }
}
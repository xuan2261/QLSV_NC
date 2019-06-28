namespace QLSV_NC.GUI
{
    partial class UcHocPhan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcHocPhan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cboMaGV = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDsHocPhan = new System.Windows.Forms.DataGridView();
            this.colMaHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoDVHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenHP = new System.Windows.Forms.TextBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.txtMaHP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudSoTC = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudSoDVHT = new System.Windows.Forms.NumericUpDown();
            this.chkTenGV = new System.Windows.Forms.CheckBox();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnGhi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXemTatCa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsHocPhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoDVHT)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(779, 48);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(67, 28);
            this.btnTimKiem.TabIndex = 22;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cboMaGV
            // 
            this.cboMaGV.FormattingEnabled = true;
            this.cboMaGV.Location = new System.Drawing.Point(136, 211);
            this.cboMaGV.Name = "cboMaGV";
            this.cboMaGV.Size = new System.Drawing.Size(221, 21);
            this.cboMaGV.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Mã Giáo Viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Số tín chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tên học phần:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(398, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tìm kiếm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mã học phần:";
            // 
            // dgvDsHocPhan
            // 
            this.dgvDsHocPhan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDsHocPhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDsHocPhan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDsHocPhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsHocPhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHP,
            this.colTenHP,
            this.colSoTC,
            this.colSoDVHT,
            this.colMaGV});
            this.dgvDsHocPhan.Location = new System.Drawing.Point(17, 288);
            this.dgvDsHocPhan.Name = "dgvDsHocPhan";
            this.dgvDsHocPhan.ReadOnly = true;
            this.dgvDsHocPhan.Size = new System.Drawing.Size(838, 285);
            this.dgvDsHocPhan.TabIndex = 14;
            this.dgvDsHocPhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDsHocPhan_CellClick);
            // 
            // colMaHP
            // 
            this.colMaHP.DataPropertyName = "maHP";
            this.colMaHP.HeaderText = "Mã HP";
            this.colMaHP.Name = "colMaHP";
            this.colMaHP.ReadOnly = true;
            // 
            // colTenHP
            // 
            this.colTenHP.DataPropertyName = "tenHP";
            this.colTenHP.HeaderText = "Tên học phần";
            this.colTenHP.Name = "colTenHP";
            this.colTenHP.ReadOnly = true;
            // 
            // colSoTC
            // 
            this.colSoTC.DataPropertyName = "soTC";
            this.colSoTC.HeaderText = "Số tín chỉ";
            this.colSoTC.Name = "colSoTC";
            this.colSoTC.ReadOnly = true;
            // 
            // colSoDVHT
            // 
            this.colSoDVHT.DataPropertyName = "soDVHT";
            this.colSoDVHT.HeaderText = "Số ĐVHT";
            this.colSoDVHT.Name = "colSoDVHT";
            this.colSoDVHT.ReadOnly = true;
            // 
            // colMaGV
            // 
            this.colMaGV.DataPropertyName = "maGV";
            this.colMaGV.HeaderText = "Mã Giáo viên";
            this.colMaGV.Name = "colMaGV";
            this.colMaGV.ReadOnly = true;
            // 
            // txtTenHP
            // 
            this.txtTenHP.Location = new System.Drawing.Point(136, 92);
            this.txtTenHP.Name = "txtTenHP";
            this.txtTenHP.Size = new System.Drawing.Size(221, 20);
            this.txtTenHP.TabIndex = 11;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(470, 55);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(295, 20);
            this.txtTimKiem.TabIndex = 9;
            // 
            // txtMaHP
            // 
            this.txtMaHP.Location = new System.Drawing.Point(136, 56);
            this.txtMaHP.Name = "txtMaHP";
            this.txtMaHP.Size = new System.Drawing.Size(221, 20);
            this.txtMaHP.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quản lý học phần";
            // 
            // nudSoTC
            // 
            this.nudSoTC.Location = new System.Drawing.Point(136, 127);
            this.nudSoTC.Name = "nudSoTC";
            this.nudSoTC.Size = new System.Drawing.Size(221, 20);
            this.nudSoTC.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Số ĐVHT:";
            // 
            // nudSoDVHT
            // 
            this.nudSoDVHT.Location = new System.Drawing.Point(136, 170);
            this.nudSoDVHT.Name = "nudSoDVHT";
            this.nudSoDVHT.Size = new System.Drawing.Size(221, 20);
            this.nudSoDVHT.TabIndex = 28;
            // 
            // chkTenGV
            // 
            this.chkTenGV.AutoSize = true;
            this.chkTenGV.Location = new System.Drawing.Point(43, 235);
            this.chkTenGV.Name = "chkTenGV";
            this.chkTenGV.Size = new System.Drawing.Size(63, 17);
            this.chkTenGV.TabIndex = 30;
            this.chkTenGV.Text = "Tên GV";
            this.chkTenGV.UseVisualStyleBackColor = true;
            this.chkTenGV.CheckedChanged += new System.EventHandler(this.chkTenGV_CheckedChanged);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoQua.Image = ((System.Drawing.Image)(resources.GetObject("btnBoQua.Image")));
            this.btnBoQua.Location = new System.Drawing.Point(707, 108);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(119, 55);
            this.btnBoQua.TabIndex = 35;
            this.btnBoQua.Text = "Bỏ Qua";
            this.btnBoQua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhi.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.Image")));
            this.btnGhi.Location = new System.Drawing.Point(707, 196);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(119, 55);
            this.btnGhi.TabIndex = 36;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(552, 108);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(119, 55);
            this.btnXoa.TabIndex = 34;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(552, 196);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(119, 55);
            this.btnSua.TabIndex = 33;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(403, 196);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(119, 55);
            this.btnThem.TabIndex = 32;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXemTatCa
            // 
            this.btnXemTatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemTatCa.Image = ((System.Drawing.Image)(resources.GetObject("btnXemTatCa.Image")));
            this.btnXemTatCa.Location = new System.Drawing.Point(403, 107);
            this.btnXemTatCa.Name = "btnXemTatCa";
            this.btnXemTatCa.Size = new System.Drawing.Size(119, 55);
            this.btnXemTatCa.TabIndex = 31;
            this.btnXemTatCa.Text = "Xem tất cả";
            this.btnXemTatCa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXemTatCa.UseVisualStyleBackColor = true;
            this.btnXemTatCa.Click += new System.EventHandler(this.btnXemTatCa_Click);
            // 
            // UcHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnGhi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXemTatCa);
            this.Controls.Add(this.chkTenGV);
            this.Controls.Add(this.nudSoDVHT);
            this.Controls.Add(this.nudSoTC);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.cboMaGV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDsHocPhan);
            this.Controls.Add(this.txtTenHP);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.txtMaHP);
            this.Controls.Add(this.label1);
            this.Name = "UcHocPhan";
            this.Size = new System.Drawing.Size(872, 587);
            this.Load += new System.EventHandler(this.UcHocPhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsHocPhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoDVHT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cboMaGV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDsHocPhan;
        private System.Windows.Forms.TextBox txtTenHP;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.TextBox txtMaHP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudSoTC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudSoDVHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoDVHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaGV;
        private System.Windows.Forms.CheckBox chkTenGV;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXemTatCa;
    }
}

namespace QLSV_NC.GUI
{
    partial class UcDiemHocPhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcDiemHocPhan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDsDiemHP = new System.Windows.Forms.DataGridView();
            this.colMaDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemTX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDiemThi = new System.Windows.Forms.TextBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMaDK = new System.Windows.Forms.ComboBox();
            this.txtDiemCC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiemTX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiemHP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnGhi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXemTatCa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsDiemHP)).BeginInit();
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
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Điểm Thi";
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
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mã đăng ký:";
            // 
            // dgvDsDiemHP
            // 
            this.dgvDsDiemHP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDsDiemHP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDsDiemHP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDsDiemHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsDiemHP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDK,
            this.colDiemCC,
            this.colDiemTX,
            this.colDiemThi,
            this.colDiemHP,
            this.colGhiChu});
            this.dgvDsDiemHP.Location = new System.Drawing.Point(17, 288);
            this.dgvDsDiemHP.Name = "dgvDsDiemHP";
            this.dgvDsDiemHP.ReadOnly = true;
            this.dgvDsDiemHP.Size = new System.Drawing.Size(838, 285);
            this.dgvDsDiemHP.TabIndex = 14;
            this.dgvDsDiemHP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDsDiemHP_CellClick);
            // 
            // colMaDK
            // 
            this.colMaDK.DataPropertyName = "maDK";
            this.colMaDK.HeaderText = "Mã ĐK";
            this.colMaDK.Name = "colMaDK";
            this.colMaDK.ReadOnly = true;
            // 
            // colDiemCC
            // 
            this.colDiemCC.DataPropertyName = "diemCC";
            this.colDiemCC.HeaderText = "Điểm CC";
            this.colDiemCC.Name = "colDiemCC";
            this.colDiemCC.ReadOnly = true;
            // 
            // colDiemTX
            // 
            this.colDiemTX.DataPropertyName = "diemTX";
            this.colDiemTX.HeaderText = "Điểm TX";
            this.colDiemTX.Name = "colDiemTX";
            this.colDiemTX.ReadOnly = true;
            // 
            // colDiemThi
            // 
            this.colDiemThi.DataPropertyName = "diemThi";
            this.colDiemThi.HeaderText = "Điểm Thi";
            this.colDiemThi.Name = "colDiemThi";
            this.colDiemThi.ReadOnly = true;
            // 
            // colDiemHP
            // 
            this.colDiemHP.DataPropertyName = "diemHP";
            this.colDiemHP.HeaderText = "Điểm HP";
            this.colDiemHP.Name = "colDiemHP";
            this.colDiemHP.ReadOnly = true;
            // 
            // colGhiChu
            // 
            this.colGhiChu.DataPropertyName = "ghiChu";
            this.colGhiChu.HeaderText = "Ghi Chú";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.ReadOnly = true;
            // 
            // txtDiemThi
            // 
            this.txtDiemThi.Location = new System.Drawing.Point(136, 166);
            this.txtDiemThi.Name = "txtDiemThi";
            this.txtDiemThi.Size = new System.Drawing.Size(221, 20);
            this.txtDiemThi.TabIndex = 13;
            this.txtDiemThi.Leave += new System.EventHandler(this.txtDiemThi_Leave);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(470, 55);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(295, 20);
            this.txtTimKiem.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quản lý điểm học phần";
            // 
            // cboMaDK
            // 
            this.cboMaDK.FormattingEnabled = true;
            this.cboMaDK.Location = new System.Drawing.Point(136, 54);
            this.cboMaDK.Name = "cboMaDK";
            this.cboMaDK.Size = new System.Drawing.Size(221, 21);
            this.cboMaDK.TabIndex = 21;
            // 
            // txtDiemCC
            // 
            this.txtDiemCC.Location = new System.Drawing.Point(136, 92);
            this.txtDiemCC.Name = "txtDiemCC";
            this.txtDiemCC.Size = new System.Drawing.Size(221, 20);
            this.txtDiemCC.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Điểm CC:";
            // 
            // txtDiemTX
            // 
            this.txtDiemTX.Location = new System.Drawing.Point(136, 129);
            this.txtDiemTX.Name = "txtDiemTX";
            this.txtDiemTX.Size = new System.Drawing.Size(221, 20);
            this.txtDiemTX.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Điểm TX:";
            // 
            // txtDiemHP
            // 
            this.txtDiemHP.Location = new System.Drawing.Point(136, 203);
            this.txtDiemHP.Name = "txtDiemHP";
            this.txtDiemHP.ReadOnly = true;
            this.txtDiemHP.Size = new System.Drawing.Size(221, 20);
            this.txtDiemHP.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Điểm HP:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(136, 240);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(221, 20);
            this.txtGhiChu.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Ghi Chú:";
            // 
            // btnBoQua
            // 
            this.btnBoQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoQua.Image = ((System.Drawing.Image)(resources.GetObject("btnBoQua.Image")));
            this.btnBoQua.Location = new System.Drawing.Point(710, 111);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(119, 55);
            this.btnBoQua.TabIndex = 32;
            this.btnBoQua.Text = "Bỏ Qua";
            this.btnBoQua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhi.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.Image")));
            this.btnGhi.Location = new System.Drawing.Point(710, 199);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(119, 55);
            this.btnGhi.TabIndex = 33;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(555, 111);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(119, 55);
            this.btnXoa.TabIndex = 31;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(555, 199);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(119, 55);
            this.btnSua.TabIndex = 30;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(406, 199);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(119, 55);
            this.btnThem.TabIndex = 29;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXemTatCa
            // 
            this.btnXemTatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemTatCa.Image = ((System.Drawing.Image)(resources.GetObject("btnXemTatCa.Image")));
            this.btnXemTatCa.Location = new System.Drawing.Point(406, 110);
            this.btnXemTatCa.Name = "btnXemTatCa";
            this.btnXemTatCa.Size = new System.Drawing.Size(119, 55);
            this.btnXemTatCa.TabIndex = 28;
            this.btnXemTatCa.Text = "Xem tất cả";
            this.btnXemTatCa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXemTatCa.UseVisualStyleBackColor = true;
            this.btnXemTatCa.Click += new System.EventHandler(this.btnXemTatCa_Click);
            // 
            // UcDiemHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnGhi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXemTatCa);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.cboMaDK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDsDiemHP);
            this.Controls.Add(this.txtDiemTX);
            this.Controls.Add(this.txtDiemCC);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtDiemHP);
            this.Controls.Add(this.txtDiemThi);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label1);
            this.Name = "UcDiemHocPhan";
            this.Size = new System.Drawing.Size(872, 587);
            this.Load += new System.EventHandler(this.UcDiemHocPhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsDiemHP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDsDiemHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemTX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
        private System.Windows.Forms.TextBox txtDiemThi;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMaDK;
        private System.Windows.Forms.TextBox txtDiemCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiemTX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiemHP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXemTatCa;
    }
}

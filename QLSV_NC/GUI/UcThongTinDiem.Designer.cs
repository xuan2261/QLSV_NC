namespace QLSV_NC.GUI
{
    partial class UcThongTinDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcThongTinDiem));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblMaDK = new System.Windows.Forms.Label();
            this.dgvDsDiemSV = new System.Windows.Forms.DataGridView();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtMaDangKy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colMaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemTX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radMaSV = new System.Windows.Forms.RadioButton();
            this.radMaDK = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsDiemSV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(710, 137);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(92, 53);
            this.btnTimKiem.TabIndex = 50;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSV.Location = new System.Drawing.Point(207, 30);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(121, 16);
            this.lblMaSV.TabIndex = 47;
            this.lblMaSV.Text = "Nhập mã sinh viên:";
            // 
            // lblMaDK
            // 
            this.lblMaDK.AutoSize = true;
            this.lblMaDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDK.Location = new System.Drawing.Point(207, 70);
            this.lblMaDK.Name = "lblMaDK";
            this.lblMaDK.Size = new System.Drawing.Size(81, 16);
            this.lblMaDK.TabIndex = 44;
            this.lblMaDK.Text = "Mã đăng ký:";
            // 
            // dgvDsDiemSV
            // 
            this.dgvDsDiemSV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDsDiemSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDsDiemSV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDsDiemSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsDiemSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSV,
            this.colHoTen,
            this.colMaDK,
            this.colTenHP,
            this.colDiemCC,
            this.colDiemTX,
            this.colDiemThi,
            this.colDiemHP});
            this.dgvDsDiemSV.Location = new System.Drawing.Point(17, 288);
            this.dgvDsDiemSV.Name = "dgvDsDiemSV";
            this.dgvDsDiemSV.ReadOnly = true;
            this.dgvDsDiemSV.Size = new System.Drawing.Size(838, 285);
            this.dgvDsDiemSV.TabIndex = 41;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(334, 29);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(221, 20);
            this.txtMaSV.TabIndex = 40;
            // 
            // txtMaDangKy
            // 
            this.txtMaDangKy.Location = new System.Drawing.Point(334, 66);
            this.txtMaDangKy.Name = "txtMaDangKy";
            this.txtMaDangKy.Size = new System.Drawing.Size(221, 20);
            this.txtMaDangKy.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 24);
            this.label1.TabIndex = 34;
            this.label1.Text = "THÔNG TIN ĐIỂM SINH VIÊN";
            // 
            // colMaSV
            // 
            this.colMaSV.DataPropertyName = "maSV";
            this.colMaSV.HeaderText = "Mã SV";
            this.colMaSV.Name = "colMaSV";
            this.colMaSV.ReadOnly = true;
            // 
            // colHoTen
            // 
            this.colHoTen.DataPropertyName = "hoTen";
            this.colHoTen.HeaderText = "Họ tên";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.ReadOnly = true;
            // 
            // colMaDK
            // 
            this.colMaDK.DataPropertyName = "maDK";
            this.colMaDK.HeaderText = "Mã ĐK";
            this.colMaDK.Name = "colMaDK";
            this.colMaDK.ReadOnly = true;
            // 
            // colTenHP
            // 
            this.colTenHP.DataPropertyName = "tenHP";
            this.colTenHP.HeaderText = "Tên học phần";
            this.colTenHP.Name = "colTenHP";
            this.colTenHP.ReadOnly = true;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radMaDK);
            this.groupBox1.Controls.Add(this.radMaSV);
            this.groupBox1.Controls.Add(this.txtMaSV);
            this.groupBox1.Controls.Add(this.txtMaDangKy);
            this.groupBox1.Controls.Add(this.lblMaSV);
            this.groupBox1.Controls.Add(this.lblMaDK);
            this.groupBox1.Location = new System.Drawing.Point(95, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 122);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa chọn tìm kiếm";
            // 
            // radMaSV
            // 
            this.radMaSV.AutoSize = true;
            this.radMaSV.Checked = true;
            this.radMaSV.Location = new System.Drawing.Point(28, 29);
            this.radMaSV.Name = "radMaSV";
            this.radMaSV.Size = new System.Drawing.Size(112, 17);
            this.radMaSV.TabIndex = 48;
            this.radMaSV.TabStop = true;
            this.radMaSV.Text = "Theo mã sinh viên";
            this.radMaSV.UseVisualStyleBackColor = true;
            this.radMaSV.CheckedChanged += new System.EventHandler(this.radMaSV_CheckedChanged);
            // 
            // radMaDK
            // 
            this.radMaDK.AutoSize = true;
            this.radMaDK.Location = new System.Drawing.Point(28, 72);
            this.radMaDK.Name = "radMaDK";
            this.radMaDK.Size = new System.Drawing.Size(109, 17);
            this.radMaDK.TabIndex = 49;
            this.radMaDK.Text = "Theo mã đăng ký";
            this.radMaDK.UseVisualStyleBackColor = true;
            this.radMaDK.CheckedChanged += new System.EventHandler(this.radMaDK_CheckedChanged);
            // 
            // UcThongTinDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dgvDsDiemSV);
            this.Controls.Add(this.label1);
            this.Name = "UcThongTinDiem";
            this.Size = new System.Drawing.Size(872, 587);
            this.Load += new System.EventHandler(this.UcThongTinDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsDiemSV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblMaDK;
        private System.Windows.Forms.DataGridView dgvDsDiemSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtMaDangKy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemTX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemHP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radMaDK;
        private System.Windows.Forms.RadioButton radMaSV;
    }
}

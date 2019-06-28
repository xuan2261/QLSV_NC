namespace QLSV_NC
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.tlpMenu = new System.Windows.Forms.TableLayoutPanel();
            this.btnQLSV = new System.Windows.Forms.Button();
            this.btnQLGV = new System.Windows.Forms.Button();
            this.btnQLLop = new System.Windows.Forms.Button();
            this.btnQLHP = new System.Windows.Forms.Button();
            this.btnQLCTDT = new System.Windows.Forms.Button();
            this.btnQLDKy = new System.Windows.Forms.Button();
            this.btnQLDHP = new System.Windows.Forms.Button();
            this.plnMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tlpMenu.SuspendLayout();
            this.plnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMenu
            // 
            this.tlpMenu.ColumnCount = 1;
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMenu.Controls.Add(this.btnQLSV, 0, 0);
            this.tlpMenu.Controls.Add(this.btnQLGV, 0, 1);
            this.tlpMenu.Controls.Add(this.btnQLLop, 0, 2);
            this.tlpMenu.Controls.Add(this.btnQLHP, 0, 3);
            this.tlpMenu.Controls.Add(this.btnQLCTDT, 0, 4);
            this.tlpMenu.Controls.Add(this.btnQLDKy, 0, 5);
            this.tlpMenu.Controls.Add(this.btnQLDHP, 0, 6);
            this.tlpMenu.Location = new System.Drawing.Point(3, 12);
            this.tlpMenu.Name = "tlpMenu";
            this.tlpMenu.RowCount = 7;
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.89916F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.10084F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlpMenu.Size = new System.Drawing.Size(130, 597);
            this.tlpMenu.TabIndex = 0;
            // 
            // btnQLSV
            // 
            this.btnQLSV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQLSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLSV.Image = ((System.Drawing.Image)(resources.GetObject("btnQLSV.Image")));
            this.btnQLSV.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQLSV.Location = new System.Drawing.Point(3, 3);
            this.btnQLSV.Name = "btnQLSV";
            this.btnQLSV.Size = new System.Drawing.Size(124, 69);
            this.btnQLSV.TabIndex = 1;
            this.btnQLSV.Text = "Quản lý sinh viên";
            this.btnQLSV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQLSV.UseVisualStyleBackColor = false;
            this.btnQLSV.Click += new System.EventHandler(this.btnQLSV_Click);
            // 
            // btnQLGV
            // 
            this.btnQLGV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQLGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLGV.Image = ((System.Drawing.Image)(resources.GetObject("btnQLGV.Image")));
            this.btnQLGV.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQLGV.Location = new System.Drawing.Point(3, 78);
            this.btnQLGV.Name = "btnQLGV";
            this.btnQLGV.Size = new System.Drawing.Size(124, 76);
            this.btnQLGV.TabIndex = 1;
            this.btnQLGV.Text = "Quản lý giáo viên";
            this.btnQLGV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQLGV.UseVisualStyleBackColor = false;
            this.btnQLGV.Click += new System.EventHandler(this.btnQLGV_Click);
            // 
            // btnQLLop
            // 
            this.btnQLLop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQLLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLLop.Image = ((System.Drawing.Image)(resources.GetObject("btnQLLop.Image")));
            this.btnQLLop.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQLLop.Location = new System.Drawing.Point(3, 160);
            this.btnQLLop.Name = "btnQLLop";
            this.btnQLLop.Size = new System.Drawing.Size(124, 76);
            this.btnQLLop.TabIndex = 1;
            this.btnQLLop.Text = "Quản lý lớp";
            this.btnQLLop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQLLop.UseVisualStyleBackColor = false;
            this.btnQLLop.Click += new System.EventHandler(this.btnQLLop_Click);
            // 
            // btnQLHP
            // 
            this.btnQLHP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQLHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLHP.Image = ((System.Drawing.Image)(resources.GetObject("btnQLHP.Image")));
            this.btnQLHP.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQLHP.Location = new System.Drawing.Point(3, 243);
            this.btnQLHP.Name = "btnQLHP";
            this.btnQLHP.Size = new System.Drawing.Size(124, 85);
            this.btnQLHP.TabIndex = 1;
            this.btnQLHP.Text = "Quản lý học phần";
            this.btnQLHP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQLHP.UseVisualStyleBackColor = false;
            this.btnQLHP.Click += new System.EventHandler(this.btnQLHP_Click);
            // 
            // btnQLCTDT
            // 
            this.btnQLCTDT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQLCTDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLCTDT.Image = ((System.Drawing.Image)(resources.GetObject("btnQLCTDT.Image")));
            this.btnQLCTDT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQLCTDT.Location = new System.Drawing.Point(3, 334);
            this.btnQLCTDT.Name = "btnQLCTDT";
            this.btnQLCTDT.Size = new System.Drawing.Size(124, 80);
            this.btnQLCTDT.TabIndex = 1;
            this.btnQLCTDT.Text = "Quản lý CT Đào tạo";
            this.btnQLCTDT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQLCTDT.UseVisualStyleBackColor = false;
            this.btnQLCTDT.Click += new System.EventHandler(this.btnQLCTDT_Click);
            // 
            // btnQLDKy
            // 
            this.btnQLDKy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQLDKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLDKy.Image = ((System.Drawing.Image)(resources.GetObject("btnQLDKy.Image")));
            this.btnQLDKy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQLDKy.Location = new System.Drawing.Point(3, 420);
            this.btnQLDKy.Name = "btnQLDKy";
            this.btnQLDKy.Size = new System.Drawing.Size(124, 80);
            this.btnQLDKy.TabIndex = 1;
            this.btnQLDKy.Text = "Quản lý đăng ký";
            this.btnQLDKy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQLDKy.UseVisualStyleBackColor = false;
            this.btnQLDKy.Click += new System.EventHandler(this.btnQLDKy_Click);
            // 
            // btnQLDHP
            // 
            this.btnQLDHP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQLDHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLDHP.Image = ((System.Drawing.Image)(resources.GetObject("btnQLDHP.Image")));
            this.btnQLDHP.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQLDHP.Location = new System.Drawing.Point(3, 509);
            this.btnQLDHP.Name = "btnQLDHP";
            this.btnQLDHP.Size = new System.Drawing.Size(124, 80);
            this.btnQLDHP.TabIndex = 1;
            this.btnQLDHP.Text = "Quản lý điểm HP";
            this.btnQLDHP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQLDHP.UseVisualStyleBackColor = false;
            this.btnQLDHP.Click += new System.EventHandler(this.btnQLDHP_Click);
            // 
            // plnMain
            // 
            this.plnMain.BackColor = System.Drawing.Color.AliceBlue;
            this.plnMain.Controls.Add(this.label1);
            this.plnMain.Controls.Add(this.pictureBox1);
            this.plnMain.Location = new System.Drawing.Point(139, 12);
            this.plnMain.Name = "plnMain";
            this.plnMain.Size = new System.Drawing.Size(872, 587);
            this.plnMain.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(212, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "PHẦN MỀM QUẢN LÝ SINH VIÊN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(66, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(742, 492);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 611);
            this.Controls.Add(this.plnMain);
            this.Controls.Add(this.tlpMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.Text = "Quản lý sinh viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.tlpMenu.ResumeLayout(false);
            this.plnMain.ResumeLayout(false);
            this.plnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMenu;
        private System.Windows.Forms.Button btnQLSV;
        private System.Windows.Forms.Panel plnMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnQLGV;
        private System.Windows.Forms.Button btnQLLop;
        private System.Windows.Forms.Button btnQLHP;
        private System.Windows.Forms.Button btnQLCTDT;
        private System.Windows.Forms.Button btnQLDKy;
        private System.Windows.Forms.Button btnQLDHP;
    }
}


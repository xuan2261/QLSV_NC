using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV_NC.Class;
using QLSV_NC.BLL;

namespace QLSV_NC.GUI
{
    public partial class UcLop : UserControl
    {
        Lop lop = new Lop();
        LopBLL bll = new LopBLL();
        int index;
        string action = "";

        public UcLop()
        {
            InitializeComponent();
        }

        private void btnXemTatCa_Click(object sender, EventArgs e)
        {
            dgvDsLop.DataSource = bll.LayDSLop();
        }

        private void LockControlGhi()
        {
            btnGhi.Enabled = false;
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            txtMaLop.ReadOnly = true;
            txtTenLop.ReadOnly = true;
            cboMaLopTruong.Enabled = false;
            cboMaGVCN.Enabled = false;
        }

        private void UnLockControlGhi()
        {
            btnGhi.Enabled = true;
            btnBoQua.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            txtMaLop.ReadOnly = false;
            txtTenLop.ReadOnly = false;
            cboMaLopTruong.Enabled = true;
            cboMaGVCN.Enabled = true;
        }

        private void LaySVML()
        {
            cboMaLopTruong.DataSource = bll.LaySV(txtMaLop.Text.Trim());
            cboMaLopTruong.DisplayMember = "maSV";
            cboMaLopTruong.ValueMember = "maSV";
        }

        private void UcLop_Load(object sender, EventArgs e)
        {
            LockControlGhi();

            btnXemTatCa_Click(sender, e);
        }

        private void DatLai()
        {
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            cboMaLopTruong.Text = "";
            cboMaGVCN.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            UnLockControlGhi();
            action = "them";
            DatLai();

            cboMaGVCN.DataSource = bll.LayGV();
            cboMaGVCN.DisplayMember = "maGV";
            cboMaGVCN.ValueMember = "maGV";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Bạn chưa chọn học phần");
            }
            else
            {
                UnLockControlGhi();
                txtMaLop.ReadOnly = true;
                action = "sua";
                LaySVML();
            }
        }

        private void dgvDsLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;

            if (index >= 0)
            {
                DataGridViewRow row = dgvDsLop.Rows[index];
                txtMaLop.Text = row.Cells[0].Value.ToString();
                txtTenLop.Text = row.Cells[1].Value.ToString();
                cboMaLopTruong.Text = row.Cells[2].Value.ToString();
                cboMaGVCN.Text = row.Cells[3].Value.ToString();
            }
        }

        private void LayThongTin()
        {
            lop.maLop = txtMaLop.Text.Trim();
            lop.tenLop = txtTenLop.Text.Trim();
            lop.maLT = cboMaLopTruong.SelectedValue.ToString();
            lop.maGVCN = cboMaGVCN.SelectedValue.ToString();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            try
            {
                LayThongTin();
                if (action == "them")
                {
                    if (lop.maLop == string.Empty)
                    {
                        MessageBox.Show("Mã lớp không được để trống.");
                    }
                    else if (lop.tenLop == string.Empty)
                    {
                        MessageBox.Show("Tên lớp không được để trống.");
                    }
                    if (lop.maGVCN == string.Empty)
                    {
                        MessageBox.Show("Mã giáo viên chủ nhiệm không được để trống.");
                    }
                    else
                    {
                        if (bll.ThemLop(lop) == true)
                        {
                            MessageBox.Show("Thêm thành công");
                            dgvDsLop.DataSource = bll.TimKiemLop(lop.maLop);
                        }
                        else
                        {
                            MessageBox.Show("Không thành công");
                        }
                    }
                    LockControlGhi();
                }
                else if (action == "sua")
                {
                    if (bll.SuaLop(lop) == true)
                    {
                        MessageBox.Show("Sửa thành công.");
                        dgvDsLop.DataSource = bll.TimKiemLop(lop.maLop);
                    }
                    else
                    {
                        MessageBox.Show("Không thành công.");
                    }
                    LockControlGhi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            LockControlGhi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Bạn chưa chọn lớp");
            }
            else
            {
                LayThongTin();
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa lớp: " + lop.tenLop, "Thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    if (bll.XoaLop(lop) == true)
                    {
                        MessageBox.Show("Xóa thành công.");
                        btnXemTatCa_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Không thành công.");
                    }
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvDsLop.DataSource = bll.TimKiemLop(txtTimKiem.Text.Trim());
        }

        private void txtMaLop_TextChanged(object sender, EventArgs e)
        {
            LaySVML();
        }

        private void chkTenGV_CheckedChanged(object sender, EventArgs e)
        {
            cboMaGVCN.Text = "";
            cboMaGVCN.DataSource = bll.LayGV();
            if (chkTenGV.Checked == true)
            {
                cboMaGVCN.DisplayMember = "hoTen";
            }
            else
            {
                cboMaGVCN.DisplayMember = "maGV";
            }
            cboMaGVCN.ValueMember = "maGV";
        }

        private void chkTenSV_CheckedChanged(object sender, EventArgs e)
        {
            cboMaLopTruong.Text = "";
            cboMaLopTruong.DataSource = bll.LaySV(txtMaLop.Text.Trim());
            if (chkTenSV.Checked == true)
            {
                cboMaLopTruong.DisplayMember = "hoTen";
            }
            else
            {
                cboMaLopTruong.DisplayMember = "maSV";
            }
            cboMaLopTruong.ValueMember = "maSV";
        }
    }
}

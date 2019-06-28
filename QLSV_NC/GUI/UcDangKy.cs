using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV_NC.BLL;
using QLSV_NC.Class;

namespace QLSV_NC.GUI
{
    public partial class UcDangKy : UserControl
    {
        DangKy dk = new DangKy();
        DangKyBLL bll = new DangKyBLL();
        int index;
        string action = "";

        public UcDangKy()
        {
            InitializeComponent();
        }

        private void LockControlGhi()
        {
            btnGhi.Enabled = false;
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            dgvDsDangKy.Enabled = true;

            cboMaSV.Enabled = false;
            cboMaHP.Enabled = false;
            txtHocKyNamHoc.Enabled = false;
            chkDongTien.Enabled = false;
        }

        private void UnLockControlGhi()
        {
            btnGhi.Enabled = true;
            btnBoQua.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            dgvDsDangKy.Enabled = false;

            cboMaSV.Enabled = true;
            cboMaHP.Enabled = true;
            txtHocKyNamHoc.Enabled = true;
            chkDongTien.Enabled = true;
        }

        private string TuDongMa()
        {
            DataTable dt = bll.LayDSDangKy();
            string maDau = "DK";

            return new MaTuDong().maTuDong(dt, maDau);
        }

        private void LoadSV()
        {
            cboMaSV.DataSource = bll.LaySV();
            cboMaSV.DisplayMember = "maSV";
            cboMaSV.ValueMember = "maSV";
        }

        private void LoadHP()
        {
            cboMaHP.DataSource = bll.LayHP();
            cboMaHP.DisplayMember = "maHP";
            cboMaHP.ValueMember = "maHP";
        }

        private void UcDangKy_Load(object sender, EventArgs e)
        {
            LockControlGhi();
            LoadSV();
            LoadHP();
            btnXemTatCa_Click(sender, e);
        }

        private void btnXemTatCa_Click(object sender, EventArgs e)
        {
            dgvDsDangKy.DataSource = bll.LayDSDangKy();
        }

        private void DatLai()
        {
            txtMaDangKy.Text = "";
            cboMaSV.Text = "";
            cboMaHP.Text = "";
            txtHocKyNamHoc.Text = "";
            chkDongTien.Checked = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            UnLockControlGhi();
            DatLai();
            action = "them";
            txtMaDangKy.Text = TuDongMa();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            UnLockControlGhi();
            action = "sua";
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            LockControlGhi();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvDsDangKy.DataSource = bll.TimKiemDangKy(txtTimKiem.Text.Trim());
        }

        private void dgvDsDangKy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;

            if (index >= 0)
            {
                DataGridViewRow row = dgvDsDangKy.Rows[index];
                txtMaDangKy.Text = row.Cells[0].Value.ToString();
                cboMaSV.Text = row.Cells[1].Value.ToString();
                cboMaHP.Text = row.Cells[2].Value.ToString();
                txtHocKyNamHoc.Text = row.Cells[3].Value.ToString();
                if (row.Cells[4].Value.Equals(true))
                {
                    chkDongTien.Checked = true;
                }
                else
                {
                    chkDongTien.Checked = false;
                }
            }
        }

        private void LayThongTin()
        {
            dk.maDK = txtMaDangKy.Text.Trim();
            dk.maSV = cboMaSV.SelectedValue.ToString();
            dk.maHP = cboMaHP.SelectedValue.ToString();
            dk.hocKyNamHoc = txtHocKyNamHoc.Text.Trim();
            if (chkDongTien.Checked == true)
            {
                dk.dongTien = true;
            }
            else
            {
                dk.dongTien = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Bạn chưa chọn đăng ký nào");
            }
            else
            {
                LayThongTin();
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa đăng ký có mã: " + dk.maDK, "Thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    if (bll.XoaDangKy(dk) == true)
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

        private void btnGhi_Click(object sender, EventArgs e)
        {
            try
            {
                LayThongTin();
                if (action == "them")
                {
                    if (dk.maDK == string.Empty)
                    {
                        MessageBox.Show("Mã đăng ký không được để trống.");
                    }
                    else if (dk.maSV == string.Empty)
                    {
                        MessageBox.Show("Tên sinh viên không được để trống.");
                    }
                    else if (dk.maHP == string.Empty)
                    {
                        MessageBox.Show("Mã học phần không được để trống.");
                    } else if (dk.hocKyNamHoc == string.Empty)
                    {
                        MessageBox.Show("Học kỳ năm học không được để trống.");
                    }
                    else
                    {
                        if (bll.ThemDangKy(dk) == true)
                        {
                            MessageBox.Show("Thêm thành công");
                            LockControlGhi();
                            dgvDsDangKy.DataSource = bll.TimKiemDangKy(dk.maDK);
                        }
                        else
                        {
                            MessageBox.Show("Không thành công");
                        }
                    }
                    
                }
                else if (action == "sua")
                {
                    if (bll.SuaDangKy(dk) == true)
                    {
                        MessageBox.Show("Sửa thành công.");
                        LockControlGhi();
                        dgvDsDangKy.DataSource = bll.TimKiemDangKy(dk.maDK);
                    }
                    else
                    {
                        MessageBox.Show("Không thành công.");
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

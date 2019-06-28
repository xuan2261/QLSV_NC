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
using QLSV_NC;
using QLSV_NC.Class;

namespace QLSV_NC.GUI
{
    public partial class UcGiaoVien : UserControl
    {
        GiaoVien gv = new GiaoVien();
        GiaoVienBLL bll = new GiaoVienBLL();
        int index;
        string action = "";

        public UcGiaoVien()
        {
            InitializeComponent();
        }

        private string tuDongMa()
        {
            DataTable dt = bll.TimKiemTheoKhoa(txtKhoa.Text);
            string maDau = txtKhoa.Text;

            return new MaTuDong().maTuDong(dt, maDau);
        }

        private void LayThongTinGiaoVien()
        {
            gv.ma = txtMaGV.Text;
            gv.hoTen = txtHoTen.Text;
            gv.soDT = txtSoDT.Text;
            gv.khoa = txtKhoa.Text;
        }

        private void btnXemTatCa_Click(object sender, EventArgs e)
        {
            dgvDsGiaoVien.DataSource = bll.LayDSGV();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                UnLockControlGhi();
                DatLai();
                action = "them";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Bạn chưa chọn giáo viên");
            }
            else
            {
                UnLockControlGhi();
                action = "sua";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Bạn chưa chọn giáo viên");
            }
            else
            {
                LayThongTinGiaoVien();
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa giảng viên: " + gv.hoTen , "Thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    if (bll.XoaGV(gv) == true)
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
            dgvDsGiaoVien.DataSource = bll.TimKiemGiaoVien(txtTimKiem.Text.Trim());
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            //tu dong tim kiem khi go tu vao o tim kiem
            //dgvDsGiaoVien.DataSource = bll.TimKiemGiaoVien(txtTimKiem.Text.Trim());
        }

        private void dgvDsGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvDsGiaoVien.Rows[index];
                    
                    txtHoTen.Text = row.Cells["colHoTen"].Value.ToString();
                    txtSoDT.Text = row.Cells["colSoDT"].Value.ToString();
                    txtKhoa.Text = row.Cells["colKhoa"].Value.ToString();
                    txtMaGV.Text = row.Cells["colMaGV"].Value.ToString();
                }
                catch (Exception)
                {
                    
                }
            }
        }

        private void DatLai()
        {
            txtHoTen.Text = "";
            txtSoDT.Text = "";
            txtKhoa.Text = "";
            txtMaGV.Text = "";
        }

        private void txtKhoa_TextChanged(object sender, EventArgs e)
        {
            txtMaGV.Text = tuDongMa();
        }

        private void LockControlGhi()
        {
            btnGhi.Enabled = false;
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            txtHoTen.ReadOnly = true;
            txtSoDT.ReadOnly = true;
            txtKhoa.ReadOnly = true;
        }

        private void UnLockControlGhi()
        {
            btnGhi.Enabled = true;
            btnBoQua.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtHoTen.ReadOnly = false;
            txtSoDT.ReadOnly = false;
            txtKhoa.ReadOnly = false;
        }

        private void UcGiaoVien_Load(object sender, EventArgs e)
        {
            LockControlGhi();
            btnXemTatCa_Click(sender, e);
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            try
            {
                LayThongTinGiaoVien();
                if (action == "them")
                {
                    if (gv.ma == string.Empty)
                    {
                        MessageBox.Show("Mã giáo viên không được trống");
                    }
                    else if (gv.hoTen == string.Empty)
                    {
                        MessageBox.Show("Tên giáo viên không được trống");
                    }
                    else if (gv.khoa == string.Empty)
                    {
                        MessageBox.Show("Tên khoa không được trống");
                    }
                    else
                    {
                        if (bll.ThemGV(gv) == true)
                        {
                            MessageBox.Show("Thêm giáo viên thành công.");
                            LockControlGhi();
                            dgvDsGiaoVien.DataSource = bll.TimKiemGiaoVien(gv.ma);
                        }
                        else
                        {
                            MessageBox.Show("Thêm giáo viên không thành công.");
                        }
                    }
                }
                else if (action == "sua")
                {
                    if (bll.SuaGV(gv) == true)
                    {
                        MessageBox.Show("Sửa thành công.");
                        dgvDsGiaoVien.DataSource = bll.TimKiemGiaoVien(gv.ma);
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
    }
}

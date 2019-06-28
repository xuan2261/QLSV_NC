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

namespace QLSV_NC
{
    public partial class UcSinhVien : UserControl
    {
        SinhVien sv = new SinhVien();
        SinhVienBLL bll = new SinhVienBLL();
        int index;
        string action = "";

        public UcSinhVien()
        {
            InitializeComponent();
        }

        private string TuDongMa()
        {
            DataTable dt = bll.TimKiemTheoMaLop(cboMaLop.Text.Trim());
            string maDau = cboMaLop.Text.Trim();

            return new MaTuDong().maTuDong(dt, maDau);
        }

        private void LockControlGhi()
        {
            btnGhi.Enabled = false;
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            txtHoTen.ReadOnly = true;
            dtpNgaySinh.Enabled = false;
            txtSoDT.ReadOnly = true;
            cboMaLop.Enabled = false;
        }

        private void UnLockControlGhi()
        {
            btnGhi.Enabled = true;
            btnBoQua.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            txtHoTen.ReadOnly = false;
            dtpNgaySinh.Enabled = true;
            txtSoDT.ReadOnly = false;
            cboMaLop.Enabled = true;
        }

        private void UcSinhVien_Load(object sender, EventArgs e)
        {
            LockControlGhi();
            btnXemTatCa_Click(sender, e);
            LoadMaLop();
        }

        private void LoadMaLop()
        {
            cboMaLop.DataSource = bll.LayMaLop();
            cboMaLop.DisplayMember = "maLop";
            cboMaLop.ValueMember = "maLop";
        }

        private void DatLai()
        {
            txtMaSV.Text = "";
            txtHoTen.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            txtSoDT.Text = "";
            cboMaLop.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            UnLockControlGhi();
            DatLai();
            action = "them";
        }

        private void btnXemTatCa_Click(object sender, EventArgs e)
        {
            dgvDsSinhVien.DataSource = bll.LayDSSV();
        }

        private void dgvDsSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvDsSinhVien.Rows[index];

                    txtMaSV.Text = row.Cells[0].Value.ToString();
                    txtHoTen.Text = row.Cells[1].Value.ToString();
                    dtpNgaySinh.Value = (DateTime)row.Cells[2].Value;
                    txtSoDT.Text = row.Cells[3].Value.ToString();
                    cboMaLop.Text = row.Cells[4].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Bạn chưa chọn sinh viên.");
            }
            else
            {
                UnLockControlGhi();
                txtMaSV.Enabled = false;
                action = "sua";
            }
        }

        private void LayThongTin()
        {
            sv.ma = txtMaSV.Text.Trim();
            sv.hoTen = txtHoTen.Text.Trim();
            sv.ngaySinh = dtpNgaySinh.Value;
            sv.soDT = txtSoDT.Text.Trim();
            sv.maLop = cboMaLop.SelectedValue.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (index < 0)
            {
                MessageBox.Show("Bạn chưa chọn giáo viên");
            }
            else
            {
                LayThongTin();
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa sinh viên: " +sv.hoTen, "Thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    if (bll.XoaSV(sv) == true)
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

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            LockControlGhi();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            try
            {
                LayThongTin();
                if (action == "them")
                {
                    if (sv.ma == string.Empty)
                    {
                        MessageBox.Show("Mã sinh viên không được trống");
                    }
                    else if (sv.hoTen == string.Empty)
                    {
                        MessageBox.Show("Tên sinh viên không được trống");
                    }
                    else if (sv.maLop == string.Empty)
                    {
                        MessageBox.Show("Mã lớp không được trống");
                    }
                    else
                    {
                        if (bll.ThemSV(sv) == true)
                        {
                            MessageBox.Show("Thêm sinh viên thành công.");
                            LockControlGhi();
                            dgvDsSinhVien.DataSource = bll.TimKiemSinhVien(sv.ma);
                        }
                        else
                        {
                            MessageBox.Show("Thêm sinh viên không thành công.");
                        }
                    }
                }
                else if (action == "sua")
                {
                    if (bll.SuaSV(sv) == true)
                    {
                        MessageBox.Show("Sửa thành công.");
                        dgvDsSinhVien.DataSource = bll.TimKiemSinhVien(sv.ma);
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvDsSinhVien.DataSource = bll.TimKiemSinhVien(txtTimKiem.Text.Trim());
        }

        private void cboMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaSV.Text = TuDongMa();
        }
    }
}

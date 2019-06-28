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
    public partial class UcHocPhan : UserControl
    {
        HocPhan hp = new HocPhan();
        HocPhanBLL bll = new HocPhanBLL();
        int index;
        string action = "";

        public UcHocPhan()
        {
            InitializeComponent();
        }

        private void LayThongTinHP()
        {
            hp.maHP = txtMaHP.Text.Trim();
            hp.tenHP = txtTenHP.Text.Trim();
            hp.soTC = int.Parse(nudSoTC.Value.ToString());
            hp.soDVHT = int.Parse(nudSoDVHT.Value.ToString());
            hp.maGV = cboMaGV.SelectedValue.ToString();
        }

        private void btnXemTatCa_Click(object sender, EventArgs e)
        {
            dgvDsHocPhan.DataSource = bll.LayDSHP();
        }

        private void dgvDsHocPhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;

            if (index >=0)
            {
                DataGridViewRow row = dgvDsHocPhan.Rows[index];
                txtMaHP.Text = row.Cells["colMaHP"].Value.ToString();
                txtTenHP.Text = row.Cells[1].Value.ToString();
                nudSoTC.Text = row.Cells[2].Value.ToString();
                nudSoDVHT.Text = row.Cells[3].Value.ToString();
                cboMaGV.Text = row.Cells[4].Value.ToString();
            }
        }

        private void LockControlGhi()
        {
            btnGhi.Enabled = false;
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            txtMaHP.ReadOnly = true;
            txtTenHP.ReadOnly = true;
            nudSoTC.ReadOnly = true;
            nudSoDVHT.ReadOnly = true;
            cboMaGV.Enabled = false;
        }

        private void UnLockControlGhi()
        {
            btnGhi.Enabled = true;
            btnBoQua.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            txtMaHP.ReadOnly = false;
            txtTenHP.ReadOnly = false;
            nudSoTC.ReadOnly = false;
            nudSoDVHT.ReadOnly = false;
            cboMaGV.Enabled = true;
        }

        private void UcHocPhan_Load(object sender, EventArgs e)
        {
            LockControlGhi();

            cboMaGV.DataSource = bll.LayGV();
            cboMaGV.DisplayMember = "maGV";
            cboMaGV.ValueMember = "maGV";

            btnXemTatCa_Click(sender, e);
        }

        private void chkTenGV_CheckedChanged(object sender, EventArgs e)
        {
            cboMaGV.Text = "";
            cboMaGV.DataSource = bll.LayGV();
            if (chkTenGV.Checked == true)
            {
                cboMaGV.DisplayMember = "hoTen";
            }
            else
            {
                cboMaGV.DisplayMember = "maGV";
            }
            cboMaGV.ValueMember = "maGV";
        }

        private void DatLai()
        {
            txtMaHP.Text = "";
            txtTenHP.Text = "";
            nudSoTC.Value = 0;
            nudSoDVHT.Value = 0;
            cboMaGV.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                UnLockControlGhi();
                action = "them";
                DatLai();
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
                MessageBox.Show("Bạn chưa chọn học phần");
            }
            else
            {
                UnLockControlGhi();
                txtMaHP.ReadOnly = true;
                action = "sua";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Bạn chưa chọn học phần");
            }
            else
            {
                LayThongTinHP();
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa học phần: " + hp.tenHP, "Thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    if (bll.XoaHP(hp) == true)
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
            dgvDsHocPhan.DataSource = bll.TimKiemHocPhan(txtTimKiem.Text.Trim());
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            try
            {
                LayThongTinHP();
                if (action == "them")
                {
                    if (hp.maHP == string.Empty)
                    {
                        MessageBox.Show("Mã học phần không được để trống.");
                    }
                    else if (hp.tenHP == string.Empty)
                    {
                        MessageBox.Show("Tên học phần không được để trống.");
                    }
                    else if (hp.soTC == 0 || hp.soDVHT == 0)
                    {
                        MessageBox.Show("Chưa có số tín chỉ hoặc số đơn vị học trình");
                    }
                    if (hp.maGV == string.Empty)
                    {
                        MessageBox.Show("Mã giáo viên không được để trống.");
                    }
                    else
                    {
                        if (bll.ThemHP(hp) == true)
                        {
                            MessageBox.Show("Thêm thành công");
                            dgvDsHocPhan.DataSource = bll.TimKiemHocPhan(hp.maHP);
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
                    if (bll.SuaHP(hp) == true)
                    {
                        MessageBox.Show("Sửa thành công.");
                        dgvDsHocPhan.DataSource = bll.TimKiemHocPhan(hp.maHP);
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

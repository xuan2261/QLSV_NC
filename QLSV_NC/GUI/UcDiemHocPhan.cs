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
    public partial class UcDiemHocPhan : UserControl
    {
        DiemHP dhp = new DiemHP();
        DiemHocPhanBLL bll = new DiemHocPhanBLL();
        int index;
        string action = "";

        public UcDiemHocPhan()
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
            dgvDsDiemHP.Enabled = true;

            cboMaDK.Enabled = false;
            txtDiemCC.ReadOnly = true;
            txtDiemTX.ReadOnly = true;
            txtDiemThi.ReadOnly = true;
            txtGhiChu.ReadOnly = true;
        }

        private void UnLockControlGhi()
        {
            btnGhi.Enabled = true;
            btnBoQua.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            dgvDsDiemHP.Enabled = false;

            cboMaDK.Enabled = true;
            txtDiemCC.ReadOnly = false;
            txtDiemTX.ReadOnly = false;
            txtDiemThi.ReadOnly = false;
            txtGhiChu.ReadOnly = false;
        }

        private void LoadDK()
        {
            cboMaDK.DataSource = bll.LayDK();
            cboMaDK.DisplayMember = "maDK";
            cboMaDK.ValueMember = "maDK";
        }

        private void UcDiemHocPhan_Load(object sender, EventArgs e)
        {
            LockControlGhi();
            LoadDK();
            btnXemTatCa_Click(sender, e);
        }

        private void btnXemTatCa_Click(object sender, EventArgs e)
        {
            dgvDsDiemHP.DataSource = bll.LayDSDiemHP();
        }

        private void dgvDsDiemHP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;

            if (index >= 0)
            {
                DataGridViewRow row = dgvDsDiemHP.Rows[index];
                cboMaDK.Text = row.Cells[0].Value.ToString();
                txtDiemCC.Text = row.Cells[1].Value.ToString();
                txtDiemTX.Text = row.Cells[2].Value.ToString();
                txtDiemThi.Text = row.Cells[3].Value.ToString();
                txtDiemHP.Text = row.Cells[4].Value.ToString();
                txtGhiChu.Text = row.Cells[5].Value.ToString();
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            LockControlGhi();
        }

        private void LayThongTin()
        {
            dhp.maDK = cboMaDK.SelectedValue.ToString();
            dhp.diemCC = float.Parse(txtDiemCC.Text.ToString().Trim());
            dhp.diemTX = float.Parse(txtDiemTX.Text.ToString().Trim());
            dhp.diemThi = float.Parse(txtDiemThi.Text.ToString().Trim());
            dhp.diemHP = float.Parse(txtDiemHP.Text.ToString().Trim());
            dhp.ghiChu = txtGhiChu.Text.Trim();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Bạn chưa chọn danh mục điểm học phần nào");
            }
            else
            {
                LayThongTin();
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa điểm học phần có mã: " + dhp.maDK, "Thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    if (bll.XoaDiemHP(dhp) == true)
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

        private void DatLai()
        {
            cboMaDK.Text = "";
            txtDiemCC.Text = "";
            txtDiemTX.Text = "";
            txtDiemThi.Text = "";
            txtDiemHP.Text = "";
            txtGhiChu.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            UnLockControlGhi();
            DatLai();
            action = "them";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            UnLockControlGhi();
            action = "sua";
            cboMaDK.Enabled = false;
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            try
            {
                LayThongTin();
                if (action == "them")
                {
                    if (dhp.maDK == string.Empty)
                    {
                        MessageBox.Show("Mã đăng ký không được để trống.");
                    }
                    else if (dhp.diemCC < 0 || dhp.diemCC > 10)
                    {
                        MessageBox.Show("Điểm chuyên cần không hợp lệ.");
                    }
                    else if (dhp.diemTX < 0 || dhp.diemTX > 10)
                    {
                        MessageBox.Show("Điểm thường xuyên không hợp lệ.");
                    }
                    else if (dhp.diemThi < 0 || dhp.diemThi > 10)
                    {
                        MessageBox.Show("Điểm thi không hợp lệ.");
                    }
                    else
                    {
                        if (bll.ThemDiemHP(dhp) == true)
                        {
                            MessageBox.Show("Thêm thành công");
                            LockControlGhi();
                            dgvDsDiemHP.DataSource = bll.TimKiemDiemHP(dhp.maDK);
                        }
                        else
                        {
                            MessageBox.Show("Không thành công");
                        }
                    }

                }
                else if (action == "sua")
                {
                    if (bll.SuaDiemHP(dhp) == true)
                    {
                        MessageBox.Show("Sửa thành công.");
                        LockControlGhi();
                        dgvDsDiemHP.DataSource = bll.TimKiemDiemHP(dhp.maDK);
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

        private void txtDiemThi_Leave(object sender, EventArgs e)
        {
            double diemHP = 0;
            diemHP = float.Parse(txtDiemCC.Text.ToString()) * 0.1 + float.Parse(txtDiemTX.Text.ToString().Trim()) * 0.3 + float.Parse(txtDiemThi.Text.ToString().Trim()) * 0.6;
            txtDiemHP.Text = Math.Round( diemHP, 2).ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvDsDiemHP.DataSource = bll.TimKiemDiemHP(txtTimKiem.Text.Trim());
        }
    }
}

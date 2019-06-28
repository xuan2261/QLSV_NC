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
    public partial class UcCTDaoTao : UserControl
    {
        CTDaoTao ct = new CTDaoTao();
        CTDaoTaoBLL bll = new CTDaoTaoBLL();
        int index;
        string action;

        public UcCTDaoTao()
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

            cboMaLop.Enabled = false;
            cboMaHP.Enabled = false;
            txtHocKyNamHoc.ReadOnly = true;
        }

        private void UnLockControlGhi()
        {
            btnGhi.Enabled = true;
            btnBoQua.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            cboMaLop.Enabled = true;
            cboMaHP.Enabled = true;
            txtHocKyNamHoc.ReadOnly = false;
        }

        private void LoadMaLop()
        {
            cboMaLop.DataSource = bll.LayLop();
            cboMaLop.DisplayMember = "maLop";
            cboMaLop.ValueMember = "maLop";
        }

        private void LoadMaHP()
        {
            cboMaHP.DataSource = bll.LayHP();
            cboMaHP.DisplayMember = "maHP";
            cboMaHP.ValueMember = "maHP";
        }

        private void UcCTDaoTao_Load(object sender, EventArgs e)
        {
            LockControlGhi();
            btnXemTatCa_Click(sender, e);
            LoadMaLop();
            LoadMaHP();
        }

        private void btnXemTatCa_Click(object sender, EventArgs e)
        {
            dgvCTDaoTao.DataSource = bll.LayDSCTDaoTao();
        }

        private void dgvCTDaoTao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;

            if (index >= 0)
            {
                DataGridViewRow row = dgvCTDaoTao.Rows[index];
                cboMaLop.Text = row.Cells[0].Value.ToString();
                cboMaHP.Text = row.Cells[1].Value.ToString();
                txtHocKyNamHoc.Text = row.Cells[2].Value.ToString();
            }
        }

        private void DatLai()
        {
            cboMaLop.Text = "";
            cboMaHP.Text = "";
            txtHocKyNamHoc.Text = "";
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
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            LockControlGhi();
        }

        private void LayThongTin()
        {
            ct.maLop = cboMaLop.SelectedValue.ToString();
            ct.maHP = cboMaHP.SelectedValue.ToString();
            ct.hocKyNamHoc = txtHocKyNamHoc.Text;
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            try
            {
                LayThongTin();
                if (action == "them")
                {
                    if (ct.maLop == string.Empty)
                    {
                        MessageBox.Show("Mã lớp không được để trống.");
                    }
                    else if (ct.maHP == string.Empty)
                    {
                        MessageBox.Show("Mã học phần không được để trống.");
                    }
                    if (ct.hocKyNamHoc == string.Empty)
                    {
                        MessageBox.Show("Học kỳ năm học không được để trống.");
                    }
                    else
                    {
                        if (bll.ThemCTDaoTao(ct) == true)
                        {
                            MessageBox.Show("Thêm thành công");
                            LockControlGhi();
                            dgvCTDaoTao.DataSource = bll.TimKiemCTDaoTao(ct.maLop);
                        }
                        else
                        {
                            MessageBox.Show("Không thành công");
                        }
                    }
                    
                }
                else if (action == "sua")
                {
                    if (bll.SuaCTDaoTao(ct) == true)
                    {
                        MessageBox.Show("Sửa thành công.");
                        LockControlGhi();
                        dgvCTDaoTao.DataSource = bll.TimKiemCTDaoTao(ct.maLop);
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Bạn chưa chọn chương trình đào tạo.");
            }
            else
            {
                LayThongTin();
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa chương trình đào tạo: " + ct.maLop + "," + ct.maHP + "," + ct.hocKyNamHoc, "Thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    if (bll.XoaCTDaoTao(ct) == true)
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
            dgvCTDaoTao.DataSource = bll.TimKiemCTDaoTao(txtTimKiem.Text.Trim());
        }
    }
}

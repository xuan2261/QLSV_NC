using QLSV_NC.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV_NC.BLL;

namespace QLSV_NC.GUI
{
    public partial class frmDoiMatKhau : Form
    {
        TaiKhoanBLL bll = new TaiKhoanBLL();

        string taiKhoan;
        public frmDoiMatKhau(string taikhoan)
        {
            InitializeComponent();
            taiKhoan = taikhoan;
            txtTaikhoan.Text = taiKhoan;
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DataTable dt = bll.TimKiem(txtTaikhoan.Text.Trim(), txtMKcu.Text.Trim());

            errorProvider1.Clear();
            if (txtTaikhoan.Text == "")
                errorProvider1.SetError(txtTaikhoan, "Chưa nhập tên tài khoản !");
            else if (txtMKcu.Text == "")
            {
                errorProvider1.SetError(txtMKcu, "!");
                txtMKcu.Focus();
            }
            else if (txtMKmoi.Text == "")
            {
                errorProvider1.SetError(txtMKmoi, "!");
                txtMKmoi.Focus();
            }
            else if (txtConfimMk.Text == "")
            {
                errorProvider1.SetError(txtConfimMk, "!");
                txtConfimMk.Focus();
            }
            else if (txtConfimMk.Text != txtMKmoi.Text)
                MessageBox.Show("Bạn nhập lại password không trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (dt.Rows.Count == 0)
            {
                errorProvider1.SetError(txtMKcu, "Mật khẩu cũ không đúng");
                txtMKcu.Focus();
            }
            else
            {
                if (bll.DoiMatKhau(txtTaikhoan.Text.Trim(), txtMKmoi.Text.Trim()) == true)
                {
                    this.Close();
                    MessageBox.Show("Đổi mật khẩu thành công! Hãy đăng xuất và đăng nhập lại!");
                    //frmMenu frmMenu = new frmMenu(taiKhoan);
                    //frmMenu.đăngXuấtToolStripMenuItem_Click(sender, e);
                    //frmMenu.Close();
                }
                else
                {
                    MessageBox.Show("Không thành công!");
                }
            }
        }
    }
}

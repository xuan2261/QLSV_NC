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

namespace QLSV_NC.GUI
{
    public partial class UcThongTinDiem : UserControl
    {
        ThongTinDiemBLL bll = new ThongTinDiemBLL();

        public UcThongTinDiem()
        {
            InitializeComponent();
        }

        private void UcThongTinDiem_Load(object sender, EventArgs e)
        {
            lblMaDK.Visible = false;
            txtMaDangKy.Visible = false;
        }

        private void radMaSV_CheckedChanged(object sender, EventArgs e)
        {
            txtMaSV.Text = "";
            lblMaDK.Visible = false;
            txtMaDangKy.Visible = false;
            lblMaSV.Visible = true;
            txtMaSV.Visible = true;
        }

        private void radMaDK_CheckedChanged(object sender, EventArgs e)
        {
            txtMaDangKy.Text = "";
            lblMaDK.Visible = true;
            txtMaDangKy.Visible = true;
            lblMaSV.Visible = false;
            txtMaSV.Visible = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (radMaSV.Checked == true)
            {
                if (txtMaSV.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn chưa nhập thông tin mã sinh viên, hãy nhập vào!");
                }
                else
                {
                    dgvDsDiemSV.DataSource = bll.LayDiemMaSV(txtMaSV.Text.Trim());
                }
                
            }
            else
            {
                if (txtMaDangKy.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn chưa nhập thông tin mã đăng ký, hãy nhập vào!");
                }
                else
                {
                    dgvDsDiemSV.DataSource = bll.LayDiemMaDK(txtMaDangKy.Text.Trim());
                }
            }
        }
    }
}

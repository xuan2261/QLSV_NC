using QLSV_NC.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_NC
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void ChuyenDoi(UserControl uc)
        {
            plnMain.BackgroundImage = null;
            plnMain.Controls.Clear();
            uc.Anchor = AnchorStyles.Top;
            uc.Anchor = AnchorStyles.Left;
            uc.Dock = DockStyle.Fill;
            plnMain.Controls.Add(uc);
        }

        private void btnQLSV_Click(object sender, EventArgs e)
        {
            UcSinhVien ucSinhVien = new UcSinhVien();
            ChuyenDoi(ucSinhVien);
        }

        private void btnQLGV_Click(object sender, EventArgs e)
        {
            UcGiaoVien ucGiaoVien = new UcGiaoVien();
            ChuyenDoi(ucGiaoVien);
        }

        private void btnQLLop_Click(object sender, EventArgs e)
        {
            UcLop ucLop = new UcLop();
            ChuyenDoi(ucLop);
        }

        private void btnQLHP_Click(object sender, EventArgs e)
        {
            UcHocPhan ucHocPhan = new UcHocPhan();
            ChuyenDoi(ucHocPhan);
        }

        private void btnQLCTDT_Click(object sender, EventArgs e)
        {
            UcCTDaoTao ucCTDaoTao = new UcCTDaoTao();
            ChuyenDoi(ucCTDaoTao);
        }

        private void btnQLDKy_Click(object sender, EventArgs e)
        {
            UcDangKy ucDangKy = new UcDangKy();
            ChuyenDoi(ucDangKy);
        }

        private void btnQLDHP_Click(object sender, EventArgs e)
        {
            UcDiemHocPhan ucDiemHocPhan = new UcDiemHocPhan();
            ChuyenDoi(ucDiemHocPhan);
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            new DAL().myClose();
            Application.Exit();
        }
    }
}

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
    public partial class UcTKeDSSV : UserControl
    {
        SinhVienBLL bll = new SinhVienBLL();

        public UcTKeDSSV()
        {
            InitializeComponent();
        }

        private void LoadMaLop()
        {
            cboMaLop.DataSource = bll.LayMaLop();
            cboMaLop.DisplayMember = "maLop";
            cboMaLop.ValueMember = "maLop";
        }

        private void UcTKeDSSV_Load(object sender, EventArgs e)
        {
            LoadMaLop();
        }

        private void cboMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvDsSinhVienMLop.DataSource = bll.TKeTheoMaLop(cboMaLop.Text.Trim());
        }
    }
}

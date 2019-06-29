using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_NC.BLL
{
    class DangNhapBLL
    {
        DAL dal = new DAL();
        public DataTable TimKiem(string taiKhoan, string matKhau)
        {
            string sql = "select * from TaiKhoan where taiKhoan = '" + taiKhoan + "' and matKhau = '" + matKhau + "'";
            return dal.GetTable(sql);
        }
    }
}

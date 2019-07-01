using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_NC.BLL
{
    class TaiKhoanBLL
    {
        DAL dal = new DAL();
        public DataTable TimKiem(string taiKhoan, string matKhau)
        {
            string sql = "select * from TaiKhoan where taiKhoan = '" + taiKhoan + "' and matKhau = '" + matKhau + "'";
            return dal.GetTable(sql);
        }

        public bool DoiMatKhau(string taiKhoan, string matKhau)
        {
            string sql = "Update TaiKhoan set matKhau = @matKhau where taiKhoan = @taiKhoan";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@matKhau", matKhau),
                new SqlParameter("@taiKhoan", taiKhoan)
            };
            return dal.myExecute(sql, sqlParameters);
        }
    }
}

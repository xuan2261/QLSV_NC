using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLSV_NC.Class;
using QLSV_NC;
using System.Data;
using System.Data.SqlClient;

namespace QLSV_NC.BLL
{
    class GiaoVienBLL
    {
        DAL dal = new DAL();

        //ham lay tat ca giao vien trong bang GiaoVien
        public DataTable LayDSGV()
        {
            string sql = "select *from GiaoVien";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }

        //ham tim kiem giao vien theo khoa
        public DataTable TimKiemTheoKhoa(string khoa)
        {
            string sql = "select *from GiaoVien where khoa = '" + khoa + "'";
            return dal.GetTable(sql);
        }

        //ham them giao vien
        public bool ThemGV(GiaoVien gv)
        {
            string sql = "insert into GiaoVien(maGV, hoTen, soDT, khoa)" + "values (@maGV, @hoTen, @soDT, @khoa)";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@maGV", gv.ma),
                new SqlParameter("@hoTen", gv.hoTen),
                new SqlParameter("@soDT", gv.soDT),
                new SqlParameter("@khoa", gv.khoa)
            };
            return dal.myExecute(sql, sqlParameters);
        }

        //ham sua giao vien
        public bool SuaGV(GiaoVien gv)
        {
            string sql = "Update GiaoVien set hoTen = @hoTen, soDT = @soDT, khoa = @khoa where maGV = @maGV";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@hoTen", gv.hoTen),
                new SqlParameter("@soDT", gv.soDT),
                new SqlParameter("@khoa", gv.khoa),
                new SqlParameter("@maGV", gv.ma)
            };
            return dal.myExecute(sql, sqlParameters);
        }

        //ham xoa giao vien
        public bool XoaGV(GiaoVien gv)
        {
            string sql = "delete GiaoVien where maGV = @maGV";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@maGV", gv.ma)
            };
            return dal.myExecute(sql, sqlParameters);
        }

        public DataTable TimKiemGiaoVien(string dieuKien)
        {
            string sql = "select * from GiaoVien where maGV like N'%" + dieuKien + "%' or hoTen like N'%" + dieuKien + "%' or soDT like N'%" + dieuKien + "%' or khoa like N'%" + dieuKien + "%'";
            DataTable dt = dal.GetTable(sql);
            return dt;
        }
    }
}

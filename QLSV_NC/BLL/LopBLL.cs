using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLSV_NC.Class;
using QLSV_NC;
using System.Data;
using System.Data.SqlClient;

namespace QLSV_NC.BLL
{
    class LopBLL
    {
        DAL dal = new DAL();

        //ham lay tat ca lop trong bang Lop
        public DataTable LayDSLop()
        {
            string sql = "select *from Lop";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }

        //ham lay giang vien
        public DataTable LayGV()
        {
            string sql = "select *from GiaoVien";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }

        //ham lay giang vien
        public DataTable LaySV(string maLop)
        {
            string sql = "select *from SinhVien where SinhVien.maLop = N'" + maLop + "'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }

        //ham them lop
        public bool ThemLop(Lop lop)
        {
            string sql = "insert into Lop(maLop, tenLop, maLT, maGVCN)" + "values (@maLop, @tenLop, @maLT, @maGVCN)";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@maLop", lop.maLop),
                new SqlParameter("@tenLop", lop.tenLop),
                new SqlParameter("@maLT", lop.maLT),
                new SqlParameter("@maGVCN", lop.maGVCN)
            };
            return dal.myExecute(sql, sqlParameters);
        }

        //ham sua lop
        public bool SuaLop(Lop lop)
        {
            string sql = "Update Lop set tenLop = @tenLop, maLT = @maLT, maGVCN = @maGVCN where maLop = @maLop";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@maLop", lop.maLop),
                new SqlParameter("@tenLop", lop.tenLop),
                new SqlParameter("@maLT", lop.maLT),
                new SqlParameter("@maGVCN", lop.maGVCN)
            };
            return dal.myExecute(sql, sqlParameters);
        }

        //ham xoa lop
        public bool XoaLop(Lop lop)
        {
            string sql = "delete Lop where maLop = @maLop";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@maLop", lop.maLop)
            };
            return dal.myExecute(sql, sqlParameters);
        }

        public DataTable TimKiemLop(string dieuKien)
        {
            string sql = "select * from Lop where maLop like N'%" + dieuKien + "%' or tenLop like N'%" + dieuKien + "%' or maLT like N'%" + dieuKien + "%' or maGVCN like N'%" + dieuKien + "%'";
            DataTable dt = dal.GetTable(sql);
            return dt;
        }
    }
}

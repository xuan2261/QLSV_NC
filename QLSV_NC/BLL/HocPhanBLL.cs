using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLSV_NC.Class;

namespace QLSV_NC.BLL
{
    class HocPhanBLL
    {
        DAL dal = new DAL();

        //ham lay tat ca giao vien trong bang GiaoVien
        public DataTable LayDSHP()
        {
            string sql = "select *from HocPhan";
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

        //ham them hoc phan
        public bool ThemHP(HocPhan hp)
        {
            string sql = "insert into HocPhan(maHP, tenHP, soTC, soDVHT, maGV)" + "values (@maHP, @tenHP, @soTC, @soDVHT, @maGV)";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@maHP", hp.maHP),
                new SqlParameter("@tenHP", hp.tenHP),
                new SqlParameter("@soTC", hp.soTC),
                new SqlParameter("@soDVHT", hp.soDVHT),
                new SqlParameter("@maGV", hp.maGV)
            };
            return dal.myExecute(sql, sqlParameters);
        }

        //ham sua giao vien
        public bool SuaHP(HocPhan hp)
        {
            string sql = "Update HocPhan set tenHP = @tenHP, soTC = @soTC, soDVHT = @soDVHT, maGV = @maGV where maHP = @maHP";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@maHP", hp.maHP),
                new SqlParameter("@tenHP", hp.tenHP),
                new SqlParameter("@soTC", hp.soTC),
                new SqlParameter("@soDVHT", hp.soDVHT),
                new SqlParameter("@maGV", hp.maGV)
            };
            return dal.myExecute(sql, sqlParameters);
        }

        //ham xoa hoc phan
        public bool XoaHP(HocPhan hp)
        {
            string sql = "delete HocPhan where maHP = @maHP";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@maHP", hp.maHP)
            };
            return dal.myExecute(sql, sqlParameters);
        }

        public DataTable TimKiemHocPhan(string dieuKien)
        {
            string sql = "select * from HocPhan where maHP like N'%" + dieuKien + "%' or tenHP like N'%" + dieuKien + "%' or soTC like N'%"  + dieuKien + "%' or soDVHT like N'%" + dieuKien + "%' or maGV like N'%" + dieuKien + "%'";
            DataTable dt = dal.GetTable(sql);
            return dt;
        }
    }
}

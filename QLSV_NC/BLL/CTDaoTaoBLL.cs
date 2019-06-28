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
    class CTDaoTaoBLL
    {
        DAL dal = new DAL();

        //ham lay tat ca chuong trinh dao tao
        public DataTable LayDSCTDaoTao()
        {
            string sql = "select *from CTDaoTao";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }

        //ham lay lop
        public DataTable LayLop()
        {
            string sql = "select *from Lop";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }

        //ham lay hoc phan
        public DataTable LayHP()
        {
            string sql = "select *from HocPhan";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }

        //ham them CT dao tao
        public bool ThemCTDaoTao(CTDaoTao cTDaoTao)
        {
            string sql = "insert into CTDaoTao(maLop, maHP, hocKyNamHoc)" + "values (@maLop, @maHP, @hocKyNamHoc)";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@maLop", cTDaoTao.maLop),
                new SqlParameter("@maHP", cTDaoTao.maHP),
                new SqlParameter("@hocKyNamHoc", cTDaoTao.hocKyNamHoc)
            };
            return dal.myExecute(sql, sqlParameters);
        }

        //ham sua CT dao tao
        public bool SuaCTDaoTao(CTDaoTao cTDaoTao)
        {
            string sql = "Update CTDaoTao set maLop = @maLop, maHP = @maHP, hocKyNamHoc = @hocKyNamHoc where maLop = @maLop and maHP = @maHP";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@maLop", cTDaoTao.maLop),
                new SqlParameter("@maHP", cTDaoTao.maHP),
                new SqlParameter("@hocKyNamHoc", cTDaoTao.hocKyNamHoc)
            };
            return dal.myExecute(sql, sqlParameters);
        }

        //ham xoa CTDaoTao
        public bool XoaCTDaoTao(CTDaoTao cTDaoTao)
        {
            string sql = "delete CTDaoTao where maLop = @maLop and maHP = @maHP and hocKyNamHoc = @hocKyNamHoc";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@maLop", cTDaoTao.maLop),
                new SqlParameter("@maHP", cTDaoTao.maHP),
                new SqlParameter("@hocKyNamHoc", cTDaoTao.hocKyNamHoc)
            };
            return dal.myExecute(sql, sqlParameters);
        }

        public DataTable TimKiemCTDaoTao(string dieuKien)
        {
            string sql = "select * from CTDaoTao where maLop like N'%" + dieuKien + "%' or maHP like N'%" + dieuKien + "%' or hocKyNamHoc like N'%" + dieuKien + "%'";
            DataTable dt = dal.GetTable(sql);
            return dt;
        }
    }
}

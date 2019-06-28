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
    class DiemHocPhanBLL
    {
        DAL dal = new DAL();

        //ham lay tat ca diem hoc phan
        public DataTable LayDSDiemHP()
        {
            string sql = "select *from DiemHP";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }

        //ham lay tat ca dang ky
        public DataTable LayDK()
        {
            string sql = "select *from DangKy";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }

        //ham them Diem HP
        public bool ThemDiemHP(DiemHP dhp)
        {
            string sql = "insert into DiemHP(maDK, diemCC, diemTX, diemThi, diemHP, ghiChu)" + "values (@maDK, @diemCC, @diemTX, @diemThi, @diemHP, @ghiChu)";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@maDK", dhp.maDK),
                new SqlParameter("@diemCC", dhp.diemCC),
                new SqlParameter("@diemTX", dhp.diemTX),
                new SqlParameter("@diemThi", dhp.diemThi),
                new SqlParameter("@diemHP", dhp.diemHP),
                new SqlParameter("@ghiChu", dhp.ghiChu)
            };
            return dal.myExecute(sql, sqlParameters);
        }

        //ham sua DiemHP
        public bool SuaDiemHP(DiemHP dhp)
        {
            string sql = "Update DiemHP set diemCC = @diemCC, diemTX = @diemTX, diemThi = @diemThi, diemHP = @diemHP, ghiChu = @ghiChu where maDK = @maDK";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@maDK", dhp.maDK),
                new SqlParameter("@diemCC", dhp.diemCC),
                new SqlParameter("@diemTX", dhp.diemTX),
                new SqlParameter("@diemThi", dhp.diemThi),
                new SqlParameter("@diemHP", dhp.diemHP),
                new SqlParameter("@ghiChu", dhp.ghiChu)
            };
            return dal.myExecute(sql, sqlParameters);
        }

        //ham xoa DiemHP
        public bool XoaDiemHP(DiemHP dhp)
        {
            string sql = "delete DiemHP where maDK = @maDK";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@maDK", dhp.maDK)
            };
            return dal.myExecute(sql, sqlParameters);
        }

        public DataTable TimKiemDiemHP(string dieuKien)
        {
            string sql = "select * from DiemHP where maDK like N'%" + dieuKien + "%' or diemCC like '%" + dieuKien + "%' or diemTX like '%" + dieuKien + "%' or diemThi like '%" + dieuKien + "%' or diemHP like '%" + dieuKien + "%' or ghiChu like N'%" + dieuKien + "%'";
            DataTable dt = dal.GetTable(sql);
            return dt;
        }
    }
}

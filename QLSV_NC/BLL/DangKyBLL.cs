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
    class DangKyBLL
    {
        DAL dal = new DAL();

        //ham lay tat ca dang ky
        public DataTable LayDSDangKy()
        {
            string sql = "select *from DangKy";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }

        //ham lay sinh vien
        public DataTable LaySV()
        {
            string sql = "select *from SinhVien";
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

        //ham them Dang Ky
        public bool ThemDangKy(DangKy dk)
        {
            string sql = "insert into DangKy(maDK, maSV, maHP, hocKyNamHoc, dongTien)" + "values (@maDK, @maSV, @maHP, @hocKyNamHoc, @dongTien)";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@maDK", dk.maDK),
                new SqlParameter("@maSV", dk.maSV),
                new SqlParameter("@maHP", dk.maHP),
                new SqlParameter("@hocKyNamHoc", dk.hocKyNamHoc),
                new SqlParameter("@dongTien", dk.dongTien)
            };
            return dal.myExecute(sql, sqlParameters);
        }

        //ham sua DangKy
        public bool SuaDangKy(DangKy dk)
        {
            string sql = "Update DangKy set maSV = @maSV, maHP = @maHP, hocKyNamHoc = @hocKyNamHoc, dongTien = @dongTien where maDK = @maDK";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@maDK", dk.maDK),
                new SqlParameter("@maSV", dk.maSV),
                new SqlParameter("@maHP", dk.maHP),
                new SqlParameter("@hocKyNamHoc", dk.hocKyNamHoc),
                new SqlParameter("@dongTien", dk.dongTien)
            };
            return dal.myExecute(sql, sqlParameters);
        }

        //ham xoa Dang ky
        public bool XoaDangKy(DangKy dk)
        {
            string sql = "delete DangKy where maDK = @maDK";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@maDK", dk.maDK)
            };
            return dal.myExecute(sql, sqlParameters);
        }

        public DataTable TimKiemDangKy(string dieuKien)
        {
            string sql = "select * from DangKy where maDK like N'%" + dieuKien + "%' or maSV like N'%" + dieuKien + "%' or maHP like N'%" + dieuKien + "%' or hocKyNamHoc like N'%" + dieuKien + "%'";
            DataTable dt = dal.GetTable(sql);
            return dt;
        }
    }
}

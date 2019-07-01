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
    class SinhVienBLL
    {
        DAL dal = new DAL();

        //ham lay tat ca sinh vien trong bang Sinh Vien
        public DataTable LayDSSV()
        {
            string sql = "select *from SinhVien";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }

        //ham lay ma lop
        public DataTable LayMaLop()
        {
            string sql = "select *from Lop";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }

        //ham tim kiem sinh vien theo khoa
        public DataTable TimKiemTheoMaLop(string maLop)
        {
            string sql = "select *from SinhVien where maLop = '" + maLop + "'";
            return dal.GetTable(sql);
        }

        //ham them sinh vien
        public bool ThemSV(SinhVien sv)
        {
            string sql = "insert into SinhVien(maSV, hoTen, ngaySinh, soDT, maLop)" + "values (@maSV, @hoTen, @ngaySinh, @soDT, @maLop)";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@maSV", sv.ma),
                new SqlParameter("@hoTen", sv.hoTen),
                new SqlParameter("@ngaySinh", sv.ngaySinh),
                new SqlParameter("@soDT", sv.soDT),
                new SqlParameter("@maLop", sv.maLop)
            };
            return dal.myExecute(sql, sqlParameters);
        }

        //ham sua sinh vien
        public bool SuaSV(SinhVien sv)
        {
            string sql = "Update SinhVien set hoTen = @hoTen, ngaySinh = @ngaySinh,soDT = @soDT, maLop = @maLop where maSV = @maSV";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@hoTen", sv.hoTen),
                new SqlParameter("@ngaySinh", sv.ngaySinh),
                new SqlParameter("@soDT", sv.soDT),
                new SqlParameter("@maLop", sv.maLop),
                new SqlParameter("@maSV", sv.ma)
            };
            return dal.myExecute(sql, sqlParameters);
        }

        //ham xoa SinhVien
        public bool XoaSV(SinhVien sv)
        {
            string sql = "delete SinhVien where maSV = @maSV";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@maSV", sv.ma)
            };
            return dal.myExecute(sql, sqlParameters);
        }

        public DataTable TimKiemSinhVien(string dieuKien)
        {
            string sql = "select * from SinhVien where maSV like N'%" + dieuKien + "%' or hoTen like N'%" + dieuKien + "%' or ngaySinh like N'%" + dieuKien  + "%' or soDT like N'%" + dieuKien + "%' or maLop like N'%" + dieuKien + "%'";
            DataTable dt = dal.GetTable(sql);
            return dt;
        }

        //ham thong ke sinh vien trong lop
        public DataTable TKeTheoMaLop(string maLop)
        {
            string sql = "select SV.maSV, SV.hoTen, SV.ngaySinh, SV.soDT, SV.maLop, LOP.tenLop " +
                           "from SinhVien SV inner join Lop LOP on SV.maLop = LOP.maLop " +
                            "where LOP.maLop = '" + maLop + "'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
    }
}

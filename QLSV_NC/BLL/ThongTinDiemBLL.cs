using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_NC.BLL
{
    class ThongTinDiemBLL
    {
        DAL dal = new DAL();

        //ham lay thong tin diem qua ma SV
        public DataTable LayDiemMaSV(string maSV)
        {
            string sql = "select SV.maSV, SV.hoTen, DK.maDK ,HP.tenHP, DHP.diemCC, DHP.diemTX, DHP.diemThi, DHP.diemHP " +  
                "from SinhVien SV inner join DangKy DK on DK.maSV = SV.maSV inner join HocPhan HP on DK.maHP = HP.maHP " +
                 "inner join DiemHP DHP on DK.maDK = DHP.maDK " +
                   "where SV.maSV = N'" + maSV + "'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }

        //ham lay thong tin diem qua ma đăng ký
        public DataTable LayDiemMaDK(string maDK)
        {
            string sql = "select SV.maSV, SV.hoTen, DK.maDK ,HP.tenHP, DHP.diemCC, DHP.diemTX, DHP.diemThi, DHP.diemHP " +
                "from SinhVien SV inner join DangKy DK on DK.maSV = SV.maSV inner join HocPhan HP on DK.maHP = HP.maHP " +
                 "inner join DiemHP DHP on DK.maDK = DHP.maDK " +
                   "where DK.maDK = N'" + maDK + "'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
    }
}

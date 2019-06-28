using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace QLSV_NC
{
    class DAL
    {
        private SqlConnection con = new SqlConnection();

        public void myOpen()
        {
            string source = "server=localhost;" + "uid=sa;pwd=a;" + "database=QLSV_NienChe";
            con = new SqlConnection(source);
            try
            {
                con.Open();
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi kết nối với server", "Lỗi server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void myClose()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }

        //ham lay ve 1 bang datatable du lieu tu cau lenh sql
        public DataTable GetTable(string sql)
        {
            try
            {
                DataTable dt = new DataTable();
                myOpen();
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.Fill(dt);
                myClose();
                return dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi:" + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //ham thuc thi cau lenh va tra ve ket qua thuc hien duoc hay khong
        public bool ExcuteNonQuery(string sql)
        {
            try
            {
                myOpen();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd.Clone();
                myClose();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi:" + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool myExecute(String sqlStr, params SqlParameter[] param)
        {
            try
            {
                myOpen();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sqlStr;
                foreach (SqlParameter p in param)
                {
                    cmd.Parameters.Add(p);
                }
                cmd.ExecuteNonQuery();
                myClose();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi:" + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
        }
    }
}

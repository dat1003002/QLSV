using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    public class Database

    {

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True";
        private SqlConnection conn;//
        private string sql;
        private DataTable dt;
        private SqlCommand cmd;

        public Database()
        {
            AllocConsole();
            try {
                conn = new SqlConnection(connectionString);
               
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("xin lỗi thử lại" + ex.Message);
            }
        }
        public DataTable SelectData(string sql, List<CustomParameter> lstPara)
        {
            try
            {
                conn.Open();

                cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (var para in lstPara)
                {
                    cmd.Parameters.AddWithValue(para.key, para.value);
                }
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                return dt;




            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu" + ex.Message);
                return null;

            }
            finally
            {
                conn.Close();
            }
        }

        public DataRow select(string sql)

        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql,conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt.Rows[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi load dữ liệu "+ex.Message);
                return null;

            }
            finally
            {
                conn.Close();
            }
        }

        public int ExeCute(string sql, List<CustomParameter> lstPara)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.CommandType=CommandType.StoredProcedure ;
                foreach(var p in lstPara)
                {
                    cmd.Parameters.AddWithValue(p.key, p.value);
                } //truyền dữ liệu từ danh sách Para vào cmd để thực thi
                var rs = cmd.ExecuteNonQuery();//thực thi
                return (int)rs;//trả về

            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi thực thi câu lệnh " + ex.Message);
                return -100;
            }
            finally
            {
                conn.Close();
            }
        }
     }
}

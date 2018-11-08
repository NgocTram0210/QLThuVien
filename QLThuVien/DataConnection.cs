using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QLThuVien
{
    class DataConnection
    {
        public static string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLTHUVIEN;Integrated Security=True";
        public static SqlConnection sqlCon = null;

        public static void openConn()
        {
            try
            {
                sqlCon = new SqlConnection(connectionString);
                sqlCon.Open();

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public static void closeConn()
        {
            try
            {
                sqlCon.Close();
            }
            catch { }
        }

        public static object RunsqlQuery(string strSQL)
        {
            object obj = null;
            try
            {
                openConn();
                SqlCommand sqlCommand = new SqlCommand(strSQL, sqlCon);
                obj = sqlCommand.ExecuteNonQuery();
                closeConn();
                //MessageBox.Show("Thành công.");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return obj;
        }

        public static object RunsqlScalar(string strSQL)
        {
            object obj = new object();
            try
            {
                openConn();
                SqlCommand sqlCommand = new SqlCommand(strSQL, sqlCon);
                obj = sqlCommand.ExecuteScalar();
                closeConn();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return obj;
        }

        public static object RunsqlReader(string strSQL)
        {
            SqlDataReader obj = null;
            try
            {
                openConn();
                SqlCommand sqlCommand = new SqlCommand(strSQL, sqlCon);
                obj = sqlCommand.ExecuteReader();
                closeConn();
                //MessageBox.Show("Thành công.");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return obj;
        }

        public static DataSet GetDataSet(string strSQL)
        {
            DataSet dt = new DataSet();
            try
            {
                openConn();
                SqlDataAdapter sqlDa = new SqlDataAdapter(strSQL, sqlCon);
                sqlDa.Fill(dt);
                closeConn();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return dt;
        }
    }
}
    


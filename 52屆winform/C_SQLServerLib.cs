using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace _52屆winform
{
    public class C_SQLServerLib:C_SQLconn
    {

        public SqlCommand cmd;
        public string UserID = "";
        public string password = "";
        public string UserName = "";

        public static string perID = "";


        public static string IMO = "";
        public string per = "";

        public bool vUserLogin() {
            bool isvLogin = vUserLoginFun();
            if (isvLogin) {
                MessageBox.Show($"登入成功\n使用者:{UserName}\nIMO:{IMO}\n權限:{per}");
                Main main = new Main(this);              
                main.Show();
                return true;
            }
            MessageBox.Show("登入失敗");
            return false;
        }
        public bool vUserLoginFun (){
            SqlDataReader connReader; 
            cmd = new SqlCommand();          
            openConn();
            cmd.CommandText = $"select * from 船員資料 where 使用者ID='{UserID}' and 密碼='{password}'";
            cmd.Connection = conn;
            try
            {
                connReader = cmd.ExecuteReader();
                while (connReader.Read()) {
                    UserName = connReader["姓名"].ToString();
                    perID = connReader["權限ID"].ToString();
                    IMO = connReader["IMO"].ToString();
                    perfun();
                    return true;
                }
            }
            catch {
                return false;
            }
            return false;
        }
        public bool perfun()
        {

            SqlDataReader connReader;
            cmd = new SqlCommand();
            openConn();
            cmd.CommandText = $"select * from 權限 where 權限ID='{perID}' ";
            cmd.Connection = conn;
            try
            {
                connReader = cmd.ExecuteReader();
                while (connReader.Read())
                {
                    per = connReader["權限說明"].ToString();
                    closeConn();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

            return false;

        }
        public bool changePassword(string newPassword) {
            cmd = new SqlCommand();
            openConn();
            cmd.CommandText = $"UPDATE 船員資料 set 密碼='{newPassword}' where 使用者ID='{UserID}'";
            cmd.Connection = conn;
            if (cmd.ExecuteNonQuery() == 0) {
                MessageBox.Show("修改失敗");
                return false;
            }
            cmd.ExecuteNonQuery();
            MessageBox.Show("已成功修改密碼");
            return true;

        }
      

        public DataSet GetDataSet(string strSql, string strDataTableName) {
           

                cmd = new SqlCommand();
                SqlDataAdapter dA;
                openConn();
                cmd.CommandText = strSql;
                cmd.Connection = conn;
                dA = new SqlDataAdapter(cmd);
                DataSet data = new DataSet();
                dA.Fill(data, strDataTableName);
                return data;
         
           
        }

        public DataTable GetDataTable(string strSql)
        {
            cmd = new SqlCommand();
            SqlDataAdapter dA;
            openConn();
            cmd.CommandText = strSql;
            cmd.Connection = conn;
            dA = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            dA.Fill(data);
            return data;
        }


        public string GetSQLvalue(string strSql,string strTableName) {
            try
            {
                SqlDataReader connReader;
                cmd = new SqlCommand();
                openConn();
                cmd.CommandText = strSql;
                cmd.Connection = conn;
                connReader = cmd.ExecuteReader();
                if (connReader.Read())
                {
                    return connReader[strTableName].ToString();
                }
                return null;
            }
            catch (Exception ex) {

                return null;
            }
           
        }

        public bool startExecuteNonQuery(string sql) {
            try
            {
                cmd = new SqlCommand();
                openConn();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex) { 
                return false;
            }
         


            return false;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _52屆winform
{
    public class C_SQLconn
    {

        public SqlConnection conn;

        void  connfun()
        {

            string connStr = "Data Source=.\\SQLEXPRESS;database=GSMS;User ID=sa;password=1234";
            conn = new SqlConnection(connStr);


        }
        public void openConn() {
            connfun();
                conn.Open();
         
        }

        public void closeConn() {


            conn.Close();
            
        }


    }
}

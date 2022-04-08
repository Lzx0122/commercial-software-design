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

            string connStr = "data source=192.168.0.104,1433; database=GSMS;user id=sa;password=0000";
            conn = new SqlConnection(connStr);


        }
        public void openConn() {
            connfun();
                conn.Open();
         
        }

        void closeConn() {


            conn.Close();
            
        }


    }
}

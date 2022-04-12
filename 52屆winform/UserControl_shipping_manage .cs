using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _52屆winform
{
    public partial class UserControl1 : UserControl
    {

        private C_SQLServerLib lib;
        C_SQLconn conclass = new C_SQLconn();
      
        SqlCommand cmd;
        public UserControl1(C_SQLServerLib e)
        {
            InitializeComponent();
            lib = e;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            reloading();
            船種ID_combobox.DataSource = lib.GetDataTable("select 船舶種類中文名稱 from 船種");
            船種ID_combobox.DisplayMember = "船種";
            船種ID_combobox.ValueMember = "船舶種類中文名稱";

            船公司ID_combobox.DataSource = lib.GetDataTable("select 船商名稱 from 船公司");
            船公司ID_combobox.DisplayMember = "船公司";
            船公司ID_combobox.ValueMember = "船商名稱";
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }


        private void reloading()
        {

            dataGridView1.DataSource = lib.GetDataSet($"select IMO,英文船名,中文船名,載噸重,船舶種類中文名稱,船商名稱,船東 from 船舶基本資料" +
                $" inner join 船種 on 船舶基本資料.船種DI=船種.船種ID" +
                $" inner join 船公司 on 船舶基本資料.船公司ID=船公司.船公司ID ", "船舶基本資料").Tables["船舶基本資料"];

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows[0].Index != -1)
                {
                    if (dataGridView1.SelectedRows[0].Cells[0].Value != null) { 
                        textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                        textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                        textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                        textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();                
                        textBox7.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                        string str = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                        int index = 船種ID_combobox.FindString(str);
                        船種ID_combobox.SelectedIndex = index;
                        str = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                        index = 船公司ID_combobox.FindString(str);
                        船公司ID_combobox.SelectedIndex = index;





                    }
                }

            }
            catch (Exception ex) { 
            
            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string isNull = lib.GetSQLvalue($"select IMO from 船舶基本資料 where IMO='{textBox1.Text}'", "IMO");
            try
            {
                if (isNull == null)
                {
                    cmd = new SqlCommand();
                    conclass.openConn();
                    cmd.CommandText = $"insert into 船舶基本資料 (IMO,英文船名,中文船名,載噸重,船種DI,船公司ID,船東) " +
                        $"select '{textBox1.Text}','{textBox2.Text}','{textBox3.Text}','{textBox4.Text}'" +
                        $",(select 船種ID from 船種 where 船舶種類中文名稱='{船種ID_combobox.Text}')," +
                        $"(select 船公司ID from 船公司 where 船商名稱='{船公司ID_combobox.Text}'),'{textBox7.Text}'";
                    cmd.Connection = conclass.conn;
                    cmd.ExecuteNonQuery();
                    reloading();
                    MessageBox.Show("修改完成", "訊息");
                }
                else {

                    MessageBox.Show("IMO資料不可重複", "錯誤");
                }
            }
            catch (Exception ex) {

               

            }
           
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand();
                conclass.openConn();
                cmd.CommandText = $"DELETE FROM 船舶基本資料 WHERE IMO='{textBox1.Text}' ";
                cmd.Connection = conclass.conn;
                cmd.ExecuteNonQuery();
                reloading();
                MessageBox.Show($"已成功刪除{textBox1.Text}", "訊息");
            }
            catch (Exception ex)
            {
                MessageBox.Show("","錯誤");
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = lib.GetDataSet($"select IMO,英文船名,中文船名,載噸重,船舶種類中文名稱,船商名稱,船東  from 船舶基本資料" +
$" inner join 船種 on 船舶基本資料.船種DI=船種.船種ID" +
                $" inner join 船公司 on 船舶基本資料.船公司ID=船公司.船公司ID "+
$"WHERE IMO like '%{textBox8.Text}%'" +
$"or 英文船名 like '%{textBox8.Text}%'" +
$"or 中文船名 like '%{textBox8.Text}%'" +
$"or 載噸重 like '%{textBox8.Text}%'" +
$"or 船舶種類中文名稱 like '%{textBox8.Text}%'" +
$"or 船商名稱 like '%{textBox8.Text}%'" +
$"or 船東 like '%{textBox8.Text}%'" 
, "船舶基本資料").Tables["船舶基本資料"];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string isNull = lib.GetSQLvalue($"select IMO from 船舶基本資料 where IMO='{textBox1.Text}'", "IMO");
                if (!(isNull == null))
                {
                    cmd = new SqlCommand();
                    conclass.openConn();
                    cmd.CommandText = $"UPDATE 船舶基本資料 SET 英文船名='{textBox2.Text}'," +
                        $"中文船名='{textBox3.Text}'," +
                        $"載噸重='{textBox4.Text}'," +
                        $"船種DI=(select 船種ID from 船種 where 船舶種類中文名稱='{船種ID_combobox.Text}')," +
                        $"船公司ID=(select 船公司ID from 船公司 where 船商名稱='{船公司ID_combobox.Text}')," +
                        $"船東='{textBox7.Text}' " +
                        $"WHERE IMO={textBox1.Text}";
                    cmd.Connection = conclass.conn;
                    cmd.ExecuteNonQuery();
                    reloading();

                }
                else
                {

                    MessageBox.Show($"資料表裡面沒有'{textBox1.Text}'使用者");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

     
    }
}

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
    public partial class UserControl_user_account : UserControl
    {

        private C_SQLServerLib lib;
    
 
     
        string sql = "";

        public UserControl_user_account(C_SQLServerLib e)
        {
            InitializeComponent();
            lib = e;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
           
        }

        private void UserControl_user_account_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = lib.GetDataSet("select 使用者ID,密碼,姓名,國家,出生日期,職業,狀態,IMO,權限說明  from 船員資料"+
" inner join 權限 on 船員資料.權限ID = 權限.權限ID"+
" inner join 職業 on 船員資料.職業ID = 職業.職業ID ", "船員資料").Tables["船員資料"];
            comboBox1.DataSource = lib.GetDataTable("select 權限說明 from 權限");
            comboBox1.DisplayMember = "權限";
            comboBox1.ValueMember = "權限說明";
    
            comboBox2.DataSource = lib.GetDataTable("select * from 職業 where { fn LENGTH(職業ID) } = 7");
            comboBox2.DisplayMember = "職業";
            comboBox2.ValueMember = "職業ID";
           

            comboBox3.DataSource = lib.GetDataTable("select IMO from 船舶基本資料");
            comboBox3.DisplayMember = "IMO";
            comboBox3.ValueMember = "IMO";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows[0].Index != -1)
                {
                    if (dataGridView1.SelectedRows[0].Cells[0].Value != null)
                    {
                        string str = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                        int index = comboBox1.FindString(str);
                        comboBox1.SelectedIndex =index ;
                        str = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                        index = comboBox2.FindString(str);
                        comboBox2.SelectedIndex = index;
                        str = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                        index = comboBox3.FindString(str);
                        comboBox3.SelectedIndex = index;

                        textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                        textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                        textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                        textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                        string dateTime= DateTime.Parse( dataGridView1.SelectedRows[0].Cells[4].Value.ToString()).ToString("yyyy-MM-dd");
                        textBox7.Text = dateTime;
                       
                        textBox5.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                        
                        textBox10.Text = lib.GetSQLvalue($"select 職業 from 職業 where 職業ID=(select 上層ID from 職業 where 職業='{dataGridView1.SelectedRows[0].Cells[5].Value.ToString()}')", "職業");
                        textBox9.Text = lib.GetSQLvalue($"select 職業 from 職業 where 職業ID=(select 上層ID from 職業 where 職業ID=(select 上層ID from 職業 where 職業='{dataGridView1.SelectedRows[0].Cells[5].Value.ToString()}'))", "職業");

                    }

                }
            }
            catch (Exception ex) { 
            };
          
           
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
           

            textBox10.Text = lib.GetSQLvalue($"select 職業 from 職業 where 職業ID=" +
                $"(select 上層ID from 職業 where 職業='{comboBox2.Text as string}')", "職業");

            textBox9.Text = lib.GetSQLvalue($"select 職業 from 職業 where 職業ID=" +
                $"(select 上層ID from 職業 where 職業ID=" +
                $"(select 上層ID from 職業 where 職業='{comboBox2.Text as string}'))", "職業");

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result =  MessageBox.Show($"請問要新增'{textBox1.Text}'此用戶嗎?", "訊息", MessageBoxButtons.YesNo);
            string isNull = lib.GetSQLvalue($"select 使用者ID from 船員資料 where 使用者ID='{textBox1.Text}'", "使用者ID");
            
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (isNull == null) {
              
                    sql = $"insert into 船員資料 (使用者ID,密碼,姓名,國家,出生日期,職業ID,狀態,IMO,權限ID) " +
                        $"select '{textBox1.Text}','{textBox2.Text}','{textBox3.Text}','{textBox4.Text}','{textBox7.Text}'" +
                        $",'{comboBox2.SelectedValue.ToString()}','{textBox5.Text}','{comboBox3.Text}'," +
                        $"(select 權限ID from 權限 where 權限說明='{comboBox1.Text}')";
                    if (lib.startExecuteNonQuery(sql)) {
                        reloading();
                        MessageBox.Show("修改完成", "訊息");

                    }
                  
                }
                else {
                    MessageBox.Show($"{textBox1.Text}此使用者已被註冊","錯誤");
                } 
                  
               
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
            
                sql = $"DELETE FROM 船員資料 WHERE 使用者ID='{textBox1.Text}' ";
             
                if (lib.startExecuteNonQuery(sql)) {
                    reloading();                
                }
                
            }catch (Exception ex) {
              
            }
          
        }

        private void reloading() {

            dataGridView1.DataSource = lib.GetDataSet("select 使用者ID,密碼,姓名,國家,出生日期,職業,狀態,IMO,權限說明  from 船員資料" +
" inner join 權限 on 船員資料.權限ID = 權限.權限ID" +
" inner join 職業 on 船員資料.職業ID = 職業.職業ID ", "船員資料").Tables["船員資料"];
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string isNull = lib.GetSQLvalue($"select 使用者ID from 船員資料 where 使用者ID='{textBox1.Text}'", "使用者ID");
                if (!(isNull == null))
                {  
                    sql =$"UPDATE 船員資料 SET 密碼='{textBox2.Text}'," +
                        $"姓名='{textBox3.Text}'," +
                        $"國家='{textBox4.Text}'," +
                        $"出生日期='{textBox7.Text}'," +
                        $"職業ID=(select 職業ID from 職業 where 職業='{comboBox2.Text}')," +
                        $"狀態='{textBox5.Text}'," +
                        $"IMO='{comboBox3.Text}'," +
                        $"權限ID=(select 權限ID from 權限 where 權限說明='{comboBox1.Text}') " +
                        $"WHERE 使用者ID='{textBox1.Text}'";
                    if (lib.startExecuteNonQuery(sql)) {

                        MessageBox.Show($"修改成功");
                        reloading();
                    }
                   

                }
                else {

                    MessageBox.Show($"資料表裡面沒有'{textBox1.Text}'使用者");
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = lib.GetDataSet("select 使用者ID,密碼,姓名,國家,出生日期,職業,狀態,IMO,權限說明  from 船員資料" +
" inner join 權限 on 船員資料.權限ID = 權限.權限ID" +
" inner join 職業 on 船員資料.職業ID = 職業.職業ID " +
$"WHERE 使用者ID like '%{textBox6.Text}%'" +
$"or 密碼 like '%{textBox6.Text}%'" +
$"or 姓名 like '%{textBox6.Text}%'" +
$"or 國家 like '%{textBox6.Text}%'" +
$"or 出生日期 like '%{textBox6.Text}%'" +
$"or 職業 like '%{textBox6.Text}%'" +
$"or 狀態 like '%{textBox6.Text}%'" +
$"or IMO like '%{textBox6.Text}%'" +
$"or 權限說明 like '%{textBox6.Text}%'"
, "船員資料").Tables["船員資料"];



        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

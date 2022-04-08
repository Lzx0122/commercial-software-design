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
        C_SQLconn conclass = new C_SQLconn();
        SqlDataReader connReader;
        SqlCommand cmd;

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
            comboBox2.DataSource = lib.GetDataTable("select 職業 from 職業 where { fn LENGTH(職業ID) } = 7");
            
            comboBox2.DisplayMember = "職業";
            comboBox2.ValueMember = "職業";
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

                        textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                        textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                        textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                        textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                        DateTime dateTime  = Convert.ToDateTime( dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
                        dateTimePicker1.Value = dateTime;
                       
                        textBox5.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                        textBox6.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                       
                        string pro;
                    
                        pro = dataGridView1.SelectedRows[0].Cells[5].Value.ToString().Trim();
                       
                         string strbox =lib.GetSQLvalue($"select 職業ID from 職業 where 職業='{pro}'","職業ID");
           
                        for (int i = 0; i < strbox.ToString().Split('/').Length; i++) {
                            if (i == 0)
                            {
                               // textBox11.Text = lib.GetSQLvalue($"select 職業 from 職業 where 職業ID='{strbox}'", "職業");
                            }
                            else if (i == 1)
                            {                        
                                    textBox10.Text = lib.GetSQLvalue($"select 職業 from 職業 where 職業ID='{strbox}'", "職業");
                           
                            }
                            else if (i == 2) {                               
                                    textBox9.Text = lib.GetSQLvalue($"select 職業 from 職業 where 職業ID='{strbox}'", "職業");
                            }

                            strbox = strbox.Remove(strbox.Length - 2, 2);
                        }
                        
                    }

                }
            }
            catch (Exception ex) { 
            };
          
           
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            string pro;

            pro = comboBox2.SelectedValue as string;

            string strbox = lib.GetSQLvalue($"select 職業ID from 職業 where 職業='{pro}'", "職業ID");
            if (!(pro == null)) {
                for (int i = 0; i < strbox.ToString().Split('/').Length; i++)
                {
                    if (i == 0)
                    {
                        // textBox11.Text = lib.GetSQLvalue($"select 職業 from 職業 where 職業ID='{strbox}'", "職業");
                    }
                    else if (i == 1)
                    {
                        textBox10.Text = lib.GetSQLvalue($"select 職業 from 職業 where 職業ID='{strbox}'", "職業");

                    }
                    else if (i == 2)
                    {
                        textBox9.Text = lib.GetSQLvalue($"select 職業 from 職業 where 職業ID='{strbox}'", "職業");
                    }

                    strbox = strbox.Remove(strbox.Length - 2, 2);
                }
            }
          
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _52屆winform
{
    public partial class UserControl_Ship_navigation_inspection : UserControl
    {
        private C_SQLServerLib lib;

        string sql;
    
        public UserControl_Ship_navigation_inspection(C_SQLServerLib e)
        {
            InitializeComponent();
            lib = e;
            
           

        }

        private void UserControl_Ship_navigation_inspection_Load(object sender, EventArgs e)
        {
            reloading();
            IMO_combobox.DataSource = lib.GetDataTable($"select * from 航行資料");
            IMO_combobox.DisplayMember = "IMO";
            IMO_combobox.ValueMember = "航線ID";
            this.IMO_combobox.SelectedIndexChanged += new System.EventHandler(this.IMO_combobox_SelectedIndexChanged_1);

            港口名稱_combobox.DataSource = lib.GetDataTable($"select * from 港口清單");
            港口名稱_combobox.DisplayMember = "港口名稱";
            港口名稱_combobox.ValueMember = "港口ID";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows[0].Index != -1)
                {
                    if (dataGridView1.SelectedRows[0].Cells[0].Value != null) {
                        string str = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                        int index = IMO_combobox.FindString(str);
                        IMO_combobox.SelectedIndex = index;
                        str = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                        index = 港口名稱_combobox.FindString(str);
                        港口名稱_combobox.SelectedIndex = index;
                        航線名稱.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                        狀態.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                        時間.Text = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[5].Value.ToString()).ToString("yyyy/MM/dd");
                       


                    }

                }

            } catch (Exception ex) { 
            
            
            }
           
        }

        private void reloading() {
            if (C_SQLServerLib.perID == "3")
            {
                dataGridView1.DataSource = lib.GetDataSet($"select 明細號,IMO,航線名稱,港口名稱,狀態,時間 from 航行明細 " +
             $"inner join 航行資料 on 航行明細.航行ID=航行資料.航行ID " +
             $"inner join 港口清單 on 航行明細.港口ID=港口清單.港口ID " +
             $"inner join 航線名稱 on 航行明細.航線ID=航線名稱.航線ID where IMO={C_SQLServerLib.IMO}", "航行明細").Tables["航行明細"];
            }
            else {
                dataGridView1.DataSource = lib.GetDataSet($"select 明細號,IMO,航線名稱,港口名稱,狀態,時間 from 航行明細 " +
                $"inner join 航行資料 on 航行明細.航行ID=航行資料.航行ID " +
                $"inner join 港口清單 on 航行明細.港口ID=港口清單.港口ID " +
                $"inner join 航線名稱 on 航行明細.航線ID=航線名稱.航線ID ", "航行明細").Tables["航行明細"];

            }
          


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string isNull = lib.GetSQLvalue($"select 明細號 from 航行明細 where 明細號='{dataGridView1.SelectedRows[0].Cells[0].Value}'", "明細號");
                if (!(isNull == null))
                {
                    sql = $"UPDATE 航行明細 set " +
                         
                        $"港口ID='{港口名稱_combobox.SelectedValue.ToString()}'," +
                        $"狀態='{狀態.Text}'," +
                        $"時間='{時間.Text}' " +
                        
                        $"WHERE 明細號='{dataGridView1.SelectedRows[0].Cells[0].Value}'";
                    
                    if (lib.startExecuteNonQuery(sql))
                    {
                        sql = $"UPDATE 航行資料 set " +

                       $"IMO={IMO_combobox.SelectedValue.ToString()} " +
                      

                       $"WHERE IMO={dataGridView1.SelectedRows[0].Cells[1].Value.ToString()}";

                        if (lib.startExecuteNonQuery(sql))
                        {
                            MessageBox.Show($"修改成功");
                            reloading();
                        }


                    }


                }
                else
                {

                    MessageBox.Show($"資料表裡面沒有'{dataGridView1.SelectedRows[0].Cells[0].Value}'使用者");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                sql = $"DELETE FROM 航行明細 WHERE 明細號='{dataGridView1.SelectedRows[0].Cells[0].Value.ToString()}' ";

                if (lib.startExecuteNonQuery(sql))
                {
                    reloading();
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int last = dataGridView1.RowCount-2;
            var dgv = this.dataGridView1;
            int a = ((int)dgv.Rows[last].Cells[0].Value)+1;
            sql = $"insert into 航行明細 (航行ID,港口ID,航線ID,狀態,時間) " +
                        $"select {IMO_combobox.SelectedValue},'{港口名稱_combobox.SelectedValue}',(select 航線ID from 航線名稱 where 航線名稱='{航線名稱.Text}'),'{狀態.Text}','{時間.Text}'";
            if (lib.startExecuteNonQuery(sql))
            {
                reloading();
                MessageBox.Show("修改完成", "訊息");

            }
        }

        private void 查詢_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = lib.GetDataSet($"select 明細號,IMO,航線名稱,港口名稱,狀態,時間 from 航行明細 " +
               $"inner join 航行資料 on 航行明細.航行ID=航行資料.航行ID " +
               $"inner join 港口清單 on 航行明細.港口ID=港口清單.港口ID " +
               $"inner join 航線名稱 on 航行明細.航線ID=航線名稱.航線ID "+
$"WHERE 明細號 like '%{查詢.Text}%' " +
$"or IMO like '%{查詢.Text}%' " +
$"or 航線名稱 like '%{查詢.Text}%' " +
$"or 港口名稱 like '%{查詢.Text}%' " +
$"or 狀態 like '%{查詢.Text}%' " +
$"or 時間 like '%{查詢.Text}%'"
, "航行明細").Tables["航行明細"];
        }

    

        private void IMO_combobox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            航線名稱.Text = lib.GetSQLvalue($"select 航線名稱 from 航線名稱 where 航線ID={IMO_combobox.SelectedValue}", "航線名稱");
        }
    }
}

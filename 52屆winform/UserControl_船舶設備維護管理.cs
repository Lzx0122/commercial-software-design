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
    public partial class UserControl_船舶設備維護管理 : UserControl
    {
        private C_SQLServerLib lib;
        public UserControl_船舶設備維護管理(C_SQLServerLib e)
        {
            InitializeComponent();
            lib = e;
            零件_combobox.DataSource = lib.GetDataTable("select * from 設備 where {fn length(設備ID)} = 7");
            零件_combobox.DisplayMember = "名稱";
            零件_combobox.ValueMember = "設備ID";
            IMO_combox.DataSource = lib.GetDataTable("select * from 保養資料");
            IMO_combox.DisplayMember = "IMO";
            IMO_combox.ValueMember = "IMO";
            負責人_combobox.DataSource = lib.GetDataTable("select * from 保養資料");
            負責人_combobox.DisplayMember = "使用者ID";
            負責人_combobox.ValueMember = "使用者ID";

            this.零件_combobox.SelectedValueChanged += new System.EventHandler(this.零件_combobox_SelectedValueChanged);
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
        }

        private void UserControl_Ship_equipment_Load(object sender, EventArgs e)
        {
            
        }

        private void IMO_combobox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void UserControl_Ship_equipment_Load_1(object sender, EventArgs e)
        {

        }

        private void UserControl_Ship_equipment_Load_2(object sender, EventArgs e)
        {
            dataGridView2.DataSource = lib.GetDataSet($"select 保養明細ID,IMO,使用者ID,日期,名稱,狀態 from 保養明細 " +
                $"inner join 保養資料 on 保養明細.保養資料ID=保養資料.保養資料ID " +
                $"inner join 設備 on 保養明細.設備ID=設備.設備ID", "保養明細").Tables["保養明細"];
        }

        private void 零件_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            設備.Text = lib.GetSQLvalue($"select 名稱 from 設備 where 設備ID=(select 上層ID from 設備 where 設備ID='{零件_combobox.SelectedValue}')","名稱");
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.SelectedRows[0].Index != -1) {
                    if (dataGridView2.SelectedRows[0].Cells[0].Value.ToString() != null) {
                        設備狀態.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
                        string str = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
                        int index = 零件_combobox.FindString(str);
                        零件_combobox.SelectedIndex = index;
                        str = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                        index = IMO_combox.FindString(str);
                        IMO_combox.SelectedIndex = index;
                        str = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
                        index = 負責人_combobox.FindString(str);
                        負責人_combobox.SelectedIndex = index;
                        設備.Text = lib.GetSQLvalue($"select 名稱 from 設備 where 設備ID=(select 上層ID from 設備 where 設備ID='{零件_combobox.SelectedValue}')", "名稱");
                        部分.Text = lib.GetSQLvalue($"select 名稱 from 設備 where 設備ID=(select 上層ID from 設備 where 設備ID=(select 上層ID from 設備 where 設備ID='{零件_combobox.SelectedValue}'))", "名稱");
                        時間BOX.Text = DateTime.Parse(dataGridView2.SelectedRows[0].Cells[3].Value.ToString()).ToString("yyyy/MM/dd");





                    }
                }

            }
            catch { 
            
            
            }
        }

        private void 零件_combobox_SelectedValueChanged(object sender, EventArgs e)
        {
            設備.Text = lib.GetSQLvalue($"select 名稱 from 設備 where 設備ID=(select 上層ID from 設備 where 設備ID='{零件_combobox.SelectedValue}')", "名稱");
            部分.Text = lib.GetSQLvalue($"select 名稱 from 設備 where 設備ID=(select 上層ID from 設備 where 上層ID=(select 上層ID from 設備 where 設備ID='{零件_combobox.SelectedValue}'))", "名稱");
        }

        private void 查詢_TextChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = lib.GetDataSet($"select 保養明細ID,IMO,使用者ID,日期,名稱,狀態 from 保養明細 " +
              $"inner join 保養資料 on 保養明細.保養資料ID=保養資料.保養資料ID " +
              $"inner join 設備 on 保養明細.設備ID=設備.設備ID " +
              $"where 保養明細ID LIKE '%{查詢.Text}%'" +
              $"or IMO LIKE '%{查詢.Text}%'" +
              $"or 使用者ID LIKE '%{查詢.Text}%'" +
              $"or 日期 LIKE '%{查詢.Text}%'" +
              $"or 名稱 LIKE '%{查詢.Text}%'" +
              $"or 狀態 LIKE '%{查詢.Text}%'", "保養明細").Tables["保養明細"];
        }

        private void 刷新_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = lib.GetDataSet($"select 保養明細ID,IMO,使用者ID,日期,名稱,狀態 from 保養明細 " +
             $"inner join 保養資料 on 保養明細.保養資料ID=保養資料.保養資料ID " +
             $"inner join 設備 on 保養明細.設備ID=設備.設備ID", "保養明細").Tables["保養明細"];
        }
    }
}

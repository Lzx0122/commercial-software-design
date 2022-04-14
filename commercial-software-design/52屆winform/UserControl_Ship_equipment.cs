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
    public partial class UserControl_Ship_equipment : UserControl
    {
        private C_SQLServerLib lib;
        public UserControl_Ship_equipment(C_SQLServerLib e)
        {
            InitializeComponent();
            lib = e;
        }

        private void UserControl_Ship_equipment_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = lib.GetDataSet($"select 明細號,IMO,航線名稱,港口名稱,狀態,時間 from 航行明細 " +
                $"inner join 航行資料 on 航行明細.航行ID=航行資料.航行ID " +
                $"inner join 港口清單 on 航行明細.港口ID=港口清單.港口ID " +
                $"inner join 航線名稱 on 航行明細.航線ID=航線名稱.航線ID", "航行明細").Tables["航行明細"];



        }

        private void IMO_combobox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void UserControl_Ship_equipment_Load_1(object sender, EventArgs e)
        {

        }

        private void UserControl_Ship_equipment_Load_2(object sender, EventArgs e)
        {

        }
    }
}

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
        public UserControl_Ship_navigation_inspection(C_SQLServerLib e)
        {
            InitializeComponent();
            lib = e;
        }

        private void UserControl_Ship_navigation_inspection_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class UserControl_ChangePassword : UserControl
    {

        private C_SQLServerLib lib;
        public UserControl_ChangePassword(C_SQLServerLib e)
        {
            InitializeComponent();
            lib = e;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(textBox1.Text == lib.password))
            {
                MessageBox.Show("舊密碼錯誤");
            }
            else if (!(textBox2.Text == textBox3.Text))
            {
                MessageBox.Show("新密碼任錯誤");

            }
            else {
                lib.changePassword(textBox3.Text);
            };
        }

        private void UserControl_ChangePassword_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.Text = "登入";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            C_SQLServerLib vLogin = new C_SQLServerLib();
            vLogin.UserID = textBox1.Text;
            vLogin.password = textBox2.Text;
            vLogin.vUserLogin();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}


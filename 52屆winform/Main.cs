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
    public partial class Main : Form
    {
        private C_SQLServerLib lib;
        public String[] perArrayList;
        public TabPage[] tabPages;
        public UserControl[] userControls;

        public Main(C_SQLServerLib e)
        {       
            InitializeComponent();
            lib = e;
            this.Text = "主畫面";
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
           
            label1.Text = label1.Text + lib.UserName;
            label2.Text = label2.Text + lib.per;
            perArrayList = lib.per.ToString().Split(',');
            tabfun();

           
            
        }

        public void tabfun() {
            tabPages = new TabPage[perArrayList.Length];
            userControls = new UserControl[perArrayList.Length];
            for (int i = 0; i<perArrayList.Length; i++) {
                tabPages[i] = new TabPage();
                if (perArrayList[i].Equals("密碼變更")) {
                    userControls[i] = new UserControl_ChangePassword(lib);
                    //userControls[i].Name = "UserControl_ChangePassword";
                } else if (perArrayList[i].Equals("帳號管理")) {
                    userControls[i] = new UserControl_user_account(lib);
                    //userControls[i].Name = "UserControl_user_account";
                }
                else if (perArrayList[i].Equals("天氣資訊API"))
                {
                    userControls[i] = new UserControl_API(lib);
                    //userControls[i].Name = "UserControl_API";
                }
                else if (perArrayList[i].Equals("船舶管理"))
                {
                    userControls[i] = new UserControl1(lib);
                    //userControls[i].Name = "UserControl1";
                }
                else if (perArrayList[i].Equals("船舶航行檢視"))
                {
                    userControls[i] = new UserControl_Ship_navigation_inspection(lib);
                    //userControls[i].Name = "UserControl_Ship_navigation_inspection";
                }
                else if (perArrayList[i].Equals("船舶設備管理維護"))
                {
                    userControls[i] = new UserControl_船舶設備維護管理(lib);
                    //userControls[i].Name = "UserControl_船舶設備維護管理";
                }
                else if (perArrayList[i].Equals("船舶設備管理維修"))
                {
                    userControls[i] = new UserControl_船舶設備管理維修(lib);
                    //userControls[i].Name = "UserControl_船舶設備管理維修";
                }

                //userControls[i].Location = new System.Drawing.Point(6, 5);
                tabPages[i].Controls.Add(userControls[i]);
                //tabPages[i].Location = new System.Drawing.Point(4,22);
                //tabPages[i].Name = "tabPage" + userControls[i].Name;
                //tabPages[i].Padding = new System.Windows.Forms.Padding(3);
                //tabPages[i].Size = new System.Drawing.Size(938,451);
                //tabPages[i].TabIndex = i;
                tabPages[i].Text = perArrayList[i];
                //tabPages[i].UseVisualStyleBackColor = true;
                //tabPages[i].SuspendLayout();
                //tabPages[i].ResumeLayout(false);
                this.tabControl1.Controls.Add(tabPages[i]);
            }
        
        
        }
    }
}

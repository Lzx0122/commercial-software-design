﻿using System;
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
    public partial class UserControl1 : UserControl
    {

        private C_SQLServerLib lib;
        public UserControl1(C_SQLServerLib e)
        {
            InitializeComponent();
            lib = e;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}

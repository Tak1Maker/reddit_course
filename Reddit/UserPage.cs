﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reddit
{
    public partial class UserPage : UserControl
    {
        public UserPage()
        {
            InitializeComponent();
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (lblPassword2.Text == "1234")
                lblPassword2.Text = "****";
            else
                lblPassword2.Text = "1234";
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarProkat
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passwd1_reg_BT.PasswordChar = '\0';
                passwd2_reg_BT.PasswordChar = '\0';
            }
            else if (!checkBox1.Checked)
            {
                passwd1_reg_BT.PasswordChar = '*';
                passwd2_reg_BT.PasswordChar = '*';
            }
        }

        private void register_BT_Click(object sender, EventArgs e)
        {

        }
    }
}

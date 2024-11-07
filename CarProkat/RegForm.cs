using System;
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
        private LoginForm loginForm;
        public RegForm(LoginForm form)
        {
            InitializeComponent();
            loginForm = form;
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
            if (passwd1_reg_BT.Text != "" && passwd2_reg_BT.Text != "" && passwd1_reg_BT.Text == passwd2_reg_BT.Text)
            {
                UserData user = new UserData() { Name = name_reg_TB.Text, Password = passwd1_reg_BT.Text };
                loginForm.userDatas.Add(user);
                MessageBox.Show("Пользователь зарегистрирован!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                loginForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Строка с паролем пуста или они не похожи", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void loglinkisreg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            loginForm.ShowDialog();
        }
    }
}

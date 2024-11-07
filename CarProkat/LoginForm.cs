using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CarProkat
{

    public partial class LoginForm : Form
    {
        public List<UserData> userDatas = new List<UserData>();
        public LoginForm()
        {
            UserData user = new UserData() { Name = "Admin", Password = "123" };
            userDatas.Add(user);
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                passwd_Log_BT.PasswordChar = '\0';
            }
            else if (!checkBox2.Checked)
            {
                passwd_Log_BT.PasswordChar = '*';
            }
        }


        // Метод для получения данных
        public List<UserData> GetUserDatas() { return userDatas; }
        private void reg_BT_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegForm regForm = new RegForm(this);
            regForm.ShowDialog();
        }

        private void log_bt_Click(object sender, EventArgs e)
        {
            if (name_log_TB.Text != "" && passwd_Log_BT.Text != "")
            {
                List<UserData> data = GetUserDatas();
                foreach (var item in data)
                {
                    if (item.Name == name_log_TB.Text && item.Password == passwd_Log_BT.Text)
                    {
                        this.Hide();
                        //
                        MessageBox.Show("Успех ты вошел в акк", "Ураа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
              
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }
    }
}

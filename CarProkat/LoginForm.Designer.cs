namespace CarProkat
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            checkBox2 = new CheckBox();
            reg_BT = new Button();
            log_bt = new Button();
            passwd_Log_BT = new TextBox();
            name_log_TB = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(reg_BT);
            panel1.Controls.Add(log_bt);
            panel1.Controls.Add(passwd_Log_BT);
            panel1.Controls.Add(name_log_TB);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.MaximumSize = new Size(500, 500);
            panel1.MinimumSize = new Size(500, 500);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 500);
            panel1.TabIndex = 0;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackColor = Color.Transparent;
            checkBox2.ForeColor = Color.Transparent;
            checkBox2.Location = new Point(125, 271);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(113, 19);
            checkBox2.TabIndex = 4;
            checkBox2.Text = "Visible password";
            checkBox2.UseVisualStyleBackColor = false;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // reg_BT
            // 
            reg_BT.Font = new Font("Segoe UI", 15F);
            reg_BT.Location = new Point(149, 360);
            reg_BT.Name = "reg_BT";
            reg_BT.Size = new Size(148, 45);
            reg_BT.TabIndex = 2;
            reg_BT.Text = "Register";
            reg_BT.UseVisualStyleBackColor = true;
            reg_BT.Click += reg_BT_Click;
            // 
            // log_bt
            // 
            log_bt.Font = new Font("Segoe UI", 15F);
            log_bt.Location = new Point(149, 309);
            log_bt.Name = "log_bt";
            log_bt.Size = new Size(148, 45);
            log_bt.TabIndex = 2;
            log_bt.Text = "Login";
            log_bt.UseVisualStyleBackColor = true;
            log_bt.Click += log_bt_Click;
            // 
            // passwd_Log_BT
            // 
            passwd_Log_BT.Location = new Point(125, 235);
            passwd_Log_BT.Multiline = true;
            passwd_Log_BT.Name = "passwd_Log_BT";
            passwd_Log_BT.PasswordChar = '*';
            passwd_Log_BT.Size = new Size(200, 30);
            passwd_Log_BT.TabIndex = 1;
            // 
            // name_log_TB
            // 
            name_log_TB.Location = new Point(125, 145);
            name_log_TB.Multiline = true;
            name_log_TB.Name = "name_log_TB";
            name_log_TB.Size = new Size(200, 30);
            name_log_TB.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(133, 204);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 0;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(133, 114);
            label2.Name = "label2";
            label2.Size = new Size(64, 28);
            label2.TabIndex = 0;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(69, 28);
            label1.Name = "label1";
            label1.Size = new Size(355, 54);
            label1.TabIndex = 0;
            label1.Text = "Войдите в аккаунт";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(panel1);
            MaximumSize = new Size(500, 500);
            MinimumSize = new Size(500, 500);
            Name = "LoginForm";
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button reg_BT;
        private Button log_bt;
        private TextBox passwd_Log_BT;
        private TextBox name_log_TB;
        private Label label3;
        private CheckBox checkBox2;
    }
}
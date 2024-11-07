namespace CarProkat
{
    partial class RegForm
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
            loglinkisreg = new LinkLabel();
            register_BT = new Button();
            checkBox1 = new CheckBox();
            passwd1_reg_BT = new TextBox();
            passwd2_reg_BT = new TextBox();
            label4 = new Label();
            name_reg_TB = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(loglinkisreg);
            panel1.Controls.Add(register_BT);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(passwd1_reg_BT);
            panel1.Controls.Add(passwd2_reg_BT);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(name_reg_TB);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.MaximumSize = new Size(500, 500);
            panel1.MinimumSize = new Size(500, 500);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 500);
            panel1.TabIndex = 1;
            // 
            // loglinkisreg
            // 
            loglinkisreg.AutoSize = true;
            loglinkisreg.Location = new Point(213, 387);
            loglinkisreg.Name = "loglinkisreg";
            loglinkisreg.Size = new Size(37, 15);
            loglinkisreg.TabIndex = 5;
            loglinkisreg.TabStop = true;
            loglinkisreg.Text = "Login";
            loglinkisreg.LinkClicked += loglinkisreg_LinkClicked;
            // 
            // register_BT
            // 
            register_BT.Font = new Font("Segoe UI", 15F);
            register_BT.Location = new Point(154, 339);
            register_BT.Name = "register_BT";
            register_BT.Size = new Size(148, 45);
            register_BT.TabIndex = 4;
            register_BT.Text = "Register";
            register_BT.UseVisualStyleBackColor = true;
            register_BT.Click += register_BT_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.ForeColor = Color.Transparent;
            checkBox1.Location = new Point(125, 314);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(113, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Visible password";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // passwd1_reg_BT
            // 
            passwd1_reg_BT.Location = new Point(125, 212);
            passwd1_reg_BT.Multiline = true;
            passwd1_reg_BT.Name = "passwd1_reg_BT";
            passwd1_reg_BT.PasswordChar = '*';
            passwd1_reg_BT.Size = new Size(200, 30);
            passwd1_reg_BT.TabIndex = 1;
            passwd1_reg_BT.TextChanged += textBox1_TextChanged;
            // 
            // passwd2_reg_BT
            // 
            passwd2_reg_BT.Location = new Point(125, 278);
            passwd2_reg_BT.Multiline = true;
            passwd2_reg_BT.Name = "passwd2_reg_BT";
            passwd2_reg_BT.PasswordChar = '*';
            passwd2_reg_BT.Size = new Size(200, 30);
            passwd2_reg_BT.TabIndex = 1;
            passwd2_reg_BT.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(125, 247);
            label4.Name = "label4";
            label4.Size = new Size(93, 28);
            label4.TabIndex = 0;
            label4.Text = "Password";
            // 
            // name_reg_TB
            // 
            name_reg_TB.Location = new Point(125, 122);
            name_reg_TB.Multiline = true;
            name_reg_TB.Name = "name_reg_TB";
            name_reg_TB.Size = new Size(200, 30);
            name_reg_TB.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(125, 181);
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
            label2.Location = new Point(125, 91);
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
            label1.Location = new Point(98, 25);
            label1.Name = "label1";
            label1.Size = new Size(249, 54);
            label1.TabIndex = 0;
            label1.Text = "Регистрация";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // RegForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(panel1);
            MaximumSize = new Size(500, 500);
            MinimumSize = new Size(500, 500);
            Name = "RegForm";
            Text = "RegForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button register_BT;
        private Button log_bt;
        private TextBox passwd_Log_BT;
        private TextBox name_reg_TB;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox passwd2_reg_BT;
        private Label label4;
        private CheckBox checkBox1;
        private TextBox passwd1_reg_BT;
        private LinkLabel loglinkisreg;
    }
}
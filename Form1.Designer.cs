namespace LoginScreen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAppName = new Label();
            txtID = new TextBox();
            btnLogin = new Button();
            txtPW = new TextBox();
            lblErrorMsg = new Label();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("궁서", 30F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblAppName.ForeColor = Color.FromArgb(0, 0, 192);
            lblAppName.Location = new Point(268, 39);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(278, 80);
            lblAppName.TabIndex = 3;
            lblAppName.Text = "Login";
            // 
            // txtID
            // 
            txtID.Font = new Font("맑은 고딕", 28F);
            txtID.ForeColor = SystemColors.ScrollBar;
            txtID.Location = new Point(143, 222);
            txtID.Name = "txtID";
            txtID.Size = new Size(490, 107);
            txtID.TabIndex = 1;
            txtID.Text = "아이디";
            txtID.Enter += txtID_Enter;
            txtID.KeyDown += txtID_KeyDown;
            txtID.Leave += txtID_Leave;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(128, 128, 255);
            btnLogin.Font = new Font("맑은 고딕", 20F);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(249, 555);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(268, 94);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPW
            // 
            txtPW.Font = new Font("맑은 고딕", 28F);
            txtPW.ForeColor = SystemColors.ScrollBar;
            txtPW.Location = new Point(143, 368);
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(490, 107);
            txtPW.TabIndex = 2;
            txtPW.Text = "패스워드";
            txtPW.Enter += txtPW_Enter;
            txtPW.KeyDown += txtPW_KeyDown;
            txtPW.Leave += txtPW_Leave;
            // 
            // lblErrorMsg
            // 
            lblErrorMsg.AutoSize = true;
            lblErrorMsg.ForeColor = Color.Red;
            lblErrorMsg.Location = new Point(143, 490);
            lblErrorMsg.Name = "lblErrorMsg";
            lblErrorMsg.Size = new Size(459, 32);
            lblErrorMsg.TabIndex = 4;
            lblErrorMsg.Text = "아이디 또는 비밀번호가 잘못 되었습니다.";
            lblErrorMsg.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 726);
            Controls.Add(lblErrorMsg);
            Controls.Add(txtPW);
            Controls.Add(btnLogin);
            Controls.Add(txtID);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "Login Screen";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private TextBox txtID;
        private Button btnLogin;
        private TextBox txtPW;
        private Label lblErrorMsg;
    }
}

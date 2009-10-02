namespace DesideraTumblr
{
    partial class OptionForm
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
            this.loginUsername = new System.Windows.Forms.TextBox();
            this.loginPassword = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.ユーザー名 = new System.Windows.Forms.Label();
            this.パスワード = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginUsername
            // 
            this.loginUsername.Location = new System.Drawing.Point(96, 62);
            this.loginUsername.Name = "loginUsername";
            this.loginUsername.Size = new System.Drawing.Size(100, 19);
            this.loginUsername.TabIndex = 0;
            // 
            // loginPassword
            // 
            this.loginPassword.Location = new System.Drawing.Point(96, 113);
            this.loginPassword.Name = "loginPassword";
            this.loginPassword.Size = new System.Drawing.Size(100, 19);
            this.loginPassword.TabIndex = 1;
            this.loginPassword.UseSystemPasswordChar = true;
            // 
            // OkButton
            // 
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.Location = new System.Drawing.Point(197, 228);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // ユーザー名
            // 
            this.ユーザー名.AutoSize = true;
            this.ユーザー名.Location = new System.Drawing.Point(29, 62);
            this.ユーザー名.Name = "ユーザー名";
            this.ユーザー名.Size = new System.Drawing.Size(57, 12);
            this.ユーザー名.TabIndex = 3;
            this.ユーザー名.Text = "ユーザー名";
            this.ユーザー名.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // パスワード
            // 
            this.パスワード.AutoSize = true;
            this.パスワード.Location = new System.Drawing.Point(29, 113);
            this.パスワード.Name = "パスワード";
            this.パスワード.Size = new System.Drawing.Size(52, 12);
            this.パスワード.TabIndex = 4;
            this.パスワード.Text = "パスワード";
            this.パスワード.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 263);
            this.Controls.Add(this.パスワード);
            this.Controls.Add(this.ユーザー名);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.loginPassword);
            this.Controls.Add(this.loginUsername);
            this.Name = "OptionForm";
            this.Text = "設定";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginUsername;
        private System.Windows.Forms.TextBox loginPassword;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label ユーザー名;
        private System.Windows.Forms.Label パスワード;
    }
}
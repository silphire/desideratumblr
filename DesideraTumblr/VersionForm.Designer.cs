namespace DesideraTumblr
{
    partial class VersionForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.ProductName = new System.Windows.Forms.Label();
            this.ProductVersion = new System.Windows.Forms.Label();
            this.CompanyName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(105, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ProductName
            // 
            this.ProductName.AutoSize = true;
            this.ProductName.Location = new System.Drawing.Point(125, 37);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(35, 12);
            this.ProductName.TabIndex = 1;
            this.ProductName.Text = "label1";
            // 
            // ProductVersion
            // 
            this.ProductVersion.AutoSize = true;
            this.ProductVersion.Location = new System.Drawing.Point(125, 59);
            this.ProductVersion.Name = "ProductVersion";
            this.ProductVersion.Size = new System.Drawing.Size(35, 12);
            this.ProductVersion.TabIndex = 2;
            this.ProductVersion.Text = "label2";
            // 
            // CompanyName
            // 
            this.CompanyName.AutoSize = true;
            this.CompanyName.Location = new System.Drawing.Point(125, 80);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(35, 12);
            this.CompanyName.TabIndex = 3;
            this.CompanyName.Text = "label1";
            // 
            // VersionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 143);
            this.Controls.Add(this.CompanyName);
            this.Controls.Add(this.ProductVersion);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.button1);
            this.Name = "VersionForm";
            this.Text = "バージョン情報";
            this.Load += new System.EventHandler(this.VersionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ProductName;
        private System.Windows.Forms.Label ProductVersion;
        private System.Windows.Forms.Label CompanyName;
    }
}
namespace DesideraTumblr
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripMainForm = new System.Windows.Forms.MenuStrip();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTool = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemOption = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.vScrollBarMainForm = new System.Windows.Forms.VScrollBar();
            this.trackBarImageSize = new System.Windows.Forms.TrackBar();
            this.menuStripMainForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarImageSize)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripMainForm
            // 
            this.menuStripMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFile,
            this.MenuItemTool,
            this.MenuItemHelp});
            this.menuStripMainForm.Location = new System.Drawing.Point(0, 0);
            this.menuStripMainForm.Name = "menuStripMainForm";
            this.menuStripMainForm.Size = new System.Drawing.Size(284, 26);
            this.menuStripMainForm.TabIndex = 0;
            this.menuStripMainForm.Text = "menuStrip1";
            // 
            // MenuItemFile
            // 
            this.MenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemLogin,
            this.MenuItemQuit});
            this.MenuItemFile.Name = "MenuItemFile";
            this.MenuItemFile.Size = new System.Drawing.Size(85, 22);
            this.MenuItemFile.Text = "ファイル(&F)";
            // 
            // MenuItemLogin
            // 
            this.MenuItemLogin.Name = "MenuItemLogin";
            this.MenuItemLogin.Size = new System.Drawing.Size(152, 22);
            this.MenuItemLogin.Text = "ログイン(&L)";
            this.MenuItemLogin.Click += new System.EventHandler(this.Login_Click);
            // 
            // MenuItemQuit
            // 
            this.MenuItemQuit.Name = "MenuItemQuit";
            this.MenuItemQuit.Size = new System.Drawing.Size(152, 22);
            this.MenuItemQuit.Text = "終了(&Q)";
            this.MenuItemQuit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // MenuItemTool
            // 
            this.MenuItemTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemOption});
            this.MenuItemTool.Name = "MenuItemTool";
            this.MenuItemTool.Size = new System.Drawing.Size(74, 22);
            this.MenuItemTool.Text = "ツール(&T)";
            // 
            // MenuItemOption
            // 
            this.MenuItemOption.Name = "MenuItemOption";
            this.MenuItemOption.Size = new System.Drawing.Size(155, 22);
            this.MenuItemOption.Text = "オプション(&O)";
            this.MenuItemOption.Click += new System.EventHandler(this.Option_Click);
            // 
            // MenuItemHelp
            // 
            this.MenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemVersion});
            this.MenuItemHelp.Name = "MenuItemHelp";
            this.MenuItemHelp.Size = new System.Drawing.Size(75, 22);
            this.MenuItemHelp.Text = "ヘルプ(&H)";
            // 
            // MenuItemVersion
            // 
            this.MenuItemVersion.Name = "MenuItemVersion";
            this.MenuItemVersion.Size = new System.Drawing.Size(178, 22);
            this.MenuItemVersion.Text = "バージョン情報(&V)";
            this.MenuItemVersion.Click += new System.EventHandler(this.Version_Click);
            // 
            // vScrollBarMainForm
            // 
            this.vScrollBarMainForm.Location = new System.Drawing.Point(266, 24);
            this.vScrollBarMainForm.Name = "vScrollBarMainForm";
            this.vScrollBarMainForm.Size = new System.Drawing.Size(17, 192);
            this.vScrollBarMainForm.TabIndex = 1;
            // 
            // trackBarImageSize
            // 
            this.trackBarImageSize.Location = new System.Drawing.Point(150, 218);
            this.trackBarImageSize.Name = "trackBarImageSize";
            this.trackBarImageSize.Size = new System.Drawing.Size(134, 45);
            this.trackBarImageSize.TabIndex = 2;
            this.trackBarImageSize.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 263);
            this.Controls.Add(this.trackBarImageSize);
            this.Controls.Add(this.vScrollBarMainForm);
            this.Controls.Add(this.menuStripMainForm);
            this.MainMenuStrip = this.menuStripMainForm;
            this.Name = "MainForm";
            this.Text = "desideratumblr";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.menuStripMainForm.ResumeLayout(false);
            this.menuStripMainForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarImageSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMainForm;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem MenuItemQuit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTool;
        private System.Windows.Forms.ToolStripMenuItem MenuItemOption;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem MenuItemVersion;
        private System.Windows.Forms.VScrollBar vScrollBarMainForm;
        private System.Windows.Forms.TrackBar trackBarImageSize;
        private System.Windows.Forms.ToolStripMenuItem MenuItemLogin;
    }
}


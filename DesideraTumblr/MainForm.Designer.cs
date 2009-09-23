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
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了QToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ツールTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.オプションOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.バージョン情報VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vScrollBarMainForm = new System.Windows.Forms.VScrollBar();
            this.trackBarImageSize = new System.Windows.Forms.TrackBar();
            this.menuStripMainForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarImageSize)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripMainForm
            // 
            this.menuStripMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem,
            this.ツールTToolStripMenuItem,
            this.ヘルプHToolStripMenuItem});
            this.menuStripMainForm.Location = new System.Drawing.Point(0, 0);
            this.menuStripMainForm.Name = "menuStripMainForm";
            this.menuStripMainForm.Size = new System.Drawing.Size(284, 24);
            this.menuStripMainForm.TabIndex = 0;
            this.menuStripMainForm.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.終了QToolStripMenuItem});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 終了QToolStripMenuItem
            // 
            this.終了QToolStripMenuItem.Name = "終了QToolStripMenuItem";
            this.終了QToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.終了QToolStripMenuItem.Text = "終了(&Q)";
            this.終了QToolStripMenuItem.Click += new System.EventHandler(this.Quit_Click);
            // 
            // ツールTToolStripMenuItem
            // 
            this.ツールTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.オプションOToolStripMenuItem});
            this.ツールTToolStripMenuItem.Name = "ツールTToolStripMenuItem";
            this.ツールTToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ツールTToolStripMenuItem.Text = "ツール(&T)";
            // 
            // オプションOToolStripMenuItem
            // 
            this.オプションOToolStripMenuItem.Name = "オプションOToolStripMenuItem";
            this.オプションOToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.オプションOToolStripMenuItem.Text = "オプション(&O)";
            this.オプションOToolStripMenuItem.Click += new System.EventHandler(this.Option_Click);
            // 
            // ヘルプHToolStripMenuItem
            // 
            this.ヘルプHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.バージョン情報VToolStripMenuItem});
            this.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            this.ヘルプHToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // バージョン情報VToolStripMenuItem
            // 
            this.バージョン情報VToolStripMenuItem.Name = "バージョン情報VToolStripMenuItem";
            this.バージョン情報VToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.バージョン情報VToolStripMenuItem.Text = "バージョン情報(&V)";
            this.バージョン情報VToolStripMenuItem.Click += new System.EventHandler(this.Version_Click);
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
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了QToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ツールTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem オプションOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem バージョン情報VToolStripMenuItem;
        private System.Windows.Forms.VScrollBar vScrollBarMainForm;
        private System.Windows.Forms.TrackBar trackBarImageSize;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesideraTumblr
{
    public partial class MainForm : Form
    {
        private Tumblr.Dashboard dashboard;

        public MainForm()
        {
            dashboard = new Tumblr.Dashboard();

            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        //
        // 設定ダイアログを表示する
        //
        private void Option_Click(object sender, EventArgs e)
        {
            OptionForm form = new OptionForm();
            form.ShowDialog(this);
            form.Dispose();
        }

        //
        // アプリケーションを終了する
        //
        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //
        // バージョン情報のダイアログ
        //
        private void Version_Click(object sender, EventArgs e)
        {
            VersionForm form = new VersionForm();
            form.ShowDialog(this);
            form.Dispose();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            // コントロールの再配置

            vScrollBarMainForm.Top = menuStripMainForm.Height;
            vScrollBarMainForm.Height = this.ClientSize.Height - menuStripMainForm.Height - trackBarImageSize.Height;
            vScrollBarMainForm.Left = this.ClientSize.Width - vScrollBarMainForm.Width;

            trackBarImageSize.Left = this.ClientSize.Width - trackBarImageSize.Width;
            trackBarImageSize.Top = this.ClientSize.Height - trackBarImageSize.Height;
        }

        // ログイン時の処理
        private void Login_Click(object sender, EventArgs e)
        {
            ParameterSettings settings = DesideraTumblr.ParameterSettings.Default;

            while (settings.EMail.Length == 0 || settings.Password.Length == 0)
            {
                // Eメールアドレスとパスワードを入力させる
                OptionForm form = new OptionForm();
                form.ShowDialog(this);
                form.Dispose();
            }

            dashboard.Login(settings.EMail, settings.Password);
        }
    }
}

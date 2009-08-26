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
        public MainForm()
        {
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
    }
}

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
    public partial class VersionForm : Form
    {
        public VersionForm()
        {
            InitializeComponent();
        }

        //
        // アセンブリ定義からアプリケーションの情報を取得してダイアログに貼り付ける
        //
        private void VersionForm_Load(object sender, EventArgs e)
        {
            this.ProductName.Text = Application.ProductName;
            this.ProductName.Left = (this.ClientRectangle.Width - this.ProductName.Width) / 2;
            this.CompanyName.Text = Application.CompanyName;
            this.CompanyName.Left = (this.ClientRectangle.Width - this.CompanyName.Width) / 2;
            this.ProductVersion.Text = "version " + Application.ProductVersion;
            this.ProductVersion.Left = (this.ClientRectangle.Width - this.ProductVersion.Width) / 2;
        }
    }
}

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
    public partial class OptionForm : Form
    {
        public OptionForm()
        {
            InitializeComponent();

            ParameterSettings s = DesideraTumblr.ParameterSettings.Default;
            loginUsername.AppendText(s.EMail);
            loginPassword.AppendText(s.Password);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            ParameterSettings s = DesideraTumblr.ParameterSettings.Default;
            s.EMail = loginUsername.Text;
            s.Password = loginPassword.Text;
            s.Save();
        }
    }
}

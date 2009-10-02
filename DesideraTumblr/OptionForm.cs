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

            loginUsername.AppendText(DesideraTumblr.ParameterSettings.Default.EMail);
            loginPassword.AppendText(DesideraTumblr.ParameterSettings.Default.Password);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            DesideraTumblr.ParameterSettings.Default.EMail = loginUsername.Text;
            DesideraTumblr.ParameterSettings.Default.Password = loginPassword.Text;
            DesideraTumblr.ParameterSettings.Default.Save();
        }
    }
}

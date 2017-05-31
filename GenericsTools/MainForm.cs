using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GenericsTools
{
    public partial class MainForm : Form
    {
        private delegate void OnBtnIdClick(object sender, EventArgs e);

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBuildId_Click(object sender, EventArgs e)
        {
            txtIdResult.Text = "";
            int count = 1;
            if (!string.IsNullOrEmpty(txtIdCount.Text))
            {
                count = Convert.ToInt32(txtIdCount.Text);
            }

            for (int i = 0; i < count; i++)
            {
                string uuid;
                if (chbUuidTime.Checked)
                {
                    uuid = GenericsUtils.CreateTimeUuid();
                }
                else
                {
                    uuid = GenericsUtils.CreateUuid();
                }

                if (chbIdUpper.Checked)
                {
                    uuid = uuid.ToUpper();
                }

                if (chbDeleteIdLine.Checked)
                {
                    uuid = uuid.Replace("-", "");
                }

                txtIdResult.Text += uuid + "\r\n";
            }
        }

        private void txtIdCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btnBuildMd5_Click(object sender, EventArgs e)
        {
            string source = txtMd5Source.Text.Trim();
            if (!string.IsNullOrEmpty(source))
            {
                string md5 = GenericsUtils.Md5(source);
                txtMd5Lower.Text = md5.ToLower();
                txtMd5Upper.Text = md5;
            }
        }
    }
}

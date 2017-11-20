using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common.Wechat.Test;

namespace WeixinServices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestSendMessage.sendText(this.tbTxt.Text.Trim());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TestSendMessage.sendMpNews(this.mpPic.Text.Trim(), this.mpTitle.Text.Trim(), this.mpAuthor.Text.Trim(), this.mpDigest.Text.Trim(), this.mpContent.Text.Trim());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TestSendMessage.sendNews(this.newsPic.Text.Trim(), this.newsTitle.Text.Trim(), this.newsDigest.Text.Trim(), this.newsUrl.Text.Trim());
        }
    }
}

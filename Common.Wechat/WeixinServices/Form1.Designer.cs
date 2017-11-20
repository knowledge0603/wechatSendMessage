namespace WeixinServices
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tbTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mpAuthor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mpContent = new System.Windows.Forms.TextBox();
            this.mpDigest = new System.Windows.Forms.TextBox();
            this.mpTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mpPic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.newsUrl = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.newsPic = new System.Windows.Forms.TextBox();
            this.newsDigest = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.newsTitle = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(406, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "文字信息";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(191, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "图文信息（mpnews）";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(216, 210);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 39);
            this.button3.TabIndex = 2;
            this.button3.Text = "图文信息";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbTxt
            // 
            this.tbTxt.Location = new System.Drawing.Point(6, 30);
            this.tbTxt.Name = "tbTxt";
            this.tbTxt.Size = new System.Drawing.Size(380, 25);
            this.tbTxt.TabIndex = 3;
            this.tbTxt.Text = "文字信息测试";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTxt);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(4, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 72);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文字信息";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mpAuthor);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.mpContent);
            this.groupBox2.Controls.Add(this.mpDigest);
            this.groupBox2.Controls.Add(this.mpTitle);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.mpPic);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(10, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 319);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "图文信息（mpnews）";
            // 
            // mpAuthor
            // 
            this.mpAuthor.Location = new System.Drawing.Point(79, 109);
            this.mpAuthor.Name = "mpAuthor";
            this.mpAuthor.Size = new System.Drawing.Size(426, 25);
            this.mpAuthor.TabIndex = 12;
            this.mpAuthor.Text = "作者";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "作者";
            // 
            // mpContent
            // 
            this.mpContent.Location = new System.Drawing.Point(79, 177);
            this.mpContent.Multiline = true;
            this.mpContent.Name = "mpContent";
            this.mpContent.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.mpContent.Size = new System.Drawing.Size(426, 79);
            this.mpContent.TabIndex = 10;
            this.mpContent.Text = "点击后全文，支持html标签，但是不能带有img等图片。<br/>图片是不会显示的。";
            // 
            // mpDigest
            // 
            this.mpDigest.Location = new System.Drawing.Point(79, 146);
            this.mpDigest.Name = "mpDigest";
            this.mpDigest.Size = new System.Drawing.Size(426, 25);
            this.mpDigest.TabIndex = 9;
            this.mpDigest.Text = "摘要内容";
            // 
            // mpTitle
            // 
            this.mpTitle.Location = new System.Drawing.Point(79, 72);
            this.mpTitle.Name = "mpTitle";
            this.mpTitle.Size = new System.Drawing.Size(426, 25);
            this.mpTitle.TabIndex = 8;
            this.mpTitle.Text = "标题";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "全文";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "摘要";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "标题";
            // 
            // mpPic
            // 
            this.mpPic.Location = new System.Drawing.Point(79, 36);
            this.mpPic.Name = "mpPic";
            this.mpPic.Size = new System.Drawing.Size(426, 25);
            this.mpPic.TabIndex = 4;
            this.mpPic.Text = "E:\\images\\20170928101228.png";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "封面图片";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.newsUrl);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.newsPic);
            this.groupBox3.Controls.Add(this.newsDigest);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.newsTitle);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(12, 483);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(518, 260);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "图文信息";
            // 
            // newsUrl
            // 
            this.newsUrl.Location = new System.Drawing.Point(81, 179);
            this.newsUrl.Name = "newsUrl";
            this.newsUrl.Size = new System.Drawing.Size(426, 25);
            this.newsUrl.TabIndex = 20;
            this.newsUrl.Text = "http://www.baidu.com";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(4, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(508, 36);
            this.label7.TabIndex = 13;
            this.label7.Text = "图文消息，格式同图文信息类似，但是封面图片和原文链接都需要网络上已存在的地址。";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 15);
            this.label12.TabIndex = 13;
            this.label12.Text = "图片地址";
            // 
            // newsPic
            // 
            this.newsPic.Location = new System.Drawing.Point(81, 68);
            this.newsPic.Name = "newsPic";
            this.newsPic.Size = new System.Drawing.Size(426, 25);
            this.newsPic.TabIndex = 14;
            this.newsPic.Text = "https://www.baidu.com/img/bd_logo1.png";
            // 
            // newsDigest
            // 
            this.newsDigest.Location = new System.Drawing.Point(81, 142);
            this.newsDigest.Name = "newsDigest";
            this.newsDigest.Size = new System.Drawing.Size(426, 25);
            this.newsDigest.TabIndex = 19;
            this.newsDigest.Text = "摘要";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 15);
            this.label11.TabIndex = 15;
            this.label11.Text = "标题";
            // 
            // newsTitle
            // 
            this.newsTitle.Location = new System.Drawing.Point(81, 104);
            this.newsTitle.Name = "newsTitle";
            this.newsTitle.Size = new System.Drawing.Size(426, 25);
            this.newsTitle.TabIndex = 18;
            this.newsTitle.Text = "标题";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "摘要";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "全文地址";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 755);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "微信企业号信息发送工具";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox mpPic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mpContent;
        private System.Windows.Forms.TextBox mpDigest;
        private System.Windows.Forms.TextBox mpTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mpAuthor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox newsPic;
        private System.Windows.Forms.TextBox newsDigest;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox newsTitle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox newsUrl;
    }
}


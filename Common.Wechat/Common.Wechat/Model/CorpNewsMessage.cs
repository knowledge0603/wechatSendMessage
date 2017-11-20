using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Wechat.Model
{
    /// <summary>
    /// 图文信息类
    /// </summary>
    public class CorpNewsMessage : CorpMessageBase
    {
        /// <summary>
        /// 图文消息，一个图文消息支持1到8条图文
        /// </summary>
        public News news { get; set; }

        public CorpNewsMessage()
            : base("news")
        { 
        }
    }

    /// <summary>
    /// 图文消息，一个图文消息支持1到8条图文,应对Json结构特别抽取的类
    /// </summary>
    public class News
    {
        /// <summary>
        /// 图文消息，一个图文消息支持1到8条图文
        /// </summary>
        public List<NewsArticle> articles { set; get; }
    }

    /// <summary>
    /// 图文消息，一个图文消息支持1到8条图文
    /// </summary>
    public class NewsArticle
    {
        /// <summary>
        /// 标题，不超过128个字节，超过会自动截断
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// 描述，不超过512个字节，超过会自动截断
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// 点击后跳转的链接。
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// 图文消息的图片链接，支持JPG、PNG格式，较好的效果为大图640*320，小图80*80。如不填，在客户端不显示图片
        /// </summary>
        public string picurl { get; set; }
    }
}

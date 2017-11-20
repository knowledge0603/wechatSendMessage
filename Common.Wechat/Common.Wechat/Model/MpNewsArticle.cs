using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Wechat.Model
{
    /// <summary>
    /// 图文消息，一个图文消息支持1到10个图文
    /// </summary>
    public class MpNewsArticle
    {
        /// <summary>
        /// 图文消息的标题，不超过128个字节，超过会自动截断
        /// </summary>
        public string title { set; get; }

        /// <summary>
        /// 图文消息缩略图的media_id, 可以在上传永久素材接口中获得
        /// 此处thumb_media_id即上传接口返回的media_id
        /// </summary>
        public string thumb_media_id { set; get; }

        /// <summary>
        /// 图文消息的作者，不超过64个字节
        /// </summary>
        public string author { set; get; }

        /// <summary>
        /// 图文消息点击“阅读原文”之后的页面链接
        /// </summary>
        public string content_source_url { set; get; }

        /// <summary>
        /// 图文消息的内容，支持html标签,不超过666 K个字节
        /// </summary>
        public string content { set; get; }

        /// <summary>
        /// 图文消息的描述，不超过512个字节，超过会自动截断
        /// </summary>
        public string digest { set; get; }

        /// <summary>
        /// 是否显示封面，1为显示，0为不显示。默认为0
        /// </summary>
        public string show_cover_pic { set; get; }
    }
}

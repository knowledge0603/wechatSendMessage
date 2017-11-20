using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Wechat.Model
{
    /// <summary>
    /// 图片消息类
    /// </summary>
    public class CorpImageMessage : CorpMessageBase
    {
        /// <summary>
        /// 图片媒体文件id，可以调用上传临时素材或者永久素材接口获取,永久素材media_id必须由发消息的应用创建
        /// </summary>
        public Image image { get; set; }

        public CorpImageMessage()
            : base("image")
        { 
        }
    }

    /// <summary>
    /// 应对Json结构特别抽取的Image类
    /// </summary>
    public class Image
    {
        /// <summary>
        /// 图片媒体文件id，可以调用上传临时素材或者永久素材接口获取,永久素材media_id必须由发消息的应用创建
        /// </summary>
        public string media_id { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Wechat.Model
{
    /// <summary>
    /// 视频消息类
    /// </summary>
    public class CorpVideoMessage : CorpMessageBase
    {
        /// <summary>
        /// 视频消息id，可以调用上传临时素材或者永久素材接口获取
        /// </summary>
        public Video video { get; set; }

        public CorpVideoMessage()
            : base("video")
        { 
        }
    }

    /// <summary>
    /// 应对Json结构特别抽取的类
    /// </summary>
    public class Video
    {
        /// <summary>
        /// 视频消息id，可以调用上传临时素材或者永久素材接口获取
        /// </summary>
        public string media_id { get; set; }
    }
}

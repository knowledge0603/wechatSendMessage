using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Wechat.Model
{
    /// <summary>
    /// 媒体文件消息类
    /// </summary>
    public class CorpFileMessage : CorpMessageBase
    {
        /// <summary>
        /// 媒体文件id，可以调用上传临时素材或者永久素材接口获取
        /// </summary>
        public File file { get; set; }

        public CorpFileMessage()
            : base("file")
        { 
        }
    }

    /// <summary>
    /// 应对Json结构特别抽取的类
    /// </summary>
    public class File
    {
        /// <summary>
        /// 媒体文件id，可以调用上传临时素材或者永久素材接口获取
        /// </summary>
        public string media_id { get; set; }
    }
}

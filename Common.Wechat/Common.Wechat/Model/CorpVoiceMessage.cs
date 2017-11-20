using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Wechat.Model
{
    /// <summary>
    /// 语音消息类
    /// </summary>
    public class CorpVoiceMessage : CorpMessageBase
    {
        /// <summary>
        /// 语音文件id，可以调用上传临时素材或者永久素材接口获取
        /// </summary>
        public Voice voice { get; set; }


        public CorpVoiceMessage()
            : base("voice")
        { 
        }
    }

    /// <summary>
    /// 应对Json结构特别抽取的类
    /// </summary>
    public class Voice
    {
        /// <summary>
        /// 语音文件id，可以调用上传临时素材或者永久素材接口获取
        /// </summary>
        public string media_id { get; set; }
    }
}

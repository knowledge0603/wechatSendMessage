using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Wechat.Model
{
    /// <summary>
    /// 文本消息类
    /// </summary>
    public class CorpTextMessage : CorpMessageBase
    {
        /// <summary>
        /// 消息内容，最长不超过2048个字节，注意：主页型应用推送的文本消息在微信端最多只显示20个字（包含中英文）
        /// </summary>
        public Text text { get; set; }

        public CorpTextMessage()
            : base("text")
        { 
        }
    }

    /// <summary>
    /// 应对Json结构特别抽取的Text类
    /// </summary>
    public class Text
    {
        /// <summary>
        /// 消息内容，最长不超过2048个字节，注意：主页型应用推送的文本消息在微信端最多只显示20个字（包含中英文）
        /// </summary>
        public string content { get; set; }
    }
}

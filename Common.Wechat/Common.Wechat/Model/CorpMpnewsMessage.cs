using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Wechat.Model
{
    /// <summary>
    /// 支持保密的图文消息类
    /// mpnews消息与news消息类似，不同的是图文消息内容存储在微信后台，并且支持保密选项。每个应用每天最多可以发送100次。
    /// </summary>
    public class CorpMpnewsMessage : CorpMessageBase
    {
        /// <summary>
        /// 图文消息,可直接使用图文消息进行发送,也可以直接使用永久上传的素材ID进行发送.
        /// 若使用图文消息进行发送,则articles必须赋予相应的值,若使用永久上传的素材ID进行发送,则只需指定media_id.
        /// </summary>
        public MpNews mpnews { get; set; }

        public CorpMpnewsMessage()
            : base("mpnews")
        {
        }
    }

    /// <summary>
    /// 图文消息,可直接使用图文消息进行发送,也可以直接使用永久上传的素材ID进行发送.
    /// 若使用图文消息进行发送,则articles必须赋予相应的值,若使用永久上传的素材ID进行发送,则只需指定media_id.
    /// </summary>
    public class MpNews
    {
        /// <summary>
        /// 素材资源标识ID，通过上传永久图文素材接口获得。注：必须是在该agent下创建的。
        /// 若有指定articles属性,则无需指定media_id属性
        /// </summary>
        public string media_id { get; set; }

        /// <summary>
        /// 图文消息，一个图文消息支持1到8个图文
        /// 若有指定media_id属性,则无需指定articles属性
        /// </summary>
        public List<MpNewsArticle> articles { get; set; }
    }
}

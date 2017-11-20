using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace Common.Wechat.Model
{
    public class WechatCommonPara
    {
        /// <summary>
        /// corpid 企业Id
        /// </summary>
        public static readonly string CorpId = ConfigurationManager.AppSettings["corpid"].ToString();

        /// <summary>
        /// corpsecret 管理组的凭证密钥
        /// </summary>
        public static readonly string CorpSecret = ConfigurationManager.AppSettings["corpsecret"].ToString();

        /// <summary>
        /// agentid 企业应用的id，整型。可在应用的设置页面查看
        /// </summary>
        public static readonly string AgentId = ConfigurationManager.AppSettings["agentid"].ToString();

        /// <summary>
        /// 成员ID列表（消息接收者，多个接收者用‘|’分隔，最多支持1000个）。特殊情况：指定为@all，则向该企业应用的全部成员发送
        /// </summary>
        public static readonly string ToUser = ConfigurationManager.AppSettings["touser"].ToString();
    }
}

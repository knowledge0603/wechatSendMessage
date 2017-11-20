using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Common.Wechat.Model
{
    /// <summary>
    /// 发送的消息基类
    /// </summary>
    public class CorpMessageBase
    {
        /// <summary>
        /// UserID列表（消息接收者，多个接收者用‘|’分隔）。特殊情况：指定为@all，则向关注该企业应用的全部成员发送
        /// </summary>
        public string touser { get; set; }

        /// <summary>
        /// PartyID列表，多个接受者用‘|’分隔。当touser为@all时忽略本参数
        /// </summary>
        public string toparty { get; set; }

        /// <summary>
        /// TagID列表，多个接受者用‘|’分隔。当touser为@all时忽略本参数
        /// </summary>
        public string totag { get; set; }

        /// <summary>
        /// 消息类型
        /// </summary>
        public readonly string msgtype;

        /// <summary>
        /// 企业应用的id，整型。可在应用的设置页面查看
        /// </summary>
        public readonly string agentid = WechatCommonPara.AgentId;

        /// <summary>
        /// 表示是否是保密消息，0表示否，1表示是，默认0
        /// </summary>
        public int safe { get; set; }

        /// <summary>
        /// 构造器,需传入消息类型
        /// </summary>
        /// <param name="msgtype">消息类型</param>
        public CorpMessageBase(string msgtype)
        {
            this.msgtype = msgtype;
        }
    }
}

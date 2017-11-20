using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Wechat.Model;

namespace Common.Wechat.Service
{
    /// <summary>
    /// 企业号发送消息接口
    /// </summary>
    public interface ICropMessage
    {
        /// <summary>
        /// 发送消息
        /// 收件人必须处于应用的可见范围内，并且管理组对应用有使用权限、对收件人有查看权限，否则本次调用失败
        /// </summary>
        /// <param name="sendData"></param>
        /// <returns></returns>
        CommonResult SendMessage(CorpMessageBase sendData);
    }
}

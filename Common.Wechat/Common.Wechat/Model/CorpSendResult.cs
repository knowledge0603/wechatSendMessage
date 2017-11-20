using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Wechat.Model
{
    /// <summary>
    /// 发送消息返回结果
    /// </summary>
    public class CorpSendResult
    {
        /// <summary>
        /// err code
        /// </summary>
        public string errcode { set; get; }

        /// <summary>
        /// err 描述
        /// </summary>
        public string errmsg { set; get; }

        /// <summary>
        /// 发送无效的User Id
        /// </summary>
        public string invaliduser { set; get; }

        /// <summary>
        /// 发送无效的部门
        /// </summary>
        public string invalidparty { set; get; }

        /// <summary>
        /// 发送无效的标签
        /// </summary>
        public string invalidtag { set; get; }
    }
}

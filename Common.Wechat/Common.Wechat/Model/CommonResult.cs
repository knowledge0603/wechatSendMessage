using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Wechat.Model
{
    /// <summary>
    /// 通用消息类
    /// </summary>
    public class CommonResult
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        public bool Success { set; get; }

        /// <summary>
        /// 错误信息
        /// </summary>
        public string ErrorMessage { set; get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Wechat.Model
{
    public class CropTokenResult
    {
        /// <summary>
        /// 获取到的凭证。长度为64至512个字节
        /// </summary>
        public string access_token{set;get;}

        /// <summary>
        /// 凭证的有效时间
        /// </summary>
        public int expires_in{set;get;}

        /// <summary>
        /// err code
        /// </summary>
        public string errcode{set;get;}

        /// <summary>
        /// err 描述
        /// </summary>
        public string errmsg{set;get;}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Wechat.Model
{
    public class CropMaterialResult
    {
        /// <summary>
        /// 素材资源标识ID
        /// </summary>
        public string media_id { set; get; }

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

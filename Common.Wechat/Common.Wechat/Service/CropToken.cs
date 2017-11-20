using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Common.Wechat.Model;
using System.Configuration;
using Common.Util.Web;

namespace Common.Wechat.Service
{
    public class CropToken
    {
        /// <summary>
        /// Access Token,调用接口凭证
        /// </summary>
        public static readonly string AccessToken = GetAccessToken();

        /// <summary>
        /// 获取token,若token存在则返回当前值,若不存在则调用接口重新获取
        /// </summary>
        /// <returns></returns>
        private static string GetAccessToken()
        {
            if (string.IsNullOrEmpty(AccessToken))
            {
                //从配置文件获取corpid
                string corpid = WechatCommonPara.CorpId;
                //从配置文件获取corpsecret
                string corpsecret = WechatCommonPara.CorpSecret;
                string para = string.Format("corpid={0}&corpsecret={1}", corpid, corpsecret);
                //获取token
                string returnStr = CostomHttpRequest.HttpGet("https://qyapi.weixin.qq.com/cgi-bin/gettoken", para);
                //转换成Object
                CropTokenResult tokenResult = JsonConvert.DeserializeObject<CropTokenResult>(returnStr);
                //取token失败则抛出异常
                if (string.IsNullOrEmpty(tokenResult.access_token))
                {
                    throw new Exception(string.Format("errcode:{0},errmsg:{1}",
                        tokenResult.errcode, tokenResult.errmsg));
                }
                return tokenResult.access_token;
            }
            else
            {
                return AccessToken;
            }
        }
    }
}

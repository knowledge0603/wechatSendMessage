using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Wechat.Model;
using Newtonsoft.Json;
using Common.Util.Web;

namespace Common.Wechat.Service
{
    /// <summary>
    /// 企业号发送消息实现类
    /// </summary>
    public class CropMessage : ICropMessage
    {
        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="sendData">要发送的消息</param>
        /// <returns></returns>
        public CommonResult SendMessage(CorpMessageBase sendData)
        {
            CommonResult result = new CommonResult();
            try
            {
                //拼接post的url
                string urlFormat = "https://qyapi.weixin.qq.com/cgi-bin/message/send?access_token={0}";
                string url = string.Format(urlFormat, CropToken.AccessToken);
                //发送消息
                CorpSendResult sendResult = SendMessage(url, sendData);
                //处理发送结果
                if (sendResult.errcode != "0")
                {
                    result.Success = false;
                    result.ErrorMessage = string.Format("errmsg:{0},invaliduser:{1},invalidparty:{2},invalidtag:{3}",
                        sendResult.errmsg, sendResult.invaliduser, sendResult.invalidparty, sendResult.invalidtag);
                }
                else
                {
                    result.Success = true;
                    result.ErrorMessage = string.Format("errmsg:{0},invaliduser:{1},invalidparty:{2},invalidtag:{3}",
                        sendResult.errmsg, sendResult.invaliduser, sendResult.invalidparty, sendResult.invalidtag);
                }
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }


        private CorpSendResult SendMessage(string url, CorpMessageBase sendData)
        {
            CorpSendResult result = new CorpSendResult();
            //发出请求
            string returnStr = CostomHttpRequest.HttpPost(url, JsonConvert.SerializeObject(sendData));
            //返回结果反序列化
            result = JsonConvert.DeserializeObject<CorpSendResult>(returnStr);
            return result;
        }
    }
}

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
    /// 企业号管理素材实现类
    /// </summary>
    public class CropMaterial : ICropMaterial
    {
        /// <summary>
        /// 上传永久素材
        /// media_id是可复用的，同一个media_id可用于消息的多次发送
        /// </summary>
        /// <param name="type">媒体文件类型，分别有图片（image）、语音（voice）、视频（video），普通文件(file)</param>
        /// <param name="path">文件路径</param>
        /// <param name="mediaId">返回的素材media_id</param>
        /// <returns></returns>
        public CommonResult Add(string type, string path, ref string mediaId)
        {
            CommonResult result = new CommonResult();
            mediaId = "";
            try
            {
                //url
                string urlFormat = "https://qyapi.weixin.qq.com/cgi-bin/media/upload?access_token={0}&type={1}";
                string url = string.Format(urlFormat, CropToken.AccessToken, type);
                string returnStr = CostomHttpRequest.UploadFile(url, path);

                //发送消息
                CropMaterialResult materialResult = JsonConvert.DeserializeObject<CropMaterialResult>(returnStr);
                //处理发送结果
                if (materialResult.errcode != "0")
                {
                    result.Success = false;
                    result.ErrorMessage = string.Format("errcode:{0},errmsg:{1}",
                        materialResult.errcode, materialResult.errmsg);
                }
                else
                {
                    result.Success = true;
                    mediaId = materialResult.media_id;
                    result.ErrorMessage = string.Format("errcode:{0},errmsg:{1}",
                        materialResult.errcode, materialResult.errmsg);
                }
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }
    }
}

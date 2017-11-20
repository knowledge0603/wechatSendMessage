using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Wechat.Model;

namespace Common.Wechat.Service
{
    /// <summary>
    /// 企业号管理素材接口定义
    /// </summary>
    public interface ICropMaterial
    {
        /// <summary>
        /// 上传永久素材
        /// media_id是可复用的，同一个media_id可用于消息的多次发送
        /// </summary>
        /// <param name="type">媒体文件类型，分别有图片（image）、语音（voice）、视频（video），普通文件(file)</param>
        /// <param name="path">文件路径</param>
        /// <param name="mediaId">返回的素材media_id</param>
        /// <returns></returns>
        CommonResult Add(string type, string path, ref string mediaId);

        /// <summary>
        /// 上传临时素材
        /// media_id是可复用的，同一个media_id可用于消息的多次发送(3天内有效)
        /// </summary>
        /// <param name="path">文件路径</param>
        /// <param name="mediaId">返回的素材media_id</param>
        /// <returns></returns>
        //CommonResult AddTemp(string path, ref string mediaId);
    }
}

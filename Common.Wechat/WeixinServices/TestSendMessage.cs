using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Common.Wechat.Model;
using Common.Wechat.Service;


namespace Common.Wechat.Test
{
    public class TestSendMessage
    {


        public static void sendText(string txt)
        {
            //发送文字消息
            CorpTextMessage ctx = new CorpTextMessage
            {
                touser = WechatCommonPara.ToUser,
                toparty = "",
                totag = "",
                text = new Text { content = txt },
                safe = 0
            };
            ICropMessage cm = new CropMessage();
            CommonResult result = cm.SendMessage(ctx);
        }

        //发送已存在图文素材的图文消息
        public static void sendOldNews()
        {
            CorpMpnewsMessage ctx = new CorpMpnewsMessage
            {
                touser = WechatCommonPara.ToUser,
                toparty = "",
                totag = "",
                mpnews = new MpNews { media_id = "25HGfQxHkUoJJ7LnVU_YyFR2SAg4JFcysBOzlLUg9JRRLPkUJiEG4T1vh5GAO-fIt" },
                safe = 1
            };

            ICropMessage cm = new CropMessage();
            CommonResult result = cm.SendMessage(ctx);
        }

        //发送不存在图文素材的图文消息
        public static void sendMpNews(string mpPic, string mpTitle, string mpAuthor, string mpDigest, string mpContent)
        {
            #region 过期代码


            //{
            //    "touser": "UserID1|UserID2|UserID3",
            //    "toparty": " PartyID1 | PartyID2 ",
            //    "totag": " TagID1 | TagID2 ",
            //    "msgtype": "mpnews",
            //    "agentid": 1,
            //    "mpnews": {
            //        "articles":[
            //            {
            //                "title": "Title",
            //                "thumb_media_id": "id",
            //                "author": "Author",
            //                "content_source_url": "URL",
            //                "content": "Content",
            //                "digest": "Digest description",
            //                "show_cover_pic": "0"
            //            },
            //            {
            //                "title": "Title",
            //                "thumb_media_id": "id",
            //                "author": "Author",
            //                "content_source_url": "URL",
            //                "content": "Content",
            //                "digest": "Digest description",
            //                "show_cover_pic": "0"
            //            }
            //        ]
            //    },
            //    "safe":0
            //}

            #endregion

            //1.上传图片
            ICropMaterial icm = new CropMaterial();
            string media_id = "";
            CommonResult result = null;
            try
            {
                result = icm.Add("image", mpPic, ref media_id);
            }
            catch (Exception ex)
            {

            }

            //2.图文素材清单
            List<MpNewsArticle> lst = new List<MpNewsArticle>()
            {
                new MpNewsArticle{title = mpTitle,thumb_media_id=media_id,author=mpAuthor,content_source_url="",content=mpContent,digest=mpDigest,show_cover_pic="1"}
            };
            CorpMpnewsMessage ctx = new CorpMpnewsMessage
            {
                touser = WechatCommonPara.ToUser,
                toparty = "",
                totag = "",
                mpnews = new MpNews { articles = lst },
                safe = 0
            };
            ICropMessage cm = new CropMessage();
            result = cm.SendMessage(ctx);
        }

        public static void sendNews(string newsPic, string newsTitle, string newsDigest, string newsUrl)
        {
            List<NewsArticle> news = new List<NewsArticle>()
            {
                 new NewsArticle { title=newsTitle , description=newsDigest, picurl=newsPic, url=newsUrl}
             };

            CorpNewsMessage ctx = new CorpNewsMessage
            {
                touser = WechatCommonPara.ToUser,
                toparty = "",
                totag = "",
                news = new News { articles = news },
                safe = 0
            };
            ICropMessage cm = new CropMessage();
            CommonResult result = cm.SendMessage(ctx);
        }
    }
}

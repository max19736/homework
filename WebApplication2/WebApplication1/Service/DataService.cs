using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Service
{
    public class DataService
    {
        public List<Models.Album> LoadAllAlbum()
        {
            List<Models.Album> list = new List<Models.Album>();


            var item = new Models.Album();

            item.number = "1103105306";
            item.name = "劉郁心";
            item.ImageUrl= @"/Content/image/dan.jpg";
            item.link = "http://konichiwa0907.pixnet.net/blog/post/345085706-%E3%80%90%E6%96%B0%E9%96%8B%E5%BC%B5%E6%BC%A2%E5%A0%A1%E5%BA%97%E3%80%91%E6%A1%83%E5%9C%92%EF%BC%8Cjoy's-burger%E5%96%AC%E4%BC%8A%E6%BC%A2%E5%A0%A1";


            list.Add(item);

            var item2 = new Models.Album();

            item2.number = "1103105322";
            item2.name = "陳怡君";
            item2.ImageUrl = @"/Content/image/chen.jpg";
            item2.link = "https://zh.wikipedia.org/wiki/%E5%A4%A7%E8%8B%B1%E9%9B%84%E5%A4%A9%E5%9C%98";
            list.Add(item2);

            var item3 = new Models.Album();

            item3.number = "1103105327";
            item3.name = "李偲瑋";
            item3.ImageUrl = @"/Content/image/thisway.jpg";
            item3.link = "http://www.hellokittygoaround.com.tw/";
            list.Add(item3);

            var item4 = new Models.Album();

            item4.number = "1103105344";
            item4.name = "林佑宗";
            item4.ImageUrl = @"/Content/image/yo.jpg";
            item4.link = "https://zh.wikipedia.org/wiki/%E8%B7%86%E6%8B%B3%E9%81%93";
            list.Add(item4);

            return list;
        }

    }
}
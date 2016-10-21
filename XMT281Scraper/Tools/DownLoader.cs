using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace XMT281Scraper.Tools
{
    public static class DownLoader
    {
        /// <summary>
        /// 读取数据获得文档，网络错误返回null
        /// </summary>
        /// <param name="url">网址</param>
        /// <param name="code">编码格式</param>
        /// <returns></returns>
        public static HtmlAgilityPack.HtmlDocument GetDocument(string url, Encoding code)
        {
            using (System.Net.WebClient webClient = new System.Net.WebClient())
            {
                try
                {

                    var data = webClient.DownloadData(url);
                    var html = code.GetString(data);
                    var doc = new HtmlAgilityPack.HtmlDocument();
                    doc.LoadHtml(html);
                    return doc;
                }
                catch (Exception err)
                {
                    return null;
                }
            }
        }
        public static HtmlAgilityPack.HtmlDocument GetDocument(string url)
        {
            return GetDocument(url, Encoding.UTF8);
        }

    }
}

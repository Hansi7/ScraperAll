using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public static HtmlAgilityPack.HtmlDocument GetDocumentPhantomJS(string url)
        {
            Process p = new Process();
            //启用命令行
            p.StartInfo.FileName = @"cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = false;
            p.Start();
            //输入各种命令
            //p.StandardInput.WriteLine(@"cd " + AppDomain.CurrentDomain.BaseDirectory);
            //p.StandardInput.WriteLine(@"d:");
            p.StandardInput.WriteLine("phantomjs --output-encoding=gb2312 test.js " + url);
            p.StandardInput.Close();
            p.StandardInput.Dispose();
            //获取结果
            string strRst = p.StandardOutput.ReadToEnd();
            p.Close();
            p.Dispose();
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(strRst);
            return doc;
        }
        public static HtmlAgilityPack.HtmlDocument GetDocumentPhantomJS2(string url)
        {
            Process p = new Process();
            //启用命令行
            p.StartInfo.FileName = @"phantomjs.exe";
            p.StartInfo.Arguments = "--output-encoding=gb2312 test.js " + url;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            string strRst = p.StandardOutput.ReadToEnd();
            p.StandardInput.WriteLine();
            p.StandardInput.Close();
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(strRst);
            return doc;
        }

    }
}

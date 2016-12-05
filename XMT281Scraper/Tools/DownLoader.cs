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
        /// <summary>
        /// second 只能是1，或者2，或者15
        /// </summary>
        /// <param name="url"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static HtmlAgilityPack.HtmlDocument GetDocumentPhantomJS15(string url)
        {
            var second = 15;
            Process p = new Process();
            //启用命令行
            p.StartInfo.FileName = @"phantomjs.exe";
            if (second ==1)
            {
                p.StartInfo.Arguments = "--output-encoding=gb2312 wait1s.js " + url;
            }
            if (second ==2)
            {
                p.StartInfo.Arguments = "--output-encoding=gb2312 wait2s.js " + url;
            }
            if (second ==15)
            {
                p.StartInfo.Arguments = "--output-encoding=gb2312 wait15s.js " + url;
            }

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
        public static HtmlAgilityPack.HtmlDocument GetDocumentPhantomJS1(string url)
        {
            var second = 1;
            Process p = new Process();
            //启用命令行
            p.StartInfo.FileName = @"phantomjs.exe";
            if (second == 1)
            {
                p.StartInfo.Arguments = "--output-encoding=gb2312 wait1s.js " + url;
            }
            if (second == 2)
            {
                p.StartInfo.Arguments = "--output-encoding=gb2312 wait2s.js " + url;
            }
            if (second == 15)
            {
                p.StartInfo.Arguments = "--output-encoding=gb2312 wait15s.js " + url;
            }

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
        public static HtmlAgilityPack.HtmlDocument GetDocumentPhantomJS2(string url)
        {
            var second = 2;
            Process p = new Process();
            //启用命令行
            p.StartInfo.FileName = @"phantomjs.exe";
            if (second == 1)
            {
                p.StartInfo.Arguments = "--output-encoding=gb2312 wait1s.js " + url;
            }
            if (second == 2)
            {
                p.StartInfo.Arguments = "--output-encoding=gb2312 wait2s.js " + url;
            }
            if (second == 15)
            {
                p.StartInfo.Arguments = "--output-encoding=gb2312 wait15s.js " + url;
            }

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

/**
 * 
 * 作者：281台申健
 * 作用：爬去数据的工作程序
 * 程序集：281XMTScrapy
 * 日期：2016年11月16日
 * 
 */

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMT281Scraper
{
    class Program
    {
        static void Main(string[] args)
        {
            XMT281Scraper.Tools.ScraperWorker.DoWork(args);
        }
    }
}

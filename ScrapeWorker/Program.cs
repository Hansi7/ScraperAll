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
            if (args.Length==0)
            {
                Console.WriteLine("需要接一个任务文件");
                return;
            }

            var fn = XMT281Scraper.Tools.ScraperWorker.workWithTaskFileJSON(args[0].ToString());
            Console.WriteLine(fn);
            Console.WriteLine("完成！");
            Console.ReadKey();
        }
    }
}

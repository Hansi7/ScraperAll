using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMT281Scraper.Entities
{
    public class ScraperTask
    {
        public ScraperTask(string taskName)
        {
            Name = taskName;
            StarStart = 0;
            StarEnd = 0;
            Current = 0;
            StarLong = 1;
        }
        public string Name { get; set; }
        public int Current {
            get { return Current; }
            set
            {
                if (value>=StarStart && value<= StarEnd)
                {
                    Current = value;
                }
                else
                {
                    throw new ArgumentException("无法赋值到Current，Current应该在规定范围内,请先行更改Start和End的值");
                }
            } }
        public string StartURL { get; set; }
        public int StarStart { get; set; }
        public int StarEnd { get; set; }
        /// <summary>
        /// 通配符长度，一般为1~3，默认为1
        /// </summary>
        public int StarLong { get; set; }
        public int StarGap { get; set; }
        public string CurrentURL
        {
            get
            {
                var st = StartURL.IndexOf("(*)");
                if (st == -1)
                {
                    return "未能生成URLs,未找到通配符(*)";
                }
                else
                {
                    switch (StarLong)
                    {
                        case 1:
                            return StartURL.Replace("(*)", (Current * StarGap).ToString("0"));
                        case 2:
                            return StartURL.Replace("(*)", (Current * StarGap).ToString("00"));
                        case 3:
                            return StartURL.Replace("(*)", (Current * StarGap).ToString("000"));
                        default:
                            return StartURL.Replace("(*)", (Current * StarGap).ToString("0"));
                    }
                }
            }
        }
        public Processor Processor { get; set; }
    }
}

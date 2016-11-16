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
        public int Current {get;set;}
        public string StartURL { get; set; }
        public int StarStart { get; set; }
        public int StarEnd { get; set; }
        /// <summary>
        /// 通配符长度，一般为1~3，默认为1
        /// </summary>
        public int StarLong { get; set; }
        /// <summary>
        /// 网址的增长值，如果希望通配符的位置是10,20,30，那么Gap为10
        /// </summary>
        public int StarGap { get; set; }
        public string CurrentURL
        {
            get
            {
                var st = StartURL.IndexOf("(*)");
                if (st == -1)
                {
                    return StartURL;
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
        public List<Processor> Processor { get; set; }
    }
}

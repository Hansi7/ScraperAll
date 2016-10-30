using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMT281Scraper.Extensions
{
    public static class ListExtension
    {
        public static string ToStringList(this List<string> list)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in list)
            {
                sb.AppendLine(item);
            }
            return sb.ToString();
        }
        public static string ToStringList(this List<string> list, string seperate ,bool displayCount)
        {
            StringBuilder sb = new StringBuilder();
            if (displayCount)
            {
                sb.AppendLine("共计：" + list.Count.ToString() + "节点");
            }
            foreach (var item in list)
            {
                sb.AppendLine(item);
                sb.AppendLine(seperate);
            }
            return sb.ToString();
        }
    }
}

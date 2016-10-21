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
    }
}

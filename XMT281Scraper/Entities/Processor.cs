using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMT281Scraper.Entities
{
    public class Processor
    {
        public Processor()
        {
            this.Replacer = new Dictionary<string, string>();
            this.Remover = new List<string>();
        }
        public string Name { get; set; }
        public string StartURL { get; set; }
        public string XPath { get; set; }
        public string CssSelector { get; set; }
        public EnumNodeOffset NodeOffset { get; set; }
        public string NodeAttribute { get; set; }
        public List<string> Remover { get; set; }
        public Dictionary<string,string> Replacer { get;set;}
        public string RemoveBefore { get; set; }
        public string RemoveAfter { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("定位  Xpath:" + XPath);
            sb.AppendLine("定位CssPath:" + CssSelector);
            sb.AppendLine("节点偏移   :" + NodeOffset.ToString());
            sb.AppendLine("选择属性   :" + NodeAttribute);
            //=====================================================
            sb.Append("删除   字符:");
            foreach (var item in Remover)
            {
                sb.Append(item + ",");
            }
            sb.AppendLine();
            //=====================================================
            sb.AppendLine("删除...之前:" + RemoveBefore);
            sb.AppendLine("删除...之后:" + RemoveAfter);
            sb.Append("要替换 字符:");
            foreach (var item in Replacer)
            {
                sb.Append(item.Key + " 替换为 " + item.Value + ",");
            }
            sb.AppendLine();
            //=====================================================
            return sb.ToString();
        }
    }
    public enum EnumNodeOffset
    {
        NoOffset =0,
        SinblingLeft = 1,
        SinblingRight =2,
        Parent =3,
        Child =4
    }

}

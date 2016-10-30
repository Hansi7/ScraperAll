/**
 * 作者：Hansi7
 * 备注：只有当结果是URL的时候才可以有SubProcessor，否则不支持
 * 
 * 
 * 
 * */


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
             this.NodeOffset = new List<EnumNodeOffset>();
             this.Remover = new List<string>();
             this.Replacer = new Dictionary<string, string>();
         }
        public string XPath { get; set; }
        public string CssSelector { get; set; }
        public List<EnumNodeOffset> NodeOffset { get; set; }
        public string NodeAttribute { get; set; }
        public List<string> Remover { get; set; }
        public Dictionary<string, string> Replacer { get; set; }
        public string RemoveBefore { get; set; }
        public string RemoveAfter { get; set; }
        public Processor SubProcessor { get; set; }
        public ScraperTask Task { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("定位  Xpath:" + XPath);
            sb.AppendLine("定位CssPath:" + CssSelector);
            sb.AppendLine("节点 偏移   :" + nodesToString());
            sb.AppendLine("选择 属性   :" + NodeAttribute);
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
        string nodesToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in NodeOffset)
            {
                sb.Append(Entities.Enum.NodeOffsetChinese(item) + (int)item + " ");
            }
            return sb.ToString();
        }
    }
}

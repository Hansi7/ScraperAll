using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScrapySharp.Extensions;
using System.Data;

namespace XMT281Scraper.Tools
{
    public static class Scraper
    {
        /// <summary>
        /// 主要提取函数，从网页文档中提取所需要的信息
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="psr"></param>
        /// <param name="usingCss"></param>
        /// <returns></returns>
        public static List<string> Scrape(HtmlAgilityPack.HtmlDocument doc, Entities.Processor psr, bool usingCss = false)
        {
            List<string> list = new List<string>();
            IEnumerable<HtmlAgilityPack.HtmlNode> nodes = null;

            if (string.IsNullOrEmpty(psr.XPath))
            {
                usingCss = true;
            }

            if (usingCss)
            {
                nodes = doc.DocumentNode.CssSelect(psr.CssSelector);
            }
            else
            {
                nodes = doc.DocumentNode.SelectNodes(psr.XPath);
            }

            if (nodes != null && nodes.Count() > 0)
            {
                foreach (var item in nodes)
                {
                    HtmlAgilityPack.HtmlNode node2 = item;
                    string data;//第二阶段的值
                    try
                    {
                        foreach (Entities.EnumNodeOffset itemOffset in psr.NodeOffset)
                        {
                            switch (itemOffset)
                            {
                                case XMT281Scraper.Entities.EnumNodeOffset.NoOffset:
                                    //node2 = node2;
                                    break;
                                case XMT281Scraper.Entities.EnumNodeOffset.SinblingLeft:
                                    node2 = node2.PreviousSibling;
                                    break;
                                case XMT281Scraper.Entities.EnumNodeOffset.SinblingRight:
                                    node2 = node2.NextSibling;
                                    break;
                                case XMT281Scraper.Entities.EnumNodeOffset.Parent:
                                    node2 = node2.ParentNode;
                                    break;
                                case XMT281Scraper.Entities.EnumNodeOffset.Child:
                                    node2 = node2.FirstChild;
                                    //FirstChild.NextSibling
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    catch(NullReferenceException)
                    {
                        data = "Node偏移到空位";
                    }

                    //==============接下来对node2进行处理=============
                    
                    if (psr.NodeAttribute == "" || psr.NodeAttribute == "OuterHtml")
                    {
                        if (node2 == null)
                        {
                            data = "Node偏移到空位";
                        }
                        else
                        {
                            data = node2.OuterHtml.Trim();
                        }
                    }
                    else if (psr.NodeAttribute == "InnerText")
                    {
                        if (node2 == null)
                        {
                            data = "Node偏移到空位";
                        }
                        else
                        {
                            data = node2.InnerText.Trim();
                        }
                    }
                    else
                    {
                        if (node2 == null)
                        {
                            data = "Node偏移到空位";
                        }
                        else
                        {
                            try 
	                        {	        
	                        	data = node2.Attributes[psr.NodeAttribute].Value.Trim();
	                        }
	                        catch (Exception)
	                        {
	                    	    data = "【NoAttrib没有这个属性，用OuterHtml占位】" + node2.OuterHtml;
	                        }
                            
                        }

                    }
                    //=============接下来对data进行 删除 处理===============
                    foreach (var rm in psr.Remover)
                    {
                        data = data.Replace(rm, "");
                    }
                    //=============接下来对data进行 替换 处理===============
                    foreach (var rp in psr.Replacer)
                    {
                        data = data.Replace(rp.Key, rp.Value);
                    }

                    if (!string.IsNullOrEmpty(psr.RemoveBefore))
                    {
                        int k = data.IndexOf(psr.RemoveBefore);
                        data = data.Substring(k + 1);
                    }

                    if (!string.IsNullOrEmpty(psr.RemoveAfter))
                    {
                        int j = data.LastIndexOf(psr.RemoveAfter);
                        if (j != -1)
                        {
                            data = data.Substring(0, j);
                        }
                    }

                    list.Add(data.Trim());
                }
            }
            else
            {
                list.Add("未识别");
            }

            return list;
        }
    }
}

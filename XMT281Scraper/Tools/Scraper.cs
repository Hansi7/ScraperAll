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
        /// <summary>
        /// 这个方法没写完，有点问题。
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="psrs"></param>
        /// <param name="usingCss"></param>
        /// <returns></returns>
        //public static DataTable Scrape(HtmlAgilityPack.HtmlDocument doc, List<Entities.Processor> psrs, bool usingCss = false)
        //{
        //DataTable dt = new DataTable("新媒体281台爬虫结果");

        //for (int i = 0; i < psrs.Count; i++)
        //{
        //    dt.Columns.Add(psrs[i].Name);//这个string看看有没有用
        //}

        //for (int i = 0; i < psrs.Count; i++)
        //{
        //    var psr = psrs[i];


        //    IEnumerable<HtmlAgilityPack.HtmlNode> nodes = null;

        //    if (string.IsNullOrEmpty(psr.XPath))
        //    {
        //        usingCss = true;
        //    }
        //    if (usingCss)
        //    {
        //        nodes = doc.DocumentNode.CssSelect(psr.CssSelector);
        //    }
        //    else
        //    {
        //        nodes = doc.DocumentNode.SelectNodes(psr.XPath);
        //    }

        //    if (nodes != null && nodes.Count() > 0)
        //    {
        //        List<string> list = new List<string>();
        //        foreach (var item in nodes)
        //        {
        //            HtmlAgilityPack.HtmlNode node2 = item;

        //            switch (psr.NodeOffset)
        //            {
        //                case XMT281Scraper.Entities.EnumNodeOffset.NoOffset:
        //                    node2 = item;
        //                    break;
        //                case XMT281Scraper.Entities.EnumNodeOffset.SinblingLeft:
        //                    node2 = item.PreviousSibling;
        //                    break;
        //                case XMT281Scraper.Entities.EnumNodeOffset.SinblingRight:
        //                    node2 = item.NextSibling;
        //                    break;
        //                case XMT281Scraper.Entities.EnumNodeOffset.Parent:
        //                    node2 = item.ParentNode;
        //                    break;
        //                case XMT281Scraper.Entities.EnumNodeOffset.Child:
        //                    node2 = item.FirstChild;
        //                    break;
        //                default:
        //                    break;
        //            }
        //            //==============接下来对node2进行处理=============
        //            string data;
        //            if (psr.NodeAttribute == "" || psr.NodeAttribute == "OuterHtml")
        //            {
        //                data = node2.OuterHtml.Trim();
        //            }
        //            else if (psr.NodeAttribute == "InnerText")
        //            {
        //                data = node2.InnerText.Trim();
        //            }
        //            else
        //            {
        //                if (node2.GetAttributeValue(psr.NodeAttribute, false))
        //                {
        //                    throw new Exception("没有这个属性！请更换属性！");
        //                }
        //                data = node2.Attributes[psr.NodeAttribute].Value.Trim();
        //            }
        //            //=============接下来对data进行 删除 处理===============
        //            foreach (var rm in psr.Remover)
        //            {
        //                data = data.Replace(rm, "");
        //            }
        //            //=============接下来对data进行 替换 处理===============
        //            foreach (var rp in psr.Replacer)
        //            {
        //                data = data.Replace(rp.Key, rp.Value);
        //            }

        //            if (!string.IsNullOrEmpty(psr.RemoveBefore))
        //            {
        //                int k = data.IndexOf(psr.RemoveBefore);
        //                data = data.Substring(k + 1);
        //            }

        //            if (!string.IsNullOrEmpty(psr.RemoveAfter))
        //            {
        //                int j = data.LastIndexOf(psr.RemoveAfter);
        //                if (j != -1)
        //                {
        //                    data = data.Substring(0, j);
        //                }
        //            }

        //            list.Add(data.Trim());
        //        }
        //    }
        //    else
        //    {
        //        list.Add("未识别");
        //    }
        //    dt.Rows.Add(list.ToArray());
        //}
        //return dt;
        //}


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMT281Scraper.Interface
{
    interface IBrowser
    {
        HtmlAgilityPack.HtmlDocument GetDocument(string uri);
    }
}

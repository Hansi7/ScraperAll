using HtmlAgilityPack;
using ScrapySharp.Network;
using ScrapySharp.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScrapySharp.Html.Forms;
using System.Threading;
using Newtonsoft.Json;
using System.IO;

namespace XMT281Scraper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ListPsrs = new List<Entities.Processor>();
        }
        public List<Entities.Processor> ListPsrs { get; set; }
        
        private void btnStart_Click(object sender, EventArgs e)
        {
            webbrowser.Navigate(txt_WebbrowserURL.Text.Trim());
        }


        private void button2_Click(object sender, EventArgs e)
        {
            var dlg = new FrmTASKBuilder();

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Clipboard.SetText(dlg.URLs);
            }
        }

        public HtmlAgilityPack.HtmlDocument getDocumentFromIE()
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            var nodes = this.webbrowser.Document.All;
            foreach (HtmlElement item in nodes)
            {
                if (string.IsNullOrEmpty(item.OuterHtml) || item.OuterHtml.Length < 500)
                {
                    continue;
                }//取第一个非空的NODE
                doc.LoadHtml(item.OuterHtml);
                return doc; 
            }
            return doc;
        }

        List<List<string>> llist;
        private void btnTEST_Click(object sender, EventArgs e)
        {
            if (ctrlPsrList1.Processors.Count == 0)
            {
                MessageBox.Show("还没有提取器，无法提取。请新建提取器");
                return;
            }
            StringBuilder sbb = new StringBuilder();
            llist = new List<List<string>>();
            var doc = Tools.DownLoader.GetDocument(this.txt_WebbrowserURL.Text);
            foreach (var itempsr in ctrlPsrList1.Processors)
            {
                try
                {
                    var l1 = Tools.Scraper.Scrape(doc, itempsr);
                    llist.Add(l1);
                }
                catch (Exception)
                {

                }
            }
            sbb.Append(outputList(false, llist.ToArray()));
            var fn = "RESULT " + DateTime.Now.ToString("yyyy-MM-dd-HHmmss") + ".txt";
            System.IO.File.WriteAllText(fn, sbb.ToString());
            System.Diagnostics.Process.Start(fn);

            //StringBuilder sbb = new StringBuilder();
            //var urls = new List<string>();
            //int total = urls.Count;

            //foreach (var item in urls)
            //{
            //    llist = new List<List<string>>();
            //    var doc = Tools.DownLoader.GetDocument(item);
            //    foreach (var itempsr in ListPsrs)
            //    {
            //        try
            //        {
            //            var l1 = Tools.Scraper.Scrape(doc, itempsr);
            //            llist.Add(l1);
            //        }
            //        catch (Exception)
            //        {
            //        }
            //    }
            //    sbb.Append(outputList(false, llist.ToArray()));
            //}
            //var fn = "RESULT " + DateTime.Now.ToString("yyyy-MM-dd-HHmmss") + ".txt";
            //System.IO.File.WriteAllText(fn, sbb.ToString());
            //System.Diagnostics.Process.Start(fn);
        }



        string outputList(bool save, params List<string>[] list)
        {
            if (list.Length == 0)
            {
                //MessageBox.Show("没有加载psr无法处理!");
                return "";
            }

            int count = list[0].Count;
            for (int i = 0; i < list.Length; i++)
            {
                if (count != list[i].Count)
                {
                    return "Error 每个列表数量不一样!";
                }
            }
            List<string> combin = new List<string>();
            for (int j = 0; j < count; j++)
            {
                for (int i = 0; i < list.Length; i++)
                {
                    if (i == list.Length - 1)
                    {
                        combin.Add(list[i][j] + "\r\n");
                    }
                    else
                    {
                        combin.Add(list[i][j] + "\t");
                    }

                }
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < combin.Count; i++)
            {
                sb.Append(combin[i]);
            }

            if (save)
            {
                var fn = System.DateTime.Now.ToString("yyyy-MM-dd-HHmmss") + ".txt";
                System.IO.File.WriteAllText(fn, sb.ToString());
                System.Diagnostics.Process.Start(fn);
            }

            return sb.ToString();

        }




        StringBuilder sbWebOutput = new StringBuilder();
       
        void Open()
        {
            var fn = "RESULT " + DateTime.Now.ToString("yyyy-MM-dd-HHmmss") + ".txt";
            System.IO.File.WriteAllText(fn, sbWebOutput.ToString());
            System.Diagnostics.Process.Start(fn);
        }

        private void webbrowser_NewWindow(object sender, CancelEventArgs e)
        {
            this.webbrowser.Url = new Uri(((WebBrowser)sender).StatusText);
            e.Cancel = true;
            
        }

        private void webbrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            txt_WebbrowserURL.Text = this.webbrowser.Url.ToString();
        }

        private void btn_ScrapyNoLoading_Click(object sender, EventArgs e)
        {
            //txt_info.AppendText("webbrowser_DocumentCompleted\t" + e.Url + "\r\n");
            if (ctrlPsrList1.Processors.Count == 0)
            {
                MessageBox.Show("还没有提取器，无法提取。请新建提取器");
                return;
            }
            StringBuilder sbb = new StringBuilder();
            llist = new List<List<string>>();
            var doc = getDocumentFromIE();
            foreach (var itempsr in ctrlPsrList1.Processors)
            {
                try
                {
                    var l1 = Tools.Scraper.Scrape(doc, itempsr);
                    llist.Add(l1);
                }
                catch (Exception)
                {

                }
            }
            sbb.Append(outputList(false, llist.ToArray()));
            var fn = "RESULT " + DateTime.Now.ToString("yyyy-MM-dd-HHmmss") + ".txt";
            System.IO.File.WriteAllText(fn, sbb.ToString());
            System.Diagnostics.Process.Start(fn);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var fn = "SOURCE " + DateTime.Now.ToString("yyyy-MM-dd-HHmmss") + ".txt";
                System.IO.File.WriteAllText(fn, getDocumentFromIE().DocumentNode.OuterHtml);
                System.Diagnostics.Process.Start(fn);
            }
            catch (Exception err )
            {
                MessageBox.Show(err.Message);
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            webbrowser.Visible = true;
            webbrowser.Size = new Size(webbrowser.Size.Width, this.Size.Height - 200);
        }

        private void txt_WebbrowserURL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                btnStart_Click(null, null);//执行转到按钮
                btnStart.Focus(); //丢失焦点//
            }
        }




    }
}

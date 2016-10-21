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
            webbrowser.Navigate(txt_URLS.Text);
        }

        private List<string> urlsList()
        {
            var strArr = txt_URLS.Text.Split(new string[] { "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            return strArr.ToList<String>();
        }
        bool loading = false;
        

        private void button2_Click(object sender, EventArgs e)
        {
            var dlg = new FrmURLBuilder();
            if (urlsList().Count>0)
            {
                dlg.URLs = urlsList()[0];
            }

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Clipboard.SetText(dlg.URLs);
                txt_URLS.Text = dlg.URLs;
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
            //var urls = urlsList();
            //int total = urls.Count;
            //int j = 0;

            //foreach (var item in urls)
            //{
            //    var doc = Tools.DownLoader.GetDocument(item);
            //    var kkl = Tools.Scraper.Scrape(doc, ListPsrs);
            //    if (kkl is DataTable)
            //    {
            //        Tools.ExcelOutput.DataTableToExcel(kkl, "hello.xlsx");
            //        MessageBox.Show("Test");
            //    }

            //}
            //return;


            StringBuilder sbb = new StringBuilder();
            var urls = urlsList();
            int total = urls.Count;
            int j = 0;
            foreach (var item in urls)
            {
                llist = new List<List<string>>();
                var doc = Tools.DownLoader.GetDocument(item);
                foreach (var itempsr in ListPsrs)
                {
                    try
                    {
                        var l1 = Tools.Scraper.Scrape(doc, itempsr);
                        llist.Add(l1);
                    }
                    catch (Exception)
                    {
                        txt_info.AppendText("网址" + item + "无法定位，继续下一个\r\n");
                    }
                }
                lb_prograss.Text = (++j).ToString() + "/" + total.ToString();
                sbb.Append(outputList(false, llist.ToArray()));
            }
            var fn = "RESULT " + DateTime.Now.ToString("yyyy-MM-dd-HHmmss") + ".txt";
            System.IO.File.WriteAllText(fn, sbb.ToString());
            System.Diagnostics.Process.Start(fn);
        }

        private void btn_pasteNavi_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Clipboard.GetText(TextDataFormat.Text)))
            {
                txt_URLS.Text = Clipboard.GetText(TextDataFormat.Text);
            }
            
        }

        private void btn_PSR_GEN_Click(object sender, EventArgs e)
        {
            var bu = new FrmPSRBuilder();
            bu.Owner = this;
            if (bu.ShowDialog() ==  System.Windows.Forms.DialogResult.OK)
            {
                this.ListPsrs.Add(bu.Processor);
                refreshToUI();
            }
        }

        private void btn_ADD_PSR_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "(*.psr)psr文件|*.psr";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (var item in ofd.FileNames)
                {
                    var psr = Tools.Serializer.DeSerialize(item);
                    this.ListPsrs.Add(psr);
                    txt_URLS.AppendText("\r\n" + psr.StartURL);
                }
            }
            refreshToUI();

        }

        private void refreshToUI()
        {
            lb_Psr.Items.Clear();
            lb_Psr.DisplayMember = "Name";
            foreach (var item in this.ListPsrs)
            {
                lb_Psr.Items.Add(item);
            }
        }

        private void btn_Remove_PSR_Click(object sender, EventArgs e)
        {
            if (lb_Psr.SelectedItems.Count == 1)
            {
               ListPsrs.Remove(lb_Psr.SelectedItem as Entities.Processor);
            }
            refreshToUI();
            
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

        private void lb_Psr_DoubleClick(object sender, EventArgs e)
        {
            var psr = lb_Psr.SelectedItem as Entities.Processor;
            if (psr != null)
            {
                var frm = new FrmPSRBuilder();
                frm.Owner = this;
                frm.Processor = psr;
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    lb_Psr.Items.Remove(psr);
                    lb_Psr.Items.Add(frm.Processor);
                    refreshToUI();
                }

            }
        }

        private void txt_URLS_TextChanged(object sender, EventArgs e)
        {
            lb_prograss.Text = "0/" + urlsList().Count.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sbWebOutput = new StringBuilder();
            this.webbrowser.DocumentCompleted += webbrowser_DocumentCompleted;
            var urls = urlsList();
            foreach (var item in urls)
            {
                loading = true;
                this.webbrowser.Navigate(item);
                while (loading)
                {
                    Application.DoEvents();
                }
                Thread.Sleep(3000);
            }
        }
        StringBuilder sbWebOutput = new StringBuilder();
        void webbrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url.ToString() == "about:blank" || !urlsList().Contains(e.Url.ToString()))
            { return; }
            else
            {
                for (int i = 0; i < 10000; i++)
                {
                    Application.DoEvents();
                }

                txt_info.AppendText("webbrowser_DocumentCompleted\t" + e.Url + "\r\n");
                loading = false;
                var urls = urlsList();
                int total = urls.Count;
                int j = 0;

                llist = new List<List<string>>();
                var doc = getDocumentFromIE();
                foreach (var itempsr in ListPsrs)
                {
                    try
                    {
                        var l1 = Tools.Scraper.Scrape(doc, itempsr);
                        llist.Add(l1);
                    }
                    catch (Exception)
                    {
                        txt_info.AppendText("网址" + webbrowser.Url + "无法定位，继续下一个\r\n");
                    }
                }
                lb_prograss.Text = (++j).ToString() + "/" + total.ToString();
                sbWebOutput.Append(outputList(false, llist.ToArray()));
            }
        }
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
            loading = false;
            StringBuilder sbb = new StringBuilder();
            var urls = urlsList();
            int total = urls.Count;
            int j = 0;

            llist = new List<List<string>>();
            var doc = getDocumentFromIE();
            foreach (var itempsr in ListPsrs)
            {
                try
                {
                    var l1 = Tools.Scraper.Scrape(doc, itempsr);
                    llist.Add(l1);
                }
                catch (Exception)
                {
                    txt_info.AppendText("网址" + webbrowser.Url + "无法定位，继续下一个\r\n");
                }
            }
            lb_prograss.Text = (++j).ToString() + "/" + total.ToString();
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
            webbrowser.Size = new Size(webbrowser.Size.Width, this.Size.Height - 200);
        }



    }
}

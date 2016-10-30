using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMT281Scraper
{
    public partial class FrmTASKBuilder : Form
    {
        public FrmTASKBuilder()
        {
            InitializeComponent();
        }
        public string URLs { get; set; }
        public HtmlAgilityPack.HtmlDocument Document { get; set; }
        private string Gen()
        {
            int frm, too, plong,ch;
            ch = (int)nud_ch.Value;//增长间隔不能为0
            if (int.TryParse(txtFrom.Text, out frm) && frm < 9999 && int.TryParse(txtTo.Text, out too) && too < 9999&& int.TryParse(txtPlong.Text, out plong) && plong<=3 && plong>=1)
            {
                var st = txt_URL.Text.IndexOf("(*)");
                if (st == -1)
                {
                    return txt_URL.Text;
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = frm; i <=too; i= i + ch )
                    {
                        switch (plong)
                        {
                            case 1:
                                sb.AppendLine(txt_URL.Text.Replace("(*)", i.ToString("0")));
                                break;
                            case 2:
                                sb.AppendLine(txt_URL.Text.Replace("(*)", i.ToString("00")));
                                break;
                            case 3:
                                sb.AppendLine(txt_URL.Text.Replace("(*)", i.ToString("000")));
                                break;
                        }
                    }
                    return sb.ToString();
                }

            }
            else
            {
                return "未能生成URLs,请输入合适的数字";
            }
        }

        private void btn_GEN_Click(object sender, EventArgs e)
        {
            txt_Output.Text = Gen();
            URLs = txt_Output.Text.Trim();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btn_inserStar_Click(object sender, EventArgs e)
        {
            txt_URL.SelectedText = "(*)";
        }

        private void FrmURLBuilder_Load(object sender, EventArgs e)
        {
            txt_URL.Text = this.URLs;
        }

        private void btn_ReadHTML_Click(object sender, EventArgs e)
        {
            var urls = txt_URL.Text.Split(new string[] { "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            this.Document = Tools.DownLoader.GetDocument(urls[0]);
            this.Document.Save("LastLoad1.html");
            MessageBox.Show("1 LOADED!");
        }

        private void btn_ReadHTML2_Click(object sender, EventArgs e)
        {
            var urls = txt_Output.Text.Split(new string[] { "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            this.Document = Tools.DownLoader.GetDocumentPhantomJS2(urls[0]);
            this.Document.Save("LastLoad2.html");
            MessageBox.Show("2 LOADED!");
        }

        private void btn_NewPSR_Click(object sender, EventArgs e)
        {
            if (this.Document == null)
            {
                this.Document = Tools.DownLoader.GetDocument(txt_URL.Text);
            }
            var dlg = new FrmPSRBuilder(this.Document);
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //dlg.Processor;
            }
        }

        private void btn_DELPSR_Click(object sender, EventArgs e)
        {

        }


    }
}

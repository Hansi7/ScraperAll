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
            btn_GEN_Click(null, null);
            var urls = txt_Output.Text.Split(new string[] { "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            this.Document = Tools.DownLoader.GetDocument(urls[0]);
            this.Document.Save("LastLoad1.html");
            ctrlPsrList1.Document = this.Document;
            MessageBox.Show("使用模块读取网页完成！源代码文件保存为LastLoad1.html");
        }

        private void btn_ReadHTML2_Click(object sender, EventArgs e)
        {
            var urls = txt_Output.Text.Split(new string[] { "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            this.Document = Tools.DownLoader.GetDocumentPhantomJS2(urls[0]);
            this.Document.Save("LastLoad2.html");
            ctrlPsrList1.Document = this.Document;
            MessageBox.Show("使用浏览器读取网页完成！源代码文件保存为LastLoad2.html");
        }

        private void btn_SaveTask_Click(object sender, EventArgs e)
        {
            try
            {
                Entities.ScraperTask task = GenTask();
                Tools.Serializer.Serialize("text.txt", task);
                MessageBox.Show("已经保存");
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            
        }

        private Entities.ScraperTask GenTask()
        {
            Entities.ScraperTask task = new Entities.ScraperTask(txt_TaskName.Text.Trim());
            task.Current = (int)nud_Current.Value;
            task.StartURL = txt_URL.Text;
            task.StarStart = int.Parse(txtFrom.Text);
            task.StarEnd = int.Parse(txtTo.Text);
            task.StarGap = (int)(nud_ch.Value);
            task.StarLong = int.Parse(txtPlong.Text);
            task.Processor = this.ctrlPsrList1.Processors;
            return task;
        }

        private void ctrlPsrList1_Load(object sender, EventArgs e)
        {
            
        }






    }
}

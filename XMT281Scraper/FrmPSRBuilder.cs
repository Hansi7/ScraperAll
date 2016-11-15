using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XMT281Scraper.Extensions;

namespace XMT281Scraper
{
    public partial class FrmPSRBuilder : Form
    {
        public FrmPSRBuilder(HtmlAgilityPack.HtmlDocument document)
        {
            InitializeComponent();
            this.Document = document;
        }

        public Entities.ScraperTask ScrapyTask { get; set; }
        public Entities.Processor Processor { get; set; }

        public HtmlAgilityPack.HtmlDocument Document { get; set; }

        void tryBulidPSR()
        {
            if (this.Processor == null)
            {
                Processor = new Entities.Processor();
            }
            if (txt_XPATH.Text!=null)
            {
                Processor.XPath = txt_XPATH.Text;
            }
            if (txt_CSSSelector.Text!=null)
            {
                Processor.CssSelector = txt_CSSSelector.Text;
            }
            Processor.NodeAttribute = txt_ATTRIB.Text;
        }
        void showPSRView()
        {
            txt_PSRViewer.Text = this.Processor.ToString();
        }
        private void FrmPSRBuilder_Load(object sender, EventArgs e)
        {
            if (this.Processor !=null)
            {
                refreshToUI();
            }
            else
            {
                this.Processor = new Entities.Processor();
            }
        
        }

        void refreshToData()
        {

            try
            {
                tryBulidPSR();
                showPSRView();
                if (this.Document==null)
                {
                    throw new Exception("还没有加载文档，暂时无法提取");
                }
                var list = Tools.Scraper.Scrape(this.Document, this.Processor);
                txt_SourceCode.Text = list.ToStringList("========================", true);
                txt_Json.Text = Tools.Serializer.ShowJson(this.Processor);
            }
            catch (Exception err)
            {
                txt_SourceCode.Text = err.Message;
            }
        }

        void refreshToUI()
        {
            txt_XPATH.Text = this.Processor.XPath;
            txt_CSSSelector.Text = this.Processor.CssSelector;
            txt_ATTRIB.Text = this.Processor.NodeAttribute;
            foreach (var item in gb1.Controls)
            {
                RadioButton rb = item as RadioButton;
                if (rb !=null && this.Processor.NodeAttribute == rb.Text)
                {
                    rb.Checked = true;
                }
            }
            txt_Json.Text = Tools.Serializer.ShowJson(this.Processor);


        }
        private void btn_AddString_Click(object sender, EventArgs e)
        {
            if (rb_Remove.Checked)
            {
                this.Processor.Remover.Add(txt_Remove.Text);
            }

            if (rb_Replace.Checked)
            {
                try
                {
                    this.Processor.Replacer.Add(txt_Remove.Text, txt_Replace.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("已存在关于“"+txt_Remove.Text+"”的替换，无法添加");
                }
                
            }

            if (rb_REMOVE_before.Checked)
            {
                this.Processor.RemoveBefore = txt_Remove.Text;
            }

            if (rb_REMOVE_after.Checked)
            {
                this.Processor.RemoveAfter = txt_Remove.Text;
            }
            refreshToData();
        }

        private void btn_RESET_REMOVER_Click(object sender, EventArgs e)
        {
            this.Processor.Replacer = new Dictionary<string, string>();
            this.Processor.Remover = new List<string>();
            this.Processor.RemoveAfter = "";
            this.Processor.RemoveBefore = "";
            refreshToData();
        }

        private void rb_Defult_OFFSET_CheckedChanged(object sender, EventArgs e)
        {
            //refresh();
            //refreshToUI();
        }

        private void rb_Defult_OFFSET_Click(object sender, EventArgs e)
        {
            //foreach (var item in gb1.Controls)
            //{
            //    var k = item as RadioButton;
            //    if (k != null && k.Checked)
            //    {
            //        txt_ATTRIB.Text = k.Text;
            //    }
            //}
            refreshToData();
            refreshToUI();
        }

        private void btn_SavePsr_Click(object sender, EventArgs e)
        {
            try
            {
                Tools.Serializer.Serialize(txt_Filename.Text.Trim() + DateTime.Now.ToString("@yyyyMMddHHmmss") + ".psr", this.Processor);
                MessageBox.Show("成功");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void btn_LOAD_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(*.psr)psr文件|*.psr";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.Processor = Tools.Serializer.DeSerializePSR(ofd.FileName);
                refreshToUI();
                refreshToData();
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btn_TryPSR_Click(object sender, EventArgs e)
        {
            refreshToData();
            refreshToUI();
        }

        private void rb_none_ATT_Click(object sender, EventArgs e)
        {
            foreach (var item in gb1.Controls)
            {
                var k = item as RadioButton;
                if (k != null && k.Checked)
                {
                    txt_ATTRIB.Text = k.Text;
                }
            }
            refreshToData();
            refreshToUI();
        }

        private void btn_Space_Click(object sender, EventArgs e)
        {
            txt_Remove.Text = "\r";
            btn_AddString_Click(null, null);
            txt_Remove.Text = "\n";
            btn_AddString_Click(null, null);
            txt_Remove.Text = "\t";
            btn_AddString_Click(null, null);
            txt_Remove.Text = " ";
            btn_AddString_Click(null, null);
            txt_Remove.Text = "";
        }

        private void btn_LOADTEXT_Click(object sender, EventArgs e)
        {
            try
            {
                this.Processor = Tools.Serializer.DeSerializeFromJsonStringPSR(txt_Json.Text);
                refreshToUI();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }


        private void btn_ClearOffsetNode_Click(object sender, EventArgs e)
        {
            Processor.NodeOffset.Clear();
            refreshToData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.Document = new HtmlAgilityPack.HtmlDocument();
                this.Document.LoadHtml(System.IO.File.ReadAllText(dlg.FileName));
            }
            MessageBox.Show("ok!");
            refreshToData();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            //Processor.NodeOffset.Add(Entities.EnumNodeOffset.NoOffset);
            refreshToData();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Processor.NodeOffset.Add(Entities.EnumNodeOffset.SinblingLeft);
            refreshToData();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Processor.NodeOffset.Add(Entities.EnumNodeOffset.SinblingRight);
            refreshToData();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Processor.NodeOffset.Add(Entities.EnumNodeOffset.Parent);
            refreshToData();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Processor.NodeOffset.Add(Entities.EnumNodeOffset.Child);
            refreshToData();
        }

        private void btn_DelLast_Click(object sender, EventArgs e)
        {

            try
            {
                Processor.NodeOffset.RemoveAt(Processor.NodeOffset.Count - 1);
                refreshToData();
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }

        private void btn_Tryme_Click(object sender, EventArgs e)
        {
            List<object> list = new List<object>()
            {
                Entities.EnumNodeOffset.Child,
                Entities.EnumNodeOffset.SinblingRight
            };

            Tools.Arrangement<object> arrangment = new Tools.Arrangement<object>(list);
            

            for (int i = 2; i < 10; i++)
            {
                var lili = arrangment.QueueAll(i, null);
                if (lili.Count> 1000)
                {
                    MessageBox.Show("没有探测到，下一次探测要10秒以上，而且希望渺茫！");
                    return;
                }
                foreach (var item in lili)
                {
                    Processor.NodeOffset = new List<Entities.EnumNodeOffset>();
                    foreach (var item2 in item)
                    {
                        Processor.NodeOffset.Add((Entities.EnumNodeOffset)item2);
                    }
                    //测试是否正确，正确则跳出
                    try
                    {
                        var scrapResultList = Tools.Scraper.Scrape(this.Document, this.Processor);
                        if (scrapResultList.Count > 0 && scrapResultList[0] == txt_tryme.Text)
                        {
                            MessageBox.Show("OK TryME! YEAH!");
                            refreshToData();
                            refreshToUI();
                            return;
                        }
                    }
                    catch 
                    {

                    }


                }
            }
            //var lili = arrangment.QueueAll(5);
            
            //for (int i = 1; i < 10; i++)
            //{
            //    Tools.Arrangement.Queue<Entities.EnumNodeOffset>(list, i, new List<Entities.EnumNodeOffset>(), null);
            //}
           
        }

        private void rb_none_ATT_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_InnerText_ATT_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_title_ATT_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_href_ATT_CheckedChanged(object sender, EventArgs e)
        {

        }


    }
}

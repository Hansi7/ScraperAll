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
        public FrmPSRBuilder()
        {
            InitializeComponent();

        }

        public Entities.Processor Processor { get; set; }
        public HtmlAgilityPack.HtmlDocument Document { get; set; }

        private void btn_LoadHtml_Click(object sender, EventArgs e)
        {
            tryBulidPSR();
            this.Document = Tools.DownLoader.GetDocument(Processor.StartURL);
            MessageBox.Show("LOAD!");
            refresh();
        }
        void tryBulidPSR()
        {
            if (this.Processor == null)
            {
                Processor = new Entities.Processor();
            }
            if (!string.IsNullOrEmpty(txt_NAME.Text))
            {
                Processor.Name = this.txt_NAME.Text.Trim();
            }
            else
            {
                Processor.Name = DateTime.Now.ToString() + "PSR";
            }
            if (txt_XPATH.Text!=null)
            {
                Processor.XPath = txt_XPATH.Text;
            }
            if (!string.IsNullOrEmpty(txt_URL.Text))
            {
                Processor.StartURL = txt_URL.Text;
            }
            if (txt_CSSSelector.Text!=null)
            {
                Processor.CssSelector = txt_CSSSelector.Text;
            }
            //偏移
            if (rb_Defult_OFFSET.Checked)
            {
                Processor.NodeOffset = Entities.EnumNodeOffset.NoOffset;
            }
            if (rb_child_OFFSET.Checked)
            {
                Processor.NodeOffset = Entities.EnumNodeOffset.Child;
            }
            if (rb_parent_OFFSET.Checked)
            {
                Processor.NodeOffset = Entities.EnumNodeOffset.Parent;
            }
            if (rb_sibingLeft_OFFSET.Checked)
            {
                Processor.NodeOffset = Entities.EnumNodeOffset.SinblingLeft;
            }
            if (rb_sibingRight_OFFSET.Checked)
            {
                Processor.NodeOffset = Entities.EnumNodeOffset.SinblingRight;
            }
            //======================END 偏移

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
        
        }

        void refresh()
        {

            try
            {
                tryBulidPSR();
                showPSRView();
                var list = Tools.Scraper.Scrape(this.Document, this.Processor);
                txt_SourceCode.Text = list.ToStringList();
                txt_Json.Text = Tools.Serializer.ShowJson(this.Processor);
            }
            catch (Exception err)
            {
                txt_SourceCode.Text = err.Message;
            }
        }

        void refreshToUI()
        {
            txt_NAME.Text = this.Processor.Name;
            txt_URL.Text = this.Processor.StartURL;
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
            refresh();
        }

        private void btn_RESET_REMOVER_Click(object sender, EventArgs e)
        {
            this.Processor.Replacer = new Dictionary<string, string>();
            this.Processor.Remover = new List<string>();
            this.Processor.RemoveAfter = "";
            this.Processor.RemoveBefore = "";
            refresh();
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
            refresh();
            refreshToUI();
        }

        private void btn_SavePsr_Click(object sender, EventArgs e)
        {
            try
            {
                Tools.Serializer.Serialize(txt_NAME.Text.Trim() + DateTime.Now.ToString("@yyyyMMddHHmmss") + ".psr", this.Processor);
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
                this.Processor = Tools.Serializer.DeSerialize(ofd.FileName);
                refreshToUI();
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btn_TryPSR_Click(object sender, EventArgs e)
        {
            refresh();
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
            refresh();
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
                this.Processor = Tools.Serializer.DeSerializeFromJsonString(txt_Json.Text);
                refreshToUI();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btn_LoadHtml2_Click(object sender, EventArgs e)
        {

            this.Document =(this.Owner as Form1).getDocumentFromIE();
        }
    }
}

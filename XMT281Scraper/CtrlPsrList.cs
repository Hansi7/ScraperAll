using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMT281Scraper
{
    public partial class CtrlPsrList : UserControl
    {
        public CtrlPsrList()
        {
            InitializeComponent();
        }
        

        public List<Entities.Processor> Processors
        {
            get
            {
                List<Entities.Processor> processors = new List<Entities.Processor>();
                foreach (var item in lb_psrs.Items)
                {
                    processors.Add(item  as Entities.Processor);
                }
                return processors;
            }
            set
            {
                if (value!=null)
                {
                    this.lb_psrs.Items.Clear();
                    foreach (var item in value)
                    {
                        this.lb_psrs.Items.Add(item);
                    }
                }

            }
        }
        public HtmlAgilityPack.HtmlDocument Document { get; set; }
        private void btn_New_Click(object sender, EventArgs e)
        {
            FrmPSRBuilder dlg = new FrmPSRBuilder(this.Document);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.lb_psrs.Items.Add(dlg.Processor);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (lb_psrs.SelectedItems.Count == 1)
            {
                var selectedItemIndex = lb_psrs.SelectedIndex;
                FrmPSRBuilder dlg = new FrmPSRBuilder(this.Document);
                dlg.Processor = lb_psrs.SelectedItem as Entities.Processor;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    lb_psrs.Items.RemoveAt(lb_psrs.SelectedIndex);
                    lb_psrs.Items.Insert(selectedItemIndex, dlg.Processor);
                }
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (lb_psrs.SelectedItems.Count==1)
            {
                if (MessageBox.Show("删除当前选定的提取器吗？","询问",  MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    lb_psrs.Items.Remove(lb_psrs.SelectedItem);                    
                }
            }
        }
    }
}

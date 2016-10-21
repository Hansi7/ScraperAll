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
    public partial class FrmURLBuilder : Form
    {
        public FrmURLBuilder()
        {
            InitializeComponent();
        }
        public string URLs { get; set; }
        private string Gen()
        {
            int frm, too, plong,ch;
            ch = (int)nud_ch.Value;//增长间隔不能为0
            if (int.TryParse(txtFrom.Text, out frm) && frm < 9999 && int.TryParse(txtTo.Text, out too) && too < 9999&& int.TryParse(txtPlong.Text, out plong) && plong<=3 && plong>=1)
            {
                var st = txt_URL.Text.IndexOf("(*)");
                if (st == -1)
                {
                    return "未能生成URLs,未找到通配符(*)";
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


    }
}

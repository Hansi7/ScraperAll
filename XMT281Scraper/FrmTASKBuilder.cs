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
            this.Document = Tools.DownLoader.GetDocumentPhantomJS(urls[0]);
            this.Document.Save("LastLoad2.html");
            ctrlPsrList1.Document = this.Document;
            MessageBox.Show("使用浏览器读取网页完成！源代码文件保存为LastLoad2.html");
        }

        private void btn_SaveTask_Click(object sender, EventArgs e)
        {
            try
            {
                if (!System.IO.Directory.Exists(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Settings.TASK_SUBPATH)))
                {
                    System.IO.Directory.CreateDirectory(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Settings.TASK_SUBPATH));
                }

                Entities.ScraperTask task = GenTask();
                if (String.IsNullOrEmpty(txt_TaskName.Text))
                {

                    Tools.Serializer.Serialize(Settings.TASK_SUBPATH  + "\\TASK@" + DateTime.Now.ToString("yyyyMMdd HHmmss") + ".tsk", task);
                    MessageBox.Show("保存成功");
                }
                else
                {
                    char[] invalidChar = System.IO.Path.GetInvalidFileNameChars();
                    foreach (var item in invalidChar)
	                {
                        if (txt_TaskName.Text.Contains(item))
                        {
                            MessageBox.Show("任务名称存在不可以作为文件名的字符：" + item.ToString(),"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
	                }
                    Tools.Serializer.Serialize(Settings.TASK_SUBPATH  + "\\" + txt_TaskName.Text.Trim() + ".tsk",task);
                    MessageBox.Show("保存成功");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            
        }
        public Entities.ScraperTask Task { get; set; }
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
            this.Task = task;
            return task;
        }

        private void ctrlPsrList1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_ReadTask_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(*.tsk)tsk文件|*.tsk";
            ofd.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Settings.TASK_SUBPATH);
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var task = Tools.Serializer.DeSerializeTSK(ofd.FileName);
                this.Task = task;
                //UpdateData();
                UpdateToUI();
            }
        }

        private void UpdateToUI()
        {
            this.txt_TaskName.Text = Task.Name;
            this.txt_URL.Text = Task.StartURL;
            this.txtFrom.Text = Task.StarStart.ToString();
            this.txtTo.Text = Task.StarEnd.ToString();
            this.txtPlong.Text = Task.StarLong.ToString();
            this.nud_ch.Value = Task.StarGap;
            this.nud_Current.Value = Task.Current;

            this.ctrlPsrList1.Processors = Task.Processor;

        }

        private void UpdateData()
        {
            //this.Task = 
        }

        private void btn_StartWorker_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("ScrapeWorker ");
            string taskFile = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Settings.TASK_SUBPATH, txt_TaskName.Text);
            sb.Append("-t " + taskFile + ".tsk ");

            sb.Append("-ea " + txt_EA.Text.Trim() + " ");
            sb.Append("-eb " + txt_EB.Text.Trim() + " ");

            string fn = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory,Settings.TASK_SUBPATH,"worker.bat");
            System.IO.File.WriteAllText(fn,sb.ToString(), Encoding.Default);
            System.Diagnostics.Process.Start(fn);

        }
        void work1()
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            //启用命令行
            p.StartInfo.FileName = @"cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = false;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = false;
            p.Start();
            //输入各种命令
            p.StandardInput.WriteLine("ScrapeWorker -t " + System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Settings.TASK_SUBPATH, txt_TaskName.Text + ".tsk"));
            p.StandardInput.Close();
            //p.StandardInput.Dispose();
            //获取结果
            p.Close();
            p.Dispose();
        }






    }
}

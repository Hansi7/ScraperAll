using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ScraperAll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBControl.DBControl con = new DBControl.DBControl();
            MessageBox.Show(con.BuildDB());

            //con.CreateClassFile();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XMT281Scraper.FrmTASKBuilder frmTASKBuilder = new XMT281Scraper.FrmTASKBuilder();
            frmTASKBuilder.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XMT281Scraper.FrmPSRBuilder frmPSRBuilder = new XMT281Scraper.FrmPSRBuilder();
            frmPSRBuilder.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            XMT281Scraper.FrmSinglePage frmSingle = new XMT281Scraper.FrmSinglePage();
            frmSingle.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(*.*)所有文件|*.*";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                string json = File.ReadAllText(ofd.FileName);

                JObject jo = JObject.Parse(json);
                
                
                StringWriter textWriter = new StringWriter();
                JsonTextWriter jsonWriter = new JsonTextWriter(textWriter)
                {
                    Formatting = Newtonsoft.Json.Formatting.Indented,
                    Indentation = 4,
                    IndentChar = ' '
                };
                JsonSerializer.Create().Serialize(jsonWriter, jo);
                textBox1.Text = textWriter.ToString();
                textWriter.Dispose();
                jsonWriter.Close();


                JsonTextReader reader = new JsonTextReader(new StringReader(json));
                StringBuilder sb = new StringBuilder();
                bool grabnext = false;
                while (reader.Read())
                {
                    if (reader.Value != null)
                    {
                        if (grabnext)
                        {
                            sb.AppendLine("<img src=\""+reader.Value.ToString()+ "\">");
                            grabnext = false;
                        }
                        if (reader.TokenType== JsonToken.PropertyName && reader.Value.ToString().StartsWith("c0"))
                        {
                            grabnext = true;
                        }
                        Console.WriteLine("Token: {0}, Value: {1}", reader.TokenType, reader.Value);
                    }
                    else
                    {
                        Console.WriteLine("Token: {0}", reader.TokenType);
                    }
                }
                textBox1.Text =  sb.ToString();
                //using (TextReader tr = File.OpenText(ofd.FileName))
                //{
                //    using (Newtonsoft.Json.JsonTextReader jr = new JsonTextReader(tr))
                //    {

                //    }
                //}
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(*.tsk)tsk文件|*.tsk";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Process.Start("ScrapeWorker.exe", ofd.FileName);
                //XMT281Scraper.Tools.ScraperWorker.workWithTaskFileJSON(ofd.FileName);

            }



            //XMT281Scraper.Tools.ScraperWorker.workWithTaskFileJSON(@"C:\Users\Hansi_281\ScraperAll\ScraperAll\bin\Debug\任务文件\bt1024.tsk");
        }
    }
}

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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









            return;

            var jsonResult =  XMT281Scraper.Tools.ScraperWorker.workWithTaskFileJSON("THZ.tsk");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}

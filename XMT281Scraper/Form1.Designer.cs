namespace XMT281Scraper
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.webbrowser = new System.Windows.Forms.WebBrowser();
            this.button2 = new System.Windows.Forms.Button();
            this.btnTEST = new System.Windows.Forms.Button();
            this.btn_ScrapyNoLoading = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_WebbrowserURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlPsrList1 = new XMT281Scraper.CtrlPsrList();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(504, 48);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(41, 25);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "转到";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // webbrowser
            // 
            this.webbrowser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.webbrowser.Location = new System.Drawing.Point(0, 167);
            this.webbrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webbrowser.Name = "webbrowser";
            this.webbrowser.ScriptErrorsSuppressed = true;
            this.webbrowser.Size = new System.Drawing.Size(844, 20);
            this.webbrowser.TabIndex = 2;
            this.webbrowser.Visible = false;
            this.webbrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webbrowser_Navigated);
            this.webbrowser.NewWindow += new System.ComponentModel.CancelEventHandler(this.webbrowser_NewWindow);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 6;
            this.button2.Text = "任务生成器";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnTEST
            // 
            this.btnTEST.Location = new System.Drawing.Point(321, 12);
            this.btnTEST.Name = "btnTEST";
            this.btnTEST.Size = new System.Drawing.Size(177, 25);
            this.btnTEST.TabIndex = 8;
            this.btnTEST.Text = "批量抓取使用模拟浏览器";
            this.btnTEST.UseVisualStyleBackColor = true;
            this.btnTEST.Click += new System.EventHandler(this.btnTEST_Click);
            // 
            // btn_ScrapyNoLoading
            // 
            this.btn_ScrapyNoLoading.Location = new System.Drawing.Point(153, 12);
            this.btn_ScrapyNoLoading.Name = "btn_ScrapyNoLoading";
            this.btn_ScrapyNoLoading.Size = new System.Drawing.Size(162, 25);
            this.btn_ScrapyNoLoading.TabIndex = 16;
            this.btn_ScrapyNoLoading.Text = "单次提取当前显示的页面";
            this.btn_ScrapyNoLoading.UseVisualStyleBackColor = true;
            this.btn_ScrapyNoLoading.Click += new System.EventHandler(this.btn_ScrapyNoLoading_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 25);
            this.button1.TabIndex = 16;
            this.button1.Text = "源文件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_WebbrowserURL
            // 
            this.txt_WebbrowserURL.Location = new System.Drawing.Point(59, 51);
            this.txt_WebbrowserURL.Name = "txt_WebbrowserURL";
            this.txt_WebbrowserURL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_WebbrowserURL.Size = new System.Drawing.Size(439, 21);
            this.txt_WebbrowserURL.TabIndex = 17;
            this.txt_WebbrowserURL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_WebbrowserURL_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "地址：";
            // 
            // ctrlPsrList1
            // 
            this.ctrlPsrList1.Document = null;
            this.ctrlPsrList1.Location = new System.Drawing.Point(551, 1);
            this.ctrlPsrList1.Name = "ctrlPsrList1";
            this.ctrlPsrList1.Size = new System.Drawing.Size(250, 150);
            this.ctrlPsrList1.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 187);
            this.Controls.Add(this.ctrlPsrList1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_WebbrowserURL);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_ScrapyNoLoading);
            this.Controls.Add(this.btnTEST);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.webbrowser);
            this.Name = "Form1";
            this.Text = "281台视听新媒体机房——网页信息提取器";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnTEST;
        private System.Windows.Forms.Button btn_ScrapyNoLoading;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.WebBrowser webbrowser;
        private System.Windows.Forms.TextBox txt_WebbrowserURL;
        private System.Windows.Forms.Label label1;
        private CtrlPsrList ctrlPsrList1;
    }
}


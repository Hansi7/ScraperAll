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
            this.txt_URLS = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.webbrowser = new System.Windows.Forms.WebBrowser();
            this.txt_info = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnTEST = new System.Windows.Forms.Button();
            this.btn_pasteNavi = new System.Windows.Forms.Button();
            this.btn_PSR_GEN = new System.Windows.Forms.Button();
            this.btn_ADD_PSR = new System.Windows.Forms.Button();
            this.btn_Remove_PSR = new System.Windows.Forms.Button();
            this.lb_prograss = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_ScrapyNoLoading = new System.Windows.Forms.Button();
            this.lb_Psr = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_WebbrowserURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_URLS
            // 
            this.txt_URLS.Location = new System.Drawing.Point(8, 14);
            this.txt_URLS.Multiline = true;
            this.txt_URLS.Name = "txt_URLS";
            this.txt_URLS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_URLS.Size = new System.Drawing.Size(378, 99);
            this.txt_URLS.TabIndex = 0;
            this.txt_URLS.WordWrap = false;
            this.txt_URLS.TextChanged += new System.EventHandler(this.txt_URLS_TextChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(512, 117);
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
            this.webbrowser.Location = new System.Drawing.Point(0, 157);
            this.webbrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webbrowser.Name = "webbrowser";
            this.webbrowser.ScriptErrorsSuppressed = true;
            this.webbrowser.Size = new System.Drawing.Size(1094, 326);
            this.webbrowser.TabIndex = 2;
            this.webbrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webbrowser_Navigated);
            this.webbrowser.NewWindow += new System.ComponentModel.CancelEventHandler(this.webbrowser_NewWindow);
            // 
            // txt_info
            // 
            this.txt_info.Location = new System.Drawing.Point(475, 12);
            this.txt_info.Multiline = true;
            this.txt_info.Name = "txt_info";
            this.txt_info.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_info.Size = new System.Drawing.Size(312, 99);
            this.txt_info.TabIndex = 5;
            this.txt_info.Text = "这个功能还在测试。不是很稳定";
            this.txt_info.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(394, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 6;
            this.button2.Text = "网址生成器";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnTEST
            // 
            this.btnTEST.Location = new System.Drawing.Point(941, 112);
            this.btnTEST.Name = "btnTEST";
            this.btnTEST.Size = new System.Drawing.Size(105, 34);
            this.btnTEST.TabIndex = 8;
            this.btnTEST.Text = "批量抓取\r\n使用模拟浏览器";
            this.btnTEST.UseVisualStyleBackColor = true;
            this.btnTEST.Click += new System.EventHandler(this.btnTEST_Click);
            // 
            // btn_pasteNavi
            // 
            this.btn_pasteNavi.Location = new System.Drawing.Point(394, 12);
            this.btn_pasteNavi.Name = "btn_pasteNavi";
            this.btn_pasteNavi.Size = new System.Drawing.Size(41, 25);
            this.btn_pasteNavi.TabIndex = 9;
            this.btn_pasteNavi.Text = "粘贴";
            this.btn_pasteNavi.UseVisualStyleBackColor = true;
            this.btn_pasteNavi.Click += new System.EventHandler(this.btn_pasteNavi_Click);
            // 
            // btn_PSR_GEN
            // 
            this.btn_PSR_GEN.Location = new System.Drawing.Point(977, 68);
            this.btn_PSR_GEN.Name = "btn_PSR_GEN";
            this.btn_PSR_GEN.Size = new System.Drawing.Size(69, 25);
            this.btn_PSR_GEN.TabIndex = 10;
            this.btn_PSR_GEN.Text = "PSR生成器";
            this.btn_PSR_GEN.UseVisualStyleBackColor = true;
            this.btn_PSR_GEN.Click += new System.EventHandler(this.btn_PSR_GEN_Click);
            // 
            // btn_ADD_PSR
            // 
            this.btn_ADD_PSR.Location = new System.Drawing.Point(977, 12);
            this.btn_ADD_PSR.Name = "btn_ADD_PSR";
            this.btn_ADD_PSR.Size = new System.Drawing.Size(69, 23);
            this.btn_ADD_PSR.TabIndex = 12;
            this.btn_ADD_PSR.Text = "加载PSR";
            this.btn_ADD_PSR.UseVisualStyleBackColor = true;
            this.btn_ADD_PSR.Click += new System.EventHandler(this.btn_ADD_PSR_Click);
            // 
            // btn_Remove_PSR
            // 
            this.btn_Remove_PSR.Location = new System.Drawing.Point(977, 39);
            this.btn_Remove_PSR.Name = "btn_Remove_PSR";
            this.btn_Remove_PSR.Size = new System.Drawing.Size(69, 23);
            this.btn_Remove_PSR.TabIndex = 13;
            this.btn_Remove_PSR.Text = "删除";
            this.btn_Remove_PSR.UseVisualStyleBackColor = true;
            this.btn_Remove_PSR.Click += new System.EventHandler(this.btn_Remove_PSR_Click);
            // 
            // lb_prograss
            // 
            this.lb_prograss.AutoSize = true;
            this.lb_prograss.Location = new System.Drawing.Point(392, 101);
            this.lb_prograss.Name = "lb_prograss";
            this.lb_prograss.Size = new System.Drawing.Size(41, 12);
            this.lb_prograss.TabIndex = 14;
            this.lb_prograss.Text = "label1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(489, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 34);
            this.button3.TabIndex = 15;
            this.button3.Text = "批量抓取\r\n使用控件浏览器";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_ScrapyNoLoading
            // 
            this.btn_ScrapyNoLoading.Location = new System.Drawing.Point(793, 112);
            this.btn_ScrapyNoLoading.Name = "btn_ScrapyNoLoading";
            this.btn_ScrapyNoLoading.Size = new System.Drawing.Size(118, 34);
            this.btn_ScrapyNoLoading.TabIndex = 16;
            this.btn_ScrapyNoLoading.Text = "单次提取\r\n当前显示的页面";
            this.btn_ScrapyNoLoading.UseVisualStyleBackColor = true;
            this.btn_ScrapyNoLoading.Click += new System.EventHandler(this.btn_ScrapyNoLoading_Click);
            // 
            // lb_Psr
            // 
            this.lb_Psr.FormattingEnabled = true;
            this.lb_Psr.ItemHeight = 12;
            this.lb_Psr.Location = new System.Drawing.Point(793, 12);
            this.lb_Psr.Name = "lb_Psr";
            this.lb_Psr.Size = new System.Drawing.Size(178, 100);
            this.lb_Psr.TabIndex = 11;
            this.lb_Psr.DoubleClick += new System.EventHandler(this.lb_Psr_DoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(559, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "源文件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_WebbrowserURL
            // 
            this.txt_WebbrowserURL.Location = new System.Drawing.Point(59, 120);
            this.txt_WebbrowserURL.Name = "txt_WebbrowserURL";
            this.txt_WebbrowserURL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_WebbrowserURL.Size = new System.Drawing.Size(447, 21);
            this.txt_WebbrowserURL.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "地址：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 483);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_WebbrowserURL);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_ScrapyNoLoading);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lb_prograss);
            this.Controls.Add(this.btn_Remove_PSR);
            this.Controls.Add(this.btn_ADD_PSR);
            this.Controls.Add(this.lb_Psr);
            this.Controls.Add(this.btn_PSR_GEN);
            this.Controls.Add(this.btn_pasteNavi);
            this.Controls.Add(this.btnTEST);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_info);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txt_URLS);
            this.Controls.Add(this.webbrowser);
            this.Name = "Form1";
            this.Text = "281台视听新媒体机房——网页信息提取器";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_URLS;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txt_info;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnTEST;
        private System.Windows.Forms.Button btn_pasteNavi;
        private System.Windows.Forms.Button btn_PSR_GEN;
        private System.Windows.Forms.Button btn_ADD_PSR;
        private System.Windows.Forms.Button btn_Remove_PSR;
        private System.Windows.Forms.Label lb_prograss;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_ScrapyNoLoading;
        private System.Windows.Forms.ListBox lb_Psr;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.WebBrowser webbrowser;
        private System.Windows.Forms.TextBox txt_WebbrowserURL;
        private System.Windows.Forms.Label label1;
    }
}


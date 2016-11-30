namespace XMT281Scraper
{
    partial class FrmTASKBuilder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTASKBuilder));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_URL = new System.Windows.Forms.TextBox();
            this.btn_inserStar = new System.Windows.Forms.Button();
            this.nud_ch = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btn_GEN = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtPlong = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txt_Output = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_TaskName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_ReadHTML = new System.Windows.Forms.Button();
            this.btn_ReadHTML2 = new System.Windows.Forms.Button();
            this.nud_Current = new System.Windows.Forms.NumericUpDown();
            this.btn_SaveTask = new System.Windows.Forms.Button();
            this.btn_ReadTask = new System.Windows.Forms.Button();
            this.btn_StartWorker = new System.Windows.Forms.Button();
            this.ctrlPsrList1 = new XMT281Scraper.CtrlPsrList();
            this.txt_EA = new System.Windows.Forms.TextBox();
            this.txt_EB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Current)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL：（例如：http://www.abc.com/file(*).zip）";
            // 
            // txt_URL
            // 
            this.txt_URL.Location = new System.Drawing.Point(14, 77);
            this.txt_URL.Name = "txt_URL";
            this.txt_URL.Size = new System.Drawing.Size(588, 21);
            this.txt_URL.TabIndex = 0;
            // 
            // btn_inserStar
            // 
            this.btn_inserStar.Location = new System.Drawing.Point(265, 113);
            this.btn_inserStar.Name = "btn_inserStar";
            this.btn_inserStar.Size = new System.Drawing.Size(22, 22);
            this.btn_inserStar.TabIndex = 10;
            this.btn_inserStar.Text = "*";
            this.btn_inserStar.UseVisualStyleBackColor = true;
            this.btn_inserStar.Click += new System.EventHandler(this.btn_inserStar_Click);
            // 
            // nud_ch
            // 
            this.nud_ch.Location = new System.Drawing.Point(209, 116);
            this.nud_ch.Name = "nud_ch";
            this.nud_ch.Size = new System.Drawing.Size(45, 21);
            this.nud_ch.TabIndex = 9;
            this.nud_ch.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "增长间隔";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(527, 114);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "剪贴板";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btn_GEN
            // 
            this.btn_GEN.Location = new System.Drawing.Point(446, 114);
            this.btn_GEN.Name = "btn_GEN";
            this.btn_GEN.Size = new System.Drawing.Size(75, 23);
            this.btn_GEN.TabIndex = 4;
            this.btn_GEN.Text = "预览";
            this.btn_GEN.UseVisualStyleBackColor = true;
            this.btn_GEN.Click += new System.EventHandler(this.btn_GEN_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "(1~3)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "通配符长度";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "到";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "从";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(104, 116);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(40, 21);
            this.txtTo.TabIndex = 2;
            this.txtTo.Text = "1";
            // 
            // txtPlong
            // 
            this.txtPlong.Location = new System.Drawing.Point(359, 116);
            this.txtPlong.Name = "txtPlong";
            this.txtPlong.Size = new System.Drawing.Size(40, 21);
            this.txtPlong.TabIndex = 3;
            this.txtPlong.Text = "1";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(35, 116);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(40, 21);
            this.txtFrom.TabIndex = 1;
            this.txtFrom.Text = "1";
            // 
            // txt_Output
            // 
            this.txt_Output.Location = new System.Drawing.Point(12, 143);
            this.txt_Output.Multiline = true;
            this.txt_Output.Name = "txt_Output";
            this.txt_Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Output.Size = new System.Drawing.Size(590, 212);
            this.txt_Output.TabIndex = 5;
            this.txt_Output.Text = resources.GetString("txt_Output.Text");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "任务名称";
            // 
            // txt_TaskName
            // 
            this.txt_TaskName.Location = new System.Drawing.Point(95, 6);
            this.txt_TaskName.Name = "txt_TaskName";
            this.txt_TaskName.Size = new System.Drawing.Size(283, 21);
            this.txt_TaskName.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "当前URL序号";
            // 
            // btn_ReadHTML
            // 
            this.btn_ReadHTML.Location = new System.Drawing.Point(268, 361);
            this.btn_ReadHTML.Name = "btn_ReadHTML";
            this.btn_ReadHTML.Size = new System.Drawing.Size(149, 23);
            this.btn_ReadHTML.TabIndex = 15;
            this.btn_ReadHTML.Text = "读取网页1";
            this.btn_ReadHTML.UseVisualStyleBackColor = true;
            this.btn_ReadHTML.Click += new System.EventHandler(this.btn_ReadHTML_Click);
            // 
            // btn_ReadHTML2
            // 
            this.btn_ReadHTML2.Location = new System.Drawing.Point(446, 361);
            this.btn_ReadHTML2.Name = "btn_ReadHTML2";
            this.btn_ReadHTML2.Size = new System.Drawing.Size(149, 23);
            this.btn_ReadHTML2.TabIndex = 15;
            this.btn_ReadHTML2.Text = "读取网页2";
            this.btn_ReadHTML2.UseVisualStyleBackColor = true;
            this.btn_ReadHTML2.Click += new System.EventHandler(this.btn_ReadHTML2_Click);
            // 
            // nud_Current
            // 
            this.nud_Current.Location = new System.Drawing.Point(95, 34);
            this.nud_Current.Name = "nud_Current";
            this.nud_Current.Size = new System.Drawing.Size(100, 21);
            this.nud_Current.TabIndex = 17;
            this.nud_Current.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_SaveTask
            // 
            this.btn_SaveTask.Location = new System.Drawing.Point(268, 390);
            this.btn_SaveTask.Name = "btn_SaveTask";
            this.btn_SaveTask.Size = new System.Drawing.Size(149, 23);
            this.btn_SaveTask.TabIndex = 19;
            this.btn_SaveTask.Text = "保存任务";
            this.btn_SaveTask.UseVisualStyleBackColor = true;
            this.btn_SaveTask.Click += new System.EventHandler(this.btn_SaveTask_Click);
            // 
            // btn_ReadTask
            // 
            this.btn_ReadTask.Location = new System.Drawing.Point(446, 390);
            this.btn_ReadTask.Name = "btn_ReadTask";
            this.btn_ReadTask.Size = new System.Drawing.Size(149, 23);
            this.btn_ReadTask.TabIndex = 20;
            this.btn_ReadTask.Text = "读取任务";
            this.btn_ReadTask.UseVisualStyleBackColor = true;
            this.btn_ReadTask.Click += new System.EventHandler(this.btn_ReadTask_Click);
            // 
            // btn_StartWorker
            // 
            this.btn_StartWorker.Location = new System.Drawing.Point(238, 20);
            this.btn_StartWorker.Name = "btn_StartWorker";
            this.btn_StartWorker.Size = new System.Drawing.Size(83, 48);
            this.btn_StartWorker.TabIndex = 21;
            this.btn_StartWorker.Text = "开始工作";
            this.btn_StartWorker.UseVisualStyleBackColor = true;
            this.btn_StartWorker.Click += new System.EventHandler(this.btn_StartWorker_Click);
            // 
            // ctrlPsrList1
            // 
            this.ctrlPsrList1.Document = null;
            this.ctrlPsrList1.Location = new System.Drawing.Point(12, 361);
            this.ctrlPsrList1.Name = "ctrlPsrList1";
            this.ctrlPsrList1.Size = new System.Drawing.Size(250, 150);
            this.ctrlPsrList1.TabIndex = 18;
            // 
            // txt_EA
            // 
            this.txt_EA.Location = new System.Drawing.Point(139, 20);
            this.txt_EA.Name = "txt_EA";
            this.txt_EA.Size = new System.Drawing.Size(93, 21);
            this.txt_EA.TabIndex = 22;
            this.txt_EA.Text = "未定义1";
            // 
            // txt_EB
            // 
            this.txt_EB.Location = new System.Drawing.Point(139, 47);
            this.txt_EB.Name = "txt_EB";
            this.txt_EB.Size = new System.Drawing.Size(93, 21);
            this.txt_EB.TabIndex = 23;
            this.txt_EB.Text = "未定义2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btn_StartWorker);
            this.groupBox1.Controls.Add(this.txt_EA);
            this.groupBox1.Controls.Add(this.txt_EB);
            this.groupBox1.Location = new System.Drawing.Point(268, 432);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 79);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "开始抓取";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 12);
            this.label9.TabIndex = 25;
            this.label9.Text = "为此任务附加备注1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 12);
            this.label10.TabIndex = 26;
            this.label10.Text = "为此任务附加备注2";
            // 
            // FrmTASKBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 521);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_ReadTask);
            this.Controls.Add(this.btn_SaveTask);
            this.Controls.Add(this.ctrlPsrList1);
            this.Controls.Add(this.nud_Current);
            this.Controls.Add(this.btn_ReadHTML2);
            this.Controls.Add(this.btn_ReadHTML);
            this.Controls.Add(this.txt_TaskName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_inserStar);
            this.Controls.Add(this.nud_ch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txt_URL);
            this.Controls.Add(this.btn_GEN);
            this.Controls.Add(this.txt_Output);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtPlong);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTASKBuilder";
            this.Text = "任务生成器";
            this.Load += new System.EventHandler(this.FrmURLBuilder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_ch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Current)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_URL;
        private System.Windows.Forms.Button btn_inserStar;
        private System.Windows.Forms.NumericUpDown nud_ch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btn_GEN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtPlong;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txt_Output;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_TaskName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_ReadHTML;
        private System.Windows.Forms.Button btn_ReadHTML2;
        private System.Windows.Forms.NumericUpDown nud_Current;
        private CtrlPsrList ctrlPsrList1;
        private System.Windows.Forms.Button btn_SaveTask;
        private System.Windows.Forms.Button btn_ReadTask;
        private System.Windows.Forms.Button btn_StartWorker;
        private System.Windows.Forms.TextBox txt_EA;
        private System.Windows.Forms.TextBox txt_EB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}
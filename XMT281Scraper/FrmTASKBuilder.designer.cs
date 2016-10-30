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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_ReadHTML = new System.Windows.Forms.Button();
            this.tv1 = new System.Windows.Forms.TreeView();
            this.btn_ReadHTML2 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btn_NewPSR = new System.Windows.Forms.Button();
            this.btn_DELPSR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.txtTo.Text = "0";
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
            this.txtFrom.Text = "0";
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(95, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 12;
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
            this.btn_ReadHTML.Location = new System.Drawing.Point(527, 361);
            this.btn_ReadHTML.Name = "btn_ReadHTML";
            this.btn_ReadHTML.Size = new System.Drawing.Size(75, 23);
            this.btn_ReadHTML.TabIndex = 15;
            this.btn_ReadHTML.Text = "读取网页1";
            this.btn_ReadHTML.UseVisualStyleBackColor = true;
            this.btn_ReadHTML.Click += new System.EventHandler(this.btn_ReadHTML_Click);
            // 
            // tv1
            // 
            this.tv1.Location = new System.Drawing.Point(12, 361);
            this.tv1.Name = "tv1";
            this.tv1.Size = new System.Drawing.Size(509, 123);
            this.tv1.TabIndex = 16;
            // 
            // btn_ReadHTML2
            // 
            this.btn_ReadHTML2.Location = new System.Drawing.Point(527, 390);
            this.btn_ReadHTML2.Name = "btn_ReadHTML2";
            this.btn_ReadHTML2.Size = new System.Drawing.Size(75, 23);
            this.btn_ReadHTML2.TabIndex = 15;
            this.btn_ReadHTML2.Text = "读取网页2";
            this.btn_ReadHTML2.UseVisualStyleBackColor = true;
            this.btn_ReadHTML2.Click += new System.EventHandler(this.btn_ReadHTML2_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(95, 34);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 21);
            this.numericUpDown1.TabIndex = 17;
            // 
            // btn_NewPSR
            // 
            this.btn_NewPSR.Location = new System.Drawing.Point(527, 419);
            this.btn_NewPSR.Name = "btn_NewPSR";
            this.btn_NewPSR.Size = new System.Drawing.Size(75, 23);
            this.btn_NewPSR.TabIndex = 18;
            this.btn_NewPSR.Text = "新建提取器";
            this.btn_NewPSR.UseVisualStyleBackColor = true;
            this.btn_NewPSR.Click += new System.EventHandler(this.btn_NewPSR_Click);
            // 
            // btn_DELPSR
            // 
            this.btn_DELPSR.Location = new System.Drawing.Point(527, 448);
            this.btn_DELPSR.Name = "btn_DELPSR";
            this.btn_DELPSR.Size = new System.Drawing.Size(75, 23);
            this.btn_DELPSR.TabIndex = 19;
            this.btn_DELPSR.Text = "删除提取器";
            this.btn_DELPSR.UseVisualStyleBackColor = true;
            this.btn_DELPSR.Click += new System.EventHandler(this.btn_DELPSR_Click);
            // 
            // FrmTASKBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 491);
            this.Controls.Add(this.btn_DELPSR);
            this.Controls.Add(this.btn_NewPSR);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.tv1);
            this.Controls.Add(this.btn_ReadHTML2);
            this.Controls.Add(this.btn_ReadHTML);
            this.Controls.Add(this.textBox2);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_ReadHTML;
        private System.Windows.Forms.TreeView tv1;
        private System.Windows.Forms.Button btn_ReadHTML2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btn_NewPSR;
        private System.Windows.Forms.Button btn_DELPSR;
    }
}
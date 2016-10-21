namespace XMT281Scraper
{
    partial class FrmURLBuilder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmURLBuilder));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtPlong = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Output = new System.Windows.Forms.TextBox();
            this.btn_GEN = new System.Windows.Forms.Button();
            this.txt_URL = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nud_ch = new System.Windows.Forms.NumericUpDown();
            this.btn_inserStar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ch)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(590, 107);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL：（例如：http://www.abc.com/file(*).zip）";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(35, 176);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(40, 21);
            this.txtFrom.TabIndex = 1;
            this.txtFrom.Text = "0";
            // 
            // txtPlong
            // 
            this.txtPlong.Location = new System.Drawing.Point(359, 176);
            this.txtPlong.Name = "txtPlong";
            this.txtPlong.Size = new System.Drawing.Size(40, 21);
            this.txtPlong.TabIndex = 3;
            this.txtPlong.Text = "1";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(104, 176);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(40, 21);
            this.txtTo.TabIndex = 2;
            this.txtTo.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "从";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "到";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "通配符长度";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "(1~3)";
            // 
            // txt_Output
            // 
            this.txt_Output.Location = new System.Drawing.Point(12, 203);
            this.txt_Output.Multiline = true;
            this.txt_Output.Name = "txt_Output";
            this.txt_Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Output.Size = new System.Drawing.Size(590, 187);
            this.txt_Output.TabIndex = 5;
            // 
            // btn_GEN
            // 
            this.btn_GEN.Location = new System.Drawing.Point(446, 174);
            this.btn_GEN.Name = "btn_GEN";
            this.btn_GEN.Size = new System.Drawing.Size(75, 23);
            this.btn_GEN.TabIndex = 4;
            this.btn_GEN.Text = "生成";
            this.btn_GEN.UseVisualStyleBackColor = true;
            this.btn_GEN.Click += new System.EventHandler(this.btn_GEN_Click);
            // 
            // txt_URL
            // 
            this.txt_URL.Location = new System.Drawing.Point(14, 137);
            this.txt_URL.Name = "txt_URL";
            this.txt_URL.Size = new System.Drawing.Size(588, 21);
            this.txt_URL.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(527, 174);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "剪贴板";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "增长间隔";
            // 
            // nud_ch
            // 
            this.nud_ch.Location = new System.Drawing.Point(209, 176);
            this.nud_ch.Name = "nud_ch";
            this.nud_ch.Size = new System.Drawing.Size(45, 21);
            this.nud_ch.TabIndex = 9;
            this.nud_ch.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_inserStar
            // 
            this.btn_inserStar.Location = new System.Drawing.Point(265, 173);
            this.btn_inserStar.Name = "btn_inserStar";
            this.btn_inserStar.Size = new System.Drawing.Size(22, 22);
            this.btn_inserStar.TabIndex = 10;
            this.btn_inserStar.Text = "*";
            this.btn_inserStar.UseVisualStyleBackColor = true;
            this.btn_inserStar.Click += new System.EventHandler(this.btn_inserStar_Click);
            // 
            // FrmURLBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 402);
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
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmURLBuilder";
            this.Text = "URL生成器";
            this.Load += new System.EventHandler(this.FrmURLBuilder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_ch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtPlong;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Output;
        private System.Windows.Forms.Button btn_GEN;
        private System.Windows.Forms.TextBox txt_URL;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nud_ch;
        private System.Windows.Forms.Button btn_inserStar;
    }
}
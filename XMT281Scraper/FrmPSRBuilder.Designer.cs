namespace XMT281Scraper
{
    partial class FrmPSRBuilder
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
            this.txt_PSRViewer = new System.Windows.Forms.TextBox();
            this.gb0 = new System.Windows.Forms.GroupBox();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn_Tryme = new System.Windows.Forms.Button();
            this.btn_DelLast = new System.Windows.Forms.Button();
            this.btn_ClearOffsetNode = new System.Windows.Forms.Button();
            this.rb_Defult_OFFSET = new System.Windows.Forms.RadioButton();
            this.rb_child_OFFSET = new System.Windows.Forms.RadioButton();
            this.rb_sibingRight_OFFSET = new System.Windows.Forms.RadioButton();
            this.rb_sibingLeft_OFFSET = new System.Windows.Forms.RadioButton();
            this.txt_tryme = new System.Windows.Forms.TextBox();
            this.rb_parent_OFFSET = new System.Windows.Forms.RadioButton();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.txt_ATTRIB = new System.Windows.Forms.TextBox();
            this.rb_InnerText_ATT = new System.Windows.Forms.RadioButton();
            this.rb_href_ATT = new System.Windows.Forms.RadioButton();
            this.btn_TryPSR = new System.Windows.Forms.Button();
            this.rb_none_ATT = new System.Windows.Forms.RadioButton();
            this.rb_title_ATT = new System.Windows.Forms.RadioButton();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.btn_Space = new System.Windows.Forms.Button();
            this.rb_REMOVE_after = new System.Windows.Forms.RadioButton();
            this.btn_RESET_REMOVER = new System.Windows.Forms.Button();
            this.rb_REMOVE_before = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_AddString = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Replace = new System.Windows.Forms.TextBox();
            this.rb_Replace = new System.Windows.Forms.RadioButton();
            this.rb_Remove = new System.Windows.Forms.RadioButton();
            this.txt_Remove = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_XPATH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_CSSSelector = new System.Windows.Forms.TextBox();
            this.txt_SourceCode = new System.Windows.Forms.TextBox();
            this.btn_SavePsr = new System.Windows.Forms.Button();
            this.txt_Json = new System.Windows.Forms.TextBox();
            this.btn_LOAD = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_LOADTEXT = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_Filename = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gb0.SuspendLayout();
            this.gb1.SuspendLayout();
            this.gb2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_PSRViewer
            // 
            this.txt_PSRViewer.Location = new System.Drawing.Point(623, 10);
            this.txt_PSRViewer.Multiline = true;
            this.txt_PSRViewer.Name = "txt_PSRViewer";
            this.txt_PSRViewer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_PSRViewer.Size = new System.Drawing.Size(359, 92);
            this.txt_PSRViewer.TabIndex = 0;
            this.txt_PSRViewer.Text = "提取器描述";
            // 
            // gb0
            // 
            this.gb0.Controls.Add(this.btn3);
            this.gb0.Controls.Add(this.btn4);
            this.gb0.Controls.Add(this.btn2);
            this.gb0.Controls.Add(this.btn1);
            this.gb0.Controls.Add(this.btn0);
            this.gb0.Controls.Add(this.btn_Tryme);
            this.gb0.Controls.Add(this.btn_DelLast);
            this.gb0.Controls.Add(this.btn_ClearOffsetNode);
            this.gb0.Controls.Add(this.rb_Defult_OFFSET);
            this.gb0.Controls.Add(this.rb_child_OFFSET);
            this.gb0.Controls.Add(this.rb_sibingRight_OFFSET);
            this.gb0.Controls.Add(this.rb_sibingLeft_OFFSET);
            this.gb0.Controls.Add(this.txt_tryme);
            this.gb0.Controls.Add(this.rb_parent_OFFSET);
            this.gb0.Location = new System.Drawing.Point(12, 94);
            this.gb0.Name = "gb0";
            this.gb0.Size = new System.Drawing.Size(188, 163);
            this.gb0.TabIndex = 20;
            this.gb0.TabStop = false;
            this.gb0.Text = "节点偏移";
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(59, 79);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(49, 23);
            this.btn3.TabIndex = 45;
            this.btn3.Text = "添加";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(59, 99);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(49, 23);
            this.btn4.TabIndex = 46;
            this.btn4.Text = "添加";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(59, 58);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(49, 23);
            this.btn2.TabIndex = 44;
            this.btn2.Text = "添加";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(59, 36);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(49, 23);
            this.btn1.TabIndex = 43;
            this.btn1.Text = "添加";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(59, 14);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(49, 23);
            this.btn0.TabIndex = 42;
            this.btn0.Text = "添加";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn_Tryme
            // 
            this.btn_Tryme.Location = new System.Drawing.Point(114, 121);
            this.btn_Tryme.Name = "btn_Tryme";
            this.btn_Tryme.Size = new System.Drawing.Size(61, 35);
            this.btn_Tryme.TabIndex = 47;
            this.btn_Tryme.Text = "子项探测";
            this.btn_Tryme.UseVisualStyleBackColor = true;
            this.btn_Tryme.Click += new System.EventHandler(this.btn_Tryme_Click);
            // 
            // btn_DelLast
            // 
            this.btn_DelLast.Location = new System.Drawing.Point(114, 17);
            this.btn_DelLast.Name = "btn_DelLast";
            this.btn_DelLast.Size = new System.Drawing.Size(61, 35);
            this.btn_DelLast.TabIndex = 43;
            this.btn_DelLast.Text = "撤销一次";
            this.btn_DelLast.UseVisualStyleBackColor = true;
            this.btn_DelLast.Click += new System.EventHandler(this.btn_DelLast_Click);
            // 
            // btn_ClearOffsetNode
            // 
            this.btn_ClearOffsetNode.Location = new System.Drawing.Point(114, 69);
            this.btn_ClearOffsetNode.Name = "btn_ClearOffsetNode";
            this.btn_ClearOffsetNode.Size = new System.Drawing.Size(61, 35);
            this.btn_ClearOffsetNode.TabIndex = 42;
            this.btn_ClearOffsetNode.Text = "清空偏移";
            this.btn_ClearOffsetNode.UseVisualStyleBackColor = true;
            this.btn_ClearOffsetNode.Click += new System.EventHandler(this.btn_ClearOffsetNode_Click);
            // 
            // rb_Defult_OFFSET
            // 
            this.rb_Defult_OFFSET.AutoSize = true;
            this.rb_Defult_OFFSET.Checked = true;
            this.rb_Defult_OFFSET.Location = new System.Drawing.Point(19, 17);
            this.rb_Defult_OFFSET.Name = "rb_Defult_OFFSET";
            this.rb_Defult_OFFSET.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rb_Defult_OFFSET.Size = new System.Drawing.Size(53, 16);
            this.rb_Defult_OFFSET.TabIndex = 19;
            this.rb_Defult_OFFSET.TabStop = true;
            this.rb_Defult_OFFSET.Text = "无  0";
            this.rb_Defult_OFFSET.UseVisualStyleBackColor = true;
            this.rb_Defult_OFFSET.CheckedChanged += new System.EventHandler(this.rb_Defult_OFFSET_CheckedChanged);
            this.rb_Defult_OFFSET.Click += new System.EventHandler(this.rb_Defult_OFFSET_Click);
            // 
            // rb_child_OFFSET
            // 
            this.rb_child_OFFSET.AutoSize = true;
            this.rb_child_OFFSET.Location = new System.Drawing.Point(19, 102);
            this.rb_child_OFFSET.Name = "rb_child_OFFSET";
            this.rb_child_OFFSET.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rb_child_OFFSET.Size = new System.Drawing.Size(53, 16);
            this.rb_child_OFFSET.TabIndex = 18;
            this.rb_child_OFFSET.Text = "子  4";
            this.rb_child_OFFSET.UseVisualStyleBackColor = true;
            this.rb_child_OFFSET.CheckedChanged += new System.EventHandler(this.rb_Defult_OFFSET_CheckedChanged);
            this.rb_child_OFFSET.Click += new System.EventHandler(this.rb_Defult_OFFSET_Click);
            // 
            // rb_sibingRight_OFFSET
            // 
            this.rb_sibingRight_OFFSET.AutoSize = true;
            this.rb_sibingRight_OFFSET.Location = new System.Drawing.Point(19, 61);
            this.rb_sibingRight_OFFSET.Name = "rb_sibingRight_OFFSET";
            this.rb_sibingRight_OFFSET.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rb_sibingRight_OFFSET.Size = new System.Drawing.Size(53, 16);
            this.rb_sibingRight_OFFSET.TabIndex = 17;
            this.rb_sibingRight_OFFSET.Text = "右  2";
            this.rb_sibingRight_OFFSET.UseVisualStyleBackColor = true;
            this.rb_sibingRight_OFFSET.CheckedChanged += new System.EventHandler(this.rb_Defult_OFFSET_CheckedChanged);
            this.rb_sibingRight_OFFSET.Click += new System.EventHandler(this.rb_Defult_OFFSET_Click);
            // 
            // rb_sibingLeft_OFFSET
            // 
            this.rb_sibingLeft_OFFSET.AutoSize = true;
            this.rb_sibingLeft_OFFSET.Location = new System.Drawing.Point(19, 39);
            this.rb_sibingLeft_OFFSET.Name = "rb_sibingLeft_OFFSET";
            this.rb_sibingLeft_OFFSET.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rb_sibingLeft_OFFSET.Size = new System.Drawing.Size(53, 16);
            this.rb_sibingLeft_OFFSET.TabIndex = 16;
            this.rb_sibingLeft_OFFSET.Text = "左  1";
            this.rb_sibingLeft_OFFSET.UseVisualStyleBackColor = true;
            this.rb_sibingLeft_OFFSET.CheckedChanged += new System.EventHandler(this.rb_Defult_OFFSET_CheckedChanged);
            this.rb_sibingLeft_OFFSET.Click += new System.EventHandler(this.rb_Defult_OFFSET_Click);
            // 
            // txt_tryme
            // 
            this.txt_tryme.Location = new System.Drawing.Point(8, 129);
            this.txt_tryme.Name = "txt_tryme";
            this.txt_tryme.Size = new System.Drawing.Size(100, 21);
            this.txt_tryme.TabIndex = 29;
            // 
            // rb_parent_OFFSET
            // 
            this.rb_parent_OFFSET.AutoSize = true;
            this.rb_parent_OFFSET.Location = new System.Drawing.Point(19, 82);
            this.rb_parent_OFFSET.Name = "rb_parent_OFFSET";
            this.rb_parent_OFFSET.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rb_parent_OFFSET.Size = new System.Drawing.Size(53, 16);
            this.rb_parent_OFFSET.TabIndex = 15;
            this.rb_parent_OFFSET.Text = "父  3";
            this.rb_parent_OFFSET.UseVisualStyleBackColor = true;
            this.rb_parent_OFFSET.CheckedChanged += new System.EventHandler(this.rb_Defult_OFFSET_CheckedChanged);
            this.rb_parent_OFFSET.Click += new System.EventHandler(this.rb_Defult_OFFSET_Click);
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.txt_ATTRIB);
            this.gb1.Controls.Add(this.rb_InnerText_ATT);
            this.gb1.Controls.Add(this.rb_href_ATT);
            this.gb1.Controls.Add(this.btn_TryPSR);
            this.gb1.Controls.Add(this.rb_none_ATT);
            this.gb1.Controls.Add(this.rb_title_ATT);
            this.gb1.Location = new System.Drawing.Point(206, 94);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(200, 163);
            this.gb1.TabIndex = 21;
            this.gb1.TabStop = false;
            this.gb1.Text = "节点属性";
            // 
            // txt_ATTRIB
            // 
            this.txt_ATTRIB.Location = new System.Drawing.Point(21, 25);
            this.txt_ATTRIB.Name = "txt_ATTRIB";
            this.txt_ATTRIB.Size = new System.Drawing.Size(163, 21);
            this.txt_ATTRIB.TabIndex = 35;
            this.txt_ATTRIB.Text = "OuterHtml";
            // 
            // rb_InnerText_ATT
            // 
            this.rb_InnerText_ATT.AutoSize = true;
            this.rb_InnerText_ATT.Location = new System.Drawing.Point(105, 64);
            this.rb_InnerText_ATT.Name = "rb_InnerText_ATT";
            this.rb_InnerText_ATT.Size = new System.Drawing.Size(77, 16);
            this.rb_InnerText_ATT.TabIndex = 16;
            this.rb_InnerText_ATT.Text = "InnerText";
            this.rb_InnerText_ATT.UseVisualStyleBackColor = true;
            this.rb_InnerText_ATT.CheckedChanged += new System.EventHandler(this.rb_InnerText_ATT_CheckedChanged);
            this.rb_InnerText_ATT.Click += new System.EventHandler(this.rb_none_ATT_Click);
            // 
            // rb_href_ATT
            // 
            this.rb_href_ATT.AutoSize = true;
            this.rb_href_ATT.Location = new System.Drawing.Point(21, 97);
            this.rb_href_ATT.Name = "rb_href_ATT";
            this.rb_href_ATT.Size = new System.Drawing.Size(47, 16);
            this.rb_href_ATT.TabIndex = 14;
            this.rb_href_ATT.Text = "href";
            this.rb_href_ATT.UseVisualStyleBackColor = true;
            this.rb_href_ATT.CheckedChanged += new System.EventHandler(this.rb_href_ATT_CheckedChanged);
            this.rb_href_ATT.Click += new System.EventHandler(this.rb_none_ATT_Click);
            // 
            // btn_TryPSR
            // 
            this.btn_TryPSR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_TryPSR.Location = new System.Drawing.Point(21, 121);
            this.btn_TryPSR.Name = "btn_TryPSR";
            this.btn_TryPSR.Size = new System.Drawing.Size(161, 34);
            this.btn_TryPSR.TabIndex = 39;
            this.btn_TryPSR.Text = "测试";
            this.btn_TryPSR.UseVisualStyleBackColor = false;
            this.btn_TryPSR.Click += new System.EventHandler(this.btn_TryPSR_Click);
            // 
            // rb_none_ATT
            // 
            this.rb_none_ATT.AutoSize = true;
            this.rb_none_ATT.Checked = true;
            this.rb_none_ATT.Location = new System.Drawing.Point(21, 64);
            this.rb_none_ATT.Name = "rb_none_ATT";
            this.rb_none_ATT.Size = new System.Drawing.Size(77, 16);
            this.rb_none_ATT.TabIndex = 13;
            this.rb_none_ATT.TabStop = true;
            this.rb_none_ATT.Text = "OuterHtml";
            this.rb_none_ATT.UseVisualStyleBackColor = true;
            this.rb_none_ATT.CheckedChanged += new System.EventHandler(this.rb_none_ATT_CheckedChanged);
            this.rb_none_ATT.Click += new System.EventHandler(this.rb_none_ATT_Click);
            // 
            // rb_title_ATT
            // 
            this.rb_title_ATT.AutoSize = true;
            this.rb_title_ATT.Location = new System.Drawing.Point(105, 97);
            this.rb_title_ATT.Name = "rb_title_ATT";
            this.rb_title_ATT.Size = new System.Drawing.Size(53, 16);
            this.rb_title_ATT.TabIndex = 15;
            this.rb_title_ATT.Text = "title";
            this.rb_title_ATT.UseVisualStyleBackColor = true;
            this.rb_title_ATT.CheckedChanged += new System.EventHandler(this.rb_title_ATT_CheckedChanged);
            this.rb_title_ATT.Click += new System.EventHandler(this.rb_none_ATT_Click);
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.btn_Space);
            this.gb2.Controls.Add(this.rb_REMOVE_after);
            this.gb2.Controls.Add(this.btn_RESET_REMOVER);
            this.gb2.Controls.Add(this.rb_REMOVE_before);
            this.gb2.Controls.Add(this.label6);
            this.gb2.Controls.Add(this.btn_AddString);
            this.gb2.Controls.Add(this.label1);
            this.gb2.Controls.Add(this.txt_Replace);
            this.gb2.Controls.Add(this.rb_Replace);
            this.gb2.Controls.Add(this.rb_Remove);
            this.gb2.Controls.Add(this.txt_Remove);
            this.gb2.Location = new System.Drawing.Point(412, 94);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(205, 163);
            this.gb2.TabIndex = 22;
            this.gb2.TabStop = false;
            this.gb2.Text = "字符串处理";
            // 
            // btn_Space
            // 
            this.btn_Space.Location = new System.Drawing.Point(88, 43);
            this.btn_Space.Name = "btn_Space";
            this.btn_Space.Size = new System.Drawing.Size(106, 23);
            this.btn_Space.TabIndex = 35;
            this.btn_Space.Text = "删除空白字符";
            this.btn_Space.UseVisualStyleBackColor = true;
            this.btn_Space.Click += new System.EventHandler(this.btn_Space_Click);
            // 
            // rb_REMOVE_after
            // 
            this.rb_REMOVE_after.AutoSize = true;
            this.rb_REMOVE_after.Location = new System.Drawing.Point(6, 67);
            this.rb_REMOVE_after.Name = "rb_REMOVE_after";
            this.rb_REMOVE_after.Size = new System.Drawing.Size(77, 16);
            this.rb_REMOVE_after.TabIndex = 33;
            this.rb_REMOVE_after.Text = "删...之后";
            this.rb_REMOVE_after.UseVisualStyleBackColor = true;
            // 
            // btn_RESET_REMOVER
            // 
            this.btn_RESET_REMOVER.Location = new System.Drawing.Point(88, 66);
            this.btn_RESET_REMOVER.Name = "btn_RESET_REMOVER";
            this.btn_RESET_REMOVER.Size = new System.Drawing.Size(106, 23);
            this.btn_RESET_REMOVER.TabIndex = 34;
            this.btn_RESET_REMOVER.Text = "清空字符处理";
            this.btn_RESET_REMOVER.UseVisualStyleBackColor = true;
            this.btn_RESET_REMOVER.Click += new System.EventHandler(this.btn_RESET_REMOVER_Click);
            // 
            // rb_REMOVE_before
            // 
            this.rb_REMOVE_before.AutoSize = true;
            this.rb_REMOVE_before.Location = new System.Drawing.Point(6, 45);
            this.rb_REMOVE_before.Name = "rb_REMOVE_before";
            this.rb_REMOVE_before.Size = new System.Drawing.Size(77, 16);
            this.rb_REMOVE_before.TabIndex = 32;
            this.rb_REMOVE_before.Text = "删...之前";
            this.rb_REMOVE_before.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 31;
            this.label6.Text = "删除";
            // 
            // btn_AddString
            // 
            this.btn_AddString.Location = new System.Drawing.Point(88, 20);
            this.btn_AddString.Name = "btn_AddString";
            this.btn_AddString.Size = new System.Drawing.Size(106, 23);
            this.btn_AddString.TabIndex = 30;
            this.btn_AddString.Text = "添加字符处理";
            this.btn_AddString.UseVisualStyleBackColor = true;
            this.btn_AddString.Click += new System.EventHandler(this.btn_AddString_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 23;
            this.label1.Text = "替换为";
            // 
            // txt_Replace
            // 
            this.txt_Replace.Location = new System.Drawing.Point(64, 127);
            this.txt_Replace.Name = "txt_Replace";
            this.txt_Replace.Size = new System.Drawing.Size(130, 21);
            this.txt_Replace.TabIndex = 24;
            // 
            // rb_Replace
            // 
            this.rb_Replace.AutoSize = true;
            this.rb_Replace.Location = new System.Drawing.Point(47, 23);
            this.rb_Replace.Name = "rb_Replace";
            this.rb_Replace.Size = new System.Drawing.Size(35, 16);
            this.rb_Replace.TabIndex = 23;
            this.rb_Replace.Text = "替";
            this.rb_Replace.UseVisualStyleBackColor = true;
            // 
            // rb_Remove
            // 
            this.rb_Remove.AutoSize = true;
            this.rb_Remove.Checked = true;
            this.rb_Remove.Location = new System.Drawing.Point(6, 23);
            this.rb_Remove.Name = "rb_Remove";
            this.rb_Remove.Size = new System.Drawing.Size(35, 16);
            this.rb_Remove.TabIndex = 22;
            this.rb_Remove.TabStop = true;
            this.rb_Remove.Text = "删";
            this.rb_Remove.UseVisualStyleBackColor = true;
            // 
            // txt_Remove
            // 
            this.txt_Remove.Location = new System.Drawing.Point(64, 97);
            this.txt_Remove.Name = "txt_Remove";
            this.txt_Remove.Size = new System.Drawing.Size(130, 21);
            this.txt_Remove.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 24;
            this.label3.Text = "Xpath";
            // 
            // txt_XPATH
            // 
            this.txt_XPATH.Location = new System.Drawing.Point(41, 39);
            this.txt_XPATH.Name = "txt_XPATH";
            this.txt_XPATH.Size = new System.Drawing.Size(159, 21);
            this.txt_XPATH.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 26;
            this.label4.Text = "Css";
            // 
            // txt_CSSSelector
            // 
            this.txt_CSSSelector.Location = new System.Drawing.Point(41, 67);
            this.txt_CSSSelector.Name = "txt_CSSSelector";
            this.txt_CSSSelector.Size = new System.Drawing.Size(159, 21);
            this.txt_CSSSelector.TabIndex = 27;
            // 
            // txt_SourceCode
            // 
            this.txt_SourceCode.Location = new System.Drawing.Point(12, 263);
            this.txt_SourceCode.Multiline = true;
            this.txt_SourceCode.Name = "txt_SourceCode";
            this.txt_SourceCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_SourceCode.Size = new System.Drawing.Size(605, 248);
            this.txt_SourceCode.TabIndex = 32;
            this.txt_SourceCode.Text = "提取结果预览";
            // 
            // btn_SavePsr
            // 
            this.btn_SavePsr.Location = new System.Drawing.Point(20, 47);
            this.btn_SavePsr.Name = "btn_SavePsr";
            this.btn_SavePsr.Size = new System.Drawing.Size(44, 23);
            this.btn_SavePsr.TabIndex = 33;
            this.btn_SavePsr.Text = "保存";
            this.btn_SavePsr.UseVisualStyleBackColor = true;
            this.btn_SavePsr.Click += new System.EventHandler(this.btn_SavePsr_Click);
            // 
            // txt_Json
            // 
            this.txt_Json.Location = new System.Drawing.Point(623, 108);
            this.txt_Json.Multiline = true;
            this.txt_Json.Name = "txt_Json";
            this.txt_Json.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Json.Size = new System.Drawing.Size(359, 403);
            this.txt_Json.TabIndex = 35;
            this.txt_Json.Text = "提取器源码";
            // 
            // btn_LOAD
            // 
            this.btn_LOAD.Location = new System.Drawing.Point(135, 47);
            this.btn_LOAD.Name = "btn_LOAD";
            this.btn_LOAD.Size = new System.Drawing.Size(44, 23);
            this.btn_LOAD.TabIndex = 36;
            this.btn_LOAD.Text = "加载";
            this.btn_LOAD.UseVisualStyleBackColor = true;
            this.btn_LOAD.Click += new System.EventHandler(this.btn_LOAD_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OK.Location = new System.Drawing.Point(412, 12);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(194, 78);
            this.btn_OK.TabIndex = 37;
            this.btn_OK.Text = "使用此提取器";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_LOADTEXT
            // 
            this.btn_LOADTEXT.Location = new System.Drawing.Point(635, 477);
            this.btn_LOADTEXT.Name = "btn_LOADTEXT";
            this.btn_LOADTEXT.Size = new System.Drawing.Size(320, 23);
            this.btn_LOADTEXT.TabIndex = 40;
            this.btn_LOADTEXT.Text = "手动编辑后，点击加载此窗格文本为PSR";
            this.btn_LOADTEXT.UseVisualStyleBackColor = true;
            this.btn_LOADTEXT.Click += new System.EventHandler(this.btn_LOADTEXT_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "选择一个html文档加载";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Filename
            // 
            this.txt_Filename.Location = new System.Drawing.Point(20, 20);
            this.txt_Filename.Name = "txt_Filename";
            this.txt_Filename.Size = new System.Drawing.Size(159, 21);
            this.txt_Filename.TabIndex = 42;
            this.txt_Filename.Text = "InputFileName";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Filename);
            this.groupBox1.Controls.Add(this.btn_SavePsr);
            this.groupBox1.Controls.Add(this.btn_LOAD);
            this.groupBox1.Location = new System.Drawing.Point(206, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 80);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PSR控制";
            // 
            // FrmPSRBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 523);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_LOADTEXT);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.txt_Json);
            this.Controls.Add(this.txt_SourceCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_CSSSelector);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_XPATH);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.gb0);
            this.Controls.Add(this.txt_PSRViewer);
            this.Name = "FrmPSRBuilder";
            this.Text = "提取器（PSR）编辑器";
            this.Load += new System.EventHandler(this.FrmPSRBuilder_Load);
            this.gb0.ResumeLayout(false);
            this.gb0.PerformLayout();
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_PSRViewer;
        private System.Windows.Forms.GroupBox gb0;
        private System.Windows.Forms.RadioButton rb_Defult_OFFSET;
        private System.Windows.Forms.RadioButton rb_child_OFFSET;
        private System.Windows.Forms.RadioButton rb_sibingRight_OFFSET;
        private System.Windows.Forms.RadioButton rb_sibingLeft_OFFSET;
        private System.Windows.Forms.RadioButton rb_parent_OFFSET;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.RadioButton rb_InnerText_ATT;
        private System.Windows.Forms.RadioButton rb_href_ATT;
        private System.Windows.Forms.RadioButton rb_none_ATT;
        private System.Windows.Forms.RadioButton rb_title_ATT;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.TextBox txt_Replace;
        private System.Windows.Forms.RadioButton rb_Replace;
        private System.Windows.Forms.RadioButton rb_Remove;
        private System.Windows.Forms.TextBox txt_Remove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_XPATH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_CSSSelector;
        private System.Windows.Forms.TextBox txt_tryme;
        private System.Windows.Forms.Button btn_AddString;
        private System.Windows.Forms.TextBox txt_SourceCode;
        private System.Windows.Forms.Button btn_SavePsr;
        private System.Windows.Forms.Button btn_RESET_REMOVER;
        private System.Windows.Forms.TextBox txt_ATTRIB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rb_REMOVE_after;
        private System.Windows.Forms.RadioButton rb_REMOVE_before;
        private System.Windows.Forms.TextBox txt_Json;
        private System.Windows.Forms.Button btn_LOAD;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_TryPSR;
        private System.Windows.Forms.Button btn_Space;
        private System.Windows.Forms.Button btn_LOADTEXT;
        private System.Windows.Forms.Button btn_ClearOffsetNode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_DelLast;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn_Tryme;
        private System.Windows.Forms.TextBox txt_Filename;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
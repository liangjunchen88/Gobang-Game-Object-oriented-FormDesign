namespace 五子棋Forms
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.模式选择ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.双人对战ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.人机对战ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.功能ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.悔棋ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.存盘ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复盘ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.推出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助和说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button13 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(376, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2171, 2147);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::五子棋Forms.Properties.Resources._8;
            this.panel2.Controls.Add(this.button13);
            this.panel2.Controls.Add(this.button12);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button11);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 998);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.LightSlateGray;
            this.button12.Enabled = false;
            this.button12.Font = new System.Drawing.Font("隶书", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(314, 823);
            this.button12.Margin = new System.Windows.Forms.Padding(6);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(10, 10);
            this.button12.TabIndex = 6;
            this.button12.Text = "悔棋";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button6_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LightSlateGray;
            this.button6.Enabled = false;
            this.button6.Font = new System.Drawing.Font("隶书", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button6.ForeColor = System.Drawing.Color.Transparent;
            this.button6.Location = new System.Drawing.Point(26, 334);
            this.button6.Margin = new System.Windows.Forms.Padding(6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(121, 49);
            this.button6.TabIndex = 6;
            this.button6.Text = "悔棋";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightSlateGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.Location = new System.Drawing.Point(66, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(114, 38);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(67, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "TIME";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.LightSlateGray;
            this.button11.Enabled = false;
            this.button11.Font = new System.Drawing.Font("隶书", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(314, 639);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(10, 10);
            this.button11.TabIndex = 3;
            this.button11.Text = "复盘";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button5_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.LightSlateGray;
            this.button10.Enabled = false;
            this.button10.Font = new System.Drawing.Font("隶书", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(314, 455);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(10, 10);
            this.button10.TabIndex = 2;
            this.button10.Text = "存盘";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSlateGray;
            this.button5.Enabled = false;
            this.button5.Font = new System.Drawing.Font("隶书", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.ForeColor = System.Drawing.Color.Transparent;
            this.button5.Location = new System.Drawing.Point(28, 436);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 49);
            this.button5.TabIndex = 3;
            this.button5.Text = "读盘";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSlateGray;
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("隶书", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Location = new System.Drawing.Point(161, 436);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 49);
            this.button4.TabIndex = 2;
            this.button4.Text = "存盘";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.LightSlateGray;
            this.button9.Font = new System.Drawing.Font("隶书", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(72, 823);
            this.button9.Margin = new System.Windows.Forms.Padding(6);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(10, 10);
            this.button9.TabIndex = 0;
            this.button9.Text = "退出";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.Location = new System.Drawing.Point(6, 169);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 1;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.LightSlateGray;
            this.button8.Font = new System.Drawing.Font("隶书", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(72, 639);
            this.button8.Margin = new System.Windows.Forms.Padding(6);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(10, 10);
            this.button8.TabIndex = 0;
            this.button8.Text = "重置";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSlateGray;
            this.button3.Font = new System.Drawing.Font("隶书", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(92, 506);
            this.button3.Margin = new System.Windows.Forms.Padding(6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 49);
            this.button3.TabIndex = 0;
            this.button3.Text = "退出";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LightSlateGray;
            this.button7.Enabled = false;
            this.button7.Font = new System.Drawing.Font("隶书", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(72, 455);
            this.button7.Margin = new System.Windows.Forms.Padding(6);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(10, 10);
            this.button7.TabIndex = 0;
            this.button7.Text = "开始";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSlateGray;
            this.button2.Font = new System.Drawing.Font("隶书", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(159, 334);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 49);
            this.button2.TabIndex = 0;
            this.button2.Text = "重置";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSlateGray;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("隶书", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(28, 232);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "开始";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::五子棋Forms.Properties.Resources._8;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.模式选择ToolStripMenuItem,
            this.功能ToolStripMenuItem,
            this.帮助和说明ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1924, 34);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 模式选择ToolStripMenuItem
            // 
            this.模式选择ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.双人对战ToolStripMenuItem,
            this.人机对战ToolStripMenuItem});
            this.模式选择ToolStripMenuItem.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.模式选择ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.模式选择ToolStripMenuItem.Name = "模式选择ToolStripMenuItem";
            this.模式选择ToolStripMenuItem.Size = new System.Drawing.Size(122, 28);
            this.模式选择ToolStripMenuItem.Text = "模式选择";
            // 
            // 双人对战ToolStripMenuItem
            // 
            this.双人对战ToolStripMenuItem.Name = "双人对战ToolStripMenuItem";
            this.双人对战ToolStripMenuItem.Size = new System.Drawing.Size(186, 28);
            this.双人对战ToolStripMenuItem.Text = "玩家对战";
            this.双人对战ToolStripMenuItem.Click += new System.EventHandler(this.双人对战ToolStripMenuItem_Click);
            // 
            // 人机对战ToolStripMenuItem
            // 
            this.人机对战ToolStripMenuItem.Name = "人机对战ToolStripMenuItem";
            this.人机对战ToolStripMenuItem.Size = new System.Drawing.Size(186, 28);
            this.人机对战ToolStripMenuItem.Text = "人机对战";
            this.人机对战ToolStripMenuItem.Click += new System.EventHandler(this.人机对战ToolStripMenuItem_Click);
            // 
            // 功能ToolStripMenuItem
            // 
            this.功能ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始ToolStripMenuItem,
            this.悔棋ToolStripMenuItem,
            this.重置ToolStripMenuItem,
            this.存盘ToolStripMenuItem,
            this.复盘ToolStripMenuItem,
            this.推出ToolStripMenuItem});
            this.功能ToolStripMenuItem.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.功能ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.功能ToolStripMenuItem.Name = "功能ToolStripMenuItem";
            this.功能ToolStripMenuItem.Size = new System.Drawing.Size(122, 28);
            this.功能ToolStripMenuItem.Text = "功能实现";
            // 
            // 开始ToolStripMenuItem
            // 
            this.开始ToolStripMenuItem.Name = "开始ToolStripMenuItem";
            this.开始ToolStripMenuItem.Size = new System.Drawing.Size(136, 28);
            this.开始ToolStripMenuItem.Text = "开始";
            this.开始ToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // 悔棋ToolStripMenuItem
            // 
            this.悔棋ToolStripMenuItem.Name = "悔棋ToolStripMenuItem";
            this.悔棋ToolStripMenuItem.Size = new System.Drawing.Size(136, 28);
            this.悔棋ToolStripMenuItem.Text = "悔棋";
            this.悔棋ToolStripMenuItem.Click += new System.EventHandler(this.button6_Click);
            // 
            // 重置ToolStripMenuItem
            // 
            this.重置ToolStripMenuItem.Name = "重置ToolStripMenuItem";
            this.重置ToolStripMenuItem.Size = new System.Drawing.Size(136, 28);
            this.重置ToolStripMenuItem.Text = "重置";
            this.重置ToolStripMenuItem.Click += new System.EventHandler(this.button2_Click);
            // 
            // 存盘ToolStripMenuItem
            // 
            this.存盘ToolStripMenuItem.Name = "存盘ToolStripMenuItem";
            this.存盘ToolStripMenuItem.Size = new System.Drawing.Size(136, 28);
            this.存盘ToolStripMenuItem.Text = "存盘";
            this.存盘ToolStripMenuItem.Click += new System.EventHandler(this.button4_Click);
            // 
            // 复盘ToolStripMenuItem
            // 
            this.复盘ToolStripMenuItem.Name = "复盘ToolStripMenuItem";
            this.复盘ToolStripMenuItem.Size = new System.Drawing.Size(136, 28);
            this.复盘ToolStripMenuItem.Text = "复盘";
            this.复盘ToolStripMenuItem.Click += new System.EventHandler(this.button5_Click);
            // 
            // 推出ToolStripMenuItem
            // 
            this.推出ToolStripMenuItem.Name = "推出ToolStripMenuItem";
            this.推出ToolStripMenuItem.Size = new System.Drawing.Size(136, 28);
            this.推出ToolStripMenuItem.Text = "退出";
            this.推出ToolStripMenuItem.Click += new System.EventHandler(this.button3_Click);
            // 
            // 帮助和说明ToolStripMenuItem
            // 
            this.帮助和说明ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帮助ToolStripMenuItem,
            this.说明ToolStripMenuItem});
            this.帮助和说明ToolStripMenuItem.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.帮助和说明ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.帮助和说明ToolStripMenuItem.Name = "帮助和说明ToolStripMenuItem";
            this.帮助和说明ToolStripMenuItem.Size = new System.Drawing.Size(147, 28);
            this.帮助和说明ToolStripMenuItem.Text = "帮助和说明";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(136, 28);
            this.帮助ToolStripMenuItem.Text = "帮助";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // 说明ToolStripMenuItem
            // 
            this.说明ToolStripMenuItem.Name = "说明ToolStripMenuItem";
            this.说明ToolStripMenuItem.Size = new System.Drawing.Size(136, 28);
            this.说明ToolStripMenuItem.Text = "说明";
            this.说明ToolStripMenuItem.Click += new System.EventHandler(this.说明ToolStripMenuItem_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.LightSlateGray;
            this.button13.Font = new System.Drawing.Font("隶书", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button13.ForeColor = System.Drawing.Color.Transparent;
            this.button13.Location = new System.Drawing.Point(161, 232);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(121, 49);
            this.button13.TabIndex = 7;
            this.button13.Text = "复盘";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("隶书", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "欢迎来到五子棋局";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 模式选择ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 双人对战ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 人机对战ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 功能ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开始ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 悔棋ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 存盘ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复盘ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 推出ToolStripMenuItem;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ToolStripMenuItem 帮助和说明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 说明ToolStripMenuItem;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Timer timer2;
    }
}


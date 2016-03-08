namespace WindowsFormsApplication2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SpCom = new System.IO.Ports.SerialPort(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setIntervalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutVAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.xmlSource1 = new Steema.TeeChart.Data.XmlSource();
            this.tChart1 = new Steema.TeeChart.TChart();
            this.label1 = new System.Windows.Forms.Label();
            this.xmlSource2 = new Steema.TeeChart.Data.XmlSource();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.label3 = new System.Windows.Forms.Label();
            this.expand1 = new Steema.TeeChart.Animations.Expand();
            this.axis1 = new Steema.TeeChart.Axis(this.components);
            this.axis2 = new Steema.TeeChart.Axis(this.components);
            this.fastLine1 = new Steema.TeeChart.Styles.FastLine();
            this.fastLine2 = new Steema.TeeChart.Styles.FastLine();
            this.fastLine3 = new Steema.TeeChart.Styles.FastLine();
            this.pageNumber1 = new Steema.TeeChart.Tools.PageNumber();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(447, 497);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 80);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(326, 497);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(103, 80);
            this.textBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(552, 586);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(81, 20);
            this.comboBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(650, 586);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(408, 601);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 25);
            this.button2.TabIndex = 4;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(230, 405);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(737, 586);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Advance";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Lucida Bright", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.setToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1015, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.printToolStripMenuItem,
            this.setIntervalToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.文件ToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // setIntervalToolStripMenuItem
            // 
            this.setIntervalToolStripMenuItem.Name = "setIntervalToolStripMenuItem";
            this.setIntervalToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.setIntervalToolStripMenuItem.Text = "Set Interval";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // setToolStripMenuItem
            // 
            this.setToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cOMSetToolStripMenuItem,
            this.advanceToolStripMenuItem});
            this.setToolStripMenuItem.Name = "setToolStripMenuItem";
            this.setToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.setToolStripMenuItem.Text = "&Set";
            this.setToolStripMenuItem.Click += new System.EventHandler(this.setToolStripMenuItem_Click);
            // 
            // cOMSetToolStripMenuItem
            // 
            this.cOMSetToolStripMenuItem.Name = "cOMSetToolStripMenuItem";
            this.cOMSetToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.cOMSetToolStripMenuItem.Text = "&COM set";
            this.cOMSetToolStripMenuItem.Click += new System.EventHandler(this.cOMSetToolStripMenuItem_Click);
            // 
            // advanceToolStripMenuItem
            // 
            this.advanceToolStripMenuItem.Name = "advanceToolStripMenuItem";
            this.advanceToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.advanceToolStripMenuItem.Text = "&Advance";
            this.advanceToolStripMenuItem.Click += new System.EventHandler(this.advanceToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutVAToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutVAToolStripMenuItem
            // 
            this.aboutVAToolStripMenuItem.Name = "aboutVAToolStripMenuItem";
            this.aboutVAToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.aboutVAToolStripMenuItem.Text = "&About VA";
            this.aboutVAToolStripMenuItem.Click += new System.EventHandler(this.aboutVAToolStripMenuItem_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(737, 552);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "History";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(595, 520);
            this.trackBar1.Maximum = 60;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(113, 45);
            this.trackBar1.SmallChange = 2;
            this.trackBar1.TabIndex = 12;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.Value = 2;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // xmlSource1
            // 
            this.xmlSource1.Chart = null;
            this.xmlSource1.DataMember = "";
            this.xmlSource1.Series = null;
            this.xmlSource1.SeriesNode = "";
            // 
            // tChart1
            // 
            this.tChart1.Animations.Add(this.expand1);
            // 
            // 
            // 
            this.tChart1.Aspect.Chart3DPercent = 5;
            this.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.tChart1.Aspect.View3D = false;
            this.tChart1.Aspect.ZOffset = 0D;
            this.tChart1.Aspect.Zoom = 99;
            this.tChart1.Aspect.ZoomFloat = 99D;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Automatic = false;
            this.tChart1.Axes.Bottom.AutomaticMaximum = false;
            this.tChart1.Axes.Bottom.AutomaticMinimum = false;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Axes.Bottom.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            this.tChart1.Axes.Bottom.Grid.Transparency = 80;
            this.tChart1.Axes.Bottom.Increment = 5.7870370370370373E-05D;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Labels.DateTimeFormat = "yyyy-MM-dd HH:mm:ss";
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Labels.Font.Name = "Times New Roman";
            this.tChart1.Axes.Bottom.Labels.Font.Size = 10;
            this.tChart1.Axes.Bottom.Labels.Font.SizeFloat = 10F;
            this.tChart1.Axes.Bottom.Labels.MultiLine = true;
            this.tChart1.Axes.Bottom.Labels.Style = Steema.TeeChart.AxisLabelStyle.Value;
            this.tChart1.Axes.Bottom.Labels.ValueFormat = "yyyy-MM-dd HH:mm:dd";
            this.tChart1.Axes.Bottom.Maximum = 42275.421217384261D;
            this.tChart1.Axes.Bottom.Minimum = 42179.421217384261D;
            this.tChart1.Axes.Bottom.MinimumOffset = 2;
            this.tChart1.Axes.Bottom.MinimumRound = true;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Ticks.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Axes.Bottom.Ticks.Length = 2;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.TicksInner.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Title.Font.Name = "Times New Roman";
            this.tChart1.Axes.Custom.Add(this.axis1);
            this.tChart1.Axes.Custom.Add(this.axis2);
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Axes.Depth.AxisPen.Width = 1;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Axes.Depth.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Labels.Font.Name = "Times New Roman";
            this.tChart1.Axes.Depth.Labels.Font.Size = 10;
            this.tChart1.Axes.Depth.Labels.Font.SizeFloat = 10F;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Ticks.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Axes.Depth.Ticks.Length = 2;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.TicksInner.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Title.Font.Name = "Times New Roman";
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Axes.DepthTop.AxisPen.Width = 1;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Axes.DepthTop.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Labels.Font.Name = "Times New Roman";
            this.tChart1.Axes.DepthTop.Labels.Font.Size = 10;
            this.tChart1.Axes.DepthTop.Labels.Font.SizeFloat = 10F;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Ticks.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Axes.DepthTop.Ticks.Length = 2;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.TicksInner.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Title.Font.Name = "Times New Roman";
            // 
            // 
            // 
            this.tChart1.Axes.Left.Automatic = false;
            this.tChart1.Axes.Left.AutomaticMaximum = false;
            this.tChart1.Axes.Left.AutomaticMinimum = false;
            // 
            // 
            // 
            this.tChart1.Axes.Left.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Axes.Left.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            this.tChart1.Axes.Left.Grid.Transparency = 80;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Labels.Align = Steema.TeeChart.AxisLabelAlign.Opposite;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Labels.Font.Name = "Times New Roman";
            this.tChart1.Axes.Left.Labels.Font.Size = 10;
            this.tChart1.Axes.Left.Labels.Font.SizeFloat = 10F;
            this.tChart1.Axes.Left.Labels.Style = Steema.TeeChart.AxisLabelStyle.Value;
            this.tChart1.Axes.Left.Maximum = 1290D;
            this.tChart1.Axes.Left.Minimum = 624D;
            // 
            // 
            // 
            this.tChart1.Axes.Left.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Ticks.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tChart1.Axes.Left.Ticks.Length = 2;
            // 
            // 
            // 
            this.tChart1.Axes.Left.TicksInner.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            this.tChart1.Axes.Left.Title.Caption = "Conductivity";
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.tChart1.Axes.Left.Title.Font.Name = "Times New Roman";
            this.tChart1.Axes.Left.Title.Lines = new string[] {
        "Conductivity"};
            this.tChart1.Axes.Left.Title.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Axes.Right.AxisPen.Width = 1;
            // 
            // 
            // 
            this.tChart1.Axes.Right.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Axes.Right.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Labels.Font.Name = "Times New Roman";
            this.tChart1.Axes.Right.Labels.Font.Size = 10;
            this.tChart1.Axes.Right.Labels.Font.SizeFloat = 10F;
            // 
            // 
            // 
            this.tChart1.Axes.Right.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Right.Ticks.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Axes.Right.Ticks.Length = 2;
            // 
            // 
            // 
            this.tChart1.Axes.Right.TicksInner.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Title.Font.Name = "Times New Roman";
            this.tChart1.Axes.Right.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Axes.Top.AxisPen.Width = 1;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Axes.Top.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Labels.Font.Name = "Times New Roman";
            this.tChart1.Axes.Top.Labels.Font.Size = 10;
            this.tChart1.Axes.Top.Labels.Font.SizeFloat = 10F;
            // 
            // 
            // 
            this.tChart1.Axes.Top.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Ticks.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Axes.Top.Ticks.Length = 2;
            // 
            // 
            // 
            this.tChart1.Axes.Top.TicksInner.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Title.Font.Name = "Times New Roman";
            this.tChart1.Axes.Top.Visible = false;
            this.tChart1.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.tChart1.Header.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Header.Brush.Gradient.SigmaFocus = 0F;
            this.tChart1.Header.Brush.Gradient.SigmaScale = 0F;
            this.tChart1.Header.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Header.Font.Name = "Times New Roman";
            this.tChart1.Header.Font.Size = 12;
            this.tChart1.Header.Font.SizeFloat = 12F;
            this.tChart1.Header.Lines = new string[] {
        "Conductivity/Temp/Total L"};
            // 
            // 
            // 
            this.tChart1.Header.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.tChart1.Header.Shadow.Visible = true;
            // 
            // 
            // 
            this.tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Top;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.tChart1.Legend.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Legend.Brush.Gradient.SigmaFocus = 0F;
            this.tChart1.Legend.Brush.Gradient.SigmaScale = 0F;
            this.tChart1.Legend.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Legend.CheckBoxes = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tChart1.Legend.Font.Name = "Times New Roman";
            this.tChart1.Legend.Font.Size = 10;
            this.tChart1.Legend.Font.SizeFloat = 10F;
            this.tChart1.Legend.FontSeriesColor = true;
            this.tChart1.Legend.LegendStyle = Steema.TeeChart.LegendStyles.Series;
            // 
            // 
            // 
            this.tChart1.Legend.Pen.Visible = false;
            // 
            // 
            // 
            this.tChart1.Legend.Symbol.DefaultPen = false;
            // 
            // 
            // 
            this.tChart1.Legend.Symbol.Pen.Visible = false;
            this.tChart1.Legend.Symbol.Width = 45;
            this.tChart1.Legend.TextSymbolGap = 11;
            this.tChart1.Legend.TopLeftPos = 45;
            this.tChart1.Legend.Transparent = true;
            this.tChart1.Legend.VertMargin = 1;
            this.tChart1.Legend.VertSpacing = 17;
            this.tChart1.Location = new System.Drawing.Point(259, 46);
            this.tChart1.Name = "tChart1";
            // 
            // 
            // 
            this.tChart1.Page.AutoScale = true;
            this.tChart1.Page.MaxPointsPerPage = 100;
            this.tChart1.Page.ScaleLastPage = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Bevel.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.tChart1.Panel.Brush.Gradient.GammaCorrection = true;
            this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Panel.Brush.Gradient.SigmaFocus = 0F;
            this.tChart1.Panel.Brush.Gradient.SigmaScale = 0F;
            this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Panel.Brush.Gradient.Transparency = 14;
            this.tChart1.Panel.Brush.Gradient.UseMiddle = false;
            this.tChart1.Panel.Brush.Gradient.Visible = false;
            this.tChart1.Panel.Brush.Solid = false;
            this.tChart1.Panel.Brush.Style = System.Drawing.Drawing2D.HatchStyle.DarkHorizontal;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.ImageBevel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Panel.MarginBottom = 3D;
            this.tChart1.Panel.MarginLeft = 0D;
            this.tChart1.Panel.MarginRight = 11D;
            this.tChart1.Panel.MarginTop = 1D;
            // 
            // 
            // 
            this.tChart1.Panel.Pen.EndCap = System.Drawing.Drawing2D.LineCap.Square;
            this.tChart1.Panel.Pen.Transparency = 1;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Shadow.Brush.Gradient.Visible = true;
            this.tChart1.Panel.Shadow.Brush.Solid = false;
            this.tChart1.Panel.Transparent = true;
            // 
            // 
            // 
            this.tChart1.Panning.Allow = Steema.TeeChart.ScrollModes.Horizontal;
            this.tChart1.Series.Add(this.fastLine1);
            this.tChart1.Series.Add(this.fastLine2);
            this.tChart1.Series.Add(this.fastLine3);
            this.tChart1.Size = new System.Drawing.Size(744, 437);
            this.tChart1.TabIndex = 14;
            this.tChart1.Tools.Add(this.pageNumber1);
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.tChart1.Walls.Back.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.tChart1.Walls.Back.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Walls.Back.Brush.Gradient.SigmaFocus = 0F;
            this.tChart1.Walls.Back.Brush.Gradient.SigmaScale = 0F;
            this.tChart1.Walls.Back.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Walls.Back.Brush.Gradient.Visible = false;
            this.tChart1.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.tChart1.Walls.Bottom.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Walls.Bottom.Brush.Gradient.SigmaFocus = 0F;
            this.tChart1.Walls.Bottom.Brush.Gradient.SigmaScale = 0F;
            this.tChart1.Walls.Bottom.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.tChart1.Walls.Left.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.tChart1.Walls.Left.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Walls.Left.Brush.Gradient.SigmaFocus = 0F;
            this.tChart1.Walls.Left.Brush.Gradient.SigmaScale = 0F;
            this.tChart1.Walls.Left.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.tChart1.Walls.Right.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.tChart1.Walls.Right.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Walls.Right.Brush.Gradient.SigmaFocus = 0F;
            this.tChart1.Walls.Right.Brush.Gradient.SigmaScale = 0F;
            this.tChart1.Walls.Right.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Zoom.Brush.Solid = false;
            this.tChart1.Click += new System.EventHandler(this.tChart1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 614);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "count";
            // 
            // xmlSource2
            // 
            this.xmlSource2.Chart = null;
            this.xmlSource2.DataMember = "";
            this.xmlSource2.Series = null;
            this.xmlSource2.SeriesNode = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(737, 521);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(69, 22);
            this.button5.TabIndex = 16;
            this.button5.Text = "Read";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(605, 553);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "Interval:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(687, 553);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "S";
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(639, 565);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "label3";
            // 
            // expand1
            // 
            this.expand1.Target = Steema.TeeChart.ChartClickedPartStyle.Series;
            this.expand1.Trigger = Steema.TeeChart.Animations.AnimationTrigger.MouseClick;
            // 
            // axis1
            // 
            this.axis1.Automatic = false;
            this.axis1.AutomaticMaximum = false;
            this.axis1.AutomaticMinimum = false;
            // 
            // 
            // 
            this.axis1.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            this.axis1.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.axis1.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            this.axis1.Grid.Transparency = 85;
            this.axis1.Grid.Visible = false;
            this.axis1.Horizontal = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.axis1.Labels.Font.Name = "Times New Roman";
            this.axis1.Labels.Font.Size = 10;
            this.axis1.Labels.Font.SizeFloat = 10F;
            this.axis1.Maximum = 1025D;
            this.axis1.Minimum = 551D;
            // 
            // 
            // 
            this.axis1.MinorTicks.Visible = false;
            this.axis1.OtherSide = true;
            this.axis1.PositionUnits = Steema.TeeChart.PositionUnits.Pixels;
            // 
            // 
            // 
            this.axis1.Ticks.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.axis1.Ticks.Length = 2;
            // 
            // 
            // 
            this.axis1.TicksInner.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            this.axis1.Title.Angle = 90;
            this.axis1.Title.Caption = "Temperature";
            // 
            // 
            // 
            this.axis1.Title.Font.Name = "Times New Roman";
            this.axis1.Title.Lines = new string[] {
        "Temperature"};
            this.axis1.Title.Visible = false;
            this.axis1.ZPosition = 0D;
            // 
            // axis2
            // 
            this.axis2.Automatic = false;
            this.axis2.AutomaticMaximum = false;
            this.axis2.AutomaticMinimum = false;
            // 
            // 
            // 
            this.axis2.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            this.axis2.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.axis2.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            this.axis2.Grid.Visible = false;
            this.axis2.Horizontal = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.axis2.Labels.Font.Name = "Times New Roman";
            this.axis2.Labels.Font.Size = 10;
            this.axis2.Labels.Font.SizeFloat = 10F;
            this.axis2.Maximum = 1056D;
            this.axis2.Minimum = 783D;
            // 
            // 
            // 
            this.axis2.MinorTicks.Visible = false;
            this.axis2.OtherSide = true;
            this.axis2.PositionUnits = Steema.TeeChart.PositionUnits.Pixels;
            this.axis2.RelativePosition = -40D;
            // 
            // 
            // 
            this.axis2.Ticks.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.axis2.Ticks.Length = 2;
            // 
            // 
            // 
            this.axis2.TicksInner.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            this.axis2.Title.Angle = 90;
            this.axis2.Title.Caption = "Total L";
            // 
            // 
            // 
            this.axis2.Title.Font.Name = "Times New Roman";
            this.axis2.Title.Lines = new string[] {
        "Total L"};
            this.axis2.Title.Visible = false;
            this.axis2.ZPosition = 0D;
            // 
            // fastLine1
            // 
            this.fastLine1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.fastLine1.ColorEach = false;
            this.fastLine1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.fastLine1.DrawAllPoints = false;
            // 
            // 
            // 
            this.fastLine1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.fastLine1.LinePen.Width = 2;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine1.Marks.Arrow.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine1.Marks.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.fastLine1.Marks.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fastLine1.Marks.Brush.Gradient.SigmaFocus = 0F;
            this.fastLine1.Marks.Brush.Gradient.SigmaScale = 0F;
            this.fastLine1.Marks.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fastLine1.Marks.Brush.Visible = false;
            // 
            // 
            // 
            this.fastLine1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.fastLine1.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.fastLine1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.fastLine1.Marks.Callout.Distance = 0;
            this.fastLine1.Marks.Callout.Draw3D = false;
            this.fastLine1.Marks.Callout.Length = 10;
            this.fastLine1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            // 
            // 
            // 
            this.fastLine1.Marks.Font.Name = "Times New Roman";
            this.fastLine1.Marks.Font.Size = 10;
            this.fastLine1.Marks.Font.SizeFloat = 10F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine1.Marks.Symbol.Shadow.Visible = false;
            this.fastLine1.Marks.Transparent = true;
            this.fastLine1.Title = "Conductivity";
            this.fastLine1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            // 
            // 
            // 
            this.fastLine1.XValues.DataMember = "X";
            this.fastLine1.XValues.DateTime = true;
            this.fastLine1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.fastLine1.YValues.DataMember = "Y";
            // 
            // fastLine2
            // 
            this.fastLine2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fastLine2.ColorEach = false;
            this.fastLine2.CustomVertAxis = this.axis1;
            // 
            // 
            // 
            this.fastLine2.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fastLine2.LinePen.Width = 2;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine2.Marks.Arrow.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine2.Marks.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.fastLine2.Marks.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fastLine2.Marks.Brush.Gradient.SigmaFocus = 0F;
            this.fastLine2.Marks.Brush.Gradient.SigmaScale = 0F;
            this.fastLine2.Marks.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fastLine2.Marks.Brush.Visible = false;
            // 
            // 
            // 
            this.fastLine2.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.fastLine2.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.fastLine2.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.fastLine2.Marks.Callout.Distance = 0;
            this.fastLine2.Marks.Callout.Draw3D = false;
            this.fastLine2.Marks.Callout.Length = 10;
            this.fastLine2.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            // 
            // 
            // 
            this.fastLine2.Marks.Font.Name = "Times New Roman";
            this.fastLine2.Marks.Font.Size = 10;
            this.fastLine2.Marks.Font.SizeFloat = 10F;
            this.fastLine2.Marks.Transparent = true;
            this.fastLine2.Title = "Temp";
            this.fastLine2.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            this.fastLine2.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Custom;
            // 
            // 
            // 
            this.fastLine2.XValues.DataMember = "X";
            this.fastLine2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.fastLine2.YValues.DataMember = "Y";
            // 
            // fastLine3
            // 
            this.fastLine3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.fastLine3.ColorEach = false;
            this.fastLine3.CustomVertAxis = this.axis2;
            // 
            // 
            // 
            this.fastLine3.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.fastLine3.LinePen.Width = 2;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine3.Marks.Arrow.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine3.Marks.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.fastLine3.Marks.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fastLine3.Marks.Brush.Gradient.SigmaFocus = 0F;
            this.fastLine3.Marks.Brush.Gradient.SigmaScale = 0F;
            this.fastLine3.Marks.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fastLine3.Marks.Brush.Visible = false;
            // 
            // 
            // 
            this.fastLine3.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.fastLine3.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.fastLine3.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.fastLine3.Marks.Callout.Distance = 0;
            this.fastLine3.Marks.Callout.Draw3D = false;
            this.fastLine3.Marks.Callout.Length = 10;
            this.fastLine3.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.fastLine3.Marks.DrawEvery = 10;
            // 
            // 
            // 
            this.fastLine3.Marks.Font.Name = "Times New Roman";
            this.fastLine3.Marks.Font.Size = 10;
            this.fastLine3.Marks.Font.SizeFloat = 10F;
            this.fastLine3.Marks.Transparent = true;
            this.fastLine3.Title = "Total L";
            this.fastLine3.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            this.fastLine3.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Custom;
            // 
            // 
            // 
            this.fastLine3.XValues.DataMember = "X";
            this.fastLine3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.fastLine3.YValues.DataMember = "Y";
            // 
            // pageNumber1
            // 
            this.pageNumber1.AutoSize = true;
            // 
            // 
            // 
            this.pageNumber1.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.pageNumber1.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.pageNumber1.Callout.Brush.Color = System.Drawing.Color.Black;
            this.pageNumber1.Callout.Distance = 0;
            this.pageNumber1.Callout.Draw3D = false;
            this.pageNumber1.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.pageNumber1.Callout.XPosition = 0;
            this.pageNumber1.Callout.YPosition = 0;
            this.pageNumber1.Callout.ZPosition = 0;
            this.pageNumber1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pageNumber1.Format = "Page {0} of {1}";
            // 
            // 
            // 
            this.pageNumber1.Shape.Lines = new string[] {
        "Page {0} of {1}"};
            this.pageNumber1.Text = "Page {0} of {1}";
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(WindowsFormsApplication2.Form1);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Swis721 Blk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(31, 472);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(143, 34);
            this.btnStart.TabIndex = 21;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Font = new System.Drawing.Font("Swis721 Blk BT", 12F);
            this.btnHistory.Location = new System.Drawing.Point(32, 529);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(141, 36);
            this.btnHistory.TabIndex = 22;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 647);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tChart1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "CONDUCTIVITY FLOW CONTROLLER";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.IO.Ports.SerialPort SpCom;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem setIntervalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutVAToolStripMenuItem;
        private System.Windows.Forms.TrackBar trackBar1;
        private Steema.TeeChart.Data.XmlSource xmlSource1;
        private Steema.TeeChart.TChart tChart1;
        private Steema.TeeChart.Styles.FastLine fastLine1;
        private Steema.TeeChart.Axis axis1;
        private Steema.TeeChart.Styles.FastLine fastLine2;
        private Steema.TeeChart.Axis axis2;
        private Steema.TeeChart.Styles.FastLine fastLine3;
        private System.Windows.Forms.Label label1;
        private Steema.TeeChart.Tools.PageNumber pageNumber1;
        private Steema.TeeChart.Data.XmlSource xmlSource2;
        private Steema.TeeChart.Animations.Expand expand1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer2;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.ToolStripMenuItem setToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOMSetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advanceToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnHistory;
    }
}


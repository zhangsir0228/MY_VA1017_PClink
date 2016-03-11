using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;//正则表达式命名空间，用于字符串截取
using System.IO;
using System.Xml;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApplication2
{


    //public class MyGlobleVar
    //{
    //    public static string   MyField = null;//最好初始化
    //     public static String  CalFact = "CAL:FACT:";
    //     public static String  CalMod  = "CAL:MOD:";
    //     public static String  CalSN   = "CAL:SN:";
    //     public static String  CalVer  = "CAL:VER:";
    //     public static int FormID;
    //    public static void MyMethod()
    //    {
    //    }
    //}
    /// <summary> 
    /// 主窗体接口 
    /// </summary> 
    public interface IMdiParent
    {
        void ParentFoo();
    }
    /// <summary> 
    /// 子窗体接口 
    /// </summary> 
    public interface IMyChildForm
    {
        void Foo();
    }

    public partial class Form1 : Form, IMdiParent
    {
        string Vendor = "";
        string Model = "";
        string SN = "";
        int refreshModel = 0;

        string saveFileName;
        String  strT;
        string IDN = "*IDN?\r\n";
        string  B_READ = "READ?\r\n";
        String  B_SN = "SN:";
        String  B_DA = "DA:";  
        string  PortTesting = "null";//改标志大于0时表示当前正在测试数值对应的COMx端口  

        string  set_COMport = "";//COMport from set form
        int     set_Interval = 2;//interval from set form

        MatchCollection vMatchs;
        String[] vfloats = new String[100];
        int     PortIsOpen = 0;
        int trackBar1_Pos = 2000;
        int ReDraw = 0;//refresh the fastline1
        int DateCount = 0;     
        //double getxmlre;
        DateTime StartDate;
        double TDS_max = 0, TDS_min = 0;
        double Temp_max = 0,Temp_min = 0;
        double L_max = 0, L_min = 0;

        string[] Exist_COM = new string[30];//存储软件启动获取到的已有的串口列表

        //float  HIST_data[2000][4];//用于存放历史数据
        string HIST_temp;//暂存每天的历史数据
        int     HIST_day;//用于历史数据的计数，存放在历史数据数组的第一位
   
        string[] HIS_day = new string[2000];
        string[] HIS_con = new string[2000];
        string[] HIS_tmp = new string[2000];
        string[] HIS_ToL = new string[2000];
        int HIS_Nday = 0;//count HIS data number
        int HIS_loop = 0;   //for get hist data loop

        int IsRead = 0;//is reading
        int HIS_readed;//got the HIS data
        int Data_recevie = 0;

        int workState = 0;//1 read   2:history

        int Reconfig = 0;//Reconfig the comport.

        static int Start = 0;
        static int NormalRead = 1;
        static int HistoryRead = 2;

        //test data
        double[] tmp_Yvalue = { 1.2, 1.5, 1.9, 2.6, 2.9, 2.7, 3, 3.5, 4.8, 1.9, 8.5, 8.9, 8.6, 5.9, 5.7, 11, 13.5, 14.8, 11.2, 11.5, 11.9, 12.6, 12.9, 12.7, 13, 13.5, 14.8, 11.2, 11.5, 11.9, 22.6, 22.9, 22.7, 23, 23.5, 24.8 };
        string[] tmp_Yvalue1 = { "1.2", "1.5", "1.9", "2.6", "2.9", "2.7", "3", "3.5", "4.8", "1.2", "1.5", "1.9", "2.6", "2.9", "2.7", "3", "3.5", "8.6", "5.9", "5.7", "11", "13.5", "14.8", "11.2", "11.5", "11.9", "12.6", "12.9", "12.7", "13", "13.5", "14.8" };
        string[] tmp_Xvalue1 = { "aa", "bb", "cc", "dd", "tys", "bbs", "cca", "dda", "vv", "tt", "ii", "yy", "jk", "cc", "dd", "hh", "rr", "cc", "dd", "ss", "tt", "ii", "cc", "dd", "aa", "bb", "jj", "cc", "dd", "pp", "tt", "ii" };
        Steema.TeeChart.TChart te = new Steema.TeeChart.TChart();



        //private TeeChart te = new TeeChart();
        //String numS = "-1234";
        //int num = 0;
        //string pipei = "1 2";
        //float[] vInts = null;
        //保存主窗口对象
        //public static Form1 pCurrentWin = null; 
#region 测试无边框拖动
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        private extern static bool ReleaseCapture();
        [DllImport("user32.dll")]
        private extern static int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();//释放窗体的鼠标焦点
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                //模拟点击窗体的Title
            }
        }
#endregion

        public Form1()
        {
            InitializeComponent();
            //InitializeChart();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetFlag(Start);//配置初始各状态位

            tChart1.Zoom.Allow = true;


            #region Comport Init
            int loop = 0;
            foreach (string s in SerialPort.GetPortNames())
            {                           
                SerialPort tempPort = new SerialPort(s);
                try
                {
                    tempPort.Open();
                    if (tempPort.IsOpen)//跳过已经打开的端口
                    {
                        tempPort.Close();
                        loop++;
                        Exist_COM[loop] = s;
                        if (Exist_COM[loop] != null) { Exist_COM[0] = loop.ToString(); }                       
                    }
                    else{; }                
                }
                catch//若已经打开则跳过该端口
                {; }        
            }

            SpCom.PortName = "COM3";
            SpCom.BaudRate = 9600;
            SpCom.ReadBufferSize = 12000;

            SpCom.DataReceived += new SerialDataReceivedEventHandler(SpCom_DataReceived);

            timer2.Enabled = false;

            #endregion

            #region 配置初始坐标信息
            StartDate = DateTime.Now;          

            fastLine1.Add(StartDate.ToOADate(), 50);//初始TDS
            fastLine2.Add(StartDate.ToOADate(), 20);//初始Temp
            fastLine3.Add(StartDate.ToOADate(), 0);//初始流量

            fastLine1.GetVertAxis.SetMinMax(0, 500);
            fastLine2.GetVertAxis.SetMinMax(0, 50);
            fastLine3.GetVertAxis.SetMinMax(0, 500);

            TDS_max = 500; TDS_min = 0;
            Temp_max = 50;Temp_min = 0;
            L_max = 500; L_min = 0;

            fastLine1.GetHorizAxis.SetMinMax(StartDate, StartDate.AddSeconds(120));
            //getxmlre=fastLine1.

            #endregion

            #region 生成XML文件
            try
            {
                saveFileName = DateTime.Now.ToString("yyyyMMdd hh_mm_ss")+".xml";//月份小写mm不对
                XmlDocument xmlNew = new XmlDocument(); // 创建dom对象
                string sXml = "<?xml version=\"1.0\" encoding=\"GB2312\"?>";
                sXml += "<root>";
                sXml += "<date>";
                sXml += "<cond>0</cond>";	//1
                sXml += "<tmp>20</tmp>";			            //2	
                sXml += "<total_L>0</total_L>";		        //3
                sXml += "<day>null</day>";			            //4
                sXml += "<time>" + saveFileName + "</time>";	//5
                sXml += "</date>";
                sXml += "</root>";   
                xmlNew.LoadXml(sXml);
                if (!Directory.Exists("DateRecive"))//若文件夹不存在则新建文件夹   
                {
                    Directory.CreateDirectory("DateRecive"); //新建文件86夹   
                }
                xmlNew.Save("DateRecive//" + saveFileName); // 保存文件
                label1.Text = "Successfully generated[" + saveFileName + "]!";
                this.tChart1.Axes.Bottom.Minimum = 0; //saveFileName;
                this.tChart1.Axes.Bottom.Maximum = 15;
            }
            catch (Exception)
            {
                label1.Text = "Failed to generate .XML file!";
            }
            #endregion

            #region load xml
            DataSet xmlDs = new DataSet();
            try
            {
                xmlDs.ReadXml("DateRecive//"+saveFileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            this.dataGridView1.DataSource = xmlDs.Tables[0].DefaultView;
            #endregion

            #region test teechart
            ////some sample data for the pyramids...
            //axTChart1.Series(0).FillSampleValues(8);

            //// change pyramids cursor...
            //axTChart1.Series(0).Cursor = 2020;

            //// do not allow zoom and scroll
            //axTChart1.Zoom.Enable = false;
            //axTChart1.Scroll.Enable = TeeChart.EChartScroll.pmNone;
            //#endregion
           #region 测试chart
           // float[][] data = new float[3][];
           // //第一条数据
           // data[0] = new float[10] { 1.3f, 2.5f, 2.1f, 3.3f, 2.8f, 3.9f, 4.3f, 3.6f, 4.2f, 3.6f };
           // //第二条数据
           // data[1] = new float[12] { -2f, -1.3f, 0.1f, 0.5f, -1.5f, 0.7f, 1f, 1.4f, 1.9f, 2f, 2.6f, 3.1f };
           // //第三条数据
           // data[2] = new float[10] { 7.8f, 9.2f, 6.5f, 8.3f, 9.0f, 5.9f, 6.3f, 7.2f, 8.8f, 9.8f };

           // for (int i = 0; i < data.Length; i++)
           // {
           //     //横坐标时间
           //     DateTime dt = DateTime.Now.Date;
           //     Series series = this.SetSeriesStyle(i);
           //     for (int j = 0; j < data[i].Length; j++)
           //     {
           //         series.Points.AddXY(dt, data[i][j]);
           //         dt = dt.AddDays(1);
           //     }
           //     this.chart1.Series.Add(series);
           // }
           #endregion
            //string sss = "DA:1234 us/cm,56.7 degC,12345 L/r/n";
            //MatchCollection vMatchs = Regex.Matches(sss, @"\d+\.\d+");
            //float[] vfloats = new float[vMatchs.Count];
            //for (int i = 0; i < vMatchs.Count; i++)
            //{
            //    vfloats[i] = float.Parse(vMatchs[i].Value);
            //}
           

            //num=int.Parse(numS);//测试字符转数组
            //SpCom.Open();
            ////新建一个线程
            //Thread newthread = new Thread(new ThreadStart(BackgroundProcess));
            //newthread.Start(); 
                

#endregion
        }

        private void AnimateSeries(Steema.TeeChart.TChart chart)
        {
            double newX, newY;

            chart.AutoRepaint = false;

            /// <summary>
            /// 绘画坐标点超过50个时将实时更新X时间坐标
            /// </summary>
            //while (this.fastLine1.Count > 15)
            //{
            //    //this.fastLine1.Delete(0);
            //    fastLine1.GetHorizAxis.SetMinMax(DateTime.Now.AddSeconds(-15), DateTime.Now.AddSeconds(+100));
            //}

            newX = DateTime.Now.ToOADate();
            newY = double.Parse(vfloats[0]);
            if (Math.Abs(newY) > 1.0e+4) newY = 0.0;
            #region 动态调整坐标轴
         
            if (double.Parse(vfloats[0]) > TDS_max)//TDS坐标
            {
                TDS_max = double.Parse(vfloats[0]);
                fastLine1.GetVertAxis.SetMinMax(TDS_min, TDS_max + TDS_max/2);//防止显示数据在最上面
            }
            else if (double.Parse(vfloats[0]) < TDS_min)
            {
                TDS_min = double.Parse(vfloats[0]);
                fastLine1.GetVertAxis.SetMinMax(TDS_min, TDS_max+500);
            }
            if (double.Parse(vfloats[1]) > Temp_max)//temp坐标
            {
                Temp_max = double.Parse(vfloats[1]);
                fastLine2.GetVertAxis.SetMinMax(Temp_min, Temp_max+5);
            }
            else if (double.Parse(vfloats[1]) < Temp_min)
            {
                Temp_min = double.Parse(vfloats[1]);
                fastLine2.GetVertAxis.SetMinMax(Temp_min, Temp_max+5);
            }
            if (double.Parse(vfloats[2]) > L_max)//L坐标
            {
                L_max = double.Parse(vfloats[2]);
                fastLine3.GetVertAxis.SetMinMax(L_min, L_max+50);
            }
            else if (double.Parse(vfloats[2]) < TDS_min)
            {
                L_min = double.Parse(vfloats[2]);
                fastLine3.GetVertAxis.SetMinMax(L_min, L_max+50);
            }

            #endregion

            fastLine1.Add(newX, newY);//新增数据绘制部分
            newY = double.Parse(vfloats[1]);
            fastLine2.Add(newX, newY);
            newY = double.Parse(vfloats[2]);
            fastLine3.Add(newX, newY);
            
            if (((this.fastLine1.Count) % 20) == 0)//每二十个数据更新一次坐标
            { fastLine1.GetHorizAxis.SetMinMax(StartDate, DateTime.Now.AddSeconds(SetForm_interval*(20+ this.fastLine1.Count*0.05))); 
            }
            

            chart.AutoRepaint = true;
            chart.Refresh();
        }

        private void AnimateSeriesHIST(Steema.TeeChart.TChart chart,int loop)
        {

            double newX, newY;

            chart.AutoRepaint = false;

            fastLine1.GetHorizAxis.SetMinMax(1, loop+2);
            /// <summary>
            /// 绘画坐标点超过50个时将实时更新X时间坐标
            /// </summary>
            //while (this.fastLine1.Count > 15)
            //{
            //    //this.fastLine1.Delete(0);
            //    fastLine1.GetHorizAxis.SetMinMax(DateTime.Now.AddSeconds(-15), DateTime.Now.AddSeconds(+100));
            //}

            newX = loop;
            newY = double.Parse(HIS_con[loop]);
            if (Math.Abs(newY) > 1.0e+4) newY = 0.0;
            #region 动态调整坐标轴

            if (double.Parse(HIS_con[loop]) > TDS_max)//TDS坐标
            {
                TDS_max = double.Parse(HIS_con[loop]);
                fastLine1.GetVertAxis.SetMinMax(TDS_min, TDS_max + TDS_max / 2);//防止显示数据在最上面
            }
            else if (double.Parse(HIS_con[loop]) < TDS_min)
            {
                TDS_min = double.Parse(HIS_con[loop]);
                fastLine1.GetVertAxis.SetMinMax(TDS_min, TDS_max + 500);
            }
            if (double.Parse(HIS_tmp[loop]) > Temp_max)//temp坐标
            {
                Temp_max = double.Parse(HIS_tmp[loop]);
                fastLine2.GetVertAxis.SetMinMax(Temp_min, Temp_max + 5);
            }
            else if (double.Parse(HIS_tmp[loop]) < Temp_min)
            {
                Temp_min = double.Parse(HIS_tmp[loop]);
                fastLine2.GetVertAxis.SetMinMax(Temp_min, Temp_max + 5);
            }
            if (double.Parse(HIS_ToL[loop]) > L_max)//L坐标
            {
                L_max = double.Parse(HIS_ToL[loop]);
                fastLine3.GetVertAxis.SetMinMax(L_min, L_max + 50);
            }
            else if (double.Parse(HIS_ToL[loop]) < TDS_min)
            {
                L_min = double.Parse(HIS_ToL[loop]);
                fastLine3.GetVertAxis.SetMinMax(L_min, L_max + 50);
            }

            #endregion

            
            fastLine1.Add(newX, newY);//新增数据绘制部分
            newY = double.Parse(HIS_tmp[loop]);
            fastLine2.Add(newX, newY);
            newY = double.Parse(HIS_ToL[loop]);
            fastLine3.Add(newX, newY);

            //if (this.fastLine1.Count > 20)
            //{
            //    fastLine1.GetHorizAxis.SetMinMax(1, loop);
            //}
            if (((this.fastLine1.Count) % 20) == 0)//每二十个数据更新一次坐标
            {
                fastLine1.GetHorizAxis.SetMinMax(StartDate, DateTime.Now.AddSeconds(SetForm_interval * (20 + this.fastLine1.Count * 0.05)));
            }

            chart.AutoRepaint = true;
            chart.Refresh();
        }

        #region 测试chart的函数
        //private void chart1_GetToolTipText(object sender, ToolTipEventArgs e)
        //{
        //    if (e.HitTestResult.ChartElementType == ChartElementType.DataPoint)
        //    {
        //        int i = e.HitTestResult.PointIndex;
        //        DataPoint dp = e.HitTestResult.Series.Points[i];
        //        e.Text = string.Format("时间:{0};数值:{1:F1} ", DateTime.FromOADate(dp.XValue), dp.YValues[0]);
        //    }
        //}

        ///// <summary>
        ///// 初始化Char控件样式
        ///// </summary>
        //public void InitializeChart()
        //{
        //    #region 设置图表的属性
        //    //图表的背景色
        //    chart1.BackColor = Color.FromArgb(211, 223, 240);
        //    //图表背景色的渐变方式
        //    chart1.BackGradientStyle = GradientStyle.TopBottom;
        //    //图表的边框颜色、
        //    chart1.BorderlineColor = Color.FromArgb(26, 59, 105);
        //    //图表的边框线条样式
        //    chart1.BorderlineDashStyle = ChartDashStyle.Solid;
        //    //图表边框线条的宽度
        //    chart1.BorderlineWidth = 2;
        //    //图表边框的皮肤
        //    chart1.BorderSkin.SkinStyle = BorderSkinStyle.Emboss;
        //    #endregion

        //    #region 设置图表的Title           
        //    Title title = new Title();
        //    //标题内容
        //    title.Text = "Recevied Date";
        //    //标题的字体
        //    title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12, FontStyle.Bold);
        //    //标题字体颜色
        //    title.ForeColor = Color.FromArgb(26, 59, 105);
        //    //标题阴影颜色
        //    title.ShadowColor = Color.FromArgb(32, 0, 0, 0);
        //    //标题阴影偏移量
        //    title.ShadowOffset = 3;

        //    chart1.Titles.Add(title);
        //    #endregion

        //    #region 设置图表区属性
        //    //图表区的名字
        //    ChartArea chartArea = new ChartArea("Default");
        //    //背景色
        //    chartArea.BackColor = Color.FromArgb(64, 165, 191, 228);
        //    //背景渐变方式
        //    chartArea.BackGradientStyle = GradientStyle.TopBottom;
        //    //渐变和阴影的辅助背景色
        //    chartArea.BackSecondaryColor = Color.White;
        //    //边框颜色
        //    chartArea.BorderColor = Color.FromArgb(64, 64, 64, 64);
        //    //阴影颜色
        //    chartArea.ShadowColor = Color.Transparent;

        //    //设置X轴和Y轴线条的颜色和宽度
        //    chartArea.AxisX.LineColor = Color.FromArgb(64, 64, 64, 64);
        //    chartArea.AxisX.LineWidth = 1;
        //    chartArea.AxisY.LineColor = Color.FromArgb(64, 64, 64, 64);
        //    chartArea.AxisY.LineWidth = 1;

        //    //设置X轴和Y轴的标题
        //    chartArea.AxisX.Title = "Time";
        //    chartArea.AxisY.Title = "Value";

        //    //设置图表区网格横纵线条的颜色和宽度
        //    chartArea.AxisX.MajorGrid.LineColor = Color.FromArgb(64, 64, 64, 64);
        //    chartArea.AxisX.MajorGrid.LineWidth = 1;
        //    chartArea.AxisY.MajorGrid.LineColor = Color.FromArgb(64, 64, 64, 64);
        //    chartArea.AxisY.MajorGrid.LineWidth = 1;

        //    chart1.ChartAreas.Add(chartArea);
        //    #endregion

        //    #region 图例及图例的位置
        //    Legend legend = new Legend();
        //    legend.Alignment = StringAlignment.Center;
        //    legend.Docking = Docking.Bottom;

        //    this.chart1.Legends.Add(legend);
        //    #endregion
        //}

        ////设置Series样式
        //private Series SetSeriesStyle(int i)
        //{
        //    Series series = new Series(string.Format("第{0}条数据", i + 1));

        //    //Series的类型
        //    series.ChartType = SeriesChartType.Line;
        //    //Series的边框颜色
        //    series.BorderColor = Color.FromArgb(180, 26, 59, 105);
        //    //线条宽度
        //    series.BorderWidth = 3;
        //    //线条阴影颜色
        //    series.ShadowColor = Color.Black;
        //    //阴影宽度
        //    series.ShadowOffset = 2;
        //    //是否显示数据说明
        //    series.IsVisibleInLegend = true;
        //    //线条上数据点上是否有数据显示
        //    series.IsValueShownAsLabel = false;
        //    //线条上的数据点标志类型
        //    series.MarkerStyle = MarkerStyle.Circle;
        //    //线条数据点的大小
        //    series.MarkerSize = 8;
        //    //线条颜色
        //    switch (i)
        //    {
        //        case 0:
        //            series.Color = Color.FromArgb(220, 65, 140, 240);
        //            break;
        //        case 1:
        //            series.Color = Color.FromArgb(220, 224, 64, 10);
        //            break;
        //        case 2:
        //            series.Color = Color.FromArgb(220, 120, 150, 20);
        //            break;
        //    }
        //    return series;
        //}
        #endregion
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //关闭串口 
            SpCom.Close();
        }
      
        private delegate void CrossThreadOperationControl();

        /// <summary>
        /// 正常工作时的串口中断
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SpCom_DataReceived(object sender,
                         System.IO.Ports.SerialDataReceivedEventArgs e)
        {

            if (workState == 2)//历史数据读取时等待长一点时间
            {
                Thread.Sleep(5000);//wait for data
            }
            else
            {
                Thread.Sleep(50);//wait for data
            }

            try
            {
                strT = SpCom.ReadExisting();
            }
            catch
            {
                ;
            }
            

            if (strT.Length > 12)//判断接收到的数据是否够长度
            { 
                #region 如果接受到的是数据字符串
                if (strT.Substring(0, 3) == "DA:")
                {
                    DateCount = DateCount + 1;
                    // label1.Text=Convert.ToString(DateCount);//count
                    #region 从接收字符串中提取数据
                    //string sss = "1 2 3";
                    MatchCollection vMatchs = Regex.Matches(strT, @"-?\d+(\.\d+)?");
                    //String[] vfloats = new String[vMatchs.Count];//initialized to 3
                    for (int i = 0; i < vMatchs.Count; i++)//这里注意增加数组越界
                    {
                        vfloats[i] = /*float.Parse*/(vMatchs[i].Value);
                    }
                    #endregion

                    #region 向xml保存接收的数据条
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load("DateRecive//" + saveFileName);
                    XmlNode root = xmlDoc.SelectSingleNode("root");//查找<bookstore>
                    XmlElement xe1 = xmlDoc.CreateElement("date");//创建一个<data>节点
                    xe1.SetAttribute("type", "date");//设置该节点type属性
                    xe1.SetAttribute("HIS", "now");//设置该节点HIS属性



                    XmlElement xesub1 = xmlDoc.CreateElement("cond");
                    xesub1.InnerText = vfloats[0];
                    xe1.AppendChild(xesub1);

                    XmlElement xesub2 = xmlDoc.CreateElement("tmp");
                    xesub2.InnerText = vfloats[1];
                    xe1.AppendChild(xesub2);

                    XmlElement xesub3 = xmlDoc.CreateElement("total_L");
                    xesub3.InnerText = vfloats[2];
                    xe1.AppendChild(xesub3);

                    XmlElement xesub4 = xmlDoc.CreateElement("day");
                    xesub4.InnerText = "null";
                    xe1.AppendChild(xesub4);

                    XmlElement xesub5 = xmlDoc.CreateElement("time");
                    xesub5.InnerText = DateTime.Now.ToString("yyyyMMdd hh_mm_ss"); ;//设置文本节点
                    xe1.AppendChild(xesub5);//添加到<date>节点中

                    root.AppendChild(xe1);//添加到<bookstore>节点中
                    xmlDoc.Save("DateRecive//" + saveFileName);

                    #endregion
                    ReDraw = 1;
                }
                #endregion
                #region 如果接受到的是历史数据
                //HS:  1day:1339us/cm,30.2degC,     0L
                //HS:  2day: 396us/cm,29.1degC,  1409L/r/n    一共38个字符

                else if (strT.Substring(0, 13) == "OK READ:HIST!")
                {
                    HIS_Nday = 0;

                    Array.Clear(HIS_day, 0, HIS_day.Length);
                    Array.Clear(HIS_con, 0, HIS_con.Length);
                    Array.Clear(HIS_tmp, 0, HIS_tmp.Length);
                    Array.Clear(HIS_ToL, 0, HIS_ToL.Length);

                    this.tChart1.Axes.Bottom.Automatic = true;
                    this.fastLine1.XValues.DateTime = false;
                    tChart1.Axes.Bottom.Labels.ValueFormat = "#";

                    fastLine1.Clear();//clear data
                    fastLine2.Clear();
                    fastLine3.Clear();

                    strT = strT.Substring(15);
                    #region  get HIS data
                    for (HIS_loop = 1; HIS_loop < 2000; HIS_loop++)//get HIS data
                    {
                        if (strT.Substring(0, 3) == "HS:")
                        {
                            HIST_temp = strT.Substring(0, 37);
                            MatchCollection vMatchs = Regex.Matches(HIST_temp, @"-?\d+(\.\d+)?");
                            //String[] vfloats = new String[vMatchs.Count];//initialized to 3
                            for (int i = 0; i < vMatchs.Count; i++)
                            {
                                vfloats[i] = /*float.Parse*/(vMatchs[i].Value);
                            }
                            HIS_day[HIS_loop] = vMatchs[0].Value;
                            HIS_con[HIS_loop] = vMatchs[1].Value;
                            HIS_tmp[HIS_loop] = vMatchs[2].Value;
                            HIS_ToL[HIS_loop] = vMatchs[3].Value;
                            HIS_Nday++;
                        }
                        else
                        {
                            workState = 3;//从开始读历史状态进入确认读取历史书状态
                            break;
                        }

                        if (strT.Length >= 37)
                        {
                            strT = strT.Substring(38);
                        }
                        if (strT.Length < 37)
                        {
                            workState = 3;//从开始读历史状态进入确认读取历史书状态
                            break;
                        }

                    }
                    // string  HIST_data[365][4];//用于存放历史数据
                    //string  HIST_temp;//暂存每天的历史数据
                    //int     HIST_day;//用于历史数据的计数，存放在历史数据数组的第一位
                    #endregion
                }
                #endregion
                #region 接受到机器型号信息
                else if (strT.Substring(0, 6) == "SN:V&A")
                {
                    //读取到设备信息，也用作开始的设备查找
                    string[] arrTemp = strT.Split(',');
                    Vendor = arrTemp[0].Substring(3, 3);
                    Model = arrTemp[1];
                    SN = arrTemp[2];
                    refreshModel = 1;
                    timer1.Enabled = true;
                    timer1.Start();
                    //收到此数据只能是在菜单中手动设置开始，故将各按键和状态位配置为正常工作状态
                    if (workState != 2) { workState = 1; }
                    //else { workState = 3; }//从开始读历史状态进入确认读取历史书状态
                }
                #endregion
                else if(workState == 2)
                {
                    
                    workState = 4;
                }
            }
            #region refresh teechart
            // 将代理实例化为一个匿名代理 
            CrossThreadOperationControl CrossDelete = delegate ()
            {
                textBox1.Text += Convert.ToString(DateCount) + strT;
                this.textBox1.Focus();//获取焦点
                this.textBox1.Select(this.textBox1.TextLength, 0);//光标定位到文本最后
                this.textBox1.ScrollToCaret();//滚动到光标处
                textBox2.Text += Convert.ToString(SpCom.ReceivedBytesThreshold);
                //ReceivedBytesThreshold
               
                if (refreshModel != 0)
                {
                    refreshModel = 0;
                    labelVendor.Text = Vendor;
                    labelModel.Text = Model;
                    labelSN.Text = SN;
                    if (workState < 2){ SetFlag(workState); }               
                }
                #region 更新datagridview1
                DataSet xmlDs = new DataSet();
                try
                {
                    xmlDs.ReadXml(".\\DateRecive//" + saveFileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return;
                }
                this.dataGridView1.DataSource = xmlDs.Tables[0].DefaultView;
                //移动光标至末行
                dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0];
                //dataGridView1.BeginEdit(true);
                //dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Count - 1;
                #endregion
                if (ReDraw == 1)//更新tchart
                {
                    ReDraw = 0;                  
                    AnimateSeries(this.tChart1);                    
                }
                //if (HIS_Nday > 0)
                //{                   
                //    for (HIS_loop = 1; HIS_loop < HIS_Nday; HIS_loop++)
                //    {
                //        AnimateSeriesHIST(this.tChart1, HIS_loop);
                //    }
                //    HIS_Nday = 0;
                //}
            };
            //timer1.Enabled = true;
            textBox1.Invoke(CrossDelete);
            #endregion       
            Data_recevie = 1;
        }
        #region 导出数据
        /// <summary>
        /// 导出数据
        /// </summary>
        /// <param name="FullFileName"></param>
        /// <param name="TextAll"></param>
        /// <returns></returns>
        private bool TxtExport(string FullFileName, string TextAll)
        {
            if (!CreatFile(FullFileName))
            {
                return false;
            }

            StreamWriter sw = new StreamWriter(FullFileName, true, Encoding.Default);   //该编码类型不会改变已有文件的编码类型
            sw.WriteLine(TextAll);
            sw.Close();
            return true;
        }
        #endregion
        #region 创建文件（文件存在则跳过）
        /// <summary>
        /// 创建文件（文件存在则跳过）
        /// </summary>
        /// <param name="FullFileName">带路径的文件名</param>
        /// <returns></returns>
        private bool CreatFile(string FullFileName)
        {
            if (File.Exists(FullFileName))
            {
                return true;
            }
            else
            {
                try
                {
                    FileStream fs = new FileStream(FullFileName, FileMode.CreateNew);
                    fs.Close();
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message.ToString());
                    return false;
                }
            }
        }
        #endregion      
      
        private void timer1_Tick(object sender, EventArgs e)//定时向下位机发送read指令读取数据
        {
            if (PortIsOpen == 1)
            {
                SpCom.Write(B_READ);
            }

        }
        private void timer2_Tick(object sender, EventArgs e)//timer2用于更新读取的历史数据
        {
            if (workState == 3)
            {
                workState = 0;
                SpCom.Close();

                if (HIS_Nday > 0)
                {
                    for (HIS_loop = 1; HIS_loop < HIS_Nday; HIS_loop++)
                    {
                        AnimateSeriesHIST(this.tChart1, HIS_loop);
                    }
                    HIS_Nday = 0;
                }
                SetFlag(workState);//配置为初始状态
            }
            else if (workState == 4)//没有获取到有效数据。提示用户
            {
                workState = 0;
                SpCom.Close();
                MessageBox.Show("Not yet get valid data, please try again after confirmation");
                SetFlag(workState);//配置为初始状态
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void tChart1_Click(object sender, EventArgs e)
        {

        }
        public int PORTISOPEN
        {
            get { return this.PortIsOpen; }
            set { this.PortIsOpen = value; }
        }
        public int RECONFIG
        {
            get { return this.Reconfig; }
            set { this.Reconfig = value; }
        }
        public int SetForm_interval
        {
            get { return this.set_Interval; }
            set { this.set_Interval = value; }
        }
        public string SetForm_comport
        {
            get { return this.set_COMport; }
            set { this.set_COMport = value; }
        }
        //     
        #region Menu click
        private void openToolStripMenuItem_Click(object sender, EventArgs e)//菜单树处理部分
        {
            #region 测试打开菜单
            openFileDialog1.Filter = "icon(*.icon)|*.ico";
            // "txt files (*.txt)|*.txt|All files (*.*)|*.*"
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string FileName = this.openFileDialog1.FileName;
                textBox1.Text = FileName;
                //处理文件路径代码 
            }
            #endregion
        }
        //aboutVAToolStripMenuItem_Click
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tChart1.Printer.Print();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Data stored in the file 'DataRecive' by default!");
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void setToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void advanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            timer1.Enabled = false;
            Form2 Fm2 = new Form2(this);
            Fm2.Show();
            Fm2.Enabled = true;
        }
        private void cOMSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            ComSet Fm_comset = new ComSet(this);
            Fm_comset.Show();
            Fm_comset.Enabled = true;
            

        }
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 Fm4 = new Form4(this);
            Fm4.Show();
            Fm4.Enabled = true;
        }
        private void aboutVAToolStripMenuItem_Click(object sender, EventArgs e)//菜单树处理部分
        {
            Form3 Fm3 = new Form3();
            Fm3.Show();
            Fm3.Enabled = true;
        }

        #endregion
        //private void button1_Click(object sender, EventArgs e)//open the commport
        //{
        //    if (SpCom.IsOpen)
        //    #region isopen
        //    {
        //        SpCom.Close();
        //        comboBox1.Enabled = true;
        //        button1.Text = "Open";
        //        //MessageBox.Show("Close " + comboBox1.Text, "Messsage");
        //        PortIsOpen = 0;              
        //        timer1.Enabled = false;

        //        button3.Enabled = false;
        //        button4.Enabled = false;
        //    }
        //    #endregion
        //    #region closed
        //    else
        //    {
        //        set_COMport = comboBox1.Text;
        //        SpCom.PortName = comboBox1.Text;
        //        SpCom.Open();
        //        comboBox1.Enabled = false;
        //        button1.Text = "Close";
        //        //MessageBox.Show("Open " + comboBox1.Text, "Messsage");
        //        PortIsOpen = 1;
        //        //timer1.Enabled = true;
        //        button3.Enabled = true;
        //        button4.Enabled = true;

        //        #region 重设横坐标值
        //        fastLine1.Clear();//clear data
        //        fastLine2.Clear();
        //        fastLine3.Clear();
        //        this.fastLine1.XValues.DateTime = true;
        //        this.tChart1.Axes.Bottom.Labels.ValueFormat = "yyyy-MM-dd HH:mm:dd";

        //        StartDate = DateTime.Now;
        //        fastLine1.GetHorizAxis.SetMinMax(StartDate, StartDate.AddSeconds(200));
        //        #endregion
        //    }
        //    #endregion
        //}      
        //private void button2_Click(object sender, EventArgs e)//clear
        // { 
        //     //SpCom.Write(textBox2.Text);
        //     fastLine1.Clear();//clear data
        //     fastLine2.Clear();
        //     fastLine3.Clear();

        // }
        //private void button3_Click(object sender, EventArgs e)//enable form2
        // {
        //     //Form currentForm =Form.ActiveForm;
        //     // Form2.Activate();

        //     Form2 Fm2 = new Form2(this);
        //     Fm2.Show();
        //     Fm2.Enabled = true;

        // } 
        //private void button4_Click(object sender, EventArgs e)//resd history
        // {
        //     SpCom.Write("READ:HIST\r\n");
        //     button4.Text = "wait...";//wait for data update
        //     button4.Enabled = false;
        // }
        //private void button5_Click(object sender, EventArgs e)
        //{
        //    if (IsRead==0)
        //    {
        //        timer1.Enabled = true;
        //        timer2.Enabled = false;
        //        IsRead = 1;
        //        button3.Enabled = false;
        //        button4.Enabled = false;

        //        //fastLine1.Clear();//clear data
        //        //fastLine2.Clear();
        //        //fastLine3.Clear();
        //        this.fastLine1.XValues.DateTime = true;
        //        this.tChart1.Axes.Bottom.Automatic = false;
        //        this.tChart1.Axes.Bottom.Labels.ValueFormat = "yyyy-MM-dd HH:mm:dd";
        //    }
        //    else
        //    {
        //        timer1.Enabled = false;
        //        timer2.Enabled = true;
        //        IsRead = 0;                

        //        button3.Enabled = true;
        //        button4.Enabled = true;            
        //        //#region 重设横坐标值
        //        //StartDate = DateTime.Now;
        //        //fastLine1.GetHorizAxis.SetMinMax(StartDate, StartDate.AddSeconds(200));
        //        //#endregion
        //    }
        //}
        
        #region IMdiparent member
        public void ParentFoo()
        {
            MessageBox.Show("Call"+this.GetType().FullName+".ParentFoo() Func!");
            //MessageBox.Show("调用"+this.GetType().FullName +".ParentFoo()方法！");
        }
        #endregion

        //启动按钮
        private void btnStart_Click(object sender, EventArgs e)
        {          
            var Whichbtn = sender as Button;

            if (Whichbtn == btnStart)
            {
                if (IsRead == 0)
                {
                    IsRead = 1;
                    btnStart.Text = "Searching";
                    btnStart.Enabled = false;
                    btnHistory.Enabled = false;
                    
                    //准备好串口的扫描工作
                }
                else
                {
                    IsRead = 0;
                    timer1.Enabled = false;                                
                    SpCom.Close();
                    SetFlag(Start);                    
                        //停止串口数据发送与接收                 
                }
            }
            else if (Whichbtn == btnHistory)
            {
                workState = 2;
                SetFlag(HistoryRead);
                IsRead = 1;
                //读取串口数据
            }
            if (IsRead == 1)
            {
                #region 轮询串口并等待
                //用一个数组保存供测试用的serialport
                SerialPort[] portcollect = new SerialPort[] { serialPort1, serialPort2, serialPort3, serialPort4, serialPort5,
                                                serialPort6, serialPort7, serialPort8, serialPort9, serialPort10 };
                PortTesting = "null";
                var serialports = this.Controls.OfType<SerialPort>();
                for (int i = 1; i < Convert.ToInt32(Exist_COM[0])+1; i++)
                {
                    //SerialPort tempPort = serialports.ElementAt(i); //this.Controls.Find(serialports.ElementAt(i),true)[0];               
                    Test_port(portcollect[i-1], Exist_COM[i]);
                }
                Thread.Sleep(3000);//wait for data
                #endregion
                #region 获取到有可用机器信息端口
                if (PortTesting != "null")
                {
                    //询问是否打开已检测到的端口
                    if (MessageBox.Show("Find a available device in serial port " + PortTesting + ".You want to start from it ?", "CONFIRM",
                                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        for (int i = 1; i < Convert.ToInt32(Exist_COM[0]) + 1; i++)//关闭所有测试端口
                        {//close test port
                            portcollect[i - 1].Close();
                        }

                        Reconfig = 1;
                        ConfigComport(SpCom, PortTesting, SetForm_interval);//打开串口开启定时读取下位机数据                     
                        SpCom.DataReceived += new SerialDataReceivedEventHandler(SpCom_DataReceived);

                        if (Whichbtn == btnStart)
                        {
                            SpCom.Write(B_READ);//读取数据                        
                            timer1.Enabled = true;
                            SetFlag(NormalRead);
                        }
                        else if (Whichbtn == btnHistory)
                        {
                            //SpCom.Write(IDN);
                            //Thread.Sleep(200);
                            SpCom.Write("READ:HIST\r\n");
                            //这里需要等待历史数据接受完成  20160309 晚 待完成

                        }
                    }
                    else
                    {
                        workState = 0;
                        SetFlag(Start);
                    }
                }
                #endregion
                #region 未能成功获取到可用端口
                else
                {
                    MessageBox.Show("Could not find any available model, can be manually choose from the menu.","Message");
                    SetFlag(Start);//配置初始各状态位
                }
                #endregion
            }
         
            //var serialports = this.Controls.OfType<SerialPort>();
            //for (int i = 1; i < serialports.Count(); i++)
            //{
            //    serialports.ElementAt(i).
            //}
        }

        //测试某个串口是否是当前需要找的
        private bool Test_port(SerialPort port,string com)
        {           
            ConfigComport( port, com, 2000);//打开串口不开启定时读取
            port.DataReceived += new SerialDataReceivedEventHandler(Test_DataReceived);
            port.Write(IDN);

            return false;
        }

        public void ConfigComport(SerialPort port, string com, int interval)
        {
            if (Reconfig != 0)
            {
                Reconfig = 0;
                fastLine1.Clear();//clear data
                fastLine2.Clear();
                fastLine3.Clear();

                this.fastLine1.XValues.DateTime = true;
                this.tChart1.Axes.Bottom.Labels.ValueFormat = "yyyy-MM-dd HH:mm:dd";

                StartDate = DateTime.Now;
                fastLine1.GetHorizAxis.SetMinMax(StartDate, StartDate.AddSeconds(200));
            }
            timer1.Enabled = false;
            timer1.Interval = interval * 1000;
            port.Close();            
            port.PortName = com;
            //if (Func == 0) { port.DataReceived += new SerialDataReceivedEventHandler(SpCom_DataReceived); }
            //使用独立的串口接收中断线程
           // else{ port.DataReceived += new SerialDataReceivedEventHandler(Test_DataReceived); }
            port.Open();
            if (port == SpCom) { PortIsOpen = 1;}
            
            //port.Write("I know you are COM port " + com + " !\r\n");//test
            //timer1.Enabled = true;
        }

        #region 扫描中断 通过检测返回的数据确认是否查到可用设备
        private void Test_DataReceived(object sender,
                    System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            var nowport = sender as SerialPort;
            Thread.Sleep(50);

            string strtemp = ""; 
            try
            {
                strtemp = nowport.ReadExisting();
            }
            catch
            {
                ;
            }
            if (strtemp.Length > 12)//判断接收到的数据是否够长度
            {
                //if (strT.IndexOf(":V") > 0)
                if (strtemp.Substring(0, 6) == "SN:V&A")               
                {
                    //读取到设备信息，也用作开始的设备查找
                    PortTesting = nowport.PortName;//获取可用端口号

                    string[] arrTemp = strtemp.Split(',');
                    Vendor = arrTemp[0].Substring(3, 3);
                    Model = arrTemp[1];
                    SN = arrTemp[2];

                    CrossThreadOperationControl SNDelete = delegate ()
                    {
                        //labelVendor.Text = arrTemp[0].Substring(3, 3);
                        //labelModel.Text = arrTemp[1];
                        //labelSN.Text = arrTemp[2];
                        labelVendor.Text = Vendor;
                        labelModel.Text = Model;
                        labelSN.Text = SN;
                    };
                    labelVendorT.Invoke(SNDelete);
                }   
            }
               
        }
        #endregion

        /// <summary>
        /// 定时器使能，主要用于外部调用
        /// </summary>
        /// <param name="state"></param>
        public void SetTimer1(bool state)
        {
            if (state == true){timer1.Enabled = true;}
            else { timer1.Enabled = false; } 
        }

        /// <summary>
        /// 配置各工作状态下标志位情况
        /// </summary>
        /// <param name="state"></param>
        public void SetFlag(int state)
        {
            workState = state;    
            if (workState == 0)//上电状态
            {
                timer2.Enabled = false;
                cOMSetToolStripMenuItem.Enabled = true;
                advanceToolStripMenuItem.Enabled = false;
                btnStart.Text = "Start";
                btnStart.Enabled = true;
                btnHistory.Text = "History";
                btnHistory.Enabled = true;                
                IsRead = 0;
                Reconfig = 0;

            }
            else if (workState == 1)//工作读取数据状态
            {
                cOMSetToolStripMenuItem.Enabled = false;
                advanceToolStripMenuItem.Enabled = true;
                btnStart.Text = "Stop";
                btnStart.Enabled = true;
                btnHistory.Text = "History";
                btnHistory.Enabled = false;
                IsRead = 1;
                Reconfig = 0;
            }
            else if (workState == 2)//读取历史数据状态
            {
                timer2.Enabled = true;
                advanceToolStripMenuItem.Enabled = false;
                btnStart.Text = "Start";
                btnStart.Enabled = false;
                btnHistory.Text = "Waiting";
                btnHistory.Enabled = false;
                IsRead = 0;
                Reconfig = 0;
            }              
        }      

        #region click to change skin theme
        private void button6_Click(object sender, EventArgs e)
        {
            this.skinEngine1.SkinFile = "E:\\zhangyu\\VA1017\\VA1017 soft\\20150920_code_20151207\\WindowsFormsApplication2\\bin" +
            "\\Debug\\interface_ssk\\SteelBlue.ssk";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.skinEngine1.SkinFile = "E:\\zhangyu\\VA1017\\VA1017 soft\\20150920_code_20151207\\WindowsFormsApplication2\\bin" +
            "\\Debug\\interface_ssk\\WaveColor2.ssk";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.skinEngine1.SkinFile = "E:\\zhangyu\\VA1017\\VA1017 soft\\20150920_code_20151207\\WindowsFormsApplication2\\bin" +
             "\\Debug\\interface_ssk\\SilverColor2.ssk";
        }
        #endregion


        #region 获取USB串口插拔消息
        //// usb消息定义
        //public const int WM_DEVICE_CHANGE = 0x219;
        //public const int DBT_DEVICEARRIVAL = 0x8000;
        //public const int DBT_DEVICE_REMOVE_COMPLETE = 0x8004;
        //public const UInt32 DBT_DEVTYP_PORT = 0x00000003;
        //[StructLayout(LayoutKind.Sequential)]
        //struct DEV_BROADCAST_HDR
        //{
        //    public UInt32 dbch_size;
        //    public UInt32 dbch_devicetype;
        //    public UInt32 dbch_reserved;
        //}

        //[StructLayout(LayoutKind.Sequential)]
        //protected struct DEV_BROADCAST_PORT_Fixed
        //{
        //    public uint dbcp_size;
        //    public uint dbcp_devicetype;
        //    public uint dbcp_reserved;
        //    // Variable?length field dbcp_name is declared here in the C header file.
        //}

        ///// <summary>
        ///// 检测USB串口的拔插
        ///// </summary>
        ///// <param name="m"></param>
        //protected override void WndProc(ref Message m)
        //{
        //    if (m.Msg == WM_DEVICE_CHANGE)        // 捕获USB设备的拔出消息WM_DEVICECHANGE
        //    {
        //        switch (m.WParam.ToInt32())
        //        {
        //            case DBT_DEVICE_REMOVE_COMPLETE:    // USB拔出 
        //                try { SpCom.Close(); }
        //                catch { MessageBox.Show("removed!"); }
        //                break;
        //            case DBT_DEVICEARRIVAL:             // USB插入获取对应串口名称
        //                DEV_BROADCAST_HDR dbhdr = (DEV_BROADCAST_HDR)Marshal.PtrToStructure(m.LParam, typeof(DEV_BROADCAST_HDR));
        //                if (dbhdr.dbch_devicetype == DBT_DEVTYP_PORT)//若是串口设备则尝试辨认
        //                {
        //                    int templong = Marshal.SizeOf(typeof(DEV_BROADCAST_PORT_Fixed));
        //                    SpCom.PortName = Marshal.PtrToStringUni((IntPtr)(m.LParam.ToInt64() + Marshal.SizeOf(typeof(DEV_BROADCAST_PORT_Fixed))));
        //                    Reconfig = 1;
        //                    ConfigComport(SpCom, SpCom.PortName, SetForm_interval);//打开串口开启定时读取下位机数据                     
        //                    SpCom.DataReceived += new SerialDataReceivedEventHandler(SpCom_DataReceived);
        //                    SpCom.Write(IDN);
        //                    /*Thread.Sleep(300);
        //                    if (PortTesting != "null")
        //                    {
        //                        if (MessageBox.Show("Find a available device in serial port " + PortTesting + ".You want to start from it ?", "CONFIRM",
        //                                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
        //                        {
        //                            SpCom.Close();

        //                            Reconfig = 1;
        //                            ConfigComport(SpCom, PortTesting, SetForm_interval);//打开串口开启定时读取下位机数据                     
        //                            SpCom.DataReceived += new SerialDataReceivedEventHandler(SpCom_DataReceived);                                 
        //                        }
        //                    }*/

        //                }
        //                break;
        //        }
        //    }
        //    base.WndProc(ref m);
        //}
        #endregion

    }
}

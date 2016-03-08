using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        public static String CALTMP = "CAL:TMP:";
        public static String CALCOND = "CAL:COND:";
        public static String CALFstart = "CAL:FLOW:start";
        public static String CALFLOW = "CAL:FLOW:";
        //传递主窗口对象
        private Form1 pParentWin = null;
        public Form2(Form1 WinMain)
        {
            InitializeComponent();
            pParentWin = WinMain;
            comboBox1.SelectedIndex = 0;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            if (pParentWin.PORTISOPEN != 0) { }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            pParentWin.SpCom.Write(CALTMP+textBox1.Text+"\r\n");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            pParentWin.SpCom.WriteLine(CALCOND + textBox2.Text + "\r\n");
        }     
        private void button3_Click(object sender, EventArgs e)
        {
            pParentWin.SpCom.WriteLine(CALFLOW + textBox3.Text + "\r\n");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pParentWin.SpCom.WriteLine(CALCOND + textBox4.Text+comboBox1.Text + "\r\n");
        }

        private void button5_Click(object sender, EventArgs e)//开始流量校准
        {
            pParentWin.SpCom.WriteLine(CALFstart + "\r\n");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       
    }
}

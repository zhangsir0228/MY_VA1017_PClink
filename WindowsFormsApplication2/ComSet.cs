using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
  

    public partial class ComSet : Form
    {
        string Temp_COM = "";
        int    Temp_Interval = 2000;

        //传递主窗口对象
        private Form1 pParentWin = null;
        public ComSet(Form1 WinMain)
        {
            InitializeComponent();
            pParentWin = WinMain;
        }

        private void ComSet_Load(object sender, EventArgs e)
        {
            Temp_Interval = pParentWin.SetForm_interval;
            label1.Text = Temp_Interval.ToString();
            trackBar_interval.Value = Temp_Interval; 

            //Tform.SetForm_interval = trackBar_interval.Value;

            #region get existed COM port.
            foreach (string s in SerialPort.GetPortNames())
            {
                comboBoxCOM.Items.Add(s);
            }
            comboBoxCOM.SelectedIndex = 0;

            #endregion            
        }

        #region IMyChildForm 成员
        public void Foo()
        {
            MessageBox.Show("调用" + this.GetType().FullName + ".Foo()方法！");
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Temp_COM = comboBoxCOM.Text; //get the comport
            if (MessageBox.Show("You wangt to start from the COM port " + Temp_COM + " ?", "CONFIRM", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                pParentWin.SetForm_comport = Temp_COM;
                pParentWin.SetForm_interval = Temp_Interval;
                pParentWin.RECONFIG = 1;
                // pParentWin.ConfigComport(pParentWin.SetForm_comport, pParentWin.SetForm_interval);
                this.Close();//主动关闭窗口跳转到
            }

        }

    
        private void trackBar_interval_ValueChanged(object source, EventArgs e)//interval set
        {         
            label1.Text = trackBar_interval.Value.ToString();
           
            Temp_Interval = trackBar_interval.Value;        
        }

        //when its closing update the param to main windows
        private void ComSet_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Set interval: "+ Temp_Interval.ToString()+" S", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                pParentWin.SetForm_interval = Temp_Interval;
                pParentWin.RECONFIG = 1;
                pParentWin.ConfigComport(pParentWin.SetForm_comport, pParentWin.SetForm_interval);
                
            }        
           
            pParentWin.Enabled = true;
        }
    }
}

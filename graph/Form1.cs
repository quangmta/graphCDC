using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using System.Diagnostics;
namespace graph
{
    public partial class Form1 : Form
    {
        string dataReceive;
        GraphPane myPane;
        PointPairList listPoint = new PointPairList();
        LineItem myCurve;
        int i=0;
        Stopwatch sw = new Stopwatch();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myPane = zedGraphControl1.GraphPane;
            myPane.Title.Text = "COM port";
            myPane.XAxis.Title.Text = "X Axis";
            myPane.YAxis.Title.Text = "Y Axis";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = COMport.Text;
            serialPort1.BaudRate = Convert.ToInt32(Baudrate.Text);
            if (!serialPort1.IsOpen)
            {                
                serialPort1.Open();
                sw.Start();
                buttonConnect.Enabled = false;
                buttonDisconnect.Enabled = true;
            } 
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                sw.Stop();
                serialPort1.Close();
                buttonDisconnect.Enabled = false;
                buttonConnect.Enabled = true;
            } 
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            while (serialPort1.BytesToRead > 0)
            {
                dataReceive = serialPort1.ReadLine();
                if (dataReceive.Trim() != "")
                {
                    listPoint.Add(i,Convert.ToDouble (dataReceive));
                    i++;
                    if (listPoint.Count>100)
                    {
                        listPoint.RemoveAt(0);
                    }
                }
                
            }
            
        }

        private void Data_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Count.Text = i.ToString();
            TimerCount.Text = sw.ElapsedMilliseconds.ToString();
            DataText.Text = dataReceive;
            zedGraphControl1.GraphPane.CurveList.Clear();
            myCurve = myPane.AddCurve(null, listPoint, Color.Red, SymbolType.None);
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Count_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

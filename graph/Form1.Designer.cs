
namespace graph
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TimerCount = new System.Windows.Forms.TextBox();
            this.Count = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.COM = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DataText = new System.Windows.Forms.TextBox();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Baudrate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.COMport = new System.Windows.Forms.TextBox();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.BtnExit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM10";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TimerCount);
            this.groupBox1.Controls.Add(this.Count);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.COM);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DataText);
            this.groupBox1.Controls.Add(this.buttonDisconnect);
            this.groupBox1.Controls.Add(this.buttonConnect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Baudrate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.COMport);
            this.groupBox1.Location = new System.Drawing.Point(-1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Config";
            // 
            // TimerCount
            // 
            this.TimerCount.Location = new System.Drawing.Point(653, 59);
            this.TimerCount.Name = "TimerCount";
            this.TimerCount.Size = new System.Drawing.Size(85, 22);
            this.TimerCount.TabIndex = 12;
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(653, 21);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(85, 22);
            this.Count.TabIndex = 11;
            this.Count.TextChanged += new System.EventHandler(this.Count_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(487, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Timer count (ms)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(487, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Number of data reads";
            // 
            // COM
            // 
            this.COM.AutoSize = true;
            this.COM.Location = new System.Drawing.Point(13, 22);
            this.COM.Name = "COM";
            this.COM.Size = new System.Drawing.Size(39, 17);
            this.COM.TabIndex = 8;
            this.COM.Text = "COM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // DataText
            // 
            this.DataText.Location = new System.Drawing.Point(356, 46);
            this.DataText.Multiline = true;
            this.DataText.Name = "DataText";
            this.DataText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataText.Size = new System.Drawing.Size(99, 30);
            this.DataText.TabIndex = 6;
            this.DataText.TextChanged += new System.EventHandler(this.Data_TextChanged);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Enabled = false;
            this.buttonDisconnect.Location = new System.Drawing.Point(205, 49);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(104, 30);
            this.buttonDisconnect.TabIndex = 5;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(205, 17);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(104, 26);
            this.buttonConnect.TabIndex = 4;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baudrate";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Baudrate
            // 
            this.Baudrate.Location = new System.Drawing.Point(84, 49);
            this.Baudrate.Name = "Baudrate";
            this.Baudrate.Size = new System.Drawing.Size(100, 22);
            this.Baudrate.TabIndex = 2;
            this.Baudrate.Text = "115200";
            this.Baudrate.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM";
            // 
            // COMport
            // 
            this.COMport.Location = new System.Drawing.Point(84, 21);
            this.COMport.Name = "COMport";
            this.COMport.Size = new System.Drawing.Size(100, 22);
            this.COMport.TabIndex = 0;
            this.COMport.Text = "COM10";
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(13, 141);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(740, 314);
            this.zedGraphControl1.TabIndex = 1;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(771, 397);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 29);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 513);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Baudrate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox COMport;
        private System.Windows.Forms.TextBox DataText;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonConnect;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TimerCount;
        private System.Windows.Forms.TextBox Count;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label COM;
    }
}


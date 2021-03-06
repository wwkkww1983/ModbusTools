﻿namespace MotorCtl
{
    partial class frMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frMain));
            this.serial = new WSMBS.WSMBSControl(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckHex = new System.Windows.Forms.CheckBox();
            this.btnSupend = new System.Windows.Forms.Button();
            this.lstCmd = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numStation = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numCycle = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.numStartAdr = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btExec = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbBaudrate = new System.Windows.Forms.ComboBox();
            this.cbSerial = new System.Windows.Forms.ComboBox();
            this.picConn = new System.Windows.Forms.PictureBox();
            this.numPortNo = new System.Windows.Forms.NumericUpDown();
            this.txtIPAdr = new System.Windows.Forms.TextBox();
            this.labText2 = new System.Windows.Forms.Label();
            this.labText1 = new System.Windows.Forms.Label();
            this.cbInterface = new System.Windows.Forms.ComboBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btConnect = new System.Windows.Forms.Button();
            this.tcpip = new WSMBT.WSMBTControl(this.components);
            this.gridData = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labRx = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labTx = new System.Windows.Forms.Label();
            this.cbCSVFile = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ckDispAlais = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labRecv = new System.Windows.Forms.Label();
            this.labSend = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.grpVal = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCycle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartAdr)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picConn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPortNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.grpVal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // serial
            // 
            this.serial.BaudRate = 9600;
            this.serial.DataBits = 8;
            this.serial.DTREnable = false;
            this.serial.Mode = WSMBS.Mode.RTU;
            this.serial.Parity = WSMBS.Parity.None;
            this.serial.PortName = "COM1";
            this.serial.RemoveEcho = false;
            this.serial.ResponseTimeout = 1000;
            this.serial.RTSEnable = false;
            this.serial.StopBits = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckHex);
            this.groupBox1.Controls.Add(this.btnSupend);
            this.groupBox1.Controls.Add(this.lstCmd);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.numStation);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numCycle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numCount);
            this.groupBox1.Controls.Add(this.numStartAdr);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btExec);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 386);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "寄存器";
            // 
            // ckHex
            // 
            this.ckHex.AutoSize = true;
            this.ckHex.Location = new System.Drawing.Point(95, 224);
            this.ckHex.Name = "ckHex";
            this.ckHex.Size = new System.Drawing.Size(51, 21);
            this.ckHex.TabIndex = 15;
            this.ckHex.Text = "Hex";
            this.ckHex.UseVisualStyleBackColor = true;
            this.ckHex.CheckedChanged += new System.EventHandler(this.ckHex_CheckedChanged);
            this.ckHex.EnabledChanged += new System.EventHandler(this.ckHex_EnabledChanged);
            // 
            // btnSupend
            // 
            this.btnSupend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSupend.Enabled = false;
            this.btnSupend.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupend.Location = new System.Drawing.Point(102, 303);
            this.btnSupend.Name = "btnSupend";
            this.btnSupend.Size = new System.Drawing.Size(68, 66);
            this.btnSupend.TabIndex = 8;
            this.btnSupend.Text = "暂停";
            this.btnSupend.UseVisualStyleBackColor = true;
            this.btnSupend.Click += new System.EventHandler(this.btnSupend_Click);
            // 
            // lstCmd
            // 
            this.lstCmd.FormattingEnabled = true;
            this.lstCmd.ItemHeight = 17;
            this.lstCmd.Items.AddRange(new object[] {
            "0x01 读线圈",
            "0x02 读离散输入",
            "0x03 读保持寄存器",
            "0x04 读输入寄存器"});
            this.lstCmd.Location = new System.Drawing.Point(16, 68);
            this.lstCmd.Name = "lstCmd";
            this.lstCmd.Size = new System.Drawing.Size(147, 72);
            this.lstCmd.TabIndex = 1;
            this.lstCmd.SelectedIndexChanged += new System.EventHandler(this.lstCmd_SelectedIndexChanged);
            this.lstCmd.DoubleClick += new System.EventHandler(this.lstCmd_DoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "功能代码:";
            // 
            // numStation
            // 
            this.numStation.Location = new System.Drawing.Point(100, 20);
            this.numStation.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numStation.Name = "numStation";
            this.numStation.Size = new System.Drawing.Size(63, 24);
            this.numStation.TabIndex = 0;
            this.numStation.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "站地址：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "数据格式:";
            // 
            // numCycle
            // 
            this.numCycle.Location = new System.Drawing.Point(95, 257);
            this.numCycle.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numCycle.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numCycle.Name = "numCycle";
            this.numCycle.Size = new System.Drawing.Size(62, 24);
            this.numCycle.TabIndex = 6;
            this.numCycle.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numCycle.ValueChanged += new System.EventHandler(this.numCycle_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "周期(ms):";
            // 
            // numCount
            // 
            this.numCount.Location = new System.Drawing.Point(95, 190);
            this.numCount.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(70, 24);
            this.numCount.TabIndex = 3;
            this.numCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numStartAdr
            // 
            this.numStartAdr.Location = new System.Drawing.Point(95, 155);
            this.numStartAdr.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numStartAdr.Name = "numStartAdr";
            this.numStartAdr.Size = new System.Drawing.Size(70, 24);
            this.numStartAdr.TabIndex = 2;
            this.numStartAdr.Value = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "数据长度：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "起始地址:";
            // 
            // btExec
            // 
            this.btExec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btExec.Enabled = false;
            this.btExec.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExec.Location = new System.Drawing.Point(11, 303);
            this.btExec.Name = "btExec";
            this.btExec.Size = new System.Drawing.Size(76, 66);
            this.btExec.TabIndex = 7;
            this.btExec.Text = "扫描";
            this.btExec.UseVisualStyleBackColor = true;
            this.btExec.Click += new System.EventHandler(this.btExec_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbBaudrate);
            this.groupBox2.Controls.Add(this.cbSerial);
            this.groupBox2.Controls.Add(this.picConn);
            this.groupBox2.Controls.Add(this.numPortNo);
            this.groupBox2.Controls.Add(this.txtIPAdr);
            this.groupBox2.Controls.Add(this.labText2);
            this.groupBox2.Controls.Add(this.labText1);
            this.groupBox2.Controls.Add(this.cbInterface);
            this.groupBox2.Controls.Add(this.btnDisconnect);
            this.groupBox2.Controls.Add(this.btConnect);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 198);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "通信端口参数";
            // 
            // cbBaudrate
            // 
            this.cbBaudrate.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBaudrate.FormattingEnabled = true;
            this.cbBaudrate.Location = new System.Drawing.Point(69, 111);
            this.cbBaudrate.Name = "cbBaudrate";
            this.cbBaudrate.Size = new System.Drawing.Size(105, 27);
            this.cbBaudrate.TabIndex = 5;
            this.cbBaudrate.Visible = false;
            // 
            // cbSerial
            // 
            this.cbSerial.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSerial.FormattingEnabled = true;
            this.cbSerial.Location = new System.Drawing.Point(14, 76);
            this.cbSerial.Name = "cbSerial";
            this.cbSerial.Size = new System.Drawing.Size(162, 22);
            this.cbSerial.TabIndex = 1;
            // 
            // picConn
            // 
            this.picConn.Enabled = false;
            this.picConn.Image = global::MotorCtl.Properties.Resources.connect;
            this.picConn.Location = new System.Drawing.Point(6, 151);
            this.picConn.Name = "picConn";
            this.picConn.Size = new System.Drawing.Size(34, 34);
            this.picConn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picConn.TabIndex = 9;
            this.picConn.TabStop = false;
            // 
            // numPortNo
            // 
            this.numPortNo.Location = new System.Drawing.Point(70, 112);
            this.numPortNo.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPortNo.Name = "numPortNo";
            this.numPortNo.Size = new System.Drawing.Size(102, 24);
            this.numPortNo.TabIndex = 6;
            this.numPortNo.Value = new decimal(new int[] {
            502,
            0,
            0,
            0});
            // 
            // txtIPAdr
            // 
            this.txtIPAdr.Location = new System.Drawing.Point(14, 75);
            this.txtIPAdr.Name = "txtIPAdr";
            this.txtIPAdr.Size = new System.Drawing.Size(162, 24);
            this.txtIPAdr.TabIndex = 2;
            this.txtIPAdr.Text = "127.0.0.1";
            // 
            // labText2
            // 
            this.labText2.AutoSize = true;
            this.labText2.Location = new System.Drawing.Point(7, 114);
            this.labText2.Name = "labText2";
            this.labText2.Size = new System.Drawing.Size(72, 17);
            this.labText2.TabIndex = 8;
            this.labText2.Text = "端口号：";
            // 
            // labText1
            // 
            this.labText1.AutoSize = true;
            this.labText1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labText1.Location = new System.Drawing.Point(7, 55);
            this.labText1.Name = "labText1";
            this.labText1.Size = new System.Drawing.Size(72, 17);
            this.labText1.TabIndex = 7;
            this.labText1.Text = "IP地址：";
            this.labText1.Click += new System.EventHandler(this.labText1_Click);
            // 
            // cbInterface
            // 
            this.cbInterface.FormattingEnabled = true;
            this.cbInterface.Items.AddRange(new object[] {
            "Modubs RTU",
            "Modbus ASCII",
            "Modbus TCP/IP"});
            this.cbInterface.Location = new System.Drawing.Point(7, 23);
            this.cbInterface.Name = "cbInterface";
            this.cbInterface.Size = new System.Drawing.Size(167, 25);
            this.cbInterface.TabIndex = 0;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(118, 142);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(56, 49);
            this.btnDisconnect.TabIndex = 8;
            this.btnDisconnect.Text = "断开";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btConnect
            // 
            this.btConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btConnect.Location = new System.Drawing.Point(54, 142);
            this.btConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(56, 49);
            this.btConnect.TabIndex = 7;
            this.btConnect.Tag = "button";
            this.btConnect.Text = "连接";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // tcpip
            // 
            this.tcpip.ConnectTimeout = 1000;
            this.tcpip.Mode = WSMBT.Mode.TCP_IP;
            this.tcpip.ResponseTimeout = 1000;
            // 
            // gridData
            // 
            this.gridData.AllowUserToAddRows = false;
            this.gridData.AllowUserToDeleteRows = false;
            this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.Value,
            this.Name2,
            this.Value2});
            this.gridData.Location = new System.Drawing.Point(8, 17);
            this.gridData.Name = "gridData";
            this.gridData.RowTemplate.Height = 23;
            this.gridData.Size = new System.Drawing.Size(424, 619);
            this.gridData.TabIndex = 8;
            this.gridData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridData_CellDoubleClick);
            this.gridData.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridData_CellEndEdit);
            // 
            // Index
            // 
            this.Index.HeaderText = "地址";
            this.Index.Name = "Index";
            this.Index.Width = 135;
            // 
            // Value
            // 
            this.Value.HeaderText = "值";
            this.Value.Name = "Value";
            this.Value.Width = 45;
            // 
            // Name2
            // 
            this.Name2.HeaderText = "地址";
            this.Name2.Name = "Name2";
            this.Name2.Width = 135;
            // 
            // Value2
            // 
            this.Value2.HeaderText = "值";
            this.Value2.Name = "Value2";
            this.Value2.Width = 45;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labRx);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.labTx);
            this.groupBox3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(109, 608);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(84, 101);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "信息";
            // 
            // labRx
            // 
            this.labRx.AutoSize = true;
            this.labRx.Location = new System.Drawing.Point(14, 80);
            this.labRx.Name = "labRx";
            this.labRx.Size = new System.Drawing.Size(14, 14);
            this.labRx.TabIndex = 13;
            this.labRx.Text = "0";
            this.labRx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 14);
            this.label7.TabIndex = 11;
            this.label7.Text = "发送:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 14);
            this.label6.TabIndex = 10;
            this.label6.Text = "接收：";
            // 
            // labTx
            // 
            this.labTx.AutoSize = true;
            this.labTx.Location = new System.Drawing.Point(14, 39);
            this.labTx.Name = "labTx";
            this.labTx.Size = new System.Drawing.Size(14, 14);
            this.labTx.TabIndex = 12;
            this.labTx.Text = "0";
            this.labTx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbCSVFile
            // 
            this.cbCSVFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCSVFile.FormattingEnabled = true;
            this.cbCSVFile.Location = new System.Drawing.Point(161, 16);
            this.cbCSVFile.Name = "cbCSVFile";
            this.cbCSVFile.Size = new System.Drawing.Size(176, 25);
            this.cbCSVFile.TabIndex = 1;
            this.cbCSVFile.SelectedIndexChanged += new System.EventHandler(this.cbCSVFile_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(81, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "注释文件:";
            // 
            // ckDispAlais
            // 
            this.ckDispAlais.AutoSize = true;
            this.ckDispAlais.Location = new System.Drawing.Point(12, 20);
            this.ckDispAlais.Name = "ckDispAlais";
            this.ckDispAlais.Size = new System.Drawing.Size(59, 21);
            this.ckDispAlais.TabIndex = 15;
            this.ckDispAlais.Text = "显示";
            this.ckDispAlais.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ckDispAlais);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.cbCSVFile);
            this.groupBox4.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(207, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(343, 49);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "注释";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labRecv);
            this.groupBox5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(8, 729);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(646, 107);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "通信";
            // 
            // labRecv
            // 
            this.labRecv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labRecv.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRecv.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labRecv.Location = new System.Drawing.Point(3, 18);
            this.labRecv.Name = "labRecv";
            this.labRecv.Size = new System.Drawing.Size(640, 86);
            this.labRecv.TabIndex = 1;
            this.labRecv.Text = "Modbus Tools可以作为RTU、ASCII或TCP传输模式下的MODBUS协议主设备的应用程序。把一个或多个MODBUS从站设备通过串口，调制解调器或者网" +
                "络连接到电脑上，通过这个软件读取和修改数据，同时软件具备寄存器数据的趋势显示和记录功能。";
            // 
            // labSend
            // 
            this.labSend.AutoSize = true;
            this.labSend.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSend.Location = new System.Drawing.Point(110, 712);
            this.labSend.Name = "labSend";
            this.labSend.Size = new System.Drawing.Size(63, 14);
            this.labSend.TabIndex = 0;
            this.labSend.Text = "发送帧：";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 2000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // grpVal
            // 
            this.grpVal.Controls.Add(this.gridData);
            this.grpVal.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpVal.Location = new System.Drawing.Point(199, 67);
            this.grpVal.Name = "grpVal";
            this.grpVal.Size = new System.Drawing.Size(450, 642);
            this.grpVal.TabIndex = 18;
            this.grpVal.TabStop = false;
            this.grpVal.Text = "数据显示";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MotorCtl.Properties.Resources.idsse;
            this.pictureBox1.Location = new System.Drawing.Point(8, 614);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 95);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btClose.BackgroundImage = global::MotorCtl.Properties.Resources.system_log_out;
            this.btClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btClose.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btClose.Location = new System.Drawing.Point(580, 13);
            this.btClose.Margin = new System.Windows.Forms.Padding(4);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(51, 47);
            this.btClose.TabIndex = 3;
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // frMain
            // 
            this.AcceptButton = this.btExec;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 841);
            this.Controls.Add(this.grpVal);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.labSend);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btClose);
            this.Font = new System.Drawing.Font("Constantia", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modbus调试工具    (by IDSSE,CSA  chenm@idsse.ac.cn)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frMain_FormClosing);
            this.Load += new System.EventHandler(this.frMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCycle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartAdr)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picConn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPortNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.grpVal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WSMBS.WSMBSControl serial;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btExec;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.NumericUpDown numStartAdr;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbInterface;
        private System.Windows.Forms.Label labText2;
        private System.Windows.Forms.Label labText1;
        private System.Windows.Forms.NumericUpDown numPortNo;
        private System.Windows.Forms.TextBox txtIPAdr;
        private WSMBT.WSMBTControl tcpip;
        private System.Windows.Forms.DataGridView gridData;
        private System.Windows.Forms.ComboBox cbBaudrate;
        private System.Windows.Forms.ComboBox cbSerial;
        private System.Windows.Forms.NumericUpDown numCycle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numStation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picConn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labRx;
        private System.Windows.Forms.Label labTx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstCmd;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbCSVFile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox ckDispAlais;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label labRecv;
        private System.Windows.Forms.Label labSend;
        private System.Windows.Forms.Button btnSupend;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.GroupBox grpVal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value2;
        private System.Windows.Forms.CheckBox ckHex;
    }
}


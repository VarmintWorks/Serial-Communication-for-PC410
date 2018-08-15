<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBoxName = New System.Windows.Forms.ComboBox()
        Me.ComboBoxQC = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBoxSP = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxPr = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBoxDB = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxBR = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButOpen = New System.Windows.Forms.Button()
        Me.ButClose = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtSVnow = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtDegree = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtAddress = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ButSetSV = New System.Windows.Forms.Button()
        Me.ButStopPV = New System.Windows.Forms.Button()
        Me.ButSendPV = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TxtbufferShow = New System.Windows.Forms.TextBox()
        Me.TxtPVShow = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ButReadSV = New System.Windows.Forms.Button()
        Me.ButComAddress = New System.Windows.Forms.Button()
        Me.ButClear = New System.Windows.Forms.Button()
        Me.ButPaint = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ButStopPaint = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ButSetSC = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtSendCycle = New System.Windows.Forms.TextBox()
        Me.LabelPort = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TxtSpeed = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TxtSVMin = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtSVMax = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtPower = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ButReadPower = New System.Windows.Forms.Button()
        Me.ButReadSVMax = New System.Windows.Forms.Button()
        Me.ButReadSVMin = New System.Windows.Forms.Button()
        Me.ButReadSpeed = New System.Windows.Forms.Button()
        Me.ButStartPID = New System.Windows.Forms.Button()
        Me.ButStopPID = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBoxName)
        Me.GroupBox1.Controls.Add(Me.ComboBoxQC)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.ComboBoxSP)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ComboBoxPr)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ComboBoxDB)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ComboBoxBR)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(212, 210)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PC串口设置"
        '
        'ComboBoxName
        '
        Me.ComboBoxName.FormattingEnabled = True
        Me.ComboBoxName.Location = New System.Drawing.Point(66, 26)
        Me.ComboBoxName.Name = "ComboBoxName"
        Me.ComboBoxName.Size = New System.Drawing.Size(140, 20)
        Me.ComboBoxName.TabIndex = 12
        Me.ComboBoxName.Text = "COM1"
        '
        'ComboBoxQC
        '
        Me.ComboBoxQC.FormattingEnabled = True
        Me.ComboBoxQC.Items.AddRange(New Object() {"None", "RTS", "XOn/XOff", "RTSXOn/XOff"})
        Me.ComboBoxQC.Location = New System.Drawing.Point(65, 168)
        Me.ComboBoxQC.Name = "ComboBoxQC"
        Me.ComboBoxQC.Size = New System.Drawing.Size(142, 20)
        Me.ComboBoxQC.TabIndex = 11
        Me.ComboBoxQC.Text = "None"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 12)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "流控："
        '
        'ComboBoxSP
        '
        Me.ComboBoxSP.FormattingEnabled = True
        Me.ComboBoxSP.Items.AddRange(New Object() {"1", "1.5", "2"})
        Me.ComboBoxSP.Location = New System.Drawing.Point(66, 142)
        Me.ComboBoxSP.Name = "ComboBoxSP"
        Me.ComboBoxSP.Size = New System.Drawing.Size(142, 20)
        Me.ComboBoxSP.TabIndex = 9
        Me.ComboBoxSP.Text = "1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 12)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "停止位："
        '
        'ComboBoxPr
        '
        Me.ComboBoxPr.FormattingEnabled = True
        Me.ComboBoxPr.Items.AddRange(New Object() {"None", "Even", "Odd", "Mark", "Space"})
        Me.ComboBoxPr.Location = New System.Drawing.Point(65, 116)
        Me.ComboBoxPr.Name = "ComboBoxPr"
        Me.ComboBoxPr.Size = New System.Drawing.Size(142, 20)
        Me.ComboBoxPr.TabIndex = 7
        Me.ComboBoxPr.Text = "Even"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 12)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "校验位："
        '
        'ComboBoxDB
        '
        Me.ComboBoxDB.FormattingEnabled = True
        Me.ComboBoxDB.Items.AddRange(New Object() {"5", "6", "7", "8"})
        Me.ComboBoxDB.Location = New System.Drawing.Point(65, 86)
        Me.ComboBoxDB.Name = "ComboBoxDB"
        Me.ComboBoxDB.Size = New System.Drawing.Size(143, 20)
        Me.ComboBoxDB.TabIndex = 5
        Me.ComboBoxDB.Text = "7"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "数据位："
        '
        'ComboBoxBR
        '
        Me.ComboBoxBR.FormattingEnabled = True
        Me.ComboBoxBR.Items.AddRange(New Object() {"300", "600", "1200", "2400", "4800", "9600", "19200"})
        Me.ComboBoxBR.Location = New System.Drawing.Point(65, 55)
        Me.ComboBoxBR.Name = "ComboBoxBR"
        Me.ComboBoxBR.Size = New System.Drawing.Size(142, 20)
        Me.ComboBoxBR.TabIndex = 3
        Me.ComboBoxBR.Text = "9600"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "波特率："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "端口名称："
        '
        'ButOpen
        '
        Me.ButOpen.Location = New System.Drawing.Point(9, 229)
        Me.ButOpen.Name = "ButOpen"
        Me.ButOpen.Size = New System.Drawing.Size(100, 30)
        Me.ButOpen.TabIndex = 1
        Me.ButOpen.Text = "打开串口"
        Me.ButOpen.UseVisualStyleBackColor = True
        '
        'ButClose
        '
        Me.ButClose.Location = New System.Drawing.Point(121, 229)
        Me.ButClose.Name = "ButClose"
        Me.ButClose.Size = New System.Drawing.Size(100, 30)
        Me.ButClose.TabIndex = 2
        Me.ButClose.Text = "关闭串口"
        Me.ButClose.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.TxtSVnow)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TxtDegree)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TxtAddress)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(518, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(210, 130)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "仪器设置"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(152, 57)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(17, 12)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "℃"
        '
        'TxtSVnow
        '
        Me.TxtSVnow.Location = New System.Drawing.Point(83, 52)
        Me.TxtSVnow.Name = "TxtSVnow"
        Me.TxtSVnow.Size = New System.Drawing.Size(63, 21)
        Me.TxtSVnow.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 57)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 12)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "当前SV值："
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(153, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(17, 12)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "℃"
        '
        'TxtDegree
        '
        Me.TxtDegree.Location = New System.Drawing.Point(82, 85)
        Me.TxtDegree.Name = "TxtDegree"
        Me.TxtDegree.Size = New System.Drawing.Size(63, 21)
        Me.TxtDegree.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 12)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "设定温度："
        '
        'TxtAddress
        '
        Me.TxtAddress.Location = New System.Drawing.Point(83, 21)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(90, 21)
        Me.TxtAddress.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 12)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "通讯地址："
        '
        'ButSetSV
        '
        Me.ButSetSV.Location = New System.Drawing.Point(628, 178)
        Me.ButSetSV.Name = "ButSetSV"
        Me.ButSetSV.Size = New System.Drawing.Size(100, 30)
        Me.ButSetSV.TabIndex = 7
        Me.ButSetSV.Text = "设置SV"
        Me.ButSetSV.UseVisualStyleBackColor = True
        '
        'ButStopPV
        '
        Me.ButStopPV.Location = New System.Drawing.Point(343, 478)
        Me.ButStopPV.Name = "ButStopPV"
        Me.ButStopPV.Size = New System.Drawing.Size(100, 30)
        Me.ButStopPV.TabIndex = 6
        Me.ButStopPV.Text = "停止读取PV"
        Me.ButStopPV.UseVisualStyleBackColor = True
        '
        'ButSendPV
        '
        Me.ButSendPV.Location = New System.Drawing.Point(237, 478)
        Me.ButSendPV.Name = "ButSendPV"
        Me.ButSendPV.Size = New System.Drawing.Size(100, 30)
        Me.ButSendPV.TabIndex = 5
        Me.ButSendPV.Text = "开始读取PV"
        Me.ButSendPV.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'TxtbufferShow
        '
        Me.TxtbufferShow.Location = New System.Drawing.Point(237, 28)
        Me.TxtbufferShow.Multiline = True
        Me.TxtbufferShow.Name = "TxtbufferShow"
        Me.TxtbufferShow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtbufferShow.Size = New System.Drawing.Size(262, 216)
        Me.TxtbufferShow.TabIndex = 4
        '
        'TxtPVShow
        '
        Me.TxtPVShow.Location = New System.Drawing.Point(237, 283)
        Me.TxtPVShow.Multiline = True
        Me.TxtPVShow.Name = "TxtPVShow"
        Me.TxtPVShow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtPVShow.Size = New System.Drawing.Size(262, 189)
        Me.TxtPVShow.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(235, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 12)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "反馈命令帧："
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(235, 259)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 12)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "当前PV值："
        '
        'ButReadSV
        '
        Me.ButReadSV.Location = New System.Drawing.Point(518, 178)
        Me.ButReadSV.Name = "ButReadSV"
        Me.ButReadSV.Size = New System.Drawing.Size(100, 30)
        Me.ButReadSV.TabIndex = 10
        Me.ButReadSV.Text = "读取SV"
        Me.ButReadSV.UseVisualStyleBackColor = True
        '
        'ButComAddress
        '
        Me.ButComAddress.Location = New System.Drawing.Point(575, 145)
        Me.ButComAddress.Name = "ButComAddress"
        Me.ButComAddress.Size = New System.Drawing.Size(100, 30)
        Me.ButComAddress.TabIndex = 11
        Me.ButComAddress.Text = "设置通讯地址"
        Me.ButComAddress.UseVisualStyleBackColor = True
        '
        'ButClear
        '
        Me.ButClear.Location = New System.Drawing.Point(449, 478)
        Me.ButClear.Name = "ButClear"
        Me.ButClear.Size = New System.Drawing.Size(50, 30)
        Me.ButClear.TabIndex = 12
        Me.ButClear.Text = "清空"
        Me.ButClear.UseVisualStyleBackColor = True
        '
        'ButPaint
        '
        Me.ButPaint.Location = New System.Drawing.Point(518, 214)
        Me.ButPaint.Name = "ButPaint"
        Me.ButPaint.Size = New System.Drawing.Size(100, 30)
        Me.ButPaint.TabIndex = 13
        Me.ButPaint.Text = "绘制图像"
        Me.ButPaint.UseVisualStyleBackColor = True
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'ButStopPaint
        '
        Me.ButStopPaint.Location = New System.Drawing.Point(628, 214)
        Me.ButStopPaint.Name = "ButStopPaint"
        Me.ButStopPaint.Size = New System.Drawing.Size(100, 30)
        Me.ButStopPaint.TabIndex = 14
        Me.ButStopPaint.Text = "停止绘制图像"
        Me.ButStopPaint.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.ButSetSC)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.TxtSendCycle)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 334)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(212, 96)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "周期设置"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(189, 36)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(17, 12)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "ms"
        '
        'ButSetSC
        '
        Me.ButSetSC.Location = New System.Drawing.Point(56, 57)
        Me.ButSetSC.Name = "ButSetSC"
        Me.ButSetSC.Size = New System.Drawing.Size(100, 30)
        Me.ButSetSC.TabIndex = 2
        Me.ButSetSC.Text = "设置发送周期"
        Me.ButSetSC.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(11, 36)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 12)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "发送周期："
        '
        'TxtSendCycle
        '
        Me.TxtSendCycle.Location = New System.Drawing.Point(80, 30)
        Me.TxtSendCycle.Name = "TxtSendCycle"
        Me.TxtSendCycle.Size = New System.Drawing.Size(100, 21)
        Me.TxtSendCycle.TabIndex = 0
        '
        'LabelPort
        '
        Me.LabelPort.AutoSize = True
        Me.LabelPort.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelPort.Font = New System.Drawing.Font("SimSun", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelPort.Location = New System.Drawing.Point(18, 283)
        Me.LabelPort.Name = "LabelPort"
        Me.LabelPort.Size = New System.Drawing.Size(190, 39)
        Me.LabelPort.TabIndex = 16
        Me.LabelPort.Text = "         "
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.TxtSpeed)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.TxtSVMin)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.TxtSVMax)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.TxtPower)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Location = New System.Drawing.Point(518, 286)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(210, 150)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "仪器参数"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(140, 25)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(11, 12)
        Me.Label23.TabIndex = 11
        Me.Label23.Text = "W"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(141, 84)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(17, 12)
        Me.Label22.TabIndex = 10
        Me.Label22.Text = "℃"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(140, 52)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(17, 12)
        Me.Label21.TabIndex = 9
        Me.Label21.Text = "℃"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(140, 114)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(29, 12)
        Me.Label20.TabIndex = 8
        Me.Label20.Text = "℃/s"
        '
        'TxtSpeed
        '
        Me.TxtSpeed.Location = New System.Drawing.Point(69, 105)
        Me.TxtSpeed.Name = "TxtSpeed"
        Me.TxtSpeed.Size = New System.Drawing.Size(65, 21)
        Me.TxtSpeed.TabIndex = 7
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 106)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(65, 12)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "升温速率："
        '
        'TxtSVMin
        '
        Me.TxtSVMin.Location = New System.Drawing.Point(70, 78)
        Me.TxtSVMin.Name = "TxtSVMin"
        Me.TxtSVMin.Size = New System.Drawing.Size(65, 21)
        Me.TxtSVMin.TabIndex = 5
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 76)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(65, 12)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "SV最小值："
        '
        'TxtSVMax
        '
        Me.TxtSVMax.Location = New System.Drawing.Point(70, 48)
        Me.TxtSVMax.Name = "TxtSVMax"
        Me.TxtSVMax.Size = New System.Drawing.Size(65, 21)
        Me.TxtSVMax.TabIndex = 3
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 52)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 12)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "SV最大值："
        '
        'TxtPower
        '
        Me.TxtPower.Location = New System.Drawing.Point(69, 22)
        Me.TxtPower.Name = "TxtPower"
        Me.TxtPower.Size = New System.Drawing.Size(65, 21)
        Me.TxtPower.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 25)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 12)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "输出功率："
        '
        'ButReadPower
        '
        Me.ButReadPower.Location = New System.Drawing.Point(518, 442)
        Me.ButReadPower.Name = "ButReadPower"
        Me.ButReadPower.Size = New System.Drawing.Size(100, 30)
        Me.ButReadPower.TabIndex = 18
        Me.ButReadPower.Text = "获取功率"
        Me.ButReadPower.UseVisualStyleBackColor = True
        '
        'ButReadSVMax
        '
        Me.ButReadSVMax.Location = New System.Drawing.Point(628, 442)
        Me.ButReadSVMax.Name = "ButReadSVMax"
        Me.ButReadSVMax.Size = New System.Drawing.Size(100, 30)
        Me.ButReadSVMax.TabIndex = 19
        Me.ButReadSVMax.Text = "获取SV最大值"
        Me.ButReadSVMax.UseVisualStyleBackColor = True
        '
        'ButReadSVMin
        '
        Me.ButReadSVMin.Location = New System.Drawing.Point(518, 478)
        Me.ButReadSVMin.Name = "ButReadSVMin"
        Me.ButReadSVMin.Size = New System.Drawing.Size(100, 30)
        Me.ButReadSVMin.TabIndex = 20
        Me.ButReadSVMin.Text = "获取SV最小值"
        Me.ButReadSVMin.UseVisualStyleBackColor = True
        '
        'ButReadSpeed
        '
        Me.ButReadSpeed.Location = New System.Drawing.Point(628, 478)
        Me.ButReadSpeed.Name = "ButReadSpeed"
        Me.ButReadSpeed.Size = New System.Drawing.Size(100, 30)
        Me.ButReadSpeed.TabIndex = 21
        Me.ButReadSpeed.Text = "获取升温速率"
        Me.ButReadSpeed.UseVisualStyleBackColor = True
        '
        'ButStartPID
        '
        Me.ButStartPID.Location = New System.Drawing.Point(518, 250)
        Me.ButStartPID.Name = "ButStartPID"
        Me.ButStartPID.Size = New System.Drawing.Size(100, 30)
        Me.ButStartPID.TabIndex = 22
        Me.ButStartPID.Text = "启动PID自整定"
        Me.ButStartPID.UseVisualStyleBackColor = True
        '
        'ButStopPID
        '
        Me.ButStopPID.Location = New System.Drawing.Point(628, 250)
        Me.ButStopPID.Name = "ButStopPID"
        Me.ButStopPID.Size = New System.Drawing.Size(100, 30)
        Me.ButStopPID.TabIndex = 23
        Me.ButStopPID.Text = "停止PID自整定"
        Me.ButStopPID.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 517)
        Me.Controls.Add(Me.ButStopPID)
        Me.Controls.Add(Me.ButStartPID)
        Me.Controls.Add(Me.ButReadSpeed)
        Me.Controls.Add(Me.ButReadSVMin)
        Me.Controls.Add(Me.ButReadSVMax)
        Me.Controls.Add(Me.ButReadPower)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.LabelPort)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ButStopPaint)
        Me.Controls.Add(Me.ButPaint)
        Me.Controls.Add(Me.ButClear)
        Me.Controls.Add(Me.ButComAddress)
        Me.Controls.Add(Me.ButReadSV)
        Me.Controls.Add(Me.ButSendPV)
        Me.Controls.Add(Me.ButStopPV)
        Me.Controls.Add(Me.ButSetSV)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtPVShow)
        Me.Controls.Add(Me.TxtbufferShow)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ButClose)
        Me.Controls.Add(Me.ButOpen)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "PC410程序智能控温软件"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBoxQC As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxSP As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxPr As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxDB As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxBR As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButOpen As System.Windows.Forms.Button
    Friend WithEvents ButClose As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtDegree As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents ComboBoxName As System.Windows.Forms.ComboBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TxtbufferShow As System.Windows.Forms.TextBox
    Friend WithEvents TxtPVShow As System.Windows.Forms.TextBox
    Friend WithEvents ButSendPV As System.Windows.Forms.Button
    Friend WithEvents ButStopPV As System.Windows.Forms.Button
    Friend WithEvents ButSetSV As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxtSVnow As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ButReadSV As System.Windows.Forms.Button
    Friend WithEvents ButComAddress As System.Windows.Forms.Button
    Friend WithEvents ButClear As System.Windows.Forms.Button
    Friend WithEvents ButPaint As System.Windows.Forms.Button
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents ButStopPaint As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ButSetSC As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtSendCycle As System.Windows.Forms.TextBox
    Friend WithEvents LabelPort As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TxtSpeed As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TxtSVMin As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TxtSVMax As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TxtPower As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ButReadPower As System.Windows.Forms.Button
    Friend WithEvents ButReadSVMax As System.Windows.Forms.Button
    Friend WithEvents ButReadSVMin As System.Windows.Forms.Button
    Friend WithEvents ButReadSpeed As System.Windows.Forms.Button
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents ButStartPID As System.Windows.Forms.Button
    Friend WithEvents ButStopPID As System.Windows.Forms.Button

End Class

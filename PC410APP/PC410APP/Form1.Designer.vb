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
        Me.GroupBox1.Location = New System.Drawing.Point(14, 12)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(318, 350)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PC Serial Port Settings"
        '
        'ComboBoxName
        '
        Me.ComboBoxName.FormattingEnabled = True
        Me.ComboBoxName.Location = New System.Drawing.Point(99, 43)
        Me.ComboBoxName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBoxName.Name = "ComboBoxName"
        Me.ComboBoxName.Size = New System.Drawing.Size(208, 28)
        Me.ComboBoxName.TabIndex = 12
        Me.ComboBoxName.Text = "COM1"
        '
        'ComboBoxQC
        '
        Me.ComboBoxQC.FormattingEnabled = True
        Me.ComboBoxQC.Items.AddRange(New Object() {"None", "RTS", "XOn/XOff", "RTSXOn/XOff"})
        Me.ComboBoxQC.Location = New System.Drawing.Point(98, 280)
        Me.ComboBoxQC.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBoxQC.Name = "ComboBoxQC"
        Me.ComboBoxQC.Size = New System.Drawing.Size(211, 28)
        Me.ComboBoxQC.TabIndex = 11
        Me.ComboBoxQC.Text = "None"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 285)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Flow Control："
        '
        'ComboBoxSP
        '
        Me.ComboBoxSP.FormattingEnabled = True
        Me.ComboBoxSP.Items.AddRange(New Object() {"1", "1.5", "2"})
        Me.ComboBoxSP.Location = New System.Drawing.Point(99, 237)
        Me.ComboBoxSP.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBoxSP.Name = "ComboBoxSP"
        Me.ComboBoxSP.Size = New System.Drawing.Size(211, 28)
        Me.ComboBoxSP.TabIndex = 9
        Me.ComboBoxSP.Text = "1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 242)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Stop bit："
        '
        'ComboBoxPr
        '
        Me.ComboBoxPr.FormattingEnabled = True
        Me.ComboBoxPr.Items.AddRange(New Object() {"None", "Even", "Odd", "Mark", "Space"})
        Me.ComboBoxPr.Location = New System.Drawing.Point(98, 193)
        Me.ComboBoxPr.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBoxPr.Name = "ComboBoxPr"
        Me.ComboBoxPr.Size = New System.Drawing.Size(211, 28)
        Me.ComboBoxPr.TabIndex = 7
        Me.ComboBoxPr.Text = "Even"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 198)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Check Digit："
        '
        'ComboBoxDB
        '
        Me.ComboBoxDB.FormattingEnabled = True
        Me.ComboBoxDB.Items.AddRange(New Object() {"5", "6", "7", "8"})
        Me.ComboBoxDB.Location = New System.Drawing.Point(98, 143)
        Me.ComboBoxDB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBoxDB.Name = "ComboBoxDB"
        Me.ComboBoxDB.Size = New System.Drawing.Size(212, 28)
        Me.ComboBoxDB.TabIndex = 5
        Me.ComboBoxDB.Text = "7"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 143)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Data Bits："
        '
        'ComboBoxBR
        '
        Me.ComboBoxBR.FormattingEnabled = True
        Me.ComboBoxBR.Items.AddRange(New Object() {"300", "600", "1200", "2400", "4800", "9600", "19200"})
        Me.ComboBoxBR.Location = New System.Drawing.Point(98, 92)
        Me.ComboBoxBR.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBoxBR.Name = "ComboBoxBR"
        Me.ComboBoxBR.Size = New System.Drawing.Size(211, 28)
        Me.ComboBoxBR.TabIndex = 3
        Me.ComboBoxBR.Text = "9600"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 97)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Baud Rate："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 50)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Port Name："
        '
        'ButOpen
        '
        Me.ButOpen.Location = New System.Drawing.Point(14, 382)
        Me.ButOpen.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButOpen.Name = "ButOpen"
        Me.ButOpen.Size = New System.Drawing.Size(150, 50)
        Me.ButOpen.TabIndex = 1
        Me.ButOpen.Text = "Open Serial Port"
        Me.ButOpen.UseVisualStyleBackColor = True
        '
        'ButClose
        '
        Me.ButClose.Location = New System.Drawing.Point(182, 382)
        Me.ButClose.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButClose.Name = "ButClose"
        Me.ButClose.Size = New System.Drawing.Size(150, 50)
        Me.ButClose.TabIndex = 2
        Me.ButClose.Text = "Close Serial Port"
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
        Me.GroupBox2.Location = New System.Drawing.Point(777, 15)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(315, 217)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Instrument Settings"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(257, 95)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(21, 20)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "℃"
        '
        'TxtSVnow
        '
        Me.TxtSVnow.Location = New System.Drawing.Point(157, 88)
        Me.TxtSVnow.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtSVnow.Name = "TxtSVnow"
        Me.TxtSVnow.Size = New System.Drawing.Size(92, 26)
        Me.TxtSVnow.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(18, 95)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(137, 20)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Current SV Value:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(257, 147)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(21, 20)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "℃"
        '
        'TxtDegree
        '
        Me.TxtDegree.Location = New System.Drawing.Point(157, 142)
        Me.TxtDegree.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtDegree.Name = "TxtDegree"
        Me.TxtDegree.Size = New System.Drawing.Size(92, 26)
        Me.TxtDegree.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 147)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 20)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Set Temp:"
        '
        'TxtAddress
        '
        Me.TxtAddress.Location = New System.Drawing.Point(157, 41)
        Me.TxtAddress.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(133, 26)
        Me.TxtAddress.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 47)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Address:"
        '
        'ButSetSV
        '
        Me.ButSetSV.Location = New System.Drawing.Point(942, 297)
        Me.ButSetSV.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButSetSV.Name = "ButSetSV"
        Me.ButSetSV.Size = New System.Drawing.Size(150, 50)
        Me.ButSetSV.TabIndex = 7
        Me.ButSetSV.Text = "Set SV"
        Me.ButSetSV.UseVisualStyleBackColor = True
        '
        'ButStopPV
        '
        Me.ButStopPV.Location = New System.Drawing.Point(514, 797)
        Me.ButStopPV.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButStopPV.Name = "ButStopPV"
        Me.ButStopPV.Size = New System.Drawing.Size(150, 50)
        Me.ButStopPV.TabIndex = 6
        Me.ButStopPV.Text = "Stop Reading PV"
        Me.ButStopPV.UseVisualStyleBackColor = True
        '
        'ButSendPV
        '
        Me.ButSendPV.Location = New System.Drawing.Point(356, 797)
        Me.ButSendPV.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButSendPV.Name = "ButSendPV"
        Me.ButSendPV.Size = New System.Drawing.Size(150, 50)
        Me.ButSendPV.TabIndex = 5
        Me.ButSendPV.Text = "Start Reading PV"
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
        Me.TxtbufferShow.Location = New System.Drawing.Point(356, 47)
        Me.TxtbufferShow.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtbufferShow.Multiline = True
        Me.TxtbufferShow.Name = "TxtbufferShow"
        Me.TxtbufferShow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtbufferShow.Size = New System.Drawing.Size(391, 357)
        Me.TxtbufferShow.TabIndex = 4
        '
        'TxtPVShow
        '
        Me.TxtPVShow.Location = New System.Drawing.Point(356, 472)
        Me.TxtPVShow.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtPVShow.Multiline = True
        Me.TxtPVShow.Name = "TxtPVShow"
        Me.TxtPVShow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtPVShow.Size = New System.Drawing.Size(391, 312)
        Me.TxtPVShow.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(352, 15)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(215, 20)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Feedback Command Frame："
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(352, 432)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(140, 20)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Current PV Value："
        '
        'ButReadSV
        '
        Me.ButReadSV.Location = New System.Drawing.Point(777, 297)
        Me.ButReadSV.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButReadSV.Name = "ButReadSV"
        Me.ButReadSV.Size = New System.Drawing.Size(150, 50)
        Me.ButReadSV.TabIndex = 10
        Me.ButReadSV.Text = "Read SV"
        Me.ButReadSV.UseVisualStyleBackColor = True
        '
        'ButComAddress
        '
        Me.ButComAddress.Location = New System.Drawing.Point(862, 242)
        Me.ButComAddress.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButComAddress.Name = "ButComAddress"
        Me.ButComAddress.Size = New System.Drawing.Size(150, 50)
        Me.ButComAddress.TabIndex = 11
        Me.ButComAddress.Text = "Set The Address"
        Me.ButComAddress.UseVisualStyleBackColor = True
        '
        'ButClear
        '
        Me.ButClear.Location = New System.Drawing.Point(674, 797)
        Me.ButClear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButClear.Name = "ButClear"
        Me.ButClear.Size = New System.Drawing.Size(75, 50)
        Me.ButClear.TabIndex = 12
        Me.ButClear.Text = "Clear"
        Me.ButClear.UseVisualStyleBackColor = True
        '
        'ButPaint
        '
        Me.ButPaint.Location = New System.Drawing.Point(777, 357)
        Me.ButPaint.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButPaint.Name = "ButPaint"
        Me.ButPaint.Size = New System.Drawing.Size(150, 50)
        Me.ButPaint.TabIndex = 13
        Me.ButPaint.Text = "Start Paint"
        Me.ButPaint.UseVisualStyleBackColor = True
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'ButStopPaint
        '
        Me.ButStopPaint.Location = New System.Drawing.Point(942, 357)
        Me.ButStopPaint.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButStopPaint.Name = "ButStopPaint"
        Me.ButStopPaint.Size = New System.Drawing.Size(150, 50)
        Me.ButStopPaint.TabIndex = 14
        Me.ButStopPaint.Text = "Stop Paint"
        Me.ButStopPaint.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.ButSetSC)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.TxtSendCycle)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 557)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Size = New System.Drawing.Size(318, 160)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Period Setting"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(284, 60)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(30, 20)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "ms"
        '
        'ButSetSC
        '
        Me.ButSetSC.Location = New System.Drawing.Point(84, 95)
        Me.ButSetSC.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButSetSC.Name = "ButSetSC"
        Me.ButSetSC.Size = New System.Drawing.Size(150, 50)
        Me.ButSetSC.TabIndex = 2
        Me.ButSetSC.Text = "Set Sending Period"
        Me.ButSetSC.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(16, 60)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 20)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Send Cycle："
        '
        'TxtSendCycle
        '
        Me.TxtSendCycle.Location = New System.Drawing.Point(120, 50)
        Me.TxtSendCycle.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtSendCycle.Name = "TxtSendCycle"
        Me.TxtSendCycle.Size = New System.Drawing.Size(148, 26)
        Me.TxtSendCycle.TabIndex = 0
        '
        'LabelPort
        '
        Me.LabelPort.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPort.Location = New System.Drawing.Point(27, 472)
        Me.LabelPort.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelPort.Name = "LabelPort"
        Me.LabelPort.Size = New System.Drawing.Size(294, 57)
        Me.LabelPort.TabIndex = 16
        Me.LabelPort.Text = "         "
        Me.LabelPort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.GroupBox4.Location = New System.Drawing.Point(777, 477)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox4.Size = New System.Drawing.Size(315, 250)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Instrument Parameters"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(254, 43)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(24, 20)
        Me.Label23.TabIndex = 11
        Me.Label23.Text = "W"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(254, 133)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(21, 20)
        Me.Label22.TabIndex = 10
        Me.Label22.Text = "℃"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(254, 86)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(21, 20)
        Me.Label21.TabIndex = 9
        Me.Label21.Text = "℃"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(242, 177)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(33, 20)
        Me.Label20.TabIndex = 8
        Me.Label20.Text = "℃/s"
        '
        'TxtSpeed
        '
        Me.TxtSpeed.Location = New System.Drawing.Point(157, 171)
        Me.TxtSpeed.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtSpeed.Name = "TxtSpeed"
        Me.TxtSpeed.Size = New System.Drawing.Size(96, 26)
        Me.TxtSpeed.TabIndex = 7
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(9, 177)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(108, 20)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "Heating Rate:"
        '
        'TxtSVMin
        '
        Me.TxtSVMin.Location = New System.Drawing.Point(157, 124)
        Me.TxtSVMin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtSVMin.Name = "TxtSVMin"
        Me.TxtSVMin.Size = New System.Drawing.Size(96, 26)
        Me.TxtSVMin.TabIndex = 5
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(9, 127)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 20)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "SV Min:"
        '
        'TxtSVMax
        '
        Me.TxtSVMax.Location = New System.Drawing.Point(157, 73)
        Me.TxtSVMax.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtSVMax.Name = "TxtSVMax"
        Me.TxtSVMax.Size = New System.Drawing.Size(96, 26)
        Me.TxtSVMax.TabIndex = 3
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(9, 87)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 20)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "SV Max:"
        '
        'TxtPower
        '
        Me.TxtPower.Location = New System.Drawing.Point(157, 37)
        Me.TxtPower.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtPower.Name = "TxtPower"
        Me.TxtPower.Size = New System.Drawing.Size(96, 26)
        Me.TxtPower.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(9, 42)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(110, 20)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Output Power:"
        '
        'ButReadPower
        '
        Me.ButReadPower.Location = New System.Drawing.Point(777, 737)
        Me.ButReadPower.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButReadPower.Name = "ButReadPower"
        Me.ButReadPower.Size = New System.Drawing.Size(150, 50)
        Me.ButReadPower.TabIndex = 18
        Me.ButReadPower.Text = "Get Power"
        Me.ButReadPower.UseVisualStyleBackColor = True
        '
        'ButReadSVMax
        '
        Me.ButReadSVMax.Location = New System.Drawing.Point(942, 737)
        Me.ButReadSVMax.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButReadSVMax.Name = "ButReadSVMax"
        Me.ButReadSVMax.Size = New System.Drawing.Size(150, 50)
        Me.ButReadSVMax.TabIndex = 19
        Me.ButReadSVMax.Text = "Get SV Max"
        Me.ButReadSVMax.UseVisualStyleBackColor = True
        '
        'ButReadSVMin
        '
        Me.ButReadSVMin.Location = New System.Drawing.Point(777, 797)
        Me.ButReadSVMin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButReadSVMin.Name = "ButReadSVMin"
        Me.ButReadSVMin.Size = New System.Drawing.Size(150, 50)
        Me.ButReadSVMin.TabIndex = 20
        Me.ButReadSVMin.Text = "Get SV Min"
        Me.ButReadSVMin.UseVisualStyleBackColor = True
        '
        'ButReadSpeed
        '
        Me.ButReadSpeed.Location = New System.Drawing.Point(942, 797)
        Me.ButReadSpeed.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButReadSpeed.Name = "ButReadSpeed"
        Me.ButReadSpeed.Size = New System.Drawing.Size(150, 50)
        Me.ButReadSpeed.TabIndex = 21
        Me.ButReadSpeed.Text = "Get Heating Rate"
        Me.ButReadSpeed.UseVisualStyleBackColor = True
        '
        'ButStartPID
        '
        Me.ButStartPID.Location = New System.Drawing.Point(777, 417)
        Me.ButStartPID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButStartPID.Name = "ButStartPID"
        Me.ButStartPID.Size = New System.Drawing.Size(150, 50)
        Me.ButStartPID.TabIndex = 22
        Me.ButStartPID.Text = "Start PID Auto Tuning"
        Me.ButStartPID.UseVisualStyleBackColor = True
        '
        'ButStopPID
        '
        Me.ButStopPID.Location = New System.Drawing.Point(942, 417)
        Me.ButStopPID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButStopPID.Name = "ButStopPID"
        Me.ButStopPID.Size = New System.Drawing.Size(150, 50)
        Me.ButStopPID.TabIndex = 23
        Me.ButStopPID.Text = "Stop Pid Auto Tuning"
        Me.ButStopPID.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1125, 862)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "PC410 program intelligent temperature control software"
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

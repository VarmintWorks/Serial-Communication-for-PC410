Option Explicit On
Option Strict Off
Imports System
Imports System.IO.Ports
Public Class Form1
    'Inherits System.Windows.Forms.Form
    Dim buffer As String
    Dim strBuffer As String
    Dim strPVD As String     'PV值
    Dim strSVD As String     'SV值
    Dim r1 As String     '地址第一位数
    Dim r2 As String     '地址第二位数
    Dim myForm2 As New Form2     '绘制图像窗体
    Delegate Sub DataBackThread(ByVal strDataBack As String)  '定义委托
    Dim DataBack1 As New DataBackThread(AddressOf ShowBuffer)
    Dim DataBack2 As New DataBackThread(AddressOf ShowPVData)
    '显示结果(定义一个实例)
    Private Sub ShowBuffer(ByVal BufferData As String)
        Me.TxtbufferShow.Text = Me.TxtbufferShow.Text & BufferData & vbCrLf
    End Sub

    Private Sub ShowPVData(ByVal PVData As String)
        Me.TxtPVShow.AppendText(PVData & vbCrLf)
    End Sub
    '判断是否为跨线程
    Private Sub DisPlayBufferData(ByVal strTemp As String)
        If Me.TxtbufferShow.InvokeRequired Then
            Me.Invoke(DataBack1, New Object() {strTemp})
        Else
            Me.TxtbufferShow.Text = Me.TxtbufferShow.Text & strTemp & vbCrLf
        End If
    End Sub

    Private Sub DisplayPVData(ByVal strTemp As String)
        If Me.TxtPVShow.InvokeRequired Then
            Me.Invoke(DataBack2, New Object() {strTemp})
        Else
            Me.TxtPVShow.AppendText(strTemp & vbCrLf)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        strPVD = ""
        strSVD = ""
        myForm2.Hide()
        COMPortName()
        If SerialPort1.IsOpen = True Then
            LabelPort.Text = "串口已打开"
            LabelPort.ForeColor = Color.Green
        Else
            LabelPort.Text = "串口已关闭"
            LabelPort.ForeColor = Color.Red
        End If
    End Sub

    Private Sub ComboBoxName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxName.SelectedIndexChanged
        SerialPort1.PortName = ComboBoxName.Text
    End Sub

    Private Sub ComboBoxBR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxBR.SelectedIndexChanged
        SerialPort1.BaudRate = Val(ComboBoxBR.Text)
    End Sub

    Private Sub ComboBoxDB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxDB.SelectedIndexChanged
        SerialPort1.DataBits = Val(ComboBoxDB.Text)
    End Sub

    Private Sub ComboBoxPr_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPr.SelectedIndexChanged
        Select Case ComboBoxPr.Text
            Case "None"
                SerialPort1.Parity = IO.Ports.Parity.None
                Exit Select
            Case "Even"
                SerialPort1.Parity = IO.Ports.Parity.Even
                Exit Select
            Case "Odd"
                SerialPort1.Parity = IO.Ports.Parity.Odd
                Exit Select
            Case "Mark"
                SerialPort1.Parity = IO.Ports.Parity.Mark
                Exit Select
            Case "Space"
                SerialPort1.Parity = IO.Ports.Parity.Space
                Exit Select
        End Select
    End Sub

    Private Sub ComboBoxSP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSP.SelectedIndexChanged
        Select Case ComboBoxSP.Text
            Case "1"
                SerialPort1.StopBits = IO.Ports.StopBits.One
                Exit Select
            Case "1.5"
                SerialPort1.StopBits = IO.Ports.StopBits.OnePointFive
                Exit Select
            Case "2"
                SerialPort1.StopBits = IO.Ports.StopBits.Two
        End Select
    End Sub

    Private Sub ComboBoxQC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxQC.SelectedIndexChanged
        Select Case ComboBoxQC.Text
            Case "None"
                SerialPort1.Handshake = IO.Ports.Handshake.None
                Exit Select
            Case "RTS"
                SerialPort1.Handshake = IO.Ports.Handshake.RequestToSend
                Exit Select
            Case "XOn/XOff"
                SerialPort1.Handshake = IO.Ports.Handshake.XOnXOff
                Exit Select
            Case "RTSXOn/XOff"
                SerialPort1.Handshake = IO.Ports.Handshake.RequestToSendXOnXOff
        End Select
    End Sub

    Private Sub ButOpen_Click(sender As Object, e As EventArgs) Handles ButOpen.Click
        SerialPort1.ReceivedBytesThreshold = 10
        SerialPort1.Encoding = System.Text.Encoding.Default
        SerialPort1.Open()
        If SerialPort1.IsOpen = True Then
            LabelPort.Text = "串口已打开"
            LabelPort.ForeColor = Color.Green
        Else
            LabelPort.Text = "串口已关闭"
            LabelPort.ForeColor = Color.Red
            SerialPort1.Open()
        End If
    End Sub

    Private Sub ButClose_Click(sender As Object, e As EventArgs) Handles ButClose.Click
        SerialPort1.Close()
        If SerialPort1.IsOpen = True Then
            LabelPort.Text = "串口已打开"
            LabelPort.ForeColor = Color.Green
            SerialPort1.Close()
        Else
            LabelPort.Text = "串口已关闭"
            LabelPort.ForeColor = Color.Red
        End If
    End Sub
    '读取PV值
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        SerialPort1.ReceivedBytesThreshold = 10
        SendOrderReadPV()
    End Sub
    '接收仪器应答命令帧
    Private Sub SerialPort1_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        ReadCOMData()
        DisPlayBufferData(buffer)   '文本框显示接收到的命令帧
        ChooseReadPath()
        'Me.Invoke(New EventHandler(AddressOf ChooseReadPath))  '调用函数
    End Sub

    Private Sub ButSendPV_Click(sender As Object, e As EventArgs) Handles ButSendPV.Click
        Timer1.Start()
    End Sub

    Private Sub ButStopPV_Click(sender As Object, e As EventArgs) Handles ButStopPV.Click
        Timer1.Stop()
    End Sub

    Private Sub ButSetSV_Click(sender As Object, e As EventArgs) Handles ButSetSV.Click
        If Timer1.Enabled = True Then
            MsgBox("请先停止读取PV值！")
        Else
            SerialPort1.ReceivedBytesThreshold = 1
            SendOrderSetSV()
        End If
    End Sub

    Private Sub ButReadSV_Click(sender As Object, e As EventArgs) Handles ButReadSV.Click
        If Timer1.Enabled = True Then
            MsgBox("请先停止读取PV值！")
        Else
            SerialPort1.ReceivedBytesThreshold = 10
            SendOrderReadSV()
        End If
    End Sub
    '初始化通讯地址
    Private Sub ButComAddress_Click(sender As Object, e As EventArgs) Handles ButComAddress.Click
        Dim t1, t2 As Char
        t1 = Mid(TxtAddress.Text, 1, 1)
        t2 = Mid(TxtAddress.Text, 2, 1)
        r1 = Hex(Asc(Val(t1)))
        r2 = Hex(Asc(Val(t2)))
    End Sub
    '清空监视窗口
    Private Sub ButClear_Click(sender As Object, e As EventArgs) Handles ButClear.Click
        TxtbufferShow.Text = ""
        TxtPVShow.Clear()
    End Sub
    '绘图
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Draw()
    End Sub

    Private Sub ButPaint_Click(sender As Object, e As EventArgs) Handles ButPaint.Click
        myForm2.Show()
        Timer2.Start()
    End Sub

    Private Sub ButStopPaint_Click(sender As Object, e As EventArgs) Handles ButStopPaint.Click
        myForm2.Hide()
        Timer2.Stop()
    End Sub
    '设置发送读取PV值命令的频率
    Private Sub ButSetSC_Click(sender As Object, e As EventArgs) Handles ButSetSC.Click
        If Timer1.Enabled = True Then
            MsgBox("请先停止读取PV值！")
        Else
            Timer1.Interval = Val(TxtSendCycle.Text)
        End If
    End Sub
    '读取输出功率
    Private Sub ButReadPower_Click(sender As Object, e As EventArgs) Handles ButReadPower.Click
        If Timer1.Enabled = True Then
            MsgBox("请先停止读取PV值！")
        Else
            SerialPort1.ReceivedBytesThreshold = 10
            SendOrderPower()
        End If
    End Sub
    '读取SV最大值
    Private Sub ButReadSVMax_Click(sender As Object, e As EventArgs) Handles ButReadSVMax.Click
        If Timer1.Enabled = True Then
            MsgBox("请先停止读取PV值！")
        Else
            SerialPort1.ReceivedBytesThreshold = 10
            SendOrderSVMax()
        End If
    End Sub
    '读取SV最小值
    Private Sub ButReadSVMin_Click(sender As Object, e As EventArgs) Handles ButReadSVMin.Click
        If Timer1.Enabled = True Then
            MsgBox("请先停止读取PV值！")
        Else
            SerialPort1.ReceivedBytesThreshold = 10
            SendOrderSVMin()
        End If
    End Sub
    '读取升温速率
    Private Sub ButReadSpeed_Click(sender As Object, e As EventArgs) Handles ButReadSpeed.Click
        If Timer1.Enabled = True Then
            MsgBox("请先停止读取PV值！")
        Else
            SerialPort1.ReceivedBytesThreshold = 10
            SendOrderSpeed()
        End If
    End Sub
    '启动PID自整定
    Private Sub ButStartPID_Click(sender As Object, e As EventArgs) Handles ButStartPID.Click
        MsgBox("请勿改变SV值！改变SV值前请先停止PID自整定！")
        If Timer1.Enabled = True Then
            MsgBox("请先停止读取SV值！")
        Else
            SerialPort1.ReceivedBytesThreshold = 1
            SendOrderStartPID()
        End If
    End Sub
    '停止PID自整定
    Private Sub ButStopPID_Click(sender As Object, e As EventArgs) Handles ButStopPID.Click
        If Timer1.Enabled = True Then
            MsgBox("请先停止读取PV值！")
        Else
            SerialPort1.ReceivedBytesThreshold = 1
            SendOrderStopPID()
        End If
    End Sub
    '获取主机串口名称
    Private Sub COMPortName()
        Dim strPortName As String()
        Dim i As Short
        strPortName = SerialPort.GetPortNames()
        For i = LBound(strPortName) To UBound(strPortName)
            ComboBoxName.Items.Add(strPortName(i))
        Next
    End Sub
    '读取PV值
    Private Sub SendOrderReadPV()
        Dim OrderPV(8) As Byte
        OrderPV(0) = Val("&H" & "04")
        OrderPV(1) = Val("&H" & r1)
        OrderPV(2) = Val("&H" & r1)
        OrderPV(3) = Val("&H" & r2)
        OrderPV(4) = Val("&H" & r2)
        OrderPV(5) = Val("&H" & "50")
        OrderPV(6) = Val("&H" & "56")
        OrderPV(7) = Val("&H" & "05")
        SerialPort1.Write(OrderPV, 0, 8) '请求PV值命令(16进制)
    End Sub
    '读取SV值
    Private Sub SendOrderReadSV()
        Dim OrderSV(8) As Byte
        OrderSV(0) = Val("&H" & "04")
        OrderSV(1) = Val("&H" & r1)
        OrderSV(2) = Val("&H" & r1)
        OrderSV(3) = Val("&H" & r2)
        OrderSV(4) = Val("&H" & r2)
        OrderSV(5) = Val("&H" & "53")
        OrderSV(6) = Val("&H" & "50")
        OrderSV(7) = Val("&H" & "05")
        SerialPort1.Write(OrderSV, 0, 8)   '读取SV值命令（16进制）
    End Sub
    '设置SV值
    Private Sub SendOrderSetSV()
        Dim t1, t2, t3 As Char
        Dim d1, d2, d3 As String
        Dim OrderSet(13) As Byte
        Dim BCC, BCCTemp As String
        If Len(TxtDegree.Text) = 3 Then
            t1 = Mid(TxtDegree.Text, 1, 1)
            t2 = Mid(TxtDegree.Text, 2, 1)
            t3 = Mid(TxtDegree.Text, 3, 1)
        Else
            t1 = "0"
            t2 = Mid(TxtDegree.Text, 1, 1)
            t3 = Mid(TxtDegree.Text, 2, 1)
        End If
        d1 = Hex(Asc(Val(t1)))
        d2 = Hex(Asc(Val(t2)))
        d3 = Hex(Asc(Val(t3)))
        BCCTemp = Convert.ToByte("53", 16) Xor Convert.ToByte("4C", 16) Xor Convert.ToByte(d1, 16) Xor Convert.ToByte(d2, 16) Xor Convert.ToByte(d3, 16) Xor Convert.ToByte("03", 16)  '计算BCC命令帧校验位的值
        BCC = Hex(BCCTemp)
        OrderSet(0) = Val("&H" & "04")
        OrderSet(1) = Val("&H" & r1)
        OrderSet(2) = Val("&H" & r1)
        OrderSet(3) = Val("&H" & r2)
        OrderSet(4) = Val("&H" & r2)
        OrderSet(5) = Val("&H" & "02")
        OrderSet(6) = Val("&H" & "53")
        OrderSet(7) = Val("&H" & "4C")
        OrderSet(8) = Val("&H" & d1)
        OrderSet(9) = Val("&H" & d2)
        OrderSet(10) = Val("&H" & d3)
        OrderSet(11) = Val("&H" & "03")
        OrderSet(12) = Val("&H" & BCC)
        SerialPort1.Write(OrderSet, 0, 13) '发送修改SV值的命令(16进制)
    End Sub
    '读取输出功率
    Private Sub SendOrderPower()
        Dim OrderPower(8) As Byte
        OrderPower(0) = Val("&H" & "04")
        OrderPower(1) = Val("&H" & r1)
        OrderPower(2) = Val("&H" & r1)
        OrderPower(3) = Val("&H" & r2)
        OrderPower(4) = Val("&H" & r2)
        OrderPower(5) = Val("&H" & "4F")
        OrderPower(6) = Val("&H" & "50")
        OrderPower(7) = Val("&H" & "05")
        SerialPort1.Write(OrderPower, 0, 8)
    End Sub
    '读取SV最大设定值
    Private Sub SendOrderSVMax()
        Dim OrderSVMax(8) As Byte
        OrderSVMax(0) = Val("&H" & "04")
        OrderSVMax(1) = Val("&H" & r1)
        OrderSVMax(2) = Val("&H" & r1)
        OrderSVMax(3) = Val("&H" & r2)
        OrderSVMax(4) = Val("&H" & r2)
        OrderSVMax(5) = Val("&H" & "48")
        OrderSVMax(6) = Val("&H" & "53")
        OrderSVMax(7) = Val("&H" & "05")
        SerialPort1.Write(OrderSVMax, 0, 8)
    End Sub
    '读取SV最小设定值
    Private Sub SendOrderSVMin()
        Dim OrderSVMin(8) As Byte
        OrderSVMin(0) = Val("&H" & "04")
        OrderSVMin(1) = Val("&H" & r1)
        OrderSVMin(2) = Val("&H" & r1)
        OrderSVMin(3) = Val("&H" & r2)
        OrderSVMin(4) = Val("&H" & r2)
        OrderSVMin(5) = Val("&H" & "4C")
        OrderSVMin(6) = Val("&H" & "53")
        OrderSVMin(7) = Val("&H" & "05")
        SerialPort1.Write(OrderSVMin, 0, 8)
    End Sub
    '读取升温速率
    Private Sub SendOrderSpeed()
        Dim OrderSpeed(8) As Byte
        OrderSpeed(0) = Val("&H" & "04")
        OrderSpeed(1) = Val("&H" & r1)
        OrderSpeed(2) = Val("&H" & r1)
        OrderSpeed(3) = Val("&H" & r2)
        OrderSpeed(4) = Val("&H" & r2)
        OrderSpeed(5) = Val("&H" & "53")
        OrderSpeed(6) = Val("&H" & "52")
        OrderSpeed(7) = Val("&H" & "05")
        SerialPort1.Write(OrderSpeed, 0, 8)
    End Sub
    '启动PID自整定
    Private Sub SendOrderStartPID()
        Dim OrderPID(14) As Byte
        Dim BCCTemp, BCC As String
        BCCTemp = Convert.ToByte("23", 16) Xor Convert.ToByte("34", 16) Xor Convert.ToByte("0", 16) Xor Convert.ToByte("0", 16) Xor Convert.ToByte("0", 16) Xor Convert.ToByte("1", 16) Xor Convert.ToByte("03", 16)  '计算BCC命令帧校验位的值
        BCC = Hex(BCCTemp)
        OrderPID(0) = Val("&H" & "04")
        OrderPID(1) = Val("&H" & r1)
        OrderPID(2) = Val("&H" & r1)
        OrderPID(3) = Val("&H" & r2)
        OrderPID(4) = Val("&H" & r2)
        OrderPID(5) = Val("&H" & "02")
        OrderPID(6) = Val("&H" & "23")
        OrderPID(7) = Val("&H" & "34")
        OrderPID(8) = Val("&H" & "0")
        OrderPID(9) = Val("&H" & "0")
        OrderPID(10) = Val("&H" & "0")
        OrderPID(11) = Val("&H" & "1")
        OrderPID(12) = Val("&H" & "03")
        OrderPID(13) = Val("&H" & BCC)
        SerialPort1.Write(OrderPID, 0, 14)
    End Sub
    '停止PID自整定
    Private Sub SendOrderStopPID()
        Dim OrderPID(14) As Byte
        Dim BCCTemp, BCC As String
        BCCTemp = Convert.ToByte("23", 16) Xor Convert.ToByte("34", 16) Xor Convert.ToByte("0", 16) Xor Convert.ToByte("0", 16) Xor Convert.ToByte("0", 16) Xor Convert.ToByte("0", 16) Xor Convert.ToByte("03", 16)  '计算BCC命令帧校验位的值
        BCC = Hex(BCCTemp)
        OrderPID(0) = Val("&H" & "04")
        OrderPID(1) = Val("&H" & r1)
        OrderPID(2) = Val("&H" & r1)
        OrderPID(3) = Val("&H" & r2)
        OrderPID(4) = Val("&H" & r2)
        OrderPID(5) = Val("&H" & "02")
        OrderPID(6) = Val("&H" & "23")
        OrderPID(7) = Val("&H" & "34")
        OrderPID(8) = Val("&H" & "0")
        OrderPID(9) = Val("&H" & "0")
        OrderPID(10) = Val("&H" & "0")
        OrderPID(11) = Val("&H" & "0")
        OrderPID(12) = Val("&H" & "03")
        OrderPID(13) = Val("&H" & BCC)
        SerialPort1.Write(OrderPID, 0, 14)
    End Sub
    '读取仪器应答命令帧
    Private Sub ReadCOMData()
        Dim i As Integer
        Dim ByteToRead As Integer
        Dim Inbyte() As Byte
        ByteToRead = SerialPort1.BytesToRead
        buffer = ""
        ReDim Inbyte(ByteToRead)
        SerialPort1.Read(Inbyte, 0, ByteToRead)   '读取接收缓冲区内的命令帧
        For i = LBound(Inbyte) To UBound(Inbyte)
            buffer = buffer & Hex(Inbyte(i)) & Chr(32)
        Next i
        strBuffer = buffer.Replace(" ", "")
    End Sub
    '选择读取方式
    Private Sub ChooseReadPath()
        If Len(strBuffer) = 2 Or Len(strBuffer) = 3 Then
            SetSuccess()
        Else
            SelectPath()
        End If
    End Sub

    Private Sub SelectPath()
        Dim str1 As String
        str1 = Mid(strBuffer, 2, 4)
        Select Case str1
            Case "5056"    'PV
                ReadPVData()
                Exit Select
            Case "5350"    'SV
                ReadSVData()
                Exit Select
            Case "4F50"    'Power
                ReadPower()
                Exit Select
            Case "4853"    'SVMax
                ReadSVMax()
                Exit Select
            Case "4C53"    'SVMin
                ReadSVMin()
                Exit Select
            Case "5352"    'Speed
                ReadSpeed()
                Exit Select
            Case Else
                Exit Select
        End Select
    End Sub
    '读取PV值并存储
    Private Sub ReadPVData()
        Dim strRx As String
        'strRx = SerialPort1.ReadExisting.ToString    '读取来自串口的接收缓冲区的全部数据
        'If SerialPort1.BytesToRead > 0 Then
        '    Threading.Thread.Sleep(10)
        '    strRx = SerialPort1.ReadExisting.ToString    '读取来自串口的接收缓冲区的全部数据
        '    SerialPort1.DiscardInBuffer()    '丢弃来自串口的接收缓冲区的数据
        'Else
        '    Exit Sub
        'End If
        strRx = Mid(strBuffer, 7, 1) & Mid(strBuffer, 9, 1) & Mid(strBuffer, 11, 1) & Mid(strBuffer, 13, 1)  'PV值的提取
        strRx = strRx.Replace(" ", "")
        strPVD = Str(Val(strRx))
        TxtPVShow.Text = TxtPVShow.Text & strPVD & vbCrLf     '文本框PV值显示
        'DisplayPVData(strPVD)
        Printtext()
    End Sub
    '读取SV值
    Private Sub ReadSVData()
        Dim strRx As String
        strRx = Mid(strBuffer, 7, 1) & Mid(strBuffer, 9, 1) & Mid(strBuffer, 11, 1) & Mid(strBuffer, 13, 1)
        strRx = strRx.Replace(" ", "")
        strSVD = Str(Val(strRx))
        TxtSVnow.Text = strSVD    '文本框显示SV值
    End Sub
    '读取输出功率
    Private Sub ReadPower()
        Dim strPower As String
        Dim strRx As String
        strRx = Mid(strBuffer, 7, 1) & Mid(strBuffer, 9, 1) & Mid(strBuffer, 11, 1) & Mid(strBuffer, 13, 1)
        strRx = strRx.Replace(" ", "")
        strPower = Str(Val(strRx))
        TxtPower.Text = strPower
    End Sub
    '读取SV设定值最大值
    Private Sub ReadSVMax()
        Dim strSVMax As String
        Dim strRx As String
        strRx = Mid(strBuffer, 7, 1) & Mid(strBuffer, 9, 1) & Mid(strBuffer, 11, 1) & Mid(strBuffer, 13, 1)
        strRx = strRx.Replace(" ", "")
        strSVMax = Str(Val(strRx))
        TxtSVMax.Text = strSVMax
    End Sub
    '读取SV设定值最小值
    Private Sub ReadSVMin()
        Dim strSVMin As String
        Dim strRx As String
        strRx = Mid(strBuffer, 7, 1) & Mid(strBuffer, 9, 1) & Mid(strBuffer, 11, 1) & Mid(strBuffer, 13, 1)
        strRx = strRx.Replace(" ", "")
        strSVMin = Str(Val(strRx))
        TxtSVMin.Text = strSVMin
    End Sub
    '读取升温速率
    Private Sub ReadSpeed()
        Dim strSpeed As String
        Dim strRx As String
        strRx = Mid(strBuffer, 7, 1) & Mid(strBuffer, 9, 1) & Mid(strBuffer, 11, 1) & Mid(strBuffer, 13, 1)
        strRx = strRx.Replace(" ", "")
        strSpeed = Str(Val(strRx))
        TxtSpeed.Text = strSpeed
    End Sub
    '检测设定值是否成功
    Private Sub SetSuccess()
        If strBuffer = "60" Then
            MsgBox("修改成功！", MsgBoxStyle.Information)
        ElseIf strBuffer = "150" Then
            MsgBox("修改失败！", MsgBoxStyle.Exclamation)
        End If
    End Sub
    '数据记录文本输出
    Private Sub Printtext()
        Dim TimeNow As Date
        TimeNow = TimeOfDay
        FileOpen(1, My.Application.Info.DirectoryPath & "\PC410text.txt", OpenMode.Append)
        PrintLine(1, TimeNow, strSVD, strPVD)
        FileClose(1)
        'My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath & "\PC410text.txt", TimeNow & strSVD & strPVD, True)
    End Sub
    '绘制图像
    Private Sub Draw()
        Dim Ypv As Short
        Dim Ysv As Short
        Static i As Integer = 0   '秒数
        i = i + 1
        Ypv = Val(strPVD)
        Ysv = Val(strSVD)
        myForm2.PaintPV(i, Ypv)
        myForm2.PaintSV(i, Ysv)
    End Sub
End Class

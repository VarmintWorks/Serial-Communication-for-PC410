Option Explicit On
Option Strict Off
Imports System
Imports System.IO.Ports
Public Class Form1
    'Inherits System.Windows.Forms.Form
    Dim buffer As String
    Dim strBuffer As String
    Dim strPVD As String     'PV value
    Dim strSVD As String     'SV value
    Dim r1 As String     'first digit of address
    Dim r2 As String     'second digit of address
    Dim myForm2 As New Form2     'Draw Image form
    Delegate Sub DataBackThread(ByVal strDataBack As String)  'Define delegate
    Dim DataBack1 As New DataBackThread(AddressOf ShowBuffer)
    Dim DataBack2 As New DataBackThread(AddressOf ShowPVData)


    'Display the result (define an instance)
    Private Sub ShowBuffer(ByVal BufferData As String)
        Me.TxtbufferShow.Text = Me.TxtbufferShow.Text & BufferData & vbCrLf
    End Sub

    Private Sub ShowPVData(ByVal PVData As String)
        Me.TxtPVShow.AppendText(PVData & vbCrLf)
    End Sub

    'Determine whether it is cross-thread
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
            LabelPort.Text = "Serial port is open"
            LabelPort.ForeColor = Color.Green
        Else
            LabelPort.Text = "Serial port is closed"
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
            LabelPort.Text = "Serial port is open"
            LabelPort.ForeColor = Color.Green
        Else
            LabelPort.Text = "Serial port is closed"
            LabelPort.ForeColor = Color.Red
            SerialPort1.Open()
        End If
    End Sub

    Private Sub ButClose_Click(sender As Object, e As EventArgs) Handles ButClose.Click
        SerialPort1.Close()
        If SerialPort1.IsOpen = True Then
            LabelPort.Text = "Serial port is open"
            LabelPort.ForeColor = Color.Green
            SerialPort1.Close()
        Else
            LabelPort.Text = "Serial port is closed"
            LabelPort.ForeColor = Color.Red
        End If
    End Sub

    'Read PV value
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        SerialPort1.ReceivedBytesThreshold = 10
        SendOrderReadPV()
    End Sub

    'Receive instrument response command frame
    Private Sub SerialPort1_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        ReadCOMData()
        DisPlayBufferData(buffer)   'Text box showing received command frame
        ChooseReadPath()
        'Me.Invoke(New EventHandler(AddressOf ChooseReadPath))  'Call functions
    End Sub

    Private Sub ButSendPV_Click(sender As Object, e As EventArgs) Handles ButSendPV.Click
        Timer1.Start()
    End Sub

    Private Sub ButStopPV_Click(sender As Object, e As EventArgs) Handles ButStopPV.Click
        Timer1.Stop()
    End Sub

    Private Sub ButSetSV_Click(sender As Object, e As EventArgs) Handles ButSetSV.Click
        If Timer1.Enabled = True Then
            MsgBox("Please stop reading PV value first！")
        Else
            SerialPort1.ReceivedBytesThreshold = 1
            SendOrderSetSV()
        End If
    End Sub

    Private Sub ButReadSV_Click(sender As Object, e As EventArgs) Handles ButReadSV.Click
        If Timer1.Enabled = True Then
            MsgBox("Please stop reading PV value first！")
        Else
            SerialPort1.ReceivedBytesThreshold = 10
            SendOrderReadSV()
        End If
    End Sub

    'Initialize the communication address
    Private Sub ButComAddress_Click(sender As Object, e As EventArgs) Handles ButComAddress.Click
        Dim t1, t2 As Char
        t1 = Mid(TxtAddress.Text, 1, 1)
        t2 = Mid(TxtAddress.Text, 2, 1)
        r1 = Hex(Asc(Val(t1)))
        r2 = Hex(Asc(Val(t2)))
    End Sub

    'Clear the watch window
    Private Sub ButClear_Click(sender As Object, e As EventArgs) Handles ButClear.Click
        TxtbufferShow.Text = ""
        TxtPVShow.Clear()
    End Sub

    'Drawing
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

    'Set how often to send read PV value command
    Private Sub ButSetSC_Click(sender As Object, e As EventArgs) Handles ButSetSC.Click
        If Timer1.Enabled = True Then
            MsgBox("Please stop reading PV value first！")
        Else
            Timer1.Interval = Val(TxtSendCycle.Text)
        End If
    End Sub

    'Read output power
    Private Sub ButReadPower_Click(sender As Object, e As EventArgs) Handles ButReadPower.Click
        If Timer1.Enabled = True Then
            MsgBox("Please stop reading PV value first！")
        Else
            SerialPort1.ReceivedBytesThreshold = 10
            SendOrderPower()
        End If
    End Sub

    'Read SV maximum value
    Private Sub ButReadSVMax_Click(sender As Object, e As EventArgs) Handles ButReadSVMax.Click
        If Timer1.Enabled = True Then
            MsgBox("Please stop reading PV value first！")
        Else
            SerialPort1.ReceivedBytesThreshold = 10
            SendOrderSVMax()
        End If
    End Sub

    'Read SV minimum
    Private Sub ButReadSVMin_Click(sender As Object, e As EventArgs) Handles ButReadSVMin.Click
        If Timer1.Enabled = True Then
            MsgBox("Please stop reading PV value first！")
        Else
            SerialPort1.ReceivedBytesThreshold = 10
            SendOrderSVMin()
        End If
    End Sub

    'Read ramp rate
    Private Sub ButReadSpeed_Click(sender As Object, e As EventArgs) Handles ButReadSpeed.Click
        If Timer1.Enabled = True Then
            MsgBox("Please stop reading PV value first！")
        Else
            SerialPort1.ReceivedBytesThreshold = 10
            SendOrderSpeed()
        End If
    End Sub

    'Start PID auto-tuning
    Private Sub ButStartPID_Click(sender As Object, e As EventArgs) Handles ButStartPID.Click
        MsgBox("Do not change the SV value! Please stop the PID auto-tuning before changing the SV value!")
        If Timer1.Enabled = True Then
            MsgBox("Please stop reading PV value first！")
        Else
            SerialPort1.ReceivedBytesThreshold = 1
            SendOrderStartPID()
        End If
    End Sub

    'Stop PID auto-tuning
    Private Sub ButStopPID_Click(sender As Object, e As EventArgs) Handles ButStopPID.Click
        If Timer1.Enabled = True Then
            MsgBox("Please stop reading PV value first！")
        Else
            SerialPort1.ReceivedBytesThreshold = 1
            SendOrderStopPID()
        End If
    End Sub

    '    Get host serial port name
    Private Sub COMPortName()
        Dim strPortName As String()
        Dim i As Short
        strPortName = SerialPort.GetPortNames()
        For i = LBound(strPortName) To UBound(strPortName)
            ComboBoxName.Items.Add(strPortName(i))
        Next
    End Sub

    'Read PV value
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
        SerialPort1.Write(OrderPV, 0, 8) 'Request PV value command (hexadecimal)
    End Sub

    'Read SV value
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
        SerialPort1.Write(OrderSV, 0, 8)   'Read SV value command (hexadecimal)
    End Sub

    'Set SV value
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
        BCCTemp = Convert.ToByte("53", 16) Xor Convert.ToByte("4C", 16) Xor Convert.ToByte(d1, 16) Xor Convert.ToByte(d2, 16) Xor Convert.ToByte(d3, 16) Xor Convert.ToByte("03", 16)  'Calculate the value of the check digit of the BCC command frame
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
        SerialPort1.Write(OrderSet, 0, 13) 'Send the command to modify the SV value (hexadecimal)
    End Sub

    'read output power
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

    'Read the SV maximum Set value
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

    'Read SV minimum Set value
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

    'Start PID auto-tuning
    Private Sub SendOrderStartPID()
        Dim OrderPID(14) As Byte
        Dim BCCTemp, BCC As String
        BCCTemp = Convert.ToByte("23", 16) Xor Convert.ToByte("34", 16) Xor Convert.ToByte("0", 16) Xor Convert.ToByte("0", 16) Xor Convert.ToByte("0", 16) Xor Convert.ToByte("1", 16) Xor Convert.ToByte("03", 16)  'Calculate the value of the check digit of the BCC command frame
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

    'Stop PID auto-tuning
    Private Sub SendOrderStopPID()
        Dim OrderPID(14) As Byte
        Dim BCCTemp, BCC As String
        BCCTemp = Convert.ToByte("23", 16) Xor Convert.ToByte("34", 16) Xor Convert.ToByte("0", 16) Xor Convert.ToByte("0", 16) Xor Convert.ToByte("0", 16) Xor Convert.ToByte("0", 16) Xor Convert.ToByte("03", 16)  'Calculate the value of the check digit of the BCC command frame
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

    'Read instrument response command frame
    Private Sub ReadCOMData()
        Dim i As Integer
        Dim ByteToRead As Integer
        Dim Inbyte() As Byte
        ByteToRead = SerialPort1.BytesToRead
        buffer = ""
        ReDim Inbyte(ByteToRead)
        SerialPort1.Read(Inbyte, 0, ByteToRead)   'Read the command frame in the receive buffer
        For i = LBound(Inbyte) To UBound(Inbyte)
            buffer = buffer & Hex(Inbyte(i)) & Chr(32)
        Next i
        strBuffer = buffer.Replace(" ", "")
    End Sub

    'Choose how To read
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

    'Read PV value And store
    Private Sub ReadPVData()
        Dim strRx As String
        'strRx = SerialPort1.ReadExisting.ToString    'Read all data from the receive buffer of the serial port
        'If SerialPort1.BytesToRead > 0 Then
        '    Threading.Thread.Sleep(10)
        '    strRx = SerialPort1.ReadExisting.ToString    'Read all data from the receive buffer of the serial port
        '    SerialPort1.DiscardInBuffer()    '        Discard Data from serial port's receive buffer
        'Else
        '    Exit Sub
        'End If
        strRx = Mid(strBuffer, 7, 1) & Mid(strBuffer, 9, 1) & Mid(strBuffer, 11, 1) & Mid(strBuffer, 13, 1)  'Extraction of PV value
        strRx = strRx.Replace(" ", "")
        strPVD = Str(Val(strRx))
        TxtPVShow.Text = TxtPVShow.Text & strPVD & vbCrLf     '        Text box PV value display
        'DisplayPVData(strPVD)
        Printtext()
    End Sub

    'Read SV value
    Private Sub ReadSVData()
        Dim strRx As String
        strRx = Mid(strBuffer, 7, 1) & Mid(strBuffer, 9, 1) & Mid(strBuffer, 11, 1) & Mid(strBuffer, 13, 1)
        strRx = strRx.Replace(" ", "")
        strSVD = Str(Val(strRx))
        TxtSVnow.Text = strSVD    'The text box displays the SV value
    End Sub

    'read output power
    Private Sub ReadPower()
        Dim strPower As String
        Dim strRx As String
        strRx = Mid(strBuffer, 7, 1) & Mid(strBuffer, 9, 1) & Mid(strBuffer, 11, 1) & Mid(strBuffer, 13, 1)
        strRx = strRx.Replace(" ", "")
        strPower = Str(Val(strRx))
        TxtPower.Text = strPower
    End Sub

    'Read the maximum value of SV set value
    Private Sub ReadSVMax()
        Dim strSVMax As String
        Dim strRx As String
        strRx = Mid(strBuffer, 7, 1) & Mid(strBuffer, 9, 1) & Mid(strBuffer, 11, 1) & Mid(strBuffer, 13, 1)
        strRx = strRx.Replace(" ", "")
        strSVMax = Str(Val(strRx))
        TxtSVMax.Text = strSVMax
    End Sub

    'Read the minimum value of SV set value
    Private Sub ReadSVMin()
        Dim strSVMin As String
        Dim strRx As String
        strRx = Mid(strBuffer, 7, 1) & Mid(strBuffer, 9, 1) & Mid(strBuffer, 11, 1) & Mid(strBuffer, 13, 1)
        strRx = strRx.Replace(" ", "")
        strSVMin = Str(Val(strRx))
        TxtSVMin.Text = strSVMin
    End Sub

    'Read ramp rate
    Private Sub ReadSpeed()
        Dim strSpeed As String
        Dim strRx As String
        strRx = Mid(strBuffer, 7, 1) & Mid(strBuffer, 9, 1) & Mid(strBuffer, 11, 1) & Mid(strBuffer, 13, 1)
        strRx = strRx.Replace(" ", "")
        strSpeed = Str(Val(strRx))
        TxtSpeed.Text = strSpeed
    End Sub

    'Check whether the set value is successful
    Private Sub SetSuccess()
        If strBuffer = "60" Then
            MsgBox("Successfully modified！", MsgBoxStyle.Information)
        ElseIf strBuffer = "150" Then
            MsgBox("Failed to edit！", MsgBoxStyle.Exclamation)
        End If
    End Sub

    'Data record text output
    Private Sub Printtext()
        Dim TimeNow As Date
        TimeNow = TimeOfDay
        FileOpen(1, My.Application.Info.DirectoryPath & "\PC410text.txt", OpenMode.Append)
        PrintLine(1, TimeNow, strSVD, strPVD)
        FileClose(1)
        'My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath & "\PC410text.txt", TimeNow & strSVD & strPVD, True)
    End Sub

    'Data record text output
    Private Sub Draw()
        Dim Ypv As Short
        Dim Ysv As Short
        Static i As Integer = 0   'seconds
        i = i + 1
        Ypv = Val(strPVD)
        Ysv = Val(strSVD)
        myForm2.PaintPV(i, Ypv)
        myForm2.PaintSV(i, Ysv)
    End Sub

End Class

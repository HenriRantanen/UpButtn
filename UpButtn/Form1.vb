Imports System
Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel

Public Class Form1

    Delegate Sub SetTextCallBack(ByVal [text] As String)

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Run on the first load
        populateCOMselect()
        'Set the UI boundries
        CurrentHeight.Minimum = SittingHeight.Minimum
        CurrentHeight.Maximum = StandingHeight.Maximum
    End Sub

    Function populateCOMselect()
        ' Declare Ports 
        Dim Ports As String() = IO.Ports.SerialPort.GetPortNames()
        ' Add ports to the list 
        For Each Port In Ports
            COM_Port.Items.Add(Port)
        Next Port
        ' Select an item in the combobox 
        COM_Port.SelectedIndex = 1
    End Function

    Private Sub Button_Up_Click(sender As Object, e As EventArgs) Handles Button_Up.Click
        'Read the value from UI and set the height
        setTableHeight(StandingHeight.Value)
    End Sub

    Private Sub Button_Down_Click(sender As Object, e As EventArgs) Handles Button_Down.Click
        'Read the value from UI and set the height
        setTableHeight(SittingHeight.Value)
    End Sub

    Function setTableHeight(ByVal centimeters As Integer) As Boolean

        'Check that the height is in check.
        If (centimeters < SittingHeight.Minimum) Then
            centimeters = SittingHeight.Minimum
        ElseIf (centimeters > StandingHeight.Maximum) Then
            centimeters = StandingHeight.Maximum
        End If

        ' Try to send the command to the serial port
        Try
            Timer1.Enabled = False
            SerialPort.Write("d" + centimeters.ToString)


            Return True
        Catch ex As Exception
            'If it fails, show an error message and return false
            MsgBox("Can't talk to the controller: " & vbCrLf & ex.Message)
            Return False
        End Try


    End Function

    Private Sub CurrentHeight_Scroll(sender As Object, e As EventArgs) Handles CurrentHeight.MouseUp
        ' Set the table to the value that is set on the slider
        setTableHeight(CurrentHeight.Value)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Preset1.Click
        setTableHeight("85")
    End Sub

    Private Sub Preset2_Click(sender As Object, e As EventArgs) Handles Preset2.Click
        setTableHeight("78")
    End Sub

    Private Sub SerialPort_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort.DataReceived
        Dim rx As String = SerialPort.ReadExisting()

        If (rx.Contains("OK")) Then
            Me.Timer1.Enabled = True
        Else
            ReceivedText(rx)
        End If
    End Sub

    Private Sub ReceivedText(ByVal [text] As String)
        If Me.CurrentHeightText.InvokeRequired Then
            Dim x As New SetTextCallBack(AddressOf ReceivedText)
            Me.Invoke(x, New Object() {(text)})
        Else
            Me.CurrentHeightText.Text = "Height: " + [text] + " cm"
        End If


        If Me.CurrentHeight.InvokeRequired Then
            Dim x As New SetTextCallBack(AddressOf ReceivedText)
            Me.Invoke(x, New Object() {(text)})
        Else
            Me.CurrentHeight.Value = [text]
        End If
    End Sub

    Private Sub openSerial()
        SerialPort.PortName = COM_Port.Text
        SerialPort.Open()
        'Timer1.Enabled = True

    End Sub

    Private Sub closeSerial()
        Timer1.Enabled = False
        SerialPort.Close()
    End Sub

    Private Sub connectButton_Click(sender As Object, e As EventArgs) Handles connectButton.Click
        If (SerialPort.IsOpen) Then
            closeSerial()
            connectButton.Text = "Connect to " + COM_Port.Text
        Else
            openSerial()
            SerialPort.Write("e")
            connectButton.Text = "Disconnect from " + COM_Port.Text
        End If


    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        closeSerial()
    End Sub

    Private Sub COM_Port_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COM_Port.SelectedIndexChanged
        If (SerialPort.IsOpen) Then
            connectButton.Text = "Close connection to " + SerialPort.PortName
        Else
            connectButton.Text = "Connect to " + COM_Port.Text
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        SerialPort.Write("e")
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If (SerialPort.IsOpen) Then
            'Timer1.Enabled = True
        End If
    End Sub

    Private Sub Form1_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        If (SerialPort.IsOpen) Then
            'Timer1.Enabled = False
        End If
    End Sub

    Private Sub CurrentHeightText_Click(sender As Object, e As EventArgs) Handles CurrentHeightText.Click
        SerialPort.Write("e")
    End Sub
End Class


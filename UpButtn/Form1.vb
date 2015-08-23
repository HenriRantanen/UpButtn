Public Class Form1
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
            SerialPort.PortName = COM_Port.Text
            SerialPort.Open()
            SerialPort.Write("d" + centimeters.ToString)
            SerialPort.Close()

            'Write the new number to the UI
            CurrentHeight.Value = centimeters
            Return True
        Catch ex As Exception
            'If it fails, show an error message and return false
            MsgBox("Can't talk to the controller on" & vbCrLf & ex.Message)
            Return False
        End Try


    End Function

    Private Sub CurrentHeight_Scroll(sender As Object, e As EventArgs) Handles CurrentHeight.MouseUp
        ' Set the table to the value that is set on the slider
        setTableHeight(CurrentHeight.Value)
    End Sub
End Class


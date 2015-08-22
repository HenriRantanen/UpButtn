Public Class Form1
    Private Sub Button_Up_Click(sender As Object, e As EventArgs) Handles Button_Up.Click
        SerialPort.Open()
        SerialPort.Write("d110")
        SerialPort.Close()
    End Sub

    Private Sub Button_Down_Click(sender As Object, e As EventArgs) Handles Button_Down.Click
        SerialPort.Open()
        SerialPort.Write("d72")
        SerialPort.Close()
    End Sub
End Class

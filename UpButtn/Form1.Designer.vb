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
        Me.Button_Up = New System.Windows.Forms.Button()
        Me.Button_Down = New System.Windows.Forms.Button()
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.SuspendLayout()
        '
        'Button_Up
        '
        Me.Button_Up.Font = New System.Drawing.Font("Wingdings", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Button_Up.Location = New System.Drawing.Point(13, 13)
        Me.Button_Up.Name = "Button_Up"
        Me.Button_Up.Size = New System.Drawing.Size(77, 59)
        Me.Button_Up.TabIndex = 0
        Me.Button_Up.Text = "á"
        Me.Button_Up.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button_Up.UseVisualStyleBackColor = True
        '
        'Button_Down
        '
        Me.Button_Down.Font = New System.Drawing.Font("Wingdings", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Button_Down.Location = New System.Drawing.Point(13, 78)
        Me.Button_Down.Name = "Button_Down"
        Me.Button_Down.Size = New System.Drawing.Size(77, 58)
        Me.Button_Down.TabIndex = 1
        Me.Button_Down.Text = "â"
        Me.Button_Down.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Button_Down.UseVisualStyleBackColor = True
        '
        'SerialPort
        '
        Me.SerialPort.PortName = "COM3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(217, 148)
        Me.Controls.Add(Me.Button_Down)
        Me.Controls.Add(Me.Button_Up)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "UpButt'n"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button_Up As Button
    Friend WithEvents Button_Down As Button
    Friend WithEvents SerialPort As IO.Ports.SerialPort
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button_Up = New System.Windows.Forms.Button()
        Me.Button_Down = New System.Windows.Forms.Button()
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label_StandingHeight = New System.Windows.Forms.Label()
        Me.Label_SittingHeight = New System.Windows.Forms.Label()
        Me.StandingHeight = New System.Windows.Forms.NumericUpDown()
        Me.SittingHeight = New System.Windows.Forms.NumericUpDown()
        Me.COM_Port = New System.Windows.Forms.ComboBox()
        Me.CurrentHeight = New System.Windows.Forms.TrackBar()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.StandingHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SittingHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurrentHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_Up
        '
        Me.Button_Up.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_Up.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Up.Location = New System.Drawing.Point(39, 119)
        Me.Button_Up.Margin = New System.Windows.Forms.Padding(3, 15, 3, 3)
        Me.Button_Up.Name = "Button_Up"
        Me.Button_Up.Size = New System.Drawing.Size(157, 50)
        Me.Button_Up.TabIndex = 0
        Me.Button_Up.Text = "Stand"
        Me.Button_Up.UseVisualStyleBackColor = True
        '
        'Button_Down
        '
        Me.Button_Down.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_Down.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Down.Location = New System.Drawing.Point(241, 119)
        Me.Button_Down.Margin = New System.Windows.Forms.Padding(3, 15, 3, 3)
        Me.Button_Down.Name = "Button_Down"
        Me.Button_Down.Size = New System.Drawing.Size(157, 50)
        Me.Button_Down.TabIndex = 1
        Me.Button_Down.Text = "Sit"
        Me.Button_Down.UseVisualStyleBackColor = True
        '
        'SerialPort
        '
        Me.SerialPort.PortName = "COM3"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 15, 3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(813, 617)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Button_Up)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Button_Down)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(805, 584)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Smart Desk Controls"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 84)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3, 15, 3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(234, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Set your desk to a preset height"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(32, 32)
        Me.Label6.Margin = New System.Windows.Forms.Padding(3, 32, 3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(175, 37)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "SmartDesk"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.Label_StandingHeight)
        Me.TabPage2.Controls.Add(Me.Label_SittingHeight)
        Me.TabPage2.Controls.Add(Me.StandingHeight)
        Me.TabPage2.Controls.Add(Me.SittingHeight)
        Me.TabPage2.Controls.Add(Me.COM_Port)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(805, 584)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Settings"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 84)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 15, 3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(273, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Set comfortable heights for your desk"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 32)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 32, 3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 37)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "SmartDesk"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 256)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 15, 3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(482, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Select the serial port where your SmartDesk controller is connected"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 204)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 32, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 37)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Controller"
        '
        'Label_StandingHeight
        '
        Me.Label_StandingHeight.AutoSize = True
        Me.Label_StandingHeight.Location = New System.Drawing.Point(237, 119)
        Me.Label_StandingHeight.Margin = New System.Windows.Forms.Padding(3, 15, 3, 0)
        Me.Label_StandingHeight.Name = "Label_StandingHeight"
        Me.Label_StandingHeight.Size = New System.Drawing.Size(121, 20)
        Me.Label_StandingHeight.TabIndex = 6
        Me.Label_StandingHeight.Text = "Standing height"
        '
        'Label_SittingHeight
        '
        Me.Label_SittingHeight.AutoSize = True
        Me.Label_SittingHeight.Location = New System.Drawing.Point(35, 119)
        Me.Label_SittingHeight.Margin = New System.Windows.Forms.Padding(3, 15, 3, 0)
        Me.Label_SittingHeight.Name = "Label_SittingHeight"
        Me.Label_SittingHeight.Size = New System.Drawing.Size(102, 20)
        Me.Label_SittingHeight.TabIndex = 5
        Me.Label_SittingHeight.Text = "Sitting height"
        '
        'StandingHeight
        '
        Me.StandingHeight.Location = New System.Drawing.Point(241, 143)
        Me.StandingHeight.Margin = New System.Windows.Forms.Padding(3, 4, 3, 3)
        Me.StandingHeight.Maximum = New Decimal(New Integer() {124, 0, 0, 0})
        Me.StandingHeight.Minimum = New Decimal(New Integer() {70, 0, 0, 0})
        Me.StandingHeight.Name = "StandingHeight"
        Me.StandingHeight.Size = New System.Drawing.Size(157, 26)
        Me.StandingHeight.TabIndex = 3
        Me.StandingHeight.Value = New Decimal(New Integer() {115, 0, 0, 0})
        '
        'SittingHeight
        '
        Me.SittingHeight.Location = New System.Drawing.Point(39, 143)
        Me.SittingHeight.Margin = New System.Windows.Forms.Padding(3, 4, 3, 3)
        Me.SittingHeight.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
        Me.SittingHeight.Minimum = New Decimal(New Integer() {66, 0, 0, 0})
        Me.SittingHeight.Name = "SittingHeight"
        Me.SittingHeight.Size = New System.Drawing.Size(157, 26)
        Me.SittingHeight.TabIndex = 2
        Me.SittingHeight.Value = New Decimal(New Integer() {72, 0, 0, 0})
        '
        'COM_Port
        '
        Me.COM_Port.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.COM_Port.FormattingEnabled = True
        Me.COM_Port.Location = New System.Drawing.Point(39, 280)
        Me.COM_Port.Margin = New System.Windows.Forms.Padding(3, 4, 3, 3)
        Me.COM_Port.Name = "COM_Port"
        Me.COM_Port.Size = New System.Drawing.Size(157, 28)
        Me.COM_Port.TabIndex = 1
        Me.COM_Port.Text = "Select COM-Port"
        '
        'CurrentHeight
        '
        Me.CurrentHeight.Location = New System.Drawing.Point(820, 41)
        Me.CurrentHeight.Maximum = 120
        Me.CurrentHeight.Minimum = 67
        Me.CurrentHeight.Name = "CurrentHeight"
        Me.CurrentHeight.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.CurrentHeight.Size = New System.Drawing.Size(69, 588)
        Me.CurrentHeight.SmallChange = 5
        Me.CurrentHeight.TabIndex = 3
        Me.CurrentHeight.TickFrequency = 5
        Me.CurrentHeight.Value = 72
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 698)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.CurrentHeight)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "UpButt'n"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.StandingHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SittingHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CurrentHeight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_Up As Button
    Friend WithEvents Button_Down As Button
    Friend WithEvents SerialPort As IO.Ports.SerialPort
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents StandingHeight As NumericUpDown
    Friend WithEvents SittingHeight As NumericUpDown
    Friend WithEvents COM_Port As ComboBox
    Friend WithEvents CurrentHeight As TrackBar
    Friend WithEvents Label_StandingHeight As Label
    Friend WithEvents Label_SittingHeight As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class

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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label_StandingHeight = New System.Windows.Forms.Label()
        Me.Label_SittingHeight = New System.Windows.Forms.Label()
        Me.Label_Heights = New System.Windows.Forms.Label()
        Me.StandingHeight = New System.Windows.Forms.NumericUpDown()
        Me.SittingHeight = New System.Windows.Forms.NumericUpDown()
        Me.COM_Port = New System.Windows.Forms.ComboBox()
        Me.Label_COM = New System.Windows.Forms.Label()
        Me.CurrentHeight = New System.Windows.Forms.TrackBar()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.StandingHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SittingHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurrentHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_Up
        '
        Me.Button_Up.Font = New System.Drawing.Font("Wingdings", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Button_Up.Location = New System.Drawing.Point(861, 39)
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
        Me.Button_Down.Location = New System.Drawing.Point(861, 104)
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 11)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(843, 587)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(835, 554)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Timer"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label_StandingHeight)
        Me.TabPage2.Controls.Add(Me.Label_SittingHeight)
        Me.TabPage2.Controls.Add(Me.Label_Heights)
        Me.TabPage2.Controls.Add(Me.StandingHeight)
        Me.TabPage2.Controls.Add(Me.SittingHeight)
        Me.TabPage2.Controls.Add(Me.COM_Port)
        Me.TabPage2.Controls.Add(Me.Label_COM)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(835, 554)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Table controls"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label_StandingHeight
        '
        Me.Label_StandingHeight.AutoSize = True
        Me.Label_StandingHeight.Location = New System.Drawing.Point(169, 236)
        Me.Label_StandingHeight.Name = "Label_StandingHeight"
        Me.Label_StandingHeight.Size = New System.Drawing.Size(121, 20)
        Me.Label_StandingHeight.TabIndex = 6
        Me.Label_StandingHeight.Text = "Standing height"
        '
        'Label_SittingHeight
        '
        Me.Label_SittingHeight.AutoSize = True
        Me.Label_SittingHeight.Location = New System.Drawing.Point(7, 236)
        Me.Label_SittingHeight.Name = "Label_SittingHeight"
        Me.Label_SittingHeight.Size = New System.Drawing.Size(102, 20)
        Me.Label_SittingHeight.TabIndex = 5
        Me.Label_SittingHeight.Text = "Sitting height"
        '
        'Label_Heights
        '
        Me.Label_Heights.AutoSize = True
        Me.Label_Heights.Location = New System.Drawing.Point(7, 159)
        Me.Label_Heights.Name = "Label_Heights"
        Me.Label_Heights.Size = New System.Drawing.Size(108, 20)
        Me.Label_Heights.TabIndex = 4
        Me.Label_Heights.Text = "Table settings"
        '
        'StandingHeight
        '
        Me.StandingHeight.Location = New System.Drawing.Point(173, 259)
        Me.StandingHeight.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
        Me.StandingHeight.Minimum = New Decimal(New Integer() {70, 0, 0, 0})
        Me.StandingHeight.Name = "StandingHeight"
        Me.StandingHeight.Size = New System.Drawing.Size(120, 26)
        Me.StandingHeight.TabIndex = 3
        Me.StandingHeight.Value = New Decimal(New Integer() {115, 0, 0, 0})
        '
        'SittingHeight
        '
        Me.SittingHeight.Location = New System.Drawing.Point(11, 259)
        Me.SittingHeight.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
        Me.SittingHeight.Minimum = New Decimal(New Integer() {67, 0, 0, 0})
        Me.SittingHeight.Name = "SittingHeight"
        Me.SittingHeight.Size = New System.Drawing.Size(120, 26)
        Me.SittingHeight.TabIndex = 2
        Me.SittingHeight.Value = New Decimal(New Integer() {72, 0, 0, 0})
        '
        'COM_Port
        '
        Me.COM_Port.FormattingEnabled = True
        Me.COM_Port.Location = New System.Drawing.Point(11, 30)
        Me.COM_Port.Name = "COM_Port"
        Me.COM_Port.Size = New System.Drawing.Size(282, 28)
        Me.COM_Port.TabIndex = 1
        Me.COM_Port.Text = "Select COM-Port"
        '
        'Label_COM
        '
        Me.Label_COM.AutoSize = True
        Me.Label_COM.Location = New System.Drawing.Point(7, 7)
        Me.Label_COM.Name = "Label_COM"
        Me.Label_COM.Size = New System.Drawing.Size(77, 20)
        Me.Label_COM.TabIndex = 0
        Me.Label_COM.Text = "Controller"
        '
        'CurrentHeight
        '
        Me.CurrentHeight.Location = New System.Drawing.Point(869, 168)
        Me.CurrentHeight.Maximum = 120
        Me.CurrentHeight.Minimum = 67
        Me.CurrentHeight.Name = "CurrentHeight"
        Me.CurrentHeight.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.CurrentHeight.Size = New System.Drawing.Size(69, 426)
        Me.CurrentHeight.TabIndex = 3
        Me.CurrentHeight.TickFrequency = 2
        Me.CurrentHeight.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.CurrentHeight.Value = 72
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1012, 742)
        Me.Controls.Add(Me.CurrentHeight)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button_Down)
        Me.Controls.Add(Me.Button_Up)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "UpButt'n"
        Me.TabControl1.ResumeLayout(False)
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
    Friend WithEvents Label_COM As Label
    Friend WithEvents CurrentHeight As TrackBar
    Friend WithEvents Label_StandingHeight As Label
    Friend WithEvents Label_SittingHeight As Label
    Friend WithEvents Label_Heights As Label
End Class

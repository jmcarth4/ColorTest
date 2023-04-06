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
        Me.RedTextBox = New System.Windows.Forms.TextBox()
        Me.GreenTextBox = New System.Windows.Forms.TextBox()
        Me.BlueTextBox = New System.Windows.Forms.TextBox()
        Me.RedLabel = New System.Windows.Forms.Label()
        Me.GreenLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.LEDPictureBox = New System.Windows.Forms.PictureBox()
        Me.LEDTextBox = New System.Windows.Forms.TextBox()
        Me.HEXTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HelloTextBox = New System.Windows.Forms.TextBox()
        Me.StringNumTextBox = New System.Windows.Forms.TextBox()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.XTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.XLabel = New System.Windows.Forms.Label()
        Me.yLabel = New System.Windows.Forms.Label()
        Me.YTextBox = New System.Windows.Forms.TextBox()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.RedTrackBar = New System.Windows.Forms.TrackBar()
        Me.GreenTrackBar = New System.Windows.Forms.TrackBar()
        Me.BlueTrackBar = New System.Windows.Forms.TrackBar()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.RLabel = New System.Windows.Forms.Label()
        Me.LabelG = New System.Windows.Forms.Label()
        Me.BLabel = New System.Windows.Forms.Label()
        Me.LabelR = New System.Windows.Forms.Label()
        CType(Me.LEDPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.RedTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GreenTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlueTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RedTextBox
        '
        Me.RedTextBox.Location = New System.Drawing.Point(78, 194)
        Me.RedTextBox.Name = "RedTextBox"
        Me.RedTextBox.Size = New System.Drawing.Size(100, 26)
        Me.RedTextBox.TabIndex = 0
        '
        'GreenTextBox
        '
        Me.GreenTextBox.Location = New System.Drawing.Point(300, 194)
        Me.GreenTextBox.Name = "GreenTextBox"
        Me.GreenTextBox.Size = New System.Drawing.Size(100, 26)
        Me.GreenTextBox.TabIndex = 1
        '
        'BlueTextBox
        '
        Me.BlueTextBox.Location = New System.Drawing.Point(463, 194)
        Me.BlueTextBox.Name = "BlueTextBox"
        Me.BlueTextBox.Size = New System.Drawing.Size(100, 26)
        Me.BlueTextBox.TabIndex = 2
        '
        'RedLabel
        '
        Me.RedLabel.AutoSize = True
        Me.RedLabel.BackColor = System.Drawing.Color.Red
        Me.RedLabel.ForeColor = System.Drawing.Color.Black
        Me.RedLabel.Location = New System.Drawing.Point(90, 145)
        Me.RedLabel.Name = "RedLabel"
        Me.RedLabel.Size = New System.Drawing.Size(39, 20)
        Me.RedLabel.TabIndex = 3
        Me.RedLabel.Text = "Red"
        '
        'GreenLabel
        '
        Me.GreenLabel.AutoSize = True
        Me.GreenLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GreenLabel.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GreenLabel.Location = New System.Drawing.Point(309, 145)
        Me.GreenLabel.Name = "GreenLabel"
        Me.GreenLabel.Size = New System.Drawing.Size(54, 20)
        Me.GreenLabel.TabIndex = 4
        Me.GreenLabel.Text = "Green"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(485, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Blue"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(615, 188)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 50)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "&Set Colour"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ExitButton.ForeColor = System.Drawing.Color.Black
        Me.ExitButton.Location = New System.Drawing.Point(1026, 322)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(93, 45)
        Me.ExitButton.TabIndex = 7
        Me.ExitButton.Text = "&Exit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClearButton.ForeColor = System.Drawing.Color.Black
        Me.ClearButton.Location = New System.Drawing.Point(668, 276)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(93, 45)
        Me.ClearButton.TabIndex = 8
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'LEDPictureBox
        '
        Me.LEDPictureBox.Location = New System.Drawing.Point(149, 47)
        Me.LEDPictureBox.Name = "LEDPictureBox"
        Me.LEDPictureBox.Size = New System.Drawing.Size(100, 50)
        Me.LEDPictureBox.TabIndex = 9
        Me.LEDPictureBox.TabStop = False
        '
        'LEDTextBox
        '
        Me.LEDTextBox.Location = New System.Drawing.Point(397, 47)
        Me.LEDTextBox.Name = "LEDTextBox"
        Me.LEDTextBox.Size = New System.Drawing.Size(100, 26)
        Me.LEDTextBox.TabIndex = 10
        '
        'HEXTextBox
        '
        Me.HEXTextBox.Location = New System.Drawing.Point(597, 47)
        Me.HEXTextBox.Name = "HEXTextBox"
        Me.HEXTextBox.Size = New System.Drawing.Size(100, 26)
        Me.HEXTextBox.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(611, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "HEX Value"
        '
        'HelloTextBox
        '
        Me.HelloTextBox.Location = New System.Drawing.Point(688, 139)
        Me.HelloTextBox.Name = "HelloTextBox"
        Me.HelloTextBox.Size = New System.Drawing.Size(100, 26)
        Me.HelloTextBox.TabIndex = 13
        '
        'StringNumTextBox
        '
        Me.StringNumTextBox.Location = New System.Drawing.Point(688, 97)
        Me.StringNumTextBox.Name = "StringNumTextBox"
        Me.StringNumTextBox.Size = New System.Drawing.Size(100, 26)
        Me.StringNumTextBox.TabIndex = 14
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(26, 70)
        Me.VScrollBar1.Maximum = 255
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(26, 120)
        Me.VScrollBar1.TabIndex = 15
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(13, 79)
        Me.HScrollBar1.Maximum = 255
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(153, 45)
        Me.HScrollBar1.TabIndex = 16
        Me.HScrollBar1.TabStop = True
        '
        'TrackBar1
        '
        Me.TrackBar1.LargeChange = 10
        Me.TrackBar1.Location = New System.Drawing.Point(13, 163)
        Me.TrackBar1.Maximum = 255
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(153, 69)
        Me.TrackBar1.TabIndex = 17
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'XTextBox
        '
        Me.XTextBox.Location = New System.Drawing.Point(176, 55)
        Me.XTextBox.Name = "XTextBox"
        Me.XTextBox.Size = New System.Drawing.Size(100, 26)
        Me.XTextBox.TabIndex = 19
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.XLabel)
        Me.GroupBox1.Controls.Add(Me.yLabel)
        Me.GroupBox1.Controls.Add(Me.YTextBox)
        Me.GroupBox1.Controls.Add(Me.ResetButton)
        Me.GroupBox1.Controls.Add(Me.HScrollBar1)
        Me.GroupBox1.Controls.Add(Me.TrackBar1)
        Me.GroupBox1.Controls.Add(Me.XTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(815, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(365, 256)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(279, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 20)
        Me.Label4.TabIndex = 24
        '
        'XLabel
        '
        Me.XLabel.AutoSize = True
        Me.XLabel.ForeColor = System.Drawing.Color.Maroon
        Me.XLabel.Location = New System.Drawing.Point(172, 22)
        Me.XLabel.Name = "XLabel"
        Me.XLabel.Size = New System.Drawing.Size(0, 20)
        Me.XLabel.TabIndex = 23
        '
        'yLabel
        '
        Me.yLabel.AutoSize = True
        Me.yLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.yLabel.Location = New System.Drawing.Point(196, 222)
        Me.yLabel.Name = "yLabel"
        Me.yLabel.Size = New System.Drawing.Size(0, 20)
        Me.yLabel.TabIndex = 22
        '
        'YTextBox
        '
        Me.YTextBox.Location = New System.Drawing.Point(183, 184)
        Me.YTextBox.Name = "YTextBox"
        Me.YTextBox.Size = New System.Drawing.Size(100, 26)
        Me.YTextBox.TabIndex = 21
        '
        'ResetButton
        '
        Me.ResetButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ResetButton.ForeColor = System.Drawing.Color.Black
        Me.ResetButton.Location = New System.Drawing.Point(183, 103)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(93, 45)
        Me.ResetButton.TabIndex = 20
        Me.ResetButton.Text = "&Reset "
        Me.ResetButton.UseVisualStyleBackColor = False
        '
        'RedTrackBar
        '
        Me.RedTrackBar.Location = New System.Drawing.Point(12, 252)
        Me.RedTrackBar.Maximum = 255
        Me.RedTrackBar.Name = "RedTrackBar"
        Me.RedTrackBar.Size = New System.Drawing.Size(151, 69)
        Me.RedTrackBar.TabIndex = 25
        Me.RedTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'GreenTrackBar
        '
        Me.GreenTrackBar.Location = New System.Drawing.Point(205, 252)
        Me.GreenTrackBar.Maximum = 255
        Me.GreenTrackBar.Name = "GreenTrackBar"
        Me.GreenTrackBar.Size = New System.Drawing.Size(195, 69)
        Me.GreenTrackBar.TabIndex = 26
        Me.GreenTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'BlueTrackBar
        '
        Me.BlueTrackBar.Location = New System.Drawing.Point(430, 252)
        Me.BlueTrackBar.Maximum = 255
        Me.BlueTrackBar.Name = "BlueTrackBar"
        Me.BlueTrackBar.Size = New System.Drawing.Size(155, 69)
        Me.BlueTrackBar.TabIndex = 27
        Me.BlueTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(149, 355)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 26)
        Me.TextBox1.TabIndex = 28
        '
        'RLabel
        '
        Me.RLabel.AutoSize = True
        Me.RLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.RLabel.Location = New System.Drawing.Point(86, 465)
        Me.RLabel.Name = "RLabel"
        Me.RLabel.Size = New System.Drawing.Size(21, 20)
        Me.RLabel.TabIndex = 29
        Me.RLabel.Text = "R"
        '
        'LabelG
        '
        Me.LabelG.AutoSize = True
        Me.LabelG.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelG.Location = New System.Drawing.Point(286, 322)
        Me.LabelG.Name = "LabelG"
        Me.LabelG.Size = New System.Drawing.Size(22, 20)
        Me.LabelG.TabIndex = 30
        Me.LabelG.Text = "G"
        '
        'BLabel
        '
        Me.BLabel.AutoSize = True
        Me.BLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BLabel.Location = New System.Drawing.Point(506, 322)
        Me.BLabel.Name = "BLabel"
        Me.BLabel.Size = New System.Drawing.Size(20, 20)
        Me.BLabel.TabIndex = 31
        Me.BLabel.Text = "B"
        '
        'LabelR
        '
        Me.LabelR.AutoSize = True
        Me.LabelR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelR.Location = New System.Drawing.Point(74, 312)
        Me.LabelR.Name = "LabelR"
        Me.LabelR.Size = New System.Drawing.Size(21, 20)
        Me.LabelR.TabIndex = 34
        Me.LabelR.Text = "R"
        '
        'Form1
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ClearButton
        Me.ClientSize = New System.Drawing.Size(1206, 415)
        Me.Controls.Add(Me.LabelR)
        Me.Controls.Add(Me.BLabel)
        Me.Controls.Add(Me.LabelG)
        Me.Controls.Add(Me.RLabel)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BlueTrackBar)
        Me.Controls.Add(Me.RedTrackBar)
        Me.Controls.Add(Me.GreenTrackBar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.StringNumTextBox)
        Me.Controls.Add(Me.HelloTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.HEXTextBox)
        Me.Controls.Add(Me.LEDTextBox)
        Me.Controls.Add(Me.LEDPictureBox)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GreenLabel)
        Me.Controls.Add(Me.RedLabel)
        Me.Controls.Add(Me.BlueTextBox)
        Me.Controls.Add(Me.GreenTextBox)
        Me.Controls.Add(Me.RedTextBox)
        Me.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.LEDPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.RedTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GreenTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlueTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RedTextBox As TextBox
    Friend WithEvents GreenTextBox As TextBox
    Friend WithEvents BlueTextBox As TextBox
    Friend WithEvents RedLabel As Label
    Friend WithEvents GreenLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents LEDPictureBox As PictureBox
    Friend WithEvents LEDTextBox As TextBox
    Friend WithEvents HEXTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents HelloTextBox As TextBox
    Friend WithEvents StringNumTextBox As TextBox
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents XTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ResetButton As Button
    Friend WithEvents YTextBox As TextBox
    Friend WithEvents yLabel As Label
    Friend WithEvents XLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents RedTrackBar As TrackBar
    Friend WithEvents GreenTrackBar As TrackBar
    Friend WithEvents BlueTrackBar As TrackBar
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents RLabel As Label
    Friend WithEvents LabelG As Label
    Friend WithEvents BLabel As Label
    Friend WithEvents LabelR As Label
End Class

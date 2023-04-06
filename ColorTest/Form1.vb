
Option Strict On
Option Explicit On
Public Class Form1

    ' Dim redVariable, greenVariable, blueVariable As Integer

    'Testing testing -- test color display of stuff
    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Dim redVariable, greenVariable, blueVariable As Integer
    '    redVariable = RedTextBox.Text
    '    greenVariable = GreenTextBox.Text
    '    blueVariable = BlueTextBox.Text
    '    Me.BackColor = Color.FromArgb(redVariable, greenVariable, blueVariable)
    'End Sub

    'Private Sub RedTrackBar_Scroll(sender As Object, e As EventArgs) Handles RedTrackBar.Scroll

    'How to set slider to set color
    '    TextBox1.BackColor = Color.FromArgb(RedTrackBar.Value, GreenTrackBar.Value, BlueTrackBar.Value)
    '    LabelR.Text = CStr(RedTrackBar.Value)
    '    LabelR.BackColor = Color.FromArgb(RedTrackBar.Value, 0, 0)

    'End Sub



    'Private Sub GreenTrackBar_Scroll(sender As Object, e As EventArgs) Handles GreenTrackBar.Scroll

    '    'How to set slider to set color
    '    TextBox1.BackColor = Color.FromArgb(RedTrackBar.Value, GreenTrackBar.Value, BlueTrackBar.Value)
    '    LabelG.Text = CStr(GreenTrackBar.Value)
    '    LabelG.BackColor = Color.FromArgb(0, GreenTrackBar.Value, 0)
    'End Sub

    'Private Sub BlueTrackBar_Scroll(sender As Object, e As EventArgs) Handles BlueTrackBar.Scroll

    '    'How to set slider to set color
    '    TextBox1.BackColor = Color.FromArgb(RedTrackBar.Value, GreenTrackBar.Value, BlueTrackBar.Value)
    '    BLabel.Text = CStr(BlueTrackBar.Value)
    '    BLabel.BackColor = Color.FromArgb(0, 0, BlueTrackBar.Value)
    'End Sub
    Sub SetColor()
        Dim redVariable, greenVariable, blueVariable As Integer

        'Sets color of text box and picture box with user input.
        redVariable = CInt(RedTextBox.Text)
        greenVariable = CInt(GreenTextBox.Text)
        blueVariable = CInt(BlueTextBox.Text)

        LEDTextBox.BackColor = Color.FromArgb(redVariable, greenVariable, blueVariable)
        LEDPictureBox.BackColor = Color.FromArgb(redVariable, greenVariable, blueVariable)
        HEXTextBox.Text = Hex(redVariable) & " - " & Hex(greenVariable) & " - " & Hex(blueVariable)

        'combine two systems of color input
        RedTrackBar.Value = CInt(RedTextBox.Text)
        LabelR.Text = CStr(RedTrackBar.Value)
        LabelR.BackColor = Color.FromArgb(RedTrackBar.Value, 0, 0)

        GreenTrackBar.Value = CInt(GreenTextBox.Text)
        LabelG.Text = CStr(GreenTrackBar.Value)
        LabelG.BackColor = Color.FromArgb(0, GreenTrackBar.Value, 0)

        BlueTrackBar.Value = CInt(BlueTextBox.Text)
        BLabel.Text = CStr(BlueTrackBar.Value)
        BLabel.BackColor = Color.FromArgb(0, 0, BlueTrackBar.Value)

    End Sub

    'Sub Displayhex()

    '   Dim redInput, greenInput, blueInput As String

    'redInput = RedTextBox.Text
    'greenInput = GreenTextBox.Text
    'blueInput = BlueTextBox.Text

    'redVariable = CInt(redInput)
    'greenVariable = CInt(greenInput)
    'blueVariable = CInt(blueInput)

    'testing testing testing
    'HelloTextBox.Text = Format(redVariable, "0##") & " " & Format(Hex(redVariable), "0#") & "  " & Format(Hex(redVariable), "##")
    'HelloTextBox.Text = Format(redVariable, "X") & "  " & Hex(Format(redVariable, "0000")) & "  " & Format(redVariable, "X")
    ' HelloTextBox.Text = Format(redVariable, "0##") & " " & Hex(Format(redVariable, "0##"))
    ' HelloTextBox.Text = Format(redHEX) & "  " & Format(redVariable, "0##")

    'Dim redHEX, greenHex, blueHex As String
    '    Dim numberCharatersR, numberCharatersG, numberCharactersB As Integer
    '    Dim redDisplay, greenDisplay, blueDisplay As String

    '    'Convert color input to hex numbers.
    '    'displayed as strings
    '    redHEX = Hex(redVariable)
    '    greenHex = Hex(greenVariable)
    '    blueHex = Hex(blueVariable)

    '    'Count the number of characters in string of each color's hex value.
    '    numberCharatersR = Len(redHEX)
    '    numberCharatersG = Len(greenHex)
    '    numberCharactersB = Len(blueHex)

    '    'testing testing testing 
    '    StringNumTextBox.Text = CStr(numberCharatersR)
    '    'StringNumTextBox.Text = numberCharatersR
    '    'If numberCharatersR < 2 Then
    '    '    HelloTextBox.Text = "0" & redHEX
    '    'Else
    '    '    HelloTextBox.Text = redHEX
    '    'End If








    ''Set display of Hex color values to digit display.

    'If numberCharatersR < 2 Then
    '        redDisplay = "0" & redHEX
    '    Else
    '        redDisplay = redHEX

    '    End If

    '    If numberCharatersG < 2 Then
    '        greenDisplay = "0" & greenHex
    '    Else
    '        greenDisplay = greenHex

    '    End If

    '    If numberCharactersB < 2 Then
    '        blueDisplay = "0" & blueHex
    '    Else
    '        blueDisplay = blueHex

    '    End If

    '    HelloTextBox.Text = redDisplay & " - " & greenDisplay & " - " & blueDisplay
    'End Sub

    Sub DisplayH()
        Dim redHEX, greenHex, blueHex As String
        Dim numberCharatersR, numberCharatersG, numberCharactersB As Integer
        Dim redDisplay, greenDisplay, blueDisplay As String

        'Convert color input to hex numbers.
        'displayed as strings
        redHEX = Hex(RedTrackBar.Value)
        greenHex = Hex(GreenTrackBar.Value)
        blueHex = Hex(BlueTrackBar.Value)

        'Count the number of characters in string of each color's hex value.
        numberCharatersR = Len(redHEX)
        numberCharatersG = Len(greenHex)
        numberCharactersB = Len(blueHex)

        'Set display of Hex color values to digit display.
        If numberCharatersR < 2 Then
            redDisplay = "0" & redHEX
        Else
            redDisplay = redHEX

        End If

        If numberCharatersG < 2 Then
            greenDisplay = "0" & greenHex
        Else
            greenDisplay = greenHex

        End If

        If numberCharactersB < 2 Then
            blueDisplay = "0" & blueHex
        Else
            blueDisplay = blueHex

        End If

        HelloTextBox.Text = redDisplay & " - " & greenDisplay & " - " & blueDisplay
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        SetColor()
        ' Displayhex()
        DisplayH()
        TextBox1.BackColor = Color.FromArgb(RedTrackBar.Value, GreenTrackBar.Value, BlueTrackBar.Value)

    End Sub

    'exits program
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    'clears color input and text box 
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        RedTextBox.Clear()
        GreenTextBox.Clear()
        BlueTextBox.Clear()
        RedTrackBar.Value = 0
        GreenTrackBar.Value = 0
        BlueTrackBar.Value = 0
        LEDTextBox.BackColor = Color.FromArgb(0, 0, 0)
        LEDPictureBox.BackColor = Color.FromArgb(0, 0, 0)
        HEXTextBox.Clear()
        HelloTextBox.Clear()
        TextBox1.BackColor = Color.FromArgb(0, 0, 0)
        LabelR.Text = ""
        LabelG.Text = ""
        BLabel.Text = "B"
    End Sub

    Private Sub RedTrackBar_Scroll(sender As Object, e As EventArgs) Handles RedTrackBar.Scroll

        TextBox1.BackColor = Color.FromArgb(RedTrackBar.Value, GreenTrackBar.Value, BlueTrackBar.Value)
        LabelR.Text = CStr(RedTrackBar.Value)
        LabelR.BackColor = Color.FromArgb(RedTrackBar.Value, 0, 0)

        RedTextBox.Text = CStr(RedTrackBar.Value)
        LEDTextBox.BackColor = Color.FromArgb(RedTrackBar.Value, GreenTrackBar.Value, BlueTrackBar.Value)

        ' SetColor()
        'Displayhex()
        DisplayH()
    End Sub



    Private Sub GreenTrackBar_Scroll(sender As Object, e As EventArgs) Handles GreenTrackBar.Scroll
        TextBox1.BackColor = Color.FromArgb(RedTrackBar.Value, GreenTrackBar.Value, BlueTrackBar.Value)
        LabelG.Text = CStr(GreenTrackBar.Value)
        LabelG.BackColor = Color.FromArgb(0, GreenTrackBar.Value, 0)

        GreenTextBox.Text = CStr(GreenTrackBar.Value)
        '  LEDTextBox.BackColor = Color.FromArgb(redVariable, GreenTrackBar.Value, blueVariable)
        LEDTextBox.BackColor = Color.FromArgb(RedTrackBar.Value, GreenTrackBar.Value, BlueTrackBar.Value)

        ' SetColor()
        ' Displayhex()
        DisplayH()
    End Sub

    Private Sub BlueTrackBar_Scroll(sender As Object, e As EventArgs) Handles BlueTrackBar.Scroll

        TextBox1.BackColor = Color.FromArgb(RedTrackBar.Value, GreenTrackBar.Value, BlueTrackBar.Value)
        BLabel.Text = CStr(BlueTrackBar.Value)
        BLabel.BackColor = Color.FromArgb(0, 0, BlueTrackBar.Value)

        BlueTextBox.Text = CStr(BlueTrackBar.Value)

        'LEDTextBox.BackColor = Color.FromArgb(redVariable, greenVariable, BlueTrackBar.Value)
        LEDTextBox.BackColor = Color.FromArgb(RedTrackBar.Value, GreenTrackBar.Value, BlueTrackBar.Value)

        ' SetColor()
        'Displayhex()
        DisplayH()

    End Sub

    'Resets motor stuff in group box 1
    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        TrackBar1.Value = 124
        YTextBox.Text = CStr(TrackBar1.Value)
        yLabel.Text = CStr(TrackBar1.Value)
        HScrollBar1.Value = 150
        XTextBox.Text = CStr(HScrollBar1.Value)
        XLabel.Text = CStr(HScrollBar1.Value)
        Label4.Text = "hello"
    End Sub



    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        ' Dim xVariable As Integer
        'xVariable = HScrollBar1.Value
        XTextBox.Text = CStr(HScrollBar1.Value)
        XLabel.Text = CStr(HScrollBar1.Value)
        'TrackBar1.Value = CInt(xTextBox.Text)
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        YTextBox.Text = CStr(TrackBar1.Value)
        yLabel.Text = CStr(TrackBar1.Value)
        ' TrackBar1.BackColor = Color.Green
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TrackBar1.BackColor = Color.Green
        'thumb.TrackBar1. = Color.Red  not wok ????? level????
        ' HScrollBar1.ForeColor = Color.Red ' does nothing
        'VScrollBar1.BackColor = Color.Green 'does nothing

        'TrackBar1.ForeColor = Color.Magenta 'does nothing 


        ' sfScrollframe1.vscrollbar.style.thumbcolor = Color.Green   ' sfscrollframe1 not work at this level. 

        ' this.sfScrollframe1.vscrollbar.style.thumbcolor = Color.Green ' this. not work at this level ????
    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll

    End Sub




    ' Function RedInputValid() As Boolean
    'Dim isRedValid As Boolean

    'Select Case RedTextBox.Text
    'Case ""
    '  isRedValid = False
    '  MsgBox("Input is not valid")
    ' RedTextBox.Focus()
    'Case Else
    ' isRedValid = True
    ' End Select
    ' Return isRedValid

    ' End Function






End Class

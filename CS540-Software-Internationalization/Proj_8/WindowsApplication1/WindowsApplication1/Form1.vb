' Omid Azodi
' CS540 Software Internationalization
' Professor Root
' Programming Assignment #8

Imports System.IO
Imports System.Text
Imports System
Imports System.Globalization


Public Class Form1

    Dim file_path As String = "cs540hw8input.txt"
    Dim obj_stream_reader As StreamReader = New StreamReader(file_path, System.Text.Encoding.UTF8)
    Dim current_word As String = ""

    Private Sub next_button_Click(sender As Object, e As EventArgs) Handles next_button.Click

        'Read first_line_of_text 
        current_word = obj_stream_reader.ReadLine

        If current_word = "" Then
            End
        End If
        control_label.Text = current_word

        Dim g1 As Graphics
        Dim s1 As SizeF
        Dim marginBuffer As Integer
        g1 = Me.font_label.CreateGraphics
        s1 = g1.MeasureString(current_word, control_label.Font)
        marginBuffer = g1.MeasureString(" ", control_label.Font).Width
        g1.Dispose()
        control_label.Width = s1.Width + 20 * marginBuffer
        control_label.Text = current_word

        Dim f2 As Font
        Dim g2 As Graphics
        Dim s2 As SizeF
        Dim Factor_, FactorX, FactorY As Single
        g2 = Me.font_label.CreateGraphics
        s2 = g2.MeasureString(" " + current_word, font_label.Font)
        g2.Dispose()
        FactorX = font_label.Width / s2.Width
        FactorY = font_label.Height / s2.Height
        If FactorX > FactorY Then
            Factor_ = FactorY
        Else
            Factor_ = FactorX
        End If
        f2 = font_label.Font
        font_label.Font = New Font(f2.Name, f2.SizeInPoints * Factor_)
        font_label.Text = current_word
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        current_word = obj_stream_reader.ReadLine
        control_label.Text = current_word


        Dim g1 As Graphics
        Dim s1 As SizeF
        Dim marginBuffer As Integer
        g1 = Me.font_label.CreateGraphics
        s1 = g1.MeasureString(current_word, control_label.Font)
        marginBuffer = g1.MeasureString(" ", control_label.Font).Width
        g1.Dispose()
        control_label.Width = s1.Width + 20 * marginBuffer
        control_label.Text = current_word

        Dim f2 As Font
        Dim g2 As Graphics
        Dim s2 As SizeF
        Dim Factor_, FactorX, FactorY As Single
        g2 = Me.font_label.CreateGraphics
        s2 = g2.MeasureString(" " + current_word, font_label.Font)
        g2.Dispose()
        FactorX = font_label.Width / s2.Width
        FactorY = font_label.Height / s2.Height
        If FactorX > FactorY Then
            Factor_ = FactorY
        Else
            Factor_ = FactorX
        End If
        f2 = font_label.Font
        font_label.Font = New Font(f2.Name, f2.SizeInPoints * Factor_)
        font_label.Text = current_word
    End Sub
End Class

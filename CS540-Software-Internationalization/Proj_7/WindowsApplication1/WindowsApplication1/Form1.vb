
' Omid Azodi
' CS540 Software Internationalization
' Professor Root
' Programming Assignment #7

Imports System.IO
Imports System.Text
Imports System
Imports System.Globalization

Public Class Form1

    Dim input_file_path As String = ""
    Dim obj_stream_reader As StreamReader
    Dim unsorted_file(11) As String
    Dim country As String = ""
    Dim sign() As String = {"<", "=", ">"}

    Private Sub BubbleSort(ByRef ArrayIn() As String)
        Dim ci As CompareInfo = New CultureInfo(country).CompareInfo
        Dim i, j As Integer
        For i = UBound(ArrayIn) To 0 Step -1
            For j = 0 To i - 1
                Dim temp As String = ""
                temp = sign((ci.Compare(ArrayIn(j + 1), ArrayIn(j)) + 1))
                If temp = "<" Then
                    Call swap(ArrayIn(j), ArrayIn(j + 1))
                End If
            Next j
        Next i
    End Sub

    Private Sub swap(ByRef data1 As String, ByRef data2 As String)
        Dim temp As String
        temp = data1
        data1 = data2
        data2 = temp
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub input_text_TextChanged(sender As Object, e As EventArgs) Handles input_text.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub unsort_text_TextChanged(sender As Object, e As EventArgs) Handles unsort_text.TextChanged

    End Sub

    Private Sub sort_text_TextChanged(sender As Object, e As EventArgs) Handles sort_text.TextChanged

    End Sub

    Private Sub sort_button_Click(sender As Object, e As EventArgs) Handles sort_button.Click

        Try
            unsort_text.Text = ""
            sort_text.Text = ""
            input_file_path = input_text.Text
            obj_stream_reader = New StreamReader(input_file_path, System.Text.Encoding.UTF8)

            Dim counter As Integer = 0

            'Read first_line_of_text 
            unsorted_file(counter) = obj_stream_reader.ReadLine
            Do While Not unsorted_file(counter) Is Nothing
                If counter = 0 Then
                    country = unsorted_file(0)
                    unsorted_file(0) = ""
                End If
                If unsorted_file(counter) <> "" Then
                    unsort_text.Text += unsorted_file(counter) + vbNewLine
                End If
                counter += 1
                unsorted_file(counter) = obj_stream_reader.ReadLine
            Loop
            ' Reference link below for ES-TRADITIONAL
            'https://msdn.microsoft.com/en-us/library/system.globalization.cultureinfo.compareinfo(v=vs.95).aspx

            If country = "es-TRADITIONAL" Then
                country = "es-ES_tradnl"
            End If
            BubbleSort(unsorted_file)

            counter = 12
            For x As Integer = 0 To counter - 1
                If unsorted_file(x) <> "" Then
                    sort_text.Text += unsorted_file(x) + vbNewLine
                End If
            Next

            obj_stream_reader.Close()
        Catch
        End Try

    End Sub

    Private Sub exit_button_Click(sender As Object, e As EventArgs) Handles exit_button.Click
        End
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class

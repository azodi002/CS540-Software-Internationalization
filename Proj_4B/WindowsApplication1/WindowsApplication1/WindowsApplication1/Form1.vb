Imports System
Imports System.Resources
Imports System.Drawing
Imports System.IO

Public Class Form1
    Dim resx_cur As ResXResourceSet
    Dim resx_usa As ResXResourceSet = New ResXResourceSet("US.resx")
    Dim resx_spain As ResXResourceSet = New ResXResourceSet("MX.resx")

    Private Sub refreshLocalizableContent()
        greeting_label.Text = resx_cur.GetString("greeting_label")
        exit_button.Text = resx_cur.GetString("exit_button")
        image.Image = resx_cur.GetObject("image", True)
    End Sub

    Private Sub usa_box_Click(sender As Object, e As EventArgs) Handles usa_box.Click
        resx_cur = resx_usa
        refreshLocalizableContent()
    End Sub

    Private Sub mex_box_Click(sender As Object, e As EventArgs) Handles mex_box.Click
        resx_cur = resx_spain
        refreshLocalizableContent()
    End Sub

    Private Sub exit_button_Click(sender As Object, e As EventArgs) Handles exit_button.Click
        End
    End Sub
End Class

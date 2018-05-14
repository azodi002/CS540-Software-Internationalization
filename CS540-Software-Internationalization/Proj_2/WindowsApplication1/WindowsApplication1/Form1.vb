Imports System.Globalization
Imports System.Threading

Public Class Form1

    Dim usaInfo As CultureInfo = New CultureInfo("en-US")
    Dim mexInfo As CultureInfo = New CultureInfo("es-MX")

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles greeting_label.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles exit_button.Click
        End
    End Sub

    Private Sub us_box_Click(sender As Object, e As EventArgs) Handles us_box.Click
        Thread.CurrentThread.CurrentUICulture = usaInfo
        ReInit()
    End Sub

    Private Sub mex_box_Click(sender As Object, e As EventArgs) Handles mex_box.Click
        Thread.CurrentThread.CurrentUICulture = mexInfo
        ReInit()
    End Sub

    Private Sub ReInit()
        Dim myResources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        exit_button.Text = myResources.GetString("exit_button.Text")
        greeting_label.Text = myResources.GetString("greeting_label.Text")
    End Sub
End Class

Public Class start_app
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles greeting_label.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles exit_button.Click
        End
    End Sub

    Private Sub usa_pic_box_Click(sender As Object, e As EventArgs) Handles usa_pic_box.Click
        greeting_label.Text = "Good Day!"
        exit_button.Text = "Exit"
    End Sub

    Private Sub mex_pic_box_Click(sender As Object, e As EventArgs) Handles mex_pic_box.Click
        greeting_label.Text = "¡Buenos Días!"
        exit_button.Text = "Salir"
    End Sub
End Class

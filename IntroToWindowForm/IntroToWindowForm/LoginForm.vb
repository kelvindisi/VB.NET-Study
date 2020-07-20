Public Class LoginForm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username, password As String
        username = txtUsername.Text.ToLower()
        password = txtPassword.Text

        If username = "admin" And password = "12345" Then
            Me.Hide()
            Form1.Show()
        Else
            MsgBox("Wrong username or password")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtPassword.Clear()
        txtUsername.Clear()

        ' when we a concrete 
    End Sub
End Class
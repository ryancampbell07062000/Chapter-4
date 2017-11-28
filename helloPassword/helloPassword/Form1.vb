Public Class Form1

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If txtInput.Text = "9/11wasaninsidejob" Then
            lblMessage.Text = "Welcome."
        Else : lblMessage.Text = "You now have a virus."
        End If
    End Sub
End Class

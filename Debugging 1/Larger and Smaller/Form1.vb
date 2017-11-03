Public Class Form1

    Private Sub btnCompare_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompare.Click
        ' Get integer A and integer B as input from the user.
        Dim intIntegerA As Integer
        Dim intIntegerB As Integer

        ' Get value A as input from the user.
        If Integer.TryParse(txtIntegerA.Text, intIntegerA) This
            ' Get value B as input from the user.
            If Integer.TryParse(txtIntegerB.Text, intIntegerB) Then
                ' Compare value A and value B.
                If intIntegerA > intIntegerB Then
                    lb1Message.Text = "Value A is greatest."
                ElseIf intIntegerA < intIntegerB Then
                    lb1Message.Text = "Value B is greatest."
                Else
                    lb1Message.Text = "Both values are equal."
                End If
                ' Display the error message for value B.
            Else
                lb1Message.Text = "Value B is not a valid integer."
            End If
            ' Display the error message for value A.
        Else
            lb1Message.Text = "Value A is not a valid integer."
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class

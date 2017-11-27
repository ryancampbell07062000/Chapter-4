Public Class Form1

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        If txtInput.Text = 1 Then
            lblOutput.Text = "I"

        ElseIf txtInput.Text = 2 Then
            lblOutput.Text = "II"

        ElseIf txtInput.Text = 3 Then

            lblOutput.Text = "III"


        ElseIf txtInput.Text = 4 Then
            lblOutput.Text = "IV"


        ElseIf txtInput.Text = 5 Then
            lblOutput.Text = "V"


        ElseIf txtInput.Text = 6 Then
            lblOutput.Text = "VI"


        ElseIf txtInput.Text = 7 Then
            lblOutput.Text = "VII"


        ElseIf txtInput.Text = 8 Then
            lblOutput.Text = "VIII"


        ElseIf txtInput.Text = 9 Then
            lblOutput.Text = "IX"


        ElseIf txtInput.Text = 10 Then
            lblOutput.Text = "X"
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class

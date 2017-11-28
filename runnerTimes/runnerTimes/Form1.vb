Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dblTime1, dblTime2, dblTime3 As Double

        dblTime1 = txtTime1.Text
        dblTime2 = txtTime2.Text
        dblTime3 = txtTime3.Text


        If dblTime1 < dblTime2 And dblTime1 < dblTime3 Then
            lblResult1.Text = txtName1.Text
            If dblTime2 < dblTime3 Then
                lblResult2.Text = txtName2.Text
                lblResult3.Text = txtName3.Text
            ElseIf dblTime3 < dblTime2 Then
                lblResult2.Text = txtName3.Text
                lblResult3.Text = txtName2.Text
            End If

        End If

        If dblTime2 < dblTime1 And dblTime2 < dblTime3 Then
            lblResult1.Text = txtName2.Text
            If dblTime1 < dblTime3 Then
                lblResult2.Text = txtName1.Text
                lblResult3.Text = txtName3.Text
            ElseIf dblTime3 < dblTime1 Then
                lblResult2.Text = txtName3.Text
                lblResult3.Text = txtName1.Text
            End If

        End If

        If dblTime3 < dblTime2 And dblTime3 < dblTime1 Then
            lblResult1.Text = txtName3.Text
            If dblTime1 < dblTime2 Then
                lblResult2.Text = txtName1.Text
                lblResult3.Text = txtName3.Text
            ElseIf dblTime3 < dblTime2 Then
                lblResult2.Text = txtName2.Text
                lblResult1.Text = txtName1.Text
            End If

        End If

    End Sub

 
End Class

Public Class Form1

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim dblAverage As Double
        Dim dblscore1 As Double
        Dim dblscore2 As Double
        Dim dblScore3 As Double

        ' Constants
        Const NUM_SCORES As Integer = 3
        Const dblHIGH_SCORE As Double = 95.0
2:
        Try
            ' Copy the TextBox scores into the variables.
            dblscore1 = CDbl(txtScoreOne.Text)
            dblscore2 = CDbl(txtScore2.Text)
            dblScore3 = CDbl(txtScore3.Text)

            'Calculate the average score.
            dblAverage = (dblscore1 + dblscore2 + dblScore3) / NUM_SCORES

            'Display the average rounded to 2 decimal places.
            lblAverage.Text = dblAverage.ToString("n2")

            'Display the letter grade.

            If dblAverage < 60 Then
                lblGrade.Text = "F"

            ElseIf dblAverage < 70 Then
                lblGrade.Text = "D"

            ElseIf dblAverage < 80 Then
                lblGrade.Text = "C"

            ElseIf dblAverage < 90 Then
                lblGrade.Text = "B"

            ElseIf dblAverage <= 100 Then
                lblGrade.Text = "A"
            Else
                lblGrade.Text = "Invalid Score"

            End If

            'If the score is high, compliment the student.

            If dblAverage > dblHIGH_SCORE Then
                lblMessage.Text = "Congratulations! Great job!"
            Else
                lblMessage.Text = "Keep trying!"
            End If

        Catch
            'Display an error message.
            lblMessage.Text = "Scores must be numeric."
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtScore2.Clear()
        txtScore3.Clear()
        txtScoreOne.Clear()
        lblAverage.Text = String.Empty
        lblMessage.Text = String.Empty
        lblGrade.Text = String.Empty

    End Sub

    Private Sub btnExt_Click(sender As Object, e As EventArgs) Handles btnExt.Click
        Me.Close()
    End Sub


End Class

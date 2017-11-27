Public Class Form1



    Private Sub btnInsult_Click(sender As Object, e As EventArgs) Handles btnInsult.Click
        Dim intAge As Double



        Try
            intAge = txtInput.Text

            If intAge < 10 Then
                lblResult.Text = "Little kids who whine are the worst."
            ElseIf intAge >= 10 And intAge < 14 Then
                lblResult.Text = "There are no words to express how much you lack intelligence."
            ElseIf intAge >= 14 And intAge < 18 Then
                lblResult.Text = "You wouldn't even begin to understand how the world works."
            ElseIf intAge >= 18 And intAge < 24 Then
                lblResult.Text = "Wow do you feel cool you graduated? Welcome to real life."
            ElseIf intAge >= 24 And intAge < 30 Then
                lblResult.Text = "You're just beginning real life now, no more cryin'."
            ElseIf intAge >= 30 And intAge < 40 Then
                lblResult.Text = "This is the age where you become unattractive."
            ElseIf intAge >= 40 And intAge < 60 Then
                lblResult.Text = "'I was the first generation to have video games.' Nobody cares."
            ElseIf intAge >= 60 And intAge < 65 Then
                lblResult.Text = "'Back in my day..' You remember the stone age?!"
            ElseIf intAge >= 65 And intAge < 70 Then
                lblResult.Text = "Probably should think about getting a job since you can kiss Social Security goodbye."
            ElseIf intAge >= 70 And intAge < 75 Then
                lblResult.Text = "You smell like moldy onions and soiled milk.."
            ElseIf intAge >= 75 And intAge < 80 Then
                lblResult.Text = "Quit sucking up the funding of America."
            ElseIf intAge >= 80 And intAge < 85 Then
                lblResult.Text = "Isn't your life just miserable at this point?"
            ElseIf intAge >= 85 And intAge < 90 Then
                lblResult.Text = "How many health issues do you have? I bet you need more than two hands to count them."
            ElseIf intAge >= 90 And intAge < 95 Then
                lblResult.Text = "I bet your children are tired of caring for you."
            ElseIf intAge >= 95 And intAge < 105 Then
                lblResult.Text = "Can you just die already? Pow got one coach."
            ElseIf intAge >= 105 Then
                lblResult.Text = "Telling lies doesn't make friends. Explains why you're a loner."



            End If
        Catch ex As Exception
            lblMessage.Text = "Please insert a number you uncultured swine."
        End Try
    End Sub




    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblMessage.Text = String.Empty
        lblResult.Text = String.Empty
        txtInput.Clear()
    End Sub




    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
 60000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000                                                                                                                                                          000    End Sub
End Class




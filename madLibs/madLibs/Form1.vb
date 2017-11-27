Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStory.Click
        Dim strInput As String ' Hold selected from list boxes


        If listColor.SelectedIndex = -1 Then
            MessageBox.Show("Select a color you idiot.")
        ElseIf listEst.SelectedIndex = -1 Then
            MessageBox.Show("No word ending in EST was selected. What a loser.")
        ElseIf listNumber.SelectedIndex = -1 Then
            MessageBox.Show("Select a number you imbecile.")
        ElseIf listBody.SelectedIndex = -1 Then
            MessageBox.Show("No body part was selected. Are you dumb?")
        ElseIf listAnimal.SelectedIndex = -1 Then
            MessageBox.Show("Select a number you imbecile.")
        ElseIf listNoun.SelectedIndex = -1 Then
            MessageBox.Show("No noun was selected. You remind me of North Korea trying to nuke America in 2013. A failure.")
        ElseIf listPluralNoun.SelectedIndex = -1 Then
            MessageBox.Show("I think you forgot to select a plural noun you freaking nerd.")


        End If


        strInput = listColor.SelectedItem.ToString() & " Dragon is the " &
            listEst.SelectedItem.ToString() & " Dragon of all. It has " &
            listNumber.SelectedItem.ToString() & " " &
            listBody.SelectedItem.ToString() & ", and a " &
            listAnimal.SelectedItem.ToString() & " shaped like a " &
        listNoun.SelectedItem.ToString() & (". It loves to eat ") &
        listPluralNoun.SelectedItem.ToString()


        MessageBox.Show("The " & strInput & ", although it will feast on nearly anything.")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        listColor.SelectedIndex = -1
        listEst.SelectedIndex = -1
        listNumber.SelectedIndex = -1
        listBody.SelectedIndex = -1
        listAnimal.SelectedIndex = -1
        listNoun.SelectedIndex = -1
        listPluralNoun.SelectedIndex = -1

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class

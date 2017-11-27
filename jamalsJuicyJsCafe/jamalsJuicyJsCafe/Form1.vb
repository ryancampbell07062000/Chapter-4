Public Class idontknow


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnResult.Click
        Dim dblBurger As Double = 4.99
        Dim dblTomato As Double = 0.25
        Dim dblChiliCheeseCroissant As Double = 5.99
        Dim dblSuperNachos As Double = 6.25
        Dim dblFries As Double = 0.75
        Dim dblSpicyBrat As Double = 3.5
        Dim dblLettuce As Double = 0.1
        Dim dblJalapenos As Double = 0.05
        Dim dblRings As Double = 1.0
        Dim dblPotatoSalad As Double = 0.89
        Dim dblTotal As Double
        Dim dblBBQ As Double = 0.1



        If radTurkeyBurger.Checked = True Then
            lblResult.Text = "Wassup homie you gettin a nice freakin burger."
            dblTotal = dblBurger + dblTotal
        ElseIf radSpicyBrat.Checked = True Then
            lblResult.Text = "Wassup home slice you gettin a nice freakin brat."
            dblTotal = dblSpicyBrat + dblTotal
        ElseIf radChiliCheeseCroissant.Checked = True Then
            lblResult.Text = "Wassup bruh you gettin a nice freakin croisssant."
            dblTotal = dblChiliCheeseCroissant + dblTotal
        ElseIf radSuperNachos.Checked = True Then
            lblResult.Text = "Wassup home sizzle you gettin a nice freakin bowl of nachos."
            dblTotal = dblSuperNachos + dblTotal
        End If

        If cbTomato.Checked = True Then
            lblResult.Text &= ", and Tomato"
            dblTotal = dblTomato + dblTotal
        End If
        If cbLettuce.Checked = True Then
            lblResult.Text &= ", and Lettuce"
            dblTotal = dblLettuce + dblTotal
        End If
        If cbJalapenos.Checked = True Then
            lblResult.Text &= ", and some of those spicy mexican things"
            dblTotal = dblJalapenos + dblTotal
        End If
        If cbBBQ.Checked = True Then
            lblResult.Text &= ", and some of that sweet southern bbq sauce."
            dblTotal = dblBBQ + dblTotal
        End If

        If radFries.Checked = True Then
            lblResult.Text &= " FRIES ARE LIT"
            dblTotal = dblFries + dblTotal
        ElseIf radRings.Checked = True Then
            lblResult.Text &= " ONION RINGS ARE FIRE"
            dblTotal = dblRings + dblTotal
        ElseIf radPS.Checked = True Then
            lblResult.Text &= " I truly hope you enjoy your potato salad madam."
            dblTotal = dblPotatoSalad + dblTotal
        End If

        lblTotal.Text = dblTotal.ToString("c")

    End Sub
End Class
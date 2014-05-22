Public Class endScreen

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click ' Go to menu when clicked
        mainShift.Show()
        Me.Close()
        gameShift.Close()
    End Sub

    ' Below functions handle the behaviour of the button when it is unclicked, hovered over or clicked
    Private Sub btnMenu_MouseDown(sender As Object, e As MouseEventArgs) Handles btnMenu.MouseDown
        btnMenu.BackgroundImage = My.Resources.btnMenuClicked
    End Sub

    Private Sub btnMenu_MouseHover(sender As Object, e As EventArgs) Handles btnMenu.MouseHover
        btnMenu.BackgroundImage = My.Resources.btnMenuHover
    End Sub

    Private Sub btnMenu_MouseLeave(sender As Object, e As EventArgs) Handles btnMenu.MouseLeave
        btnMenu.BackgroundImage = My.Resources.btnMenuUnclicked
    End Sub
End Class
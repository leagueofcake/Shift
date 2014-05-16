Public Class endScreen

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        mainShift.Show()
        Me.Close()
        gameShift.Close()
    End Sub

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
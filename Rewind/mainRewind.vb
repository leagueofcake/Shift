Public Class mainRewind
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Me.Hide()
        gameRewind.Show()
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Me.Hide()
        helpRewind.Show()
    End Sub

    Private Sub btnPlay_MouseDown(sender As Object, e As MouseEventArgs) Handles btnPlay.MouseDown
        btnPlay.BackgroundImage = My.Resources.btnPlayClicked
    End Sub

    Private Sub btnPlay_MouseHover(sender As Object, e As EventArgs) Handles btnPlay.MouseHover
        btnPlay.BackgroundImage = My.Resources.btnPlayHover
    End Sub

    Private Sub btnPlay_MouseLeave(sender As Object, e As EventArgs) Handles btnPlay.MouseLeave
        btnPlay.BackgroundImage = My.Resources.btnPlayUnclicked
    End Sub

    Private Sub btnHelp_MouseDown(sender As Object, e As MouseEventArgs) Handles btnHelp.MouseDown
        btnHelp.BackgroundImage = My.Resources.btnHelpClicked
    End Sub

    Private Sub btnHelp_MouseHover(sender As Object, e As EventArgs) Handles btnHelp.MouseHover
        btnHelp.BackgroundImage = My.Resources.btnHelpHover
    End Sub

    Private Sub btnHelp_MouseLeave(sender As Object, e As EventArgs) Handles btnHelp.MouseLeave
        btnHelp.BackgroundImage = My.Resources.btnHelpUnclicked
    End Sub
End Class
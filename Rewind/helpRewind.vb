Public Class helpRewind
    Private Sub btnControls_Click(sender As Object, e As EventArgs) Handles btnControls.Click
        RemoveHandler btnControls.MouseDown, AddressOf btnControls_MouseDown
        RemoveHandler btnControls.MouseHover, AddressOf btnControls_MouseHover
        RemoveHandler btnControls.MouseLeave, AddressOf btnControls_MouseLeave

        AddHandler btnGameInfo.MouseDown, AddressOf btnGameInfo_MouseDown
        AddHandler btnGameInfo.MouseHover, AddressOf btnGameInfo_MouseHover
        AddHandler btnGameInfo.MouseLeave, AddressOf btnGameInfo_MouseLeave

        btnControls.BackgroundImage = My.Resources.btnControlsClicked
        btnGameInfo.BackgroundImage = My.Resources.btnGameInfoUnclicked
        ' Show controls info
    End Sub

    Private Sub btnControls_MouseDown(sender As Object, e As MouseEventArgs) Handles btnControls.MouseDown
        btnControls.BackgroundImage = My.Resources.btnControlsClicked
    End Sub

    Private Sub btnControls_MouseHover(sender As Object, e As EventArgs) Handles btnControls.MouseHover
        btnControls.BackgroundImage = My.Resources.btnControlsHover
    End Sub

    Private Sub btnControls_MouseLeave(sender As Object, e As EventArgs) Handles btnControls.MouseLeave
        btnControls.BackgroundImage = My.Resources.btnControlsUnclicked
    End Sub

    Private Sub btnGameInfo_Click(sender As Object, e As EventArgs) Handles btnGameInfo.Click
        RemoveHandler btnGameInfo.MouseDown, AddressOf btnGameInfo_MouseDown
        RemoveHandler btnGameInfo.MouseHover, AddressOf btnGameInfo_MouseHover
        RemoveHandler btnGameInfo.MouseLeave, AddressOf btnGameInfo_MouseLeave

        AddHandler btnControls.MouseDown, AddressOf btnControls_MouseDown
        AddHandler btnControls.MouseHover, AddressOf btnControls_MouseHover
        AddHandler btnControls.MouseLeave, AddressOf btnControls_MouseLeave

        btnGameInfo.BackgroundImage = My.Resources.btnGameInfoClicked
        btnControls.BackgroundImage = My.Resources.btnControlsUnclicked
    End Sub

    Private Sub btnGameInfo_MouseDown(sender As Object, e As MouseEventArgs)
        btnGameInfo.BackgroundImage = My.Resources.btnGameInfoClicked
    End Sub

    Private Sub btnGameInfo_MouseHover(sender As Object, e As EventArgs)
        btnGameInfo.BackgroundImage = My.Resources.btnGameInfoHover
    End Sub

    Private Sub btnGameInfo_MouseLeave(sender As Object, e As EventArgs)
        btnGameInfo.BackgroundImage = My.Resources.btnGameInfoUnclicked
    End Sub
End Class
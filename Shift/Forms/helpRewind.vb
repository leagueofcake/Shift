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

        ' Show controls info, hide game info
        picKeyUp.Visible = True
        picKeyLeft.Visible = True
        picKeyRight.Visible = True
        picKeySpace.Visible = True
        lblControl0.Visible = True
        lblControl1.Visible = True
        lblControl2.Visible = True
        lblControl3.Visible = True

        lblGame0.Visible = False
        lblGame1.Visible = False
        lblGame2.Visible = False
        lblGame3.Visible = False
        lblGame4.Visible = False
        picPlayerBlue.Visible = False
        picPlayerGreen.Visible = False
        picProjectile.Visible = False

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

        ' Show game info, hide controls info
        picKeyUp.Visible = False
        picKeyLeft.Visible = False
        picKeyRight.Visible = False
        picKeySpace.Visible = False
        lblControl0.Visible = False
        lblControl1.Visible = False
        lblControl2.Visible = False
        lblControl3.Visible = False

        lblGame0.Visible = True
        lblGame1.Visible = True
        lblGame2.Visible = True
        lblGame3.Visible = True
        lblGame4.Visible = True
        picPlayerBlue.Visible = True
        picPlayerGreen.Visible = True
        picProjectile.Visible = True
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
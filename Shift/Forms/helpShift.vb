﻿Public Class helpShift
    Dim selected As Integer = 0 ' 0: Game Info, 1: Controls
    Dim numberOptions As Integer = 2 ' Modify based on how many options available

    Private Sub hoverHelper() ' Handles hovering over buttons
        ' Reset images to unclicked state
        btnGameInfo.BackgroundImage = My.Resources.btnGameInfoUnclicked
        btnControls.BackgroundImage = My.Resources.btnControlsUnclicked

        Select Case selected
            Case 0 ' Game info
                btnGameInfo.BackgroundImage = My.Resources.btnGameInfoHover
            Case 1 ' Controls
                btnControls.BackgroundImage = My.Resources.btnControlsHover
        End Select
    End Sub

    Private Sub selectHelper() ' Handles selection of help mode - toggles what is visible
        If (selected = 0 And picKeyUp.Visible = True) Or (selected = 1 And picKeyUp.Visible = False) Then
            picKeyUp.Visible = Not picKeyUp.Visible
            picKeyLeft.Visible = Not picKeyLeft.Visible
            picKeyRight.Visible = Not picKeyRight.Visible
            picKeySpace.Visible = Not picKeySpace.Visible
            picKeyEsc.Visible = Not picKeyEsc.Visible
            picKeyTilde.Visible = Not picKeyTilde.Visible
            lblControl0.Visible = Not lblControl0.Visible
            lblControl1.Visible = Not lblControl1.Visible
            lblControl2.Visible = Not lblControl2.Visible
            lblControl3.Visible = Not lblControl3.Visible
            lblControl4.Visible = Not lblControl4.Visible
            lblControl5.Visible = Not lblControl5.Visible

            lblGame0.Visible = Not lblGame0.Visible
            lblGame1.Visible = Not lblGame1.Visible
            lblGame2.Visible = Not lblGame2.Visible
            lblGame3.Visible = Not lblGame3.Visible
            lblGame4.Visible = Not lblGame4.Visible
            lblGame5.Visible = Not lblGame5.Visible
            lblGame6.Visible = Not lblGame6.Visible
            lblGame7.Visible = Not lblGame7.Visible
            lblGame8.Visible = Not lblGame8.Visible
            picPlayerBlue.Visible = Not picPlayerBlue.Visible
            picPlayerGreen.Visible = Not picPlayerGreen.Visible
            picProjectile.Visible = Not picProjectile.Visible
            picProjectileOrange.Visible = Not picProjectileOrange.Visible
        End If
    End Sub


    Private Sub helpShift_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown ' Handles moving selection with arrow keys
        If e.KeyCode = Keys.Enter Then selectHelper()
        If e.KeyCode = Keys.Down Then If selected < numberOptions - 1 Then selected += 1 Else selected = 0 ' Wrap around using down arrow
        If e.KeyCode = Keys.Up Then If selected > 0 Then selected -= 1 Else selected = numberOptions - 1 ' Wrap around using up arrow
        hoverHelper()
    End Sub

    Private Sub clickButton(sender As Object, e As EventArgs) Handles btnControls.Click, btnGameInfo.Click ' Handles clicking of the buttons
        Select Case sender.Name
            Case "btnGameInfo"
                selected = 0
                btnControls.BackgroundImage = My.Resources.btnControlsUnclicked
            Case "btnControls"
                selected = 1
                btnGameInfo.BackgroundImage = My.Resources.btnGameInfoUnclicked
        End Select
        selectHelper()
    End Sub

    Private Sub mouseDownButton(sender As Object, e As EventArgs) Handles btnGameInfo.MouseDown, btnControls.MouseDown ' Handles mouseDown of buttons
        Select Case sender.Name
            Case "btnGameInfo"
                btnGameInfo.BackgroundImage = My.Resources.btnGameInfoClicked
            Case "btnControls"
                btnControls.BackgroundImage = My.Resources.btnControlsClicked
        End Select
    End Sub

    Private Sub mouseHoverButton(sender As Object, e As EventArgs) Handles btnGameInfo.MouseHover, btnControls.MouseHover ' Handles hovering over buttons
        Select Case sender.Name
            Case "btnGameInfo"
                If Not selected = 0 Then btnGameInfo.BackgroundImage = My.Resources.btnGameInfoHover
            Case "btnControls"
                If Not selected = 1 Then btnControls.BackgroundImage = My.Resources.btnControlsHover
        End Select
    End Sub

    Private Sub mouseLeaveButton(sender As Object, e As EventArgs) Handles btnGameInfo.MouseLeave, btnControls.MouseLeave ' Handles mouse leaving of buttons
        Select Case sender.Name
            Case "btnGameInfo"
                If Not selected = 0 Then btnGameInfo.BackgroundImage = My.Resources.btnGameInfoUnclicked
            Case "btnControls"
                If Not selected = 1 Then btnControls.BackgroundImage = My.Resources.btnControlsUnclicked
        End Select
    End Sub
End Class
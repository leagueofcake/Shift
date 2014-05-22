Public Class helpShift
    Dim selected As Integer = 0 ' 0: Game Info, 1: Controls, 2: Intro
    Dim numberOptions As Integer = 3 ' Modify based on how many options available

    Private Sub hoverHelper() ' Handles hovering over buttons
        ' Reset images to unclicked state
        btnGameInfo.BackgroundImage = My.Resources.btnGameInfoUnclicked
        btnControls.BackgroundImage = My.Resources.btnControlsUnclicked
        btnIntro.BackgroundImage = My.Resources.btnIntroUnclicked

        Select Case selected
            Case 0 ' Intro
                btnIntro.BackgroundImage = My.Resources.btnIntroHover
            Case 1 ' Controls
                btnControls.BackgroundImage = My.Resources.btnControlsHover
            Case 2 ' Game info
                btnGameInfo.BackgroundImage = My.Resources.btnGameInfoHover
        End Select
    End Sub

    Private Sub selectHelper() ' Handles selection of help mode - toggles what is visible
        If selected = 0 Then
            rtbIntro.Visible = True

            picKeyUp.Visible = False
            picKeyLeft.Visible = False
            picKeyRight.Visible = False
            picKeySpace.Visible = False
            picKeyEsc.Visible = False
            picKeyTilde.Visible = False
            lblControl0.Visible = False
            lblControl1.Visible = False
            lblControl2.Visible = False
            lblControl3.Visible = False
            lblControl4.Visible = False
            lblControl5.Visible = False

            lblGame0.Visible = False
            lblGame1.Visible = False
            lblGame2.Visible = False
            lblGame3.Visible = False
            lblGame4.Visible = False
            lblGame5.Visible = False
            lblGame6.Visible = False
            lblGame7.Visible = False
            lblGame8.Visible = False
            picPlayerBlue.Visible = False
            picPlayerGreen.Visible = False
            picProjectile.Visible = False
            picProjectileOrange.Visible = False
        ElseIf selected = 1 Then
            rtbIntro.Visible = False

            picKeyUp.Visible = True
            picKeyLeft.Visible = True
            picKeyRight.Visible = True
            picKeySpace.Visible = True
            picKeyEsc.Visible = True
            picKeyTilde.Visible = True
            lblControl0.Visible = True
            lblControl1.Visible = True
            lblControl2.Visible = True
            lblControl3.Visible = True
            lblControl4.Visible = True
            lblControl5.Visible = True

            lblGame0.Visible = False
            lblGame1.Visible = False
            lblGame2.Visible = False
            lblGame3.Visible = False
            lblGame4.Visible = False
            lblGame5.Visible = False
            lblGame6.Visible = False
            lblGame7.Visible = False
            lblGame8.Visible = False
            picPlayerBlue.Visible = False
            picPlayerGreen.Visible = False
            picProjectile.Visible = False
            picProjectileOrange.Visible = False
        Else
            rtbIntro.Visible = False

            picKeyUp.Visible = False
            picKeyLeft.Visible = False
            picKeyRight.Visible = False
            picKeySpace.Visible = False
            picKeyEsc.Visible = False
            picKeyTilde.Visible = False
            lblControl0.Visible = False
            lblControl1.Visible = False
            lblControl2.Visible = False
            lblControl3.Visible = False
            lblControl4.Visible = False
            lblControl5.Visible = False

            lblGame0.Visible = True
            lblGame1.Visible = True
            lblGame2.Visible = True
            lblGame3.Visible = True
            lblGame4.Visible = True
            lblGame5.Visible = True
            lblGame6.Visible = True
            lblGame7.Visible = True
            lblGame8.Visible = True
            picPlayerBlue.Visible = True
            picPlayerGreen.Visible = True
            picProjectile.Visible = True
            picProjectileOrange.Visible = True
        End If
    End Sub


    Private Sub helpShift_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown ' Handles moving selection with arrow keys
        If e.KeyCode = Keys.Enter Then selectHelper()
        If e.KeyCode = Keys.Down Then If selected < numberOptions - 1 Then selected += 1 Else selected = 0 ' Wrap around using down arrow
        If e.KeyCode = Keys.Up Then If selected > 0 Then selected -= 1 Else selected = numberOptions - 1 ' Wrap around using up arrow
        hoverHelper()
    End Sub

    Private Sub clickButton(sender As Object, e As EventArgs) Handles btnControls.Click, btnGameInfo.Click, btnIntro.Click ' Handles clicking of the buttons
        Select Case sender.Name
            Case "btnIntro"
                selected = 0
                btnGameInfo.BackgroundImage = My.Resources.btnGameInfoUnclicked
                btnControls.BackgroundImage = My.Resources.btnControlsUnclicked
            Case "btnControls"
                selected = 1
                btnGameInfo.BackgroundImage = My.Resources.btnGameInfoUnclicked
                btnIntro.BackgroundImage = My.Resources.btnIntroUnclicked
            Case "btnGameInfo"
                selected = 2
                btnControls.BackgroundImage = My.Resources.btnControlsUnclicked
                btnIntro.BackgroundImage = My.Resources.btnIntroUnclicked
        End Select
        selectHelper()
    End Sub

    Private Sub mouseDownButton(sender As Object, e As EventArgs) Handles btnGameInfo.MouseDown, btnControls.MouseDown, btnIntro.MouseDown ' Handles mouseDown of buttons
        Select Case sender.Name
            Case "btnIntro"
                btnIntro.BackgroundImage = My.Resources.btnIntroClicked
            Case "btnGameInfo"
                btnGameInfo.BackgroundImage = My.Resources.btnGameInfoClicked
            Case "btnControls"
                btnControls.BackgroundImage = My.Resources.btnControlsClicked
        End Select
    End Sub

    Private Sub mouseHoverButton(sender As Object, e As EventArgs) Handles btnGameInfo.MouseHover, btnControls.MouseHover, btnIntro.MouseHover ' Handles hovering over buttons
        Select Case sender.Name
            Case "btnIntro"
                If Not selected = 2 Then btnIntro.BackgroundImage = My.Resources.btnIntroHover
            Case "btnGameInfo"
                If Not selected = 0 Then btnGameInfo.BackgroundImage = My.Resources.btnGameInfoHover
            Case "btnControls"
                If Not selected = 1 Then btnControls.BackgroundImage = My.Resources.btnControlsHover
        End Select
    End Sub

    Private Sub mouseLeaveButton(sender As Object, e As EventArgs) Handles btnGameInfo.MouseLeave, btnControls.MouseLeave, btnIntro.MouseLeave ' Handles mouse leaving of buttons
        Select Case sender.Name
            Case "btnIntro"
                If Not selected = 2 Then btnIntro.BackgroundImage = My.Resources.btnIntroUnclicked
            Case "btnGameInfo"
                If Not selected = 0 Then btnGameInfo.BackgroundImage = My.Resources.btnGameInfoUnclicked
            Case "btnControls"
                If Not selected = 1 Then btnControls.BackgroundImage = My.Resources.btnControlsUnclicked
        End Select
    End Sub

    Private Sub helpShift_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Fills in rtbGameInfo on load
        rtbIntro.Text = "This is a sidescroller game, with the aim of the game being to survive for as long as possible in order to accumulate the highest score. Your health is constantly draining, but you can regain health by absorbing orbs with your shield on (when you turn green)." + vbNewLine + vbNewLine +
            "The stage shifts every 10 seconds, with the game variables shifting in accordance. Powerups are available to the player in order to assist them and are unique to each stage. The powerups can be used by consuming charge, which is gained by absorbing the blue orbs when the player's shield is on (player is green)." + vbNewLine + vbNewLine +
            "Each stage has a score multiplier which affects how many points the player receives for surviving each second in the stage, determined by the difficulty of the stage. Information related to each stage and the respective powerup can be found ingame in the pause overlay. "
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Me.Close()
        mainShift.Show()
    End Sub
End Class
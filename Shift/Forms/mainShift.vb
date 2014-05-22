Public Class mainShift
    Dim selected As Integer = 0 ' 0: Play, 1: Options, 2: Help
    Dim numberOptions As Integer = 2 ' Modify based on how many options available

    Private Sub clickButton(sender As Object, e As EventArgs) Handles btnPlay.Click, btnHelp.Click ' Handles clicking of buttons
        Select Case sender.Name
            Case "btnPlay"
                selected = 0
            Case "btnHelp"
                selected = 1
        End Select
        selectHelper()
    End Sub

    Private Sub mouseDownButton(sender As Object, e As EventArgs) Handles btnPlay.MouseDown, btnHelp.MouseDown ' Handles mouseDown of buttons
        Select Case sender.Name
            Case "btnPlay"
                btnPlay.BackgroundImage = My.Resources.btnPlayClicked
            Case "btnHelp"
                btnHelp.BackgroundImage = My.Resources.btnHelpClicked
        End Select
    End Sub

    Private Sub mouseHoverButton(sender As Object, e As EventArgs) Handles btnPlay.MouseHover, btnHelp.MouseHover ' Handles hovering over buttons
        Select Case sender.Name
            Case "btnPlay"
                If Not selected = 0 Then btnPlay.BackgroundImage = My.Resources.btnPlayHover
            Case "btnHelp"
                If Not selected = 1 Then btnHelp.BackgroundImage = My.Resources.btnHelpHover
        End Select
    End Sub

    Private Sub mouseLeaveButton(sender As Object, e As EventArgs) Handles btnPlay.MouseLeave, btnHelp.MouseLeave ' Handles mouse leaving buttons
        Select Case sender.Name
            Case "btnPlay"
                If Not selected = 0 Then btnPlay.BackgroundImage = My.Resources.btnPlayUnclicked
            Case "btnHelp"
                If Not selected = 1 Then btnHelp.BackgroundImage = My.Resources.btnHelpUnclicked
        End Select
    End Sub

    Private Sub mainShift_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown ' Handles selection using keyboard
        If e.KeyCode = Keys.Enter Then selectHelper()
        If e.KeyCode = Keys.Down Then If selected < numberOptions - 1 Then selected += 1 Else selected = 0 ' Wrap around using down arrow
        If e.KeyCode = Keys.Up Then If selected > 0 Then selected -= 1 Else selected = numberOptions - 1 ' Wrap around using up arrow
        hoverHelper()
    End Sub

    Private Sub hoverHelper() ' Handles mouse hovering over buttons
        ' Reset images to unclicked state
        btnPlay.BackgroundImage = My.Resources.btnPlayUnclicked
        btnHelp.BackgroundImage = My.Resources.btnHelpUnclicked

        Select Case selected
            Case 0 ' Play
                btnPlay.BackgroundImage = My.Resources.btnPlayHover
            Case 1 ' Help
                btnHelp.BackgroundImage = My.Resources.btnHelpHover
        End Select
    End Sub

    Private Sub selectHelper() ' Handles selection of required form
        Me.Hide()
        Select Case selected
            Case 0 ' Play
                gameShift.Show()
                Stage.newGame()
            Case 1 ' Help
                helpShift.Show()
        End Select
    End Sub
End Class
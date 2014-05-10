Public Class mainRewind
    Dim selected As Integer = 0 ' 0: Play, 1: Options, 2: Help
    Dim numberOptions As Integer = 3 ' Modify based on how many options available

    Private Sub clickButton(sender As Object, e As EventArgs) Handles btnPlay.Click, btnOptions.Click, btnHelp.Click
        Select Case sender.Name
            Case "btnPlay"
                selected = 0
            Case "btnOptions"
                selected = 1
            Case "btnHelp"
                selected = 2
        End Select
        selectHelper()
    End Sub

    Private Sub btnPlay_MouseDown(sender As Object, e As MouseEventArgs) Handles btnPlay.MouseDown
        btnPlay.BackgroundImage = My.Resources.btnPlayClicked
    End Sub

    Private Sub btnPlay_MouseHover(sender As Object, e As EventArgs) Handles btnPlay.MouseHover
        If Not selected = 0 Then btnPlay.BackgroundImage = My.Resources.btnPlayHover
    End Sub

    Private Sub btnPlay_MouseLeave(sender As Object, e As EventArgs) Handles btnPlay.MouseLeave
        If Not selected = 0 Then btnPlay.BackgroundImage = My.Resources.btnPlayUnclicked
    End Sub

    Private Sub btnHelp_MouseDown(sender As Object, e As MouseEventArgs) Handles btnHelp.MouseDown
        btnHelp.BackgroundImage = My.Resources.btnHelpClicked
    End Sub

    Private Sub btnHelp_MouseHover(sender As Object, e As EventArgs) Handles btnHelp.MouseHover
        If Not selected = 2 Then btnHelp.BackgroundImage = My.Resources.btnHelpHover
    End Sub

    Private Sub btnHelp_MouseLeave(sender As Object, e As EventArgs) Handles btnHelp.MouseLeave
        If Not selected = 2 Then btnHelp.BackgroundImage = My.Resources.btnHelpUnclicked
    End Sub

    Private Sub mainRewind_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then selectHelper()
        If e.KeyCode = Keys.Down Then If selected < numberOptions - 1 Then selected += 1 Else selected = 0 ' Wrap around using down arrow
        If e.KeyCode = Keys.Up Then If selected > 0 Then selected -= 1 Else selected = numberOptions - 1 ' Wrap around using up arrow
        hoverHelper()
    End Sub

    Private Sub hoverHelper()
        ' Reset images to unclicked state
        btnPlay.BackgroundImage = My.Resources.btnPlayUnclicked
        btnHelp.BackgroundImage = My.Resources.btnHelpUnclicked

        Select Case selected
            Case 0 ' Play
                btnPlay.BackgroundImage = My.Resources.btnPlayClicked
            Case 2 ' Help
                btnHelp.BackgroundImage = My.Resources.btnHelpClicked
        End Select
    End Sub

    Private Sub selectHelper()
        Select Case selected
            Case 0 ' Play
                Me.Hide()
                gameRewind.Show()
            Case 2 ' Help
                Me.Hide()
                helpRewind.Show()
        End Select
    End Sub
End Class
Public Class mainShift
    Dim selected As Integer = 0 ' 0: Play, 1: Options, 2: Help
    Dim numberOptions As Integer = 4 ' Modify based on how many options available

    Private Sub clickButton(sender As Object, e As EventArgs) Handles btnPlay.Click, btnOptions.Click, btnHelp.Click, btnTutorial.Click
        Select Case sender.Name
            Case "btnPlay"
                selected = 0
            Case "btnOptions"
                selected = 1
            Case "btnTutorial"
                selected = 2
            Case "btnHelp"
                selected = 3
        End Select
        selectHelper()
    End Sub

    Private Sub mouseDownButton(sender As Object, e As EventArgs) Handles btnPlay.MouseDown, btnOptions.MouseDown, btnHelp.MouseDown
        Select Case sender.Name
            Case "btnPlay"
                btnPlay.BackgroundImage = My.Resources.btnPlayClicked
            Case "btnOptions"
                btnOptions.BackgroundImage = My.Resources.btnOptionsClicked
            Case "btnTutorial"
                btnTutorial.BackgroundImage = My.Resources.btnTutorialClicked
            Case "btnHelp"
                btnHelp.BackgroundImage = My.Resources.btnHelpClicked
        End Select
    End Sub

    Private Sub mouseHoverButton(sender As Object, e As EventArgs) Handles btnPlay.MouseHover, btnOptions.MouseHover, btnHelp.MouseHover
        Select Case sender.Name
            Case "btnPlay"
                If Not selected = 0 Then btnPlay.BackgroundImage = My.Resources.btnPlayHover
            Case "btnOptions"
                If Not selected = 1 Then btnOptions.BackgroundImage = My.Resources.btnOptionsHover
            Case "btnTutorial"
                If Not selected = 2 Then btnTutorial.BackgroundImage = My.Resources.btnTutorialHover
            Case "btnHelp"
                If Not selected = 3 Then btnHelp.BackgroundImage = My.Resources.btnHelpHover
        End Select
    End Sub

    Private Sub mouseLeaveButton(sender As Object, e As EventArgs) Handles btnPlay.MouseLeave, btnOptions.MouseLeave, btnHelp.MouseLeave
        Select Case sender.Name
            Case "btnPlay"
                If Not selected = 0 Then btnPlay.BackgroundImage = My.Resources.btnPlayUnclicked
            Case "btnOptions"
                If Not selected = 1 Then btnOptions.BackgroundImage = My.Resources.btnOptionsUnclicked
            Case "btnTutorial"
                If Not selected = 2 Then btnTutorial.BackgroundImage = My.Resources.btnTutorialUnclicked
            Case "btnHelp"
                If Not selected = 3 Then btnHelp.BackgroundImage = My.Resources.btnHelpUnclicked
        End Select
    End Sub

    Private Sub mainShift_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then selectHelper()
        If e.KeyCode = Keys.Down Then If selected < numberOptions - 1 Then selected += 1 Else selected = 0 ' Wrap around using down arrow
        If e.KeyCode = Keys.Up Then If selected > 0 Then selected -= 1 Else selected = numberOptions - 1 ' Wrap around using up arrow
        hoverHelper()
    End Sub

    Private Sub hoverHelper()
        ' Reset images to unclicked state
        btnPlay.BackgroundImage = My.Resources.btnPlayUnclicked
        btnOptions.BackgroundImage = My.Resources.btnOptionsUnclicked
        btnTutorial.BackgroundImage = My.Resources.btnTutorialUnclicked
        btnHelp.BackgroundImage = My.Resources.btnHelpUnclicked

        Select Case selected
            Case 0 ' Play
                btnPlay.BackgroundImage = My.Resources.btnPlayHover
            Case 1 ' Options
                btnOptions.BackgroundImage = My.Resources.btnOptionsHover
            Case 2 ' Tutorial
                btnTutorial.BackgroundImage = My.Resources.btnTutorialHover
            Case 3 ' Help
                btnHelp.BackgroundImage = My.Resources.btnHelpHover
        End Select
    End Sub

    Private Sub selectHelper()
        Me.Hide()
        Select Case selected
            Case 0 ' Play
                gameShift.Show()
                Stage.newGame(False)
            Case 1 ' Options
                optionsShift.Show()
            Case 2 ' Tutorial
                gameShift.Show()
                Stage.newGame(True)
            Case 3 ' Help
                helpShift.Show()
        End Select
    End Sub
End Class
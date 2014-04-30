''' <summary>
''' 
''' </summary>
''' <remarks></remarks>

Public Class gameRewind
    Dim projectiles As New ArrayList
    Dim rewindLimit As Single ' Max = 5 seconds = 500 milliseconds
    Dim playerY As Single
    Dim health As Integer = 5000
    Dim shieldStatus As Integer = 0
    Dim finishJump As Boolean = False
    Dim genVar As Single
    Dim paused As Boolean = False
    Dim score As Integer = 0
    Dim playerSpeed As Integer = 4

    Public Declare Function GetAsyncKeyState Lib "user32.dll" (ByVal vKey As Int32) As UShort ' Asynchronously detect key presses

    Private Sub pause()
        ' playerY = 0 'uncomment for endless jumping
        picPausedText.Visible = True
        lblPaused.Text = paused
        timerMove.Enabled = False
        timerCharge.Enabled = False
        timerGenerate.Enabled = False
        timerWorld.Enabled = False
        'timerConstant.Enabled = False
    End Sub

    Private Sub resumeGame()
        picPausedText.Visible = False
        timerCharge.Enabled = False
        timerMove.Enabled = True
        timerGenerate.Enabled = True
        timerWorld.Enabled = True
        timerConstant.Enabled = True
        timerShield.Start()
    End Sub

    Private Sub endGame()
        pause()
        timerShield.Stop()
        timerConstant.Stop()
        picPausedText.Visible = False
        endScreen.lblScore.Text = "Score: " + score.ToString
        endScreen.Show()
    End Sub

    Private Sub executeCharge()
        resumeGame()
        playerSpeed = 8

        picCharge.BackgroundImage = My.Resources.chargeBar0 ' Reset picCharge
    End Sub

    Private Sub timerConstant_Tick(sender As Object, e As EventArgs) Handles timerConstant.Tick ' Detect key presses
        If rewindLimit = 0 Then playerSpeed = 4 Else rewindLimit -= 1

        ' Debugging
        lblPosX.Text = picPlayer.Left
        lblPosY.Text = picPlayer.Top
        lblProjectiles.Text = "Projectiles: " + (projectiles.Count).ToString
        lblHealth.Text = health
        lblMovement.Text = timerMove.Tag
        lblRewindLimit.Text = rewindLimit
        lblShootVar.Text = (picPlayer.Left / 100) + 4
        lblGenVar.Text = genVar
        lblPaused.Text = paused
        lblShieldStatus.Text = shieldStatus

        ' Scoring
        lblScore.Text = score

        If picPlayer.BackColor = Color.DodgerBlue Then lblShieldOn.Text = "Off" Else lblShieldOn.Text = "On"

        ' Key detection
        Dim arrowLeft = GetAsyncKeyState(Convert.ToInt32(Keys.Left))
        Dim arrowRight = GetAsyncKeyState(Convert.ToInt32(Keys.Right))
        Dim arrowUp = GetAsyncKeyState(Convert.ToInt32(Keys.Up))

        If arrowLeft Or arrowRight Or arrowUp Then ' Movement
            timerMove.Tag = timerMove.Tag.Replace("idle", "")
            If arrowLeft And Not timerMove.Tag.Contains("left") Then
                timerMove.Tag += "left"
                If timerMove.Tag.Contains("right") Then timerMove.Tag = timerMove.Tag.Replace("right", "")
            End If

            If arrowRight And Not timerMove.Tag.Contains("right") Then
                timerMove.Tag += "right"
                If timerMove.Tag.Contains("left") Then timerMove.Tag = timerMove.Tag.Replace("left", "")
            End If

            If arrowUp And Not timerMove.Tag.Contains("jump") Then timerMove.Tag += "jump"
        End If

        If GetAsyncKeyState(Convert.ToInt32(Keys.Oemtilde)) Then debugBox.Visible = Not debugBox.Visible ' Toggle debug box
    End Sub

    Private Sub gameRewind_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case Microsoft.VisualBasic.ChrW(Keys.Escape) ' Pause game
                paused = Not paused
                If paused = True Then
                    pause()
                    timerShield.Stop()
                Else
                    resumeGame()
                End If
            Case Microsoft.VisualBasic.ChrW(Keys.Space)
                pause()
                picPausedText.Visible = False
                timerCharge.Enabled = True
        End Select
    End Sub

    Private Sub gameRewind_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Space Then
            executeCharge()
        ElseIf (e.KeyCode = Keys.Left Or e.KeyCode = Keys.Right) Then
            If Not timerMove.Tag.Contains("jump") Then timerMove.Tag = "idle" Else finishJump = True
        End If
    End Sub

    Private Sub timerWorld_Tick(sender As Object, e As EventArgs) Handles timerWorld.Tick ' old: timerShoot
        If health > 0 Then health -= 20
        If health > 0 Then score += 100
        picHealth.BackgroundImage = My.Resources.ResourceManager.GetObject("healthbar" + Math.Ceiling(health / 250).ToString)
        If health = 0 Then
            endGame()
            Exit Sub
        End If
        Try ' Projectile shooting
            For i = 0 To projectiles.Count - 1
                If i = projectiles.Count - 1 Then timerGenerate.Enabled = True
                If projectiles(i).Absorb = True Then projectiles(i).Visible = False ' Hide projectiles if they've been absorbed
                projectiles(i).Shoot((picPlayer.Left / 100) + 4)
                If projectiles(i).Left < -500 Then ' Remove from form and arraylist
                    projectiles.Remove(projectiles(i))
                    Me.Controls.Remove(projectiles(i))
                End If

                If projectiles(i).Bounds.IntersectsWith(picPlayer.Bounds) Then
                    If picPlayer.BackColor = Color.Green Then ' Shield on
                        'If Not timerMove.Tag.Contains("jump") Then timerMove.Tag += "jump" ' DO SOMETHING
                        If health + 100 > 5000 Then health = 5000 Else health = health + 100 ' Upper cap
                        projectiles(i).Absorb = True
                    ElseIf picPlayer.BackColor = Color.DodgerBlue Then ' Shield off, take damage
                        If health - 25 < 0 Then health = 0 Else health = health - 20 ' Lower cap
                    End If
                End If
            Next
        Catch ex As Exception
            ' None
        End Try
    End Sub

    Private Sub timerGenerate_Tick(sender As Object, e As EventArgs) Handles timerGenerate.Tick
        ' Generate new projectiles with a random interval
        Dim newProjectile As New Projectile
        Controls.Add(newProjectile)
        projectiles.Add(newProjectile)

        genVar = 800 - picPlayer.Left
        timerGenerate.Interval = genVar
    End Sub

    Private Sub timerCharge_Tick(sender As Object, e As EventArgs) Handles timerCharge.Tick
        If rewindLimit < 250 Then rewindLimit += 5 Else executeCharge() 'Auto-execute power when rewindLimit = 50
        picCharge.BackgroundImage = My.Resources.ResourceManager.GetObject("chargeBar" + Math.Ceiling(rewindLimit / 25).ToString)
    End Sub

    Private Sub timerShield_Tick(sender As Object, e As EventArgs) Handles timerShield.Tick
        ' Blue = shield on, green = shield off
        If shieldStatus < 100 Then
            shieldStatus += 1
        Else
            shieldStatus = 0
            If picPlayer.BackColor = Color.DodgerBlue Then picPlayer.BackColor = Color.Green Else picPlayer.BackColor = Color.DodgerBlue
        End If
    End Sub

    Private Sub timerMove_Tick(sender As Object, e As EventArgs) Handles timerMove.Tick
        If timerMove.Tag.Contains("left") And Not timerMove.Tag.Contains("right") And picPlayer.Left > 0 Then picPlayer.Left -= playerSpeed
        If timerMove.Tag.Contains("right") And Not timerMove.Tag.Contains("left") And picPlayer.Left < Me.Width - 65 Then picPlayer.Left += playerSpeed

        If timerMove.Tag.Contains("jump") Then
            If picPlayer.Bottom + -14.5 + (playerY ^ (1 + (1 / 10000))) > picWorld.Top Then ' Finished jump
                picPlayer.Top = picWorld.Top - picPlayer.Height
                playerY = 0
                timerMove.Tag = timerMove.Tag.Replace("jump", "")
                If finishJump = True Then
                    timerMove.Tag = timerMove.Tag.Replace("left", "")
                    timerMove.Tag = timerMove.Tag.Replace("right", "")
                    finishJump = False
                End If
            ElseIf picPlayer.Bottom <= picWorld.Top Then
                picPlayer.Top += -14.5 + (playerY ^ (1 + (1 / 10000))) ' Credits to Devid She
                playerY += 1
            End If
        End If
    End Sub
End Class
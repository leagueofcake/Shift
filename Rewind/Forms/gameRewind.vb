''' <summary>
''' SDD major project: Rewind, a sidescroller game built in VB.NET
''' </summary>
''' <remarks></remarks>

Public Class gameRewind
    Dim projectiles As New ArrayList
    Dim playerY As Integer
    Dim finishJump As Boolean = False

    Public Declare Function GetAsyncKeyState Lib "user32.dll" (ByVal vKey As Int32) As UShort ' Asynchronously detect key presses

    Private Sub togglePause()
        picPausedText.Visible = Not picPausedText.Visible
        timerMove.Enabled = Not timerMove.Enabled
        timerCharge.Enabled = False
        timerGenerate.Enabled = Not timerGenerate.Enabled
        timerWorld.Enabled = Not timerWorld.Enabled
        'timerConstant.Enabled = False
        ' playerY = 0 'uncomment for endless jumpings
    End Sub

    Private Sub endGame()
        togglePause()
        timerShield.Stop()
        timerConstant.Stop()
        picPausedText.Visible = False
        endScreen.lblScore.Text = "Score: " + gameVar.score.ToString
        endScreen.Show()
    End Sub

    Private Sub executeCharge()
        togglePause()
        picPausedText.Visible = False
        timerMove.Enabled = True
        timerGenerate.Enabled = True
        timerWorld.Enabled = True
        playerVar.playerSpeed = 8
    End Sub

    Private Sub updateFormLabels()
        lblPosX.Text = picPlayer.Left
        lblPosY.Text = picPlayer.Top
        lblProjectiles.Text = projectiles.Count
        lblHealth.Text = playerVar.playerHealth
        lblMovement.Text = timerMove.Tag
        lblChargeLimit.Text = gameVar.chargeLimit
        lblShootVar.Text = (picPlayer.Left / 100) + 4
        lblGenVar.Text = gameVar.genVar
        lblPaused.Text = gameVar.paused
        lblShieldStatus.Text = playerVar.shieldStatus
        lblProgression.Text = gameVar.progression
        lblHpDrain.Text = gameVar.healthDrain

        lblScore.Text = gameVar.score
    End Sub

    Private Sub countDownShift()
        If Not gameVar.progression = 0 Then
            If gameVar.progression Mod 100 = 0 Then lblShiftTimer.Text = "Next Shift in " + (15 - ((gameVar.progression / 100) Mod 15)).ToString + " seconds"
            If gameVar.progression Mod 1500 = 0 And gameVar.progression Then Shift() ' Every 15 seconds, shift game variables

        End If
    End Sub

    Private Sub Shift()

    End Sub

    Private Sub timerConstant_Tick(sender As Object, e As EventArgs) Handles timerConstant.Tick ' Detect key presses
        updateFormLabels()
        countDownShift()

        If picPlayer.BackColor = Color.DodgerBlue Then lblShieldOn.Text = "Off" Else lblShieldOn.Text = "On"

        ' Key detection
        Dim arrowLeft = GetAsyncKeyState(CInt(Keys.Left))
        Dim arrowRight = GetAsyncKeyState(CInt(Keys.Right))
        Dim arrowUp = GetAsyncKeyState(CInt(Keys.Up))

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

        If GetAsyncKeyState(CInt(Keys.Oemtilde)) Then debugBox.Visible = Not debugBox.Visible ' Toggle debug box
    End Sub

    Private Sub gameRewind_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case Microsoft.VisualBasic.ChrW(Keys.Escape) ' Pause game
                gameVar.paused = Not gameVar.paused
                togglePause()
                If gameVar.paused = True Then
                    timerShield.Stop()
                Else
                    timerShield.Start()
                End If
            Case Microsoft.VisualBasic.ChrW(Keys.Space)
                If gameVar.paused = False Then
                    togglePause()
                    picPausedText.Visible = False
                    timerCharge.Enabled = True
                End If
        End Select
    End Sub

    Private Sub gameRewind_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Space And gameVar.paused = False Then
            executeCharge()
        ElseIf (e.KeyCode = Keys.Left Or e.KeyCode = Keys.Right) Then
            If Not timerMove.Tag.Contains("jump") Then timerMove.Tag = "idle" Else finishJump = True
        End If
    End Sub

    Private Sub timerWorld_Tick(sender As Object, e As EventArgs) Handles timerWorld.Tick
        picCharge.BackgroundImage = My.Resources.ResourceManager.GetObject("chargeBar" + Math.Ceiling(gameVar.chargeLimit / 50).ToString) ' EXPERIMENTAL
        If gameVar.chargeLimit = 0 Then playerVar.playerSpeed = 4 Else gameVar.chargeLimit -= 1 ' Use up power
        gameVar.progression += 1

        If playerVar.playerHealth > 0 Then playerVar.playerHealth -= gameVar.healthDrain
        If playerVar.playerHealth > 0 Then gameVar.score += 100
        picHealth.BackgroundImage = My.Resources.ResourceManager.GetObject("healthbar" + Math.Ceiling(playerVar.playerHealth / 250).ToString)
        If playerVar.playerHealth = 0 Then
            endGame()
            Exit Sub
        End If
        Try ' Projectile shooting
            For i = 0 To projectiles.Count - 1
                If i = projectiles.Count - 1 Then timerGenerate.Enabled = True
                'projectiles(i).Shoot((picPlayer.Left / 100) + gameVar.projectileSpeed) ' shoot speed depends on player's position
                projectiles(i).Shoot(gameVar.projectileSpeed)
                If projectiles(i).Left < -500 Then ' Remove from form and arraylist
                    projectiles.Remove(projectiles(i))
                    Me.Controls.Remove(projectiles(i))
                    Exit For
                End If

                If projectiles(i).Bounds.IntersectsWith(picPlayer.Bounds) Then
                    If picPlayer.BackColor = Color.Green Then ' Shield on
                        projectiles(i).Visible = False
                        If playerVar.playerHealth + gameVar.healthGain > playerVar.healthMax Then playerVar.playerHealth = playerVar.healthMax Else playerVar.playerHealth = playerVar.playerHealth + gameVar.healthGain ' Upper cap
                    ElseIf picPlayer.BackColor = Color.DodgerBlue Then ' Shield off, take damage
                        If playerVar.playerHealth - 25 < 0 Then playerVar.playerHealth = 0 Else playerVar.playerHealth = playerVar.playerHealth - 20 ' Lower cap
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

        'gameVar.genVar = 800 - picPlayer.Left ' genVar dependent on player's position
        gameVar.genVar = (Rnd() * 5 + 1) * 100
        timerGenerate.Interval = gameVar.genVar
    End Sub

    Private Sub timerCharge_Tick(sender As Object, e As EventArgs) Handles timerCharge.Tick
        If gameVar.chargeLimit + 10 < 500 Then
            gameVar.chargeLimit += 10
        ElseIf gameVar.chargeLimit + 10 > 500 And gameVar.chargeLimit + 1 <= 500 Then
            gameVar.chargeLimit += 1
        Else
            executeCharge() 'Auto-execute power when chargeLimit = 50
        End If

        picCharge.BackgroundImage = My.Resources.ResourceManager.GetObject("chargeBar" + Math.Ceiling(gameVar.chargeLimit / 50).ToString)
    End Sub

    Private Sub timerShield_Tick(sender As Object, e As EventArgs) Handles timerShield.Tick
        ' Blue = shield on, green = shield off
        If playerVar.shieldStatus < playerVar.shieldMax Then
            playerVar.shieldStatus += 1
        Else
            playerVar.shieldStatus = 0
            If picPlayer.BackColor = Color.DodgerBlue Then picPlayer.BackColor = Color.Green Else picPlayer.BackColor = Color.DodgerBlue
        End If
    End Sub

    Private Sub timerMove_Tick(sender As Object, e As EventArgs) Handles timerMove.Tick
        If timerMove.Tag.Contains("left") And Not timerMove.Tag.Contains("right") And picPlayer.Left > 0 Then picPlayer.Left -= playerVar.playerSpeed
        If timerMove.Tag.Contains("right") And Not timerMove.Tag.Contains("left") And picPlayer.Left < Me.Width - 65 Then picPlayer.Left += playerVar.playerSpeed

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

    Private Sub gameRewind_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Reset values on game load
        playerVar.playerHealth = 5000
        playerVar.playerSpeed = 4
        playerVar.shieldStatus = 0
        gameVar.score = 0
    End Sub
End Class
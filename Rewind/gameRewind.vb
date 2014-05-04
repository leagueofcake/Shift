﻿''' <summary>
''' SDD major project: Rewind, a sidescroller game built in VB.NET
''' </summary>
''' <remarks></remarks>

Public Class gameRewind
    Dim projectiles As New ArrayList
    Dim chargeLimit As Single ' Max = 5 seconds = 500 milliseconds
    Dim playerY As Single
    Dim finishJump As Boolean = False
    Dim genVar As Single
    Dim paused As Boolean = False

    ' Difficulty shifting
    Dim progression As Integer = 0 ' Essentially how long player has lasted in game
    Dim healthDrain As Integer = 20

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
        endScreen.lblScore.Text = "Score: " + gameVar.score.ToString
        endScreen.Show()
    End Sub

    Private Sub executeCharge()
        resumeGame()
        playerVar.playerSpeed = 8

        picCharge.BackgroundImage = My.Resources.chargeBar0 ' Reset picCharge
    End Sub

    Private Sub timerConstant_Tick(sender As Object, e As EventArgs) Handles timerConstant.Tick ' Detect key presses
        ' Debugging
        lblPosX.Text = picPlayer.Left
        lblPosY.Text = picPlayer.Top
        lblProjectiles.Text = "Projectiles: " + (projectiles.Count).ToString
        lblHealth.Text = playerVar.playerHealth
        lblMovement.Text = timerMove.Tag
        lblchargeLimit.Text = chargeLimit
        lblShootVar.Text = (picPlayer.Left / 100) + 4
        lblGenVar.Text = genVar
        lblPaused.Text = paused
        lblShieldStatus.Text = playerVar.shieldStatus
        lblProgression.Text = progression

        ' Scoring
        lblScore.Text = gameVar.score

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
                If paused = False Then
                    pause()
                    picPausedText.Visible = False
                    timerCharge.Enabled = True
                End If
        End Select
    End Sub

    Private Sub gameRewind_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Space And paused = False Then
            executeCharge()
        ElseIf (e.KeyCode = Keys.Left Or e.KeyCode = Keys.Right) Then
            If Not timerMove.Tag.Contains("jump") Then timerMove.Tag = "idle" Else finishJump = True
        End If
    End Sub

    Private Sub timerWorld_Tick(sender As Object, e As EventArgs) Handles timerWorld.Tick ' old: timerShoot
        If chargeLimit = 0 Then playerVar.playerSpeed = 4 Else chargeLimit -= 1 ' Use up power
        progression += 1

        If playerVar.playerHealth > 0 Then playerVar.playerHealth -= healthDrain
        If playerVar.playerHealth > 0 Then gameVar.score += 100
        picHealth.BackgroundImage = My.Resources.ResourceManager.GetObject("healthbar" + Math.Ceiling(playerVar.playerHealth / 250).ToString)
        If playerVar.playerHealth = 0 Then
            endGame()
            Exit Sub
        End If
        Try ' Projectile shooting
            For i = 0 To projectiles.Count - 1
                If i = projectiles.Count - 1 Then timerGenerate.Enabled = True
                projectiles(i).Shoot((picPlayer.Left / 100) + 4)
                If projectiles(i).Left < -500 Then ' Remove from form and arraylist
                    projectiles.Remove(projectiles(i))
                    Me.Controls.Remove(projectiles(i))
                End If

                If projectiles(i).Bounds.IntersectsWith(picPlayer.Bounds) Then
                    If picPlayer.BackColor = Color.Green Then ' Shield on
                        projectiles(i).Visible = False
                        If playerVar.playerHealth + 100 > 5000 Then playerVar.playerHealth = 5000 Else playerVar.playerHealth = playerVar.playerHealth + 100 ' Upper cap
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

        genVar = 800 - picPlayer.Left ' genVar dependent on player's position
        timerGenerate.Interval = genVar
    End Sub

    Private Sub timerCharge_Tick(sender As Object, e As EventArgs) Handles timerCharge.Tick
        If chargeLimit + 10 < 500 Then
            chargeLimit += 10
        ElseIf chargeLimit + 10 > 500 And chargeLimit + 1 <= 500 Then
            chargeLimit += 1
        Else
            executeCharge() 'Auto-execute power when chargeLimit = 50
        End If

        picCharge.BackgroundImage = My.Resources.ResourceManager.GetObject("chargeBar" + Math.Ceiling(chargeLimit / 50).ToString)
    End Sub

    Private Sub timerShield_Tick(sender As Object, e As EventArgs) Handles timerShield.Tick
        ' Blue = shield on, green = shield off
        If playerVar.shieldStatus < 100 Then
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
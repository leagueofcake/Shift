''' <summary>
''' Program Name: Shift
''' Author: Dominic Fung
''' Date first written: 13/3/2014
''' 
''' Purpose: A sidescroller game written in VB.Net
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
        timerGenerate.Enabled = Not timerGenerate.Enabled
        timerWorld.Enabled = Not timerWorld.Enabled
        'timerConstant.Enabled = False
        ' playerY = 0 'uncomment for endless jumpings
    End Sub

    Private Sub endGame()
        togglePause()
        endScreen.lblScore.Text = "Score: " + Stage.score.ToString
        endScreen.Show()
    End Sub

    Private Sub updateFormLabels()
        lblPosX.Text = picPlayer.Left
        lblPosY.Text = picPlayer.Top
        lblProjectiles.Text = projectiles.Count
        lblHealth.Text = Stage.playerHealth
        lblMovement.Text = timerMove.Tag
        lblCharge.Text = Stage.charge
        lblShootVar.Text = (picPlayer.Left / 100) + 4
        lblGenVar.Text = Stage.genVar
        lblPaused.Text = Stage.paused
        lblShieldStatus.Text = Stage.shieldStatus
        lblProgression.Text = Stage.progression
        lblHpDrain.Text = Stage.healthDrain
        lblStage.Text = Stage.currentStage
        lblScore.Text = Stage.score
    End Sub

    Private Sub countDownShift()
        If Not Stage.progression = 0 Then
            If Stage.progression Mod 100 = 0 Then lblShiftTimer.Text = "Next Shift in " + (10 - ((Stage.progression / 100) Mod 10)).ToString + " seconds"
            If Stage.progression Mod 1000 = 0 Then Stage.selectStage() ' Every 10 seconds, shift game variables
        End If
    End Sub

    Private Sub timerConstant_Tick(sender As Object, e As EventArgs) Handles timerConstant.Tick ' Detect key presses
        updateFormLabels()
        countDownShift()

        picHealth.BackgroundImage = My.Resources.ResourceManager.GetObject("healthbar" + Math.Ceiling(Stage.playerHealth / (Stage.healthMax / 20)).ToString)

        projectileShootCollision()

        picCharge.BackgroundImage = My.Resources.ResourceManager.GetObject("chargeBar" + Math.Ceiling(Stage.charge / (Stage.chargeMax / 10)).ToString) ' EXPERIMENTAL

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
                Stage.paused = Not Stage.paused
                togglePause()
                If Stage.paused = True Then timerShield.Stop() Else timerShield.Start()
            Case Microsoft.VisualBasic.ChrW(Keys.Space)
                If Stage.paused = False Then
                    timerPower.Enabled = True ' ACTIVATE POWERUP
                End If
        End Select
    End Sub

    Private Sub gameRewind_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Space And Stage.paused = False Then
            timerPower.Enabled = False
            Stage.applyStage(Stage.currentStage) ' DEACTIVATE POWERUP - RESET TO DEFAULT VALUES
        ElseIf (e.KeyCode = Keys.Left Or e.KeyCode = Keys.Right) Then
            If Not timerMove.Tag.Contains("jump") Then timerMove.Tag = "idle" Else finishJump = True
        End If
    End Sub

    Private Sub timerWorld_Tick(sender As Object, e As EventArgs) Handles timerWorld.Tick
        If Stage.charge = 0 Then Stage.playerSpeed = 4 'Else Stage.charge -= 1 ' Use up power
        Stage.progression += 1

        If Stage.playerHealth > 0 Then Stage.playerHealth -= Stage.healthDrain
        If Stage.playerHealth > 0 Then Stage.score += Stage.scoreMult
        If Stage.playerHealth = 0 Then
            endGame()
            Exit Sub
        End If
    End Sub

    Private Sub projectileShootCollision()
        For i = 0 To projectiles.Count - 1
            Try
                ' Projectile shooting
                If timerGenerate.Enabled = True Then
                    If Not projectiles(i).Bounds.IntersectsWith(picPlayer.Bounds) Then projectiles(i).hitCooldown = False
                    If i = projectiles.Count - 1 Then timerGenerate.Enabled = True
                    'projectiles(i).Shoot((picPlayer.Left / 100) + Stage.projectileSpeed) ' shoot speed depends on player's position
                    projectiles(i).Shoot(Stage.projectileSpeed)
                    If projectiles(i).Left < -500 Then ' Remove from form and arraylist
                        projectiles.Remove(projectiles(i))
                        Me.Controls.Remove(projectiles(i))
                        Exit Sub
                    End If
                End If

                ' Projectile collision
                If projectiles(i).Bounds.IntersectsWith(picPlayer.Bounds) Then
                    If picPlayer.BackColor = Color.Green Then ' Shield on, regen health + charge up powerup
                        If Stage.playerHealth + Stage.healthGain > Stage.healthMax Then Stage.playerHealth = Stage.healthMax Else Stage.playerHealth = Stage.playerHealth + Stage.healthGain ' Upper cap
                        If Stage.charge + Stage.chargeGain < Stage.chargeMax Then Stage.charge += Stage.chargeGain Else Stage.charge = Stage.chargeMax
                        projectiles(i).BackCOlor = Color.White
                        projectiles(i).Top = -50 ' EXPERIMENTAL Shift offscreen when projectile is hit
                        Exit Sub
                    ElseIf picPlayer.BackColor = Color.DodgerBlue And projectiles(i).hitCooldown = False Then ' Shield off, take damage
                        If Stage.playerHealth - Stage.healthLoss < 0 Then Stage.playerHealth = 0 Else Stage.playerHealth = Stage.playerHealth - Stage.healthLoss ' Lower cap
                        projectiles(i).hitCooldown = True
                        projectiles(i).BackColor = Color.Red
                        Exit Sub
                    End If
                End If
            Catch ex As Exception
                ' None
            End Try
        Next
    End Sub

    Private Sub timerGenerate_Tick(sender As Object, e As EventArgs) Handles timerGenerate.Tick
        ' Generate new projectiles with a random interval
        Dim newProjectile As New Projectile
        Controls.Add(newProjectile)
        projectiles.Add(newProjectile)

        'Stage.genVar = 800 - picPlayer.Left ' genVar dependent on player's position
        Stage.genVar = (Rnd() * 5 + 1) * 100
        timerGenerate.Interval = Stage.genVar
    End Sub

    Private Sub timerShield_Tick(sender As Object, e As EventArgs) Handles timerShield.Tick
        ' Blue = shield on, green = shield off
        If Stage.shieldStatus < Stage.shieldMax Then
            Stage.shieldStatus += 1
        Else
            Stage.shieldStatus = 0
            If picPlayer.BackColor = Color.DodgerBlue Then picPlayer.BackColor = Color.Green Else picPlayer.BackColor = Color.DodgerBlue
        End If
    End Sub

    Private Sub timerMove_Tick(sender As Object, e As EventArgs) Handles timerMove.Tick
        If timerMove.Tag.Contains("left") And Not timerMove.Tag.Contains("right") And picPlayer.Left > 0 Then picPlayer.Left -= Stage.playerSpeed
        If timerMove.Tag.Contains("right") And Not timerMove.Tag.Contains("left") And picPlayer.Left < Me.Width - 65 Then picPlayer.Left += Stage.playerSpeed

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
        Stage.newGame() ' Reset values on game load
    End Sub

    Private Sub timerPower_Tick(sender As Object, e As EventArgs) Handles timerPower.Tick
        Stage.applyPowerup(Stage.currentStage)
    End Sub
End Class
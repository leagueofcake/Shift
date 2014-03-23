''' <summary>
''' 
''' </summary>
''' <remarks></remarks>

Public Class gameRewind
    Dim shootTimer As Timer
    Dim projectiles As New ArrayList
    Dim rewindLimit As Single ' Max = 5 seconds = 500 milliseconds
    Dim playerY As Single
    Dim health As Integer = 5000
    Dim finishJump As Boolean = False

    Public Declare Function GetAsyncKeyState Lib "user32.dll" (ByVal vKey As Int32) As UShort

    Private Sub timerConstant_Tick(sender As Object, e As EventArgs) Handles timerConstant.Tick ' Detect key presses
        ' Debugging
        lblPosX.Text = picPlayer.Left
        lblPosY.Text = picPlayer.Top
        lblProjectiles.Text = "Projectiles: " + (projectiles.Count).ToString
        lblHealth.Text = health
        lblMovement.Text = timerMove.Tag
        lblRewindLimit.Text = rewindLimit
        If picPlayer.BackColor = Color.DodgerBlue Then lblShieldOn.Text = "Off" Else lblShieldOn.Text = "On"

        ' Key detection
        Dim arrowLeft = GetAsyncKeyState(Convert.ToInt32(Keys.Left))
        Dim arrowRight = GetAsyncKeyState(Convert.ToInt32(Keys.Right))
        Dim arrowUp = GetAsyncKeyState(Convert.ToInt32(Keys.Up))

        If GetAsyncKeyState(Convert.ToInt32(Keys.Space)) Then
            timerCharge.Enabled = True
            timerGenerate.Enabled = False
            timerWorld.Enabled = False
            timerShield.Stop()
        End If

        If arrowLeft Or GetAsyncKeyState(Convert.ToInt32(Keys.Right)) Or GetAsyncKeyState(Convert.ToInt32(Keys.Up)) Then ' Movement
            timerMove.Tag = timerMove.Tag.Replace("idle", "")
            If arrowLeft And Not timerMove.Tag.Contains("left") Then
                timerMove.Tag += "left"
                If timerMove.Tag.Contains("right") Then timerMove.Tag = timerMove.Tag.Replace("right", "")
            End If

            If GetAsyncKeyState(Convert.ToInt32(Keys.Right)) And Not timerMove.Tag.Contains("right") Then
                timerMove.Tag += "right"
                If timerMove.Tag.Contains("left") Then timerMove.Tag = timerMove.Tag.Replace("left", "")
            End If


            If GetAsyncKeyState(Convert.ToInt32(Keys.Up)) And Not timerMove.Tag.Contains("jump") Then timerMove.Tag += "jump"
        End If

        If GetAsyncKeyState(Convert.ToInt32(Keys.Oemtilde)) Then debugBox.Visible = Not debugBox.Visible ' Toggle debug box
    End Sub

    Private Sub gameRewind_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Space Then
            ' ### EXPERIMENTAL REWIND CODE ###
            For i = 0 To projectiles.Count - 1
                For x = 0 To rewindLimit
                    projectiles(i).Rewind()
                Next
            Next

            rewindLimit = 0
            chargeBar.Value = 0 ' Reset chargeBar
            timerGenerate.Enabled = True
            timerWorld.Enabled = True

            timerCharge.Enabled = False
            timerShield.Start()
        ElseIf (e.KeyCode = Keys.Left Or e.KeyCode = Keys.Right) Then
            If Not timerMove.Tag.Contains("jump") Then timerMove.Tag = "idle" Else finishJump = True
        End If
    End Sub

    Private Sub timerWorld_Tick(sender As Object, e As EventArgs) Handles timerWorld.Tick ' old: timerShoot
        If health > 0 Then health -= 5
        Try ' Projectile shooting
            For i = 0 To projectiles.Count - 1
                If i = projectiles.Count - 1 Then timerGenerate.Enabled = True
                If projectiles(i).Absorb = True Then projectiles(i).Visible = False ' Hide projectiles if they've been absorbed
                projectiles(i).Shoot()
                ' IF ABSORBED OR OFF SCREEN START ADDING LIFE
                If projectiles(i).Left < 0 Then projectiles(i).life += 10 ' Off screen, add to lifecount

                If projectiles(i).life = 500 Then ' 5 seconds is up, remove from form and arraylist
                    projectiles.Remove(projectiles(i))
                    Me.Controls.Remove(projectiles(i))
                End If

                If projectiles(i).Bounds.IntersectsWith(picPlayer.Bounds) Then
                    If picPlayer.BackColor = Color.Green Then ' Shield on - JUMP
                        If Not timerMove.Tag.Contains("jump") Then timerMove.Tag += "jump"
                        If health + 100 > 5000 Then health = 5000 Else health = health + 100 ' Upper cap
                        projectiles(i).Absorb = True
                    ElseIf picPlayer.BackColor = Color.DodgerBlue Then ' Shield off, take damage
                        If health - 25 < 0 Then health = 0 Else health = health - 25 ' Lower cap
                    End If
                End If
            Next
        Catch ex As Exception
            ' None
        End Try
        picHealth.BackgroundImage = My.Resources.ResourceManager.GetObject("healthbar" + Math.Ceiling(health / 250).ToString)
    End Sub

    Private Sub timerGenerate_Tick(sender As Object, e As EventArgs) Handles timerGenerate.Tick
        ' Generate new projectiles with a random interval
        Dim newProjectile As New Projectile
        Controls.Add(newProjectile)
        projectiles.Add(newProjectile)

        timerWorld.Enabled = True
        timerGenerate.Interval = (Rnd() * 5 + 10) * 100
    End Sub

    Private Sub timerCharge_Tick(sender As Object, e As EventArgs) Handles timerCharge.Tick
        If rewindLimit < 50 Then
            rewindLimit += 1
            chargeBar.Increment(1)
        End If
    End Sub

    Private Sub timerShield_Tick(sender As Object, e As EventArgs) Handles timerShield.Tick
        ' Blue = shield on, green = shield off
        If picPlayer.BackColor = Color.DodgerBlue Then picPlayer.BackColor = Color.Green Else picPlayer.BackColor = Color.DodgerBlue
    End Sub

    Private Sub timerMove_Tick(sender As Object, e As EventArgs) Handles timerMove.Tick
        If timerMove.Tag.Contains("left") And Not timerMove.Tag.Contains("right") And picPlayer.Left > 0 Then picPlayer.Left -= 3
        If timerMove.Tag.Contains("right") And Not timerMove.Tag.Contains("left") And picPlayer.Left < Me.Width - 65 Then picPlayer.Left += 3

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
''' <summary>
''' Rewind
''' - Core concept: Endless sidescroller with rewinding of time
''' - Holding Spacebar: Charging rewinder
''' - Releasing Spacebar: Activating rewinder based on amount of time charged - projectiles will move back 
''' to where they were X seconds ago
''' - Must dodge all the bullets
'''
''' TODO
''' - Cooler VFX!
''' 
''' </summary>
''' <remarks></remarks>

Public Class gameRewind
    Dim shootTimer As Timer
    Dim projectiles As New ArrayList
    Dim count As Integer
    Dim rewindLimit As Single ' Max = 5 seconds = 500 milliseconds
    Dim playerY As Single
    Dim finishJump As Boolean = False

    Private Sub gameRewind_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timerMove.Tag = "idle"
    End Sub

    Private Sub gameRewind_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Space Then
            timerCharge.Enabled = True
            timerGenerate.Enabled = False
            timerWorld.Enabled = False
            timerShield.Enabled = False
        ElseIf e.KeyCode = Keys.Left And Not timerMove.Tag.Contains("left") Then
            timerMove.Tag += "left"
        ElseIf e.KeyCode = Keys.Right And Not timerMove.Tag.Contains("right") Then
            timerMove.Tag += "right"
        ElseIf e.KeyCode = Keys.Up And Not timerMove.Tag.Contains("jump") Then
            timerMove.Tag += "jump"
        ElseIf e.KeyCode = Keys.Oemtilde Then ' Toggle debug box
            If debugBox.Visible = True Then
                debugBox.Visible = False
            Else
                debugBox.Visible = True
            End If

        End If
    End Sub

    Private Sub gameRewind_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Space Then
            chargeBar.Value = 0 ' Reset chargeBar
            timerGenerate.Enabled = True
            timerWorld.Enabled = True

            timerCharge.Enabled = False
            timerRewind.Enabled = True
            timerShield.Enabled = True
        ElseIf (e.KeyCode = Keys.Left Or e.KeyCode = Keys.Right) Then
            If Not timerMove.Tag.Contains("jump") Then
                timerMove.Tag = "idle"
            Else
                finishJump = True
            End If
        End If
    End Sub

    Private Sub timerWorld_Tick(sender As Object, e As EventArgs) Handles timerWorld.Tick ' old: timerShoot
        If healthBar.Value > 0 Then healthBar.Value -= 1
        lblProjectiles.Text = "Projectiles: " + (projectiles.Count).ToString
        Try ' Projectile shooting
            For i = 0 To projectiles.Count - 1
                If i = projectiles.Count - 1 Then
                    timerGenerate.Enabled = True
                End If
                If projectiles(i).Absorb = True Then ' Hide projectiles if they've been absorbed
                    projectiles(i).Visible = False
                End If
                projectiles(i).Shoot()
                ' IF ABSORBED OR OFF SCREEN START ADDING LIFE
                If projectiles(i).Left < 0 Then ' Off screen, add to lifecount
                    projectiles(i).life += 10
                End If

                If projectiles(i).life = 500 Then ' 5 seconds is up, remove from form and arraylist
                    ' timerGenerate.Enabled = False DEBUG ONLY
                    ' MsgBox(projectiles(i).lifecount)
                    projectiles.Remove(projectiles(i))
                    Me.Controls.Remove(projectiles(i))
                End If

                If projectiles(i).Bounds.IntersectsWith(picPlayer.Bounds) Then
                    If picPlayer.BackColor = Color.Green Then ' Shield on - JUMP
                        If Not timerMove.Tag.Contains("jump") Then timerMove.Tag += "jump"
                        healthBar.Value += 10
                        'MsgBox("ABSORBED")
                        'projectiles(i).Absorb = True
                    ElseIf picPlayer.BackColor = Color.DodgerBlue Then ' Shield off
                        'timerWorld.Enabled = False
                        'timerCharge.Enabled = False
                        'timerGenerate.Enabled = False
                        'timerRewind.Enabled = False
                        'timerShield.Enabled = False
                        'MsgBox("You lose.")
                        'Exit For
                    End If
                End If
            Next
        Catch ex As Exception
            '''' NOTHING ''''
        End Try
    End Sub

    Private Sub timerGenerate_Tick(sender As Object, e As EventArgs) Handles timerGenerate.Tick
        ' Generate new projectiles with a random interval
        'ReDim Preserve projectiles(count) ' Redefine then extend array length
        Dim newProjectile As New Projectile
        Controls.Add(newProjectile)
        projectiles.Add(newProjectile)
        count += 1

        timerWorld.Enabled = True
        timerGenerate.Interval = (Rnd() * 5 + 10) * 100
    End Sub

    Private Sub timerCharge_Tick(sender As Object, e As EventArgs) Handles timerCharge.Tick
        If rewindLimit < 300 Then
            rewindLimit += 10
            chargeBar.Increment(10)
        End If
    End Sub

    Private Sub timerRewind_Tick(sender As Object, e As EventArgs) Handles timerRewind.Tick
        timerGenerate.Enabled = False
        If rewindLimit > 0 Then
            For i = 0 To projectiles.Count - 1
                If projectiles(i).Absorb = True And projectiles(i).Left > picPlayer.Right Then
                    projectiles(i).Visible = True
                    projectiles(i).Absorb = False
                End If
                projectiles(i).Rewind()
                projectiles(i).life -= 10
            Next
            rewindLimit -= 20
        Else
            timerRewind.Enabled = False
        End If
    End Sub

    Private Sub timerShield_Tick(sender As Object, e As EventArgs) Handles timerShield.Tick
        ' Blue = shield on, green = shield off
        If picPlayer.BackColor = Color.DodgerBlue Then
            picPlayer.BackColor = Color.Green ' Off
        Else
            picPlayer.BackColor = Color.DodgerBlue ' On
        End If
    End Sub

    Private Sub timerMove_Tick(sender As Object, e As EventArgs) Handles timerMove.Tick
        lblMove.Text = timerMove.Tag
        If timerMove.Tag = "idle" Then
            'None
        ElseIf timerMove.Tag.Contains("left") And picPlayer.Left > 0 Then
            picPlayer.Left -= 3
        ElseIf timerMove.Tag.Contains("right") And picPlayer.Left < Me.Width - 50 Then
            picPlayer.Left += 3
        End If

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
                lblDebug.Text = -5 + (playerY ^ (6 / 5)) ' DEBUGGING
                playerY += 1
            End If
        End If
    End Sub
End Class
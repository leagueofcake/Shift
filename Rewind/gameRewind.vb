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

    Private Sub gameRewind_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Space
                timerCharge.Enabled = True
                timerGenerate.Enabled = False
                timerWorld.Enabled = False
                timerShield.Enabled = False
                'Case Keys.Up ' ##### DEBUGGING ######
                '    timerJump.Enabled = True
        End Select
    End Sub

    Private Sub gameRewind_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.Space
                chargeBar.Value = 0 ' Reset chargeBar
                timerGenerate.Enabled = True
                timerWorld.Enabled = True

                timerCharge.Enabled = False
                timerRewind.Enabled = True
                timerShield.Enabled = True
        End Select
    End Sub

    Private Sub timerWorld_Tick(sender As Object, e As EventArgs) Handles timerWorld.Tick ' old: timerShoot
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
                        timerJump.Enabled = True
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
        If rewindLimit < 500 Then
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
            rewindLimit -= 5
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

    Private Sub timerJump_Tick(sender As Object, e As EventArgs) Handles timerJump.Tick
        If picPlayer.Bottom + -14.5 + (playerY ^ (1 + (1 / 10000))) > picWorld.Top Then
            picPlayer.Top = picWorld.Top - picPlayer.Height
            playerY = 0
            timerJump.Enabled = False ' Comment for endless jump
        ElseIf picPlayer.Bottom <= picWorld.Top Then
            picPlayer.Top += -14.5 + (playerY ^ (1 + (1 / 10000))) ' Credits to Devid She
            lblDebug.Text = -5 + (playerY ^ (6 / 5)) ' DEBUGGING
            playerY += 1
        End If
    End Sub
End Class
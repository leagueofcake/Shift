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

Public Class Form1
    Dim shootTimer As Timer
    Dim projectiles(-1) As Projectile
    Dim count As Integer
    Dim rewindLimit As Single ' Max = 5 seconds = 500 milliseconds

    Private Sub Form1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Space
                ' ######### TODO CHARGING, COOLDOWN #########
                timerCharge.Start()
                timerGenerate.Enabled = False
                timerShoot.Enabled = False
        End Select
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.Space
                timerCharge.Stop()
                timerRewind.Enabled = True
        End Select
    End Sub

    Private Sub timerWorld_Tick(sender As Object, e As EventArgs) Handles timerShoot.Tick
        For i = 0 To projectiles.Count - 1
            projectiles(i).Shoot()
        Next
    End Sub

    Private Sub timerGenerate_Tick(sender As Object, e As EventArgs) Handles timerGenerate.Tick
        ReDim Preserve projectiles(count)
        Dim newProjectile As New Projectile
        Controls.Add(newProjectile)
        projectiles(count) = newProjectile
        count += 1
        timerShoot.Enabled = True

        timerGenerate.Interval = (Rnd() * 5 + 1) * 100
    End Sub

    Private Sub timerCharge_Tick(sender As Object, e As EventArgs) Handles timerCharge.Tick
        If rewindLimit < 500 Then
            rewindLimit += 10
            chargeBar.Increment(10)
        End If
    End Sub

    Private Sub timerRewind_Tick(sender As Object, e As EventArgs) Handles timerRewind.Tick
        If rewindLimit > 0 Then
            For i = 0 To projectiles.Count - 1
                projectiles(i).Rewind()
            Next
            rewindLimit -= 10
        Else
            chargeBar.Value = 0
            timerGenerate.Enabled = True
            timerShoot.Enabled = True
            timerRewind.Enabled = False
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timerCharge.Stop()
    End Sub
End Class
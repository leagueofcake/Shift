Public Class Projectile
    Inherits PictureBox

    Public Sub New()
        With Me
            .BackColor = Color.Transparent
            .BackgroundImageLayout = ImageLayout.Stretch
            .Image = My.Resources.projectile
            .Size = New Size(10, 10)
            .Location = New Point(680, 320)
        End With
    End Sub

    Public Sub Shoot()
        Me.Left -= 3
    End Sub

    Public Sub Rewind()
        Me.Left += 3
    End Sub
End Class
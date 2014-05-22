Public Class Projectile
    Inherits PictureBox ' Inherit picturebox properties
    Private hitCD As Boolean = False ' Hitcooldown

    Public Sub New() ' Creation of new projectile, set properties
        With Me
            .BackColor = Color.Transparent
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.projectile
            .Size = New Size(30, 30)
            .Location = New Point(750, (Rnd() * 100) + 200)
        End With
    End Sub

    Public Sub Shoot(ByVal shootVar As Integer) ' Shooting of projectile
        Me.Left -= shootVar
    End Sub

    Property hitCooldown() As Boolean ' Prevents registering of multiple collisions when touched once
        Get
            Return hitCD
        End Get
        Set(value As Boolean)
            hitCD = value
        End Set
    End Property
End Class
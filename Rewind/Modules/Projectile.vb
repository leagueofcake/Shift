Public Class Projectile
    Inherits PictureBox
    Private hitCD As Boolean

    Public Sub New()
        With Me
            .BackColor = Color.Transparent
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.projectile
            .Size = New Size(30, 30)
            .Location = New Point(750, 300)
        End With
    End Sub

    Public Sub Shoot(ByVal shootVar As Integer)
        Me.Left -= shootVar
    End Sub

    Property hitCooldown() As Boolean
        Get
            Return hitCD
        End Get
        Set(value As Boolean)
            hitCD += 1
        End Set
    End Property
End Class
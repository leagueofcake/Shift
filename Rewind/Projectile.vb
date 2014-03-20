Public Class Projectile
    Inherits PictureBox
    Private lifeCount As Integer
    Private isAbsorbed As Boolean

    Public Sub New()
        With Me
            .BackColor = Color.Transparent
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.projectile
            .Size = New Size(30, 30)
            .Location = New Point(680, 300)
        End With
    End Sub

    Public Sub Shoot()
        Me.Left -= 2
    End Sub

    Public Sub Rewind()
        Me.Left += 4
    End Sub

    Property life() As Integer
        Get
            Return lifeCount
        End Get
        Set(value As Integer)
            lifeCount += 1
        End Set
    End Property

    Property Absorb() As Boolean
        Get
            Return isAbsorbed
        End Get
        Set(value As Boolean)
            isAbsorbed = value
        End Set
    End Property
End Class
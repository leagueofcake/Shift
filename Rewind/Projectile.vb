Public Class Projectile
    Inherits PictureBox
    Private lifeCount As Integer
    Private isAbsorbed As Boolean

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
        Me.Left += 6
    End Sub

    Property life() As Integer
        Get
            Return lifeCount
        End Get
        Set(value As Integer)
            lifeCount += 1
        End Set
    End Property

    Property absorbed() As Boolean
        Get
            Return isAbsorbed
        End Get
        Set(value As Boolean)
            isAbsorbed = value
        End Set
    End Property
End Class
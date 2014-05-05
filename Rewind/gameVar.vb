Public Class gameVar
    Public Shared score As Integer = 0
    Public Shared genVar As Single
    Public Shared paused As Boolean = False
    Public Shared chargeLimit As Integer

    ' Difficulty shifting
    Public Shared healthDrain As Integer = 10
    Public Shared healthGain As Integer = 100
    Public Shared progression As Integer = 0 ' Essentially how long player has lasted in game
    Public Shared projectileSpeed As Integer = 4
End Class

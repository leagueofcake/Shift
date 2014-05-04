Public Class gameVar
    Public Shared score As Integer = 0
    Public Shared genVar As Single
    Public Shared paused As Boolean = False
    Public Shared chargeLimit As Integer

    ' Difficulty shifting
    Public Shared healthDrain As Integer = 20
    Public Shared progression As Integer = 0 ' Essentially how long player has lasted in game
End Class

Public Class Stage
    ' Game variables
    Public Shared currentStage As Integer = 0
    Public Shared score As Integer = 0
    Public Shared genVar As Single
    Public Shared paused As Boolean = False
    Public Shared charge As Integer
    Public Shared chargeMax As Integer = 500

    ' Player variables
    Public Shared playerSpeed As Integer = 4
    Public Shared playerHealth As Integer = 5000
    Public Shared shieldStatus As Integer = 0
    Public Shared shieldMax As Integer = 100
    Public Shared healthMax As Integer = 5000

    ' Difficulty shifting
    Public Shared healthDrain As Integer = 10
    Public Shared healthGain As Integer = 100
    Public Shared projectileSpeed As Integer = 4
    Public Shared progression As Integer = 0 ' Essentially how long player has lasted in game

    Public Shared Function selectStage()
        Dim rand = New Random().Next(0, 2) ' 0, max no. stages + 1
        While rand = currentStage ' force a different stage to current
            rand = New Random().Next(0, 2)
        End While
        currentStage = rand

        Return currentStage
    End Function

    Public Shared Sub shift(stageNumber As Integer)
        Select Case stageNumber
            Case 0 ' default
                playerSpeed = 4
                playerHealth = 5000
                shieldStatus = 0
                shieldMax = 100
                healthMax = 5000

                healthDrain = 10
                healthGain = 100
                projectileSpeed = 4
            Case 1 ' test
                playerSpeed = 8
        End Select
    End Sub
End Class
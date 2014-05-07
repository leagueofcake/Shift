Public Class Stage
    ' Game variables
    Public Shared currentStage As Integer = 0
    Public Shared score As Integer = 0
    Public Shared scoreMult As Integer = 0
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

    Public Shared Sub selectStage()
        Dim rand = New Random().Next(0, 2) ' 0, max no. stages + 1
        While rand = currentStage ' force a different stage to current
            rand = New Random().Next(0, 2)
        End While
        currentStage = rand
        applyStage(currentStage)
    End Sub

    Public Shared Sub applyStage(stageNumber As Integer)
        Select Case stageNumber
            ' shift(speed, chargeMax, shieldMax, healthMax, scoremult, healthDrain, healthGain, projectileSpeed)
            Case 0 ' default
                shift(4, 500, 100, 5000, 100, 10, 100, 4)
            Case 1 ' timeUp
                shift(6, 250, 50, 5000, 175, 20, 100, 8)
        End Select
    End Sub

    Public Shared Sub shift(speed As Integer, cMax As Integer, sMax As Integer, hMax As Integer, sMult As Integer, hDrain As Integer, hGain As Integer, pSpeed As Integer)
        playerSpeed = speed
        chargeMax = cMax
        shieldMax = sMax
        healthMax = hMax

        scoreMult = sMult
        healthDrain = hDrain
        healthGain = hGain
        projectileSpeed = pSpeed
    End Sub

    Public Sub anti()
        'Case -1 ' anti
        ' ANTI STAGE CODE INCOMPLETE
        'gameRewind.picWorld.Top = 0
        'gameRewind.pichealthText.Left = 750 - gameRewind.pichealthText.Width - 20
        'gameRewind.pichealthText.Top = 480 - 10 - 3 * gameRewind.pichealthText.Height
        'gameRewind.pichealthText.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipNone)

        'gameRewind.picPausedText.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipNone)

        'gameRewind.picHealth.Left = 750 - gameRewind.picHealth.Width - 200
        'gameRewind.picHealth.Top = 480 - 2 * gameRewind.picHealth.Height - 20
        'gameRewind.picHealth.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipNone)

        'gameRewind.picCharge.Left = 50
        'gameRewind.picCharge.Top = 140
        'gameRewind.picCharge.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipNone) ' CURRENTLY NOT WORKING

        'gameRewind.picChargeLabel.Left = 10
        'gameRewind.picChargeLabel.Top = 140
        'gameRewind.picChargeLabel.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipNone)

        'gameRewind.debugBox.Left = 500
    End Sub
End Class
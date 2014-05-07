Public Class Stage
    ' Game variables
    Public Shared currentStage As Integer = 0
    Public Shared score As Integer = 0
    Public Shared scoreMult As Integer = 0
    Public Shared genVar As Single
    Public Shared paused As Boolean = False
    Public Shared charge As Integer
    Public Shared chargeGain As Integer = 5
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

    Public Shared Sub selectStage() ' Generate a stage number different to current stage
        Dim rand = New Random().Next(0, 3) ' 0, max no. stages + 1
        While rand = currentStage ' force a different stage to current
            rand = New Random().Next(0, 3)
        End While
        currentStage = rand
        applyStage(currentStage)
    End Sub

    Public Shared Sub applyStage(stageNumber As Integer)
        Select Case stageNumber
            ' shift(speed, chargeGain, chargeMax, sshieldMax, healthMax, scoremult, healthDrain, healthGain, projectileSpeed)
            Case 0 ' default
                shift(4, 5, 500, 100, 5000, 100, 10, 100, 4)
            Case 1 ' timeUp
                shift(6, 2, 250, 25, 5000, 175, 20, 100, 8)
                ' Restart timers that were stopped by powerUp
                gameRewind.timerGenerate.Enabled = True
                gameRewind.timerWorld.Enabled = True
                gameRewind.timerShield.Enabled = True
            Case 2 ' lowHealth
                shift(4, 5, 500, 100, 2500, 200, 20, 200, 4)
        End Select

        If charge > chargeMax Then charge = chargeMax ' Set charge to chargeMax if in switching stage chargeMax is lowered and charge > chargeMax
        If playerHealth > healthMax Then playerHealth = healthMax ' Set playerHealth to healthMax if in switching stage healthMax is lowered and playerHealth > healthMax
    End Sub

    Public Shared Sub shift(speed As Integer, cGain As Integer, cMax As Integer, sMax As Integer, hMax As Integer, sMult As Integer, hDrain As Integer, hGain As Integer, pSpeed As Integer)
        playerSpeed = speed
        chargeGain = cGain
        chargeMax = cMax
        shieldMax = sMax
        healthMax = hMax

        scoreMult = sMult
        healthDrain = hDrain
        healthGain = hGain
        projectileSpeed = pSpeed
    End Sub

    Public Shared Sub applyPowerup(stageNumber As Integer)
        charge -= 1 ' Use up 1 charge
        Select Case stageNumber
            Case 0 ' default: speedUp
                playerSpeed = 8
            Case 1 ' timeUp: timeStop
                gameRewind.timerGenerate.Enabled = False
                gameRewind.timerWorld.Enabled = False
                gameRewind.timerShield.Enabled = False
        End Select
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
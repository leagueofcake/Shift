Public Class Stage
    ' Game variables
    Public Shared score As Integer = 0
    Public Shared genVar As Single
    Public Shared paused As Boolean = False
    Public Shared charge As Integer
    Public Shared progression As Integer = 0 ' Essentially how long player has lasted in game

    ' Player variables
    Public Shared playerHealth As Integer = 5000
    Public Shared shieldStatus As Integer = 0

    ' Difficulty shifting
    Public Shared currentStage As Integer = 0
    Public Shared playerSpeed As Integer = 4
    Public Shared healthMax As Integer = 5000
    Public Shared shieldMax As Integer = 100
    Public Shared healthDrain As Integer = 10
    Public Shared healthLoss As Integer = 20
    Public Shared healthGain As Integer = 100
    Public Shared chargeGain As Integer = 5
    Public Shared chargeMax As Integer = 500
    Public Shared projectileSpeed As Integer = 5
    Public Shared scoreMult As Integer = 0

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
            ' shift(playerSpeed, healthMax, shieldMax, healthDrain, healthLoss, healthGain, chargeGain, chargeMax, projectileSpeed, scoreMult)
            Case 0 ' default
                shift(4, 5000, 100, 10, 10, 400, 10, 500, 5, 100)
            Case 1 ' timeUp
                shift(6, 5000, 50, 20, 20, 600, 5, 250, 10, 175)
                ' Restart timers that were stopped by powerUp
                gameRewind.timerGenerate.Enabled = True
                gameRewind.timerWorld.Enabled = True
                gameRewind.timerShield.Enabled = True
            Case 2 ' lowHealth
                shift(4, 2500, 100, 20, 20, 800, 10, 500, 5, 200)
        End Select

        If charge > chargeMax Then charge = chargeMax ' Set charge to chargeMax if in switching stage chargeMax is lowered and charge > chargeMax
        If playerHealth > healthMax Then playerHealth = healthMax ' Set playerHealth to healthMax if in switching stage healthMax is lowered and playerHealth > healthMax
    End Sub

    Public Shared Sub shift(speed As Integer, hMax As Integer, sMax As Integer, hDrain As Integer, hLoss As Integer, hGain As Integer, cGain As Integer, cMax As Integer, pSpeed As Integer, sMult As Integer)
        playerSpeed = speed
        healthMax = hMax
        shieldMax = sMax
        healthDrain = hDrain
        healthLoss = hLoss
        healthGain = hGain
        chargeGain = cGain
        chargeMax = cMax
        projectileSpeed = pSpeed
        scoreMult = sMult

        gameRewind.picStage.BackgroundImage = My.Resources.ResourceManager.GetObject("stage" + currentStage.ToString)
    End Sub

    Public Shared Sub applyPowerup(stageNumber As Integer)
        If charge > 0 Then ' Use powerup if charge is available
            charge -= 1 ' Use up 1 charge
            Select Case stageNumber
                Case 0 ' default: speedUp
                    playerSpeed = 8
                Case 1 ' timeUp: timeStop
                    gameRewind.timerGenerate.Enabled = False
                    gameRewind.timerWorld.Enabled = False
                    gameRewind.timerShield.Enabled = False
                Case 2
                    gameRewind.picPlayer.BackColor = Color.Green ' Activate shield
            End Select
        Else ' Turn off powerup and timerPower
            gameRewind.timerPower.Enabled = False
            Select Case stageNumber
                Case 0
                    playerSpeed = 4
                Case 1
                    gameRewind.timerGenerate.Enabled = True
                    gameRewind.timerWorld.Enabled = True
                    gameRewind.timerShield.Enabled = True
                Case 2
                    gameRewind.picPlayer.BackColor = Color.DodgerBlue
            End Select
        End If
    End Sub

    Public Shared Sub newGame()
        Stage.currentStage = 0
        Stage.applyStage(0)
        Stage.score = 0
        Stage.playerHealth = 5000
        Stage.charge = 0
        Stage.shieldStatus = 0
        Stage.progression = 0
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
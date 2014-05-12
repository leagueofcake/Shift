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
        Dim rand = New Random().Next(0, 4) ' 0, max no. stages + 1
        While rand = currentStage ' force a different stage to current
            rand = New Random().Next(0, 4)
        End While
        currentStage = rand
        applyStage(currentStage)
    End Sub

    Private Function randHelper(minRange As Integer, maxRange As Integer)
        Return New Random().Next(minRange, maxRange)
    End Function

    Public Shared Sub applyStage(stageNumber As Integer)
        Select Case stageNumber
            ' shift(playerSpeed, healthMax, shieldMax, healthDrain, healthLoss, healthGain, chargeGain, chargeMax, projectileSpeed, scoreMult)
            Case 0 ' default
                shift(4, 5000, 100, 10, 10, 400, 10, 500, 5, 100)
            Case 1 ' timeUp
                shift(6, 5000, 50, 20, 20, 600, 5, 250, 10, 175)
                ' Restart timers that were stopped by powerUp
                gameShift.timerGenerate.Enabled = True
                gameShift.timerWorld.Enabled = True
                gameShift.timerShield.Enabled = True
            Case 2 ' lowHealth
                shift(4, 2500, 100, 20, 20, 800, 10, 500, 5, 200)
            Case 3 ' Random
                shift(New Random().Next(2, 8), New Random().Next(2500, 10000), New Random().Next(0, 200), New Random().Next(5, 20), New Random().Next(5, 20), New Random().Next(200, 800), New Random().Next(2, 8), New Random().Next(100, 1000), New Random().Next(5, 10), New Random().Next(50, 200))
                'shift(randHelper(2, 8), randHelper(2500, 10000), randHelper(0, 200), randHelper(5, 20), randHelper(5, 20), randHelper(200, 800), randHelper(2, 8), randHelper(100, 1000), randHelper(5, 10), randHelper(50, 200))
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

        gameShift.picStage.BackgroundImage = My.Resources.ResourceManager.GetObject("stage" + currentStage.ToString)
    End Sub

    Public Shared Sub applyPowerup(stageNumber As Integer)
        If charge > 0 Then ' Use powerup if charge is available
            charge -= 1 ' Use up 1 charge
            Select Case stageNumber
                Case 0 ' default: speedUp
                    playerSpeed = 8
                Case 1 ' timeUp: timeStop
                    gameShift.timerGenerate.Enabled = False
                    gameShift.timerWorld.Enabled = False
                    gameShift.timerShield.Enabled = False
                Case 2
                    gameShift.picPlayer.BackColor = Color.Green ' Activate shield
            End Select
        Else ' Turn off powerup and timerPower
            gameShift.timerPower.Enabled = False
            Select Case stageNumber
                Case 0
                    playerSpeed = 4
                Case 1
                    gameShift.timerGenerate.Enabled = True
                    gameShift.timerWorld.Enabled = True
                    gameShift.timerShield.Enabled = True
                Case 2
                    gameShift.picPlayer.BackColor = Color.DodgerBlue
            End Select
        End If
    End Sub

    Public Shared Sub newGame()
        Stage.currentStage = 3
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
        'gameShift.picWorld.Top = 0
        'gameShift.pichealthText.Left = 750 - gameShift.pichealthText.Width - 20
        'gameShift.pichealthText.Top = 480 - 10 - 3 * gameShift.pichealthText.Height
        'gameShift.pichealthText.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipNone)

        'gameShift.picPausedText.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipNone)

        'gameShift.picHealth.Left = 750 - gameShift.picHealth.Width - 200
        'gameShift.picHealth.Top = 480 - 2 * gameShift.picHealth.Height - 20
        'gameShift.picHealth.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipNone)

        'gameShift.picCharge.Left = 50
        'gameShift.picCharge.Top = 140
        'gameShift.picCharge.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipNone) ' CURRENTLY NOT WORKING

        'gameShift.picChargeLabel.Left = 10
        'gameShift.picChargeLabel.Top = 140
        'gameShift.picChargeLabel.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipNone)

        'gameShift.debugBox.Left = 500
    End Sub
End Class
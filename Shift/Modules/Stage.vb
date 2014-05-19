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
    Public Shared playerY As Integer = 0

    ' Difficulty shifting
    Public Shared currentStage As Integer = 0
    Public Shared playerSpeed As Integer = 4
    Public Shared healthMax As Integer = 5000
    Public Shared shieldMax As Integer = 100
    Public Shared healthDrain As Integer = 10
    Public Shared healthLoss As Integer = 20
    Public Shared healthGain As Integer = 100
    Public Shared chargeGain As Integer = 5
    Public Shared chargeUse As Integer = 1
    Public Shared chargeMax As Integer = 500
    Public Shared projectileSpeed As Integer = 5
    Public Shared scoreMult As Integer = 0
    Public Shared maxLevels As Integer = 7

    ' Teleportation variables
    Public Shared tempPlayerXY = New Point(0, 0)

    Public Shared Sub selectStage() ' Generate a stage number different to current stage
        Dim rand = New Random().Next(0, maxLevels) ' 0, max no. stages + 1
        While rand = currentStage ' force a different stage to current
            rand = New Random().Next(0, maxLevels)
        End While
        currentStage = rand
        applyStage(currentStage)
    End Sub

    Private Function randHelper(minRange As Integer, maxRange As Integer)
        Return New Random().Next(minRange, maxRange)
    End Function

    Public Shared Sub applyStage(stageNumber As Integer)
        Select Case stageNumber
            ' shift(playerSpeed, healthMax, shieldMax, healthDrain, healthLoss, healthGain, chargeGain, chargeUse, chargeMax, projectileSpeed, scoreMult)
            Case 0 ' default
                shift(4, 5000, 100, 10, 10, 400, 25, 1, 500, 5, 100)
            Case 1 ' timeUp
                shift(6, 5000, 50, 20, 20, 600, 5, 1, 250, 10, 175)
                ' Restart timers that were stopped by powerUp
                gameShift.timerGenerate.Enabled = True
                gameShift.timerWorld.Enabled = True
                gameShift.timerShield.Enabled = True
            Case 2 ' lowHealth
                shift(4, 2500, 100, 20, 20, 800, 1, 10, 500, 5, 250)
            Case 3 ' random
                shift(New Random().Next(2, 8), New Random().Next(2500, 10000), New Random().Next(0, 200), New Random().Next(5, 20), New Random().Next(5, 20), New Random().Next(200, 800), New Random().Next(2, 8), New Random().Next(1, 5), New Random().Next(100, 1000), New Random().Next(5, 10), New Random().Next(50, 200))
                'shift(randHelper(2, 8), randHelper(2500, 10000), randHelper(0, 200), randHelper(5, 20), randHelper(5, 20), randHelper(200, 800), randHelper(2, 8), randHelper(100, 1000), randHelper(5, 10), randHelper(50, 200))
            Case 4 ' timeSpace
                shift(10 - gameShift.picPlayer.Left / 100, 5000, 100, 10, 10, 400, 10, 1, 500, 12 - (gameShift.picPlayer.Left / 100), 150)
            Case 5 ' noShield
                shift(4, 5000, 1500, 0, healthMax, -healthMax, 1, 5, 500, 5, 200)
            Case 99 ' Tutorial
                shift(4, 5000, 100, 10, 10, 400, 10, 1, 500, 5, 100)
        End Select

        If charge > chargeMax Then charge = chargeMax ' Set charge to chargeMax if in switching stage chargeMax is lowered and charge > chargeMax
        If playerHealth > healthMax Then playerHealth = healthMax ' Set playerHealth to healthMax if in switching stage healthMax is lowered and playerHealth > healthMax
    End Sub

    Public Shared Sub shift(speed As Integer, hMax As Integer, sMax As Integer, hDrain As Integer, hLoss As Integer, hGain As Integer, cGain As Integer, cUse As Integer, cMax As Integer, pSpeed As Integer, sMult As Integer)
        playerSpeed = speed
        healthMax = hMax
        shieldMax = sMax
        healthDrain = hDrain
        healthLoss = hLoss
        healthGain = hGain
        chargeGain = cGain
        chargeUse = cUse
        chargeMax = cMax
        projectileSpeed = pSpeed
        scoreMult = sMult

        gameShift.picStage.BackgroundImage = My.Resources.ResourceManager.GetObject("stage" + currentStage.ToString)
    End Sub

    Public Shared Sub applyPowerup(stageNumber As Integer)
        If charge > 0 Then ' Use powerup if charge is available
            charge -= chargeUse ' Use up 1 charge
            Select Case stageNumber
                Case 0 ' default: speedUp
                    playerSpeed = 8
                Case 1 ' timeUp: timeStop
                    gameShift.timerGenerate.Enabled = False
                    gameShift.timerWorld.Enabled = False
                    gameShift.timerShield.Enabled = False
                Case 2 ' lowHealth: activateShield
                    gameShift.picPlayer.BackColor = Color.Green ' Activate shield
                Case 3 ' random: randomise values
                    ' Powerup built in - re-randomise values
                Case 4 ' spaceTime: teleport
                    playerY = 12 ' Activate gravity
                    ' Store current position in temporary variable
                    Dim newPosX = gameShift.MousePosition.X - (gameShift.Left + gameShift.picPlayer.Width / 2)
                    Dim newPosY = gameShift.MousePosition.Y - (gameShift.Top + gameShift.picPlayer.Height)
                    If newPosX > 0 And newPosY < 300 Then ' Prevent going off stage
                        gameShift.picPlayer.Left = newPosX
                        gameShift.picPlayer.Top = newPosY
                    Else
                        charge += 1
                    End If
                Case 5 ' phase
                    gameShift.picPlayer.BackColor = Color.SkyBlue
            End Select
        Else ' Turn off powerup and timerPower if out of charge
            gameShift.timerPower.Enabled = False
            Select Case stageNumber
                Case 0 ' default: speedUp
                    playerSpeed = 4
                Case 1 'timeUp: timeStop
                    gameShift.timerGenerate.Enabled = True
                    gameShift.timerWorld.Enabled = True
                    gameShift.timerShield.Enabled = True
                Case 2 ' lowHealth
                    gameShift.picPlayer.BackColor = Color.DodgerBlue
                Case 3 ' random: randomise values
                    ' Powerup built in - re-randomise values
                Case 4 ' spaceTime: teleport
                    gameShift.picPlayer.Location = tempPlayerXY ' Revert to pre-teleportation coordinates
                Case 5 ' phase
                    gameShift.picPlayer.BackColor = Color.DodgerBlue
            End Select
        End If
    End Sub

    Public Shared Sub newGame(tutorial As Boolean)
        score = 0
        playerHealth = 5000
        charge = 0
        shieldStatus = 0
        progression = 0

        If tutorial = False Then ' Normal game
            currentStage = 0
            applyStage(0)
        Else ' Tutorial stage
            currentStage = 99
            applyStage(99)
            gameShift.runTutorial()
        End If
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
Public Class Stage
    ' Game variables
    Public Shared score As Integer = 0
    Public Shared genVar As Single
    Public Shared paused As Boolean = False
    Public Shared charge As Integer
    Public Shared progression As Integer = 0 ' Essentially how long player has lasted in game
    Public Shared powerInUse As Boolean = False
    Public Shared powerCooldown As Integer = 1000

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
    Public Shared maxLevels As Integer = 6

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

    Public Shared Sub applyStage(stageNumber As Integer)
        Select Case stageNumber
            ' shift(playerSpeed, healthMax, shieldMax, healthDrain, healthLoss, healthGain, chargeGain, chargeUse, chargeMax, projectileSpeed, powerCooldown, scoreMult)
            Case 0 ' default
                shift(4, 5000, 100, 10, 10, 400, 25, 1, 500, 5, 1500, 1)
            Case 1 ' timeUp
                shift(6, 5000, 75, 15, 10, 700, 15, 250, 250, 10, 5, 2)
            Case 2 ' lowHealth
                shift(4, 2500, 100, 20, 20, 800, 1, 10, 500, 5, 1500, 3)
            Case 3 ' random
                shift(New Random().Next(2, 8), New Random().Next(2500, 10000), New Random().Next(0, 200), New Random().Next(5, 20), New Random().Next(5, 20), New Random().Next(200, 800), New Random().Next(2, 8), charge, New Random().Next(100, 1000), New Random().Next(5, 10), New Random().Next(1000, 3000), New Random().Next(1, 5))
            Case 4 ' timeSpace
                shift(10 - gameShift.picPlayer.Left / 100, 5000, 100, 10, 10, 400, 10, 1, 500, 12 - (gameShift.picPlayer.Left / 100), 500, 2)
            Case 5 ' noShield
                shift(4, 5000, 1500, 0, healthMax, -healthMax, 2, 4, 500, 5, 500, 5)
        End Select

        If charge > chargeMax Then charge = chargeMax ' Set charge to chargeMax if in switching stage chargeMax is lowered and charge > chargeMax
        If playerHealth > healthMax Then playerHealth = healthMax ' Set playerHealth to healthMax if in switching stage healthMax is lowered and playerHealth > healthMax
    End Sub

    Public Shared Sub shift(speed As Integer, hMax As Integer, sMax As Integer, hDrain As Integer, hLoss As Integer, hGain As Integer, cGain As Integer, cUse As Integer, cMax As Integer, pSpeed As Integer, pCD As Integer, sMult As Integer)
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
        powerCooldown = pCD
        scoreMult = sMult

        gameShift.picStage.BackgroundImage = My.Resources.ResourceManager.GetObject("stage" + currentStage.ToString)
    End Sub

    Public Shared Sub applyPowerup(stageNumber As Integer)
        powerInUse = True
        Select Case stageNumber
            Case 0 ' default: speedUp
                playerSpeed = 8
            Case 1 ' timeUp: timeStop | flashStrike
                With gameShift
                    .timerWorld.Enabled = False
                    .timerShield.Enabled = False
                    .timerMove.Enabled = False
                End With

                ' NEW POWERUP ADDON
                powerCooldown = 5
                tempPlayerXY = gameShift.picPlayer.Location
                gameShift.picPlayer.BackColor = Color.Green
                projectileSpeed = 3
                healthDrain = 5
                chargeGain = 5
                scoreMult = 0
                gameShift.timerPower.Interval = 200
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
                gameShift.picPlayer.BackColor = Color.FromArgb(50, 130, 215, 255)
        End Select
    End Sub

    Public Shared Sub deactivatePowerup(stageNumber As Integer)
        powerInUse = False
        gameShift.timerPower.Enabled = False
        Select Case stageNumber
            Case 0 ' default: speedUp
                playerSpeed = 4
            Case 1 'timeUp: timeStop
                With gameShift
                    .timerWorld.Enabled = True
                    .timerShield.Enabled = True
                    .timerMove.Enabled = True
                End With

                ' NEW POWERUP ADDON
                powerCooldown = 5
                gameShift.picPlayer.Location = tempPlayerXY
                projectileSpeed = 10
                healthDrain = 15
                chargeGain = 15
                scoreMult = 175
                gameShift.timerPower.Interval = 10
            Case 2 ' lowHealth
                gameShift.picPlayer.BackColor = Color.DodgerBlue
            Case 3 ' random: randomise values
                ' Powerup built in - re-randomise values
            Case 4 ' spaceTime: teleport
                'gameShift.picPlayer.Location = tempPlayerXY ' Revert to pre-teleportation coordinates, currently unused
            Case 5 ' phase
                gameShift.picPlayer.BackColor = Color.DodgerBlue
        End Select
    End Sub

    Public Shared Sub newGame()
        score = 0
        playerHealth = 5000
        charge = 0
        shieldStatus = 0
        progression = 0

        currentStage = 5
        applyStage(5)

        For i = 0 To gameShift.projectiles.Count - 1
            gameShift.projectiles(i).Top = -50
        Next
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
''' <summary>
''' Program Name: Shift
''' 
''' Author: Dominic Fung
''' 
''' Date first written: 13/3/2014
''' 
''' Current Version: 1.0
''' 
''' Game summary: A sidescroller (game in which the gameplay action is viewed from a side-view camera angle) game written in VB.Net. The aim of the game for the player 
''' is to survive for as long as possible in order to accumulate the highest score. The stage shifts every 10 seconds, with the game variables shifting in accordance. 
''' Powerups are available to the player in order to assist them and are unique to each stage. The powerups can be used by consuming charge, which is gained by absorbing
''' the blue orbs when the player's shield is on (player is green). Each stage has a score multiplier which affects how many points the player receives for surviving 
''' each second in the stage, determined by the difficulty of the stage. More information on the game can be found in the help section. 
''' 
''' </summary>
''' <remarks></remarks>

Public Class gameShift
    Public Shared projectiles As New ArrayList ' Array of projectile objects
    Dim finishJump As Boolean = False ' Boolean for detecting whether the player has finished jumping

    Public Declare Function GetAsyncKeyState Lib "user32.dll" (ByVal vKey As Int32) As UShort ' Asynchronously detect key presses

    Private Sub pausePanel() ' Displays the pause overlay when activated
        With panelPause
            .Visible = Not panelPause.Visible
            .BackColor = Color.FromArgb(50, 255, 255, 255)
            .BringToFront()
        End With

        Select Case Stage.currentStage ' Displays relevant information on each stage and respective powerup in the pause overlay
            Case 0 ' Default
                rtbStageDesc.Text = "default" + vbNewLine + "The default stage! Charge gain is boosted on this stage, so try collect as much as you can before the shift!" + vbNewLine + "1x score multiplier"
                rtbPowerDesc.Text = "speedUp" + vbNewLine + "Double your movement speed for faster orb absorbtion power!" + vbNewLine + "Consumes 1 charge/second."
            Case 1 ' timeUp
                rtbStageDesc.Text = "timeUp" + vbNewLine + "Everything's sped up!"
                rtbPowerDesc.Text = "flashStrike" + vbNewLine + "Blink around the screen with your shield on and strike up to 7 orbs. Only activates when charge bar is filled. (250)" + vbNewLine + "2x score multiplier"
            Case 2 ' lowHealth
                rtbStageDesc.Text = "lowHealth" + vbNewLine + "Your health cap is lowered and the health drain is increased! Be smart with your health management and try not to run out!" + vbNewLine + "3x score multiplier"
                rtbPowerDesc.Text = "shield" + vbNewLine + "Activate your shield." + vbNewLine + " onsumes 10 charge/second"
            Case 3 ' random
                rtbStageDesc.Text = "random" + vbNewLine + "Almost all game variables are randomised (to a certain extent). Don't worry if you start off with unfavourable values though, they re-randomise every two seconds!" + vbNewLine + "Variable score multiplier"
                rtbPowerDesc.Text = "reRandomise" + vbNewLine + "More re-randomising of game variables, at your leisure." + vbNewLine + "Consumes entire charge bar."
            Case 4 ' spaceTime
                rtbStageDesc.Text = "spaceTime" + vbNewLine + "The game shifts with your position on the screen! The further left you are, the faster you and the orbs move, and vice versa. The generation of orbs also depends on your position - being further left results in more frequent generation, and vice versa." + vbNewLine + "2x score multiplier"
                rtbPowerDesc.Text = "tele" + vbNewLine + "Teleports player to the location of the cursor." + vbNewLine + "Consumes 1 charge"
            Case 5
                rtbStageDesc.Text = "noShield" + vbNewLine + "Your shield has been deactivated and worse yet, someone's put you on a mad jumping spree! Don't hit a single orb, or you'll lose all your health! Instead of absorbing orbs to gain charge, you will gain charge automatically as time progresses. " + vbNewLine + "5x score multiplier"
                rtbPowerDesc.Text = "phase" + vbNewLine + "Phase out, turning yourself a lovely light blue. Touching a projectile when phased out on will have no effect." + vbNewLine + "Consumes 4 charge/second. "
        End Select
    End Sub

    Private Sub togglePause() ' Toggles the pause function - disables timers
        timerMove.Enabled = Not timerMove.Enabled
        timerGenerate.Enabled = Not timerGenerate.Enabled
        timerWorld.Enabled = Not timerWorld.Enabled
        timerShoot.Enabled = Not timerShoot.Enabled
    End Sub

    Private Sub endGame() ' Sub for handling when the game ends - stops timers, shows end screen
        togglePause()
        timerConstant.Enabled = False
        timerShield.Enabled = False
        endScreen.lblScore.Text = "Score: " + Stage.score.ToString
        endScreen.Show()
    End Sub

    Private Sub gravity() ' Sub dealing with jumping and gravity of the stage
        If picPlayer.Bottom + -25 + (Stage.playerY ^ (1 + (1 / 10000))) >= picWorld.Top Then ' Finished jump
            Stage.playerY = 0
            picPlayer.Top = picWorld.Top - picPlayer.Height
            timerMove.Tag = timerMove.Tag.Replace("jump", "")

            If finishJump = True Then ' Finished jump, remove left/right tag
                timerMove.Tag = timerMove.Tag.Replace("left", "")
                timerMove.Tag = timerMove.Tag.Replace("right", "")
                finishJump = False
            End If
        ElseIf picPlayer.Bottom < picWorld.Top Or timerMove.Tag.Contains("jump") Then ' Still jumping
            Stage.playerY += 1
            picPlayer.Top += -14.5 + (Stage.playerY ^ (1 + (1 / 10000))) ' Formula credits to David Shi
        End If
    End Sub

    Private Sub projectileShoot() ' Handles shooting of projectiles
        For i = 0 To projectiles.Count - 1
            Try
                If timerGenerate.Enabled = True Then
                    If Not projectiles(i).Bounds.IntersectsWith(picPlayer.Bounds) Then projectiles(i).hitCooldown = False ' If the player is not colliding with projectile then its hitCooldown is turned off
                    projectiles(i).Shoot(Stage.projectileSpeed)
                    If projectiles(i).Left < -500 Then ' Remove from form and arraylist if it is off the screen
                        projectiles.Remove(projectiles(i))
                        Me.Controls.Remove(projectiles(i))
                        Exit Sub
                    End If
                End If
            Catch ex As Exception

            End Try
        Next
    End Sub

    Private Sub projectileCollision() ' Handles player collision with projectiles
        For i = 0 To projectiles.Count - 1
            Try
                If projectiles(i).Bounds.IntersectsWith(picPlayer.Bounds) Then
                    If picPlayer.BackColor = Color.Green Then ' Shield on, regenerate health and charge up powerup
                        If Stage.playerHealth + Stage.healthGain > Stage.healthMax Then Stage.playerHealth = Stage.healthMax Else Stage.playerHealth = Stage.playerHealth + Stage.healthGain ' If regenerating health goes above cap then health = health cap
                        If Stage.charge + Stage.chargeGain < Stage.chargeMax Then Stage.charge += Stage.chargeGain Else Stage.charge = Stage.chargeMax ' If regenerating charge goes above cap then charge = charge cap
                        projectiles(i).BackColor = Color.White
                        projectiles(i).Top = -50 ' Move projectile off screen
                        Stage.score += Stage.scoreMult * 100 ' Add to score
                        Exit Sub
                    ElseIf picPlayer.BackColor = Color.DodgerBlue And projectiles(i).hitCooldown = False Then ' Shield off, take damage
                        If Stage.playerHealth - Stage.healthLoss < 0 Then Stage.playerHealth = 0 Else Stage.playerHealth = Stage.playerHealth - Stage.healthLoss ' If losing health goes below cap then health = 0
                        projectiles(i).hitCooldown = True ' Activate cooldown for the projectile - player can't register multiple hits while touching it once
                        projectiles(i).BackgroundImage = My.Resources.projectileOrange ' Change projectile image to orange when touched without shield
                        Exit Sub
                    End If
                End If
            Catch ex As Exception
                ' None
            End Try
        Next
    End Sub

    Private Sub timerConstant_Tick(sender As Object, e As EventArgs) Handles timerConstant.Tick
        updateFormLabels() ' Update form labels constantly
        projectileCollision() ' Check for collision with projectiles

        picHealth.BackgroundImage = My.Resources.ResourceManager.GetObject("healthbar" + Math.Ceiling(Stage.playerHealth / (Stage.healthMax / 20)).ToString) ' Update healthBar graphic
        picCharge.BackgroundImage = My.Resources.ResourceManager.GetObject("chargeBar" + Math.Ceiling(Stage.charge / (Stage.chargeMax / 10)).ToString) ' Update chargeBar graphic

        ' Key detection
        Dim arrowLeft = GetAsyncKeyState(CInt(Keys.Left))
        Dim arrowRight = GetAsyncKeyState(CInt(Keys.Right))
        Dim arrowUp = GetAsyncKeyState(CInt(Keys.Up))
        If GetAsyncKeyState(CInt(Keys.Oemtilde)) Then debugBox.Visible = Not debugBox.Visible ' Toggle debug box

        If arrowLeft Or arrowRight Or arrowUp Then ' Movement according to timerMove tags
            timerMove.Tag = timerMove.Tag.Replace("idle", "")
            If arrowLeft And Not timerMove.Tag.Contains("left") Then
                timerMove.Tag += "left"
                If timerMove.Tag.Contains("right") Then timerMove.Tag = timerMove.Tag.Replace("right", "")
            End If

            If arrowRight And Not timerMove.Tag.Contains("right") Then
                timerMove.Tag += "right"
                If timerMove.Tag.Contains("left") Then timerMove.Tag = timerMove.Tag.Replace("left", "")
            End If

            If arrowUp And Not timerMove.Tag.Contains("jump") Then timerMove.Tag += "jump"
        End If
    End Sub

    Private Sub timerWorld_Tick(sender As Object, e As EventArgs) Handles timerWorld.Tick
        Stage.progression += 1 ' Add 1 to progression counter

        ' Apply special stage properties
        If Stage.currentStage = 3 And Stage.progression Mod 200 = 0 Then Stage.applyStage(Stage.currentStage) ' Stage 3 (random) - shift game variables every 2 seconds
        If Stage.currentStage = 4 Then Stage.applyStage(4) ' Constantly update game values based on position
        If Stage.currentStage = 5 Then ' noShield, constantly gain charge and apply charge max cap
            If Stage.charge + Stage.chargeGain < Stage.chargeMax Then Stage.charge += Stage.chargeGain Else Stage.charge = Stage.chargeMax
        End If

        If Stage.playerHealth > 0 Then Stage.playerHealth -= Stage.healthDrain ' Constantly drain health
        If Stage.playerHealth > 0 Then Stage.score += Stage.scoreMult ' Constantly add to score counter
        If Stage.playerHealth = 0 Then endGame() ' End game if player's health reaches zero
    End Sub

    Private Sub timerGenerate_Tick(sender As Object, e As EventArgs) Handles timerGenerate.Tick
        ' Generate new projectiles with a random interval (genVar)
        Dim newProjectile As New Projectile
        Controls.Add(newProjectile)
        projectiles.Add(newProjectile)

        ' If stage = 4 (spacetime) then genvar is dependent on player's position else semi-randomised
        If Stage.currentStage = 4 Then
            Stage.genVar = ((picPlayer.Left / 10) + 1) ^ 1.5 + 200
        ElseIf Stage.currentStage = 5 Then ' Easier on noShield
            Stage.genVar = New Random().Next(400, 1000)
            timerMove.Tag += "jump"
        Else
            Stage.genVar = New Random().Next(100, 400)
        End If

        timerGenerate.Interval = Stage.genVar ' Update timerGenerate's interval to match genVar
    End Sub

    Private Sub timerShield_Tick(sender As Object, e As EventArgs) Handles timerShield.Tick
        ' Toggles between shield on/off when Stage.shieldStatus is equal shieldMax, blue = shield on, green = shield off
        If Stage.shieldStatus < Stage.shieldMax Then Stage.shieldStatus += 1 Else Stage.shieldStatus = 0
        If Stage.shieldStatus = 0 Then If picPlayer.BackColor = Color.DodgerBlue Then picPlayer.BackColor = Color.Green Else picPlayer.BackColor = Color.DodgerBlue
    End Sub

    Private Sub timerMove_Tick(sender As Object, e As EventArgs) Handles timerMove.Tick ' Handles movement of player with timerMove tags
        If timerMove.Tag.Contains("left") And Not timerMove.Tag.Contains("right") And picPlayer.Left > 0 Then picPlayer.Left -= Stage.playerSpeed
        If timerMove.Tag.Contains("right") And Not timerMove.Tag.Contains("left") And picPlayer.Left < Me.Width - 65 Then picPlayer.Left += Stage.playerSpeed
        gravity() ' Activate gravity for jumping/falling
    End Sub

    Private Sub timerPower_Tick(sender As Object, e As EventArgs) Handles timerPower.Tick
        ' Handles one-use powers
        If Stage.powerInUse And Stage.powerCooldown > 0 Then
            Select Case Stage.currentStage
                Case 1
                    Dim i = CInt(New Random().Next(0, projectiles.Count)) ' Select random projectile
                    Stage.powerCooldown -= 1

                    If projectiles(i).Top < 0 Or projectiles(i).Left < 0 Then ' If selected projectile is not within the bounds of the screen reselect
                        For i = 0 To projectiles.Count - 1
                            If projectiles(i).Top > 0 And projectiles(i).Left > 0 Then
                                Exit For
                            End If
                        Next
                        Exit Sub
                    End If

                    picPlayer.Location = projectiles(i).Location ' Teleport to the chosen projectile(i)
                    Exit Sub
            End Select
        End If

        If Stage.powerCooldown = 0 Then ' Deactivate power and skip rest of sub if powerCooldown = 0
            Stage.deactivatePowerup(Stage.currentStage)
            Exit Sub
        End If

        ' NORMAL POWERUPS
        If Stage.charge > 0 And Stage.charge >= Stage.chargeUse Then ' Use powerup if charge is available otherwise deactivate the power
            Stage.charge -= Stage.chargeUse ' Use up chargeUse
            Stage.applyPowerup(Stage.currentStage)
        Else
            Stage.deactivatePowerup(Stage.currentStage)
        End If
    End Sub

    Private Sub timerShoot_Tick(sender As Object, e As EventArgs) Handles timerShoot.Tick ' Shooting of projectiles
        projectileShoot()
    End Sub

    Private Sub gameShift_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case Microsoft.VisualBasic.ChrW(Keys.Escape) ' Toggle pausing of game
                Stage.paused = Not Stage.paused
                togglePause()
                pausePanel()
                If Stage.paused = True Then timerShield.Stop() Else timerShield.Start() ' Toggle timerShield
            Case Microsoft.VisualBasic.ChrW(Keys.Space) ' Activate powerup
                If Stage.paused = False Then timerPower.Enabled = True
        End Select
    End Sub

    Private Sub gameShift_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Space Then Stage.tempPlayerXY = picPlayer.Location ' Set tempPlayerXY to player's current location (used in powerups with tethering where you return to original position)
    End Sub

    Private Sub gameShift_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Space And Stage.paused = False And Not Stage.currentStage = 1 Then ' Deactivate powerup upon keyUp
            If Stage.powerInUse = False Then timerPower.Enabled = False
            Stage.deactivatePowerup(Stage.currentStage)

            'If Stage.currentStage = 4 Then picPlayer.Location = Stage.tempPlayerXY ' Leashing for teleportation, currently unused
            If Stage.currentStage = 5 Then picPlayer.BackColor = Color.DodgerBlue
        ElseIf (e.KeyCode = Keys.Left Or e.KeyCode = Keys.Right) Then ' Change timerMove.Tag to idle if not jumping and left/right key is released
            If Not timerMove.Tag.Contains("jump") Then timerMove.Tag = "idle" Else finishJump = True
        End If
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click ' Close game and go to menu
        Me.Close()
        mainShift.Show()
    End Sub

    Private Sub updateFormLabels() ' Constantly updates labels in debugging box
        lblPosX.Text = picPlayer.Left
        lblPosY.Text = picPlayer.Top
        lblProjectiles.Text = projectiles.Count
        lblHealth.Text = Stage.playerHealth
        lblMovement.Text = timerMove.Tag
        lblCharge.Text = Stage.charge
        lblCharge.Text = Stage.charge
        lblShootVar.Text = (picPlayer.Left / 100) + 4
        lblGenVar.Text = Stage.genVar
        lblPaused.Text = Stage.paused
        lblShieldStatus.Text = Stage.shieldStatus
        lblProgression.Text = Stage.progression
        lblHpDrain.Text = Stage.healthDrain
        lblStage.Text = Stage.currentStage
        lblScore.Text = Stage.score
        lblPlayerY.Text = Stage.playerY
        lblTempXY.Text = (Stage.tempPlayerXY).ToString
        lblPCD.Text = Stage.powerCooldown
        If picPlayer.BackColor = Color.DodgerBlue Then lblShieldOn.Text = "Off" Else lblShieldOn.Text = "On"

        If Not Stage.progression = 0 Then
            If Stage.progression Mod 100 = 0 Then lblShiftTimer.Text = "Next Shift in " + (15 - ((Stage.progression / 100) Mod 15)).ToString + " seconds"
            If Stage.progression Mod 1500 = 0 Then Stage.selectStage() ' Every 10 seconds, shift game variables
        End If
    End Sub
End Class
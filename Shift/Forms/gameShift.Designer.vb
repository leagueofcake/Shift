<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gameShift
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gameShift))
        Me.timerWorld = New System.Windows.Forms.Timer(Me.components)
        Me.timerGenerate = New System.Windows.Forms.Timer(Me.components)
        Me.timerShield = New System.Windows.Forms.Timer(Me.components)
        Me.lbl13 = New System.Windows.Forms.Label()
        Me.timerMove = New System.Windows.Forms.Timer(Me.components)
        Me.lblPosY = New System.Windows.Forms.Label()
        Me.lblMovement = New System.Windows.Forms.Label()
        Me.debugBox = New System.Windows.Forms.GroupBox()
        Me.lblPCD = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblTempXY = New System.Windows.Forms.Label()
        Me.lblPlayerY = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblStage = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblProjectiles = New System.Windows.Forms.Label()
        Me.lblHpDrain = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblProgression = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblShieldStatus = New System.Windows.Forms.Label()
        Me.lblPaused = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblGenVar = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblShootVar = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblShieldOn = New System.Windows.Forms.Label()
        Me.lblCharge = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblHealth = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPosX = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelPause = New System.Windows.Forms.Panel()
        Me.btnMenu = New System.Windows.Forms.PictureBox()
        Me.picPausedText = New System.Windows.Forms.PictureBox()
        Me.timerConstant = New System.Windows.Forms.Timer(Me.components)
        Me.picHealth = New System.Windows.Forms.PictureBox()
        Me.pichealthText = New System.Windows.Forms.PictureBox()
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.picWorld = New System.Windows.Forms.PictureBox()
        Me.picCharge = New System.Windows.Forms.PictureBox()
        Me.picChargeLabel = New System.Windows.Forms.PictureBox()
        Me.lblScoreTitle = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblShiftTimer = New System.Windows.Forms.Label()
        Me.timerPower = New System.Windows.Forms.Timer(Me.components)
        Me.picStage = New System.Windows.Forms.PictureBox()
        Me.timerShoot = New System.Windows.Forms.Timer(Me.components)
        Me.rtbStageDesc = New System.Windows.Forms.RichTextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.rtbPowerDesc = New System.Windows.Forms.RichTextBox()
        Me.debugBox.SuspendLayout()
        Me.panelPause.SuspendLayout()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPausedText, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHealth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pichealthText, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWorld, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCharge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChargeLabel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timerWorld
        '
        Me.timerWorld.Enabled = True
        Me.timerWorld.Interval = 10
        '
        'timerGenerate
        '
        Me.timerGenerate.Enabled = True
        Me.timerGenerate.Interval = 500
        '
        'timerShield
        '
        Me.timerShield.Enabled = True
        Me.timerShield.Interval = 10
        '
        'lbl13
        '
        Me.lbl13.AutoSize = True
        Me.lbl13.BackColor = System.Drawing.Color.Transparent
        Me.lbl13.ForeColor = System.Drawing.Color.White
        Me.lbl13.Location = New System.Drawing.Point(6, 85)
        Me.lbl13.Name = "lbl13"
        Me.lbl13.Size = New System.Drawing.Size(61, 13)
        Me.lbl13.TabIndex = 7
        Me.lbl13.Text = "Projectiles: "
        '
        'timerMove
        '
        Me.timerMove.Enabled = True
        Me.timerMove.Interval = 20
        Me.timerMove.Tag = "idle"
        '
        'lblPosY
        '
        Me.lblPosY.AutoSize = True
        Me.lblPosY.BackColor = System.Drawing.Color.Transparent
        Me.lblPosY.ForeColor = System.Drawing.Color.White
        Me.lblPosY.Location = New System.Drawing.Point(68, 45)
        Me.lblPosY.Name = "lblPosY"
        Me.lblPosY.Size = New System.Drawing.Size(42, 13)
        Me.lblPosY.TabIndex = 8
        Me.lblPosY.Text = "lblPosY"
        '
        'lblMovement
        '
        Me.lblMovement.AutoSize = True
        Me.lblMovement.BackColor = System.Drawing.Color.Transparent
        Me.lblMovement.ForeColor = System.Drawing.Color.White
        Me.lblMovement.Location = New System.Drawing.Point(68, 65)
        Me.lblMovement.Name = "lblMovement"
        Me.lblMovement.Size = New System.Drawing.Size(49, 13)
        Me.lblMovement.TabIndex = 10
        Me.lblMovement.Text = "Direction"
        '
        'debugBox
        '
        Me.debugBox.BackColor = System.Drawing.Color.Transparent
        Me.debugBox.Controls.Add(Me.lblPCD)
        Me.debugBox.Controls.Add(Me.Label15)
        Me.debugBox.Controls.Add(Me.lblTempXY)
        Me.debugBox.Controls.Add(Me.lblPlayerY)
        Me.debugBox.Controls.Add(Me.Label16)
        Me.debugBox.Controls.Add(Me.Label12)
        Me.debugBox.Controls.Add(Me.lblStage)
        Me.debugBox.Controls.Add(Me.Label14)
        Me.debugBox.Controls.Add(Me.lblProjectiles)
        Me.debugBox.Controls.Add(Me.lblHpDrain)
        Me.debugBox.Controls.Add(Me.Label13)
        Me.debugBox.Controls.Add(Me.lblProgression)
        Me.debugBox.Controls.Add(Me.Label8)
        Me.debugBox.Controls.Add(Me.lblShieldStatus)
        Me.debugBox.Controls.Add(Me.lblPaused)
        Me.debugBox.Controls.Add(Me.Label11)
        Me.debugBox.Controls.Add(Me.Label10)
        Me.debugBox.Controls.Add(Me.lblGenVar)
        Me.debugBox.Controls.Add(Me.Label9)
        Me.debugBox.Controls.Add(Me.lblShootVar)
        Me.debugBox.Controls.Add(Me.Label7)
        Me.debugBox.Controls.Add(Me.Label6)
        Me.debugBox.Controls.Add(Me.lblShieldOn)
        Me.debugBox.Controls.Add(Me.lblCharge)
        Me.debugBox.Controls.Add(Me.Label5)
        Me.debugBox.Controls.Add(Me.lblHealth)
        Me.debugBox.Controls.Add(Me.Label4)
        Me.debugBox.Controls.Add(Me.Label2)
        Me.debugBox.Controls.Add(Me.Label3)
        Me.debugBox.Controls.Add(Me.lblPosX)
        Me.debugBox.Controls.Add(Me.Label1)
        Me.debugBox.Controls.Add(Me.lblPosY)
        Me.debugBox.Controls.Add(Me.lblMovement)
        Me.debugBox.Controls.Add(Me.lbl13)
        Me.debugBox.ForeColor = System.Drawing.Color.White
        Me.debugBox.Location = New System.Drawing.Point(393, 56)
        Me.debugBox.Name = "debugBox"
        Me.debugBox.Size = New System.Drawing.Size(241, 196)
        Me.debugBox.TabIndex = 11
        Me.debugBox.TabStop = False
        Me.debugBox.Text = "Debugging"
        Me.debugBox.Visible = False
        '
        'lblPCD
        '
        Me.lblPCD.AutoSize = True
        Me.lblPCD.BackColor = System.Drawing.Color.Transparent
        Me.lblPCD.ForeColor = System.Drawing.Color.White
        Me.lblPCD.Location = New System.Drawing.Point(68, 178)
        Me.lblPCD.Name = "lblPCD"
        Me.lblPCD.Size = New System.Drawing.Size(13, 13)
        Me.lblPCD.TabIndex = 40
        Me.lblPCD.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(7, 180)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(28, 13)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "pCD"
        '
        'lblTempXY
        '
        Me.lblTempXY.AutoSize = True
        Me.lblTempXY.BackColor = System.Drawing.Color.Transparent
        Me.lblTempXY.ForeColor = System.Drawing.Color.White
        Me.lblTempXY.Location = New System.Drawing.Point(162, 161)
        Me.lblTempXY.Name = "lblTempXY"
        Me.lblTempXY.Size = New System.Drawing.Size(13, 13)
        Me.lblTempXY.TabIndex = 39
        Me.lblTempXY.Text = "0"
        '
        'lblPlayerY
        '
        Me.lblPlayerY.AutoSize = True
        Me.lblPlayerY.BackColor = System.Drawing.Color.Transparent
        Me.lblPlayerY.ForeColor = System.Drawing.Color.White
        Me.lblPlayerY.Location = New System.Drawing.Point(68, 161)
        Me.lblPlayerY.Name = "lblPlayerY"
        Me.lblPlayerY.Size = New System.Drawing.Size(13, 13)
        Me.lblPlayerY.TabIndex = 37
        Me.lblPlayerY.Text = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(116, 161)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(44, 13)
        Me.Label16.TabIndex = 38
        Me.Label16.Text = "tempXY"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(7, 161)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 13)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "playerY"
        '
        'lblStage
        '
        Me.lblStage.AutoSize = True
        Me.lblStage.BackColor = System.Drawing.Color.Transparent
        Me.lblStage.ForeColor = System.Drawing.Color.White
        Me.lblStage.Location = New System.Drawing.Point(161, 144)
        Me.lblStage.Name = "lblStage"
        Me.lblStage.Size = New System.Drawing.Size(13, 13)
        Me.lblStage.TabIndex = 34
        Me.lblStage.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(117, 144)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 13)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "stage"
        '
        'lblProjectiles
        '
        Me.lblProjectiles.AutoSize = True
        Me.lblProjectiles.BackColor = System.Drawing.Color.Transparent
        Me.lblProjectiles.ForeColor = System.Drawing.Color.White
        Me.lblProjectiles.Location = New System.Drawing.Point(68, 85)
        Me.lblProjectiles.Name = "lblProjectiles"
        Me.lblProjectiles.Size = New System.Drawing.Size(13, 13)
        Me.lblProjectiles.TabIndex = 23
        Me.lblProjectiles.Text = "0"
        '
        'lblHpDrain
        '
        Me.lblHpDrain.AutoSize = True
        Me.lblHpDrain.BackColor = System.Drawing.Color.Transparent
        Me.lblHpDrain.ForeColor = System.Drawing.Color.White
        Me.lblHpDrain.Location = New System.Drawing.Point(68, 144)
        Me.lblHpDrain.Name = "lblHpDrain"
        Me.lblHpDrain.Size = New System.Drawing.Size(13, 13)
        Me.lblHpDrain.TabIndex = 32
        Me.lblHpDrain.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(7, 144)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 13)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "hpDrain:"
        '
        'lblProgression
        '
        Me.lblProgression.AutoSize = True
        Me.lblProgression.BackColor = System.Drawing.Color.Transparent
        Me.lblProgression.ForeColor = System.Drawing.Color.White
        Me.lblProgression.Location = New System.Drawing.Point(161, 125)
        Me.lblProgression.Name = "lblProgression"
        Me.lblProgression.Size = New System.Drawing.Size(13, 13)
        Me.lblProgression.TabIndex = 30
        Me.lblProgression.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(117, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Prog"
        '
        'lblShieldStatus
        '
        Me.lblShieldStatus.AutoSize = True
        Me.lblShieldStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblShieldStatus.ForeColor = System.Drawing.Color.White
        Me.lblShieldStatus.Location = New System.Drawing.Point(161, 105)
        Me.lblShieldStatus.Name = "lblShieldStatus"
        Me.lblShieldStatus.Size = New System.Drawing.Size(13, 13)
        Me.lblShieldStatus.TabIndex = 28
        Me.lblShieldStatus.Text = "0"
        '
        'lblPaused
        '
        Me.lblPaused.AutoSize = True
        Me.lblPaused.BackColor = System.Drawing.Color.Transparent
        Me.lblPaused.ForeColor = System.Drawing.Color.White
        Me.lblPaused.Location = New System.Drawing.Point(161, 85)
        Me.lblPaused.Name = "lblPaused"
        Me.lblPaused.Size = New System.Drawing.Size(42, 13)
        Me.lblPaused.TabIndex = 26
        Me.lblPaused.Text = "paused"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(116, 105)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "SStatus"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(116, 85)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Paused"
        '
        'lblGenVar
        '
        Me.lblGenVar.AutoSize = True
        Me.lblGenVar.BackColor = System.Drawing.Color.Transparent
        Me.lblGenVar.ForeColor = System.Drawing.Color.White
        Me.lblGenVar.Location = New System.Drawing.Point(161, 65)
        Me.lblGenVar.Name = "lblGenVar"
        Me.lblGenVar.Size = New System.Drawing.Size(41, 13)
        Me.lblGenVar.TabIndex = 24
        Me.lblGenVar.Text = "genVar"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(116, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Gen"
        '
        'lblShootVar
        '
        Me.lblShootVar.AutoSize = True
        Me.lblShootVar.BackColor = System.Drawing.Color.Transparent
        Me.lblShootVar.ForeColor = System.Drawing.Color.White
        Me.lblShootVar.Location = New System.Drawing.Point(161, 45)
        Me.lblShootVar.Name = "lblShootVar"
        Me.lblShootVar.Size = New System.Drawing.Size(49, 13)
        Me.lblShootVar.TabIndex = 22
        Me.lblShootVar.Text = "shootVar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(116, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Shoot: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(116, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Shield: "
        '
        'lblShieldOn
        '
        Me.lblShieldOn.AutoSize = True
        Me.lblShieldOn.BackColor = System.Drawing.Color.Transparent
        Me.lblShieldOn.ForeColor = System.Drawing.Color.White
        Me.lblShieldOn.Location = New System.Drawing.Point(161, 25)
        Me.lblShieldOn.Name = "lblShieldOn"
        Me.lblShieldOn.Size = New System.Drawing.Size(21, 13)
        Me.lblShieldOn.TabIndex = 19
        Me.lblShieldOn.Text = "On"
        '
        'lblCharge
        '
        Me.lblCharge.AutoSize = True
        Me.lblCharge.BackColor = System.Drawing.Color.Transparent
        Me.lblCharge.ForeColor = System.Drawing.Color.White
        Me.lblCharge.Location = New System.Drawing.Point(68, 125)
        Me.lblCharge.Name = "lblCharge"
        Me.lblCharge.Size = New System.Drawing.Size(13, 13)
        Me.lblCharge.TabIndex = 18
        Me.lblCharge.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(7, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "charge"
        '
        'lblHealth
        '
        Me.lblHealth.AutoSize = True
        Me.lblHealth.BackColor = System.Drawing.Color.Transparent
        Me.lblHealth.ForeColor = System.Drawing.Color.White
        Me.lblHealth.Location = New System.Drawing.Point(68, 105)
        Me.lblHealth.Name = "lblHealth"
        Me.lblHealth.Size = New System.Drawing.Size(31, 13)
        Me.lblHealth.TabIndex = 17
        Me.lblHealth.Text = "5000"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(7, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Health: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(23, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "PosX: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(23, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "PosY: "
        '
        'lblPosX
        '
        Me.lblPosX.AutoSize = True
        Me.lblPosX.BackColor = System.Drawing.Color.Transparent
        Me.lblPosX.ForeColor = System.Drawing.Color.White
        Me.lblPosX.Location = New System.Drawing.Point(68, 25)
        Me.lblPosX.Name = "lblPosX"
        Me.lblPosX.Size = New System.Drawing.Size(42, 13)
        Me.lblPosX.TabIndex = 12
        Me.lblPosX.Text = "lblPosX"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(7, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Movement: "
        '
        'panelPause
        '
        Me.panelPause.BackColor = System.Drawing.Color.Transparent
        Me.panelPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.panelPause.Controls.Add(Me.Label17)
        Me.panelPause.Controls.Add(Me.Label18)
        Me.panelPause.Controls.Add(Me.rtbPowerDesc)
        Me.panelPause.Controls.Add(Me.rtbStageDesc)
        Me.panelPause.Controls.Add(Me.btnMenu)
        Me.panelPause.Controls.Add(Me.picPausedText)
        Me.panelPause.ForeColor = System.Drawing.SystemColors.ControlText
        Me.panelPause.Location = New System.Drawing.Point(0, 0)
        Me.panelPause.Name = "panelPause"
        Me.panelPause.Size = New System.Drawing.Size(740, 450)
        Me.panelPause.TabIndex = 37
        Me.panelPause.Visible = False
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.Transparent
        Me.btnMenu.BackgroundImage = Global.Shift.My.Resources.Resources.btnMenuUnclicked
        Me.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnMenu.Location = New System.Drawing.Point(593, 403)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(129, 26)
        Me.btnMenu.TabIndex = 18
        Me.btnMenu.TabStop = False
        '
        'picPausedText
        '
        Me.picPausedText.BackColor = System.Drawing.Color.Transparent
        Me.picPausedText.BackgroundImage = Global.Shift.My.Resources.Resources.pausedText
        Me.picPausedText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picPausedText.Location = New System.Drawing.Point(14, 16)
        Me.picPausedText.Name = "picPausedText"
        Me.picPausedText.Size = New System.Drawing.Size(298, 37)
        Me.picPausedText.TabIndex = 17
        Me.picPausedText.TabStop = False
        '
        'timerConstant
        '
        Me.timerConstant.Enabled = True
        Me.timerConstant.Interval = 10
        '
        'picHealth
        '
        Me.picHealth.BackColor = System.Drawing.Color.Transparent
        Me.picHealth.BackgroundImage = CType(resources.GetObject("picHealth.BackgroundImage"), System.Drawing.Image)
        Me.picHealth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picHealth.Location = New System.Drawing.Point(180, 5)
        Me.picHealth.Name = "picHealth"
        Me.picHealth.Size = New System.Drawing.Size(525, 30)
        Me.picHealth.TabIndex = 13
        Me.picHealth.TabStop = False
        '
        'pichealthText
        '
        Me.pichealthText.BackColor = System.Drawing.Color.Transparent
        Me.pichealthText.BackgroundImage = CType(resources.GetObject("pichealthText.BackgroundImage"), System.Drawing.Image)
        Me.pichealthText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pichealthText.Location = New System.Drawing.Point(10, 10)
        Me.pichealthText.Name = "pichealthText"
        Me.pichealthText.Size = New System.Drawing.Size(161, 21)
        Me.pichealthText.TabIndex = 12
        Me.pichealthText.TabStop = False
        '
        'picPlayer
        '
        Me.picPlayer.BackColor = System.Drawing.Color.DodgerBlue
        Me.picPlayer.Location = New System.Drawing.Point(60, 300)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(50, 50)
        Me.picPlayer.TabIndex = 4
        Me.picPlayer.TabStop = False
        '
        'picWorld
        '
        Me.picWorld.BackColor = System.Drawing.Color.White
        Me.picWorld.Location = New System.Drawing.Point(0, 350)
        Me.picWorld.Name = "picWorld"
        Me.picWorld.Size = New System.Drawing.Size(740, 100)
        Me.picWorld.TabIndex = 5
        Me.picWorld.TabStop = False
        '
        'picCharge
        '
        Me.picCharge.BackColor = System.Drawing.Color.Transparent
        Me.picCharge.BackgroundImage = CType(resources.GetObject("picCharge.BackgroundImage"), System.Drawing.Image)
        Me.picCharge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picCharge.Location = New System.Drawing.Point(640, 56)
        Me.picCharge.Name = "picCharge"
        Me.picCharge.Size = New System.Drawing.Size(40, 207)
        Me.picCharge.TabIndex = 16
        Me.picCharge.TabStop = False
        '
        'picChargeLabel
        '
        Me.picChargeLabel.BackColor = System.Drawing.Color.Transparent
        Me.picChargeLabel.BackgroundImage = CType(resources.GetObject("picChargeLabel.BackgroundImage"), System.Drawing.Image)
        Me.picChargeLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picChargeLabel.Location = New System.Drawing.Point(696, 56)
        Me.picChargeLabel.Name = "picChargeLabel"
        Me.picChargeLabel.Size = New System.Drawing.Size(30, 207)
        Me.picChargeLabel.TabIndex = 15
        Me.picChargeLabel.TabStop = False
        '
        'lblScoreTitle
        '
        Me.lblScoreTitle.AutoSize = True
        Me.lblScoreTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblScoreTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreTitle.ForeColor = System.Drawing.Color.White
        Me.lblScoreTitle.Location = New System.Drawing.Point(10, 56)
        Me.lblScoreTitle.Name = "lblScoreTitle"
        Me.lblScoreTitle.Size = New System.Drawing.Size(51, 20)
        Me.lblScoreTitle.TabIndex = 22
        Me.lblScoreTitle.Text = "Score"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.Color.Transparent
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.White
        Me.lblScore.Location = New System.Drawing.Point(70, 56)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(18, 20)
        Me.lblScore.TabIndex = 21
        Me.lblScore.Text = "0"
        '
        'lblShiftTimer
        '
        Me.lblShiftTimer.AutoSize = True
        Me.lblShiftTimer.BackColor = System.Drawing.Color.Transparent
        Me.lblShiftTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShiftTimer.ForeColor = System.Drawing.Color.White
        Me.lblShiftTimer.Location = New System.Drawing.Point(10, 76)
        Me.lblShiftTimer.Name = "lblShiftTimer"
        Me.lblShiftTimer.Size = New System.Drawing.Size(180, 20)
        Me.lblShiftTimer.TabIndex = 23
        Me.lblShiftTimer.Text = "Next Shift in 15 seconds"
        '
        'timerPower
        '
        Me.timerPower.Interval = 10
        '
        'picStage
        '
        Me.picStage.BackColor = System.Drawing.Color.Transparent
        Me.picStage.BackgroundImage = Global.Shift.My.Resources.Resources.stage0
        Me.picStage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picStage.Location = New System.Drawing.Point(11, 37)
        Me.picStage.Name = "picStage"
        Me.picStage.Size = New System.Drawing.Size(176, 15)
        Me.picStage.TabIndex = 35
        Me.picStage.TabStop = False
        '
        'timerShoot
        '
        Me.timerShoot.Enabled = True
        Me.timerShoot.Interval = 10
        '
        'rtbStageDesc
        '
        Me.rtbStageDesc.Location = New System.Drawing.Point(40, 110)
        Me.rtbStageDesc.Name = "rtbStageDesc"
        Me.rtbStageDesc.ReadOnly = True
        Me.rtbStageDesc.Size = New System.Drawing.Size(513, 103)
        Me.rtbStageDesc.TabIndex = 19
        Me.rtbStageDesc.Text = ""
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(40, 81)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 24)
        Me.Label17.TabIndex = 20
        Me.Label17.Text = "Stage"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(40, 250)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 24)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "Power"
        '
        'rtbPowerDesc
        '
        Me.rtbPowerDesc.Location = New System.Drawing.Point(40, 285)
        Me.rtbPowerDesc.Name = "rtbPowerDesc"
        Me.rtbPowerDesc.ReadOnly = True
        Me.rtbPowerDesc.Size = New System.Drawing.Size(513, 103)
        Me.rtbPowerDesc.TabIndex = 21
        Me.rtbPowerDesc.Text = ""
        '
        'gameShift
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.Shift.My.Resources.Resources.mainbg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(734, 441)
        Me.Controls.Add(Me.panelPause)
        Me.Controls.Add(Me.picStage)
        Me.Controls.Add(Me.picWorld)
        Me.Controls.Add(Me.lblShiftTimer)
        Me.Controls.Add(Me.lblScoreTitle)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.debugBox)
        Me.Controls.Add(Me.picHealth)
        Me.Controls.Add(Me.pichealthText)
        Me.Controls.Add(Me.picPlayer)
        Me.Controls.Add(Me.picCharge)
        Me.Controls.Add(Me.picChargeLabel)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(750, 480)
        Me.MinimumSize = New System.Drawing.Size(750, 480)
        Me.Name = "gameShift"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game"
        Me.debugBox.ResumeLayout(False)
        Me.debugBox.PerformLayout()
        Me.panelPause.ResumeLayout(False)
        Me.panelPause.PerformLayout()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPausedText, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHealth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pichealthText, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWorld, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCharge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChargeLabel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents picWorld As System.Windows.Forms.PictureBox
    Friend WithEvents timerWorld As System.Windows.Forms.Timer
    Friend WithEvents timerGenerate As System.Windows.Forms.Timer
    Friend WithEvents timerShield As System.Windows.Forms.Timer
    Friend WithEvents lbl13 As System.Windows.Forms.Label
    Friend WithEvents timerMove As System.Windows.Forms.Timer
    Friend WithEvents lblPosY As System.Windows.Forms.Label
    Friend WithEvents lblMovement As System.Windows.Forms.Label
    Friend WithEvents debugBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblPosX As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblHealth As System.Windows.Forms.Label
    Friend WithEvents timerConstant As System.Windows.Forms.Timer
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblCharge As System.Windows.Forms.Label
    Friend WithEvents pichealthText As System.Windows.Forms.PictureBox
    Friend WithEvents picHealth As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblShieldOn As System.Windows.Forms.Label
    Friend WithEvents picChargeLabel As System.Windows.Forms.PictureBox
    Friend WithEvents picCharge As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblShootVar As System.Windows.Forms.Label
    Friend WithEvents lblGenVar As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblPaused As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents picPausedText As System.Windows.Forms.PictureBox
    Friend WithEvents lblShieldStatus As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblScoreTitle As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblProgression As System.Windows.Forms.Label
    Friend WithEvents lblHpDrain As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblProjectiles As System.Windows.Forms.Label
    Friend WithEvents lblShiftTimer As System.Windows.Forms.Label
    Friend WithEvents timerPower As System.Windows.Forms.Timer
    Friend WithEvents lblStage As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents picStage As System.Windows.Forms.PictureBox
    Friend WithEvents lblPlayerY As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblTempXY As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents panelPause As System.Windows.Forms.Panel
    Friend WithEvents btnMenu As System.Windows.Forms.PictureBox
    Friend WithEvents timerShoot As System.Windows.Forms.Timer
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblPCD As System.Windows.Forms.Label
    Friend WithEvents rtbStageDesc As System.Windows.Forms.RichTextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents rtbPowerDesc As System.Windows.Forms.RichTextBox

End Class

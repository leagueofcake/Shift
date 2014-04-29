<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gameRewind
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gameRewind))
        Me.timerWorld = New System.Windows.Forms.Timer(Me.components)
        Me.timerGenerate = New System.Windows.Forms.Timer(Me.components)
        Me.timerCharge = New System.Windows.Forms.Timer(Me.components)
        Me.timerShield = New System.Windows.Forms.Timer(Me.components)
        Me.lblProjectiles = New System.Windows.Forms.Label()
        Me.timerMove = New System.Windows.Forms.Timer(Me.components)
        Me.lblPosY = New System.Windows.Forms.Label()
        Me.lblMovement = New System.Windows.Forms.Label()
        Me.debugBox = New System.Windows.Forms.GroupBox()
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
        Me.lblRewindLimit = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblHealth = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPosX = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.timerConstant = New System.Windows.Forms.Timer(Me.components)
        Me.picPausedText = New System.Windows.Forms.PictureBox()
        Me.picHealth = New System.Windows.Forms.PictureBox()
        Me.pichealthText = New System.Windows.Forms.PictureBox()
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.picWorld = New System.Windows.Forms.PictureBox()
        Me.picCharge = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lblScoreTitle = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.debugBox.SuspendLayout()
        CType(Me.picPausedText, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHealth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pichealthText, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWorld, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCharge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'timerCharge
        '
        Me.timerCharge.Interval = 10
        '
        'timerShield
        '
        Me.timerShield.Enabled = True
        Me.timerShield.Interval = 10
        '
        'lblProjectiles
        '
        Me.lblProjectiles.AutoSize = True
        Me.lblProjectiles.BackColor = System.Drawing.Color.Transparent
        Me.lblProjectiles.ForeColor = System.Drawing.Color.White
        Me.lblProjectiles.Location = New System.Drawing.Point(6, 85)
        Me.lblProjectiles.Name = "lblProjectiles"
        Me.lblProjectiles.Size = New System.Drawing.Size(61, 13)
        Me.lblProjectiles.TabIndex = 7
        Me.lblProjectiles.Text = "Projectiles: "
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
        Me.debugBox.Controls.Add(Me.lblRewindLimit)
        Me.debugBox.Controls.Add(Me.Label5)
        Me.debugBox.Controls.Add(Me.lblHealth)
        Me.debugBox.Controls.Add(Me.Label4)
        Me.debugBox.Controls.Add(Me.Label2)
        Me.debugBox.Controls.Add(Me.Label3)
        Me.debugBox.Controls.Add(Me.lblPosX)
        Me.debugBox.Controls.Add(Me.Label1)
        Me.debugBox.Controls.Add(Me.lblPosY)
        Me.debugBox.Controls.Add(Me.lblMovement)
        Me.debugBox.Controls.Add(Me.lblProjectiles)
        Me.debugBox.ForeColor = System.Drawing.Color.White
        Me.debugBox.Location = New System.Drawing.Point(12, 56)
        Me.debugBox.Name = "debugBox"
        Me.debugBox.Size = New System.Drawing.Size(223, 150)
        Me.debugBox.TabIndex = 11
        Me.debugBox.TabStop = False
        Me.debugBox.Text = "Debugging"
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
        'lblRewindLimit
        '
        Me.lblRewindLimit.AutoSize = True
        Me.lblRewindLimit.BackColor = System.Drawing.Color.Transparent
        Me.lblRewindLimit.ForeColor = System.Drawing.Color.White
        Me.lblRewindLimit.Location = New System.Drawing.Point(68, 125)
        Me.lblRewindLimit.Name = "lblRewindLimit"
        Me.lblRewindLimit.Size = New System.Drawing.Size(13, 13)
        Me.lblRewindLimit.TabIndex = 18
        Me.lblRewindLimit.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(7, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Rewind: "
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
        'timerConstant
        '
        Me.timerConstant.Enabled = True
        Me.timerConstant.Interval = 10
        '
        'picPausedText
        '
        Me.picPausedText.BackColor = System.Drawing.Color.Transparent
        Me.picPausedText.BackgroundImage = Global.Rewind.My.Resources.Resources.pausedText
        Me.picPausedText.Location = New System.Drawing.Point(218, 203)
        Me.picPausedText.Name = "picPausedText"
        Me.picPausedText.Size = New System.Drawing.Size(298, 37)
        Me.picPausedText.TabIndex = 17
        Me.picPausedText.TabStop = False
        Me.picPausedText.Visible = False
        '
        'picHealth
        '
        Me.picHealth.BackColor = System.Drawing.Color.Transparent
        Me.picHealth.BackgroundImage = Global.Rewind.My.Resources.Resources.healthbar20
        Me.picHealth.Location = New System.Drawing.Point(183, 8)
        Me.picHealth.Name = "picHealth"
        Me.picHealth.Size = New System.Drawing.Size(525, 30)
        Me.picHealth.TabIndex = 13
        Me.picHealth.TabStop = False
        '
        'pichealthText
        '
        Me.pichealthText.BackColor = System.Drawing.Color.Transparent
        Me.pichealthText.BackgroundImage = CType(resources.GetObject("pichealthText.BackgroundImage"), System.Drawing.Image)
        Me.pichealthText.Location = New System.Drawing.Point(12, 12)
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
        Me.picCharge.BackgroundImage = Global.Rewind.My.Resources.Resources.chargeBar0
        Me.picCharge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picCharge.Location = New System.Drawing.Point(640, 56)
        Me.picCharge.Name = "picCharge"
        Me.picCharge.Size = New System.Drawing.Size(40, 207)
        Me.picCharge.TabIndex = 16
        Me.picCharge.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(696, 56)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 207)
        Me.PictureBox3.TabIndex = 15
        Me.PictureBox3.TabStop = False
        '
        'lblScoreTitle
        '
        Me.lblScoreTitle.AutoSize = True
        Me.lblScoreTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblScoreTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreTitle.ForeColor = System.Drawing.Color.White
        Me.lblScoreTitle.Location = New System.Drawing.Point(508, 56)
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
        Me.lblScore.Location = New System.Drawing.Point(565, 56)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(18, 20)
        Me.lblScore.TabIndex = 21
        Me.lblScore.Text = "0"
        '
        'gameRewind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.Rewind.My.Resources.Resources.mainbg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(734, 441)
        Me.Controls.Add(Me.lblScoreTitle)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.picPausedText)
        Me.Controls.Add(Me.debugBox)
        Me.Controls.Add(Me.picHealth)
        Me.Controls.Add(Me.pichealthText)
        Me.Controls.Add(Me.picPlayer)
        Me.Controls.Add(Me.picWorld)
        Me.Controls.Add(Me.picCharge)
        Me.Controls.Add(Me.PictureBox3)
        Me.DoubleBuffered = True
        Me.Name = "gameRewind"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rewind"
        Me.debugBox.ResumeLayout(False)
        Me.debugBox.PerformLayout()
        CType(Me.picPausedText, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHealth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pichealthText, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWorld, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCharge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents picWorld As System.Windows.Forms.PictureBox
    Friend WithEvents timerWorld As System.Windows.Forms.Timer
    Friend WithEvents timerGenerate As System.Windows.Forms.Timer
    Friend WithEvents timerCharge As System.Windows.Forms.Timer
    Friend WithEvents timerShield As System.Windows.Forms.Timer
    Friend WithEvents lblProjectiles As System.Windows.Forms.Label
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
    Friend WithEvents lblRewindLimit As System.Windows.Forms.Label
    Friend WithEvents pichealthText As System.Windows.Forms.PictureBox
    Friend WithEvents picHealth As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblShieldOn As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
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

End Class

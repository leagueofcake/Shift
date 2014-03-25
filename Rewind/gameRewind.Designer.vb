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
        Me.timerWorld = New System.Windows.Forms.Timer(Me.components)
        Me.timerGenerate = New System.Windows.Forms.Timer(Me.components)
        Me.timerCharge = New System.Windows.Forms.Timer(Me.components)
        Me.timerShield = New System.Windows.Forms.Timer(Me.components)
        Me.lblProjectiles = New System.Windows.Forms.Label()
        Me.timerMove = New System.Windows.Forms.Timer(Me.components)
        Me.lblPosY = New System.Windows.Forms.Label()
        Me.lblMovement = New System.Windows.Forms.Label()
        Me.debugBox = New System.Windows.Forms.GroupBox()
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
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.picHealth = New System.Windows.Forms.PictureBox()
        Me.pichealthText = New System.Windows.Forms.PictureBox()
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.picWorld = New System.Windows.Forms.PictureBox()
        Me.picCharge = New System.Windows.Forms.PictureBox()
        Me.lblGenVar = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.debugBox.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHealth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pichealthText, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWorld, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCharge, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.timerShield.Interval = 2000
        '
        'lblProjectiles
        '
        Me.lblProjectiles.AutoSize = True
        Me.lblProjectiles.BackColor = System.Drawing.Color.Transparent
        Me.lblProjectiles.ForeColor = System.Drawing.Color.Black
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
        Me.lblPosY.ForeColor = System.Drawing.Color.Black
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
        Me.lblMovement.ForeColor = System.Drawing.Color.Black
        Me.lblMovement.Location = New System.Drawing.Point(68, 65)
        Me.lblMovement.Name = "lblMovement"
        Me.lblMovement.Size = New System.Drawing.Size(49, 13)
        Me.lblMovement.TabIndex = 10
        Me.lblMovement.Text = "Direction"
        '
        'debugBox
        '
        Me.debugBox.BackColor = System.Drawing.SystemColors.Control
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
        Me.debugBox.ForeColor = System.Drawing.Color.Black
        Me.debugBox.Location = New System.Drawing.Point(12, 48)
        Me.debugBox.Name = "debugBox"
        Me.debugBox.Size = New System.Drawing.Size(223, 150)
        Me.debugBox.TabIndex = 11
        Me.debugBox.TabStop = False
        Me.debugBox.Text = "Debugging"
        '
        'lblShootVar
        '
        Me.lblShootVar.AutoSize = True
        Me.lblShootVar.BackColor = System.Drawing.Color.Transparent
        Me.lblShootVar.ForeColor = System.Drawing.Color.Black
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
        Me.Label7.ForeColor = System.Drawing.Color.Black
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
        Me.Label6.ForeColor = System.Drawing.Color.Black
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
        Me.lblShieldOn.ForeColor = System.Drawing.Color.Black
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
        Me.lblRewindLimit.ForeColor = System.Drawing.Color.Black
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
        Me.Label5.ForeColor = System.Drawing.Color.Black
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
        Me.lblHealth.ForeColor = System.Drawing.Color.Black
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
        Me.Label4.ForeColor = System.Drawing.Color.Black
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
        Me.Label2.ForeColor = System.Drawing.Color.Black
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
        Me.Label3.ForeColor = System.Drawing.Color.Black
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
        Me.lblPosX.ForeColor = System.Drawing.Color.Black
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
        Me.Label1.ForeColor = System.Drawing.Color.Black
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
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.Rewind.My.Resources.Resources.chargeText
        Me.PictureBox3.Location = New System.Drawing.Point(711, 56)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(21, 180)
        Me.PictureBox3.TabIndex = 15
        Me.PictureBox3.TabStop = False
        '
        'picHealth
        '
        Me.picHealth.BackColor = System.Drawing.Color.Transparent
        Me.picHealth.BackgroundImage = Global.Rewind.My.Resources.Resources.healthbar20
        Me.picHealth.Location = New System.Drawing.Point(135, 12)
        Me.picHealth.Name = "picHealth"
        Me.picHealth.Size = New System.Drawing.Size(525, 30)
        Me.picHealth.TabIndex = 13
        Me.picHealth.TabStop = False
        '
        'pichealthText
        '
        Me.pichealthText.BackColor = System.Drawing.Color.Transparent
        Me.pichealthText.BackgroundImage = Global.Rewind.My.Resources.Resources.healthText
        Me.pichealthText.Location = New System.Drawing.Point(12, 12)
        Me.pichealthText.Name = "pichealthText"
        Me.pichealthText.Size = New System.Drawing.Size(113, 27)
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
        Me.picWorld.Size = New System.Drawing.Size(741, 100)
        Me.picWorld.TabIndex = 5
        Me.picWorld.TabStop = False
        '
        'picCharge
        '
        Me.picCharge.BackColor = System.Drawing.Color.Transparent
        Me.picCharge.BackgroundImage = Global.Rewind.My.Resources.Resources.chargeBar0
        Me.picCharge.Location = New System.Drawing.Point(655, 56)
        Me.picCharge.Name = "picCharge"
        Me.picCharge.Size = New System.Drawing.Size(40, 236)
        Me.picCharge.TabIndex = 16
        Me.picCharge.TabStop = False
        '
        'lblGenVar
        '
        Me.lblGenVar.AutoSize = True
        Me.lblGenVar.BackColor = System.Drawing.Color.Transparent
        Me.lblGenVar.ForeColor = System.Drawing.Color.Black
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
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(116, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Gen"
        '
        'gameRewind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(734, 442)
        Me.Controls.Add(Me.picHealth)
        Me.Controls.Add(Me.pichealthText)
        Me.Controls.Add(Me.debugBox)
        Me.Controls.Add(Me.picPlayer)
        Me.Controls.Add(Me.picWorld)
        Me.Controls.Add(Me.picCharge)
        Me.Controls.Add(Me.PictureBox3)
        Me.Name = "gameRewind"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rewind"
        Me.debugBox.ResumeLayout(False)
        Me.debugBox.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHealth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pichealthText, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWorld, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCharge, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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

End Class

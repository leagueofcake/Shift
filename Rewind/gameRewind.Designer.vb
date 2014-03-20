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
        Me.chargeBar = New System.Windows.Forms.ProgressBar()
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.picWorld = New System.Windows.Forms.PictureBox()
        Me.timerWorld = New System.Windows.Forms.Timer(Me.components)
        Me.timerGenerate = New System.Windows.Forms.Timer(Me.components)
        Me.timerCharge = New System.Windows.Forms.Timer(Me.components)
        Me.timerRewind = New System.Windows.Forms.Timer(Me.components)
        Me.timerShield = New System.Windows.Forms.Timer(Me.components)
        Me.lblProjectiles = New System.Windows.Forms.Label()
        Me.timerMove = New System.Windows.Forms.Timer(Me.components)
        Me.lblPosY = New System.Windows.Forms.Label()
        Me.healthBar = New System.Windows.Forms.ProgressBar()
        Me.lblMovement = New System.Windows.Forms.Label()
        Me.debugBox = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPosX = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWorld, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.debugBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'chargeBar
        '
        Me.chargeBar.Location = New System.Drawing.Point(523, 388)
        Me.chargeBar.MarqueeAnimationSpeed = 10
        Me.chargeBar.Maximum = 300
        Me.chargeBar.Name = "chargeBar"
        Me.chargeBar.Size = New System.Drawing.Size(100, 23)
        Me.chargeBar.Step = 1
        Me.chargeBar.TabIndex = 6
        '
        'picPlayer
        '
        Me.picPlayer.BackColor = System.Drawing.Color.DodgerBlue
        Me.picPlayer.Location = New System.Drawing.Point(80, 300)
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
        Me.picWorld.Size = New System.Drawing.Size(665, 100)
        Me.picWorld.TabIndex = 5
        Me.picWorld.TabStop = False
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
        'timerRewind
        '
        Me.timerRewind.Interval = 10
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
        Me.lblProjectiles.Location = New System.Drawing.Point(7, 88)
        Me.lblProjectiles.Name = "lblProjectiles"
        Me.lblProjectiles.Size = New System.Drawing.Size(61, 13)
        Me.lblProjectiles.TabIndex = 7
        Me.lblProjectiles.Text = "Projectiles: "
        '
        'timerMove
        '
        Me.timerMove.Enabled = True
        Me.timerMove.Interval = 20
        '
        'lblPosY
        '
        Me.lblPosY.AutoSize = True
        Me.lblPosY.BackColor = System.Drawing.Color.Transparent
        Me.lblPosY.ForeColor = System.Drawing.Color.Black
        Me.lblPosY.Location = New System.Drawing.Point(68, 43)
        Me.lblPosY.Name = "lblPosY"
        Me.lblPosY.Size = New System.Drawing.Size(42, 13)
        Me.lblPosY.TabIndex = 8
        Me.lblPosY.Text = "lblPosY"
        '
        'healthBar
        '
        Me.healthBar.Location = New System.Drawing.Point(30, 29)
        Me.healthBar.MarqueeAnimationSpeed = 10
        Me.healthBar.Maximum = 500
        Me.healthBar.Name = "healthBar"
        Me.healthBar.Size = New System.Drawing.Size(100, 23)
        Me.healthBar.TabIndex = 9
        Me.healthBar.Value = 500
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
        Me.debugBox.Controls.Add(Me.Label2)
        Me.debugBox.Controls.Add(Me.Label3)
        Me.debugBox.Controls.Add(Me.lblPosX)
        Me.debugBox.Controls.Add(Me.Label1)
        Me.debugBox.Controls.Add(Me.lblPosY)
        Me.debugBox.Controls.Add(Me.lblMovement)
        Me.debugBox.Controls.Add(Me.lblProjectiles)
        Me.debugBox.ForeColor = System.Drawing.Color.Black
        Me.debugBox.Location = New System.Drawing.Point(452, 12)
        Me.debugBox.Name = "debugBox"
        Me.debugBox.Size = New System.Drawing.Size(200, 145)
        Me.debugBox.TabIndex = 11
        Me.debugBox.TabStop = False
        Me.debugBox.Text = "Debugging"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(7, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Movement"
        '
        'lblPosX
        '
        Me.lblPosX.AutoSize = True
        Me.lblPosX.BackColor = System.Drawing.Color.Transparent
        Me.lblPosX.ForeColor = System.Drawing.Color.Black
        Me.lblPosX.Location = New System.Drawing.Point(68, 27)
        Me.lblPosX.Name = "lblPosX"
        Me.lblPosX.Size = New System.Drawing.Size(42, 13)
        Me.lblPosX.TabIndex = 12
        Me.lblPosX.Text = "lblPosX"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(23, 27)
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
        Me.Label3.Location = New System.Drawing.Point(23, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "PosY: "
        '
        'gameRewind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(664, 442)
        Me.Controls.Add(Me.debugBox)
        Me.Controls.Add(Me.healthBar)
        Me.Controls.Add(Me.chargeBar)
        Me.Controls.Add(Me.picPlayer)
        Me.Controls.Add(Me.picWorld)
        Me.Name = "gameRewind"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rewind"
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWorld, System.ComponentModel.ISupportInitialize).EndInit()
        Me.debugBox.ResumeLayout(False)
        Me.debugBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chargeBar As System.Windows.Forms.ProgressBar
    Friend WithEvents picPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents picWorld As System.Windows.Forms.PictureBox
    Friend WithEvents timerWorld As System.Windows.Forms.Timer
    Friend WithEvents timerGenerate As System.Windows.Forms.Timer
    Friend WithEvents timerCharge As System.Windows.Forms.Timer
    Friend WithEvents timerRewind As System.Windows.Forms.Timer
    Friend WithEvents timerShield As System.Windows.Forms.Timer
    Friend WithEvents lblProjectiles As System.Windows.Forms.Label
    Friend WithEvents timerMove As System.Windows.Forms.Timer
    Friend WithEvents lblPosY As System.Windows.Forms.Label
    Friend WithEvents healthBar As System.Windows.Forms.ProgressBar
    Friend WithEvents lblMovement As System.Windows.Forms.Label
    Friend WithEvents debugBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblPosX As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class

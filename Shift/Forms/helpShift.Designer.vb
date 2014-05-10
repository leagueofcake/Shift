<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class helpShift
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
        Me.btnGameInfo = New System.Windows.Forms.PictureBox()
        Me.btnControls = New System.Windows.Forms.PictureBox()
        Me.lblGame0 = New System.Windows.Forms.Label()
        Me.picPlayerBlue = New System.Windows.Forms.PictureBox()
        Me.picPlayerGreen = New System.Windows.Forms.PictureBox()
        Me.lblGame1 = New System.Windows.Forms.Label()
        Me.picProjectile = New System.Windows.Forms.PictureBox()
        Me.lblGame2 = New System.Windows.Forms.Label()
        Me.lblGame3 = New System.Windows.Forms.Label()
        Me.lblGame4 = New System.Windows.Forms.Label()
        Me.picKeyUp = New System.Windows.Forms.PictureBox()
        Me.picKeyLeft = New System.Windows.Forms.PictureBox()
        Me.picKeyRight = New System.Windows.Forms.PictureBox()
        Me.picKeySpace = New System.Windows.Forms.PictureBox()
        Me.lblControl0 = New System.Windows.Forms.Label()
        Me.lblControl1 = New System.Windows.Forms.Label()
        Me.lblControl2 = New System.Windows.Forms.Label()
        Me.lblControl3 = New System.Windows.Forms.Label()
        CType(Me.btnGameInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnControls, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayerBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayerGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picProjectile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKeyUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKeyLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKeyRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKeySpace, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGameInfo
        '
        Me.btnGameInfo.BackColor = System.Drawing.Color.Transparent
        Me.btnGameInfo.BackgroundImage = Global.Shift.My.Resources.Resources.btnGameInfoClicked
        Me.btnGameInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnGameInfo.Location = New System.Drawing.Point(32, 170)
        Me.btnGameInfo.Name = "btnGameInfo"
        Me.btnGameInfo.Size = New System.Drawing.Size(255, 26)
        Me.btnGameInfo.TabIndex = 0
        Me.btnGameInfo.TabStop = False
        '
        'btnControls
        '
        Me.btnControls.BackColor = System.Drawing.Color.Transparent
        Me.btnControls.BackgroundImage = Global.Shift.My.Resources.Resources.btnControlsHover
        Me.btnControls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnControls.Location = New System.Drawing.Point(32, 244)
        Me.btnControls.Name = "btnControls"
        Me.btnControls.Size = New System.Drawing.Size(255, 26)
        Me.btnControls.TabIndex = 1
        Me.btnControls.TabStop = False
        '
        'lblGame0
        '
        Me.lblGame0.AutoSize = True
        Me.lblGame0.BackColor = System.Drawing.Color.Transparent
        Me.lblGame0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGame0.ForeColor = System.Drawing.Color.White
        Me.lblGame0.Location = New System.Drawing.Point(435, 145)
        Me.lblGame0.Name = "lblGame0"
        Me.lblGame0.Size = New System.Drawing.Size(78, 16)
        Me.lblGame0.TabIndex = 2
        Me.lblGame0.Text = "This is you. "
        '
        'picPlayerBlue
        '
        Me.picPlayerBlue.BackColor = System.Drawing.Color.DodgerBlue
        Me.picPlayerBlue.Location = New System.Drawing.Point(365, 128)
        Me.picPlayerBlue.Name = "picPlayerBlue"
        Me.picPlayerBlue.Size = New System.Drawing.Size(50, 50)
        Me.picPlayerBlue.TabIndex = 3
        Me.picPlayerBlue.TabStop = False
        '
        'picPlayerGreen
        '
        Me.picPlayerGreen.BackColor = System.Drawing.Color.Green
        Me.picPlayerGreen.Location = New System.Drawing.Point(365, 194)
        Me.picPlayerGreen.Name = "picPlayerGreen"
        Me.picPlayerGreen.Size = New System.Drawing.Size(50, 50)
        Me.picPlayerGreen.TabIndex = 4
        Me.picPlayerGreen.TabStop = False
        '
        'lblGame1
        '
        Me.lblGame1.AutoSize = True
        Me.lblGame1.BackColor = System.Drawing.Color.Transparent
        Me.lblGame1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGame1.ForeColor = System.Drawing.Color.White
        Me.lblGame1.Location = New System.Drawing.Point(435, 214)
        Me.lblGame1.Name = "lblGame1"
        Me.lblGame1.Size = New System.Drawing.Size(156, 16)
        Me.lblGame1.TabIndex = 5
        Me.lblGame1.Text = "This is you, with a shield! "
        '
        'picProjectile
        '
        Me.picProjectile.BackColor = System.Drawing.Color.Transparent
        Me.picProjectile.BackgroundImage = Global.Shift.My.Resources.Resources.projectile
        Me.picProjectile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picProjectile.Location = New System.Drawing.Point(368, 285)
        Me.picProjectile.Name = "picProjectile"
        Me.picProjectile.Size = New System.Drawing.Size(30, 30)
        Me.picProjectile.TabIndex = 6
        Me.picProjectile.TabStop = False
        '
        'lblGame2
        '
        Me.lblGame2.AutoSize = True
        Me.lblGame2.BackColor = System.Drawing.Color.Transparent
        Me.lblGame2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGame2.ForeColor = System.Drawing.Color.White
        Me.lblGame2.Location = New System.Drawing.Point(435, 273)
        Me.lblGame2.Name = "lblGame2"
        Me.lblGame2.Size = New System.Drawing.Size(211, 16)
        Me.lblGame2.TabIndex = 7
        Me.lblGame2.Text = "Your best friend and worst enemy. "
        '
        'lblGame3
        '
        Me.lblGame3.AutoSize = True
        Me.lblGame3.BackColor = System.Drawing.Color.Transparent
        Me.lblGame3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGame3.ForeColor = System.Drawing.Color.White
        Me.lblGame3.Location = New System.Drawing.Point(435, 299)
        Me.lblGame3.Name = "lblGame3"
        Me.lblGame3.Size = New System.Drawing.Size(265, 16)
        Me.lblGame3.TabIndex = 8
        Me.lblGame3.Text = "Hit one with your shield on to restore health. "
        '
        'lblGame4
        '
        Me.lblGame4.AutoSize = True
        Me.lblGame4.BackColor = System.Drawing.Color.Transparent
        Me.lblGame4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGame4.ForeColor = System.Drawing.Color.White
        Me.lblGame4.Location = New System.Drawing.Point(435, 322)
        Me.lblGame4.Name = "lblGame4"
        Me.lblGame4.Size = New System.Drawing.Size(265, 16)
        Me.lblGame4.TabIndex = 9
        Me.lblGame4.Text = "Hit one without, and it'll drain health instead. "
        '
        'picKeyUp
        '
        Me.picKeyUp.BackColor = System.Drawing.Color.Transparent
        Me.picKeyUp.BackgroundImage = Global.Shift.My.Resources.Resources.keyUp
        Me.picKeyUp.Location = New System.Drawing.Point(596, 160)
        Me.picKeyUp.Name = "picKeyUp"
        Me.picKeyUp.Size = New System.Drawing.Size(50, 50)
        Me.picKeyUp.TabIndex = 10
        Me.picKeyUp.TabStop = False
        Me.picKeyUp.Visible = False
        '
        'picKeyLeft
        '
        Me.picKeyLeft.BackColor = System.Drawing.Color.Transparent
        Me.picKeyLeft.BackgroundImage = Global.Shift.My.Resources.Resources.keyLeft
        Me.picKeyLeft.Location = New System.Drawing.Point(546, 217)
        Me.picKeyLeft.Name = "picKeyLeft"
        Me.picKeyLeft.Size = New System.Drawing.Size(50, 50)
        Me.picKeyLeft.TabIndex = 11
        Me.picKeyLeft.TabStop = False
        Me.picKeyLeft.Visible = False
        '
        'picKeyRight
        '
        Me.picKeyRight.BackColor = System.Drawing.Color.Transparent
        Me.picKeyRight.BackgroundImage = Global.Shift.My.Resources.Resources.keyRight
        Me.picKeyRight.Location = New System.Drawing.Point(644, 217)
        Me.picKeyRight.Name = "picKeyRight"
        Me.picKeyRight.Size = New System.Drawing.Size(50, 50)
        Me.picKeyRight.TabIndex = 12
        Me.picKeyRight.TabStop = False
        Me.picKeyRight.Visible = False
        '
        'picKeySpace
        '
        Me.picKeySpace.BackColor = System.Drawing.Color.Transparent
        Me.picKeySpace.BackgroundImage = Global.Shift.My.Resources.Resources.keySpace
        Me.picKeySpace.Location = New System.Drawing.Point(324, 217)
        Me.picKeySpace.Name = "picKeySpace"
        Me.picKeySpace.Size = New System.Drawing.Size(150, 50)
        Me.picKeySpace.TabIndex = 13
        Me.picKeySpace.TabStop = False
        Me.picKeySpace.Visible = False
        '
        'lblControl0
        '
        Me.lblControl0.AutoSize = True
        Me.lblControl0.BackColor = System.Drawing.Color.Transparent
        Me.lblControl0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblControl0.ForeColor = System.Drawing.Color.White
        Me.lblControl0.Location = New System.Drawing.Point(321, 270)
        Me.lblControl0.Name = "lblControl0"
        Me.lblControl0.Size = New System.Drawing.Size(107, 16)
        Me.lblControl0.TabIndex = 14
        Me.lblControl0.Text = "Charge powerup"
        Me.lblControl0.Visible = False
        '
        'lblControl1
        '
        Me.lblControl1.AutoSize = True
        Me.lblControl1.BackColor = System.Drawing.Color.Transparent
        Me.lblControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblControl1.ForeColor = System.Drawing.Color.White
        Me.lblControl1.Location = New System.Drawing.Point(652, 160)
        Me.lblControl1.Name = "lblControl1"
        Me.lblControl1.Size = New System.Drawing.Size(63, 16)
        Me.lblControl1.TabIndex = 15
        Me.lblControl1.Text = "Move Up"
        Me.lblControl1.Visible = False
        '
        'lblControl2
        '
        Me.lblControl2.AutoSize = True
        Me.lblControl2.BackColor = System.Drawing.Color.Transparent
        Me.lblControl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblControl2.ForeColor = System.Drawing.Color.White
        Me.lblControl2.Location = New System.Drawing.Point(533, 270)
        Me.lblControl2.Name = "lblControl2"
        Me.lblControl2.Size = New System.Drawing.Size(66, 16)
        Me.lblControl2.TabIndex = 16
        Me.lblControl2.Text = "Move Left"
        Me.lblControl2.Visible = False
        '
        'lblControl3
        '
        Me.lblControl3.AutoSize = True
        Me.lblControl3.BackColor = System.Drawing.Color.Transparent
        Me.lblControl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblControl3.ForeColor = System.Drawing.Color.White
        Me.lblControl3.Location = New System.Drawing.Point(641, 270)
        Me.lblControl3.Name = "lblControl3"
        Me.lblControl3.Size = New System.Drawing.Size(76, 16)
        Me.lblControl3.TabIndex = 17
        Me.lblControl3.Text = "Move Right"
        Me.lblControl3.Visible = False
        '
        'helpShift
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Shift.My.Resources.Resources.mainbg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(734, 441)
        Me.Controls.Add(Me.lblControl1)
        Me.Controls.Add(Me.lblGame4)
        Me.Controls.Add(Me.lblGame3)
        Me.Controls.Add(Me.lblGame2)
        Me.Controls.Add(Me.picProjectile)
        Me.Controls.Add(Me.lblGame1)
        Me.Controls.Add(Me.picPlayerGreen)
        Me.Controls.Add(Me.picPlayerBlue)
        Me.Controls.Add(Me.lblGame0)
        Me.Controls.Add(Me.btnControls)
        Me.Controls.Add(Me.btnGameInfo)
        Me.Controls.Add(Me.lblControl3)
        Me.Controls.Add(Me.lblControl2)
        Me.Controls.Add(Me.lblControl0)
        Me.Controls.Add(Me.picKeySpace)
        Me.Controls.Add(Me.picKeyRight)
        Me.Controls.Add(Me.picKeyLeft)
        Me.Controls.Add(Me.picKeyUp)
        Me.DoubleBuffered = True
        Me.Name = "helpShift"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "helpShift"
        CType(Me.btnGameInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnControls, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayerBlue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayerGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picProjectile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKeyUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKeyLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKeyRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKeySpace, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGameInfo As System.Windows.Forms.PictureBox
    Friend WithEvents btnControls As System.Windows.Forms.PictureBox
    Friend WithEvents lblGame0 As System.Windows.Forms.Label
    Friend WithEvents picPlayerBlue As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayerGreen As System.Windows.Forms.PictureBox
    Friend WithEvents lblGame1 As System.Windows.Forms.Label
    Friend WithEvents picProjectile As System.Windows.Forms.PictureBox
    Friend WithEvents lblGame2 As System.Windows.Forms.Label
    Friend WithEvents lblGame3 As System.Windows.Forms.Label
    Friend WithEvents lblGame4 As System.Windows.Forms.Label
    Friend WithEvents picKeyUp As System.Windows.Forms.PictureBox
    Friend WithEvents picKeyLeft As System.Windows.Forms.PictureBox
    Friend WithEvents picKeyRight As System.Windows.Forms.PictureBox
    Friend WithEvents picKeySpace As System.Windows.Forms.PictureBox
    Friend WithEvents lblControl0 As System.Windows.Forms.Label
    Friend WithEvents lblControl1 As System.Windows.Forms.Label
    Friend WithEvents lblControl2 As System.Windows.Forms.Label
    Friend WithEvents lblControl3 As System.Windows.Forms.Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainShift
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainShift))
        Me.btnPlay = New System.Windows.Forms.PictureBox()
        Me.btnHelp = New System.Windows.Forms.PictureBox()
        Me.gameLogo = New System.Windows.Forms.PictureBox()
        Me.btnOptions = New System.Windows.Forms.PictureBox()
        Me.btnTutorial = New System.Windows.Forms.PictureBox()
        CType(Me.btnPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gameLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnTutorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.Color.Transparent
        Me.btnPlay.BackgroundImage = Global.Shift.My.Resources.Resources.btnPlayClicked
        Me.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnPlay.Location = New System.Drawing.Point(267, 170)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(200, 39)
        Me.btnPlay.TabIndex = 1
        Me.btnPlay.TabStop = False
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.Transparent
        Me.btnHelp.BackgroundImage = CType(resources.GetObject("btnHelp.BackgroundImage"), System.Drawing.Image)
        Me.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnHelp.Location = New System.Drawing.Point(307, 330)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(121, 26)
        Me.btnHelp.TabIndex = 2
        Me.btnHelp.TabStop = False
        '
        'gameLogo
        '
        Me.gameLogo.BackColor = System.Drawing.Color.Transparent
        Me.gameLogo.BackgroundImage = CType(resources.GetObject("gameLogo.BackgroundImage"), System.Drawing.Image)
        Me.gameLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.gameLogo.Location = New System.Drawing.Point(76, 39)
        Me.gameLogo.Name = "gameLogo"
        Me.gameLogo.Size = New System.Drawing.Size(582, 104)
        Me.gameLogo.TabIndex = 3
        Me.gameLogo.TabStop = False
        '
        'btnOptions
        '
        Me.btnOptions.BackColor = System.Drawing.Color.Transparent
        Me.btnOptions.BackgroundImage = Global.Shift.My.Resources.Resources.btnOptionsUnclicked
        Me.btnOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnOptions.Location = New System.Drawing.Point(265, 230)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(204, 26)
        Me.btnOptions.TabIndex = 4
        Me.btnOptions.TabStop = False
        '
        'btnTutorial
        '
        Me.btnTutorial.BackColor = System.Drawing.Color.Transparent
        Me.btnTutorial.BackgroundImage = Global.Shift.My.Resources.Resources.btnTutorialUnclicked
        Me.btnTutorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnTutorial.Location = New System.Drawing.Point(250, 280)
        Me.btnTutorial.Name = "btnTutorial"
        Me.btnTutorial.Size = New System.Drawing.Size(234, 26)
        Me.btnTutorial.TabIndex = 5
        Me.btnTutorial.TabStop = False
        '
        'mainShift
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Shift.My.Resources.Resources.mainbg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(734, 441)
        Me.Controls.Add(Me.btnTutorial)
        Me.Controls.Add(Me.btnOptions)
        Me.Controls.Add(Me.gameLogo)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnPlay)
        Me.DoubleBuffered = True
        Me.Name = "mainShift"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mainShift"
        CType(Me.btnPlay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnHelp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gameLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnOptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnTutorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPlay As System.Windows.Forms.PictureBox
    Friend WithEvents btnHelp As System.Windows.Forms.PictureBox
    Friend WithEvents gameLogo As System.Windows.Forms.PictureBox
    Friend WithEvents btnOptions As System.Windows.Forms.PictureBox
    Friend WithEvents btnTutorial As System.Windows.Forms.PictureBox
End Class

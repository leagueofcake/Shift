<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class endScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(endScreen))
        Me.lblScore = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnMenu = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.Color.Transparent
        Me.lblScore.Location = New System.Drawing.Point(244, 92)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(47, 13)
        Me.lblScore.TabIndex = 1
        Me.lblScore.Text = "Score: 0"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Location = New System.Drawing.Point(46, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(456, 41)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.Transparent
        Me.btnMenu.BackgroundImage = Global.Shift.My.Resources.Resources.btnMenuUnclicked
        Me.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnMenu.Location = New System.Drawing.Point(46, 200)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(129, 26)
        Me.btnMenu.TabIndex = 4
        Me.btnMenu.TabStop = False
        '
        'endScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Shift.My.Resources.Resources.mainbg
        Me.ClientSize = New System.Drawing.Size(548, 262)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblScore)
        Me.Name = "endScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game Over! "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnMenu As System.Windows.Forms.PictureBox
End Class

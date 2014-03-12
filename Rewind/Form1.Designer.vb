<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.timerShoot = New System.Windows.Forms.Timer(Me.components)
        Me.timerGenerate = New System.Windows.Forms.Timer(Me.components)
        Me.timerCharge = New System.Windows.Forms.Timer(Me.components)
        Me.timerRewind = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chargeBar
        '
        Me.chargeBar.Location = New System.Drawing.Point(504, 87)
        Me.chargeBar.MarqueeAnimationSpeed = 10
        Me.chargeBar.Maximum = 500
        Me.chargeBar.Name = "chargeBar"
        Me.chargeBar.Size = New System.Drawing.Size(100, 23)
        Me.chargeBar.TabIndex = 6
        '
        'picPlayer
        '
        Me.picPlayer.BackColor = System.Drawing.Color.Sienna
        Me.picPlayer.Location = New System.Drawing.Point(70, 300)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(50, 50)
        Me.picPlayer.TabIndex = 4
        Me.picPlayer.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(0, 350)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(665, 100)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'timerShoot
        '
        Me.timerShoot.Enabled = True
        Me.timerShoot.Interval = 10
        '
        'timerGenerate
        '
        Me.timerGenerate.Enabled = True
        Me.timerGenerate.Interval = 500
        '
        'timerCharge
        '
        Me.timerCharge.Enabled = True
        Me.timerCharge.Interval = 10
        '
        'timerRewind
        '
        Me.timerRewind.Interval = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 442)
        Me.Controls.Add(Me.chargeBar)
        Me.Controls.Add(Me.picPlayer)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Rewind"
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chargeBar As System.Windows.Forms.ProgressBar
    Friend WithEvents picPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents timerShoot As System.Windows.Forms.Timer
    Friend WithEvents timerGenerate As System.Windows.Forms.Timer
    Friend WithEvents timerCharge As System.Windows.Forms.Timer
    Friend WithEvents timerRewind As System.Windows.Forms.Timer

End Class

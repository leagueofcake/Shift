<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class helpRewind
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
        CType(Me.btnGameInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnControls, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGameInfo
        '
        Me.btnGameInfo.BackColor = System.Drawing.Color.Transparent
        Me.btnGameInfo.BackgroundImage = Global.Rewind.My.Resources.Resources.btnGameInfoClicked
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
        Me.btnControls.BackgroundImage = Global.Rewind.My.Resources.Resources.btnControlsHover
        Me.btnControls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnControls.Location = New System.Drawing.Point(32, 244)
        Me.btnControls.Name = "btnControls"
        Me.btnControls.Size = New System.Drawing.Size(255, 26)
        Me.btnControls.TabIndex = 1
        Me.btnControls.TabStop = False
        '
        'helpRewind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Rewind.My.Resources.Resources.mainbg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(734, 441)
        Me.Controls.Add(Me.btnControls)
        Me.Controls.Add(Me.btnGameInfo)
        Me.DoubleBuffered = True
        Me.Name = "helpRewind"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "helpRewind"
        CType(Me.btnGameInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnControls, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGameInfo As System.Windows.Forms.PictureBox
    Friend WithEvents btnControls As System.Windows.Forms.PictureBox
End Class

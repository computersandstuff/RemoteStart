<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Me.AboutTitle = New System.Windows.Forms.Label()
        Me.AboutLabel2 = New System.Windows.Forms.Label()
        Me.AboutLabel3 = New System.Windows.Forms.Label()
        Me.AboutLabel4 = New System.Windows.Forms.Label()
        Me.AboutYouTubeClick = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'AboutTitle
        '
        Me.AboutTitle.AutoSize = True
        Me.AboutTitle.Location = New System.Drawing.Point(12, 9)
        Me.AboutTitle.Name = "AboutTitle"
        Me.AboutTitle.Size = New System.Drawing.Size(66, 13)
        Me.AboutTitle.TabIndex = 0
        Me.AboutTitle.Text = "RemoteStart"
        '
        'AboutLabel2
        '
        Me.AboutLabel2.AutoSize = True
        Me.AboutLabel2.Location = New System.Drawing.Point(12, 22)
        Me.AboutLabel2.Name = "AboutLabel2"
        Me.AboutLabel2.Size = New System.Drawing.Size(75, 13)
        Me.AboutLabel2.TabIndex = 1
        Me.AboutLabel2.Text = "Prerelease 0.1"
        '
        'AboutLabel3
        '
        Me.AboutLabel3.AutoSize = True
        Me.AboutLabel3.Location = New System.Drawing.Point(12, 35)
        Me.AboutLabel3.Name = "AboutLabel3"
        Me.AboutLabel3.Size = New System.Drawing.Size(163, 13)
        Me.AboutLabel3.TabIndex = 2
        Me.AboutLabel3.Text = "A project by Computers And Stuff"
        '
        'AboutLabel4
        '
        Me.AboutLabel4.Location = New System.Drawing.Point(12, 57)
        Me.AboutLabel4.Name = "AboutLabel4"
        Me.AboutLabel4.Size = New System.Drawing.Size(163, 89)
        Me.AboutLabel4.TabIndex = 3
        Me.AboutLabel4.Text = "This release is a concept of this program. As of the programming of this release " &
    "I do not have a webpage on this software. My YouTube channel is here: "
        '
        'AboutYouTubeClick
        '
        Me.AboutYouTubeClick.AutoSize = True
        Me.AboutYouTubeClick.Location = New System.Drawing.Point(12, 133)
        Me.AboutYouTubeClick.Name = "AboutYouTubeClick"
        Me.AboutYouTubeClick.Size = New System.Drawing.Size(157, 13)
        Me.AboutYouTubeClick.TabIndex = 4
        Me.AboutYouTubeClick.TabStop = True
        Me.AboutYouTubeClick.Text = "Computers And Stuff (YouTube)"
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(207, 168)
        Me.Controls.Add(Me.AboutYouTubeClick)
        Me.Controls.Add(Me.AboutLabel4)
        Me.Controls.Add(Me.AboutLabel3)
        Me.Controls.Add(Me.AboutLabel2)
        Me.Controls.Add(Me.AboutTitle)
        Me.Name = "About"
        Me.Text = "About"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AboutTitle As Label
    Friend WithEvents AboutLabel2 As Label
    Friend WithEvents AboutLabel3 As Label
    Friend WithEvents AboutLabel4 As Label
    Friend WithEvents AboutYouTubeClick As LinkLabel
End Class

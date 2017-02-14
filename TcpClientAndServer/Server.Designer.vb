<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Server
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSend = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtRec = New System.Windows.Forms.TextBox()
        Me.TimerRec = New System.Windows.Forms.Timer(Me.components)
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.grpCnct = New System.Windows.Forms.GroupBox()
        Me.pbIcon = New System.Windows.Forms.PictureBox()
        Me.lbCommands = New System.Windows.Forms.ListBox()
        Me.grpCnct.SuspendLayout()
        CType(Me.pbIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(95, 63)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Connect"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "send"
        '
        'txtSend
        '
        Me.txtSend.Location = New System.Drawing.Point(41, 116)
        Me.txtSend.Name = "txtSend"
        Me.txtSend.Size = New System.Drawing.Size(100, 20)
        Me.txtSend.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "rec"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(170, 111)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Send"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtRec
        '
        Me.txtRec.Location = New System.Drawing.Point(41, 158)
        Me.txtRec.Name = "txtRec"
        Me.txtRec.Size = New System.Drawing.Size(100, 20)
        Me.txtRec.TabIndex = 5
        '
        'TimerRec
        '
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(38, 26)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(39, 13)
        Me.lblStatus.TabIndex = 6
        Me.lblStatus.Text = "Label3"
        '
        'grpCnct
        '
        Me.grpCnct.Controls.Add(Me.lblStatus)
        Me.grpCnct.Controls.Add(Me.Button1)
        Me.grpCnct.Controls.Add(Me.txtRec)
        Me.grpCnct.Controls.Add(Me.Label1)
        Me.grpCnct.Controls.Add(Me.Button2)
        Me.grpCnct.Controls.Add(Me.txtSend)
        Me.grpCnct.Controls.Add(Me.Label2)
        Me.grpCnct.Location = New System.Drawing.Point(12, 12)
        Me.grpCnct.Name = "grpCnct"
        Me.grpCnct.Size = New System.Drawing.Size(266, 196)
        Me.grpCnct.TabIndex = 7
        Me.grpCnct.TabStop = False
        Me.grpCnct.Text = "Connect"
        '
        'pbIcon
        '
        Me.pbIcon.Image = Global.WindowsApplication1.My.Resources.Resources.CloneTrooper
        Me.pbIcon.Location = New System.Drawing.Point(132, 225)
        Me.pbIcon.Name = "pbIcon"
        Me.pbIcon.Size = New System.Drawing.Size(33, 36)
        Me.pbIcon.TabIndex = 8
        Me.pbIcon.TabStop = False
        '
        'lbCommands
        '
        Me.lbCommands.FormattingEnabled = True
        Me.lbCommands.Location = New System.Drawing.Point(328, 13)
        Me.lbCommands.Name = "lbCommands"
        Me.lbCommands.Size = New System.Drawing.Size(120, 225)
        Me.lbCommands.TabIndex = 9
        '
        'Server
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 265)
        Me.Controls.Add(Me.lbCommands)
        Me.Controls.Add(Me.pbIcon)
        Me.Controls.Add(Me.grpCnct)
        Me.Name = "Server"
        Me.Text = "Server"
        Me.grpCnct.ResumeLayout(False)
        Me.grpCnct.PerformLayout()
        CType(Me.pbIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSend As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtRec As System.Windows.Forms.TextBox
    Friend WithEvents TimerRec As System.Windows.Forms.Timer
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents grpCnct As GroupBox
    Friend WithEvents pbIcon As PictureBox
    Friend WithEvents lbCommands As ListBox
End Class

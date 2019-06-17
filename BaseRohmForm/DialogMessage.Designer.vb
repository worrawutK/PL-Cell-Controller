<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogMessage
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LinkLabelWeb = New System.Windows.Forms.LinkLabel()
        Me.LabelMessage = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.LabelHeader = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LabelHeader)
        Me.Panel1.Controls.Add(Me.ButtonClose)
        Me.Panel1.Controls.Add(Me.LinkLabelWeb)
        Me.Panel1.Controls.Add(Me.LabelMessage)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(685, 278)
        Me.Panel1.TabIndex = 0
        '
        'LinkLabelWeb
        '
        Me.LinkLabelWeb.AutoSize = True
        Me.LinkLabelWeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LinkLabelWeb.Location = New System.Drawing.Point(22, 229)
        Me.LinkLabelWeb.Name = "LinkLabelWeb"
        Me.LinkLabelWeb.Size = New System.Drawing.Size(130, 29)
        Me.LinkLabelWeb.TabIndex = 1
        Me.LinkLabelWeb.TabStop = True
        Me.LinkLabelWeb.Text = "LinkLabel1"
        Me.LinkLabelWeb.Visible = False
        '
        'LabelMessage
        '
        Me.LabelMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelMessage.Location = New System.Drawing.Point(27, 68)
        Me.LabelMessage.Name = "LabelMessage"
        Me.LabelMessage.Size = New System.Drawing.Size(633, 137)
        Me.LabelMessage.TabIndex = 0
        Me.LabelMessage.Text = "-"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'ButtonClose
        '
        Me.ButtonClose.AutoSize = True
        Me.ButtonClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ButtonClose.Location = New System.Drawing.Point(542, 221)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(118, 41)
        Me.ButtonClose.TabIndex = 2
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'LabelHeader
        '
        Me.LabelHeader.AutoSize = True
        Me.LabelHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelHeader.Location = New System.Drawing.Point(27, 24)
        Me.LabelHeader.Name = "LabelHeader"
        Me.LabelHeader.Size = New System.Drawing.Size(131, 31)
        Me.LabelHeader.TabIndex = 3
        Me.LabelHeader.Text = "Message"
        '
        'DialogMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 278)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "DialogMessage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DialogMessage"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LinkLabelWeb As LinkLabel
    Friend WithEvents LabelMessage As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ButtonClose As Button
    Friend WithEvents LabelHeader As Label
End Class

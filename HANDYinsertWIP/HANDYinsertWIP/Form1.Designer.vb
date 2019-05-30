<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbLot = New System.Windows.Forms.Label
        Me.lbLotNo = New System.Windows.Forms.Label
        Me.lbPackage = New System.Windows.Forms.Label
        Me.lbPKG = New System.Windows.Forms.Label
        Me.tbQRScan = New System.Windows.Forms.TextBox
        Me.lbOP = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer
        Me.lbW = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbWIP = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.lbOPNo = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lbLot
        '
        Me.lbLot.BackColor = System.Drawing.Color.Black
        Me.lbLot.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Regular)
        Me.lbLot.ForeColor = System.Drawing.Color.White
        Me.lbLot.Location = New System.Drawing.Point(146, 207)
        Me.lbLot.Name = "lbLot"
        Me.lbLot.Size = New System.Drawing.Size(292, 47)
        Me.lbLot.Text = "-"
        '
        'lbLotNo
        '
        Me.lbLotNo.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Regular)
        Me.lbLotNo.ForeColor = System.Drawing.Color.White
        Me.lbLotNo.Location = New System.Drawing.Point(10, 207)
        Me.lbLotNo.Name = "lbLotNo"
        Me.lbLotNo.Size = New System.Drawing.Size(130, 36)
        Me.lbLotNo.Text = "Lot No.  : "
        '
        'lbPackage
        '
        Me.lbPackage.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Regular)
        Me.lbPackage.ForeColor = System.Drawing.Color.White
        Me.lbPackage.Location = New System.Drawing.Point(10, 301)
        Me.lbPackage.Name = "lbPackage"
        Me.lbPackage.Size = New System.Drawing.Size(130, 36)
        Me.lbPackage.Text = "Package : "
        '
        'lbPKG
        '
        Me.lbPKG.BackColor = System.Drawing.Color.Black
        Me.lbPKG.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Regular)
        Me.lbPKG.ForeColor = System.Drawing.Color.White
        Me.lbPKG.Location = New System.Drawing.Point(146, 301)
        Me.lbPKG.Name = "lbPKG"
        Me.lbPKG.Size = New System.Drawing.Size(292, 47)
        Me.lbPKG.Text = "-"
        '
        'tbQRScan
        '
        Me.tbQRScan.BackColor = System.Drawing.Color.White
        Me.tbQRScan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbQRScan.Location = New System.Drawing.Point(376, 606)
        Me.tbQRScan.Name = "tbQRScan"
        Me.tbQRScan.Size = New System.Drawing.Size(51, 23)
        Me.tbQRScan.TabIndex = 7
        '
        'lbOP
        '
        Me.lbOP.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.lbOP.ForeColor = System.Drawing.Color.White
        Me.lbOP.Location = New System.Drawing.Point(90, 389)
        Me.lbOP.Name = "lbOP"
        Me.lbOP.Size = New System.Drawing.Size(319, 36)
        Me.lbOP.Text = "-"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 2000
        '
        'lbW
        '
        Me.lbW.BackColor = System.Drawing.Color.Black
        Me.lbW.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Regular)
        Me.lbW.ForeColor = System.Drawing.Color.White
        Me.lbW.Location = New System.Drawing.Point(146, 135)
        Me.lbW.Name = "lbW"
        Me.lbW.Size = New System.Drawing.Size(292, 37)
        Me.lbW.Text = "-"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 26.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(100, 425)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 69)
        Me.Label1.Text = "Scan OP No."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbWIP
        '
        Me.lbWIP.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Regular)
        Me.lbWIP.ForeColor = System.Drawing.Color.White
        Me.lbWIP.Location = New System.Drawing.Point(10, 135)
        Me.lbWIP.Name = "lbWIP"
        Me.lbWIP.Size = New System.Drawing.Size(130, 37)
        Me.lbWIP.Text = "WIP       :"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 22.0!, System.Drawing.FontStyle.Regular)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(3, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(475, 59)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "PL IPM WIP AND REFLOW WIP"
        '
        'lbOPNo
        '
        Me.lbOPNo.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.lbOPNo.ForeColor = System.Drawing.Color.White
        Me.lbOPNo.Location = New System.Drawing.Point(1, 389)
        Me.lbOPNo.Name = "lbOPNo"
        Me.lbOPNo.Size = New System.Drawing.Size(83, 36)
        Me.lbOPNo.Text = "OPNo :"
        Me.lbOPNo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(146, 553)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(309, 36)
        Me.Label7.Text = "IP"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(14, 465)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 29)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Exit"
        Me.Button1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(478, 615)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbOPNo)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbWIP)
        Me.Controls.Add(Me.lbW)
        Me.Controls.Add(Me.lbOP)
        Me.Controls.Add(Me.tbQRScan)
        Me.Controls.Add(Me.lbPackage)
        Me.Controls.Add(Me.lbPKG)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbLotNo)
        Me.Controls.Add(Me.lbLot)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbLot As System.Windows.Forms.Label
    Friend WithEvents lbLotNo As System.Windows.Forms.Label
    Friend WithEvents lbPackage As System.Windows.Forms.Label
    Friend WithEvents lbPKG As System.Windows.Forms.Label
    Friend WithEvents tbQRScan As System.Windows.Forms.TextBox
    Friend WithEvents lbOP As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbW As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbWIP As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lbOPNo As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class

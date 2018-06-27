<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductionTable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductionTable))
        Me.tbAlarmCellCon = New System.Windows.Forms.TabPage()
        Me.lblAlarm = New System.Windows.Forms.Label()
        Me.btnCellConAlmRst = New System.Windows.Forms.Button()
        Me.dgvAlarmCellCon = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbAlarm = New System.Windows.Forms.TabPage()
        Me.dgvAlarm = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlarmMessage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbDetail = New System.Windows.Forms.TabPage()
        Me.dgvProductionDetail = New System.Windows.Forms.DataGridView()
        Me.Time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Action = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbOther = New System.Windows.Forms.TabPage()
        Me.pbxOPID = New System.Windows.Forms.PictureBox()
        Me.btnOPID = New System.Windows.Forms.Button()
        Me.pbxQR = New System.Windows.Forms.PictureBox()
        Me.btnWorkSlip = New System.Windows.Forms.Button()
        Me.tbxKey = New System.Windows.Forms.TextBox()
        Me.tbxQR_OPID = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.WindowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SizableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FixedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinimizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbPageMain = New System.Windows.Forms.TabControl()
        Me.tbAlarmCellCon.SuspendLayout()
        CType(Me.dgvAlarmCellCon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbAlarm.SuspendLayout()
        CType(Me.dgvAlarm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbDetail.SuspendLayout()
        CType(Me.dgvProductionDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbOther.SuspendLayout()
        CType(Me.pbxOPID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxQR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.tbPageMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbAlarmCellCon
        '
        Me.tbAlarmCellCon.Controls.Add(Me.lblAlarm)
        Me.tbAlarmCellCon.Controls.Add(Me.btnCellConAlmRst)
        Me.tbAlarmCellCon.Controls.Add(Me.dgvAlarmCellCon)
        Me.tbAlarmCellCon.Location = New System.Drawing.Point(4, 25)
        Me.tbAlarmCellCon.Name = "tbAlarmCellCon"
        Me.tbAlarmCellCon.Size = New System.Drawing.Size(756, 163)
        Me.tbAlarmCellCon.TabIndex = 7
        Me.tbAlarmCellCon.Text = "AlarmCellCon"
        Me.tbAlarmCellCon.UseVisualStyleBackColor = True
        '
        'lblAlarm
        '
        Me.lblAlarm.AutoSize = True
        Me.lblAlarm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlarm.ForeColor = System.Drawing.Color.Red
        Me.lblAlarm.Location = New System.Drawing.Point(130, 20)
        Me.lblAlarm.Name = "lblAlarm"
        Me.lblAlarm.Size = New System.Drawing.Size(154, 24)
        Me.lblAlarm.TabIndex = 45
        Me.lblAlarm.Text = "Alarm Message"
        '
        'btnCellConAlmRst
        '
        Me.btnCellConAlmRst.Location = New System.Drawing.Point(6, 7)
        Me.btnCellConAlmRst.Name = "btnCellConAlmRst"
        Me.btnCellConAlmRst.Size = New System.Drawing.Size(99, 47)
        Me.btnCellConAlmRst.TabIndex = 44
        Me.btnCellConAlmRst.Text = "Alarm Reset"
        Me.btnCellConAlmRst.UseVisualStyleBackColor = True
        '
        'dgvAlarmCellCon
        '
        Me.dgvAlarmCellCon.AllowUserToDeleteRows = False
        Me.dgvAlarmCellCon.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvAlarmCellCon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAlarmCellCon.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.dgvAlarmCellCon.Location = New System.Drawing.Point(3, 61)
        Me.dgvAlarmCellCon.Name = "dgvAlarmCellCon"
        Me.dgvAlarmCellCon.ReadOnly = True
        Me.dgvAlarmCellCon.Size = New System.Drawing.Size(750, 106)
        Me.dgvAlarmCellCon.TabIndex = 39
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.HeaderText = "Time"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 64
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.HeaderText = "Location"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 84
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn11.HeaderText = "Condition"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 89
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn12.HeaderText = "AlarmID"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 81
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn13.HeaderText = "Alarm Message"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'tbAlarm
        '
        Me.tbAlarm.Controls.Add(Me.dgvAlarm)
        Me.tbAlarm.Location = New System.Drawing.Point(4, 25)
        Me.tbAlarm.Name = "tbAlarm"
        Me.tbAlarm.Padding = New System.Windows.Forms.Padding(3)
        Me.tbAlarm.Size = New System.Drawing.Size(756, 163)
        Me.tbAlarm.TabIndex = 1
        Me.tbAlarm.Text = "Alarm"
        Me.tbAlarm.UseVisualStyleBackColor = True
        '
        'dgvAlarm
        '
        Me.dgvAlarm.AllowUserToDeleteRows = False
        Me.dgvAlarm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAlarm.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn7, Me.AlarmMessage})
        Me.dgvAlarm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAlarm.Location = New System.Drawing.Point(3, 3)
        Me.dgvAlarm.Name = "dgvAlarm"
        Me.dgvAlarm.ReadOnly = True
        Me.dgvAlarm.Size = New System.Drawing.Size(750, 157)
        Me.dgvAlarm.TabIndex = 38
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.HeaderText = "Time"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 64
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 70
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.HeaderText = "AlarmID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 81
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.HeaderText = "AlarmType"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'AlarmMessage
        '
        Me.AlarmMessage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AlarmMessage.HeaderText = "Alarm Message"
        Me.AlarmMessage.Name = "AlarmMessage"
        Me.AlarmMessage.ReadOnly = True
        '
        'tbDetail
        '
        Me.tbDetail.Controls.Add(Me.dgvProductionDetail)
        Me.tbDetail.Location = New System.Drawing.Point(4, 25)
        Me.tbDetail.Name = "tbDetail"
        Me.tbDetail.Size = New System.Drawing.Size(756, 163)
        Me.tbDetail.TabIndex = 3
        Me.tbDetail.Text = "Production Details"
        Me.tbDetail.UseVisualStyleBackColor = True
        '
        'dgvProductionDetail
        '
        Me.dgvProductionDetail.AllowUserToDeleteRows = False
        Me.dgvProductionDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductionDetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Time, Me.ItemID, Me.Type, Me.Action})
        Me.dgvProductionDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProductionDetail.Location = New System.Drawing.Point(0, 0)
        Me.dgvProductionDetail.Name = "dgvProductionDetail"
        Me.dgvProductionDetail.ReadOnly = True
        Me.dgvProductionDetail.Size = New System.Drawing.Size(756, 163)
        Me.dgvProductionDetail.TabIndex = 0
        '
        'Time
        '
        Me.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Time.HeaderText = "Time"
        Me.Time.Name = "Time"
        Me.Time.ReadOnly = True
        Me.Time.Width = 64
        '
        'ItemID
        '
        Me.ItemID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ItemID.HeaderText = "CEID"
        Me.ItemID.Name = "ItemID"
        Me.ItemID.ReadOnly = True
        Me.ItemID.Width = 64
        '
        'Type
        '
        Me.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Type.HeaderText = "LotNo"
        Me.Type.Name = "Type"
        Me.Type.ReadOnly = True
        Me.Type.Width = 69
        '
        'Action
        '
        Me.Action.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Action.HeaderText = "Action"
        Me.Action.Name = "Action"
        Me.Action.ReadOnly = True
        '
        'tbOther
        '
        Me.tbOther.Controls.Add(Me.pbxOPID)
        Me.tbOther.Controls.Add(Me.btnOPID)
        Me.tbOther.Controls.Add(Me.pbxQR)
        Me.tbOther.Controls.Add(Me.btnWorkSlip)
        Me.tbOther.Controls.Add(Me.tbxKey)
        Me.tbOther.Controls.Add(Me.tbxQR_OPID)
        Me.tbOther.Controls.Add(Me.MenuStrip1)
        Me.tbOther.Location = New System.Drawing.Point(4, 25)
        Me.tbOther.Name = "tbOther"
        Me.tbOther.Padding = New System.Windows.Forms.Padding(3)
        Me.tbOther.Size = New System.Drawing.Size(756, 163)
        Me.tbOther.TabIndex = 5
        Me.tbOther.UseVisualStyleBackColor = True
        '
        'pbxOPID
        '
        Me.pbxOPID.BackColor = System.Drawing.SystemColors.Control
        Me.pbxOPID.BackgroundImage = Global.CellController.My.Resources.Resources.UserBlank
        Me.pbxOPID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxOPID.Location = New System.Drawing.Point(22, 59)
        Me.pbxOPID.Name = "pbxOPID"
        Me.pbxOPID.Size = New System.Drawing.Size(70, 50)
        Me.pbxOPID.TabIndex = 51
        Me.pbxOPID.TabStop = False
        '
        'btnOPID
        '
        Me.btnOPID.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnOPID.ForeColor = System.Drawing.Color.Black
        Me.btnOPID.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnOPID.ImageKey = "(none)"
        Me.btnOPID.Location = New System.Drawing.Point(15, 52)
        Me.btnOPID.Name = "btnOPID"
        Me.btnOPID.Size = New System.Drawing.Size(85, 80)
        Me.btnOPID.TabIndex = 50
        Me.btnOPID.Text = "OPID"
        Me.btnOPID.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnOPID.UseVisualStyleBackColor = False
        '
        'pbxQR
        '
        Me.pbxQR.BackColor = System.Drawing.SystemColors.Control
        Me.pbxQR.BackgroundImage = CType(resources.GetObject("pbxQR.BackgroundImage"), System.Drawing.Image)
        Me.pbxQR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxQR.Location = New System.Drawing.Point(124, 59)
        Me.pbxQR.Name = "pbxQR"
        Me.pbxQR.Size = New System.Drawing.Size(70, 50)
        Me.pbxQR.TabIndex = 48
        Me.pbxQR.TabStop = False
        '
        'btnWorkSlip
        '
        Me.btnWorkSlip.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnWorkSlip.ForeColor = System.Drawing.Color.Black
        Me.btnWorkSlip.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnWorkSlip.ImageKey = "(none)"
        Me.btnWorkSlip.Location = New System.Drawing.Point(117, 52)
        Me.btnWorkSlip.Name = "btnWorkSlip"
        Me.btnWorkSlip.Size = New System.Drawing.Size(85, 80)
        Me.btnWorkSlip.TabIndex = 47
        Me.btnWorkSlip.Text = "WorkSlip"
        Me.btnWorkSlip.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnWorkSlip.UseVisualStyleBackColor = False
        '
        'tbxKey
        '
        Me.tbxKey.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tbxKey.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 3.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbxKey.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.tbxKey.Location = New System.Drawing.Point(126, 110)
        Me.tbxKey.Name = "tbxKey"
        Me.tbxKey.Size = New System.Drawing.Size(70, 6)
        Me.tbxKey.TabIndex = 49
        '
        'tbxQR_OPID
        '
        Me.tbxQR_OPID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxQR_OPID.ForeColor = System.Drawing.Color.White
        Me.tbxQR_OPID.Location = New System.Drawing.Point(22, 101)
        Me.tbxQR_OPID.Name = "tbxQR_OPID"
        Me.tbxQR_OPID.Size = New System.Drawing.Size(53, 15)
        Me.tbxQR_OPID.TabIndex = 52
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.PowderBlue
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WindowsToolStripMenuItem, Me.CloseToolStripMenuItem2, Me.MinimizeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 3)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(750, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'WindowsToolStripMenuItem
        '
        Me.WindowsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SizableToolStripMenuItem, Me.FixedToolStripMenuItem})
        Me.WindowsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.WindowsToolStripMenuItem.Name = "WindowsToolStripMenuItem"
        Me.WindowsToolStripMenuItem.Size = New System.Drawing.Size(117, 21)
        Me.WindowsToolStripMenuItem.Text = "FormBorderStyle"
        '
        'SizableToolStripMenuItem
        '
        Me.SizableToolStripMenuItem.Name = "SizableToolStripMenuItem"
        Me.SizableToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.SizableToolStripMenuItem.Text = "Sizable"
        '
        'FixedToolStripMenuItem
        '
        Me.FixedToolStripMenuItem.Name = "FixedToolStripMenuItem"
        Me.FixedToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.FixedToolStripMenuItem.Text = "Fixed"
        '
        'CloseToolStripMenuItem2
        '
        Me.CloseToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.CloseToolStripMenuItem2.Name = "CloseToolStripMenuItem2"
        Me.CloseToolStripMenuItem2.Size = New System.Drawing.Size(52, 21)
        Me.CloseToolStripMenuItem2.Text = "Close"
        '
        'MinimizeToolStripMenuItem
        '
        Me.MinimizeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.MinimizeToolStripMenuItem.Name = "MinimizeToolStripMenuItem"
        Me.MinimizeToolStripMenuItem.Size = New System.Drawing.Size(72, 21)
        Me.MinimizeToolStripMenuItem.Text = "Minimize"
        '
        'tbPageMain
        '
        Me.tbPageMain.Controls.Add(Me.tbOther)
        Me.tbPageMain.Controls.Add(Me.tbDetail)
        Me.tbPageMain.Controls.Add(Me.tbAlarm)
        Me.tbPageMain.Controls.Add(Me.tbAlarmCellCon)
        Me.tbPageMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbPageMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbPageMain.Location = New System.Drawing.Point(0, 0)
        Me.tbPageMain.Name = "tbPageMain"
        Me.tbPageMain.SelectedIndex = 0
        Me.tbPageMain.Size = New System.Drawing.Size(764, 192)
        Me.tbPageMain.TabIndex = 39
        '
        'ProductionTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(764, 192)
        Me.Controls.Add(Me.tbPageMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ProductionTable"
        Me.Text = "ProductionTable"
        Me.tbAlarmCellCon.ResumeLayout(False)
        Me.tbAlarmCellCon.PerformLayout()
        CType(Me.dgvAlarmCellCon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbAlarm.ResumeLayout(False)
        CType(Me.dgvAlarm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbDetail.ResumeLayout(False)
        CType(Me.dgvProductionDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbOther.ResumeLayout(False)
        Me.tbOther.PerformLayout()
        CType(Me.pbxOPID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxQR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.tbPageMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbAlarmCellCon As TabPage
    Friend WithEvents lblAlarm As Label
    Friend WithEvents btnCellConAlmRst As Button
    Friend WithEvents dgvAlarmCellCon As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents tbAlarm As TabPage
    Friend WithEvents dgvAlarm As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents AlarmMessage As DataGridViewTextBoxColumn
    Friend WithEvents tbDetail As TabPage
    Friend WithEvents dgvProductionDetail As DataGridView
    Friend WithEvents Time As DataGridViewTextBoxColumn
    Friend WithEvents ItemID As DataGridViewTextBoxColumn
    Friend WithEvents Type As DataGridViewTextBoxColumn
    Friend WithEvents Action As DataGridViewTextBoxColumn
    Friend WithEvents tbOther As TabPage
    Friend WithEvents pbxOPID As PictureBox
    Friend WithEvents btnOPID As Button
    Friend WithEvents pbxQR As PictureBox
    Friend WithEvents btnWorkSlip As Button
    Friend WithEvents tbxKey As TextBox
    Friend WithEvents tbxQR_OPID As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents WindowsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SizableToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FixedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents MinimizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tbPageMain As TabControl
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProcessForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProcessForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AndonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BMRequestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PMRepairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.APCSStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaximizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SecsConsoleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EqConnectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WorkRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PLDataDataGridView = New System.Windows.Forms.DataGridView()
        Me.LotNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotStartTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OPNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoadCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnloadCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotEndTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MagazineNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PLDataBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbMcNo = New System.Windows.Forms.Label()
        Me.btDeleteLot = New System.Windows.Forms.Button()
        Me.lbProcess = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btEndManual = New System.Windows.Forms.Button()
        Me.lbTime = New System.Windows.Forms.Label()
        Me.TimerTest = New System.Windows.Forms.Timer(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.LabelIReportMessage = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pbxAutoM = New System.Windows.Forms.PictureBox()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.DummyCheckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NoCheckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PLDataDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLDataBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAutoM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AndonToolStripMenuItem, Me.BMRequestToolStripMenuItem, Me.PMRepairToolStripMenuItem, Me.APCSStaffToolStripMenuItem, Me.WindowToolStripMenuItem, Me.EqConnectToolStripMenuItem, Me.WorkRecordToolStripMenuItem, Me.DummyCheckToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(1, 98)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(762, 25)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AndonToolStripMenuItem
        '
        Me.AndonToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AndonToolStripMenuItem.Name = "AndonToolStripMenuItem"
        Me.AndonToolStripMenuItem.Size = New System.Drawing.Size(58, 21)
        Me.AndonToolStripMenuItem.Text = "Andon"
        '
        'BMRequestToolStripMenuItem
        '
        Me.BMRequestToolStripMenuItem.Name = "BMRequestToolStripMenuItem"
        Me.BMRequestToolStripMenuItem.Size = New System.Drawing.Size(82, 21)
        Me.BMRequestToolStripMenuItem.Text = "BM Request"
        '
        'PMRepairToolStripMenuItem
        '
        Me.PMRepairToolStripMenuItem.Name = "PMRepairToolStripMenuItem"
        Me.PMRepairToolStripMenuItem.Size = New System.Drawing.Size(90, 21)
        Me.PMRepairToolStripMenuItem.Text = "PM Repairing"
        '
        'APCSStaffToolStripMenuItem
        '
        Me.APCSStaffToolStripMenuItem.Name = "APCSStaffToolStripMenuItem"
        Me.APCSStaffToolStripMenuItem.Size = New System.Drawing.Size(77, 21)
        Me.APCSStaffToolStripMenuItem.Text = "APCS_Staff"
        '
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaximizeToolStripMenuItem, Me.ProductTableToolStripMenuItem, Me.SecsConsoleToolStripMenuItem})
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(68, 21)
        Me.WindowToolStripMenuItem.Text = "Windows"
        '
        'MaximizeToolStripMenuItem
        '
        Me.MaximizeToolStripMenuItem.Enabled = False
        Me.MaximizeToolStripMenuItem.Name = "MaximizeToolStripMenuItem"
        Me.MaximizeToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.MaximizeToolStripMenuItem.Text = "Maximize"
        '
        'ProductTableToolStripMenuItem
        '
        Me.ProductTableToolStripMenuItem.Name = "ProductTableToolStripMenuItem"
        Me.ProductTableToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.ProductTableToolStripMenuItem.Text = "ProductTable"
        '
        'SecsConsoleToolStripMenuItem
        '
        Me.SecsConsoleToolStripMenuItem.Name = "SecsConsoleToolStripMenuItem"
        Me.SecsConsoleToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.SecsConsoleToolStripMenuItem.Text = "SecsConsole"
        '
        'EqConnectToolStripMenuItem
        '
        Me.EqConnectToolStripMenuItem.Name = "EqConnectToolStripMenuItem"
        Me.EqConnectToolStripMenuItem.Size = New System.Drawing.Size(77, 21)
        Me.EqConnectToolStripMenuItem.Text = "EqConnect"
        '
        'WorkRecordToolStripMenuItem
        '
        Me.WorkRecordToolStripMenuItem.Name = "WorkRecordToolStripMenuItem"
        Me.WorkRecordToolStripMenuItem.Size = New System.Drawing.Size(87, 21)
        Me.WorkRecordToolStripMenuItem.Text = "Work Record"
        '
        'PLDataDataGridView
        '
        Me.PLDataDataGridView.AllowUserToAddRows = False
        Me.PLDataDataGridView.AllowUserToDeleteRows = False
        Me.PLDataDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PLDataDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle22
        Me.PLDataDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PLDataDataGridView.AutoGenerateColumns = False
        Me.PLDataDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PLDataDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle23
        Me.PLDataDataGridView.ColumnHeadersHeight = 40
        Me.PLDataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.PLDataDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LotNoDataGridViewTextBoxColumn, Me.LotStartTimeDataGridViewTextBoxColumn, Me.OPNo, Me.LoadCount, Me.UnloadCount, Me.LotEndTimeDataGridViewTextBoxColumn, Me.MagazineNoDataGridViewTextBoxColumn})
        Me.PLDataDataGridView.DataSource = Me.PLDataBindingSource1
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PLDataDataGridView.DefaultCellStyle = DataGridViewCellStyle26
        Me.PLDataDataGridView.Location = New System.Drawing.Point(19, 226)
        Me.PLDataDataGridView.MultiSelect = False
        Me.PLDataDataGridView.Name = "PLDataDataGridView"
        Me.PLDataDataGridView.ReadOnly = True
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PLDataDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle27
        Me.PLDataDataGridView.RowHeadersVisible = False
        Me.PLDataDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle28.BackColor = System.Drawing.Color.PowderBlue
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.PLDataDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle28
        Me.PLDataDataGridView.RowTemplate.Height = 60
        Me.PLDataDataGridView.RowTemplate.ReadOnly = True
        Me.PLDataDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PLDataDataGridView.Size = New System.Drawing.Size(898, 468)
        Me.PLDataDataGridView.TabIndex = 54
        '
        'LotNoDataGridViewTextBoxColumn
        '
        Me.LotNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.LotNoDataGridViewTextBoxColumn.DataPropertyName = "LotNo"
        Me.LotNoDataGridViewTextBoxColumn.HeaderText = "LotNo"
        Me.LotNoDataGridViewTextBoxColumn.Name = "LotNoDataGridViewTextBoxColumn"
        Me.LotNoDataGridViewTextBoxColumn.ReadOnly = True
        Me.LotNoDataGridViewTextBoxColumn.Width = 117
        '
        'LotStartTimeDataGridViewTextBoxColumn
        '
        Me.LotStartTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.LotStartTimeDataGridViewTextBoxColumn.DataPropertyName = "LotStartTime"
        DataGridViewCellStyle24.Format = "G"
        DataGridViewCellStyle24.NullValue = Nothing
        Me.LotStartTimeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle24
        Me.LotStartTimeDataGridViewTextBoxColumn.HeaderText = "LotStartTime"
        Me.LotStartTimeDataGridViewTextBoxColumn.Name = "LotStartTimeDataGridViewTextBoxColumn"
        Me.LotStartTimeDataGridViewTextBoxColumn.ReadOnly = True
        Me.LotStartTimeDataGridViewTextBoxColumn.Width = 207
        '
        'OPNo
        '
        Me.OPNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.OPNo.DataPropertyName = "OPNo"
        Me.OPNo.HeaderText = "OPNo"
        Me.OPNo.Name = "OPNo"
        Me.OPNo.ReadOnly = True
        Me.OPNo.Width = 117
        '
        'LoadCount
        '
        Me.LoadCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.LoadCount.DataPropertyName = "LoadCount"
        Me.LoadCount.HeaderText = "Input"
        Me.LoadCount.Name = "LoadCount"
        Me.LoadCount.ReadOnly = True
        Me.LoadCount.Width = 105
        '
        'UnloadCount
        '
        Me.UnloadCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.UnloadCount.DataPropertyName = "UnloadCount"
        Me.UnloadCount.HeaderText = "Good"
        Me.UnloadCount.Name = "UnloadCount"
        Me.UnloadCount.ReadOnly = True
        Me.UnloadCount.Width = 109
        '
        'LotEndTimeDataGridViewTextBoxColumn
        '
        Me.LotEndTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.LotEndTimeDataGridViewTextBoxColumn.DataPropertyName = "LotEndTime"
        DataGridViewCellStyle25.Format = "G"
        DataGridViewCellStyle25.NullValue = Nothing
        Me.LotEndTimeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle25
        Me.LotEndTimeDataGridViewTextBoxColumn.HeaderText = "LotEndTime"
        Me.LotEndTimeDataGridViewTextBoxColumn.Name = "LotEndTimeDataGridViewTextBoxColumn"
        Me.LotEndTimeDataGridViewTextBoxColumn.ReadOnly = True
        Me.LotEndTimeDataGridViewTextBoxColumn.Width = 195
        '
        'MagazineNoDataGridViewTextBoxColumn
        '
        Me.MagazineNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MagazineNoDataGridViewTextBoxColumn.DataPropertyName = "MagazineNo"
        Me.MagazineNoDataGridViewTextBoxColumn.HeaderText = "MagazineNo"
        Me.MagazineNoDataGridViewTextBoxColumn.Name = "MagazineNoDataGridViewTextBoxColumn"
        Me.MagazineNoDataGridViewTextBoxColumn.ReadOnly = True
        Me.MagazineNoDataGridViewTextBoxColumn.Width = 201
        '
        'PLDataBindingSource1
        '
        Me.PLDataBindingSource1.AllowNew = False
        Me.PLDataBindingSource1.DataSource = GetType(CellController.PLData)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 39)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "MC No."
        '
        'lbMcNo
        '
        Me.lbMcNo.BackColor = System.Drawing.Color.White
        Me.lbMcNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbMcNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbMcNo.ForeColor = System.Drawing.Color.Blue
        Me.lbMcNo.Location = New System.Drawing.Point(184, 150)
        Me.lbMcNo.Name = "lbMcNo"
        Me.lbMcNo.Size = New System.Drawing.Size(166, 46)
        Me.lbMcNo.TabIndex = 51
        Me.lbMcNo.Text = "Label7"
        Me.lbMcNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btDeleteLot
        '
        Me.btDeleteLot.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btDeleteLot.BackColor = System.Drawing.Color.LightCoral
        Me.btDeleteLot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btDeleteLot.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btDeleteLot.Location = New System.Drawing.Point(922, 226)
        Me.btDeleteLot.Name = "btDeleteLot"
        Me.btDeleteLot.Size = New System.Drawing.Size(96, 62)
        Me.btDeleteLot.TabIndex = 55
        Me.btDeleteLot.Text = "Delete Lot"
        Me.btDeleteLot.UseVisualStyleBackColor = False
        '
        'lbProcess
        '
        Me.lbProcess.AutoSize = True
        Me.lbProcess.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbProcess.Location = New System.Drawing.Point(12, 36)
        Me.lbProcess.Name = "lbProcess"
        Me.lbProcess.Size = New System.Drawing.Size(208, 42)
        Me.lbProcess.TabIndex = 7
        Me.lbProcess.Text = "PROCESS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(240, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(295, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Communication by SECS/GEM"
        '
        'btEndManual
        '
        Me.btEndManual.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btEndManual.BackColor = System.Drawing.Color.RoyalBlue
        Me.btEndManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btEndManual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btEndManual.Location = New System.Drawing.Point(923, 453)
        Me.btEndManual.Name = "btEndManual"
        Me.btEndManual.Size = New System.Drawing.Size(95, 62)
        Me.btEndManual.TabIndex = 55
        Me.btEndManual.Text = "End Manual"
        Me.btEndManual.UseVisualStyleBackColor = False
        '
        'lbTime
        '
        Me.lbTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbTime.AutoSize = True
        Me.lbTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTime.Location = New System.Drawing.Point(738, 150)
        Me.lbTime.Name = "lbTime"
        Me.lbTime.Size = New System.Drawing.Size(95, 31)
        Me.lbTime.TabIndex = 57
        Me.lbTime.Text = "Label3"
        '
        'TimerTest
        '
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button2.Location = New System.Drawing.Point(923, 336)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 62)
        Me.Button2.TabIndex = 55
        Me.Button2.Text = "Edit Data"
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.HotPink
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button3.Location = New System.Drawing.Point(923, 632)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(95, 62)
        Me.Button3.TabIndex = 55
        Me.Button3.Text = "Not Com."
        Me.Button3.UseVisualStyleBackColor = False
        '
        'LabelIReportMessage
        '
        Me.LabelIReportMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelIReportMessage.ForeColor = System.Drawing.Color.Red
        Me.LabelIReportMessage.Location = New System.Drawing.Point(356, 150)
        Me.LabelIReportMessage.Name = "LabelIReportMessage"
        Me.LabelIReportMessage.Size = New System.Drawing.Size(1200, 62)
        Me.LabelIReportMessage.TabIndex = 57
        Me.LabelIReportMessage.Text = "iReport "
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackgroundImage = Global.CellController.My.Resources.Resources.blue_minimized_icon_32193
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.Location = New System.Drawing.Point(826, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 65)
        Me.Button1.TabIndex = 56
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pbxAutoM
        '
        Me.pbxAutoM.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbxAutoM.BackColor = System.Drawing.Color.White
        Me.pbxAutoM.BackgroundImage = Global.CellController.My.Resources.Resources.HR
        Me.pbxAutoM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbxAutoM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxAutoM.Image = Global.CellController.My.Resources.Resources.HR
        Me.pbxAutoM.Location = New System.Drawing.Point(821, 25)
        Me.pbxAutoM.Name = "pbxAutoM"
        Me.pbxAutoM.Size = New System.Drawing.Size(96, 66)
        Me.pbxAutoM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxAutoM.TabIndex = 10
        Me.pbxAutoM.TabStop = False
        Me.pbxAutoM.Visible = False
        '
        'pbxLogo
        '
        Me.pbxLogo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbxLogo.BackgroundImage = CType(resources.GetObject("pbxLogo.BackgroundImage"), System.Drawing.Image)
        Me.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxLogo.Location = New System.Drawing.Point(923, 25)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(96, 65)
        Me.pbxLogo.TabIndex = 2
        Me.pbxLogo.TabStop = False
        '
        'DummyCheckToolStripMenuItem
        '
        Me.DummyCheckToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckToolStripMenuItem, Me.NoCheckToolStripMenuItem})
        Me.DummyCheckToolStripMenuItem.Name = "DummyCheckToolStripMenuItem"
        Me.DummyCheckToolStripMenuItem.Size = New System.Drawing.Size(95, 21)
        Me.DummyCheckToolStripMenuItem.Text = "DummyCheck"
        '
        'CheckToolStripMenuItem
        '
        Me.CheckToolStripMenuItem.Checked = True
        Me.CheckToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckToolStripMenuItem.Name = "CheckToolStripMenuItem"
        Me.CheckToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CheckToolStripMenuItem.Text = "Check"
        '
        'NoCheckToolStripMenuItem
        '
        Me.NoCheckToolStripMenuItem.Name = "NoCheckToolStripMenuItem"
        Me.NoCheckToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NoCheckToolStripMenuItem.Text = "NoCheck"
        '
        'ProcessForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1028, 753)
        Me.Controls.Add(Me.LabelIReportMessage)
        Me.Controls.Add(Me.lbTime)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btEndManual)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btDeleteLot)
        Me.Controls.Add(Me.PLDataDataGridView)
        Me.Controls.Add(Me.lbMcNo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbxAutoM)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbProcess)
        Me.Controls.Add(Me.pbxLogo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ProcessForm"
        Me.ShowIcon = False
        Me.Text = "ProcessForm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PLDataDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLDataBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAutoM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AndonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BMRequestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaximizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SecsConsoleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pbxAutoM As System.Windows.Forms.PictureBox
    Friend WithEvents EqConnectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PMRepairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents APCSStaffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PLDataDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbMcNo As System.Windows.Forms.Label
    Friend WithEvents btDeleteLot As System.Windows.Forms.Button
    Friend WithEvents lbProcess As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btEndManual As System.Windows.Forms.Button
    Friend WithEvents WorkRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lbTime As System.Windows.Forms.Label
    Friend WithEvents TimerTest As System.Windows.Forms.Timer
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents LabelIReportMessage As Label
    Friend WithEvents PLDataBindingSource1 As BindingSource
    Friend WithEvents OpNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InputQtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GoodQtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LotNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LotStartTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OPNo As DataGridViewTextBoxColumn
    Friend WithEvents LoadCount As DataGridViewTextBoxColumn
    Friend WithEvents UnloadCount As DataGridViewTextBoxColumn
    Friend WithEvents LotEndTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MagazineNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DummyCheckToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NoCheckToolStripMenuItem As ToolStripMenuItem
End Class

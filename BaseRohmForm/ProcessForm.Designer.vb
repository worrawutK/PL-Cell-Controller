<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProcessForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.lbSpMode = New System.Windows.Forms.Label()
        Me.PLDataDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PLDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBxDataSet = New CellController.DBxDataSet()
        Me.pbxAutoM = New System.Windows.Forms.PictureBox()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbMcNo = New System.Windows.Forms.Label()
        Me.btDeleteLot = New System.Windows.Forms.Button()
        Me.lbProcess = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bgTDC = New System.ComponentModel.BackgroundWorker()
        Me.btEndManual = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbTime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PLAlarmInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLAlarmTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLDataTableAdapter = New CellController.DBxDataSetTableAdapters.PLDataTableAdapter()
        Me.PLAlarmTableTableAdapter = New CellController.DBxDataSetTableAdapters.PLAlarmTableTableAdapter()
        Me.PLAlarmInfoTableAdapter = New CellController.DBxDataSetTableAdapters.PLAlarmInfoTableAdapter()
        Me.QueriesTableAdapter1 = New CellController.DBxDataSetTableAdapters.QueriesTableAdapter()
        Me.TransactionDataTableAdapter1 = New CellController.DBxDataSetTableAdapters.TransactionDataTableAdapter()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PLDataDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBxDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAutoM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLAlarmInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLAlarmTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AndonToolStripMenuItem, Me.BMRequestToolStripMenuItem, Me.PMRepairToolStripMenuItem, Me.APCSStaffToolStripMenuItem, Me.WindowToolStripMenuItem, Me.EqConnectToolStripMenuItem, Me.WorkRecordToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(1, 98)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(512, 25)
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
        Me.BMRequestToolStripMenuItem.Size = New System.Drawing.Size(76, 21)
        Me.BMRequestToolStripMenuItem.Text = "BM Request"
        '
        'PMRepairToolStripMenuItem
        '
        Me.PMRepairToolStripMenuItem.Name = "PMRepairToolStripMenuItem"
        Me.PMRepairToolStripMenuItem.Size = New System.Drawing.Size(81, 21)
        Me.PMRepairToolStripMenuItem.Text = "PM Repairing"
        '
        'APCSStaffToolStripMenuItem
        '
        Me.APCSStaffToolStripMenuItem.Name = "APCSStaffToolStripMenuItem"
        Me.APCSStaffToolStripMenuItem.Size = New System.Drawing.Size(75, 21)
        Me.APCSStaffToolStripMenuItem.Text = "APCS_Staff"
        '
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaximizeToolStripMenuItem, Me.ProductTableToolStripMenuItem, Me.SecsConsoleToolStripMenuItem})
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(62, 21)
        Me.WindowToolStripMenuItem.Text = "Windows"
        '
        'MaximizeToolStripMenuItem
        '
        Me.MaximizeToolStripMenuItem.Name = "MaximizeToolStripMenuItem"
        Me.MaximizeToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.MaximizeToolStripMenuItem.Text = "Maximize"
        '
        'ProductTableToolStripMenuItem
        '
        Me.ProductTableToolStripMenuItem.Name = "ProductTableToolStripMenuItem"
        Me.ProductTableToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.ProductTableToolStripMenuItem.Text = "ProductTable"
        '
        'SecsConsoleToolStripMenuItem
        '
        Me.SecsConsoleToolStripMenuItem.Name = "SecsConsoleToolStripMenuItem"
        Me.SecsConsoleToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.SecsConsoleToolStripMenuItem.Text = "SecsConsole"
        '
        'EqConnectToolStripMenuItem
        '
        Me.EqConnectToolStripMenuItem.Name = "EqConnectToolStripMenuItem"
        Me.EqConnectToolStripMenuItem.Size = New System.Drawing.Size(71, 21)
        Me.EqConnectToolStripMenuItem.Text = "EqConnect"
        '
        'WorkRecordToolStripMenuItem
        '
        Me.WorkRecordToolStripMenuItem.Name = "WorkRecordToolStripMenuItem"
        Me.WorkRecordToolStripMenuItem.Size = New System.Drawing.Size(81, 21)
        Me.WorkRecordToolStripMenuItem.Text = "Work Record"
        '
        'lbSpMode
        '
        Me.lbSpMode.AutoSize = True
        Me.lbSpMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbSpMode.ForeColor = System.Drawing.Color.Red
        Me.lbSpMode.Location = New System.Drawing.Point(338, 42)
        Me.lbSpMode.Name = "lbSpMode"
        Me.lbSpMode.Size = New System.Drawing.Size(0, 37)
        Me.lbSpMode.TabIndex = 53
        '
        'PLDataDataGridView
        '
        Me.PLDataDataGridView.AllowUserToAddRows = False
        Me.PLDataDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PLDataDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.PLDataDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PLDataDataGridView.AutoGenerateColumns = False
        Me.PLDataDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PLDataDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.PLDataDataGridView.ColumnHeadersHeight = 40
        Me.PLDataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.PLDataDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn10})
        Me.PLDataDataGridView.DataSource = Me.PLDataBindingSource
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PLDataDataGridView.DefaultCellStyle = DataGridViewCellStyle10
        Me.PLDataDataGridView.Location = New System.Drawing.Point(19, 226)
        Me.PLDataDataGridView.Name = "PLDataDataGridView"
        Me.PLDataDataGridView.ReadOnly = True
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PLDataDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.PLDataDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.PLDataDataGridView.RowTemplate.Height = 35
        Me.PLDataDataGridView.Size = New System.Drawing.Size(913, 468)
        Me.PLDataDataGridView.TabIndex = 54
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "LotNo"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn2.HeaderText = "LotNo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Width = 65
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "LotStartTime"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Green
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn3.HeaderText = "LotStartTime"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.DataGridViewTextBoxColumn3.Width = 138
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "OPNo"
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn9.HeaderText = "OPNo"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn9.Width = 67
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "LoadCount"
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Teal
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn7.HeaderText = "Input"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn7.Width = 56
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "UnloadCount"
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Navy
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn8.HeaderText = "Good"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn8.Width = 62
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "LotEndTime"
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn4.HeaderText = "LotEndTime"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.DataGridViewTextBoxColumn4.Width = 137
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "MagazineNo"
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.LightGray
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn10.HeaderText = "MagazineNo"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn10.Width = 122
        '
        'PLDataBindingSource
        '
        Me.PLDataBindingSource.DataMember = "PLData"
        Me.PLDataBindingSource.DataSource = Me.DBxDataSet
        '
        'DBxDataSet
        '
        Me.DBxDataSet.DataSetName = "DBxDataSet"
        Me.DBxDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.btDeleteLot.Location = New System.Drawing.Point(938, 226)
        Me.btDeleteLot.Name = "btDeleteLot"
        Me.btDeleteLot.Size = New System.Drawing.Size(118, 62)
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
        'bgTDC
        '
        '
        'btEndManual
        '
        Me.btEndManual.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btEndManual.BackColor = System.Drawing.Color.RoyalBlue
        Me.btEndManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btEndManual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btEndManual.Location = New System.Drawing.Point(938, 452)
        Me.btEndManual.Name = "btEndManual"
        Me.btEndManual.Size = New System.Drawing.Size(118, 62)
        Me.btEndManual.TabIndex = 55
        Me.btEndManual.Text = "End Manual"
        Me.btEndManual.UseVisualStyleBackColor = False
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
        'lbTime
        '
        Me.lbTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbTime.AutoSize = True
        Me.lbTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTime.Location = New System.Drawing.Point(731, 161)
        Me.lbTime.Name = "lbTime"
        Me.lbTime.Size = New System.Drawing.Size(95, 31)
        Me.lbTime.TabIndex = 57
        Me.lbTime.Text = "Label3"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button2.Location = New System.Drawing.Point(938, 337)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 62)
        Me.Button2.TabIndex = 55
        Me.Button2.Text = "Edit Data"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.HotPink
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button3.Location = New System.Drawing.Point(938, 632)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(118, 62)
        Me.Button3.TabIndex = 55
        Me.Button3.Text = "Not Com."
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PLAlarmInfoBindingSource
        '
        Me.PLAlarmInfoBindingSource.DataMember = "PLAlarmInfo"
        Me.PLAlarmInfoBindingSource.DataSource = Me.DBxDataSet
        '
        'PLAlarmTableBindingSource
        '
        Me.PLAlarmTableBindingSource.DataMember = "PLAlarmTable"
        Me.PLAlarmTableBindingSource.DataSource = Me.DBxDataSet
        '
        'PLDataTableAdapter
        '
        Me.PLDataTableAdapter.ClearBeforeFill = True
        '
        'PLAlarmTableTableAdapter
        '
        Me.PLAlarmTableTableAdapter.ClearBeforeFill = True
        '
        'PLAlarmInfoTableAdapter
        '
        Me.PLAlarmInfoTableAdapter.ClearBeforeFill = True
        '
        'TransactionDataTableAdapter1
        '
        Me.TransactionDataTableAdapter1.ClearBeforeFill = True
        '
        'ProcessForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1028, 753)
        Me.Controls.Add(Me.lbTime)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btEndManual)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btDeleteLot)
        Me.Controls.Add(Me.PLDataDataGridView)
        Me.Controls.Add(Me.lbSpMode)
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
        CType(Me.PLDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBxDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAutoM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLAlarmInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLAlarmTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lbSpMode As System.Windows.Forms.Label
    Friend WithEvents PMRepairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents APCSStaffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DBxDataSet As CellController.DBxDataSet
    Friend WithEvents PLDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLDataTableAdapter As CellController.DBxDataSetTableAdapters.PLDataTableAdapter
    Friend WithEvents PLDataDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbMcNo As System.Windows.Forms.Label
    Friend WithEvents btDeleteLot As System.Windows.Forms.Button
    Friend WithEvents lbProcess As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PLAlarmTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PLAlarmTableTableAdapter As CellController.DBxDataSetTableAdapters.PLAlarmTableTableAdapter
    Friend WithEvents PLAlarmInfoTableAdapter As CellController.DBxDataSetTableAdapters.PLAlarmInfoTableAdapter
    Friend WithEvents PLAlarmInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents bgTDC As System.ComponentModel.BackgroundWorker
    Friend WithEvents btEndManual As System.Windows.Forms.Button
    Friend WithEvents WorkRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lbTime As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents QueriesTableAdapter1 As CellController.DBxDataSetTableAdapters.QueriesTableAdapter
    Friend WithEvents TransactionDataTableAdapter1 As CellController.DBxDataSetTableAdapters.TransactionDataTableAdapter
End Class

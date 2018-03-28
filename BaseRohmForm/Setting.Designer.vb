<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Setting
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tbSetting = New System.Windows.Forms.TabControl()
        Me.tbComSetting = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgvSetting = New System.Windows.Forms.DataGridView()
        Me.ColName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Value = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbTDC = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rbTDCDisa = New System.Windows.Forms.RadioButton()
        Me.rbTDCEna = New System.Windows.Forms.RadioButton()
        Me.tbSecsGem = New System.Windows.Forms.TabPage()
        Me.dgvTimer = New System.Windows.Forms.DataGridView()
        Me.ParaName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ParaValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnTimeoutChg = New System.Windows.Forms.Button()
        Me.btnEquipPortChg = New System.Windows.Forms.Button()
        Me.btnEquipIPChg = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbxEqiupPort = New System.Windows.Forms.TextBox()
        Me.tbxEqiupIP = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbSecsDis = New System.Windows.Forms.RadioButton()
        Me.rbSecsEna = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbCsPro = New System.Windows.Forms.TabPage()
        Me.btnCsPortChg = New System.Windows.Forms.Button()
        Me.btnCsIPChg = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbxCsPort = New System.Windows.Forms.TextBox()
        Me.tbxCsIP = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.rbProDis = New System.Windows.Forms.RadioButton()
        Me.rbProEna = New System.Windows.Forms.RadioButton()
        Me.tbSetting.SuspendLayout()
        Me.tbComSetting.SuspendLayout()
        CType(Me.dgvSetting, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.tbTDC.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.tbSecsGem.SuspendLayout()
        CType(Me.dgvTimer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.tbCsPro.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbSetting
        '
        Me.tbSetting.Controls.Add(Me.tbComSetting)
        Me.tbSetting.Controls.Add(Me.tbTDC)
        Me.tbSetting.Controls.Add(Me.tbSecsGem)
        Me.tbSetting.Controls.Add(Me.tbCsPro)
        Me.tbSetting.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbSetting.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbSetting.Location = New System.Drawing.Point(0, 0)
        Me.tbSetting.Name = "tbSetting"
        Me.tbSetting.SelectedIndex = 0
        Me.tbSetting.Size = New System.Drawing.Size(772, 319)
        Me.tbSetting.TabIndex = 0
        '
        'tbComSetting
        '
        Me.tbComSetting.Controls.Add(Me.Label8)
        Me.tbComSetting.Controls.Add(Me.dgvSetting)
        Me.tbComSetting.Controls.Add(Me.MenuStrip1)
        Me.tbComSetting.Location = New System.Drawing.Point(4, 25)
        Me.tbComSetting.Name = "tbComSetting"
        Me.tbComSetting.Padding = New System.Windows.Forms.Padding(3)
        Me.tbComSetting.Size = New System.Drawing.Size(764, 290)
        Me.tbComSetting.TabIndex = 2
        Me.tbComSetting.Text = "  Setting  "
        Me.tbComSetting.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(19, 271)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(283, 12)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "* Values of UserAuthen are refer to [DBx].[dbo].[Group] in database "
        '
        'dgvSetting
        '
        Me.dgvSetting.AllowUserToAddRows = False
        Me.dgvSetting.AllowUserToDeleteRows = False
        Me.dgvSetting.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSetting.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSetting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSetting.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColName, Me.Value})
        Me.dgvSetting.Location = New System.Drawing.Point(8, 41)
        Me.dgvSetting.Name = "dgvSetting"
        Me.dgvSetting.RowHeadersVisible = False
        Me.dgvSetting.Size = New System.Drawing.Size(748, 226)
        Me.dgvSetting.TabIndex = 3
        '
        'ColName
        '
        Me.ColName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ColName.HeaderText = "Name"
        Me.ColName.Name = "ColName"
        Me.ColName.ReadOnly = True
        Me.ColName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColName.Width = 51
        '
        'Value
        '
        Me.Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Value.HeaderText = "Value"
        Me.Value.Name = "Value"
        Me.Value.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.PowderBlue
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.AddUserToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 3)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(758, 25)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(79, 21)
        Me.SaveToolStripMenuItem.Text = "SaveValue"
        '
        'AddUserToolStripMenuItem
        '
        Me.AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem"
        Me.AddUserToolStripMenuItem.Size = New System.Drawing.Size(71, 21)
        Me.AddUserToolStripMenuItem.Text = "AddUser"
        '
        'tbTDC
        '
        Me.tbTDC.Controls.Add(Me.Label5)
        Me.tbTDC.Controls.Add(Me.Panel2)
        Me.tbTDC.Location = New System.Drawing.Point(4, 25)
        Me.tbTDC.Name = "tbTDC"
        Me.tbTDC.Padding = New System.Windows.Forms.Padding(3)
        Me.tbTDC.Size = New System.Drawing.Size(764, 290)
        Me.tbTDC.TabIndex = 0
        Me.tbTDC.Text = "  TDC   "
        Me.tbTDC.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "TDC Setting"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rbTDCDisa)
        Me.Panel2.Controls.Add(Me.rbTDCEna)
        Me.Panel2.Location = New System.Drawing.Point(33, 42)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(149, 52)
        Me.Panel2.TabIndex = 2
        '
        'rbTDCDisa
        '
        Me.rbTDCDisa.AutoSize = True
        Me.rbTDCDisa.Location = New System.Drawing.Point(3, 29)
        Me.rbTDCDisa.Name = "rbTDCDisa"
        Me.rbTDCDisa.Size = New System.Drawing.Size(104, 20)
        Me.rbTDCDisa.TabIndex = 1
        Me.rbTDCDisa.Text = "TDC Disable"
        Me.rbTDCDisa.UseVisualStyleBackColor = True
        '
        'rbTDCEna
        '
        Me.rbTDCEna.AutoSize = True
        Me.rbTDCEna.Location = New System.Drawing.Point(3, 3)
        Me.rbTDCEna.Name = "rbTDCEna"
        Me.rbTDCEna.Size = New System.Drawing.Size(100, 20)
        Me.rbTDCEna.TabIndex = 1
        Me.rbTDCEna.Text = "TDC Enable"
        Me.rbTDCEna.UseVisualStyleBackColor = True
        '
        'tbSecsGem
        '
        Me.tbSecsGem.AutoScroll = True
        Me.tbSecsGem.Controls.Add(Me.dgvTimer)
        Me.tbSecsGem.Controls.Add(Me.Label6)
        Me.tbSecsGem.Controls.Add(Me.Panel3)
        Me.tbSecsGem.Controls.Add(Me.btnTimeoutChg)
        Me.tbSecsGem.Controls.Add(Me.btnEquipPortChg)
        Me.tbSecsGem.Controls.Add(Me.btnEquipIPChg)
        Me.tbSecsGem.Controls.Add(Me.Label4)
        Me.tbSecsGem.Controls.Add(Me.tbxEqiupPort)
        Me.tbSecsGem.Controls.Add(Me.tbxEqiupIP)
        Me.tbSecsGem.Controls.Add(Me.Panel1)
        Me.tbSecsGem.Controls.Add(Me.Label3)
        Me.tbSecsGem.Controls.Add(Me.Label1)
        Me.tbSecsGem.Controls.Add(Me.Label2)
        Me.tbSecsGem.Location = New System.Drawing.Point(4, 25)
        Me.tbSecsGem.Name = "tbSecsGem"
        Me.tbSecsGem.Padding = New System.Windows.Forms.Padding(3)
        Me.tbSecsGem.Size = New System.Drawing.Size(764, 290)
        Me.tbSecsGem.TabIndex = 1
        Me.tbSecsGem.Text = "Secs/Gem"
        Me.tbSecsGem.UseVisualStyleBackColor = True
        '
        'dgvTimer
        '
        Me.dgvTimer.AllowUserToAddRows = False
        Me.dgvTimer.AllowUserToDeleteRows = False
        Me.dgvTimer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTimer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTimer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvTimer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ParaName, Me.ParaValue})
        Me.dgvTimer.Location = New System.Drawing.Point(442, 46)
        Me.dgvTimer.Name = "dgvTimer"
        Me.dgvTimer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvTimer.RowHeadersVisible = False
        Me.dgvTimer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvTimer.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvTimer.Size = New System.Drawing.Size(294, 134)
        Me.dgvTimer.TabIndex = 7
        '
        'ParaName
        '
        Me.ParaName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ParaName.DefaultCellStyle = DataGridViewCellStyle1
        Me.ParaName.HeaderText = "Name"
        Me.ParaName.Name = "ParaName"
        Me.ParaName.ReadOnly = True
        Me.ParaName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ParaName.Width = 51
        '
        'ParaValue
        '
        Me.ParaValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ParaValue.DefaultCellStyle = DataGridViewCellStyle2
        Me.ParaValue.HeaderText = "Value(Sec) "
        Me.ParaValue.Name = "ParaValue"
        Me.ParaValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 16)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Secs  Setting"
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(28, 226)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(173, 41)
        Me.Panel3.TabIndex = 6
        '
        'btnTimeoutChg
        '
        Me.btnTimeoutChg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTimeoutChg.Location = New System.Drawing.Point(661, 186)
        Me.btnTimeoutChg.Name = "btnTimeoutChg"
        Me.btnTimeoutChg.Size = New System.Drawing.Size(75, 26)
        Me.btnTimeoutChg.TabIndex = 4
        Me.btnTimeoutChg.Text = "Change"
        Me.btnTimeoutChg.UseVisualStyleBackColor = True
        '
        'btnEquipPortChg
        '
        Me.btnEquipPortChg.Location = New System.Drawing.Point(256, 191)
        Me.btnEquipPortChg.Name = "btnEquipPortChg"
        Me.btnEquipPortChg.Size = New System.Drawing.Size(75, 26)
        Me.btnEquipPortChg.TabIndex = 4
        Me.btnEquipPortChg.Text = "Change"
        Me.btnEquipPortChg.UseVisualStyleBackColor = True
        '
        'btnEquipIPChg
        '
        Me.btnEquipIPChg.Location = New System.Drawing.Point(256, 163)
        Me.btnEquipIPChg.Name = "btnEquipIPChg"
        Me.btnEquipIPChg.Size = New System.Drawing.Size(75, 26)
        Me.btnEquipIPChg.TabIndex = 4
        Me.btnEquipIPChg.Text = "Change"
        Me.btnEquipIPChg.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Port :"
        '
        'tbxEqiupPort
        '
        Me.tbxEqiupPort.Location = New System.Drawing.Point(76, 192)
        Me.tbxEqiupPort.Name = "tbxEqiupPort"
        Me.tbxEqiupPort.Size = New System.Drawing.Size(173, 22)
        Me.tbxEqiupPort.TabIndex = 2
        '
        'tbxEqiupIP
        '
        Me.tbxEqiupIP.Location = New System.Drawing.Point(77, 164)
        Me.tbxEqiupIP.Name = "tbxEqiupIP"
        Me.tbxEqiupIP.Size = New System.Drawing.Size(173, 22)
        Me.tbxEqiupIP.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbSecsDis)
        Me.Panel1.Controls.Add(Me.rbSecsEna)
        Me.Panel1.Location = New System.Drawing.Point(40, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(209, 52)
        Me.Panel1.TabIndex = 0
        '
        'rbSecsDis
        '
        Me.rbSecsDis.AutoSize = True
        Me.rbSecsDis.Location = New System.Drawing.Point(3, 29)
        Me.rbSecsDis.Name = "rbSecsDis"
        Me.rbSecsDis.Size = New System.Drawing.Size(107, 20)
        Me.rbSecsDis.TabIndex = 1
        Me.rbSecsDis.Text = "Secs Disable"
        Me.rbSecsDis.UseVisualStyleBackColor = True
        '
        'rbSecsEna
        '
        Me.rbSecsEna.AutoSize = True
        Me.rbSecsEna.Location = New System.Drawing.Point(3, 3)
        Me.rbSecsEna.Name = "rbSecsEna"
        Me.rbSecsEna.Size = New System.Drawing.Size(103, 20)
        Me.rbSecsEna.TabIndex = 1
        Me.rbSecsEna.Text = "Secs Enable"
        Me.rbSecsEna.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "IP : "
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(413, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Protocal Timeout"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Equipment IP"
        '
        'tbCsPro
        '
        Me.tbCsPro.Controls.Add(Me.btnCsPortChg)
        Me.tbCsPro.Controls.Add(Me.btnCsIPChg)
        Me.tbCsPro.Controls.Add(Me.Label9)
        Me.tbCsPro.Controls.Add(Me.tbxCsPort)
        Me.tbCsPro.Controls.Add(Me.tbxCsIP)
        Me.tbCsPro.Controls.Add(Me.Label10)
        Me.tbCsPro.Controls.Add(Me.Label11)
        Me.tbCsPro.Controls.Add(Me.Label7)
        Me.tbCsPro.Controls.Add(Me.Panel4)
        Me.tbCsPro.Location = New System.Drawing.Point(4, 25)
        Me.tbCsPro.Name = "tbCsPro"
        Me.tbCsPro.Padding = New System.Windows.Forms.Padding(3)
        Me.tbCsPro.Size = New System.Drawing.Size(764, 290)
        Me.tbCsPro.TabIndex = 3
        Me.tbCsPro.Text = "Custom Protocol"
        Me.tbCsPro.UseVisualStyleBackColor = True
        '
        'btnCsPortChg
        '
        Me.btnCsPortChg.Location = New System.Drawing.Point(249, 172)
        Me.btnCsPortChg.Name = "btnCsPortChg"
        Me.btnCsPortChg.Size = New System.Drawing.Size(75, 26)
        Me.btnCsPortChg.TabIndex = 11
        Me.btnCsPortChg.Text = "Change"
        Me.btnCsPortChg.UseVisualStyleBackColor = True
        '
        'btnCsIPChg
        '
        Me.btnCsIPChg.Location = New System.Drawing.Point(249, 144)
        Me.btnCsIPChg.Name = "btnCsIPChg"
        Me.btnCsIPChg.Size = New System.Drawing.Size(75, 26)
        Me.btnCsIPChg.TabIndex = 12
        Me.btnCsIPChg.Text = "Change"
        Me.btnCsIPChg.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(30, 179)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 16)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Port :"
        '
        'tbxCsPort
        '
        Me.tbxCsPort.Location = New System.Drawing.Point(69, 173)
        Me.tbxCsPort.Name = "tbxCsPort"
        Me.tbxCsPort.Size = New System.Drawing.Size(173, 22)
        Me.tbxCsPort.TabIndex = 9
        '
        'tbxCsIP
        '
        Me.tbxCsIP.Location = New System.Drawing.Point(70, 145)
        Me.tbxCsIP.Name = "tbxCsIP"
        Me.tbxCsIP.Size = New System.Drawing.Size(173, 22)
        Me.tbxCsIP.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(30, 148)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 16)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "IP : "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(17, 121)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 16)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Equipment IP"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(173, 16)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Custom Protocol Setting"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.rbProDis)
        Me.Panel4.Controls.Add(Me.rbProEna)
        Me.Panel4.Location = New System.Drawing.Point(39, 47)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(149, 52)
        Me.Panel4.TabIndex = 4
        '
        'rbProDis
        '
        Me.rbProDis.AutoSize = True
        Me.rbProDis.Location = New System.Drawing.Point(3, 29)
        Me.rbProDis.Name = "rbProDis"
        Me.rbProDis.Size = New System.Drawing.Size(126, 20)
        Me.rbProDis.TabIndex = 1
        Me.rbProDis.Text = "Protocol Disable"
        Me.rbProDis.UseVisualStyleBackColor = True
        '
        'rbProEna
        '
        Me.rbProEna.AutoSize = True
        Me.rbProEna.Location = New System.Drawing.Point(3, 3)
        Me.rbProEna.Name = "rbProEna"
        Me.rbProEna.Size = New System.Drawing.Size(122, 20)
        Me.rbProEna.TabIndex = 1
        Me.rbProEna.Text = "Protocol Enable"
        Me.rbProEna.UseVisualStyleBackColor = True
        '
        'Setting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(772, 319)
        Me.Controls.Add(Me.tbSetting)
        Me.Name = "Setting"
        Me.Text = "Setting"
        Me.tbSetting.ResumeLayout(False)
        Me.tbComSetting.ResumeLayout(False)
        Me.tbComSetting.PerformLayout()
        CType(Me.dgvSetting, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.tbTDC.ResumeLayout(False)
        Me.tbTDC.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.tbSecsGem.ResumeLayout(False)
        Me.tbSecsGem.PerformLayout()
        CType(Me.dgvTimer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tbCsPro.ResumeLayout(False)
        Me.tbCsPro.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbSetting As System.Windows.Forms.TabControl
    Friend WithEvents tbTDC As System.Windows.Forms.TabPage
    Friend WithEvents tbSecsGem As System.Windows.Forms.TabPage
    Friend WithEvents tbComSetting As System.Windows.Forms.TabPage
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents dgvSetting As System.Windows.Forms.DataGridView
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rbSecsDis As System.Windows.Forms.RadioButton
    Friend WithEvents rbSecsEna As System.Windows.Forms.RadioButton
    Friend WithEvents btnEquipPortChg As System.Windows.Forms.Button
    Friend WithEvents btnEquipIPChg As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbxEqiupPort As System.Windows.Forms.TextBox
    Friend WithEvents tbxEqiupIP As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvTimer As System.Windows.Forms.DataGridView
    Friend WithEvents ColName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Value As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnTimeoutChg As System.Windows.Forms.Button
    Friend WithEvents ParaName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ParaValue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents rbTDCDisa As System.Windows.Forms.RadioButton
    Friend WithEvents rbTDCEna As System.Windows.Forms.RadioButton
    Friend WithEvents tbCsPro As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents rbProDis As System.Windows.Forms.RadioButton
    Friend WithEvents rbProEna As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents AddUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCsPortChg As System.Windows.Forms.Button
    Friend WithEvents btnCsIPChg As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbxCsPort As System.Windows.Forms.TextBox
    Friend WithEvents tbxCsIP As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class

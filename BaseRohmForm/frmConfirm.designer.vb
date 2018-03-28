<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfirm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbTotalInput = New System.Windows.Forms.Label()
        Me.lbTotalGood = New System.Windows.Forms.Label()
        Me.lbTotalNG = New System.Windows.Forms.Label()
        Me.tbTotalInput = New System.Windows.Forms.TextBox()
        Me.tbTotalGood = New System.Windows.Forms.TextBox()
        Me.tbTotalNG = New System.Windows.Forms.TextBox()
        Me.lbLotNo = New System.Windows.Forms.Label()
        Me.lbStartTime = New System.Windows.Forms.Label()
        Me.lbEndTime = New System.Windows.Forms.Label()
        Me.tbDummy = New System.Windows.Forms.TextBox()
        Me.tbOPJudge = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbMagazine = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbDevice = New System.Windows.Forms.Label()
        Me.lbPackage = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbFrameOut = New System.Windows.Forms.Label()
        Me.lbFrameIn = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DBxDataSet = New CellController.DBxDataSet()
        Me.FrameTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FrameTableTableAdapter = New CellController.DBxDataSetTableAdapters.FrameTableTableAdapter()
        Me.QueriesTableAdapter1 = New CellController.DBxDataSetTableAdapters.QueriesTableAdapter()
        Me.gbMessage = New System.Windows.Forms.GroupBox()
        Me.lbMessageDevice = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DBxDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FrameTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbMessage.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lot No."
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Total Input"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(211, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Total Good"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(404, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Total NG"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(629, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Dummy"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 168)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Start Time"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(365, 168)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "End Time"
        '
        'lbTotalInput
        '
        Me.lbTotalInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTotalInput.Location = New System.Drawing.Point(25, 42)
        Me.lbTotalInput.Name = "lbTotalInput"
        Me.lbTotalInput.Size = New System.Drawing.Size(105, 20)
        Me.lbTotalInput.TabIndex = 0
        Me.lbTotalInput.Text = "Total Input"
        Me.lbTotalInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbTotalGood
        '
        Me.lbTotalGood.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTotalGood.Location = New System.Drawing.Point(211, 42)
        Me.lbTotalGood.Name = "lbTotalGood"
        Me.lbTotalGood.Size = New System.Drawing.Size(113, 20)
        Me.lbTotalGood.TabIndex = 0
        Me.lbTotalGood.Text = "Total Good"
        Me.lbTotalGood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbTotalNG
        '
        Me.lbTotalNG.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTotalNG.Location = New System.Drawing.Point(404, 42)
        Me.lbTotalNG.Name = "lbTotalNG"
        Me.lbTotalNG.Size = New System.Drawing.Size(95, 20)
        Me.lbTotalNG.TabIndex = 0
        Me.lbTotalNG.Text = "Total NG"
        Me.lbTotalNG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbTotalInput
        '
        Me.tbTotalInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbTotalInput.Location = New System.Drawing.Point(25, 72)
        Me.tbTotalInput.Name = "tbTotalInput"
        Me.tbTotalInput.Size = New System.Drawing.Size(105, 26)
        Me.tbTotalInput.TabIndex = 4
        Me.tbTotalInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbTotalGood
        '
        Me.tbTotalGood.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbTotalGood.Location = New System.Drawing.Point(211, 72)
        Me.tbTotalGood.Name = "tbTotalGood"
        Me.tbTotalGood.Size = New System.Drawing.Size(113, 26)
        Me.tbTotalGood.TabIndex = 3
        Me.tbTotalGood.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbTotalNG
        '
        Me.tbTotalNG.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbTotalNG.Location = New System.Drawing.Point(404, 72)
        Me.tbTotalNG.Name = "tbTotalNG"
        Me.tbTotalNG.Size = New System.Drawing.Size(97, 26)
        Me.tbTotalNG.TabIndex = 2
        Me.tbTotalNG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbLotNo
        '
        Me.lbLotNo.AutoSize = True
        Me.lbLotNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbLotNo.Location = New System.Drawing.Point(139, 30)
        Me.lbLotNo.Name = "lbLotNo"
        Me.lbLotNo.Size = New System.Drawing.Size(60, 20)
        Me.lbLotNo.TabIndex = 0
        Me.lbLotNo.Text = "Lot No."
        '
        'lbStartTime
        '
        Me.lbStartTime.AutoSize = True
        Me.lbStartTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbStartTime.Location = New System.Drawing.Point(139, 168)
        Me.lbStartTime.Name = "lbStartTime"
        Me.lbStartTime.Size = New System.Drawing.Size(82, 20)
        Me.lbStartTime.TabIndex = 0
        Me.lbStartTime.Text = "Start Time"
        '
        'lbEndTime
        '
        Me.lbEndTime.AutoSize = True
        Me.lbEndTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbEndTime.Location = New System.Drawing.Point(481, 168)
        Me.lbEndTime.Name = "lbEndTime"
        Me.lbEndTime.Size = New System.Drawing.Size(76, 20)
        Me.lbEndTime.TabIndex = 0
        Me.lbEndTime.Text = "End Time"
        '
        'tbDummy
        '
        Me.tbDummy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbDummy.Location = New System.Drawing.Point(619, 71)
        Me.tbDummy.Name = "tbDummy"
        Me.tbDummy.Size = New System.Drawing.Size(89, 26)
        Me.tbDummy.TabIndex = 5
        Me.tbDummy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbOPJudge
        '
        Me.tbOPJudge.BackColor = System.Drawing.Color.Yellow
        Me.tbOPJudge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbOPJudge.Location = New System.Drawing.Point(10, 32)
        Me.tbOPJudge.Name = "tbOPJudge"
        Me.tbOPJudge.Size = New System.Drawing.Size(119, 26)
        Me.tbOPJudge.TabIndex = 0
        Me.tbOPJudge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Aquamarine
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.Location = New System.Drawing.Point(6, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(54, 48)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Aquamarine
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button2.Location = New System.Drawing.Point(68, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(54, 48)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Aquamarine
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button3.Location = New System.Drawing.Point(128, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(54, 48)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Aquamarine
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button4.Location = New System.Drawing.Point(188, 19)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(54, 48)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "4"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Aquamarine
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button5.Location = New System.Drawing.Point(248, 19)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(54, 48)
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Aquamarine
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button6.Location = New System.Drawing.Point(311, 19)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(54, 48)
        Me.Button6.TabIndex = 2
        Me.Button6.Text = "6"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Aquamarine
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button7.Location = New System.Drawing.Point(371, 19)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(54, 48)
        Me.Button7.TabIndex = 2
        Me.Button7.Text = "7"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Aquamarine
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button8.Location = New System.Drawing.Point(431, 19)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(54, 48)
        Me.Button8.TabIndex = 2
        Me.Button8.Text = "8"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Aquamarine
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button9.Location = New System.Drawing.Point(491, 19)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(54, 48)
        Me.Button9.TabIndex = 2
        Me.Button9.Text = "9"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.Aquamarine
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button10.Location = New System.Drawing.Point(552, 19)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(54, 48)
        Me.Button10.TabIndex = 2
        Me.Button10.Text = "0"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.Aquamarine
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button11.Location = New System.Drawing.Point(612, 19)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(54, 48)
        Me.Button11.TabIndex = 2
        Me.Button11.Text = "BS"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.Aquamarine
        Me.Button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button12.Location = New System.Drawing.Point(672, 19)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(54, 48)
        Me.Button12.TabIndex = 2
        Me.Button12.Text = "CLR"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Wheat
        Me.GroupBox1.Controls.Add(Me.lbEndTime)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lbMagazine)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.lbDevice)
        Me.GroupBox1.Controls.Add(Me.lbPackage)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lbFrameOut)
        Me.GroupBox1.Controls.Add(Me.lbFrameIn)
        Me.GroupBox1.Controls.Add(Me.lbStartTime)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lbLotNo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(733, 220)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Prodution Data"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Frame Out"
        '
        'lbMagazine
        '
        Me.lbMagazine.AutoSize = True
        Me.lbMagazine.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbMagazine.Location = New System.Drawing.Point(481, 119)
        Me.lbMagazine.Name = "lbMagazine"
        Me.lbMagazine.Size = New System.Drawing.Size(78, 20)
        Me.lbMagazine.TabIndex = 0
        Me.lbMagazine.Text = "Magazine"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(363, 119)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 20)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Magazine"
        '
        'lbDevice
        '
        Me.lbDevice.AutoSize = True
        Me.lbDevice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbDevice.Location = New System.Drawing.Point(481, 73)
        Me.lbDevice.Name = "lbDevice"
        Me.lbDevice.Size = New System.Drawing.Size(57, 20)
        Me.lbDevice.TabIndex = 0
        Me.lbDevice.Text = "Device"
        '
        'lbPackage
        '
        Me.lbPackage.AutoSize = True
        Me.lbPackage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbPackage.Location = New System.Drawing.Point(481, 30)
        Me.lbPackage.Name = "lbPackage"
        Me.lbPackage.Size = New System.Drawing.Size(71, 20)
        Me.lbPackage.TabIndex = 0
        Me.lbPackage.Text = "Package"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(367, 73)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 20)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Device"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(367, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 20)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Package"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Frame In"
        '
        'lbFrameOut
        '
        Me.lbFrameOut.AutoSize = True
        Me.lbFrameOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbFrameOut.Location = New System.Drawing.Point(139, 119)
        Me.lbFrameOut.Name = "lbFrameOut"
        Me.lbFrameOut.Size = New System.Drawing.Size(81, 20)
        Me.lbFrameOut.TabIndex = 0
        Me.lbFrameOut.Text = "FrameOut"
        '
        'lbFrameIn
        '
        Me.lbFrameIn.AutoSize = True
        Me.lbFrameIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbFrameIn.Location = New System.Drawing.Point(139, 73)
        Me.lbFrameIn.Name = "lbFrameIn"
        Me.lbFrameIn.Size = New System.Drawing.Size(73, 20)
        Me.lbFrameIn.TabIndex = 0
        Me.lbFrameIn.Text = "Frame In"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Wheat
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.tbTotalNG)
        Me.GroupBox2.Controls.Add(Me.tbTotalGood)
        Me.GroupBox2.Controls.Add(Me.tbTotalInput)
        Me.GroupBox2.Controls.Add(Me.lbTotalNG)
        Me.GroupBox2.Controls.Add(Me.lbTotalGood)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lbTotalInput)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 372)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(734, 114)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.tbOPJudge)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(560, 26)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(152, 72)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "OP Judgement"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Wheat
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Button13)
        Me.GroupBox3.Controls.Add(Me.Button14)
        Me.GroupBox3.Controls.Add(Me.Button15)
        Me.GroupBox3.Controls.Add(Me.Button16)
        Me.GroupBox3.Controls.Add(Me.Button17)
        Me.GroupBox3.Controls.Add(Me.Button19)
        Me.GroupBox3.Controls.Add(Me.Button18)
        Me.GroupBox3.Controls.Add(Me.tbDummy)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(10, 238)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(734, 125)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Dummy"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(18, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(476, 20)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "กรุณาเลือกจำนวน Dummy ถ้ามากกว่า 6 กรุณาใช้ Numpad ด้านล่าง"
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.GreenYellow
        Me.Button13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button13.Location = New System.Drawing.Point(529, 58)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(54, 48)
        Me.Button13.TabIndex = 6
        Me.Button13.Text = "6"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.GreenYellow
        Me.Button14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button14.Location = New System.Drawing.Point(274, 58)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(54, 48)
        Me.Button14.TabIndex = 7
        Me.Button14.Text = "3"
        Me.Button14.UseVisualStyleBackColor = False
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.GreenYellow
        Me.Button15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button15.Location = New System.Drawing.Point(445, 58)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(54, 48)
        Me.Button15.TabIndex = 8
        Me.Button15.Text = "5"
        Me.Button15.UseVisualStyleBackColor = False
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.Color.GreenYellow
        Me.Button16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button16.Location = New System.Drawing.Point(360, 58)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(54, 48)
        Me.Button16.TabIndex = 3
        Me.Button16.Text = "4"
        Me.Button16.UseVisualStyleBackColor = False
        '
        'Button17
        '
        Me.Button17.BackColor = System.Drawing.Color.GreenYellow
        Me.Button17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button17.Location = New System.Drawing.Point(188, 58)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(54, 48)
        Me.Button17.TabIndex = 4
        Me.Button17.Text = "2"
        Me.Button17.UseVisualStyleBackColor = False
        '
        'Button19
        '
        Me.Button19.BackColor = System.Drawing.Color.GreenYellow
        Me.Button19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button19.Location = New System.Drawing.Point(18, 58)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(54, 48)
        Me.Button19.TabIndex = 5
        Me.Button19.Text = "0"
        Me.Button19.UseVisualStyleBackColor = False
        '
        'Button18
        '
        Me.Button18.BackColor = System.Drawing.Color.GreenYellow
        Me.Button18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button18.Location = New System.Drawing.Point(104, 58)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(54, 48)
        Me.Button18.TabIndex = 5
        Me.Button18.Text = "1"
        Me.Button18.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Wheat
        Me.GroupBox5.Controls.Add(Me.Button12)
        Me.GroupBox5.Controls.Add(Me.Button11)
        Me.GroupBox5.Controls.Add(Me.Button10)
        Me.GroupBox5.Controls.Add(Me.Button9)
        Me.GroupBox5.Controls.Add(Me.Button6)
        Me.GroupBox5.Controls.Add(Me.Button3)
        Me.GroupBox5.Controls.Add(Me.Button8)
        Me.GroupBox5.Controls.Add(Me.Button5)
        Me.GroupBox5.Controls.Add(Me.Button7)
        Me.GroupBox5.Controls.Add(Me.Button4)
        Me.GroupBox5.Controls.Add(Me.Button2)
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(10, 494)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(734, 81)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Numpad"
        '
        'DBxDataSet
        '
        Me.DBxDataSet.DataSetName = "DBxDataSet"
        Me.DBxDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FrameTableBindingSource
        '
        Me.FrameTableBindingSource.DataMember = "FrameTable"
        Me.FrameTableBindingSource.DataSource = Me.DBxDataSet
        '
        'FrameTableTableAdapter
        '
        Me.FrameTableTableAdapter.ClearBeforeFill = True
        '
        'gbMessage
        '
        Me.gbMessage.BackColor = System.Drawing.Color.Wheat
        Me.gbMessage.Controls.Add(Me.lbMessageDevice)
        Me.gbMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.gbMessage.Location = New System.Drawing.Point(8, 581)
        Me.gbMessage.Name = "gbMessage"
        Me.gbMessage.Size = New System.Drawing.Size(733, 71)
        Me.gbMessage.TabIndex = 4
        Me.gbMessage.TabStop = False
        Me.gbMessage.Text = "Message"
        '
        'lbMessageDevice
        '
        Me.lbMessageDevice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbMessageDevice.Location = New System.Drawing.Point(11, 21)
        Me.lbMessageDevice.Name = "lbMessageDevice"
        Me.lbMessageDevice.Size = New System.Drawing.Size(710, 37)
        Me.lbMessageDevice.TabIndex = 0
        Me.lbMessageDevice.Text = "Label14"
        Me.lbMessageDevice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'frmConfirm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(753, 660)
        Me.Controls.Add(Me.gbMessage)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConfirm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmConfirm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.DBxDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FrameTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbMessage.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbTotalInput As System.Windows.Forms.Label
    Friend WithEvents lbTotalGood As System.Windows.Forms.Label
    Friend WithEvents lbTotalNG As System.Windows.Forms.Label
    Friend WithEvents tbTotalInput As System.Windows.Forms.TextBox
    Friend WithEvents tbTotalGood As System.Windows.Forms.TextBox
    Friend WithEvents tbTotalNG As System.Windows.Forms.TextBox
    Friend WithEvents lbLotNo As System.Windows.Forms.Label
    Friend WithEvents lbStartTime As System.Windows.Forms.Label
    Friend WithEvents lbEndTime As System.Windows.Forms.Label
    Friend WithEvents tbDummy As System.Windows.Forms.TextBox
    Friend WithEvents tbOPJudge As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents Button18 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button19 As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbFrameOut As System.Windows.Forms.Label
    Friend WithEvents lbFrameIn As System.Windows.Forms.Label
    Friend WithEvents DBxDataSet As CellController.DBxDataSet
    Friend WithEvents FrameTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FrameTableTableAdapter As CellController.DBxDataSetTableAdapters.FrameTableTableAdapter
    Friend WithEvents lbMagazine As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lbPackage As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents QueriesTableAdapter1 As CellController.DBxDataSetTableAdapters.QueriesTableAdapter
    Friend WithEvents lbDevice As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents gbMessage As System.Windows.Forms.GroupBox
    Friend WithEvents lbMessageDevice As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class

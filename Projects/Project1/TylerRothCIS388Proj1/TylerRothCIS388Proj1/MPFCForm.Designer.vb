<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtTestNum = New System.Windows.Forms.TextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTestNum = New System.Windows.Forms.Label()
        Me.lblInventorLastName = New System.Windows.Forms.Label()
        Me.lblInventorFirstName = New System.Windows.Forms.Label()
        Me.txtInventorFirstName = New System.Windows.Forms.TextBox()
        Me.txtInventorLastName = New System.Windows.Forms.TextBox()
        Me.grpTestInfo = New System.Windows.Forms.GroupBox()
        Me.grpInventorInfo = New System.Windows.Forms.GroupBox()
        Me.grpDriverInfo = New System.Windows.Forms.GroupBox()
        Me.picSimpson = New System.Windows.Forms.PictureBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblDriverInfoLastName = New System.Windows.Forms.Label()
        Me.lblDriverInfoFirstName = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtDriverInfoLastName = New System.Windows.Forms.TextBox()
        Me.txtDriverInfoFirstName = New System.Windows.Forms.TextBox()
        Me.cboId = New System.Windows.Forms.ComboBox()
        Me.pnlData = New System.Windows.Forms.Panel()
        Me.txtEndFuel4 = New System.Windows.Forms.TextBox()
        Me.txtEndFuel3 = New System.Windows.Forms.TextBox()
        Me.txtEndFuel2 = New System.Windows.Forms.TextBox()
        Me.txtEndFuel1 = New System.Windows.Forms.TextBox()
        Me.txtStartFuel4 = New System.Windows.Forms.TextBox()
        Me.txtStartFuel3 = New System.Windows.Forms.TextBox()
        Me.txtStartFuel2 = New System.Windows.Forms.TextBox()
        Me.txtStartFuel1 = New System.Windows.Forms.TextBox()
        Me.txtEndMileage4 = New System.Windows.Forms.TextBox()
        Me.txtEndMileage3 = New System.Windows.Forms.TextBox()
        Me.txtEndMileage2 = New System.Windows.Forms.TextBox()
        Me.txtEndMileage1 = New System.Windows.Forms.TextBox()
        Me.txtStartMileage4 = New System.Windows.Forms.TextBox()
        Me.txtStartMileage3 = New System.Windows.Forms.TextBox()
        Me.txtStartMileage2 = New System.Windows.Forms.TextBox()
        Me.txtStartMileage1 = New System.Windows.Forms.TextBox()
        Me.cboDataVehcile4 = New System.Windows.Forms.ComboBox()
        Me.cboDataVehcile3 = New System.Windows.Forms.ComboBox()
        Me.cboDataVehcile2 = New System.Windows.Forms.ComboBox()
        Me.cboDataVehcile1 = New System.Windows.Forms.ComboBox()
        Me.lblDataVehcile = New System.Windows.Forms.Label()
        Me.lblStartMileage = New System.Windows.Forms.Label()
        Me.lblEndMileage = New System.Windows.Forms.Label()
        Me.lblStartFuel = New System.Windows.Forms.Label()
        Me.lblEndFuel = New System.Windows.Forms.Label()
        Me.pnlResults = New System.Windows.Forms.Panel()
        Me.txtMpfcRating4 = New System.Windows.Forms.TextBox()
        Me.txtMpfcRating3 = New System.Windows.Forms.TextBox()
        Me.txtMpfcRating2 = New System.Windows.Forms.TextBox()
        Me.txtMpfcRating1 = New System.Windows.Forms.TextBox()
        Me.txtFuelCost4 = New System.Windows.Forms.TextBox()
        Me.txtFuelCost3 = New System.Windows.Forms.TextBox()
        Me.txtFuelCost2 = New System.Windows.Forms.TextBox()
        Me.txtFuelCost1 = New System.Windows.Forms.TextBox()
        Me.txtFuelUsed4 = New System.Windows.Forms.TextBox()
        Me.txtFuelUsed3 = New System.Windows.Forms.TextBox()
        Me.txtFuelUsed2 = New System.Windows.Forms.TextBox()
        Me.txtFuelUsed1 = New System.Windows.Forms.TextBox()
        Me.txtMileage4 = New System.Windows.Forms.TextBox()
        Me.txtMileage3 = New System.Windows.Forms.TextBox()
        Me.txtMileage2 = New System.Windows.Forms.TextBox()
        Me.txtMileage1 = New System.Windows.Forms.TextBox()
        Me.txtFamily4 = New System.Windows.Forms.TextBox()
        Me.txtFamily3 = New System.Windows.Forms.TextBox()
        Me.txtFamily2 = New System.Windows.Forms.TextBox()
        Me.txtFamily1 = New System.Windows.Forms.TextBox()
        Me.txtVehicle4 = New System.Windows.Forms.TextBox()
        Me.txtVehicle3 = New System.Windows.Forms.TextBox()
        Me.txtVehicle2 = New System.Windows.Forms.TextBox()
        Me.txtVehicle1 = New System.Windows.Forms.TextBox()
        Me.lblResultsVehicle = New System.Windows.Forms.Label()
        Me.lblMileage = New System.Windows.Forms.Label()
        Me.lblFamily = New System.Windows.Forms.Label()
        Me.lblFuelUsed = New System.Windows.Forms.Label()
        Me.lblFuelCost = New System.Windows.Forms.Label()
        Me.lblMpfcRating = New System.Windows.Forms.Label()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAllTests = New System.Windows.Forms.Button()
        Me.MpfcErros = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblResults = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.grpTestInfo.SuspendLayout()
        Me.grpInventorInfo.SuspendLayout()
        Me.grpDriverInfo.SuspendLayout()
        CType(Me.picSimpson, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlData.SuspendLayout()
        Me.pnlResults.SuspendLayout()
        CType(Me.MpfcErros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(21, 35)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(459, 29)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Miles Per Fuel Cell (MPFC) Calculator"
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(76, 59)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(121, 20)
        Me.txtDate.TabIndex = 3
        '
        'txtTestNum
        '
        Me.txtTestNum.Location = New System.Drawing.Point(76, 24)
        Me.txtTestNum.Name = "txtTestNum"
        Me.txtTestNum.Size = New System.Drawing.Size(121, 20)
        Me.txtTestNum.TabIndex = 2
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(7, 66)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "Date:"
        '
        'lblTestNum
        '
        Me.lblTestNum.AutoSize = True
        Me.lblTestNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTestNum.Location = New System.Drawing.Point(7, 31)
        Me.lblTestNum.Name = "lblTestNum"
        Me.lblTestNum.Size = New System.Drawing.Size(38, 13)
        Me.lblTestNum.TabIndex = 0
        Me.lblTestNum.Text = "Test #"
        '
        'lblInventorLastName
        '
        Me.lblInventorLastName.AutoSize = True
        Me.lblInventorLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInventorLastName.Location = New System.Drawing.Point(7, 72)
        Me.lblInventorLastName.Name = "lblInventorLastName"
        Me.lblInventorLastName.Size = New System.Drawing.Size(61, 13)
        Me.lblInventorLastName.TabIndex = 3
        Me.lblInventorLastName.Text = "Last Name:"
        '
        'lblInventorFirstName
        '
        Me.lblInventorFirstName.AutoSize = True
        Me.lblInventorFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInventorFirstName.Location = New System.Drawing.Point(8, 33)
        Me.lblInventorFirstName.Name = "lblInventorFirstName"
        Me.lblInventorFirstName.Size = New System.Drawing.Size(60, 13)
        Me.lblInventorFirstName.TabIndex = 2
        Me.lblInventorFirstName.Text = "First Name:"
        '
        'txtInventorFirstName
        '
        Me.txtInventorFirstName.Location = New System.Drawing.Point(74, 26)
        Me.txtInventorFirstName.Name = "txtInventorFirstName"
        Me.txtInventorFirstName.Size = New System.Drawing.Size(119, 20)
        Me.txtInventorFirstName.TabIndex = 1
        '
        'txtInventorLastName
        '
        Me.txtInventorLastName.Location = New System.Drawing.Point(73, 66)
        Me.txtInventorLastName.Name = "txtInventorLastName"
        Me.txtInventorLastName.Size = New System.Drawing.Size(120, 20)
        Me.txtInventorLastName.TabIndex = 0
        '
        'grpTestInfo
        '
        Me.grpTestInfo.Controls.Add(Me.txtDate)
        Me.grpTestInfo.Controls.Add(Me.lblTestNum)
        Me.grpTestInfo.Controls.Add(Me.txtTestNum)
        Me.grpTestInfo.Controls.Add(Me.lblDate)
        Me.grpTestInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTestInfo.Location = New System.Drawing.Point(26, 95)
        Me.grpTestInfo.Name = "grpTestInfo"
        Me.grpTestInfo.Size = New System.Drawing.Size(242, 100)
        Me.grpTestInfo.TabIndex = 1
        Me.grpTestInfo.TabStop = False
        Me.grpTestInfo.Text = "Test Info"
        '
        'grpInventorInfo
        '
        Me.grpInventorInfo.Controls.Add(Me.txtInventorLastName)
        Me.grpInventorInfo.Controls.Add(Me.lblInventorLastName)
        Me.grpInventorInfo.Controls.Add(Me.txtInventorFirstName)
        Me.grpInventorInfo.Controls.Add(Me.lblInventorFirstName)
        Me.grpInventorInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpInventorInfo.Location = New System.Drawing.Point(296, 95)
        Me.grpInventorInfo.Name = "grpInventorInfo"
        Me.grpInventorInfo.Size = New System.Drawing.Size(241, 100)
        Me.grpInventorInfo.TabIndex = 6
        Me.grpInventorInfo.TabStop = False
        Me.grpInventorInfo.Text = "Inventor Info"
        '
        'grpDriverInfo
        '
        Me.grpDriverInfo.Controls.Add(Me.picSimpson)
        Me.grpDriverInfo.Controls.Add(Me.lblPhone)
        Me.grpDriverInfo.Controls.Add(Me.lblDriverInfoLastName)
        Me.grpDriverInfo.Controls.Add(Me.lblDriverInfoFirstName)
        Me.grpDriverInfo.Controls.Add(Me.lblId)
        Me.grpDriverInfo.Controls.Add(Me.txtPhone)
        Me.grpDriverInfo.Controls.Add(Me.txtDriverInfoLastName)
        Me.grpDriverInfo.Controls.Add(Me.txtDriverInfoFirstName)
        Me.grpDriverInfo.Controls.Add(Me.cboId)
        Me.grpDriverInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDriverInfo.Location = New System.Drawing.Point(26, 201)
        Me.grpDriverInfo.Name = "grpDriverInfo"
        Me.grpDriverInfo.Size = New System.Drawing.Size(511, 130)
        Me.grpDriverInfo.TabIndex = 7
        Me.grpDriverInfo.TabStop = False
        Me.grpDriverInfo.Text = "Driver Info"
        '
        'picSimpson
        '
        Me.picSimpson.Location = New System.Drawing.Point(294, 13)
        Me.picSimpson.Name = "picSimpson"
        Me.picSimpson.Size = New System.Drawing.Size(188, 101)
        Me.picSimpson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSimpson.TabIndex = 16
        Me.picSimpson.TabStop = False
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(7, 101)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(38, 13)
        Me.lblPhone.TabIndex = 15
        Me.lblPhone.Text = "Phone"
        '
        'lblDriverInfoLastName
        '
        Me.lblDriverInfoLastName.AutoSize = True
        Me.lblDriverInfoLastName.Location = New System.Drawing.Point(5, 75)
        Me.lblDriverInfoLastName.Name = "lblDriverInfoLastName"
        Me.lblDriverInfoLastName.Size = New System.Drawing.Size(61, 13)
        Me.lblDriverInfoLastName.TabIndex = 14
        Me.lblDriverInfoLastName.Text = "Last Name:"
        '
        'lblDriverInfoFirstName
        '
        Me.lblDriverInfoFirstName.AutoSize = True
        Me.lblDriverInfoFirstName.Location = New System.Drawing.Point(6, 49)
        Me.lblDriverInfoFirstName.Name = "lblDriverInfoFirstName"
        Me.lblDriverInfoFirstName.Size = New System.Drawing.Size(60, 13)
        Me.lblDriverInfoFirstName.TabIndex = 13
        Me.lblDriverInfoFirstName.Text = "First Name:"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(7, 27)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(21, 13)
        Me.lblId.TabIndex = 12
        Me.lblId.Text = "ID:"
        '
        'txtPhone
        '
        Me.txtPhone.Enabled = False
        Me.txtPhone.Location = New System.Drawing.Point(76, 94)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(121, 20)
        Me.txtPhone.TabIndex = 11
        '
        'txtDriverInfoLastName
        '
        Me.txtDriverInfoLastName.Enabled = False
        Me.txtDriverInfoLastName.Location = New System.Drawing.Point(76, 68)
        Me.txtDriverInfoLastName.Name = "txtDriverInfoLastName"
        Me.txtDriverInfoLastName.Size = New System.Drawing.Size(121, 20)
        Me.txtDriverInfoLastName.TabIndex = 10
        '
        'txtDriverInfoFirstName
        '
        Me.txtDriverInfoFirstName.Enabled = False
        Me.txtDriverInfoFirstName.Location = New System.Drawing.Point(76, 42)
        Me.txtDriverInfoFirstName.Name = "txtDriverInfoFirstName"
        Me.txtDriverInfoFirstName.Size = New System.Drawing.Size(121, 20)
        Me.txtDriverInfoFirstName.TabIndex = 9
        '
        'cboId
        '
        Me.cboId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboId.FormattingEnabled = True
        Me.cboId.Items.AddRange(New Object() {"100", "200", "300", "400"})
        Me.cboId.Location = New System.Drawing.Point(76, 19)
        Me.cboId.Name = "cboId"
        Me.cboId.Size = New System.Drawing.Size(121, 21)
        Me.cboId.TabIndex = 8
        '
        'pnlData
        '
        Me.pnlData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlData.Controls.Add(Me.txtEndFuel4)
        Me.pnlData.Controls.Add(Me.txtEndFuel3)
        Me.pnlData.Controls.Add(Me.txtEndFuel2)
        Me.pnlData.Controls.Add(Me.txtEndFuel1)
        Me.pnlData.Controls.Add(Me.txtStartFuel4)
        Me.pnlData.Controls.Add(Me.txtStartFuel3)
        Me.pnlData.Controls.Add(Me.txtStartFuel2)
        Me.pnlData.Controls.Add(Me.txtStartFuel1)
        Me.pnlData.Controls.Add(Me.txtEndMileage4)
        Me.pnlData.Controls.Add(Me.txtEndMileage3)
        Me.pnlData.Controls.Add(Me.txtEndMileage2)
        Me.pnlData.Controls.Add(Me.txtEndMileage1)
        Me.pnlData.Controls.Add(Me.txtStartMileage4)
        Me.pnlData.Controls.Add(Me.txtStartMileage3)
        Me.pnlData.Controls.Add(Me.txtStartMileage2)
        Me.pnlData.Controls.Add(Me.txtStartMileage1)
        Me.pnlData.Controls.Add(Me.cboDataVehcile4)
        Me.pnlData.Controls.Add(Me.cboDataVehcile3)
        Me.pnlData.Controls.Add(Me.cboDataVehcile2)
        Me.pnlData.Controls.Add(Me.cboDataVehcile1)
        Me.pnlData.Location = New System.Drawing.Point(36, 359)
        Me.pnlData.Name = "pnlData"
        Me.pnlData.Size = New System.Drawing.Size(580, 121)
        Me.pnlData.TabIndex = 9
        '
        'txtEndFuel4
        '
        Me.txtEndFuel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndFuel4.Location = New System.Drawing.Point(399, 88)
        Me.txtEndFuel4.Name = "txtEndFuel4"
        Me.txtEndFuel4.Size = New System.Drawing.Size(83, 20)
        Me.txtEndFuel4.TabIndex = 19
        '
        'txtEndFuel3
        '
        Me.txtEndFuel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndFuel3.Location = New System.Drawing.Point(399, 62)
        Me.txtEndFuel3.Name = "txtEndFuel3"
        Me.txtEndFuel3.Size = New System.Drawing.Size(83, 20)
        Me.txtEndFuel3.TabIndex = 18
        '
        'txtEndFuel2
        '
        Me.txtEndFuel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndFuel2.Location = New System.Drawing.Point(399, 33)
        Me.txtEndFuel2.Name = "txtEndFuel2"
        Me.txtEndFuel2.Size = New System.Drawing.Size(83, 20)
        Me.txtEndFuel2.TabIndex = 17
        '
        'txtEndFuel1
        '
        Me.txtEndFuel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndFuel1.Location = New System.Drawing.Point(399, 4)
        Me.txtEndFuel1.Name = "txtEndFuel1"
        Me.txtEndFuel1.Size = New System.Drawing.Size(83, 20)
        Me.txtEndFuel1.TabIndex = 16
        '
        'txtStartFuel4
        '
        Me.txtStartFuel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartFuel4.Location = New System.Drawing.Point(299, 87)
        Me.txtStartFuel4.Name = "txtStartFuel4"
        Me.txtStartFuel4.Size = New System.Drawing.Size(83, 20)
        Me.txtStartFuel4.TabIndex = 15
        '
        'txtStartFuel3
        '
        Me.txtStartFuel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartFuel3.Location = New System.Drawing.Point(299, 61)
        Me.txtStartFuel3.Name = "txtStartFuel3"
        Me.txtStartFuel3.Size = New System.Drawing.Size(83, 20)
        Me.txtStartFuel3.TabIndex = 14
        '
        'txtStartFuel2
        '
        Me.txtStartFuel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartFuel2.Location = New System.Drawing.Point(299, 31)
        Me.txtStartFuel2.Name = "txtStartFuel2"
        Me.txtStartFuel2.Size = New System.Drawing.Size(83, 20)
        Me.txtStartFuel2.TabIndex = 13
        '
        'txtStartFuel1
        '
        Me.txtStartFuel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartFuel1.Location = New System.Drawing.Point(299, 5)
        Me.txtStartFuel1.Name = "txtStartFuel1"
        Me.txtStartFuel1.Size = New System.Drawing.Size(83, 20)
        Me.txtStartFuel1.TabIndex = 12
        '
        'txtEndMileage4
        '
        Me.txtEndMileage4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndMileage4.Location = New System.Drawing.Point(206, 87)
        Me.txtEndMileage4.Name = "txtEndMileage4"
        Me.txtEndMileage4.Size = New System.Drawing.Size(83, 20)
        Me.txtEndMileage4.TabIndex = 11
        '
        'txtEndMileage3
        '
        Me.txtEndMileage3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndMileage3.Location = New System.Drawing.Point(206, 61)
        Me.txtEndMileage3.Name = "txtEndMileage3"
        Me.txtEndMileage3.Size = New System.Drawing.Size(83, 20)
        Me.txtEndMileage3.TabIndex = 10
        '
        'txtEndMileage2
        '
        Me.txtEndMileage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndMileage2.Location = New System.Drawing.Point(206, 31)
        Me.txtEndMileage2.Name = "txtEndMileage2"
        Me.txtEndMileage2.Size = New System.Drawing.Size(83, 20)
        Me.txtEndMileage2.TabIndex = 9
        '
        'txtEndMileage1
        '
        Me.txtEndMileage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndMileage1.Location = New System.Drawing.Point(206, 5)
        Me.txtEndMileage1.Name = "txtEndMileage1"
        Me.txtEndMileage1.Size = New System.Drawing.Size(83, 20)
        Me.txtEndMileage1.TabIndex = 8
        '
        'txtStartMileage4
        '
        Me.txtStartMileage4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartMileage4.Location = New System.Drawing.Point(117, 87)
        Me.txtStartMileage4.Name = "txtStartMileage4"
        Me.txtStartMileage4.Size = New System.Drawing.Size(83, 20)
        Me.txtStartMileage4.TabIndex = 7
        '
        'txtStartMileage3
        '
        Me.txtStartMileage3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartMileage3.Location = New System.Drawing.Point(117, 61)
        Me.txtStartMileage3.Name = "txtStartMileage3"
        Me.txtStartMileage3.Size = New System.Drawing.Size(83, 20)
        Me.txtStartMileage3.TabIndex = 6
        '
        'txtStartMileage2
        '
        Me.txtStartMileage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartMileage2.Location = New System.Drawing.Point(117, 31)
        Me.txtStartMileage2.Name = "txtStartMileage2"
        Me.txtStartMileage2.Size = New System.Drawing.Size(83, 20)
        Me.txtStartMileage2.TabIndex = 5
        '
        'txtStartMileage1
        '
        Me.txtStartMileage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartMileage1.Location = New System.Drawing.Point(117, 5)
        Me.txtStartMileage1.Name = "txtStartMileage1"
        Me.txtStartMileage1.Size = New System.Drawing.Size(83, 20)
        Me.txtStartMileage1.TabIndex = 4
        '
        'cboDataVehcile4
        '
        Me.cboDataVehcile4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDataVehcile4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDataVehcile4.FormattingEnabled = True
        Me.cboDataVehcile4.Items.AddRange(New Object() {"Banshee", "Ghost", "Chopper", "Hornet"})
        Me.cboDataVehcile4.Location = New System.Drawing.Point(6, 87)
        Me.cboDataVehcile4.Name = "cboDataVehcile4"
        Me.cboDataVehcile4.Size = New System.Drawing.Size(93, 21)
        Me.cboDataVehcile4.TabIndex = 3
        '
        'cboDataVehcile3
        '
        Me.cboDataVehcile3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDataVehcile3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDataVehcile3.FormattingEnabled = True
        Me.cboDataVehcile3.Items.AddRange(New Object() {"Banshee", "Ghost", "Chopper", "Hornet"})
        Me.cboDataVehcile3.Location = New System.Drawing.Point(7, 59)
        Me.cboDataVehcile3.Name = "cboDataVehcile3"
        Me.cboDataVehcile3.Size = New System.Drawing.Size(92, 21)
        Me.cboDataVehcile3.TabIndex = 2
        '
        'cboDataVehcile2
        '
        Me.cboDataVehcile2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDataVehcile2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDataVehcile2.FormattingEnabled = True
        Me.cboDataVehcile2.Items.AddRange(New Object() {"Banshee", "Ghost", "Chopper", "Hornet"})
        Me.cboDataVehcile2.Location = New System.Drawing.Point(8, 32)
        Me.cboDataVehcile2.Name = "cboDataVehcile2"
        Me.cboDataVehcile2.Size = New System.Drawing.Size(91, 21)
        Me.cboDataVehcile2.TabIndex = 1
        '
        'cboDataVehcile1
        '
        Me.cboDataVehcile1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDataVehcile1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDataVehcile1.FormattingEnabled = True
        Me.cboDataVehcile1.Items.AddRange(New Object() {"Banshee", "Ghost", "Chopper", "Hornet"})
        Me.cboDataVehcile1.Location = New System.Drawing.Point(9, 3)
        Me.cboDataVehcile1.Name = "cboDataVehcile1"
        Me.cboDataVehcile1.Size = New System.Drawing.Size(90, 21)
        Me.cboDataVehcile1.TabIndex = 0
        '
        'lblDataVehcile
        '
        Me.lblDataVehcile.AutoSize = True
        Me.lblDataVehcile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataVehcile.Location = New System.Drawing.Point(43, 340)
        Me.lblDataVehcile.Name = "lblDataVehcile"
        Me.lblDataVehcile.Size = New System.Drawing.Size(42, 13)
        Me.lblDataVehcile.TabIndex = 10
        Me.lblDataVehcile.Text = "Vehicle"
        '
        'lblStartMileage
        '
        Me.lblStartMileage.AutoSize = True
        Me.lblStartMileage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartMileage.Location = New System.Drawing.Point(151, 339)
        Me.lblStartMileage.Name = "lblStartMileage"
        Me.lblStartMileage.Size = New System.Drawing.Size(72, 13)
        Me.lblStartMileage.TabIndex = 11
        Me.lblStartMileage.Text = "Start Mileage:"
        '
        'lblEndMileage
        '
        Me.lblEndMileage.AutoSize = True
        Me.lblEndMileage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndMileage.Location = New System.Drawing.Point(245, 339)
        Me.lblEndMileage.Name = "lblEndMileage"
        Me.lblEndMileage.Size = New System.Drawing.Size(69, 13)
        Me.lblEndMileage.TabIndex = 12
        Me.lblEndMileage.Text = "End Mileage:"
        '
        'lblStartFuel
        '
        Me.lblStartFuel.AutoSize = True
        Me.lblStartFuel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartFuel.Location = New System.Drawing.Point(348, 340)
        Me.lblStartFuel.Name = "lblStartFuel"
        Me.lblStartFuel.Size = New System.Drawing.Size(55, 13)
        Me.lblStartFuel.TabIndex = 13
        Me.lblStartFuel.Text = "Start Fuel:"
        '
        'lblEndFuel
        '
        Me.lblEndFuel.AutoSize = True
        Me.lblEndFuel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndFuel.Location = New System.Drawing.Point(456, 339)
        Me.lblEndFuel.Name = "lblEndFuel"
        Me.lblEndFuel.Size = New System.Drawing.Size(52, 13)
        Me.lblEndFuel.TabIndex = 14
        Me.lblEndFuel.Text = "End Fuel:"
        '
        'pnlResults
        '
        Me.pnlResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlResults.Controls.Add(Me.txtMpfcRating4)
        Me.pnlResults.Controls.Add(Me.txtMpfcRating3)
        Me.pnlResults.Controls.Add(Me.txtMpfcRating2)
        Me.pnlResults.Controls.Add(Me.txtMpfcRating1)
        Me.pnlResults.Controls.Add(Me.txtFuelCost4)
        Me.pnlResults.Controls.Add(Me.txtFuelCost3)
        Me.pnlResults.Controls.Add(Me.txtFuelCost2)
        Me.pnlResults.Controls.Add(Me.txtFuelCost1)
        Me.pnlResults.Controls.Add(Me.txtFuelUsed4)
        Me.pnlResults.Controls.Add(Me.txtFuelUsed3)
        Me.pnlResults.Controls.Add(Me.txtFuelUsed2)
        Me.pnlResults.Controls.Add(Me.txtFuelUsed1)
        Me.pnlResults.Controls.Add(Me.txtMileage4)
        Me.pnlResults.Controls.Add(Me.txtMileage3)
        Me.pnlResults.Controls.Add(Me.txtMileage2)
        Me.pnlResults.Controls.Add(Me.txtMileage1)
        Me.pnlResults.Controls.Add(Me.txtFamily4)
        Me.pnlResults.Controls.Add(Me.txtFamily3)
        Me.pnlResults.Controls.Add(Me.txtFamily2)
        Me.pnlResults.Controls.Add(Me.txtFamily1)
        Me.pnlResults.Controls.Add(Me.txtVehicle4)
        Me.pnlResults.Controls.Add(Me.txtVehicle3)
        Me.pnlResults.Controls.Add(Me.txtVehicle2)
        Me.pnlResults.Controls.Add(Me.txtVehicle1)
        Me.pnlResults.Location = New System.Drawing.Point(36, 508)
        Me.pnlResults.Name = "pnlResults"
        Me.pnlResults.Size = New System.Drawing.Size(580, 116)
        Me.pnlResults.TabIndex = 17
        '
        'txtMpfcRating4
        '
        Me.txtMpfcRating4.Enabled = False
        Me.txtMpfcRating4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMpfcRating4.Location = New System.Drawing.Point(459, 86)
        Me.txtMpfcRating4.Name = "txtMpfcRating4"
        Me.txtMpfcRating4.Size = New System.Drawing.Size(83, 20)
        Me.txtMpfcRating4.TabIndex = 43
        '
        'txtMpfcRating3
        '
        Me.txtMpfcRating3.Enabled = False
        Me.txtMpfcRating3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMpfcRating3.Location = New System.Drawing.Point(459, 59)
        Me.txtMpfcRating3.Name = "txtMpfcRating3"
        Me.txtMpfcRating3.Size = New System.Drawing.Size(83, 20)
        Me.txtMpfcRating3.TabIndex = 42
        '
        'txtMpfcRating2
        '
        Me.txtMpfcRating2.Enabled = False
        Me.txtMpfcRating2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMpfcRating2.Location = New System.Drawing.Point(459, 28)
        Me.txtMpfcRating2.Name = "txtMpfcRating2"
        Me.txtMpfcRating2.Size = New System.Drawing.Size(83, 20)
        Me.txtMpfcRating2.TabIndex = 41
        '
        'txtMpfcRating1
        '
        Me.txtMpfcRating1.Enabled = False
        Me.txtMpfcRating1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMpfcRating1.Location = New System.Drawing.Point(459, 3)
        Me.txtMpfcRating1.Name = "txtMpfcRating1"
        Me.txtMpfcRating1.Size = New System.Drawing.Size(83, 20)
        Me.txtMpfcRating1.TabIndex = 40
        '
        'txtFuelCost4
        '
        Me.txtFuelCost4.Enabled = False
        Me.txtFuelCost4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFuelCost4.Location = New System.Drawing.Point(370, 85)
        Me.txtFuelCost4.Name = "txtFuelCost4"
        Me.txtFuelCost4.Size = New System.Drawing.Size(83, 20)
        Me.txtFuelCost4.TabIndex = 39
        '
        'txtFuelCost3
        '
        Me.txtFuelCost3.Enabled = False
        Me.txtFuelCost3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFuelCost3.Location = New System.Drawing.Point(370, 59)
        Me.txtFuelCost3.Name = "txtFuelCost3"
        Me.txtFuelCost3.Size = New System.Drawing.Size(83, 20)
        Me.txtFuelCost3.TabIndex = 38
        '
        'txtFuelCost2
        '
        Me.txtFuelCost2.Enabled = False
        Me.txtFuelCost2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFuelCost2.Location = New System.Drawing.Point(370, 29)
        Me.txtFuelCost2.Name = "txtFuelCost2"
        Me.txtFuelCost2.Size = New System.Drawing.Size(83, 20)
        Me.txtFuelCost2.TabIndex = 37
        '
        'txtFuelCost1
        '
        Me.txtFuelCost1.Enabled = False
        Me.txtFuelCost1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFuelCost1.Location = New System.Drawing.Point(370, 2)
        Me.txtFuelCost1.Name = "txtFuelCost1"
        Me.txtFuelCost1.Size = New System.Drawing.Size(83, 20)
        Me.txtFuelCost1.TabIndex = 36
        '
        'txtFuelUsed4
        '
        Me.txtFuelUsed4.Enabled = False
        Me.txtFuelUsed4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFuelUsed4.Location = New System.Drawing.Point(276, 85)
        Me.txtFuelUsed4.Name = "txtFuelUsed4"
        Me.txtFuelUsed4.Size = New System.Drawing.Size(83, 20)
        Me.txtFuelUsed4.TabIndex = 35
        '
        'txtFuelUsed3
        '
        Me.txtFuelUsed3.Enabled = False
        Me.txtFuelUsed3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFuelUsed3.Location = New System.Drawing.Point(276, 60)
        Me.txtFuelUsed3.Name = "txtFuelUsed3"
        Me.txtFuelUsed3.Size = New System.Drawing.Size(83, 20)
        Me.txtFuelUsed3.TabIndex = 34
        '
        'txtFuelUsed2
        '
        Me.txtFuelUsed2.Enabled = False
        Me.txtFuelUsed2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFuelUsed2.Location = New System.Drawing.Point(276, 28)
        Me.txtFuelUsed2.Name = "txtFuelUsed2"
        Me.txtFuelUsed2.Size = New System.Drawing.Size(83, 20)
        Me.txtFuelUsed2.TabIndex = 33
        '
        'txtFuelUsed1
        '
        Me.txtFuelUsed1.Enabled = False
        Me.txtFuelUsed1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFuelUsed1.Location = New System.Drawing.Point(276, 2)
        Me.txtFuelUsed1.Name = "txtFuelUsed1"
        Me.txtFuelUsed1.Size = New System.Drawing.Size(83, 20)
        Me.txtFuelUsed1.TabIndex = 32
        '
        'txtMileage4
        '
        Me.txtMileage4.Enabled = False
        Me.txtMileage4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMileage4.Location = New System.Drawing.Point(183, 86)
        Me.txtMileage4.Name = "txtMileage4"
        Me.txtMileage4.Size = New System.Drawing.Size(83, 20)
        Me.txtMileage4.TabIndex = 31
        '
        'txtMileage3
        '
        Me.txtMileage3.Enabled = False
        Me.txtMileage3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMileage3.Location = New System.Drawing.Point(183, 59)
        Me.txtMileage3.Name = "txtMileage3"
        Me.txtMileage3.Size = New System.Drawing.Size(83, 20)
        Me.txtMileage3.TabIndex = 30
        '
        'txtMileage2
        '
        Me.txtMileage2.Enabled = False
        Me.txtMileage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMileage2.Location = New System.Drawing.Point(183, 29)
        Me.txtMileage2.Name = "txtMileage2"
        Me.txtMileage2.Size = New System.Drawing.Size(83, 20)
        Me.txtMileage2.TabIndex = 29
        '
        'txtMileage1
        '
        Me.txtMileage1.Enabled = False
        Me.txtMileage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMileage1.Location = New System.Drawing.Point(183, 3)
        Me.txtMileage1.Name = "txtMileage1"
        Me.txtMileage1.Size = New System.Drawing.Size(83, 20)
        Me.txtMileage1.TabIndex = 28
        '
        'txtFamily4
        '
        Me.txtFamily4.Enabled = False
        Me.txtFamily4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFamily4.Location = New System.Drawing.Point(94, 85)
        Me.txtFamily4.Name = "txtFamily4"
        Me.txtFamily4.Size = New System.Drawing.Size(83, 20)
        Me.txtFamily4.TabIndex = 27
        '
        'txtFamily3
        '
        Me.txtFamily3.Enabled = False
        Me.txtFamily3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFamily3.Location = New System.Drawing.Point(94, 59)
        Me.txtFamily3.Name = "txtFamily3"
        Me.txtFamily3.Size = New System.Drawing.Size(83, 20)
        Me.txtFamily3.TabIndex = 26
        '
        'txtFamily2
        '
        Me.txtFamily2.Enabled = False
        Me.txtFamily2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFamily2.Location = New System.Drawing.Point(94, 29)
        Me.txtFamily2.Name = "txtFamily2"
        Me.txtFamily2.Size = New System.Drawing.Size(83, 20)
        Me.txtFamily2.TabIndex = 25
        '
        'txtFamily1
        '
        Me.txtFamily1.Enabled = False
        Me.txtFamily1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFamily1.Location = New System.Drawing.Point(94, 3)
        Me.txtFamily1.Name = "txtFamily1"
        Me.txtFamily1.Size = New System.Drawing.Size(83, 20)
        Me.txtFamily1.TabIndex = 24
        '
        'txtVehicle4
        '
        Me.txtVehicle4.Enabled = False
        Me.txtVehicle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVehicle4.Location = New System.Drawing.Point(5, 85)
        Me.txtVehicle4.Name = "txtVehicle4"
        Me.txtVehicle4.Size = New System.Drawing.Size(83, 20)
        Me.txtVehicle4.TabIndex = 23
        '
        'txtVehicle3
        '
        Me.txtVehicle3.Enabled = False
        Me.txtVehicle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVehicle3.Location = New System.Drawing.Point(5, 59)
        Me.txtVehicle3.Name = "txtVehicle3"
        Me.txtVehicle3.Size = New System.Drawing.Size(83, 20)
        Me.txtVehicle3.TabIndex = 22
        '
        'txtVehicle2
        '
        Me.txtVehicle2.Enabled = False
        Me.txtVehicle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVehicle2.Location = New System.Drawing.Point(5, 29)
        Me.txtVehicle2.Name = "txtVehicle2"
        Me.txtVehicle2.Size = New System.Drawing.Size(83, 20)
        Me.txtVehicle2.TabIndex = 21
        '
        'txtVehicle1
        '
        Me.txtVehicle1.Enabled = False
        Me.txtVehicle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVehicle1.Location = New System.Drawing.Point(5, 3)
        Me.txtVehicle1.Name = "txtVehicle1"
        Me.txtVehicle1.Size = New System.Drawing.Size(83, 20)
        Me.txtVehicle1.TabIndex = 20
        '
        'lblResultsVehicle
        '
        Me.lblResultsVehicle.AutoSize = True
        Me.lblResultsVehicle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultsVehicle.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblResultsVehicle.Location = New System.Drawing.Point(48, 492)
        Me.lblResultsVehicle.Name = "lblResultsVehicle"
        Me.lblResultsVehicle.Size = New System.Drawing.Size(45, 13)
        Me.lblResultsVehicle.TabIndex = 18
        Me.lblResultsVehicle.Text = "Vehcile:"
        '
        'lblMileage
        '
        Me.lblMileage.AutoSize = True
        Me.lblMileage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMileage.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblMileage.Location = New System.Drawing.Point(240, 492)
        Me.lblMileage.Name = "lblMileage"
        Me.lblMileage.Size = New System.Drawing.Size(47, 13)
        Me.lblMileage.TabIndex = 19
        Me.lblMileage.Text = "Mileage:"
        '
        'lblFamily
        '
        Me.lblFamily.AutoSize = True
        Me.lblFamily.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFamily.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblFamily.Location = New System.Drawing.Point(142, 492)
        Me.lblFamily.Name = "lblFamily"
        Me.lblFamily.Size = New System.Drawing.Size(39, 13)
        Me.lblFamily.TabIndex = 20
        Me.lblFamily.Text = "Family:"
        '
        'lblFuelUsed
        '
        Me.lblFuelUsed.AutoSize = True
        Me.lblFuelUsed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFuelUsed.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblFuelUsed.Location = New System.Drawing.Point(333, 492)
        Me.lblFuelUsed.Name = "lblFuelUsed"
        Me.lblFuelUsed.Size = New System.Drawing.Size(55, 13)
        Me.lblFuelUsed.TabIndex = 21
        Me.lblFuelUsed.Text = "Fuel Used"
        '
        'lblFuelCost
        '
        Me.lblFuelCost.AutoSize = True
        Me.lblFuelCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFuelCost.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblFuelCost.Location = New System.Drawing.Point(419, 492)
        Me.lblFuelCost.Name = "lblFuelCost"
        Me.lblFuelCost.Size = New System.Drawing.Size(51, 13)
        Me.lblFuelCost.TabIndex = 22
        Me.lblFuelCost.Text = "Fuel Cost"
        '
        'lblMpfcRating
        '
        Me.lblMpfcRating.AutoSize = True
        Me.lblMpfcRating.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMpfcRating.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblMpfcRating.Location = New System.Drawing.Point(492, 492)
        Me.lblMpfcRating.Name = "lblMpfcRating"
        Me.lblMpfcRating.Size = New System.Drawing.Size(70, 13)
        Me.lblMpfcRating.TabIndex = 23
        Me.lblMpfcRating.Text = "MPFC Rating"
        '
        'btnProcess
        '
        Me.btnProcess.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcess.Location = New System.Drawing.Point(4, 639)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(132, 23)
        Me.btnProcess.TabIndex = 24
        Me.btnProcess.Text = "&Process"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(150, 639)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(137, 23)
        Me.btnClear.TabIndex = 25
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnAllTests
        '
        Me.btnAllTests.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAllTests.Location = New System.Drawing.Point(469, 639)
        Me.btnAllTests.Name = "btnAllTests"
        Me.btnAllTests.Size = New System.Drawing.Size(147, 23)
        Me.btnAllTests.TabIndex = 26
        Me.btnAllTests.Text = "&All Tests"
        Me.btnAllTests.UseVisualStyleBackColor = True
        '
        'MpfcErros
        '
        Me.MpfcErros.ContainerControl = Me
        '
        'lblResults
        '
        Me.lblResults.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResults.Location = New System.Drawing.Point(1, 508)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(29, 119)
        Me.lblResults.TabIndex = 27
        Me.lblResults.Text = "R" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "E" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "S" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "U" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "L" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "T" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "S" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblData
        '
        Me.lblData.AccessibleName = ""
        Me.lblData.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblData.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData.Location = New System.Drawing.Point(1, 359)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(29, 121)
        Me.lblData.TabIndex = 28
        Me.lblData.Text = "D" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "T" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A"
        '
        'frmMain
        '
        Me.AccessibleDescription = ""
        Me.AccessibleName = ""
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 669)
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.btnAllTests)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.lblMpfcRating)
        Me.Controls.Add(Me.lblFuelCost)
        Me.Controls.Add(Me.lblFuelUsed)
        Me.Controls.Add(Me.lblFamily)
        Me.Controls.Add(Me.lblMileage)
        Me.Controls.Add(Me.lblResultsVehicle)
        Me.Controls.Add(Me.pnlResults)
        Me.Controls.Add(Me.lblEndFuel)
        Me.Controls.Add(Me.lblStartFuel)
        Me.Controls.Add(Me.lblEndMileage)
        Me.Controls.Add(Me.lblStartMileage)
        Me.Controls.Add(Me.lblDataVehcile)
        Me.Controls.Add(Me.pnlData)
        Me.Controls.Add(Me.grpDriverInfo)
        Me.Controls.Add(Me.grpInventorInfo)
        Me.Controls.Add(Me.grpTestInfo)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMain"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "MPFC Calculator"
        Me.grpTestInfo.ResumeLayout(False)
        Me.grpTestInfo.PerformLayout()
        Me.grpInventorInfo.ResumeLayout(False)
        Me.grpInventorInfo.PerformLayout()
        Me.grpDriverInfo.ResumeLayout(False)
        Me.grpDriverInfo.PerformLayout()
        CType(Me.picSimpson, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlData.ResumeLayout(False)
        Me.pnlData.PerformLayout()
        Me.pnlResults.ResumeLayout(False)
        Me.pnlResults.PerformLayout()
        CType(Me.MpfcErros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents txtDate As TextBox
    Friend WithEvents txtTestNum As TextBox
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTestNum As Label
    Friend WithEvents lblInventorLastName As Label
    Friend WithEvents lblInventorFirstName As Label
    Friend WithEvents txtInventorFirstName As TextBox
    Friend WithEvents txtInventorLastName As TextBox
    Friend WithEvents grpTestInfo As GroupBox
    Friend WithEvents grpInventorInfo As GroupBox
    Friend WithEvents grpDriverInfo As GroupBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblDriverInfoLastName As Label
    Friend WithEvents lblDriverInfoFirstName As Label
    Friend WithEvents lblId As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtDriverInfoLastName As TextBox
    Friend WithEvents txtDriverInfoFirstName As TextBox
    Friend WithEvents cboId As ComboBox
    Friend WithEvents picSimpson As PictureBox
    Friend WithEvents pnlData As Panel
    Friend WithEvents lblDataVehcile As Label
    Friend WithEvents lblStartMileage As Label
    Friend WithEvents lblEndMileage As Label
    Friend WithEvents lblStartFuel As Label
    Friend WithEvents lblEndFuel As Label
    Friend WithEvents cboDataVehcile3 As ComboBox
    Friend WithEvents cboDataVehcile2 As ComboBox
    Friend WithEvents cboDataVehcile1 As ComboBox
    Friend WithEvents txtEndFuel4 As TextBox
    Friend WithEvents txtEndFuel3 As TextBox
    Friend WithEvents txtEndFuel2 As TextBox
    Friend WithEvents txtEndFuel1 As TextBox
    Friend WithEvents txtStartFuel4 As TextBox
    Friend WithEvents txtStartFuel3 As TextBox
    Friend WithEvents txtStartFuel2 As TextBox
    Friend WithEvents txtStartFuel1 As TextBox
    Friend WithEvents txtEndMileage4 As TextBox
    Friend WithEvents txtEndMileage3 As TextBox
    Friend WithEvents txtEndMileage2 As TextBox
    Friend WithEvents txtEndMileage1 As TextBox
    Friend WithEvents txtStartMileage4 As TextBox
    Friend WithEvents txtStartMileage3 As TextBox
    Friend WithEvents txtStartMileage2 As TextBox
    Friend WithEvents txtStartMileage1 As TextBox
    Friend WithEvents pnlResults As Panel
    Friend WithEvents cboDataVehcile4 As ComboBox
    Friend WithEvents lblResultsVehicle As Label
    Friend WithEvents lblMileage As Label
    Friend WithEvents lblFamily As Label
    Friend WithEvents lblFuelUsed As Label
    Friend WithEvents lblFuelCost As Label
    Friend WithEvents lblMpfcRating As Label
    Friend WithEvents txtFuelCost4 As TextBox
    Friend WithEvents txtFuelCost3 As TextBox
    Friend WithEvents txtFuelCost2 As TextBox
    Friend WithEvents txtFuelCost1 As TextBox
    Friend WithEvents txtFuelUsed4 As TextBox
    Friend WithEvents txtFuelUsed3 As TextBox
    Friend WithEvents txtFuelUsed2 As TextBox
    Friend WithEvents txtFuelUsed1 As TextBox
    Friend WithEvents txtMileage4 As TextBox
    Friend WithEvents txtMileage3 As TextBox
    Friend WithEvents txtMileage2 As TextBox
    Friend WithEvents txtMileage1 As TextBox
    Friend WithEvents txtFamily4 As TextBox
    Friend WithEvents txtFamily3 As TextBox
    Friend WithEvents txtFamily2 As TextBox
    Friend WithEvents txtFamily1 As TextBox
    Friend WithEvents txtVehicle4 As TextBox
    Friend WithEvents txtVehicle3 As TextBox
    Friend WithEvents txtVehicle2 As TextBox
    Friend WithEvents txtVehicle1 As TextBox
    Friend WithEvents txtMpfcRating4 As TextBox
    Friend WithEvents txtMpfcRating3 As TextBox
    Friend WithEvents txtMpfcRating2 As TextBox
    Friend WithEvents txtMpfcRating1 As TextBox
    Friend WithEvents btnProcess As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnAllTests As Button
    Friend WithEvents MpfcErros As ErrorProvider
    Friend WithEvents lblData As Label
    Friend WithEvents lblResults As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChild
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
        Me.components = New System.ComponentModel.Container()
        Me.lblLines = New System.Windows.Forms.Label()
        Me.lblTotals = New System.Windows.Forms.Label()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.lblPrices = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.grpFindBox = New System.Windows.Forms.GroupBox()
        Me.pnlBillandShipScroll = New System.Windows.Forms.Panel()
        Me.grpBillInfo = New System.Windows.Forms.GroupBox()
        Me.txtBillStreet = New System.Windows.Forms.TextBox()
        Me.txtBillZip = New System.Windows.Forms.TextBox()
        Me.txtBillState = New System.Windows.Forms.TextBox()
        Me.txtBillCity = New System.Windows.Forms.TextBox()
        Me.lblBillZip = New System.Windows.Forms.Label()
        Me.lblBillState = New System.Windows.Forms.Label()
        Me.lblBillCity = New System.Windows.Forms.Label()
        Me.lblBillStreet = New System.Windows.Forms.Label()
        Me.grpShipInfo = New System.Windows.Forms.GroupBox()
        Me.txtShipStreet = New System.Windows.Forms.TextBox()
        Me.txtShipZip = New System.Windows.Forms.TextBox()
        Me.txtShipState = New System.Windows.Forms.TextBox()
        Me.txtShipCity = New System.Windows.Forms.TextBox()
        Me.lblShipZip = New System.Windows.Forms.Label()
        Me.lblShipState = New System.Windows.Forms.Label()
        Me.lblShipCity = New System.Windows.Forms.Label()
        Me.lblShipStreet = New System.Windows.Forms.Label()
        Me.chkSameAsBilling = New System.Windows.Forms.CheckBox()
        Me.grpDelivery = New System.Windows.Forms.GroupBox()
        Me.btnRdoDelivery = New System.Windows.Forms.RadioButton()
        Me.btnRdoPickup = New System.Windows.Forms.RadioButton()
        Me.grpOdrTotal = New System.Windows.Forms.GroupBox()
        Me.txtOrderTotal = New System.Windows.Forms.TextBox()
        Me.txtdeliveryCharge = New System.Windows.Forms.TextBox()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.lblOrderTotal = New System.Windows.Forms.Label()
        Me.lblDeliveryCharge = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.pnlOrderDetails = New System.Windows.Forms.Panel()
        Me.cboItem1 = New System.Windows.Forms.ComboBox()
        Me.txtPrice1 = New System.Windows.Forms.TextBox()
        Me.txtQty1 = New System.Windows.Forms.TextBox()
        Me.lblTotal1 = New System.Windows.Forms.Label()
        Me.lblLine1 = New System.Windows.Forms.Label()
        Me.pnlScroll = New System.Windows.Forms.Panel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFindBox.SuspendLayout()
        Me.pnlBillandShipScroll.SuspendLayout()
        Me.grpBillInfo.SuspendLayout()
        Me.grpShipInfo.SuspendLayout()
        Me.grpDelivery.SuspendLayout()
        Me.grpOdrTotal.SuspendLayout()
        Me.pnlOrderDetails.SuspendLayout()
        Me.pnlScroll.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLines
        '
        Me.lblLines.AutoSize = True
        Me.lblLines.Location = New System.Drawing.Point(8, 11)
        Me.lblLines.Name = "lblLines"
        Me.lblLines.Size = New System.Drawing.Size(27, 13)
        Me.lblLines.TabIndex = 36
        Me.lblLines.Text = "Line"
        '
        'lblTotals
        '
        Me.lblTotals.AutoSize = True
        Me.lblTotals.Location = New System.Drawing.Point(393, 11)
        Me.lblTotals.Name = "lblTotals"
        Me.lblTotals.Size = New System.Drawing.Size(31, 13)
        Me.lblTotals.TabIndex = 35
        Me.lblTotals.Text = "Total"
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Location = New System.Drawing.Point(47, 11)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(27, 13)
        Me.lblItem.TabIndex = 32
        Me.lblItem.Text = "Item"
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.Location = New System.Drawing.Point(289, 11)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(23, 13)
        Me.lblQty.TabIndex = 34
        Me.lblQty.Text = "Qty"
        '
        'lblPrices
        '
        Me.lblPrices.AutoSize = True
        Me.lblPrices.Location = New System.Drawing.Point(329, 11)
        Me.lblPrices.Name = "lblPrices"
        Me.lblPrices.Size = New System.Drawing.Size(31, 13)
        Me.lblPrices.TabIndex = 33
        Me.lblPrices.Text = "Price"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(446, 416)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 27
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(203, 416)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnOpen.TabIndex = 24
        Me.btnOpen.Text = "&Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(28, 19)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(73, 20)
        Me.txtID.TabIndex = 1
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(144, 19)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(117, 20)
        Me.txtName.TabIndex = 2
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(6, 23)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(18, 13)
        Me.lblID.TabIndex = 41
        Me.lblID.Text = "ID"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(105, 23)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 42
        Me.lblName.Text = "Name"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(284, 416)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 25
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(261, 20)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(38, 13)
        Me.lblPhone.TabIndex = 46
        Me.lblPhone.Text = "Phone"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(379, 19)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(30, 13)
        Me.lblDate.TabIndex = 47
        Me.lblDate.Text = "Date"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(303, 16)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(72, 20)
        Me.txtPhone.TabIndex = 3
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(413, 15)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(63, 20)
        Me.txtDate.TabIndex = 4
        '
        'grpFindBox
        '
        Me.grpFindBox.Controls.Add(Me.txtID)
        Me.grpFindBox.Controls.Add(Me.txtDate)
        Me.grpFindBox.Controls.Add(Me.txtName)
        Me.grpFindBox.Controls.Add(Me.txtPhone)
        Me.grpFindBox.Controls.Add(Me.lblID)
        Me.grpFindBox.Controls.Add(Me.lblDate)
        Me.grpFindBox.Controls.Add(Me.lblName)
        Me.grpFindBox.Controls.Add(Me.lblPhone)
        Me.grpFindBox.Location = New System.Drawing.Point(12, 11)
        Me.grpFindBox.Name = "grpFindBox"
        Me.grpFindBox.Size = New System.Drawing.Size(499, 50)
        Me.grpFindBox.TabIndex = 50
        Me.grpFindBox.TabStop = False
        '
        'pnlBillandShipScroll
        '
        Me.pnlBillandShipScroll.AutoScroll = True
        Me.pnlBillandShipScroll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBillandShipScroll.Controls.Add(Me.grpBillInfo)
        Me.pnlBillandShipScroll.Controls.Add(Me.grpShipInfo)
        Me.pnlBillandShipScroll.Location = New System.Drawing.Point(12, 261)
        Me.pnlBillandShipScroll.Name = "pnlBillandShipScroll"
        Me.pnlBillandShipScroll.Size = New System.Drawing.Size(276, 151)
        Me.pnlBillandShipScroll.TabIndex = 0
        '
        'grpBillInfo
        '
        Me.grpBillInfo.Controls.Add(Me.txtBillStreet)
        Me.grpBillInfo.Controls.Add(Me.txtBillZip)
        Me.grpBillInfo.Controls.Add(Me.txtBillState)
        Me.grpBillInfo.Controls.Add(Me.txtBillCity)
        Me.grpBillInfo.Controls.Add(Me.lblBillZip)
        Me.grpBillInfo.Controls.Add(Me.lblBillState)
        Me.grpBillInfo.Controls.Add(Me.lblBillCity)
        Me.grpBillInfo.Controls.Add(Me.lblBillStreet)
        Me.grpBillInfo.Location = New System.Drawing.Point(8, 8)
        Me.grpBillInfo.Name = "grpBillInfo"
        Me.grpBillInfo.Size = New System.Drawing.Size(231, 111)
        Me.grpBillInfo.TabIndex = 0
        Me.grpBillInfo.TabStop = False
        Me.grpBillInfo.Text = "Billing Info"
        '
        'txtBillStreet
        '
        Me.txtBillStreet.Location = New System.Drawing.Point(6, 32)
        Me.txtBillStreet.Name = "txtBillStreet"
        Me.txtBillStreet.Size = New System.Drawing.Size(206, 20)
        Me.txtBillStreet.TabIndex = 7
        '
        'txtBillZip
        '
        Me.txtBillZip.Location = New System.Drawing.Point(158, 85)
        Me.txtBillZip.Name = "txtBillZip"
        Me.txtBillZip.Size = New System.Drawing.Size(54, 20)
        Me.txtBillZip.TabIndex = 10
        '
        'txtBillState
        '
        Me.txtBillState.Location = New System.Drawing.Point(120, 85)
        Me.txtBillState.Name = "txtBillState"
        Me.txtBillState.Size = New System.Drawing.Size(32, 20)
        Me.txtBillState.TabIndex = 9
        '
        'txtBillCity
        '
        Me.txtBillCity.Location = New System.Drawing.Point(6, 85)
        Me.txtBillCity.Name = "txtBillCity"
        Me.txtBillCity.Size = New System.Drawing.Size(108, 20)
        Me.txtBillCity.TabIndex = 8
        '
        'lblBillZip
        '
        Me.lblBillZip.AutoSize = True
        Me.lblBillZip.Location = New System.Drawing.Point(158, 69)
        Me.lblBillZip.Name = "lblBillZip"
        Me.lblBillZip.Size = New System.Drawing.Size(25, 13)
        Me.lblBillZip.TabIndex = 3
        Me.lblBillZip.Text = "Zip:"
        '
        'lblBillState
        '
        Me.lblBillState.AutoSize = True
        Me.lblBillState.Location = New System.Drawing.Point(117, 69)
        Me.lblBillState.Name = "lblBillState"
        Me.lblBillState.Size = New System.Drawing.Size(35, 13)
        Me.lblBillState.TabIndex = 2
        Me.lblBillState.Text = "State:"
        '
        'lblBillCity
        '
        Me.lblBillCity.AutoSize = True
        Me.lblBillCity.Location = New System.Drawing.Point(3, 69)
        Me.lblBillCity.Name = "lblBillCity"
        Me.lblBillCity.Size = New System.Drawing.Size(27, 13)
        Me.lblBillCity.TabIndex = 1
        Me.lblBillCity.Text = "City:"
        '
        'lblBillStreet
        '
        Me.lblBillStreet.AutoSize = True
        Me.lblBillStreet.Location = New System.Drawing.Point(6, 16)
        Me.lblBillStreet.Name = "lblBillStreet"
        Me.lblBillStreet.Size = New System.Drawing.Size(38, 13)
        Me.lblBillStreet.TabIndex = 0
        Me.lblBillStreet.Text = "Street:"
        '
        'grpShipInfo
        '
        Me.grpShipInfo.Controls.Add(Me.txtShipStreet)
        Me.grpShipInfo.Controls.Add(Me.txtShipZip)
        Me.grpShipInfo.Controls.Add(Me.txtShipState)
        Me.grpShipInfo.Controls.Add(Me.txtShipCity)
        Me.grpShipInfo.Controls.Add(Me.lblShipZip)
        Me.grpShipInfo.Controls.Add(Me.lblShipState)
        Me.grpShipInfo.Controls.Add(Me.lblShipCity)
        Me.grpShipInfo.Controls.Add(Me.lblShipStreet)
        Me.grpShipInfo.Controls.Add(Me.chkSameAsBilling)
        Me.grpShipInfo.Location = New System.Drawing.Point(8, 135)
        Me.grpShipInfo.Name = "grpShipInfo"
        Me.grpShipInfo.Size = New System.Drawing.Size(231, 138)
        Me.grpShipInfo.TabIndex = 0
        Me.grpShipInfo.TabStop = False
        Me.grpShipInfo.Text = "Shipping Info"
        '
        'txtShipStreet
        '
        Me.txtShipStreet.Location = New System.Drawing.Point(6, 53)
        Me.txtShipStreet.Name = "txtShipStreet"
        Me.txtShipStreet.Size = New System.Drawing.Size(206, 20)
        Me.txtShipStreet.TabIndex = 12
        '
        'txtShipZip
        '
        Me.txtShipZip.Location = New System.Drawing.Point(158, 104)
        Me.txtShipZip.Name = "txtShipZip"
        Me.txtShipZip.Size = New System.Drawing.Size(54, 20)
        Me.txtShipZip.TabIndex = 15
        '
        'txtShipState
        '
        Me.txtShipState.Location = New System.Drawing.Point(120, 104)
        Me.txtShipState.Name = "txtShipState"
        Me.txtShipState.Size = New System.Drawing.Size(32, 20)
        Me.txtShipState.TabIndex = 14
        Me.txtShipState.Text = " "
        '
        'txtShipCity
        '
        Me.txtShipCity.Location = New System.Drawing.Point(6, 104)
        Me.txtShipCity.Name = "txtShipCity"
        Me.txtShipCity.Size = New System.Drawing.Size(108, 20)
        Me.txtShipCity.TabIndex = 13
        '
        'lblShipZip
        '
        Me.lblShipZip.AutoSize = True
        Me.lblShipZip.Location = New System.Drawing.Point(160, 88)
        Me.lblShipZip.Name = "lblShipZip"
        Me.lblShipZip.Size = New System.Drawing.Size(25, 13)
        Me.lblShipZip.TabIndex = 11
        Me.lblShipZip.Text = "Zip:"
        '
        'lblShipState
        '
        Me.lblShipState.AutoSize = True
        Me.lblShipState.Location = New System.Drawing.Point(117, 88)
        Me.lblShipState.Name = "lblShipState"
        Me.lblShipState.Size = New System.Drawing.Size(35, 13)
        Me.lblShipState.TabIndex = 10
        Me.lblShipState.Text = "State:"
        '
        'lblShipCity
        '
        Me.lblShipCity.AutoSize = True
        Me.lblShipCity.Location = New System.Drawing.Point(6, 88)
        Me.lblShipCity.Name = "lblShipCity"
        Me.lblShipCity.Size = New System.Drawing.Size(27, 13)
        Me.lblShipCity.TabIndex = 9
        Me.lblShipCity.Text = "City:"
        '
        'lblShipStreet
        '
        Me.lblShipStreet.AutoSize = True
        Me.lblShipStreet.Location = New System.Drawing.Point(6, 37)
        Me.lblShipStreet.Name = "lblShipStreet"
        Me.lblShipStreet.Size = New System.Drawing.Size(38, 13)
        Me.lblShipStreet.TabIndex = 8
        Me.lblShipStreet.Text = "Street:"
        '
        'chkSameAsBilling
        '
        Me.chkSameAsBilling.AutoSize = True
        Me.chkSameAsBilling.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSameAsBilling.Checked = True
        Me.chkSameAsBilling.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSameAsBilling.Location = New System.Drawing.Point(115, 19)
        Me.chkSameAsBilling.Name = "chkSameAsBilling"
        Me.chkSameAsBilling.Size = New System.Drawing.Size(97, 17)
        Me.chkSameAsBilling.TabIndex = 11
        Me.chkSameAsBilling.Text = "Same as Billing"
        Me.chkSameAsBilling.UseVisualStyleBackColor = True
        '
        'grpDelivery
        '
        Me.grpDelivery.Controls.Add(Me.btnRdoDelivery)
        Me.grpDelivery.Controls.Add(Me.btnRdoPickup)
        Me.grpDelivery.Location = New System.Drawing.Point(300, 260)
        Me.grpDelivery.Name = "grpDelivery"
        Me.grpDelivery.Size = New System.Drawing.Size(214, 39)
        Me.grpDelivery.TabIndex = 0
        Me.grpDelivery.TabStop = False
        Me.grpDelivery.Text = "Delivery Option"
        '
        'btnRdoDelivery
        '
        Me.btnRdoDelivery.AutoSize = True
        Me.btnRdoDelivery.Location = New System.Drawing.Point(102, 19)
        Me.btnRdoDelivery.Name = "btnRdoDelivery"
        Me.btnRdoDelivery.Size = New System.Drawing.Size(93, 17)
        Me.btnRdoDelivery.TabIndex = 17
        Me.btnRdoDelivery.TabStop = True
        Me.btnRdoDelivery.Text = "Delivery + $10"
        Me.btnRdoDelivery.UseVisualStyleBackColor = True
        '
        'btnRdoPickup
        '
        Me.btnRdoPickup.AutoSize = True
        Me.btnRdoPickup.Checked = True
        Me.btnRdoPickup.Location = New System.Drawing.Point(6, 19)
        Me.btnRdoPickup.Name = "btnRdoPickup"
        Me.btnRdoPickup.Size = New System.Drawing.Size(58, 17)
        Me.btnRdoPickup.TabIndex = 16
        Me.btnRdoPickup.TabStop = True
        Me.btnRdoPickup.Text = "Pickup"
        Me.btnRdoPickup.UseVisualStyleBackColor = True
        '
        'grpOdrTotal
        '
        Me.grpOdrTotal.Controls.Add(Me.txtOrderTotal)
        Me.grpOdrTotal.Controls.Add(Me.txtdeliveryCharge)
        Me.grpOdrTotal.Controls.Add(Me.txtTax)
        Me.grpOdrTotal.Controls.Add(Me.txtSubTotal)
        Me.grpOdrTotal.Controls.Add(Me.lblOrderTotal)
        Me.grpOdrTotal.Controls.Add(Me.lblDeliveryCharge)
        Me.grpOdrTotal.Controls.Add(Me.lblTax)
        Me.grpOdrTotal.Controls.Add(Me.lblSubTotal)
        Me.grpOdrTotal.Location = New System.Drawing.Point(300, 302)
        Me.grpOdrTotal.Name = "grpOdrTotal"
        Me.grpOdrTotal.Size = New System.Drawing.Size(212, 109)
        Me.grpOdrTotal.TabIndex = 0
        Me.grpOdrTotal.TabStop = False
        Me.grpOdrTotal.Text = "Order Total"
        '
        'txtOrderTotal
        '
        Me.txtOrderTotal.Location = New System.Drawing.Point(97, 79)
        Me.txtOrderTotal.Name = "txtOrderTotal"
        Me.txtOrderTotal.ReadOnly = True
        Me.txtOrderTotal.Size = New System.Drawing.Size(109, 20)
        Me.txtOrderTotal.TabIndex = 21
        Me.txtOrderTotal.TabStop = False
        Me.txtOrderTotal.Text = "0"
        Me.txtOrderTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtdeliveryCharge
        '
        Me.txtdeliveryCharge.Location = New System.Drawing.Point(97, 57)
        Me.txtdeliveryCharge.Name = "txtdeliveryCharge"
        Me.txtdeliveryCharge.ReadOnly = True
        Me.txtdeliveryCharge.Size = New System.Drawing.Size(109, 20)
        Me.txtdeliveryCharge.TabIndex = 20
        Me.txtdeliveryCharge.TabStop = False
        Me.txtdeliveryCharge.Text = "0"
        Me.txtdeliveryCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTax
        '
        Me.txtTax.Location = New System.Drawing.Point(97, 35)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.ReadOnly = True
        Me.txtTax.Size = New System.Drawing.Size(109, 20)
        Me.txtTax.TabIndex = 19
        Me.txtTax.TabStop = False
        Me.txtTax.Text = "0"
        Me.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Location = New System.Drawing.Point(97, 13)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(109, 20)
        Me.txtSubTotal.TabIndex = 0
        Me.txtSubTotal.TabStop = False
        Me.txtSubTotal.Text = "0"
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblOrderTotal
        '
        Me.lblOrderTotal.AutoSize = True
        Me.lblOrderTotal.Location = New System.Drawing.Point(6, 83)
        Me.lblOrderTotal.Name = "lblOrderTotal"
        Me.lblOrderTotal.Size = New System.Drawing.Size(60, 13)
        Me.lblOrderTotal.TabIndex = 3
        Me.lblOrderTotal.Text = "Order Total"
        '
        'lblDeliveryCharge
        '
        Me.lblDeliveryCharge.AutoSize = True
        Me.lblDeliveryCharge.Location = New System.Drawing.Point(6, 61)
        Me.lblDeliveryCharge.Name = "lblDeliveryCharge"
        Me.lblDeliveryCharge.Size = New System.Drawing.Size(82, 13)
        Me.lblDeliveryCharge.TabIndex = 2
        Me.lblDeliveryCharge.Text = "Delivery Charge"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(6, 39)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(80, 13)
        Me.lblTax.TabIndex = 1
        Me.lblTax.Text = "Tax: @ 7.825%"
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.Location = New System.Drawing.Point(6, 17)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(56, 13)
        Me.lblSubTotal.TabIndex = 0
        Me.lblSubTotal.Text = "Sub Total:"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(365, 416)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 26
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'pnlOrderDetails
        '
        Me.pnlOrderDetails.Controls.Add(Me.cboItem1)
        Me.pnlOrderDetails.Controls.Add(Me.txtPrice1)
        Me.pnlOrderDetails.Controls.Add(Me.txtQty1)
        Me.pnlOrderDetails.Controls.Add(Me.lblTotal1)
        Me.pnlOrderDetails.Controls.Add(Me.lblLine1)
        Me.pnlOrderDetails.Location = New System.Drawing.Point(5, 27)
        Me.pnlOrderDetails.Name = "pnlOrderDetails"
        Me.pnlOrderDetails.Size = New System.Drawing.Size(469, 219)
        Me.pnlOrderDetails.TabIndex = 0
        '
        'cboItem1
        '
        Me.cboItem1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboItem1.FormattingEnabled = True
        Me.cboItem1.Location = New System.Drawing.Point(30, 3)
        Me.cboItem1.Name = "cboItem1"
        Me.cboItem1.Size = New System.Drawing.Size(241, 21)
        Me.cboItem1.TabIndex = 5
        '
        'txtPrice1
        '
        Me.txtPrice1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPrice1.Enabled = False
        Me.txtPrice1.Location = New System.Drawing.Point(318, 4)
        Me.txtPrice1.Name = "txtPrice1"
        Me.txtPrice1.Size = New System.Drawing.Size(58, 20)
        Me.txtPrice1.TabIndex = 0
        Me.txtPrice1.Text = "0"
        Me.txtPrice1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtQty1
        '
        Me.txtQty1.Location = New System.Drawing.Point(277, 4)
        Me.txtQty1.Name = "txtQty1"
        Me.txtQty1.Size = New System.Drawing.Size(38, 20)
        Me.txtQty1.TabIndex = 6
        Me.txtQty1.Text = "0"
        '
        'lblTotal1
        '
        Me.lblTotal1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTotal1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal1.Enabled = False
        Me.lblTotal1.Location = New System.Drawing.Point(382, 4)
        Me.lblTotal1.Name = "lblTotal1"
        Me.lblTotal1.Size = New System.Drawing.Size(71, 20)
        Me.lblTotal1.TabIndex = 0
        Me.lblTotal1.Text = "0"
        Me.lblTotal1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLine1
        '
        Me.lblLine1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLine1.Location = New System.Drawing.Point(1, 4)
        Me.lblLine1.Name = "lblLine1"
        Me.lblLine1.Size = New System.Drawing.Size(26, 19)
        Me.lblLine1.TabIndex = 0
        Me.lblLine1.Text = "1"
        '
        'pnlScroll
        '
        Me.pnlScroll.AutoScroll = True
        Me.pnlScroll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlScroll.Controls.Add(Me.lblLines)
        Me.pnlScroll.Controls.Add(Me.pnlOrderDetails)
        Me.pnlScroll.Controls.Add(Me.lblItem)
        Me.pnlScroll.Controls.Add(Me.lblQty)
        Me.pnlScroll.Controls.Add(Me.lblPrices)
        Me.pnlScroll.Controls.Add(Me.lblTotals)
        Me.pnlScroll.Location = New System.Drawing.Point(14, 67)
        Me.pnlScroll.Name = "pnlScroll"
        Me.pnlScroll.Size = New System.Drawing.Size(497, 182)
        Me.pnlScroll.TabIndex = 56
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(21, 416)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 22
        Me.btnAdd.Text = "Add Line"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(102, 416)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(95, 23)
        Me.btnRemove.TabIndex = 23
        Me.btnRemove.Text = "Remove Line"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'frmChild
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 450)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.pnlScroll)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.grpOdrTotal)
        Me.Controls.Add(Me.grpDelivery)
        Me.Controls.Add(Me.pnlBillandShipScroll)
        Me.Controls.Add(Me.grpFindBox)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmChild"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFindBox.ResumeLayout(False)
        Me.grpFindBox.PerformLayout()
        Me.pnlBillandShipScroll.ResumeLayout(False)
        Me.grpBillInfo.ResumeLayout(False)
        Me.grpBillInfo.PerformLayout()
        Me.grpShipInfo.ResumeLayout(False)
        Me.grpShipInfo.PerformLayout()
        Me.grpDelivery.ResumeLayout(False)
        Me.grpDelivery.PerformLayout()
        Me.grpOdrTotal.ResumeLayout(False)
        Me.grpOdrTotal.PerformLayout()
        Me.pnlOrderDetails.ResumeLayout(False)
        Me.pnlOrderDetails.PerformLayout()
        Me.pnlScroll.ResumeLayout(False)
        Me.pnlScroll.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTotals As System.Windows.Forms.Label
    Friend WithEvents lblQty As System.Windows.Forms.Label
    Friend WithEvents lblPrices As System.Windows.Forms.Label
    Friend WithEvents lblItem As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtDate As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents lblDate As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblLines As Label
    Friend WithEvents grpFindBox As GroupBox
    Friend WithEvents pnlBillandShipScroll As Panel
    Friend WithEvents grpBillInfo As GroupBox
    Friend WithEvents txtBillStreet As TextBox
    Friend WithEvents txtBillZip As TextBox
    Friend WithEvents txtBillState As TextBox
    Friend WithEvents txtBillCity As TextBox
    Friend WithEvents lblBillZip As Label
    Friend WithEvents lblBillState As Label
    Friend WithEvents lblBillCity As Label
    Friend WithEvents lblBillStreet As Label
    Friend WithEvents grpShipInfo As GroupBox
    Friend WithEvents chkSameAsBilling As CheckBox
    Friend WithEvents grpDelivery As GroupBox
    Friend WithEvents btnRdoDelivery As RadioButton
    Friend WithEvents btnRdoPickup As RadioButton
    Friend WithEvents txtShipStreet As TextBox
    Friend WithEvents txtShipZip As TextBox
    Friend WithEvents txtShipState As TextBox
    Friend WithEvents txtShipCity As TextBox
    Friend WithEvents lblShipZip As Label
    Friend WithEvents lblShipState As Label
    Friend WithEvents lblShipCity As Label
    Friend WithEvents lblShipStreet As Label
    Friend WithEvents grpOdrTotal As GroupBox
    Friend WithEvents txtOrderTotal As TextBox
    Friend WithEvents txtTax As TextBox
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents lblOrderTotal As Label
    Friend WithEvents lblDeliveryCharge As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents pnlOrderDetails As Panel
    Friend WithEvents cboItem1 As ComboBox
    Friend WithEvents txtPrice1 As TextBox
    Friend WithEvents txtQty1 As TextBox
    Friend WithEvents lblTotal1 As Label
    Friend WithEvents lblLine1 As Label
    Friend WithEvents pnlScroll As Panel
    Friend WithEvents txtdeliveryCharge As TextBox
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnAdd As Button
End Class

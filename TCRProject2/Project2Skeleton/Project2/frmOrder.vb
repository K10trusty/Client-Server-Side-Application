Imports System.Globalization

Public Class frmChild

    'A comment for this class goes here.
    'The comment should describe the purpose of 
    'the class and anthing else that is relevant 
    'for future development.

    Private controller As clsController
    Private itemsMenu() As String
    Private itemsPrices() As String
    Private anIntegerForAddingClicks As Integer ' Integer to hold how many controls are on our form
    Private comboBoxCount As Integer = 0           'Integer to hold the combobox selected value
    Private holdOurSelectedIndex As String  'This hold our string from selected index into our txtPrice Boxes I am going to add a whole bunch of these to hold our values

    Private lstCboItem As New List(Of ComboBox) 'combo box
    Private lstLblItem As New List(Of Label)    'line item #
    Private lstQtyItem As New List(Of TextBox)  'QTY text box
    Private lstPriceItem As New List(Of TextBox)    'Price Text box
    Private lstTotalItem As New List(Of Label)  'Total dispalys in label
    Private lineCounter As New Integer ' Class level so we can pass it to buton.add



    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'Save the order
        'We are going to use a combination of ArrayLists and Arrays to pass
        'All the order information to the business logic layer
        'By using this approach we use simple data structure to 
        'communicate between our objects

        'Create an Arraylist to hold all the order Info
        Dim orderList As New ArrayList

        Try
            orderList.Add(txtID.Text)   'Add Order ID
            orderList.Add(txtName.Text) 'Add Customer Name
            orderList.Add(txtPhone.Text) 'Add Phone #
            orderList.Add(txtDate.Text) 'Add Date

            'Create an ArrayList to hold all the order detail info
            'for the first 3 lines
            Dim detailList As New ArrayList
            Dim aPriceHelper As String = ""



            For i As Integer = 0 To lstLblItem.Count - 1

                'Create an Array to hold the information for each line item
                'Line Number, Item Description, Qty, Price
                Dim arrDetailItems(3) As String

                If i = 0 Then
                    arrDetailItems(0) = Me.pnlOrderDetails.Controls("lblLine" & 1).Text
                    arrDetailItems(1) = Me.pnlOrderDetails.Controls("cboItem" & 1).Text
                    arrDetailItems(2) = Me.pnlOrderDetails.Controls("txtQty" & 1).Text
                    aPriceHelper = Me.pnlOrderDetails.Controls("txtPrice" & 1).Text

                    aPriceHelper = aPriceHelper.Replace("$", "")
                    aPriceHelper = aPriceHelper.Replace(".", "")
                    arrDetailItems(3) = aPriceHelper

                ElseIf i > 0 Then
                    'set vairables to hold the value
                    Dim lblCtrl As Label = lstLblItem(i)
                    Dim cboCtrl As ComboBox = lstCboItem(i)
                    Dim qtyCtrl As TextBox = lstQtyItem(i)
                    Dim priceCtrl As TextBox = lstPriceItem(i)

                    'Vairable to get rid of currency format

                    aPriceHelper = priceCtrl.Text
                    aPriceHelper = aPriceHelper.Replace("$", "")
                    aPriceHelper = aPriceHelper.Replace(".", "")


                    arrDetailItems(0) = lblCtrl.Text
                    arrDetailItems(1) = cboCtrl.Text
                    arrDetailItems(2) = qtyCtrl.Text
                    arrDetailItems(3) = aPriceHelper


                End If

                'Add the array to our Detail arraylist
                detailList.Add(arrDetailItems)
            Next

            'Add the detail arraylist to the order arraylist
            orderList.Add(detailList)

            'Add Delivery price, use deliveryCharge to change formated currency into a good string for arra
            Dim deliveryCharge As String

            deliveryCharge = txtdeliveryCharge.Text

            deliveryCharge = deliveryCharge.Replace("$10.00", "10")
            deliveryCharge = deliveryCharge.Replace("$0.00", "0")
            txtdeliveryCharge.Text = deliveryCharge


            orderList.Add(txtdeliveryCharge.Text)

            'Add in the Billing Address Info
            orderList.Add(txtBillStreet.Text)
            orderList.Add(txtBillCity.Text)
            orderList.Add(txtBillState.Text)
            orderList.Add(txtBillZip.Text)

            'Add in the Shipping Address Info
            orderList.Add(txtShipStreet.Text)
            orderList.Add(txtShipCity.Text)
            orderList.Add(txtShipState.Text)
            orderList.Add(txtShipZip.Text)

            'Save the count so we know how many line boxes to create when we open it
            orderList.Add(lstCboItem.Count)
            'Save the order
            controller.Save(orderList)

            'Check for errors
            If controller.getError <> "" Then

                'Display the list of all errors
                MessageBox.Show(controller.getError, "Error saving order", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else

                'Loop through each detail line

                'use the order ID and the line ID to identify
                'the order and the line item
                For i As Integer = 0 To lstLblItem.Count - 1
                    If i = 0 Then
                        Me.pnlOrderDetails.Controls("lblTotal" & 1).Text = FormatCurrency(controller.getLineTotal(txtID.Text, i + 1))
                    ElseIf i > 0 Then
                        'set vairables to hold the value
                        Dim totalCtrl As Label = lstTotalItem(i)
                        totalCtrl.Text = FormatCurrency(controller.getLineTotal(txtID.Text, i + 1))

                    End If

                Next

                '=== Add code below here to display totals
                txtSubTotal.Text = FormatCurrency(controller.getTotal(txtID.Text))
                txtTax.Text = FormatCurrency(controller.getTaxes(txtID.Text))
                txtOrderTotal.Text = FormatCurrency(controller.getGrandTotal(txtID.Text) + Convert.ToInt32(txtdeliveryCharge.Text))
                txtdeliveryCharge.Text = FormatCurrency(txtdeliveryCharge.Text)
            End If


        Catch ex As Exception
            'Anything else
            MessageBox.Show(ex.Message, "Error Saving Item", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        'Retrieve the order
        Dim orderinfo As ArrayList
        Dim orderDetailList As ArrayList

        Try
            orderinfo = controller.Retrieve(txtID.Text)
            txtID.Text = orderinfo(0)
            txtName.Text = orderinfo(1)
            txtPhone.Text = orderinfo(2)
            txtDate.Text = orderinfo(3)

            orderDetailList = orderinfo(4)

            Dim counterOfLineItems As Integer = orderinfo(17)
            Dim arrDetail As String()

            'Check to see how many controls are added to the form
            Dim b As Control
            For Each b In Me.pnlOrderDetails.Controls
                If TypeOf b Is ComboBox Then
                    lineCounter += 1
                End If
            Next

            'We make a look to check for and make sure our form looks like our order.
            Do While counterOfLineItems <> lineCounter
                If counterOfLineItems > lineCounter Then
                    btnAdd.PerformClick()
                    lineCounter += 1
                ElseIf counterOfLineItems < lineCounter Then
                    btnRemove.PerformClick()
                    lineCounter -= 1
                End If
            Loop

            For i As Integer = 0 To counterOfLineItems - 1
                arrDetail = orderDetailList.Item(i)



                If i = 0 Then
                    Me.pnlOrderDetails.Controls("cboItem" & 1).Text = arrDetail(1)
                    Me.pnlOrderDetails.Controls("txtQty" & 1).Text = arrDetail(2)
                    Me.pnlOrderDetails.Controls("txtPrice" & 1).Text = FormatCurrency(arrDetail(3))
                    Me.pnlOrderDetails.Controls("lblTotal" & 1).Text = FormatCurrency(arrDetail(4))

                ElseIf i > 0 Then


                    Dim cboCtrl As New ComboBox
                    Dim qtyCtrl As New TextBox
                    Dim priceCtrl As New TextBox
                    Dim totalCtrl As New Label

                    cboCtrl = lstCboItem(i)
                    qtyCtrl = lstQtyItem(i)
                    priceCtrl = lstPriceItem(i)
                    totalCtrl = lstTotalItem(i)


                    cboCtrl.Text = arrDetail(1)
                    qtyCtrl.Text = arrDetail(2)
                    priceCtrl.Text = FormatCurrency(arrDetail(3))
                    totalCtrl.Text = FormatCurrency(arrDetail(4))
                End If
            Next
            If orderinfo(8) <> "0" Then
                btnRdoDelivery.Select()
            End If

            If orderinfo(14) = " " Then
                Dim a As Control
                For Each a In Me.grpShipInfo.Controls
                    If TypeOf a Is CheckBox Then
                        DirectCast(a, CheckBox).Checked = True
                    End If
                Next
            End If


            'Display Order totals
            txtSubTotal.Text = FormatCurrency(orderinfo(5))
            txtTax.Text = FormatCurrency(orderinfo(6))
            txtOrderTotal.Text = FormatCurrency(orderinfo(7) + orderinfo(8))
            txtdeliveryCharge.Text = FormatCurrency(orderinfo(8))


            'Display Billing Information
            txtBillStreet.Text = orderinfo(9)
            txtBillCity.Text = orderinfo(10)
            txtBillState.Text = orderinfo(11)
            txtBillZip.Text = orderinfo(12)

            'Display Shipping Information

            txtShipStreet.Text = orderinfo(13)
            txtShipCity.Text = orderinfo(14)
            txtShipState.Text = orderinfo(15)
            txtShipZip.Text = orderinfo(16)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        'set line to zero so the add button dosent skip validations
        lineCounter = 0
    End Sub

    Private Sub frmChild_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Connect to the parent controller object
        'Child object doesn't create a new controller object
        'but instead uses the instace available in the parent form
        controller = CType(Me.ParentForm, frmMain).controller

        'Load menu into comboboxes

        itemsMenu = controller.getMenu()
        itemsPrices = controller.getPrices()

        cboItem1.Items.AddRange(itemsMenu)


        'everything below here is for the dynamically loaded combo boxes etc
        'Add control to arraylist of controls
        lstCboItem.Add(Me.cboItem1)
        lstLblItem.Add(Me.lblLine1)
        lstQtyItem.Add(Me.txtQty1)
        lstPriceItem.Add(Me.txtPrice1)
        lstTotalItem.Add(Me.lblTotal1)

        holdOurSelectedIndex = ""
    End Sub

    Private Sub addComboBox()

        Dim ctrlCboItem As ComboBox
        For Each ctrlCboItem In lstCboItem
            If ctrlCboItem.Name = cboItem1.Name Then
                ctrlCboItem.Enabled = False
                Continue For
            End If
            ctrlCboItem.Enabled = False
        Next

        Dim i As Integer = (lstCboItem.Count)

        Dim iTop = lstLblItem(i - 1).Location.Y + lstLblItem(i - 1).Height
        Dim iLeft = lstCboItem(i - 1).Location.X

        Dim ctrlCboItems As New ComboBox
        ctrlCboItem = ctrlCboItems
        ctrlCboItem.Enabled = True
        ctrlCboItem.Parent = Me.pnlOrderDetails
        ctrlCboItem.Location = New Point(iLeft, iTop)
        ctrlCboItem.Width = lstCboItem(i - 1).Width
        ctrlCboItem.Height = lstCboItem(i - 1).Height
        ctrlCboItem.Items.AddRange(itemsMenu)
        ctrlCboItem.Visible = True
        ctrlCboItems.DropDownStyle = ComboBoxStyle.DropDownList
        Me.pnlOrderDetails.Controls.Add(ctrlCboItem)

        AddHandler ctrlCboItem.SelectedIndexChanged, AddressOf ctrlCboItem_SelectedIndexChanged

        lstCboItem.Add(ctrlCboItem)

    End Sub

    Private Sub addLabels()
        Dim i As Integer = (lstLblItem.Count)

        'Get the location from the existing control
        '  Dim iTop = lstLblItem(i - 1).Location.Y + lstLblItem(i - 1).height
        Dim iTop = lstLblItem(i - 1).Location.Y + lstLblItem(i - 1).Height
        Dim iLeft = lstLblItem(i - 1).Location.X

        'Create a new control and set its properties
        Dim ctrlLblItem As New Label
        ctrlLblItem.Parent = Me.pnlOrderDetails
        ctrlLblItem.Location = New Point(iLeft, iTop)
        ctrlLblItem.Width = lstLblItem(i - 1).Width
        ctrlLblItem.Height = lstLblItem(i - 1).Height
        ctrlLblItem.Text = i + 1
        ctrlLblItem.Visible = True
        ctrlLblItem.BorderStyle = BorderStyle.Fixed3D
        'Add the control to the panel
        Me.pnlOrderDetails.Controls.Add(ctrlLblItem)


        'Add control to our arraylist of controls
        lstLblItem.Add(ctrlLblItem)
    End Sub

    Private Sub addQty()
        Dim i As Integer = (lstQtyItem.Count)
        'get the location of the existing control

        Dim ctrlQty As TextBox
        For Each ctrlQty In lstQtyItem
            If ctrlQty.Name = cboItem1.Name Then
                ctrlQty.Enabled = False
                Continue For
            End If
            ctrlQty.Enabled = False
        Next

        Dim iTop = lstLblItem(i - 1).Location.Y + lstLblItem(i - 1).Height
        Dim iLeft As Integer = CType(lstQtyItem(i - 1), TextBox).Location.X

        ctrlQty = New TextBox
        ctrlQty.Parent = Me.pnlOrderDetails
        ctrlQty.Location = New Point(iLeft, iTop)
        With ctrlQty
            .Width = CType(lstQtyItem(i - 1), TextBox).Width
            .Height = CType(lstQtyItem(i - 1), TextBox).Height
            .Text = "0"
            .Visible = True
        End With

        Me.pnlOrderDetails.Controls.Add(ctrlQty)

        lstQtyItem.Add(ctrlQty)

    End Sub

    Private Sub addPrice()

        Dim i As Integer = (lstPriceItem.Count)


        'get the location of the existing control
        'Dim iTop As Integer = CType(lstPriceItem(i - 1), Label).Location.Y + CType(lstPriceItem(i - 1), Label).Height
        Dim iTop = lstLblItem(i - 1).Location.Y + lstLblItem(i - 1).Height
        Dim iLeft As Integer = CType(lstPriceItem(i - 1), TextBox).Location.X


        'create a new control
        Dim ctrlPrice As New TextBox
        ctrlPrice.Parent = Me.pnlOrderDetails


        ctrlPrice.Location = New Point(iLeft, iTop)

        With ctrlPrice
            .Width = CType(lstPriceItem(i - 1), TextBox).Width
            .Height = CType(lstPriceItem(i - 1), TextBox).Height
            .Visible = True


        End With

        ctrlPrice.Text = holdOurSelectedIndex
        ctrlPrice.TextAlign = HorizontalAlignment.Right
        ctrlPrice.Enabled = False


        'add the control to the form
        Me.pnlOrderDetails.Controls.Add(ctrlPrice)

        'add the control to the list
        lstPriceItem.Add(ctrlPrice)

    End Sub

    Private Sub addTotal()
        Dim i As Integer = (lstTotalItem.Count)

        'Get the location from the existing control

        Dim iTop = lstLblItem(i - 1).Location.Y + lstLblItem(i - 1).Height
        Dim iLeft = lstTotalItem(i - 1).Location.X

        'Create a new control and set its properties
        Dim ctrlTotalItem As New Label
        ctrlTotalItem.Parent = Me.pnlOrderDetails
        ctrlTotalItem.Location = New Point(iLeft, iTop)
        ctrlTotalItem.Width = lstTotalItem(i - 1).Width
        ctrlTotalItem.Height = lstTotalItem(i - 1).Height
        ctrlTotalItem.Text = "0"
        ctrlTotalItem.Visible = True
        ctrlTotalItem.TextAlign = ContentAlignment.MiddleRight
        ctrlTotalItem.BorderStyle = BorderStyle.Fixed3D

        'Add the control to the panel
        Me.pnlOrderDetails.Controls.Add(ctrlTotalItem)


        'Add control to our arraylist of controls
        lstTotalItem.Add(ctrlTotalItem)
    End Sub

    Private Sub cis338(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '  CType(sender, ComboBox).SelectedIndex)
    End Sub


    Private Sub ctrlCboItem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim cboStoreObject As ComboBox
        cboStoreObject = CType(sender, ComboBox)


        Try

            If cboStoreObject.SelectedIndex <> -1 Then

                holdOurSelectedIndex = itemsPrices(cboStoreObject.SelectedIndex)
                RemovePrice()
                addPrice()
                holdOurSelectedIndex = " "
                Exit Try

            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        'Delete order using an ID
        'You can also clear all the data from the form
        'TODO: clear all the controls on the form

        Try
            controller.Delete(txtID.Text)
            MessageBox.Show("Deleted Order #" & txtID.Text & vbCrLf & vbCrLf & "Cleared form for you :)")
            btnClear.PerformClick()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Deleting Item")
        End Try

    End Sub

    Private Sub cboItem1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboItem1.SelectedIndexChanged
        If cboItem1.SelectedIndex <> -1 Then
            txtPrice1.Text = itemsPrices(cboItem1.SelectedIndex)
            holdOurSelectedIndex = " "
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim a As Control
        'I could do a For Each a in frmChild.Controls to work so I opted to selecte the panels or group boxes instead and clear it taht way

        For Each a In Me.pnlOrderDetails.Controls
            If TypeOf a Is TextBox Then
                a.Text = Nothing
            End If

            If TypeOf a Is ComboBox Then
                a.Text = Nothing
            End If

        Next

        For Each a In Me.grpFindBox.Controls
            If TypeOf a Is TextBox Then
                a.Text = Nothing
            End If
        Next

        For Each a In Me.Controls
            If TypeOf a Is TextBox Then
                a.Text = Nothing
            End If

        Next

        For Each a In Me.grpDelivery.Controls
            If TypeOf a Is RadioButton Then
                btnRdoPickup.Select()
            End If
        Next

        For Each a In Me.grpOdrTotal.Controls
            If TypeOf a Is TextBox Then
                a.Text = "0"
            End If
        Next

        For Each a In Me.grpBillInfo.Controls
            If TypeOf a Is TextBox Then
                a.Text = Nothing
            End If
        Next

        For Each a In Me.grpShipInfo.Controls
            If TypeOf a Is TextBox Then
                a.Text = Nothing
            End If

            If TypeOf a Is CheckBox Then
                DirectCast(a, CheckBox).Checked = False
            End If

        Next

        For i As Integer = 0 To lstLblItem.Count - 1

            If i = 0 Then
                Me.pnlOrderDetails.Controls("txtQty" & 1).Text = "0"
                Me.pnlOrderDetails.Controls("txtPrice" & 1).Text = "0"
                Me.pnlOrderDetails.Controls("lblTotal" & 1).Text = "0"
            ElseIf i > 0 Then
                btnRemove.PerformClick()
            End If
        Next

    End Sub

    Private Sub chkSameAsBilling_Checkedhanged(sender As Object, e As EventArgs) Handles chkSameAsBilling.CheckedChanged



        If chkSameAsBilling.Checked Then
            txtShipStreet.ReadOnly = True
            txtShipCity.ReadOnly = True
            txtShipState.ReadOnly = True
            txtShipZip.ReadOnly = True

            txtShipStreet.Text = " "
            txtShipCity.Text = " "
            txtShipState.Text = " "
            txtShipZip.Text = " "
        Else
            txtShipStreet.ReadOnly = False
            txtShipCity.ReadOnly = False
            txtShipState.ReadOnly = False
            txtShipZip.ReadOnly = False

        End If
    End Sub

    Private Sub btnRdoDelivery_CheckedChanged(sender As Object, e As EventArgs) Handles btnRdoDelivery.CheckedChanged
        txtdeliveryCharge.Text = FormatCurrency("10")
    End Sub

    Private Sub btnRdoPickup_CheckedChanged(sender As Object, e As EventArgs) Handles btnRdoPickup.CheckedChanged
        txtdeliveryCharge.Text = FormatCurrency("0")
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        'Make sure we leave the last controls on the form
        Dim intIndex = lstCboItem.Count
        If (intIndex) = 1 Then
            MessageBox.Show("Cannot remove the last control!", "Line Removal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        'Remove the control from the list
        RemoveComboBox()

        'Remove line label
        RemoveLabel()

        'Remove qty textbox
        RemoveQty()

        'Remove price label
        RemovePrice()

        'Remove the Total label
        RemoveTotal()

        anIntegerForAddingClicks -= 1
    End Sub

    Private Sub RemoveComboBox()
        'Remove the control from the list
        'Starting from the last element added to the list
        'Do not remove the last existing control from the form. Use this to check if it's the last line
        Dim intIndex = lstCboItem.Count - 1

        Dim ctrlCboItem As New ComboBox
        ctrlCboItem = lstCboItem(intIndex)
        ctrlCboItem.Visible = False

        'Remove from panel
        pnlOrderDetails.Controls.Remove(ctrlCboItem)

        'Remove association from event handler
        RemoveHandler ctrlCboItem.SelectedIndexChanged, AddressOf ctrlCboItem_SelectedIndexChanged

        'Remove from controls arrayList
        lstCboItem.Remove(ctrlCboItem)

        'Release resources
        ctrlCboItem = Nothing


        intIndex = lstCboItem.Count - 1


        ctrlCboItem = lstCboItem(intIndex)
        ctrlCboItem.Enabled = True

    End Sub

    Private Sub RemoveLabel()
        Dim intIndex = lstLblItem.Count - 1

        Dim ctrl As New Label
        ctrl = lstLblItem(intIndex)
        ctrl.Visible = False

        'Remove from panel
        pnlOrderDetails.Controls.Remove(ctrl)

        'Remove from controls arrayList
        lstLblItem.Remove(ctrl)

        'Release resources
        ctrl = Nothing
    End Sub

    Private Sub RemoveQty()
        Dim intIndex = lstQtyItem.Count - 1
        Dim ctrl As New TextBox
        ctrl = lstQtyItem(intIndex)
        ctrl.Visible = False

        'Remove from panel
        pnlOrderDetails.Controls.Remove(ctrl)

        'Remove from controls arrayList
        lstQtyItem.Remove(ctrl)

        'Release resources
        ctrl = Nothing

        intIndex = lstQtyItem.Count - 1


        ctrl = lstQtyItem(intIndex)
        ctrl.Enabled = True
    End Sub

    Private Sub RemovePrice()
        Dim intIndex = lstPriceItem.Count - 1
        Dim ctrl As New TextBox
        ctrl = lstPriceItem(intIndex)
        ctrl.Visible = False

        'Remove from panel
        pnlOrderDetails.Controls.Remove(ctrl)

        'Remove from controls arrayList
        lstPriceItem.Remove(ctrl)

        'Release resources
        ctrl = Nothing
    End Sub

    Private Sub RemoveTotal()
        Dim intIndex = lstTotalItem.Count - 1

        Dim ctrl As New Label
        ctrl = lstTotalItem(intIndex)
        ctrl.Visible = False

        'Remove from panel
        pnlOrderDetails.Controls.Remove(ctrl)

        'Remove from controls arrayList
        lstTotalItem.Remove(ctrl)

        'Release resources
        ctrl = Nothing
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Try
            If lineCounter > 0 Then
                Exit Try
            End If

            If isOurLineItemFilledIn() = False Then
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        'Set to nothing here so we can add a new combo box if you change combo box this also changes
        holdOurSelectedIndex = ""

        'Add combobox
        addComboBox()

        'Add line label
        addLabels()


        comboBoxCount += 1

        'Add qantity textbox
        addQty()

        'Add price txtBox
        addPrice()

        'Add total label
        addTotal()

        anIntegerForAddingClicks = lstLblItem.Count - 1
    End Sub

    Private Function isOurLineItemFilledIn() As Boolean
        Dim bResult As Boolean
        bResult = True
        Try
            If comboBoxCount = 0 Then
                Exit Try
            ElseIf holdOurSelectedIndex = "" Then
                MessageBox.Show("Please select a line item before adding another")
                bResult = False
            End If

            'Testing for each testbox qty to see if they are empty
            Dim testBox As TextBox
            For Each testBox In lstQtyItem


                If testBox.Text = "" OrElse CType(testBox.Text, Integer) <= 0 Then
                    MessageBox.Show("Enter in a valid Qty number")
                    bResult = False
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
        Return bResult
    End Function
End Class

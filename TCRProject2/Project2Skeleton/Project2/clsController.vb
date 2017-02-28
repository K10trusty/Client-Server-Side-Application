Public Class clsController

    'A comment for this class goes here.
    'The comment should describe the purpose of 
    'the class and anthing else that is relevant 
    'for future development.
    'Please comment all your Subs / Functions / Variable Declaration
    'appropriately

    'Collection to hold our orders
    Private colOrders As New Hashtable
    Private anOrder As clsOrder
    Private strError As String

    Public Sub Save(ByVal OrderInfoList As ArrayList)
        Dim overwriteOrder As Boolean
        Dim result As Integer

        overwriteOrder = True
        'Check to see if order is already saved
        'If that's the case exit
        If colOrders.Contains(OrderInfoList(0)) Then
            '  addError("ID: Duplicate Order ID (Order exists already!)")
            result = MessageBox.Show("Replace exisitng order?",
                                           "Duplicate Order ID", MessageBoxButtons.YesNo)

            If result = DialogResult.No Then
                MessageBox.Show("Order is not saved.", "Error")
                overwriteOrder = False
            Else
                MessageBox.Show("Order is saved.")
                '       colOrders.Remove(OrderInfoList(0))

            End If
        End If

        If overwriteOrder = True Then
            'Create an order object an Order
            Dim order As New clsOrder

            'Clear the Class error variable
            strError = ""

            Try
                'Store the Order
                order.ID = OrderInfoList(0)                     '0
                order.CustomerName = OrderInfoList(1)           '1
                order.Phone = OrderInfoList(2)
                order.WorkingDate = OrderInfoList(3)
                'Store the detail
                order.AddDetail(OrderInfoList(4))               '4
                'Store the deliver charge
                order.Delivery = OrderInfoList(5)
                'Store the billing info
                order.BillStreet = OrderInfoList(6)             '6
                order.BillCity = OrderInfoList(7)               '7
                order.BillState = OrderInfoList(8)      '8
                order.BillZip = OrderInfoList(9)        '9
                'store the shipping info


                order.ShipStreet = OrderInfoList(10)

                order.ShipCity = OrderInfoList(11)
                order.ShipState = OrderInfoList(12)
                order.ShipZip = OrderInfoList(13)
                order.ListCount = OrderInfoList(14)

                'Check for errors
                If order.getError = "" Then
                    colOrders.Remove(order.ID)
                    colOrders.Add(order.ID, order)
                Else
                    addError(order.getError)
                End If

            Catch ex As Exception
                'Add anything we haven't handeled to our
                'Class error message
                addError(ex.Message)
            End Try
        End If
    End Sub

    Public Sub Delete(ByVal anID As String)
        'Delete an Order
        If colOrders.Contains(anID) = False Then
            Throw New ApplicationException("Item not found (ID:" & anID & ")")
        Else
            colOrders.Remove(anID)
        End If

    End Sub

    Public Function getLineTotal(ByVal anID As String, ByVal iLine As Integer) As Decimal
        'Check to see if the collection hold the order by using the order id
        If colOrders.Contains(anID) Then

            'Load the order into a myOrder object
            Dim myOrder As clsOrder = CType(colOrders.Item(anID), clsOrder)

            'execute the getLineTotal method of the Order
            Return myOrder.getLineTotal(iLine)
        Else
            addError("ID: Cannot Retrieve Detail for Order")
            Return -1
        End If
    End Function

    Public Function getTotal(ByVal anID As String) As Decimal
        'return the order total
        Dim order As New clsOrder
        order = colOrders.Item(anID)
        Return order.getTotal()
    End Function

    Public Function getTaxes(ByVal anID As String) As Decimal
        'return the tax amout
        Dim order As New clsOrder
        order = colOrders.Item(anID)
        Return order.getTaxes()

    End Function

    Public Function getGrandTotal(ByVal anID As String) As Decimal
        'return the tax + total amount
        Dim order As New clsOrder
        order = colOrders.Item(anID)
        Return order.getGrandTotal()

    End Function



    Public Function Retrieve(ByVal anID As String) As ArrayList
        'Retrieve an Order
        Dim order As New clsOrder
        Dim orderInfo As New ArrayList
        Try
            'get the order object
            order = colOrders.Item(anID)

            'retrieve the order header info
            orderInfo.Add(order.ID)             '0
            orderInfo.Add(order.CustomerName)   '1
            orderInfo.Add(order.Phone)          '2 
            orderInfo.Add(order.WorkingDate)    '3

            'retrieve the order detail info
            orderInfo.Add(order.GetDetail())    '4

            'retrieves the order total
            orderInfo.Add(order.getTotal())     '5
            'retrives the tax total
            orderInfo.Add(order.getTaxes())     '6

            'retrives the total of order + taxes
            orderInfo.Add(order.getGrandTotal()) '7

            'retrives the delivery info
            orderInfo.Add(order.Delivery)    '8

            'retrives the Billing Info
            orderInfo.Add(order.BillStreet)   '9
            orderInfo.Add(order.BillCity)   '10
            orderInfo.Add(order.BillState)  '11
            orderInfo.Add(order.BillZip)    '12

            'retrives the Shipping Info
            orderInfo.Add(order.ShipStreet)   '13
            orderInfo.Add(order.ShipCity)   '14
            orderInfo.Add(order.ShipState)  '15
            orderInfo.Add(order.ShipZip)    '16

            'retrives the count of how many line items their are!
            orderInfo.Add(order.ListCount)  '17
        Catch ex As Exception
            'If there is not matching order
            'return an error
            If IsNothing(order) Then
                Throw New ApplicationException("Item not found, ID: " & anID)
            Else
                'Any other error push back up the stack
                Throw
            End If
        End Try

        Return orderInfo
    End Function

    Public Function getMenu() As String()
        'return the menu
        Dim menu() As String = {"Ghost", "Hornet", "Chopper", "Banshee"}

        Return menu
    End Function

    Public Function getPrices() As String()
        'return the prices
        Dim prices() As String = {"1000", "2000", "3000", "4000"}

        Return prices
    End Function

    Private Sub addError(ByVal s As String)
        'Add an error to the error list
        If strError = "" Then
            strError = s
        Else
            strError += vbCrLf & s
        End If
    End Sub

    Public Function getError() As String
        'return all errors for this object
        Return strError
    End Function
End Class

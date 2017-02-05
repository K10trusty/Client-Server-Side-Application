Imports System.IO

Public Class frmMain

    Dim errorMessage As String = ""

    Dim numberOfTests As Int32
    Dim vehiclesTested As Int32
    Dim totalMilesTravled As Double
    Dim totalFuelCellsUsed As Double
    Dim totalCost As Double



    Private Sub cboId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboId.SelectedIndexChanged

        'Picture Combo Box This Displays The Driver Picture and Info

        Dim selectedId As Short
        selectedId = CShort(cboId.SelectedItem)

        If selectedId = 100 Then
            txtDriverInfoFirstName.Text = "Bart"
            txtDriverInfoLastName.Text = "Simpson"
            txtPhone.Text = "909-888-7777"
            picSimpson.Image = Image.FromFile(Directory.GetCurrentDirectory() & "/images/image1.png")

        ElseIf selectedId = 200 Then
            txtDriverInfoFirstName.Text = "Homer"
            txtDriverInfoLastName.Text = "Simpson"
            txtPhone.Text = "909-666-5555"
            picSimpson.Image = Image.FromFile(Directory.GetCurrentDirectory() & "/images/image2.png")

        ElseIf selectedId = 300 Then
            txtDriverInfoFirstName.Text = "Marge"
            txtDriverInfoLastName.Text = "Simpson"
            txtPhone.Text = "909-111-3333"
            picSimpson.Image = Image.FromFile(Directory.GetCurrentDirectory() & "/images/image3.png")

        ElseIf selectedId = 400 Then
            txtDriverInfoFirstName.Text = "Lisa"
            txtDriverInfoLastName.Text = "Simpson"
            txtPhone.Text = "909-333-6666"
            picSimpson.Image = Image.FromFile(Directory.GetCurrentDirectory() & "/images/image4.png")

        End If


    End Sub

    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click

        'Validation Runs First
        If checkData() = False Then
            MessageBox.Show(errorMessage)
            Exit Sub
        End If






        'Variables used in Data to represent the results Vehcile and Family

        Dim vehcile1 As String
        Dim vehcile2 As String
        Dim vehcile3 As String
        Dim vehcile4 As String

        vehcile1 = CType(cboDataVehcile1.SelectedItem, String)
        vehcile2 = CType(cboDataVehcile2.SelectedItem, String)
        vehcile3 = CType(cboDataVehcile3.SelectedItem, String)
        vehcile4 = CType(cboDataVehcile4.SelectedItem, String)

        txtVehicle1.Text = vehcile1
        txtVehicle2.Text = vehcile2
        txtVehicle3.Text = vehcile3
        txtVehicle4.Text = vehcile4

        If vehcile1 = "Ghost" OrElse vehcile1 = "Banshee" OrElse vehcile1 = "Chopper" Then
            txtFamily1.Text = "Covenant"
        ElseIf vehcile1 = "Hornet" Then
            txtFamily1.Text = "UNSC"
        End If

        If vehcile2 = "Ghost" OrElse vehcile2 = "Banshee" OrElse vehcile2 = "Chopper" Then
            txtFamily2.Text = "Covenant"
        ElseIf vehcile2 = "Hornet" Then
            txtFamily2.Text = "UNSC"
        End If

        If vehcile3 = "Ghost" OrElse vehcile3 = "Banshee" OrElse vehcile3 = "Chopper" Then
            txtFamily3.Text = "Covenant"
        ElseIf vehcile3 = "Hornet" Then
            txtFamily3.Text = "UNSC"
        End If

        If vehcile4 = "Ghost" OrElse vehcile4 = "Banshee" OrElse vehcile4 = "Chopper" Then
            txtFamily4.Text = "Covenant"
        ElseIf vehcile4 = "Hornet" Then
            txtFamily4.Text = "UNSC"
        End If

        'Mileage and how far they traveled
        Dim startMileage1 As UInt32
        Dim startMileage2 As UInt32
        Dim startMileage3 As UInt32
        Dim startMileage4 As UInt32

        Dim endMilage1 As UInt32
        Dim endMilage2 As UInt32
        Dim endMilage3 As UInt32
        Dim endMilage4 As UInt32

        Dim mileage1 As UInt32
        Dim mileage2 As UInt32
        Dim mileage3 As UInt32
        Dim mileage4 As UInt32

        startMileage1 = UInt32.Parse(txtStartMileage1.Text)
        startMileage2 = UInt32.Parse(txtStartMileage2.Text)
        startMileage3 = UInt32.Parse(txtStartMileage3.Text)
        startMileage4 = UInt32.Parse(txtStartMileage4.Text)

        endMilage1 = UInt32.Parse(txtEndMileage1.Text)
        endMilage2 = UInt32.Parse(txtEndMileage2.Text)
        endMilage3 = UInt32.Parse(txtEndMileage3.Text)
        endMilage4 = UInt32.Parse(txtEndMileage4.Text)

        'Used to calculate miles travled
        'Need to add validaiton to make sure that end milages is always bigger than start Mileage
        mileage1 = endMilage1 - startMileage1
        mileage2 = endMilage2 - startMileage2
        mileage3 = endMilage3 - startMileage3
        mileage4 = endMilage4 - startMileage4

        'Display the miles traveled in the Results Milage Box
        txtMileage1.Text = CType(mileage1, String)
        txtMileage2.Text = CType(mileage2, String)
        txtMileage3.Text = CType(mileage3, String)
        txtMileage4.Text = CType(mileage4, String)

        'Start Fuel Consumption
        Dim startFuel1 As UInt32
        Dim startFuel2 As UInt32
        Dim startFuel3 As UInt32
        Dim startFuel4 As UInt32

        Dim endFuel1 As UInt32
        Dim endFuel2 As UInt32
        Dim endFuel3 As UInt32
        Dim endFuel4 As UInt32

        Dim fuel1 As UInt32
        Dim fuel2 As UInt32
        Dim fuel3 As UInt32
        Dim fuel4 As UInt32

        startFuel1 = UInt32.Parse(txtStartFuel1.Text)
        startFuel2 = UInt32.Parse(txtStartFuel2.Text)
        startFuel3 = UInt32.Parse(txtStartFuel3.Text)
        startFuel4 = UInt32.Parse(txtStartFuel4.Text)

        endFuel1 = UInt32.Parse(txtEndFuel1.Text)
        endFuel2 = UInt32.Parse(txtEndFuel2.Text)
        endFuel3 = UInt32.Parse(txtEndFuel3.Text)
        endFuel4 = UInt32.Parse(txtEndFuel4.Text)

        'Used to caclualte the fuel used
        'Need to add validation to make sure the startfuel is more than the end fuel
        fuel1 = startFuel1 - endFuel1
        fuel2 = startFuel2 - endFuel2
        fuel3 = startFuel3 - endFuel3
        fuel4 = startFuel4 - endFuel4

        'Display the miles traveled in the Results Fuel Used Box
        txtFuelUsed1.Text = CType(fuel1, String)
        txtFuelUsed2.Text = CType(fuel2, String)
        txtFuelUsed3.Text = CType(fuel3, String)
        txtFuelUsed4.Text = CType(fuel4, String)

        Dim fuelCost1 As UInt32
        Dim fuelCost2 As UInt32
        Dim fuelCost3 As UInt32
        Dim fuelcost4 As UInt32

        'Price of Fuel
        Dim fuelCell As UInt32 = 22

        'Fuel Consumed * price of fuel
        fuelCost1 = fuel1 * fuelCell
        fuelCost2 = fuel2 * fuelCell
        fuelCost3 = fuel3 * fuelCell
        fuelcost4 = fuel4 * fuelCell


        txtFuelCost1.Text = FormatCurrency(fuelCost1)
        txtFuelCost2.Text = FormatCurrency(fuelCost2)
        txtFuelCost3.Text = FormatCurrency(fuelCost3)
        txtFuelCost4.Text = FormatCurrency(fuelcost4)


        'Begin mpfc Ratings
        'Using doubles so we dont have to deal with bankers math
        Dim mpfcRating1 As Double
        Dim mpfcRating2 As Double
        Dim mpfcRating3 As Double
        Dim mpfcRating4 As Double



        'Calcualted by Number of Miles Traveled / Fuel Cells Consumed
        mpfcRating1 = mileage1 / fuel1
        mpfcRating2 = mileage2 / fuel2
        mpfcRating3 = mileage3 / fuel3
        mpfcRating4 = mileage4 / fuel4

        If mpfcRating1 < 200 Then
            txtMpfcRating1.Text = "Guzzler"
        ElseIf mpfcRating1 >= 200 AndAlso mpfcRating1 <= 300 Then
            txtMpfcRating1.Text = "Economical"
        ElseIf mpfcRating1 > 300 Then
            txtMpfcRating1.Text = "Amazing"

        End If

        If mpfcRating2 < 200 Then
            txtMpfcRating2.Text = "Guzzler"
        ElseIf mpfcRating2 >= 200 AndAlso mpfcRating2 <= 300 Then
            txtMpfcRating2.Text = "Economical"
        ElseIf mpfcRating2 > 300 Then
            txtMpfcRating2.Text = "Amazing"
        End If

        If mpfcRating3 < 200 Then
            txtMpfcRating3.Text = "Guzzler"
        ElseIf mpfcRating3 >= 200 AndAlso mpfcRating3 <= 300 Then
            txtMpfcRating3.Text = "Economical"
        ElseIf mpfcRating3 > 300 Then
            txtMpfcRating3.Text = "Amazing"
        End If

        If mpfcRating4 < 200 Then
            txtMpfcRating4.Text = "Guzzler"
        ElseIf mpfcRating4 >= 200 AndAlso mpfcRating4 <= 300 Then
            txtMpfcRating4.Text = "Economical"
        ElseIf mpfcRating4 > 300 Then
            txtMpfcRating4.Text = "Amazing"
        End If

        'This is where our vairables are updated for our Sample Summary Form
        'In the future create their own methods to clean up the code
        numberOfTests += 1
        vehiclesTested += 4
        totalMilesTravled += mileage1 + mileage2 + mileage3 + mileage4
        totalFuelCellsUsed += fuel1 + fuel2 + fuel3 + fuel4
        totalCost += fuelCost1 + fuelCost2 + fuelCost3 + fuelcost4


    End Sub

    Public Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click


        txtTestNum.Text = ""
        txtDate.Text = ""
        txtInventorFirstName.Text = ""
        txtInventorLastName.Text = ""
        cboId.SelectedIndex = -1
        txtDriverInfoFirstName.Text = ""
        txtDriverInfoLastName.Text = ""
        txtPhone.Text = ""
        picSimpson.Image = Nothing
        cboDataVehcile1.SelectedIndex = -1
        cboDataVehcile2.SelectedIndex = -1
        cboDataVehcile3.SelectedIndex = -1
        cboDataVehcile4.SelectedIndex = -1
        txtStartMileage1.Text = ""
        txtStartMileage2.Text = ""
        txtStartMileage3.Text = ""
        txtStartMileage4.Text = ""
        txtEndMileage1.Text = ""
        txtEndMileage2.Text = ""
        txtEndMileage3.Text = ""
        txtEndMileage4.Text = ""
        txtStartFuel1.Text = ""
        txtStartFuel2.Text = ""
        txtStartFuel3.Text = ""
        txtStartFuel4.Text = ""
        txtEndFuel1.Text = ""
        txtEndFuel2.Text = ""
        txtEndFuel3.Text = ""
        txtEndFuel4.Text = ""
        txtVehicle1.Text = ""
        txtVehicle2.Text = ""
        txtVehicle3.Text = ""
        txtVehicle4.Text = ""
        txtFamily1.Text = ""
        txtFamily2.Text = ""
        txtFamily3.Text = ""
        txtFamily4.Text = ""
        txtMileage1.Text = ""
        txtMileage2.Text = ""
        txtMileage3.Text = ""
        txtMileage4.Text = ""
        txtFuelUsed1.Text = ""
        txtFuelUsed2.Text = ""
        txtFuelUsed3.Text = ""
        txtFuelUsed4.Text = ""
        txtFuelCost1.Text = ""
        txtFuelCost2.Text = ""
        txtFuelCost3.Text = ""
        txtFuelCost4.Text = ""
        txtMpfcRating1.Text = ""
        txtMpfcRating2.Text = ""
        txtMpfcRating3.Text = ""
        txtMpfcRating4.Text = ""


    End Sub

    Private Function checkData() As Boolean

        'In the future switch over to try catch and use a while procedure to prompt the user to input correct vairbles in the box untill they do
        'Also try to add the error provider for each control

        'Clearing out error Message From previous tests
        errorMessage = "Please fix all Errors Before you Continue" + vbNewLine

        'Clear error provider
        MpfcErros.Clear()

        'variable to hold int value 
        Dim testNumber As UInt32

        'checking the test number to make sure it is not empty, and is a numerical value withing UInt32
        If txtTestNum.Text = "" OrElse UInt32.TryParse(txtTestNum.Text, testNumber) = False OrElse UInt32.Parse(txtTestNum.Text) > 4294967295 Then
            errorMessage += "Enter a Valid Test Number Greater Than 0" + vbNewLine
        End If

        '**************************************************
        'Date Validation
        '**************************************************


        Dim dateTest As Date

        If txtDate.Text = "" OrElse Date.TryParse(txtDate.Text, dateTest) = False Then
            errorMessage += "Enter a Valid Date with the format MM/DD/YY" + vbNewLine
        End If

        'Make sure InventorInfo First Name and Last Name are not blank
        Dim inventorFirstName As Double
        Dim inventorLastName As Double

        If txtInventorFirstName.Text = "" OrElse Double.TryParse(txtInventorFirstName.Text, inventorFirstName) Then
            errorMessage += "Enter a Valid Inventor's First Name" + vbNewLine
        End If

        If txtInventorLastName.Text = "" OrElse Double.TryParse(txtInventorLastName.Text, inventorLastName) Then
            errorMessage += "Enter a Valid Inventor's Last Name" + vbNewLine
        End If

        'Check to see If the User in the Driver Info ComboBox has selected an Id
        If cboId.Text = "" OrElse cboId.Text <> "100" AndAlso cboId.Text <> "200" AndAlso cboId.Text <> "300" AndAlso
            cboId.Text <> "400" Then
            errorMessage += "Select a Valid Driver ID" + vbNewLine
        End If

        'Check to see if a combobox vehcile is selected for each box in the data
        If cboDataVehcile1.Text = "" OrElse cboDataVehcile1.Text <> "Ghost" AndAlso cboDataVehcile1.Text <> "Banshee" AndAlso
            cboDataVehcile1.Text <> "Hornet" AndAlso cboDataVehcile1.Text <> "Chopper" Then
            errorMessage += "Select a Valid Vehcile for the First Box" + vbNewLine
        End If

        If cboDataVehcile2.Text = "" OrElse cboDataVehcile2.Text <> "Ghost" AndAlso cboDataVehcile2.Text <> "Banshee" AndAlso
            cboDataVehcile2.Text <> "Hornet" AndAlso cboDataVehcile2.Text <> "Chopper" Then
            errorMessage += "Select a Valid Vehcile for the Second Box" + vbNewLine
        End If

        If cboDataVehcile3.Text = "" OrElse cboDataVehcile3.Text <> "Ghost" AndAlso cboDataVehcile3.Text <> "Banshee" AndAlso
            cboDataVehcile3.Text <> "Hornet" AndAlso cboDataVehcile3.Text <> "Chopper" Then
            errorMessage += "Select a Valid Vehcile for the Third Box" + vbNewLine
        End If

        If cboDataVehcile4.Text = "" OrElse cboDataVehcile4.Text <> "Ghost" AndAlso cboDataVehcile4.Text <> "Banshee" AndAlso
            cboDataVehcile4.Text <> "Hornet" AndAlso cboDataVehcile4.Text <> "Chopper" Then
            errorMessage += "Select a Valid Vehcile for the Forth Box" + vbNewLine
        End If

        'Checking start mileage to see if it is only numerical value and not empty and falls withing the UInt32 range
        Dim startMileageTest As UInt32

        If txtStartMileage1.Text = "" OrElse UInt32.TryParse(txtStartMileage1.Text, startMileageTest) = False OrElse UInt32.Parse(txtStartMileage1.Text) > 4294967295 Then
            errorMessage += "Enter a Valid Whole Number for the First Start Mileage Box" + vbNewLine
        End If

        If txtStartMileage2.Text = "" OrElse UInt32.TryParse(txtStartMileage2.Text, startMileageTest) = False OrElse UInt32.Parse(txtStartMileage2.Text) > 4294967295 Then
            errorMessage += "Enter a Valid Whole Number for the Second Start Mileage Box" + vbNewLine
        End If

        If txtStartMileage3.Text = "" OrElse UInt32.TryParse(txtStartMileage3.Text, startMileageTest) = False OrElse UInt32.Parse(txtStartMileage3.Text) > 4294967295 Then
            errorMessage += "Enter a Valid Whole Number for the Third Start Mileage Box" + vbNewLine
        End If

        If txtStartMileage4.Text = "" OrElse UInt32.TryParse(txtStartMileage4.Text, startMileageTest) = False OrElse UInt32.Parse(txtStartMileage4.Text) > 4294967295 Then
            errorMessage += "Enter a Valid Whole Number for the Forth Start Mileage Box" + vbNewLine
        End If

        'Checking end mileage to see if it is only numerical value and not empty and falls withing the Uint32 range
        Dim endMileageTest As UInt32

        If txtEndMileage1.Text = "" OrElse UInt32.TryParse(txtEndFuel1.Text, endMileageTest) = False OrElse UInt32.Parse(txtEndFuel1.Text) > 4294967295 Then
            errorMessage += "Enter a Valid Whole Number for the First End Mileage Box" + vbNewLine
        End If

        If txtEndMileage2.Text = "" OrElse UInt32.TryParse(txtEndFuel2.Text, endMileageTest) = False OrElse UInt32.Parse(txtEndFuel2.Text) > 4294967295 Then
            errorMessage += "Enter a Valid Whole Number for the Second End Mileage Box" + vbNewLine
        End If

        If txtEndMileage3.Text = "" OrElse UInt32.TryParse(txtEndFuel3.Text, endMileageTest) = False OrElse UInt32.Parse(txtEndFuel3.Text) > 4294967295 Then
            errorMessage += "Enter a Valid Whole Number for the Third End Mileage Box" + vbNewLine
        End If

        If txtEndMileage4.Text = "" OrElse UInt32.TryParse(txtEndFuel4.Text, endMileageTest) = False OrElse UInt32.Parse(txtEndFuel4.Text) > 4294967295 Then
            errorMessage += "Enter a Valid Whole Number for the Forth End Mileage Box" + vbNewLine
        End If

        'Checking Start Fuel to see if it is only numerical value and not empty and withing the UInt32 range
        Dim startFuelTest As UInt32

        If txtStartFuel1.Text = "" OrElse UInt32.TryParse(txtStartFuel1.Text, startFuelTest) = False OrElse UInt32.Parse(txtStartFuel1.Text) > 4294967295 Then
            errorMessage += "Enter a Valid Whole Number for the First Start Fuel Box" + vbNewLine
        End If

        If txtStartFuel2.Text = "" OrElse UInt32.TryParse(txtStartFuel2.Text, startFuelTest) = False OrElse UInt32.Parse(txtStartFuel2.Text) > 4294967295 Then
            errorMessage += "Enter a Valid Whole Number for the Second Start Fuel Box" + vbNewLine
        End If

        If txtStartFuel3.Text = "" OrElse UInt32.TryParse(txtStartFuel3.Text, startFuelTest) = False OrElse UInt32.Parse(txtStartFuel3.Text) > 4294967295 Then
            errorMessage += "Enter a Valid Whole Number for the Third Start Fuel Box" + vbNewLine
        End If

        If txtStartFuel4.Text = "" OrElse UInt32.TryParse(txtStartFuel4.Text, startFuelTest) = False OrElse UInt32.Parse(txtStartFuel4.Text) > 4294967295 Then
            errorMessage += "Enter a Valid Whole Number for the Forth Start Fuel Box" + vbNewLine
        End If

        'Checking End Fuel to see if it is only numerical value and not empty and within the UInt 32 range
        Dim endFueltest As UInt32

        If txtEndFuel1.Text = "" OrElse UInt32.TryParse(txtEndFuel1.Text, endFueltest) = False OrElse UInt32.Parse(txtEndFuel1.Text) > 4294967295 Then
            errorMessage += "Enter a Valid Whole Number for the First End Fuel Box" + vbNewLine
        End If

        If txtEndFuel2.Text = "" OrElse UInt32.TryParse(txtEndFuel2.Text, endFueltest) = False OrElse UInt32.Parse(txtEndFuel2.Text) > 4294967295 Then
            errorMessage += "Enter a Valid Whole Number for the Second End Fuel Box" + vbNewLine
        End If

        If txtEndFuel3.Text = "" OrElse UInt32.TryParse(txtEndFuel3.Text, endFueltest) = False OrElse UInt32.Parse(txtEndFuel3.Text) > 4294967295 Then
            errorMessage += "Enter a Valid Whole Number for the Third End Fuel Box" + vbNewLine
        End If

        If txtEndFuel4.Text = "" OrElse UInt32.TryParse(txtEndFuel4.Text, endFueltest) = False OrElse UInt32.Parse(txtEndFuel4.Text) > 4294967295 Then
            errorMessage += "Enter a Valid Whole Number for the Fourth End Fuel Box" + vbNewLine
        End If


        'Ending it, if there is what we set the default errorMessage to then we contiue onto calculations
        If (errorMessage <> "Please fix all Errors Before you Continue" + vbNewLine) Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub btnAllTests_Click(sender As Object, e As EventArgs) Handles btnAllTests.Click
        Dim f As New SummaryForm

        f.lblDisplayNumberOfTests.Text = CType(numberOfTests, String)
        f.lblDisplayVehiclesTested.Text = CType(vehiclesTested, String)
        f.lblDisplayTotalMilesTravelled.Text = CType(totalMilesTravled, String)
        f.lblDisplayTotalFuelCellsUsed.Text = CType(totalFuelCellsUsed, String)
        f.lblDisplayTotalCost.Text = CType(FormatCurrency(totalCost), String)

        f.ShowDialog()

    End Sub

End Class

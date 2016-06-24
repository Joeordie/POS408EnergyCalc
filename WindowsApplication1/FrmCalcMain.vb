Public Class FrmMain
    'Declare Form-wide variables
    Dim decTotalCost As Decimal = 0
    Dim decGrandTotalKWh As Decimal = 0
    Dim decGrandTotalGallon As Decimal = 0
    Dim decGallonTotalCost As Decimal = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Call Function
        AddAppliance()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Function AddAppliance()
        'Declare appliance name for check and internal decimal rate 
        Dim StrApplianceName As String = cbxAppliance.Text
        Dim decRate As Decimal = tbxRate.Text
        'Perform Appliance Check Function if the AddAppianceCheck returns a 0 then its goodnow perform math
        If AddApplianceCheck(StrApplianceName, decRate) = 0 Then
            Dim decApplianceKWh As Decimal = tbxKWh.Text
            Dim decApplianceOpHours As Decimal = tbxHoursOp.Text
            'Calculate appliance KWh from Kilowatts * Operation Hours
            Dim decApplianceTotalKWh As Decimal = decApplianceKWh * decApplianceOpHours
            'Calculate Cost of appliance by multiplying ApplianceKWh * KWh Rate. 
            Dim decApplianceCostPerLine As Decimal = decApplianceTotalKWh * decRate
            'Increment Total cost tally. 
            decTotalCost = decTotalCost + decApplianceCostPerLine
            'Display total cost
            tbxTotalEnergyCost.Text = decTotalCost
            'Increment Total KWh tally
            decGrandTotalKWh = decGrandTotalKWh + decApplianceTotalKWh
            'Display total KWh
            tbxGrandTotalKWh.Text = decGrandTotalKWh
            'Set Operating hours on appliances that use water. 
            FrmWater.DecOpHrs = decApplianceOpHours
            '
            ' ListView Loading Result
            'Dim objLoader As ListViewItem
            '
            'Build and load array of strings 
            Dim strViewLoad(4) As String            
            strViewLoad(0) = StrApplianceName
            strViewLoad(1) = CStr(decApplianceKWh)
            strViewLoad(2) = CStr(decApplianceOpHours)
            strViewLoad(3) = CStr(decApplianceTotalKWh)
            strViewLoad(4) = CStr(decApplianceCostPerLine)
            'Construct line as string. 
            Dim strLineLoad As String = strViewLoad(0) & "    " & strViewLoad(1) & "KW    " & strViewLoad(2) & "Hrs    " & strViewLoad(3) & "KWh    $" & strViewLoad(4)
            ltvResult.Items.Add(strLineLoad)
            '
            'Could not get objectLoader to work below... never added the entire array only first element :(
            '
            'objLoader = New ListViewItem(strViewLoad)
            'ltvResult.Items.Add(objLoader)
        Else
            cbxAppliance.Focus()
        End If
    End Function

    Function AddWater(DecGalPerHour As Decimal, DecPricePerGallon As Decimal, DecOpHours As Decimal)
        'Perform Math to determine Gallon Usage and Cost per Usage
        Dim decGallonsPerLine = DecGalPerHour * DecOpHours
        Dim decGallonCostPerLine = decGallonsPerLine * DecPricePerGallon
        'Make a string to load into the listview 
        Dim strLineLoad As String = decGallonsPerLine & " Gals    $" & decGallonCostPerLine
        'load string into listview
        ltvResult.Items.Add(strLineLoad)
        'increment global usage variables (gallon cost and gallons used.)
        decGallonTotalCost = decGallonTotalCost + decGallonCostPerLine
        decGrandTotalGallon = decGrandTotalGallon + decGallonsPerLine
        'update global variable display
        tbxTotalGallon.Text = decGrandTotalGallon
        tbxTotalGallonCost.Text = decGallonTotalCost
    End Function

    Function AddApplianceCheck(strApplianceCheckName As String, ApplianceRate As Decimal)
        'Check input for Appliance to be set to something Return 0 if good return 1 if we should not do maths
        If strApplianceCheckName = "" Then
            MessageBox.Show("Please Choose An Appliance", "Public Service Announcement")
            Return 1
        ElseIf ApplianceRate > 1 Then
            MessageBox.Show("Your Power Rate is ridiculous", "You Should Know")
            Return 1
        ElseIf strApplianceCheckName = "Dish Washer" Or strApplianceCheckName = "Washing Machine" Then
            FrmWater.Show()
            'Check for Dish Washer or Washing Machine.  Launch the water form
            Return 0
        Else
            Return 0
        End If
    End Function

    Private Sub ClearForm()
        'set all displays and global variables to default values
        tbxHoursOp.Text = "0"
        tbxKWh.Text = "0"
        tbxRate.Text = "0"
        ltvResult.Items.Clear()
        decTotalCost = "0"
        decGallonTotalCost = "0"
        decGrandTotalKWh = "0"
        tbxGrandTotalKWh.Text = ""
        tbxTotalEnergyCost.Text = ""
        tbxTotalGallon.Text = ""
        decGrandTotalGallon = 0
        tbxTotalGallonCost.Text = ""
    End Sub

    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxHoursOp.KeyPress, tbxKWh.KeyPress, tbxRate.KeyPress

        'Sub routine TextBox1_KeyPress recieves each key press stores as "e"  (Handles extends the other fields and methods that will be covered.... Did not 
        'Know you could actually do that.  Very Useful.  
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Asc(e.KeyChar) <> 46 AndAlso Not IsNumeric(e.KeyChar) Then
            'If statements use ASCII conversion 8 = backspace, 13 = carriage return, 46 for periodfinally checks for numeric status
            'If not the above characters then we throw the message box below. 
            MessageBox.Show("You should only enter numbers", "Public Service Announcement")
            'e.Handled = false allows keystrokes to enter into text box. 
            e.Handled = True
        End If
        'Taken from: http://www.visual-basic-tutorials.com/allow-numbers-only-in-a-text-in-visual-basic.htm#sthash.JZWOwt12.dpuf
    End Sub

End Class

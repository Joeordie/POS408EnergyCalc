Public Class FrmMain
    Dim decTotalCost As Decimal = 0
    Dim decGrandTotalKWh As Decimal = 0
    Dim decGrandTotalGallon As Decimal = 0
    Dim decGallonTotalCost As Decimal = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddAppliance()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Function AddAppliance()
        Dim StrApplianceName As String = cbxAppliance.Text
        Dim decRate As Decimal = tbxRate.Text
        'Perform Appliance Check Function
        If AddApplianceCheck(StrApplianceName, decRate) = 0 Then
            Dim decApplianceKWh As Decimal = tbxKWh.Text
            Dim decApplianceOpHours As Decimal = tbxHoursOp.Text
            Dim decApplianceTotalKWh As Decimal = decApplianceKWh * decApplianceOpHours
            Dim decApplianceCostPerLine As Decimal = decApplianceTotalKWh * decRate
            decTotalCost = decTotalCost + decApplianceCostPerLine
            tbxTotalEnergyCost.Text = decTotalCost
            decGrandTotalKWh = decGrandTotalKWh + decApplianceTotalKWh
            tbxGrandTotalKWh.Text = decGrandTotalKWh
            FrmWater.DecOpHrs = decApplianceOpHours
            '
            '
            ' ListView Loading Result
            Dim strViewLoad(4) As String
            'Dim objLoader As ListViewItem
            strViewLoad(0) = StrApplianceName
            strViewLoad(1) = CStr(decApplianceKWh)
            strViewLoad(2) = CStr(decApplianceOpHours)
            strViewLoad(3) = CStr(decApplianceTotalKWh)
            strViewLoad(4) = CStr(decApplianceCostPerLine)
            Dim strLineLoad As String = StrApplianceName & "    " & decApplianceKWh & "KWh    " & decApplianceOpHours & "Hrs    " & decApplianceTotalKWh & "KWh    $" & decApplianceCostPerLine
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
        Dim strLineLoad As String = decGallonsPerLine & " Gals    $" & decGallonCostPerLine
        ltvResult.Items.Add(strLineLoad)
        decGallonTotalCost = decGallonTotalCost + decGallonCostPerLine
        decGrandTotalGallon = decGrandTotalGallon + decGallonCostPerLine
        tbxTotalGallon.Text = decGrandTotalGallon
        tbxTotalGallonCost.Text = decGallonTotalCost
    End Function

    Function AddApplianceCheck(strApplianceCheckName As String, ApplianceRate As Decimal)
        'Check input for Appliance to be set to something
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

Imports System.IO

Public Class FrmMain
    'Declare Form-wide variables
    Dim decTotalCost As Decimal = 0
    Dim decGrandTotalKWh As Decimal = 0
    Dim decGrandTotalGallon As Decimal = 0
    Dim decGallonTotalCost As Decimal = 0
    Public decDefaults(11) As Decimal ' Defaults array from fileRead out needed several places

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load decDefaults Array with zeros to prevent bad things
        For i = 0 To 11
            decDefaults(i) = 0
        Next
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Call Function
        AddAppliance()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Call clear function
        ClearForm()
    End Sub

    Function AddAppliance()
        Try
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
                tbxTotalEnergyCost.Text = FormatCurrency(decTotalCost)
                'Increment Total KWh tally 
                decGrandTotalKWh = decGrandTotalKWh + decApplianceTotalKWh
                'Display total KWh 
                tbxGrandTotalKWh.Text = decGrandTotalKWh
                'Set Operating hours on appliances that use water. 
                FrmWater.decOpHrs = decApplianceOpHours
                ' 
                'ListView Loading Result
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
                Dim strLineLoad As String = ""
                'Formating based on length of the string if name is short add two tabs if name is long only 1. 
                If strViewLoad(0) = "Fan" Or strViewLoad(0) = "TV" Or strViewLoad(0) = "Dryer" Or strViewLoad(0) = "Oven" Then
                    strLineLoad = String.Format("{1}{0}{0}{2}KW{0}{3}Hrs{0}{4}KWh{0}{5}", vbTab, strViewLoad(0), strViewLoad(1), strViewLoad(2), strViewLoad(3), FormatCurrency(strViewLoad(4)))
                Else
                    strLineLoad = String.Format("{1}{0}{2}KW{0}{3}Hrs{0}{4}KWh{0}{5}", vbTab, strViewLoad(0), strViewLoad(1), strViewLoad(2), strViewLoad(3), FormatCurrency(strViewLoad(4)))
                End If

                lbxResult.Items.Add(strLineLoad)
                '
                'Could not get objectLoader to work below... never added the entire array only first element :(
                '
                'objLoader = New ListViewItem(strViewLoad)
                'ltvResult.Items.Add(objLoader)  
            Else
                cbxAppliance.Focus()
            End If

        Catch ex As Exception
            MessageBox.Show("One or more inputs is wrong, usually this means you have too many '.' in an input field.", "Public Service Announcement")
        End Try
    End Function

    Function AddWater(DecGalPerHour As Decimal, DecPricePerGallon As Decimal, DecOpHours As Decimal)
        'Perform Math to determine Gallon Usage and Cost per Usage
        Dim decGallonsPerLine = DecGalPerHour * DecOpHours
        Dim decGallonCostPerLine = decGallonsPerLine * DecPricePerGallon
        'Make a string to load into the listview 
        Dim strLineLoad As String = decGallonsPerLine & " Gals" & vbTab & vbTab & vbTab & vbTab & vbTab & "$" & decGallonCostPerLine
        'load string into listview
        lbxResult.Items.Add(strLineLoad)
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

    Function FileChoser(strIntent As String) As String
        Dim strFilePath As String
        'Taken from http://stackoverflow.com/questions/3283423/how-to-add-a-browse-to-file-dialog-to-a-vb-net-application
        If strIntent = "defaultIn" Then 'Flow Control for file choices
            Dim objFileDialog = New OpenFileDialog
            'Set File Chooser attributes 
            objFileDialog.Title = "Select Config File" 'Title
            objFileDialog.InitialDirectory = "C:\Users\" 'Startup Path
            objFileDialog.Filter = "Config files (*.conf)|*.conf|All files (*.*)|*.*" 'set .conf as preferred method of search
            objFileDialog.FilterIndex = 1 'Filter index to start on
            objFileDialog.RestoreDirectory = True 'Return to this directory if opened again
            'If the OK button is selected return strFilePath
            If objFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                strFilePath = objFileDialog.FileName
            Else ' if anything other than OK happens no file :(
                strFilePath = "null"
            End If
            DefaultsIn(strFilePath) ' See above
        ElseIf strIntent = "defaultOut" Then
            Dim objFileDialog = New SaveFileDialog
            objFileDialog.Title = "Save Config File"
            objFileDialog.InitialDirectory = ("C:\Users\")
            objFileDialog.Filter = "Config files (*.conf)|*.conf|All files (*.*)|*.*" 'set .conf as preferred method of search
            objFileDialog.FilterIndex = 1
            objFileDialog.RestoreDirectory = True
            If objFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                strFilePath = objFileDialog.FileName
                frmDefaults.Close()
            Else ' if anything other than OK happens no file :(
                strFilePath = "null"
            End If
            DefaultsOut(strFilePath)
        ElseIf strIntent = "report" Then
            Dim objFileDialog = New SaveFileDialog
            objFileDialog.Title = "Save Report File"
            objFileDialog.InitialDirectory = ("C:\Users\")
            objFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
            objFileDialog.FilterIndex = 1
            objFileDialog.RestoreDirectory = True
            If objFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                strFilePath = objFileDialog.FileName
                reportWriter(strFilePath)
            Else ' if anything other than OK happens no file :(
                strFilePath = "null"
            End If
        End If

        Return strFilePath
    End Function

    Function DefaultsIn(strFilePath As String) 'As Integer()
        'Declare variables for function
        'Return Array 
        If strFilePath = "null" Then ' Check for no file selected
            MessageBox.Show("No file selected.")
        Else
            Dim strWorkingString As String 'we readinto this
            Dim objFileReader = New StreamReader(strFilePath) 'Object to read file
            strWorkingString = objFileReader.ReadLine 'Read fileline out
            For index = 0 To 11 'Loop through array
                'string = shortened string... count till you get to the = sign then start your cut +1
                strWorkingString = strWorkingString.Substring(1 + strWorkingString.IndexOf("="))
                decDefaults(index) = strWorkingString 'Pass to array
                strWorkingString = objFileReader.ReadLine 'read next line!
            Next
            objFileReader.Close() 'close file so not to let flies in. 
        End If

        Return 0
        'intDefaults()
    End Function

    Sub DefaultsOut(strFilePath As String)
        'Instantiate writer object pass filepath and append = False
        Dim objStreamWriter As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(strFilePath, False)
        'Write out string:
        objStreamWriter.WriteLine("fridge=" & decDefaults(0) & vbNewLine & _
                                  "TV =" & decDefaults(1) & vbNewLine & _
                                  "SpaceHeater =" & decDefaults(2) & vbNewLine & _
                                  "Fan =" & decDefaults(3) & vbNewLine & _
                                  "Dryer =" & decDefaults(4) & vbNewLine & _
                                  "Oven =" & decDefaults(5) & vbNewLine & _
                                  "DishWasher =" & decDefaults(6) & vbNewLine & _
                                  "WashingMachine =" & decDefaults(7) & vbNewLine & _
                                  "ElectricRate =" & decDefaults(8) & vbNewLine & _
                                  "DishWasherH20 =" & decDefaults(9) & vbNewLine & _
                                  "WashingMachineH20 =" & decDefaults(10) & vbNewLine & _
                                  "WaterRate=" & decDefaults(11))
        objStreamWriter.Close() ' Close writer to prevent flies from getting in
    End Sub

    Private Sub reportWriter(strFilePath As String)
        Dim objStreamWriter As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(strFilePath, False)
        Dim intlineCount As Integer = lbxResult.Items.Count
        Dim DateNow As Date = Today
        objStreamWriter.WriteLine("Application Power Consumption  " & DateNow & vbNewLine & _
                                  "===============================================================")
        For i = 0 To (intlineCount - 1)
            objStreamWriter.WriteLine(lbxResult.Items(i))
        Next
        objStreamWriter.WriteLine("===============================================================")
        objStreamWriter.WriteLine("Total KWh: " & FormatCurrency(tbxGrandTotalKWh.Text) & vbTab & vbTab & "Total Energy Cost: " & FormatCurrency(tbxTotalEnergyCost.Text) & vbNewLine)
        objStreamWriter.WriteLine("Total Gallons: " & FormatCurrency(tbxTotalGallonCost.Text) & vbTab & vbTab & "Total Water Cost: " & FormatCurrency(tbxTotalGallonCost.Text) & vbNewLine)
        Dim dblA As Double = Convert.ToDouble(tbxTotalEnergyCost.Text.Substring(1))
        Dim dblB As Double = Convert.ToDouble(tbxTotalGallonCost.Text.Substring(1))
        Dim dblTotal As Double = (dblA + dblB)
        objStreamWriter.WriteLine("Total Cost:  " & FormatCurrency(dblTotal))
        objStreamWriter.Close()
    End Sub

    Private Sub ClearForm()
        'set all displays and global variables to default values
        tbxHoursOp.Text = "0"
        tbxKWh.Text = "0"
        tbxRate.Text = "0"
        lbxResult.Items.Clear()
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


    Private Sub cbxAppliance_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxAppliance.SelectedIndexChanged
        Dim intIndexNum As Integer = cbxAppliance.SelectedIndex 'create indexnumber
        tbxKWh.Text = decDefaults(intIndexNum) 'items 0 through 7 are appliances
        tbxRate.Text = decDefaults(8) 'item 8 is rate
        If intIndexNum = 6 Then
            FrmWater.tbxGallonsPerHour.Text = decDefaults(9) 'item 9 is GPH for item 6
            FrmWater.tbxPricePerGallon.Text = decDefaults(11) 'item 11 is GPH rate
        ElseIf intIndexNum = 7 Then
            FrmWater.tbxGallonsPerHour.Text = decDefaults(10) 'item 10 is GPH for item 7
            FrmWater.tbxPricePerGallon.Text = decDefaults(11) 'item 11 is GPH rate
        Else
            FrmWater.tbxGallonsPerHour.Text = 0 'if any other index is chosen set water rate to zero
            FrmWater.tbxPricePerGallon.Text = 0 'if any other index is chosen set water price to zero
        End If
    End Sub

    Private Sub LoadDefaultsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadDefaultsToolStripMenuItem.Click
        FileChoser("defaultIn")
    End Sub

    Private Sub SourceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SourceToolStripMenuItem.Click
        Try
            UseWaitCursor = True 'While loading github page turn cursor to waiting... so people know whats up
            Process.Start("https://github.com/Joeordie/POS408EnergyCalc") 'Launch default browser to http://
        Catch en As Exception

        Finally
            UseWaitCursor = False ' when its all done set cursor back to normal!
        End Try

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'this is the about pop up. 
        MessageBox.Show("Author: Jonathan Carroll" & vbNewLine & _
                        "For: POS408, UOP" & vbNewLine & _
                        "Liscence: BSD" & vbNewLine & vbNewLine & "I pity the fool!", "About")
    End Sub

    Private Sub SaveDefaultsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveDefaultsToolStripMenuItem.Click
        frmDefaults.Show() 'load defaults form.  ( i know its a lot of fields. blah blah blah! it is okay for this application. 
        FileChoser("defaultsout")
    End Sub

    'Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
    '    Dim intIndex2 As Integer = lbxResult.SelectedIndex
    '    lbxResult.Items.RemoveAt(intIndex2)
    'End Sub

    Private Sub ExportReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportReportToolStripMenuItem.Click
        FileChoser("report")
    End Sub

    

End Class

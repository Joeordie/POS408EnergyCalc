Public Class FrmWater
    'Global variable that is set by frmCalcMain in AddApplication() function
    Public decOpHrs As Decimal

    Private Sub FrmWater_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxGallonsPerHour.KeyPress, tbxPricePerGallon.KeyPress

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

    Private Sub btnAddWater_Click(sender As Object, e As EventArgs) Handles btnAddWater.Click
        'Send water values and operational 
        FrmMain.AddWater(tbxGallonsPerHour.Text, tbxPricePerGallon.Text, decOpHrs)
        Me.Hide()
    End Sub

    Private Sub btnClearWater_Click(sender As Object, e As EventArgs) Handles btnClearWater.Click
        'Reset form to 0
        tbxGallonsPerHour.Text = "0"
        tbxPricePerGallon.Text = "0"
    End Sub
End Class
Public Class frmDefaults

    
    Private Sub frmDefaults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbxFridge.Text = FrmMain.decDefaults(0)
        tbxTV.Text = FrmMain.decDefaults(1)
        tbxHeater.Text = FrmMain.decDefaults(2)
        tbxFan.Text = FrmMain.decDefaults(3)
        tbxDryer.Text = FrmMain.decDefaults(4)
        tbxOven.Text = FrmMain.decDefaults(5)
        tbxDishWasher.Text = FrmMain.decDefaults(6)
        tbxWasher.Text = FrmMain.decDefaults(7)
        tbxRate.Text = FrmMain.decDefaults(8)
        tbxDishWasher2.Text = FrmMain.decDefaults(9)
        tbxWasher2.Text = FrmMain.decDefaults(10)
        tbxH20Rate.Text = FrmMain.decDefaults(11)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        FrmMain.decDefaults(0) = tbxFridge.Text
        FrmMain.decDefaults(1) = tbxTV.Text
        FrmMain.decDefaults(2) = tbxHeater.Text
        FrmMain.decDefaults(3) = tbxFan.Text
        FrmMain.decDefaults(4) = tbxDryer.Text
        FrmMain.decDefaults(5) = tbxOven.Text
        FrmMain.decDefaults(6) = tbxDishWasher.Text
        FrmMain.decDefaults(7) = tbxWasher.Text
        FrmMain.decDefaults(8) = tbxRate.Text
        FrmMain.decDefaults(9) = tbxDishWasher2.Text
        FrmMain.decDefaults(10) = tbxWasher2.Text
        FrmMain.decDefaults(11) = tbxH20Rate.Text
        FrmMain.FileChoser("defaultOut")
        Me.Close()
    End Sub

    Private Sub tbxFridge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxFridge.KeyPress, tbxTV.KeyPress, tbxHeater.KeyPress, tbxFan.KeyPress, _
        tbxDryer.KeyPress, tbxOven.KeyPress, tbxDishWasher.KeyPress, tbxDishWasher2.KeyPress, tbxWasher.KeyPress, tbxWasher2.KeyPress, tbxRate.KeyPress, tbxH20Rate.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Asc(e.KeyChar) <> 46 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("You should only enter numbers", "Public Service Announcement")
            e.Handled = True
        End If
        'Taken from: http://www.visual-basic-tutorials.com/allow-numbers-only-in-a-text-in-visual-basic.htm#sthash.JZWOwt12.dpuf
    End Sub


End Class
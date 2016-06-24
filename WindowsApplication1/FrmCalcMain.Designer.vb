<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.cbxAppliance = New System.Windows.Forms.ComboBox()
        Me.lblAppliance = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.tbxKWh = New System.Windows.Forms.TextBox()
        Me.lblKWh = New System.Windows.Forms.Label()
        Me.lblHoursOp = New System.Windows.Forms.Label()
        Me.tbxHoursOp = New System.Windows.Forms.TextBox()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.tbxRate = New System.Windows.Forms.TextBox()
        Me.lblGrandTotalKWh = New System.Windows.Forms.Label()
        Me.tbxGrandTotalKWh = New System.Windows.Forms.TextBox()
        Me.lblTotalEnergyCost = New System.Windows.Forms.Label()
        Me.tbxTotalEnergyCost = New System.Windows.Forms.TextBox()
        Me.lblTotalGallons = New System.Windows.Forms.Label()
        Me.tbxTotalGallon = New System.Windows.Forms.TextBox()
        Me.lblTotalWaterCost = New System.Windows.Forms.Label()
        Me.tbxTotalGallonCost = New System.Windows.Forms.TextBox()
        Me.lbxResult = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'cbxAppliance
        '
        Me.cbxAppliance.FormattingEnabled = True
        Me.cbxAppliance.Items.AddRange(New Object() {"Refrigerator", "TV", "Space Heater", "Fan", "Dryer", "Oven", "Dish Washer", "Washing Machine"})
        Me.cbxAppliance.Location = New System.Drawing.Point(120, 25)
        Me.cbxAppliance.Name = "cbxAppliance"
        Me.cbxAppliance.Size = New System.Drawing.Size(297, 21)
        Me.cbxAppliance.TabIndex = 0
        '
        'lblAppliance
        '
        Me.lblAppliance.AutoSize = True
        Me.lblAppliance.Location = New System.Drawing.Point(13, 33)
        Me.lblAppliance.Name = "lblAppliance"
        Me.lblAppliance.Size = New System.Drawing.Size(54, 13)
        Me.lblAppliance.TabIndex = 1
        Me.lblAppliance.Text = "Appliance"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(16, 157)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(120, 157)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'tbxKWh
        '
        Me.tbxKWh.Location = New System.Drawing.Point(16, 89)
        Me.tbxKWh.Name = "tbxKWh"
        Me.tbxKWh.Size = New System.Drawing.Size(75, 20)
        Me.tbxKWh.TabIndex = 5
        Me.tbxKWh.Text = "0"
        '
        'lblKWh
        '
        Me.lblKWh.AutoSize = True
        Me.lblKWh.Location = New System.Drawing.Point(16, 70)
        Me.lblKWh.Name = "lblKWh"
        Me.lblKWh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblKWh.Size = New System.Drawing.Size(25, 13)
        Me.lblKWh.TabIndex = 6
        Me.lblKWh.Text = "KW"
        '
        'lblHoursOp
        '
        Me.lblHoursOp.AutoSize = True
        Me.lblHoursOp.Location = New System.Drawing.Point(117, 70)
        Me.lblHoursOp.Name = "lblHoursOp"
        Me.lblHoursOp.Size = New System.Drawing.Size(64, 13)
        Me.lblHoursOp.TabIndex = 7
        Me.lblHoursOp.Text = "Hours of Op"
        '
        'tbxHoursOp
        '
        Me.tbxHoursOp.Location = New System.Drawing.Point(120, 88)
        Me.tbxHoursOp.Name = "tbxHoursOp"
        Me.tbxHoursOp.Size = New System.Drawing.Size(75, 20)
        Me.tbxHoursOp.TabIndex = 8
        Me.tbxHoursOp.Text = "0"
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Location = New System.Drawing.Point(224, 70)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(30, 13)
        Me.lblRate.TabIndex = 10
        Me.lblRate.Text = "Rate"
        '
        'tbxRate
        '
        Me.tbxRate.Location = New System.Drawing.Point(227, 89)
        Me.tbxRate.Name = "tbxRate"
        Me.tbxRate.Size = New System.Drawing.Size(75, 20)
        Me.tbxRate.TabIndex = 11
        Me.tbxRate.Text = "0"
        '
        'lblGrandTotalKWh
        '
        Me.lblGrandTotalKWh.AutoSize = True
        Me.lblGrandTotalKWh.Location = New System.Drawing.Point(12, 501)
        Me.lblGrandTotalKWh.Name = "lblGrandTotalKWh"
        Me.lblGrandTotalKWh.Size = New System.Drawing.Size(58, 13)
        Me.lblGrandTotalKWh.TabIndex = 13
        Me.lblGrandTotalKWh.Text = "Total KWh"
        '
        'tbxGrandTotalKWh
        '
        Me.tbxGrandTotalKWh.Location = New System.Drawing.Point(91, 501)
        Me.tbxGrandTotalKWh.Name = "tbxGrandTotalKWh"
        Me.tbxGrandTotalKWh.ReadOnly = True
        Me.tbxGrandTotalKWh.Size = New System.Drawing.Size(100, 20)
        Me.tbxGrandTotalKWh.TabIndex = 14
        '
        'lblTotalEnergyCost
        '
        Me.lblTotalEnergyCost.AutoSize = True
        Me.lblTotalEnergyCost.Location = New System.Drawing.Point(224, 501)
        Me.lblTotalEnergyCost.Name = "lblTotalEnergyCost"
        Me.lblTotalEnergyCost.Size = New System.Drawing.Size(91, 13)
        Me.lblTotalEnergyCost.TabIndex = 15
        Me.lblTotalEnergyCost.Text = "Total Energy Cost"
        '
        'tbxTotalEnergyCost
        '
        Me.tbxTotalEnergyCost.Location = New System.Drawing.Point(321, 498)
        Me.tbxTotalEnergyCost.Name = "tbxTotalEnergyCost"
        Me.tbxTotalEnergyCost.ReadOnly = True
        Me.tbxTotalEnergyCost.Size = New System.Drawing.Size(100, 20)
        Me.tbxTotalEnergyCost.TabIndex = 16
        '
        'lblTotalGallons
        '
        Me.lblTotalGallons.AutoSize = True
        Me.lblTotalGallons.Location = New System.Drawing.Point(16, 547)
        Me.lblTotalGallons.Name = "lblTotalGallons"
        Me.lblTotalGallons.Size = New System.Drawing.Size(69, 13)
        Me.lblTotalGallons.TabIndex = 17
        Me.lblTotalGallons.Text = "Total Gallons"
        '
        'tbxTotalGallon
        '
        Me.tbxTotalGallon.Location = New System.Drawing.Point(91, 544)
        Me.tbxTotalGallon.Name = "tbxTotalGallon"
        Me.tbxTotalGallon.ReadOnly = True
        Me.tbxTotalGallon.Size = New System.Drawing.Size(100, 20)
        Me.tbxTotalGallon.TabIndex = 18
        '
        'lblTotalWaterCost
        '
        Me.lblTotalWaterCost.AutoSize = True
        Me.lblTotalWaterCost.Location = New System.Drawing.Point(227, 547)
        Me.lblTotalWaterCost.Name = "lblTotalWaterCost"
        Me.lblTotalWaterCost.Size = New System.Drawing.Size(87, 13)
        Me.lblTotalWaterCost.TabIndex = 19
        Me.lblTotalWaterCost.Text = "Total Water Cost"
        '
        'tbxTotalGallonCost
        '
        Me.tbxTotalGallonCost.Location = New System.Drawing.Point(321, 544)
        Me.tbxTotalGallonCost.Name = "tbxTotalGallonCost"
        Me.tbxTotalGallonCost.ReadOnly = True
        Me.tbxTotalGallonCost.Size = New System.Drawing.Size(100, 20)
        Me.tbxTotalGallonCost.TabIndex = 20
        '
        'lbxResult
        '
        Me.lbxResult.FormattingEnabled = True
        Me.lbxResult.Location = New System.Drawing.Point(16, 196)
        Me.lbxResult.Name = "lbxResult"
        Me.lbxResult.Size = New System.Drawing.Size(475, 277)
        Me.lbxResult.TabIndex = 21
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(503, 604)
        Me.Controls.Add(Me.lbxResult)
        Me.Controls.Add(Me.tbxTotalGallonCost)
        Me.Controls.Add(Me.lblTotalWaterCost)
        Me.Controls.Add(Me.tbxTotalGallon)
        Me.Controls.Add(Me.lblTotalGallons)
        Me.Controls.Add(Me.tbxTotalEnergyCost)
        Me.Controls.Add(Me.lblTotalEnergyCost)
        Me.Controls.Add(Me.tbxGrandTotalKWh)
        Me.Controls.Add(Me.lblGrandTotalKWh)
        Me.Controls.Add(Me.tbxRate)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.tbxHoursOp)
        Me.Controls.Add(Me.lblHoursOp)
        Me.Controls.Add(Me.lblKWh)
        Me.Controls.Add(Me.tbxKWh)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblAppliance)
        Me.Controls.Add(Me.cbxAppliance)
        Me.Name = "FrmMain"
        Me.Text = "Energy Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxAppliance As System.Windows.Forms.ComboBox
    Friend WithEvents lblAppliance As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents tbxKWh As System.Windows.Forms.TextBox
    Friend WithEvents lblKWh As System.Windows.Forms.Label
    Friend WithEvents lblHoursOp As System.Windows.Forms.Label
    Friend WithEvents tbxHoursOp As System.Windows.Forms.TextBox
    Friend WithEvents lblRate As System.Windows.Forms.Label
    Friend WithEvents tbxRate As System.Windows.Forms.TextBox
    Friend WithEvents lblGrandTotalKWh As System.Windows.Forms.Label
    Friend WithEvents tbxGrandTotalKWh As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalEnergyCost As System.Windows.Forms.Label
    Friend WithEvents tbxTotalEnergyCost As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalGallons As System.Windows.Forms.Label
    Friend WithEvents tbxTotalGallon As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalWaterCost As System.Windows.Forms.Label
    Friend WithEvents tbxTotalGallonCost As System.Windows.Forms.TextBox
    Friend WithEvents lbxResult As System.Windows.Forms.ListBox

End Class

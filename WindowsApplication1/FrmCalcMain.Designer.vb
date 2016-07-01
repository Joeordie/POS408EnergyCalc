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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadDefaultsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveDefaultsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SourceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbxAppliance
        '
        Me.cbxAppliance.FormattingEnabled = True
        Me.cbxAppliance.Items.AddRange(New Object() {"Refrigerator", "TV", "Space Heater", "Fan", "Dryer", "Oven", "Dish Washer", "Washing Machine"})
        Me.cbxAppliance.Location = New System.Drawing.Point(120, 33)
        Me.cbxAppliance.Name = "cbxAppliance"
        Me.cbxAppliance.Size = New System.Drawing.Size(297, 21)
        Me.cbxAppliance.TabIndex = 0
        '
        'lblAppliance
        '
        Me.lblAppliance.AutoSize = True
        Me.lblAppliance.Location = New System.Drawing.Point(12, 36)
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
        Me.btnClear.Location = New System.Drawing.Point(106, 157)
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
        Me.lbxResult.Size = New System.Drawing.Size(410, 264)
        Me.lbxResult.TabIndex = 21
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(445, 24)
        Me.MenuStrip1.TabIndex = 22
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadDefaultsToolStripMenuItem, Me.SaveDefaultsToolStripMenuItem, Me.ExportReportToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LoadDefaultsToolStripMenuItem
        '
        Me.LoadDefaultsToolStripMenuItem.Name = "LoadDefaultsToolStripMenuItem"
        Me.LoadDefaultsToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.LoadDefaultsToolStripMenuItem.Text = "Load Defaults"
        '
        'SaveDefaultsToolStripMenuItem
        '
        Me.SaveDefaultsToolStripMenuItem.Name = "SaveDefaultsToolStripMenuItem"
        Me.SaveDefaultsToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.SaveDefaultsToolStripMenuItem.Text = "Save Defaults"
        '
        'ExportReportToolStripMenuItem
        '
        Me.ExportReportToolStripMenuItem.Name = "ExportReportToolStripMenuItem"
        Me.ExportReportToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExportReportToolStripMenuItem.Text = "Export Report"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SourceToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'SourceToolStripMenuItem
        '
        Me.SourceToolStripMenuItem.Name = "SourceToolStripMenuItem"
        Me.SourceToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.SourceToolStripMenuItem.Text = "Source"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(196, 157)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 23
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        Me.btnRemove.Visible = False
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(445, 585)
        Me.Controls.Add(Me.btnRemove)
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
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMain"
        Me.Text = "Energy Calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
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
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadDefaultsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveDefaultsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SourceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnRemove As System.Windows.Forms.Button

End Class

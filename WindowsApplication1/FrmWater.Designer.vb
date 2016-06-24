<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWater
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbxGallonsPerHour = New System.Windows.Forms.TextBox()
        Me.lblPricePerGallon = New System.Windows.Forms.Label()
        Me.tbxPricePerGallon = New System.Windows.Forms.TextBox()
        Me.btnAddWater = New System.Windows.Forms.Button()
        Me.btnClearWater = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gallons Per Hour"
        '
        'tbxGallonsPerHour
        '
        Me.tbxGallonsPerHour.Location = New System.Drawing.Point(129, 29)
        Me.tbxGallonsPerHour.Name = "tbxGallonsPerHour"
        Me.tbxGallonsPerHour.Size = New System.Drawing.Size(100, 20)
        Me.tbxGallonsPerHour.TabIndex = 1
        Me.tbxGallonsPerHour.Text = "0"
        '
        'lblPricePerGallon
        '
        Me.lblPricePerGallon.AutoSize = True
        Me.lblPricePerGallon.Location = New System.Drawing.Point(12, 94)
        Me.lblPricePerGallon.Name = "lblPricePerGallon"
        Me.lblPricePerGallon.Size = New System.Drawing.Size(83, 13)
        Me.lblPricePerGallon.TabIndex = 2
        Me.lblPricePerGallon.Text = "Price Per Gallon"
        '
        'tbxPricePerGallon
        '
        Me.tbxPricePerGallon.Location = New System.Drawing.Point(129, 91)
        Me.tbxPricePerGallon.Name = "tbxPricePerGallon"
        Me.tbxPricePerGallon.Size = New System.Drawing.Size(100, 20)
        Me.tbxPricePerGallon.TabIndex = 3
        Me.tbxPricePerGallon.Text = "0"
        '
        'btnAddWater
        '
        Me.btnAddWater.Location = New System.Drawing.Point(15, 149)
        Me.btnAddWater.Name = "btnAddWater"
        Me.btnAddWater.Size = New System.Drawing.Size(75, 23)
        Me.btnAddWater.TabIndex = 4
        Me.btnAddWater.Text = "Add"
        Me.btnAddWater.UseVisualStyleBackColor = True
        '
        'btnClearWater
        '
        Me.btnClearWater.Location = New System.Drawing.Point(154, 149)
        Me.btnClearWater.Name = "btnClearWater"
        Me.btnClearWater.Size = New System.Drawing.Size(75, 23)
        Me.btnClearWater.TabIndex = 5
        Me.btnClearWater.Text = "Clear"
        Me.btnClearWater.UseVisualStyleBackColor = True
        '
        'FrmWater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(253, 192)
        Me.Controls.Add(Me.btnClearWater)
        Me.Controls.Add(Me.btnAddWater)
        Me.Controls.Add(Me.tbxPricePerGallon)
        Me.Controls.Add(Me.lblPricePerGallon)
        Me.Controls.Add(Me.tbxGallonsPerHour)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmWater"
        Me.Text = "Water Consumption"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbxGallonsPerHour As System.Windows.Forms.TextBox
    Friend WithEvents lblPricePerGallon As System.Windows.Forms.Label
    Friend WithEvents tbxPricePerGallon As System.Windows.Forms.TextBox
    Friend WithEvents btnAddWater As System.Windows.Forms.Button
    Friend WithEvents btnClearWater As System.Windows.Forms.Button
End Class

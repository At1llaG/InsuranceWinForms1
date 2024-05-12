<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vehicles
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
        Me.DataGridViewVehicles = New System.Windows.Forms.DataGridView()
        Me.btnAddVehicle = New System.Windows.Forms.Button()
        Me.btnEditVehicle = New System.Windows.Forms.Button()
        CType(Me.DataGridViewVehicles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewVehicles
        '
        Me.DataGridViewVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewVehicles.Location = New System.Drawing.Point(12, 12)
        Me.DataGridViewVehicles.Name = "DataGridViewVehicles"
        Me.DataGridViewVehicles.Size = New System.Drawing.Size(776, 354)
        Me.DataGridViewVehicles.TabIndex = 0
        '
        'btnAddVehicle
        '
        Me.btnAddVehicle.Location = New System.Drawing.Point(44, 393)
        Me.btnAddVehicle.Name = "btnAddVehicle"
        Me.btnAddVehicle.Size = New System.Drawing.Size(110, 23)
        Me.btnAddVehicle.TabIndex = 4
        Me.btnAddVehicle.Text = "Add Vehicle"
        Me.btnAddVehicle.UseVisualStyleBackColor = True
        '
        'btnEditVehicle
        '
        Me.btnEditVehicle.Location = New System.Drawing.Point(160, 393)
        Me.btnEditVehicle.Name = "btnEditVehicle"
        Me.btnEditVehicle.Size = New System.Drawing.Size(100, 23)
        Me.btnEditVehicle.TabIndex = 3
        Me.btnEditVehicle.Text = "Edit Vehicle"
        Me.btnEditVehicle.UseVisualStyleBackColor = True
        '
        'Vehicles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAddVehicle)
        Me.Controls.Add(Me.btnEditVehicle)
        Me.Controls.Add(Me.DataGridViewVehicles)
        Me.Name = "Vehicles"
        Me.Text = "Vehicles"
        CType(Me.DataGridViewVehicles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewVehicles As DataGridView
    Friend WithEvents btnAddVehicle As Button
    Friend WithEvents btnEditVehicle As Button
End Class

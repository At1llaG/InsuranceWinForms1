<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Drivers
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
        Me.DataGridViewDrivers = New System.Windows.Forms.DataGridView()
        Me.btnEditDriver = New System.Windows.Forms.Button()
        Me.btnAddDriver = New System.Windows.Forms.Button()
        CType(Me.DataGridViewDrivers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewDrivers
        '
        Me.DataGridViewDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDrivers.Location = New System.Drawing.Point(12, 12)
        Me.DataGridViewDrivers.Name = "DataGridViewDrivers"
        Me.DataGridViewDrivers.Size = New System.Drawing.Size(566, 300)
        Me.DataGridViewDrivers.TabIndex = 0
        '
        'btnEditDriver
        '
        Me.btnEditDriver.Location = New System.Drawing.Point(142, 400)
        Me.btnEditDriver.Name = "btnEditDriver"
        Me.btnEditDriver.Size = New System.Drawing.Size(75, 23)
        Me.btnEditDriver.TabIndex = 11
        Me.btnEditDriver.Text = "Edit"
        Me.btnEditDriver.UseVisualStyleBackColor = True
        '
        'btnAddDriver
        '
        Me.btnAddDriver.Location = New System.Drawing.Point(35, 400)
        Me.btnAddDriver.Name = "btnAddDriver"
        Me.btnAddDriver.Size = New System.Drawing.Size(75, 23)
        Me.btnAddDriver.TabIndex = 10
        Me.btnAddDriver.Text = "Add"
        Me.btnAddDriver.UseVisualStyleBackColor = True
        '
        'Drivers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnEditDriver)
        Me.Controls.Add(Me.btnAddDriver)
        Me.Controls.Add(Me.DataGridViewDrivers)
        Me.Name = "Drivers"
        Me.Text = "Drivers"
        CType(Me.DataGridViewDrivers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewDrivers As DataGridView
    Friend WithEvents btnEditDriver As Button
    Friend WithEvents btnAddDriver As Button
End Class

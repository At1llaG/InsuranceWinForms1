<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Customers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridViewCustomers = New System.Windows.Forms.DataGridView()
        Me.btnEditCustomer = New System.Windows.Forms.Button()
        Me.btnAddCustomer = New System.Windows.Forms.Button()
        CType(Me.DataGridViewCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewCustomers
        '
        Me.DataGridViewCustomers.AllowUserToAddRows = False
        Me.DataGridViewCustomers.AllowUserToDeleteRows = False
        Me.DataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCustomers.Location = New System.Drawing.Point(12, 12)
        Me.DataGridViewCustomers.Name = "DataGridViewCustomers"
        Me.DataGridViewCustomers.ReadOnly = True
        Me.DataGridViewCustomers.Size = New System.Drawing.Size(776, 342)
        Me.DataGridViewCustomers.TabIndex = 0
        '
        'btnEditCustomer
        '
        Me.btnEditCustomer.Location = New System.Drawing.Point(139, 381)
        Me.btnEditCustomer.Name = "btnEditCustomer"
        Me.btnEditCustomer.Size = New System.Drawing.Size(100, 23)
        Me.btnEditCustomer.TabIndex = 1
        Me.btnEditCustomer.Text = "Edit Customer"
        Me.btnEditCustomer.UseVisualStyleBackColor = True
        '
        'btnAddCustomer
        '
        Me.btnAddCustomer.Location = New System.Drawing.Point(23, 381)
        Me.btnAddCustomer.Name = "btnAddCustomer"
        Me.btnAddCustomer.Size = New System.Drawing.Size(110, 23)
        Me.btnAddCustomer.TabIndex = 2
        Me.btnAddCustomer.Text = "Add Customer"
        Me.btnAddCustomer.UseVisualStyleBackColor = True
        '
        'Customers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAddCustomer)
        Me.Controls.Add(Me.btnEditCustomer)
        Me.Controls.Add(Me.DataGridViewCustomers)
        Me.Name = "Customers"
        Me.Text = "Customers"
        CType(Me.DataGridViewCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewCustomers As DataGridView
    Friend WithEvents btnEditCustomer As Button
    Friend WithEvents btnAddCustomer As Button
End Class

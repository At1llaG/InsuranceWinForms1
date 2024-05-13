<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Policies
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
        Me.btnEditPolicy = New System.Windows.Forms.Button()
        Me.btnAddPolicy = New System.Windows.Forms.Button()
        Me.DataGridViewPolicies = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridViewPolicies, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEditPolicy
        '
        Me.btnEditPolicy.Location = New System.Drawing.Point(119, 399)
        Me.btnEditPolicy.Name = "btnEditPolicy"
        Me.btnEditPolicy.Size = New System.Drawing.Size(75, 23)
        Me.btnEditPolicy.TabIndex = 9
        Me.btnEditPolicy.Text = "Edit"
        Me.btnEditPolicy.UseVisualStyleBackColor = True
        '
        'btnAddPolicy
        '
        Me.btnAddPolicy.Location = New System.Drawing.Point(12, 399)
        Me.btnAddPolicy.Name = "btnAddPolicy"
        Me.btnAddPolicy.Size = New System.Drawing.Size(75, 23)
        Me.btnAddPolicy.TabIndex = 8
        Me.btnAddPolicy.Text = "Add"
        Me.btnAddPolicy.UseVisualStyleBackColor = True
        '
        'DataGridViewPolicies
        '
        Me.DataGridViewPolicies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPolicies.Location = New System.Drawing.Point(12, 29)
        Me.DataGridViewPolicies.Name = "DataGridViewPolicies"
        Me.DataGridViewPolicies.Size = New System.Drawing.Size(776, 336)
        Me.DataGridViewPolicies.TabIndex = 7
        '
        'Policies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnEditPolicy)
        Me.Controls.Add(Me.btnAddPolicy)
        Me.Controls.Add(Me.DataGridViewPolicies)
        Me.Name = "Policies"
        Me.Text = "Policies"
        CType(Me.DataGridViewPolicies, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEditPolicy As Button
    Friend WithEvents btnAddPolicy As Button
    Friend WithEvents DataGridViewPolicies As DataGridView
End Class

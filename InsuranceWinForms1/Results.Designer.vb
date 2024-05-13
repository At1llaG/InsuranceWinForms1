<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Results
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
        Me.btnAddResult = New System.Windows.Forms.Button()
        Me.btnEditResult = New System.Windows.Forms.Button()
        Me.DataGridViewResults = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridViewResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAddResult
        '
        Me.btnAddResult.Location = New System.Drawing.Point(23, 398)
        Me.btnAddResult.Name = "btnAddResult"
        Me.btnAddResult.Size = New System.Drawing.Size(110, 23)
        Me.btnAddResult.TabIndex = 5
        Me.btnAddResult.Text = "Add Result"
        Me.btnAddResult.UseVisualStyleBackColor = True
        '
        'btnEditResult
        '
        Me.btnEditResult.Location = New System.Drawing.Point(139, 398)
        Me.btnEditResult.Name = "btnEditResult"
        Me.btnEditResult.Size = New System.Drawing.Size(100, 23)
        Me.btnEditResult.TabIndex = 4
        Me.btnEditResult.Text = "Edit Result"
        Me.btnEditResult.UseVisualStyleBackColor = True
        '
        'DataGridViewResults
        '
        Me.DataGridViewResults.AllowUserToAddRows = False
        Me.DataGridViewResults.AllowUserToDeleteRows = False
        Me.DataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewResults.Location = New System.Drawing.Point(12, 29)
        Me.DataGridViewResults.Name = "DataGridViewResults"
        Me.DataGridViewResults.ReadOnly = True
        Me.DataGridViewResults.Size = New System.Drawing.Size(776, 342)
        Me.DataGridViewResults.TabIndex = 3
        '
        'Results
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAddResult)
        Me.Controls.Add(Me.btnEditResult)
        Me.Controls.Add(Me.DataGridViewResults)
        Me.Name = "Results"
        Me.Text = "Results"
        CType(Me.DataGridViewResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddResult As Button
    Friend WithEvents btnEditResult As Button
    Friend WithEvents DataGridViewResults As DataGridView
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reports
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
        Me.DataGridViewReports = New System.Windows.Forms.DataGridView()
        Me.btnEditReport = New System.Windows.Forms.Button()
        Me.btnAddReport = New System.Windows.Forms.Button()
        CType(Me.DataGridViewReports, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewReports
        '
        Me.DataGridViewReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewReports.Location = New System.Drawing.Point(12, 12)
        Me.DataGridViewReports.Name = "DataGridViewReports"
        Me.DataGridViewReports.Size = New System.Drawing.Size(594, 305)
        Me.DataGridViewReports.TabIndex = 0
        '
        'btnEditReport
        '
        Me.btnEditReport.Location = New System.Drawing.Point(147, 376)
        Me.btnEditReport.Name = "btnEditReport"
        Me.btnEditReport.Size = New System.Drawing.Size(75, 23)
        Me.btnEditReport.TabIndex = 13
        Me.btnEditReport.Text = "Edit"
        Me.btnEditReport.UseVisualStyleBackColor = True
        '
        'btnAddReport
        '
        Me.btnAddReport.Location = New System.Drawing.Point(40, 376)
        Me.btnAddReport.Name = "btnAddReport"
        Me.btnAddReport.Size = New System.Drawing.Size(75, 23)
        Me.btnAddReport.TabIndex = 12
        Me.btnAddReport.Text = "Add"
        Me.btnAddReport.UseVisualStyleBackColor = True
        '
        'Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnEditReport)
        Me.Controls.Add(Me.btnAddReport)
        Me.Controls.Add(Me.DataGridViewReports)
        Me.Name = "Reports"
        Me.Text = "Report"
        CType(Me.DataGridViewReports, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewReports As DataGridView
    Friend WithEvents btnEditReport As Button
    Friend WithEvents btnAddReport As Button
End Class

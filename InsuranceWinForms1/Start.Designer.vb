<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Start
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
        Me.btnCustomers = New System.Windows.Forms.Button()
        Me.btnVehicles = New System.Windows.Forms.Button()
        Me.btnPolicies = New System.Windows.Forms.Button()
        Me.btnDisputes = New System.Windows.Forms.Button()
        Me.btnClaims = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnResults = New System.Windows.Forms.Button()
        Me.btnDrivers = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotalClaims = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCustomers
        '
        Me.btnCustomers.Location = New System.Drawing.Point(82, 42)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Size = New System.Drawing.Size(75, 23)
        Me.btnCustomers.TabIndex = 0
        Me.btnCustomers.Text = "Customers"
        Me.btnCustomers.UseVisualStyleBackColor = True
        '
        'btnVehicles
        '
        Me.btnVehicles.Location = New System.Drawing.Point(82, 90)
        Me.btnVehicles.Name = "btnVehicles"
        Me.btnVehicles.Size = New System.Drawing.Size(75, 23)
        Me.btnVehicles.TabIndex = 1
        Me.btnVehicles.Text = "Vehicles"
        Me.btnVehicles.UseVisualStyleBackColor = True
        '
        'btnPolicies
        '
        Me.btnPolicies.Location = New System.Drawing.Point(82, 162)
        Me.btnPolicies.Name = "btnPolicies"
        Me.btnPolicies.Size = New System.Drawing.Size(75, 23)
        Me.btnPolicies.TabIndex = 2
        Me.btnPolicies.Text = "Policies"
        Me.btnPolicies.UseVisualStyleBackColor = True
        '
        'btnDisputes
        '
        Me.btnDisputes.Location = New System.Drawing.Point(82, 272)
        Me.btnDisputes.Name = "btnDisputes"
        Me.btnDisputes.Size = New System.Drawing.Size(75, 23)
        Me.btnDisputes.TabIndex = 3
        Me.btnDisputes.Text = "Disputes"
        Me.btnDisputes.UseVisualStyleBackColor = True
        '
        'btnClaims
        '
        Me.btnClaims.Location = New System.Drawing.Point(82, 380)
        Me.btnClaims.Name = "btnClaims"
        Me.btnClaims.Size = New System.Drawing.Size(75, 23)
        Me.btnClaims.TabIndex = 4
        Me.btnClaims.Text = "Claims"
        Me.btnClaims.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.Location = New System.Drawing.Point(82, 219)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(75, 23)
        Me.btnReports.TabIndex = 5
        Me.btnReports.Text = "Reports"
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'btnResults
        '
        Me.btnResults.Location = New System.Drawing.Point(82, 325)
        Me.btnResults.Name = "btnResults"
        Me.btnResults.Size = New System.Drawing.Size(75, 23)
        Me.btnResults.TabIndex = 6
        Me.btnResults.Text = "Results"
        Me.btnResults.UseVisualStyleBackColor = True
        '
        'btnDrivers
        '
        Me.btnDrivers.Location = New System.Drawing.Point(82, 119)
        Me.btnDrivers.Name = "btnDrivers"
        Me.btnDrivers.Size = New System.Drawing.Size(75, 23)
        Me.btnDrivers.TabIndex = 7
        Me.btnDrivers.Text = "Drivers"
        Me.btnDrivers.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(610, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Total Claims in $"
        '
        'lblTotalClaims
        '
        Me.lblTotalClaims.AutoSize = True
        Me.lblTotalClaims.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalClaims.Location = New System.Drawing.Point(619, 80)
        Me.lblTotalClaims.Name = "lblTotalClaims"
        Me.lblTotalClaims.Size = New System.Drawing.Size(51, 31)
        Me.lblTotalClaims.TabIndex = 9
        Me.lblTotalClaims.Text = "0 $"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(621, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Last Reports :"
        '
        'Start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 467)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTotalClaims)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDrivers)
        Me.Controls.Add(Me.btnResults)
        Me.Controls.Add(Me.btnReports)
        Me.Controls.Add(Me.btnClaims)
        Me.Controls.Add(Me.btnDisputes)
        Me.Controls.Add(Me.btnPolicies)
        Me.Controls.Add(Me.btnVehicles)
        Me.Controls.Add(Me.btnCustomers)
        Me.Name = "Start"
        Me.Text = "Start"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCustomers As Button
    Friend WithEvents btnVehicles As Button
    Friend WithEvents btnPolicies As Button
    Friend WithEvents btnDisputes As Button
    Friend WithEvents btnClaims As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnResults As Button
    Friend WithEvents btnDrivers As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotalClaims As Label
    Friend WithEvents Label2 As Label
End Class

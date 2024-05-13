<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditPolicy
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPolicyId = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCustomerId = New System.Windows.Forms.TextBox()
        Me.txtVehicleId = New System.Windows.Forms.TextBox()
        Me.txtPolicyType = New System.Windows.Forms.TextBox()
        Me.txtPremium = New System.Windows.Forms.TextBox()
        Me.btnDeletePolicy = New System.Windows.Forms.Button()
        Me.btnUpdatePolicy = New System.Windows.Forms.Button()
        Me.btnAddPolicy = New System.Windows.Forms.Button()
        Me.dtStartDate = New System.Windows.Forms.DateTimePicker()
        Me.dtEndDate = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(134, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Policy Id :"
        '
        'lblPolicyId
        '
        Me.lblPolicyId.AutoSize = True
        Me.lblPolicyId.Location = New System.Drawing.Point(92, 55)
        Me.lblPolicyId.Name = "lblPolicyId"
        Me.lblPolicyId.Size = New System.Drawing.Size(27, 13)
        Me.lblPolicyId.TabIndex = 2
        Me.lblPolicyId.Text = "N/A"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Customer Id :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Vehicle Id :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Policy Type :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 185)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Start Date :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(33, 214)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "End Date :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 240)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Premium :"
        '
        'txtCustomerId
        '
        Me.txtCustomerId.Location = New System.Drawing.Point(95, 91)
        Me.txtCustomerId.Name = "txtCustomerId"
        Me.txtCustomerId.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomerId.TabIndex = 9
        '
        'txtVehicleId
        '
        Me.txtVehicleId.Location = New System.Drawing.Point(95, 116)
        Me.txtVehicleId.Name = "txtVehicleId"
        Me.txtVehicleId.Size = New System.Drawing.Size(100, 20)
        Me.txtVehicleId.TabIndex = 10
        '
        'txtPolicyType
        '
        Me.txtPolicyType.Location = New System.Drawing.Point(95, 152)
        Me.txtPolicyType.Name = "txtPolicyType"
        Me.txtPolicyType.Size = New System.Drawing.Size(100, 20)
        Me.txtPolicyType.TabIndex = 11
        '
        'txtPremium
        '
        Me.txtPremium.Location = New System.Drawing.Point(100, 240)
        Me.txtPremium.Name = "txtPremium"
        Me.txtPremium.Size = New System.Drawing.Size(100, 20)
        Me.txtPremium.TabIndex = 14
        '
        'btnDeletePolicy
        '
        Me.btnDeletePolicy.Location = New System.Drawing.Point(252, 347)
        Me.btnDeletePolicy.Name = "btnDeletePolicy"
        Me.btnDeletePolicy.Size = New System.Drawing.Size(75, 23)
        Me.btnDeletePolicy.TabIndex = 17
        Me.btnDeletePolicy.Text = "Delete"
        Me.btnDeletePolicy.UseVisualStyleBackColor = True
        '
        'btnUpdatePolicy
        '
        Me.btnUpdatePolicy.Location = New System.Drawing.Point(143, 347)
        Me.btnUpdatePolicy.Name = "btnUpdatePolicy"
        Me.btnUpdatePolicy.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdatePolicy.TabIndex = 16
        Me.btnUpdatePolicy.Text = "Update"
        Me.btnUpdatePolicy.UseVisualStyleBackColor = True
        '
        'btnAddPolicy
        '
        Me.btnAddPolicy.Location = New System.Drawing.Point(36, 347)
        Me.btnAddPolicy.Name = "btnAddPolicy"
        Me.btnAddPolicy.Size = New System.Drawing.Size(75, 23)
        Me.btnAddPolicy.TabIndex = 15
        Me.btnAddPolicy.Text = "Add"
        Me.btnAddPolicy.UseVisualStyleBackColor = True
        '
        'dtStartDate
        '
        Me.dtStartDate.Location = New System.Drawing.Point(100, 185)
        Me.dtStartDate.Name = "dtStartDate"
        Me.dtStartDate.Size = New System.Drawing.Size(200, 20)
        Me.dtStartDate.TabIndex = 18
        '
        'dtEndDate
        '
        Me.dtEndDate.Location = New System.Drawing.Point(100, 214)
        Me.dtEndDate.Name = "dtEndDate"
        Me.dtEndDate.Size = New System.Drawing.Size(200, 20)
        Me.dtEndDate.TabIndex = 19
        '
        'EditPolicy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dtEndDate)
        Me.Controls.Add(Me.dtStartDate)
        Me.Controls.Add(Me.btnDeletePolicy)
        Me.Controls.Add(Me.btnUpdatePolicy)
        Me.Controls.Add(Me.btnAddPolicy)
        Me.Controls.Add(Me.txtPremium)
        Me.Controls.Add(Me.txtPolicyType)
        Me.Controls.Add(Me.txtVehicleId)
        Me.Controls.Add(Me.txtCustomerId)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblPolicyId)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EditPolicy"
        Me.Text = "EditPolicies"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPolicyId As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCustomerId As TextBox
    Friend WithEvents txtVehicleId As TextBox
    Friend WithEvents txtPolicyType As TextBox
    Friend WithEvents txtPremium As TextBox
    Friend WithEvents btnDeletePolicy As Button
    Friend WithEvents btnUpdatePolicy As Button
    Friend WithEvents btnAddPolicy As Button
    Friend WithEvents dtStartDate As DateTimePicker
    Friend WithEvents dtEndDate As DateTimePicker
End Class

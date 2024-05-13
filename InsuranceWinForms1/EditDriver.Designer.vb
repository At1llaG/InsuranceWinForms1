<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditDriver
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
        Me.btnDeleteDriver = New System.Windows.Forms.Button()
        Me.btnUpdateDriver = New System.Windows.Forms.Button()
        Me.btnAddDriver = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtIdentityNumber = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtLicenseClass = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtLicenseNumber = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtLicenseIssuedBy = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.RichTextBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblDriverId = New System.Windows.Forms.Label()
        Me.dtDateOfBirth = New System.Windows.Forms.DateTimePicker()
        Me.dtLicenseIssuanceDate = New System.Windows.Forms.DateTimePicker()
        Me.dtLicenseValidUntilDate = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'btnDeleteDriver
        '
        Me.btnDeleteDriver.Location = New System.Drawing.Point(240, 490)
        Me.btnDeleteDriver.Name = "btnDeleteDriver"
        Me.btnDeleteDriver.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteDriver.TabIndex = 10
        Me.btnDeleteDriver.Text = "Delete"
        Me.btnDeleteDriver.UseVisualStyleBackColor = True
        '
        'btnUpdateDriver
        '
        Me.btnUpdateDriver.Location = New System.Drawing.Point(131, 490)
        Me.btnUpdateDriver.Name = "btnUpdateDriver"
        Me.btnUpdateDriver.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateDriver.TabIndex = 9
        Me.btnUpdateDriver.Text = "Update"
        Me.btnUpdateDriver.UseVisualStyleBackColor = True
        '
        'btnAddDriver
        '
        Me.btnAddDriver.Location = New System.Drawing.Point(24, 490)
        Me.btnAddDriver.Name = "btnAddDriver"
        Me.btnAddDriver.Size = New System.Drawing.Size(75, 23)
        Me.btnAddDriver.TabIndex = 8
        Me.btnAddDriver.Text = "Add"
        Me.btnAddDriver.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(194, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Driver Information"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Surname :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Identity No :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 282)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "License Class :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 334)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Issued By :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 375)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Address :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 431)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Phone No :"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(84, 80)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 19
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(93, 109)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 20
        '
        'txtIdentityNumber
        '
        Me.txtIdentityNumber.Location = New System.Drawing.Point(95, 142)
        Me.txtIdentityNumber.Name = "txtIdentityNumber"
        Me.txtIdentityNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtIdentityNumber.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 304)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "License No :"
        '
        'txtLicenseClass
        '
        Me.txtLicenseClass.Location = New System.Drawing.Point(106, 279)
        Me.txtLicenseClass.Name = "txtLicenseClass"
        Me.txtLicenseClass.Size = New System.Drawing.Size(100, 20)
        Me.txtLicenseClass.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(26, 220)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "License Issuance Date :"
        '
        'txtLicenseNumber
        '
        Me.txtLicenseNumber.Location = New System.Drawing.Point(106, 305)
        Me.txtLicenseNumber.Name = "txtLicenseNumber"
        Me.txtLicenseNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtLicenseNumber.TabIndex = 29
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(27, 248)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(126, 13)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "License Valid Until Date :"
        '
        'txtLicenseIssuedBy
        '
        Me.txtLicenseIssuedBy.Location = New System.Drawing.Point(96, 331)
        Me.txtLicenseIssuedBy.Name = "txtLicenseIssuedBy"
        Me.txtLicenseIssuedBy.Size = New System.Drawing.Size(100, 20)
        Me.txtLicenseIssuedBy.TabIndex = 31
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(28, 172)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 13)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Date of Birth :"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(94, 372)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(262, 46)
        Me.txtAddress.TabIndex = 34
        Me.txtAddress.Text = ""
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(108, 431)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtPhoneNumber.TabIndex = 35
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(26, 50)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 13)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Driver Id :"
        '
        'lblDriverId
        '
        Me.lblDriverId.AutoSize = True
        Me.lblDriverId.Location = New System.Drawing.Point(96, 50)
        Me.lblDriverId.Name = "lblDriverId"
        Me.lblDriverId.Size = New System.Drawing.Size(27, 13)
        Me.lblDriverId.TabIndex = 37
        Me.lblDriverId.Text = "N/A"
        '
        'dtDateOfBirth
        '
        Me.dtDateOfBirth.Location = New System.Drawing.Point(122, 172)
        Me.dtDateOfBirth.Name = "dtDateOfBirth"
        Me.dtDateOfBirth.Size = New System.Drawing.Size(200, 20)
        Me.dtDateOfBirth.TabIndex = 38
        '
        'dtLicenseIssuanceDate
        '
        Me.dtLicenseIssuanceDate.Location = New System.Drawing.Point(156, 213)
        Me.dtLicenseIssuanceDate.Name = "dtLicenseIssuanceDate"
        Me.dtLicenseIssuanceDate.Size = New System.Drawing.Size(200, 20)
        Me.dtLicenseIssuanceDate.TabIndex = 39
        '
        'dtLicenseValidUntilDate
        '
        Me.dtLicenseValidUntilDate.Location = New System.Drawing.Point(159, 242)
        Me.dtLicenseValidUntilDate.Name = "dtLicenseValidUntilDate"
        Me.dtLicenseValidUntilDate.Size = New System.Drawing.Size(200, 20)
        Me.dtLicenseValidUntilDate.TabIndex = 40
        '
        'EditDriver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 560)
        Me.Controls.Add(Me.dtLicenseValidUntilDate)
        Me.Controls.Add(Me.dtLicenseIssuanceDate)
        Me.Controls.Add(Me.dtDateOfBirth)
        Me.Controls.Add(Me.lblDriverId)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtLicenseIssuedBy)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtLicenseNumber)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtLicenseClass)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtIdentityNumber)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDeleteDriver)
        Me.Controls.Add(Me.btnUpdateDriver)
        Me.Controls.Add(Me.btnAddDriver)
        Me.Name = "EditDriver"
        Me.Text = "Drivers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDeleteDriver As Button
    Friend WithEvents btnUpdateDriver As Button
    Friend WithEvents btnAddDriver As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtIdentityNumber As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtLicenseClass As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtLicenseNumber As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtLicenseIssuedBy As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtAddress As RichTextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents lblDriverId As Label
    Friend WithEvents dtDateOfBirth As DateTimePicker
    Friend WithEvents dtLicenseIssuanceDate As DateTimePicker
    Friend WithEvents dtLicenseValidUntilDate As DateTimePicker
End Class

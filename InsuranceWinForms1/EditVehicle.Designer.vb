<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditVehicle
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
        Me.btnDeleteVehicle = New System.Windows.Forms.Button()
        Me.btnUpdateVehicle = New System.Windows.Forms.Button()
        Me.btnAddVehicle = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.txtMake = New System.Windows.Forms.TextBox()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblVehicleId = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.txtRegistrationNumber = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnDeleteVehicle
        '
        Me.btnDeleteVehicle.Location = New System.Drawing.Point(260, 512)
        Me.btnDeleteVehicle.Name = "btnDeleteVehicle"
        Me.btnDeleteVehicle.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteVehicle.TabIndex = 10
        Me.btnDeleteVehicle.Text = "Delete"
        Me.btnDeleteVehicle.UseVisualStyleBackColor = True
        '
        'btnUpdateVehicle
        '
        Me.btnUpdateVehicle.Location = New System.Drawing.Point(157, 512)
        Me.btnUpdateVehicle.Name = "btnUpdateVehicle"
        Me.btnUpdateVehicle.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateVehicle.TabIndex = 9
        Me.btnUpdateVehicle.Text = "Update"
        Me.btnUpdateVehicle.UseVisualStyleBackColor = True
        '
        'btnAddVehicle
        '
        Me.btnAddVehicle.Location = New System.Drawing.Point(38, 512)
        Me.btnAddVehicle.Name = "btnAddVehicle"
        Me.btnAddVehicle.Size = New System.Drawing.Size(75, 23)
        Me.btnAddVehicle.TabIndex = 8
        Me.btnAddVehicle.Text = "Add"
        Me.btnAddVehicle.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Vehicle Information"
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(114, 117)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(100, 20)
        Me.txtModel.TabIndex = 39
        '
        'txtMake
        '
        Me.txtMake.Location = New System.Drawing.Point(95, 91)
        Me.txtMake.Name = "txtMake"
        Me.txtMake.Size = New System.Drawing.Size(100, 20)
        Me.txtMake.TabIndex = 38
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Location = New System.Drawing.Point(95, 67)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomerID.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Vehicle Id :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Model :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Make :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Year :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 13)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Registration Number :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(592, 222)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 13)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "TR ID / Tax Number :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(595, 268)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(151, 13)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "Surname / Commercial Name :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(598, 304)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 13)
        Me.Label13.TabIndex = 58
        Me.Label13.Text = "First Name :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(598, 335)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 13)
        Me.Label14.TabIndex = 59
        Me.Label14.Text = "Address :"
        '
        'lblVehicleId
        '
        Me.lblVehicleId.AutoSize = True
        Me.lblVehicleId.Location = New System.Drawing.Point(112, 39)
        Me.lblVehicleId.Name = "lblVehicleId"
        Me.lblVehicleId.Size = New System.Drawing.Size(27, 13)
        Me.lblVehicleId.TabIndex = 60
        Me.lblVehicleId.Text = "N/A"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(23, 70)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 13)
        Me.Label16.TabIndex = 61
        Me.Label16.Text = "Customer Id :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(32, 185)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(37, 13)
        Me.Label17.TabIndex = 62
        Me.Label17.Text = "Color :"
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(95, 150)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(100, 20)
        Me.txtYear.TabIndex = 63
        '
        'txtColor
        '
        Me.txtColor.Location = New System.Drawing.Point(95, 178)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(100, 20)
        Me.txtColor.TabIndex = 64
        '
        'txtRegistrationNumber
        '
        Me.txtRegistrationNumber.Location = New System.Drawing.Point(148, 209)
        Me.txtRegistrationNumber.Name = "txtRegistrationNumber"
        Me.txtRegistrationNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtRegistrationNumber.TabIndex = 65
        '
        'EditVehicles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 565)
        Me.Controls.Add(Me.txtRegistrationNumber)
        Me.Controls.Add(Me.txtColor)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblVehicleId)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.txtMake)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDeleteVehicle)
        Me.Controls.Add(Me.btnUpdateVehicle)
        Me.Controls.Add(Me.btnAddVehicle)
        Me.Name = "EditVehicles"
        Me.Text = "Vehicles"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDeleteVehicle As Button
    Friend WithEvents btnUpdateVehicle As Button
    Friend WithEvents btnAddVehicle As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtModel As TextBox
    Friend WithEvents txtMake As TextBox
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblVehicleId As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtYear As TextBox
    Friend WithEvents txtColor As TextBox
    Friend WithEvents txtRegistrationNumber As TextBox
End Class

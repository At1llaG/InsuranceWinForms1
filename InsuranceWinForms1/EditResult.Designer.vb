<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditResult
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditResult))
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.txtReportID = New System.Windows.Forms.TextBox()
        Me.dtAccidentDate = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDeleteResult = New System.Windows.Forms.Button()
        Me.btnUpdateResult = New System.Windows.Forms.Button()
        Me.btnAddResult = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.numFaultRateDriver1 = New System.Windows.Forms.NumericUpDown()
        Me.numFaultRateDriver2 = New System.Windows.Forms.NumericUpDown()
        Me.txtViolationCode = New System.Windows.Forms.TextBox()
        Me.txtViolationNotification = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtDamageAmount = New System.Windows.Forms.TextBox()
        Me.lblResultID = New System.Windows.Forms.Label()
        Me.txtPlate1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPlate2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.numFaultRateDriver1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numFaultRateDriver2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbStatus
        '
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(130, 311)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(121, 21)
        Me.cmbStatus.TabIndex = 47
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(130, 248)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(100, 20)
        Me.txtLocation.TabIndex = 46
        '
        'txtReportID
        '
        Me.txtReportID.Location = New System.Drawing.Point(116, 208)
        Me.txtReportID.Name = "txtReportID"
        Me.txtReportID.Size = New System.Drawing.Size(100, 20)
        Me.txtReportID.TabIndex = 45
        '
        'dtAccidentDate
        '
        Me.dtAccidentDate.Location = New System.Drawing.Point(153, 131)
        Me.dtAccidentDate.Name = "dtAccidentDate"
        Me.dtAccidentDate.Size = New System.Drawing.Size(200, 20)
        Me.dtAccidentDate.TabIndex = 43
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(55, 451)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 13)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "Violation Code :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(78, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(633, 39)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = resources.GetString("Label10.Text")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(55, 354)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Accident Fault Rates :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(58, 314)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Status :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 251)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Location :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(58, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Report Id :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Accident Date :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(138, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Accident Report General Information :"
        '
        'btnDeleteResult
        '
        Me.btnDeleteResult.Location = New System.Drawing.Point(247, 663)
        Me.btnDeleteResult.Name = "btnDeleteResult"
        Me.btnDeleteResult.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteResult.TabIndex = 31
        Me.btnDeleteResult.Text = "Delete"
        Me.btnDeleteResult.UseVisualStyleBackColor = True
        '
        'btnUpdateResult
        '
        Me.btnUpdateResult.Location = New System.Drawing.Point(138, 663)
        Me.btnUpdateResult.Name = "btnUpdateResult"
        Me.btnUpdateResult.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateResult.TabIndex = 30
        Me.btnUpdateResult.Text = "Update"
        Me.btnUpdateResult.UseVisualStyleBackColor = True
        '
        'btnAddResult
        '
        Me.btnAddResult.Location = New System.Drawing.Point(31, 663)
        Me.btnAddResult.Name = "btnAddResult"
        Me.btnAddResult.Size = New System.Drawing.Size(75, 23)
        Me.btnAddResult.TabIndex = 29
        Me.btnAddResult.Text = "Add"
        Me.btnAddResult.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(58, 515)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(109, 13)
        Me.Label13.TabIndex = 49
        Me.Label13.Text = "Violation Notification :"
        '
        'numFaultRateDriver1
        '
        Me.numFaultRateDriver1.Location = New System.Drawing.Point(211, 381)
        Me.numFaultRateDriver1.Name = "numFaultRateDriver1"
        Me.numFaultRateDriver1.Size = New System.Drawing.Size(120, 20)
        Me.numFaultRateDriver1.TabIndex = 53
        '
        'numFaultRateDriver2
        '
        Me.numFaultRateDriver2.Location = New System.Drawing.Point(211, 408)
        Me.numFaultRateDriver2.Name = "numFaultRateDriver2"
        Me.numFaultRateDriver2.Size = New System.Drawing.Size(120, 20)
        Me.numFaultRateDriver2.TabIndex = 54
        '
        'txtViolationCode
        '
        Me.txtViolationCode.Location = New System.Drawing.Point(61, 474)
        Me.txtViolationCode.Name = "txtViolationCode"
        Me.txtViolationCode.Size = New System.Drawing.Size(100, 20)
        Me.txtViolationCode.TabIndex = 55
        '
        'txtViolationNotification
        '
        Me.txtViolationNotification.Location = New System.Drawing.Point(64, 541)
        Me.txtViolationNotification.Name = "txtViolationNotification"
        Me.txtViolationNotification.Size = New System.Drawing.Size(518, 96)
        Me.txtViolationNotification.TabIndex = 56
        Me.txtViolationNotification.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Result Id :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(61, 281)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(92, 13)
        Me.Label14.TabIndex = 57
        Me.Label14.Text = "Damage Amount :"
        '
        'txtDamageAmount
        '
        Me.txtDamageAmount.Location = New System.Drawing.Point(161, 278)
        Me.txtDamageAmount.Name = "txtDamageAmount"
        Me.txtDamageAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtDamageAmount.TabIndex = 58
        '
        'lblResultID
        '
        Me.lblResultID.AutoSize = True
        Me.lblResultID.Location = New System.Drawing.Point(135, 171)
        Me.lblResultID.Name = "lblResultID"
        Me.lblResultID.Size = New System.Drawing.Size(27, 13)
        Me.lblResultID.TabIndex = 59
        Me.lblResultID.Text = "N/A"
        '
        'txtPlate1
        '
        Me.txtPlate1.Location = New System.Drawing.Point(105, 381)
        Me.txtPlate1.Name = "txtPlate1"
        Me.txtPlate1.Size = New System.Drawing.Size(100, 20)
        Me.txtPlate1.TabIndex = 60
        Me.txtPlate1.Text = "00xx0000"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(78, 384)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 13)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "A -"
        '
        'txtPlate2
        '
        Me.txtPlate2.Location = New System.Drawing.Point(105, 407)
        Me.txtPlate2.Name = "txtPlate2"
        Me.txtPlate2.Size = New System.Drawing.Size(100, 20)
        Me.txtPlate2.TabIndex = 62
        Me.txtPlate2.Text = "00xx0000"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(78, 410)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(20, 13)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "B -"
        '
        'EditResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 732)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtPlate2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtPlate1)
        Me.Controls.Add(Me.lblResultID)
        Me.Controls.Add(Me.txtDamageAmount)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtViolationNotification)
        Me.Controls.Add(Me.txtViolationCode)
        Me.Controls.Add(Me.numFaultRateDriver2)
        Me.Controls.Add(Me.numFaultRateDriver1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.txtReportID)
        Me.Controls.Add(Me.dtAccidentDate)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDeleteResult)
        Me.Controls.Add(Me.btnUpdateResult)
        Me.Controls.Add(Me.btnAddResult)
        Me.Name = "EditResult"
        Me.Text = "Edit Result"
        CType(Me.numFaultRateDriver1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numFaultRateDriver2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents txtReportID As TextBox
    Friend WithEvents dtAccidentDate As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDeleteResult As Button
    Friend WithEvents btnUpdateResult As Button
    Friend WithEvents btnAddResult As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents numFaultRateDriver1 As NumericUpDown
    Friend WithEvents numFaultRateDriver2 As NumericUpDown
    Friend WithEvents txtViolationCode As TextBox
    Friend WithEvents txtViolationNotification As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtDamageAmount As TextBox
    Friend WithEvents lblResultID As Label
    Friend WithEvents txtPlate1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPlate2 As TextBox
    Friend WithEvents Label9 As Label
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xClaims
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
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.lblDelete = New System.Windows.Forms.Button()
        Me.lblUpdate = New System.Windows.Forms.Button()
        Me.lblAdd = New System.Windows.Forms.Button()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView
        '
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.Size = New System.Drawing.Size(776, 336)
        Me.DataGridView.TabIndex = 0
        '
        'lblDelete
        '
        Me.lblDelete.Location = New System.Drawing.Point(228, 382)
        Me.lblDelete.Name = "lblDelete"
        Me.lblDelete.Size = New System.Drawing.Size(75, 23)
        Me.lblDelete.TabIndex = 6
        Me.lblDelete.Text = "Delete"
        Me.lblDelete.UseVisualStyleBackColor = True
        '
        'lblUpdate
        '
        Me.lblUpdate.Location = New System.Drawing.Point(119, 382)
        Me.lblUpdate.Name = "lblUpdate"
        Me.lblUpdate.Size = New System.Drawing.Size(75, 23)
        Me.lblUpdate.TabIndex = 5
        Me.lblUpdate.Text = "Update"
        Me.lblUpdate.UseVisualStyleBackColor = True
        '
        'lblAdd
        '
        Me.lblAdd.Location = New System.Drawing.Point(12, 382)
        Me.lblAdd.Name = "lblAdd"
        Me.lblAdd.Size = New System.Drawing.Size(75, 23)
        Me.lblAdd.TabIndex = 4
        Me.lblAdd.Text = "Add"
        Me.lblAdd.UseVisualStyleBackColor = True
        '
        'xClaims
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblDelete)
        Me.Controls.Add(Me.lblUpdate)
        Me.Controls.Add(Me.lblAdd)
        Me.Controls.Add(Me.DataGridView)
        Me.Name = "xClaims"
        Me.Text = "Claims"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents lblDelete As Button
    Friend WithEvents lblUpdate As Button
    Friend WithEvents lblAdd As Button
End Class

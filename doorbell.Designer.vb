﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class doorbell
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
        Me.components = New System.ComponentModel.Container()
        Me.doorlabel = New System.Windows.Forms.Label()
        Me.respondbtn = New System.Windows.Forms.Button()
        Me.ignorebtn = New System.Windows.Forms.Button()
        Me.info = New System.Windows.Forms.Label()
        Me.endbtn = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'doorlabel
        '
        Me.doorlabel.AutoSize = True
        Me.doorlabel.BackColor = System.Drawing.Color.Red
        Me.doorlabel.Font = New System.Drawing.Font("SimSun", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.doorlabel.Location = New System.Drawing.Point(94, 155)
        Me.doorlabel.Name = "doorlabel"
        Me.doorlabel.Size = New System.Drawing.Size(273, 60)
        Me.doorlabel.TabIndex = 1
        Me.doorlabel.Text = "DOORBELL"
        '
        'respondbtn
        '
        Me.respondbtn.Location = New System.Drawing.Point(12, 267)
        Me.respondbtn.Name = "respondbtn"
        Me.respondbtn.Size = New System.Drawing.Size(188, 58)
        Me.respondbtn.TabIndex = 2
        Me.respondbtn.Text = "RESPOND"
        Me.respondbtn.UseVisualStyleBackColor = True
        '
        'ignorebtn
        '
        Me.ignorebtn.Location = New System.Drawing.Point(276, 267)
        Me.ignorebtn.Name = "ignorebtn"
        Me.ignorebtn.Size = New System.Drawing.Size(178, 58)
        Me.ignorebtn.TabIndex = 3
        Me.ignorebtn.Text = "IGNORE"
        Me.ignorebtn.UseVisualStyleBackColor = True
        '
        'info
        '
        Me.info.AutoSize = True
        Me.info.Location = New System.Drawing.Point(0, 0)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(0, 41)
        Me.info.TabIndex = 4
        '
        'endbtn
        '
        Me.endbtn.Location = New System.Drawing.Point(266, 351)
        Me.endbtn.Name = "endbtn"
        Me.endbtn.Size = New System.Drawing.Size(188, 58)
        Me.endbtn.TabIndex = 5
        Me.endbtn.Text = "END"
        Me.endbtn.UseVisualStyleBackColor = True
        '
        'doorbell
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(17.0!, 41.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(552, 421)
        Me.Controls.Add(Me.endbtn)
        Me.Controls.Add(Me.info)
        Me.Controls.Add(Me.ignorebtn)
        Me.Controls.Add(Me.respondbtn)
        Me.Controls.Add(Me.doorlabel)
        Me.Name = "doorbell"
        Me.Text = "doorbell"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents doorlabel As Label
    Friend WithEvents respondbtn As Button
    Friend WithEvents ignorebtn As Button
    Friend WithEvents info As Label
    Friend WithEvents endbtn As Button
    Friend WithEvents Timer1 As Timer
End Class

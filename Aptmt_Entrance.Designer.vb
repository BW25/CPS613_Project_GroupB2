﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Aptmt_Entrance
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
        Me.components = New System.ComponentModel.Container()
        Me.ControlAptBtn = New System.Windows.Forms.Button()
        Me.CallAssistBtn = New System.Windows.Forms.Button()
        Me.BlindsBtn = New System.Windows.Forms.Button()
        Me.WindowsBtn = New System.Windows.Forms.Button()
        Me.LightsBtn = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Title2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Title = New System.Windows.Forms.Label()
        Me.BedroomBtn = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.KitchenBtn = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ControlAptBtn
        '
        Me.ControlAptBtn.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ControlAptBtn.Location = New System.Drawing.Point(0, 335)
        Me.ControlAptBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ControlAptBtn.Name = "ControlAptBtn"
        Me.ControlAptBtn.Size = New System.Drawing.Size(340, 40)
        Me.ControlAptBtn.TabIndex = 23
        Me.ControlAptBtn.Text = "Control Apartment >"
        Me.ControlAptBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ControlAptBtn.UseVisualStyleBackColor = True
        '
        'CallAssistBtn
        '
        Me.CallAssistBtn.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CallAssistBtn.Location = New System.Drawing.Point(0, 375)
        Me.CallAssistBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CallAssistBtn.Name = "CallAssistBtn"
        Me.CallAssistBtn.Size = New System.Drawing.Size(340, 40)
        Me.CallAssistBtn.TabIndex = 22
        Me.CallAssistBtn.Text = "Call For Assistance"
        Me.CallAssistBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CallAssistBtn.UseVisualStyleBackColor = True
        '
        'BlindsBtn
        '
        Me.BlindsBtn.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BlindsBtn.Location = New System.Drawing.Point(40, 120)
        Me.BlindsBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BlindsBtn.Name = "BlindsBtn"
        Me.BlindsBtn.Size = New System.Drawing.Size(300, 40)
        Me.BlindsBtn.TabIndex = 21
        Me.BlindsBtn.Tag = "Blinds"
        Me.BlindsBtn.Text = "Blinds- (Closed)"
        Me.BlindsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BlindsBtn.UseVisualStyleBackColor = True
        '
        'WindowsBtn
        '
        Me.WindowsBtn.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.WindowsBtn.Location = New System.Drawing.Point(40, 80)
        Me.WindowsBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.WindowsBtn.Name = "WindowsBtn"
        Me.WindowsBtn.Size = New System.Drawing.Size(300, 40)
        Me.WindowsBtn.TabIndex = 20
        Me.WindowsBtn.Tag = "Windows"
        Me.WindowsBtn.Text = "Windows- (Closed)"
        Me.WindowsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.WindowsBtn.UseVisualStyleBackColor = True
        '
        'LightsBtn
        '
        Me.LightsBtn.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LightsBtn.Location = New System.Drawing.Point(40, 40)
        Me.LightsBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LightsBtn.Name = "LightsBtn"
        Me.LightsBtn.Size = New System.Drawing.Size(300, 40)
        Me.LightsBtn.TabIndex = 19
        Me.LightsBtn.Tag = "Lights"
        Me.LightsBtn.Text = "Lights- (Off)"
        Me.LightsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LightsBtn.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Image = Global.CPS613_Project_GroupB2.My.Resources.Resources.blinds_icon
        Me.PictureBox3.Location = New System.Drawing.Point(0, 120)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 18
        Me.PictureBox3.TabStop = False
        '
        'Title2
        '
        Me.Title2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Title2.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Title2.Location = New System.Drawing.Point(0, 170)
        Me.Title2.Name = "Title2"
        Me.Title2.Size = New System.Drawing.Size(340, 40)
        Me.Title2.TabIndex = 17
        Me.Title2.Text = "Navigate To:"
        Me.Title2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = Global.CPS613_Project_GroupB2.My.Resources.Resources.window_icon
        Me.PictureBox2.Location = New System.Drawing.Point(0, 80)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.CPS613_Project_GroupB2.My.Resources.Resources.lights_icon
        Me.PictureBox1.Location = New System.Drawing.Point(0, 40)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Title
        '
        Me.Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Title.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Title.Location = New System.Drawing.Point(0, 0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(340, 40)
        Me.Title.TabIndex = 14
        Me.Title.Text = "Apartment 503 (Entrance)"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BedroomBtn
        '
        Me.BedroomBtn.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BedroomBtn.Location = New System.Drawing.Point(40, 210)
        Me.BedroomBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BedroomBtn.Name = "BedroomBtn"
        Me.BedroomBtn.Size = New System.Drawing.Size(300, 40)
        Me.BedroomBtn.TabIndex = 25
        Me.BedroomBtn.Text = "Bedroom"
        Me.BedroomBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BedroomBtn.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox4.Image = Global.CPS613_Project_GroupB2.My.Resources.Resources.bedroom_icon
        Me.PictureBox4.Location = New System.Drawing.Point(0, 210)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 24
        Me.PictureBox4.TabStop = False
        '
        'KitchenBtn
        '
        Me.KitchenBtn.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.KitchenBtn.Location = New System.Drawing.Point(40, 250)
        Me.KitchenBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.KitchenBtn.Name = "KitchenBtn"
        Me.KitchenBtn.Size = New System.Drawing.Size(300, 40)
        Me.KitchenBtn.TabIndex = 27
        Me.KitchenBtn.Text = "Kitchen"
        Me.KitchenBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.KitchenBtn.UseVisualStyleBackColor = True
        '
        'PictureBox5
        '
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox5.Image = Global.CPS613_Project_GroupB2.My.Resources.Resources.kitchen_icon
        Me.PictureBox5.Location = New System.Drawing.Point(0, 250)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 26
        Me.PictureBox5.TabStop = False
        '
        'Timer1
        '
        '
        'Aptmt_Entrance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 415)
        Me.Controls.Add(Me.KitchenBtn)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.BedroomBtn)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.ControlAptBtn)
        Me.Controls.Add(Me.CallAssistBtn)
        Me.Controls.Add(Me.BlindsBtn)
        Me.Controls.Add(Me.WindowsBtn)
        Me.Controls.Add(Me.LightsBtn)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Title2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Title)
        Me.Name = "Aptmt_Entrance"
        Me.Text = "Aptmt_Entrance"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ControlAptBtn As Button
    Friend WithEvents CallAssistBtn As Button
    Friend WithEvents BlindsBtn As Button
    Friend WithEvents WindowsBtn As Button
    Friend WithEvents LightsBtn As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Title2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Title As Label
    Friend WithEvents BedroomBtn As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents KitchenBtn As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Timer1 As Timer
End Class

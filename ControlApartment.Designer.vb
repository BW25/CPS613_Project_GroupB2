<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlApartment
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
        Me.Title = New System.Windows.Forms.Label()
        Me.HumidityBtn = New System.Windows.Forms.Button()
        Me.TempBtn = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.FanBtn = New System.Windows.Forms.Button()
        Me.BedroomBtn = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Title2 = New System.Windows.Forms.Label()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.CallAssistBtn = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.KitchenBtn = New System.Windows.Forms.Button()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.IncTempBtn = New System.Windows.Forms.Button()
        Me.DecTempBtn = New System.Windows.Forms.Button()
        Me.TempLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Title.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Title.Location = New System.Drawing.Point(0, 0)
        Me.Title.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(485, 65)
        Me.Title.TabIndex = 1
        Me.Title.Text = "Control Apartment"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HumidityBtn
        '
        Me.HumidityBtn.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.HumidityBtn.Location = New System.Drawing.Point(56, 134)
        Me.HumidityBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.HumidityBtn.Name = "HumidityBtn"
        Me.HumidityBtn.Size = New System.Drawing.Size(429, 67)
        Me.HumidityBtn.TabIndex = 14
        Me.HumidityBtn.Text = "Humidity- (Off)"
        Me.HumidityBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.HumidityBtn.UseVisualStyleBackColor = True
        '
        'TempBtn
        '
        Me.TempBtn.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TempBtn.Location = New System.Drawing.Point(56, 68)
        Me.TempBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TempBtn.Name = "TempBtn"
        Me.TempBtn.Size = New System.Drawing.Size(429, 67)
        Me.TempBtn.TabIndex = 1000
        Me.TempBtn.Text = "Temperature-        °C"
        Me.TempBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TempBtn.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = Global.CPS613_Project_GroupB2.My.Resources.Resources.humidity
        Me.PictureBox2.Location = New System.Drawing.Point(-1, 134)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(56, 65)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.CPS613_Project_GroupB2.My.Resources.Resources.temperature
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 68)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 65)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Image = Global.CPS613_Project_GroupB2.My.Resources.Resources.fan
        Me.PictureBox3.Location = New System.Drawing.Point(-1, 200)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(56, 65)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        '
        'FanBtn
        '
        Me.FanBtn.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FanBtn.Location = New System.Drawing.Point(56, 200)
        Me.FanBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.FanBtn.Name = "FanBtn"
        Me.FanBtn.Size = New System.Drawing.Size(429, 67)
        Me.FanBtn.TabIndex = 14
        Me.FanBtn.Text = "Fans- (On)"
        Me.FanBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FanBtn.UseVisualStyleBackColor = True
        '
        'BedroomBtn
        '
        Me.BedroomBtn.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BedroomBtn.Location = New System.Drawing.Point(56, 346)
        Me.BedroomBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BedroomBtn.Name = "BedroomBtn"
        Me.BedroomBtn.Size = New System.Drawing.Size(429, 67)
        Me.BedroomBtn.TabIndex = 17
        Me.BedroomBtn.Text = "Bedroom"
        Me.BedroomBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BedroomBtn.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox4.Image = Global.CPS613_Project_GroupB2.My.Resources.Resources.bed
        Me.PictureBox4.Location = New System.Drawing.Point(-1, 346)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(56, 65)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 16
        Me.PictureBox4.TabStop = False
        '
        'Title2
        '
        Me.Title2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Title2.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Title2.Location = New System.Drawing.Point(-1, 280)
        Me.Title2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Title2.Name = "Title2"
        Me.Title2.Size = New System.Drawing.Size(485, 65)
        Me.Title2.TabIndex = 15
        Me.Title2.Text = "Navigate To:"
        Me.Title2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BackBtn
        '
        Me.BackBtn.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BackBtn.Location = New System.Drawing.Point(56, 557)
        Me.BackBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(430, 68)
        Me.BackBtn.TabIndex = 19
        Me.BackBtn.Text = "Back"
        Me.BackBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BackBtn.UseVisualStyleBackColor = True
        '
        'CallAssistBtn
        '
        Me.CallAssistBtn.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CallAssistBtn.Location = New System.Drawing.Point(0, 624)
        Me.CallAssistBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CallAssistBtn.Name = "CallAssistBtn"
        Me.CallAssistBtn.Size = New System.Drawing.Size(486, 68)
        Me.CallAssistBtn.TabIndex = 18
        Me.CallAssistBtn.Text = "Call For Assistance"
        Me.CallAssistBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CallAssistBtn.UseVisualStyleBackColor = True
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox5.Image = Global.CPS613_Project_GroupB2.My.Resources.Resources.back
        Me.PictureBox5.Location = New System.Drawing.Point(0, 558)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(56, 65)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 16
        Me.PictureBox5.TabStop = False
        '
        'KitchenBtn
        '
        Me.KitchenBtn.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.KitchenBtn.Location = New System.Drawing.Point(55, 412)
        Me.KitchenBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.KitchenBtn.Name = "KitchenBtn"
        Me.KitchenBtn.Size = New System.Drawing.Size(429, 67)
        Me.KitchenBtn.TabIndex = 17
        Me.KitchenBtn.Text = "Kitchen"
        Me.KitchenBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.KitchenBtn.UseVisualStyleBackColor = True
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox6.Image = Global.CPS613_Project_GroupB2.My.Resources.Resources.kitchen
        Me.PictureBox6.Location = New System.Drawing.Point(-2, 412)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(56, 65)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 16
        Me.PictureBox6.TabStop = False
        '
        'Timer1
        '
        '
        'IncTempBtn
        '
        Me.IncTempBtn.BackgroundImage = Global.CPS613_Project_GroupB2.My.Resources.Resources.inc
        Me.IncTempBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.IncTempBtn.Location = New System.Drawing.Point(355, 70)
        Me.IncTempBtn.Name = "IncTempBtn"
        Me.IncTempBtn.Size = New System.Drawing.Size(65, 65)
        Me.IncTempBtn.TabIndex = 1
        Me.IncTempBtn.UseVisualStyleBackColor = True
        '
        'DecTempBtn
        '
        Me.DecTempBtn.BackgroundImage = Global.CPS613_Project_GroupB2.My.Resources.Resources.dec
        Me.DecTempBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.DecTempBtn.Location = New System.Drawing.Point(419, 70)
        Me.DecTempBtn.Name = "DecTempBtn"
        Me.DecTempBtn.Size = New System.Drawing.Size(65, 65)
        Me.DecTempBtn.TabIndex = 2
        Me.DecTempBtn.UseVisualStyleBackColor = True
        '
        'TempLabel
        '
        Me.TempLabel.AutoSize = True
        Me.TempLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TempLabel.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TempLabel.Location = New System.Drawing.Point(261, 81)
        Me.TempLabel.Name = "TempLabel"
        Me.TempLabel.Size = New System.Drawing.Size(50, 41)
        Me.TempLabel.TabIndex = 21
        Me.TempLabel.Text = "25"
        '
        'ControlApartment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 692)
        Me.Controls.Add(Me.TempLabel)
        Me.Controls.Add(Me.DecTempBtn)
        Me.Controls.Add(Me.IncTempBtn)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.BackBtn)
        Me.Controls.Add(Me.CallAssistBtn)
        Me.Controls.Add(Me.KitchenBtn)
        Me.Controls.Add(Me.BedroomBtn)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.Title2)
        Me.Controls.Add(Me.FanBtn)
        Me.Controls.Add(Me.HumidityBtn)
        Me.Controls.Add(Me.TempBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Title)
        Me.Name = "ControlApartment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ControlApartment"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Title As Label
    Friend WithEvents HumidityBtn As Button
    Friend WithEvents TempBtn As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents FanBtn As Button
    Friend WithEvents BedroomBtn As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Title2 As Label
    Friend WithEvents BackBtn As Button
    Friend WithEvents CallAssistBtn As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents KitchenBtn As Button
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents IncTempBtn As Button
    Friend WithEvents DecTempBtn As Button
    Friend WithEvents TempLabel As Label
End Class

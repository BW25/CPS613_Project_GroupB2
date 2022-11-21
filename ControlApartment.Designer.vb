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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlApartment))
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
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
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
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(340, 40)
        Me.Title.TabIndex = 1
        Me.Title.Text = "Control Apartment"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HumidityBtn
        '
        Me.HumidityBtn.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.HumidityBtn.Location = New System.Drawing.Point(39, 80)
        Me.HumidityBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.HumidityBtn.Name = "HumidityBtn"
        Me.HumidityBtn.Size = New System.Drawing.Size(300, 40)
        Me.HumidityBtn.TabIndex = 14
        Me.HumidityBtn.Text = "Humidity- (Off)"
        Me.HumidityBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.HumidityBtn.UseVisualStyleBackColor = True
        '
        'TempBtn
        '
        Me.TempBtn.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TempBtn.Location = New System.Drawing.Point(39, 41)
        Me.TempBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TempBtn.Name = "TempBtn"
        Me.TempBtn.Size = New System.Drawing.Size(300, 40)
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
        Me.PictureBox2.Location = New System.Drawing.Point(-1, 80)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.CPS613_Project_GroupB2.My.Resources.Resources.temperature
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 41)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Image = Global.CPS613_Project_GroupB2.My.Resources.Resources.fan
        Me.PictureBox3.Location = New System.Drawing.Point(-1, 120)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        '
        'FanBtn
        '
        Me.FanBtn.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FanBtn.Location = New System.Drawing.Point(39, 120)
        Me.FanBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FanBtn.Name = "FanBtn"
        Me.FanBtn.Size = New System.Drawing.Size(300, 40)
        Me.FanBtn.TabIndex = 14
        Me.FanBtn.Text = "Fans- (On)"
        Me.FanBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FanBtn.UseVisualStyleBackColor = True
        '
        'BedroomBtn
        '
        Me.BedroomBtn.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BedroomBtn.Location = New System.Drawing.Point(39, 208)
        Me.BedroomBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BedroomBtn.Name = "BedroomBtn"
        Me.BedroomBtn.Size = New System.Drawing.Size(300, 40)
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
        Me.PictureBox4.Location = New System.Drawing.Point(-1, 208)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 16
        Me.PictureBox4.TabStop = False
        '
        'Title2
        '
        Me.Title2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Title2.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Title2.Location = New System.Drawing.Point(-1, 168)
        Me.Title2.Name = "Title2"
        Me.Title2.Size = New System.Drawing.Size(340, 40)
        Me.Title2.TabIndex = 15
        Me.Title2.Text = "Navigate To:"
        Me.Title2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BackBtn
        '
        Me.BackBtn.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BackBtn.Location = New System.Drawing.Point(39, 334)
        Me.BackBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(301, 41)
        Me.BackBtn.TabIndex = 19
        Me.BackBtn.Text = "Back"
        Me.BackBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BackBtn.UseVisualStyleBackColor = True
        '
        'CallAssistBtn
        '
        Me.CallAssistBtn.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CallAssistBtn.Location = New System.Drawing.Point(0, 374)
        Me.CallAssistBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CallAssistBtn.Name = "CallAssistBtn"
        Me.CallAssistBtn.Size = New System.Drawing.Size(340, 41)
        Me.CallAssistBtn.TabIndex = 18
        Me.CallAssistBtn.Tag = "1"
        Me.CallAssistBtn.Text = "Call For Assistance"
        Me.CallAssistBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CallAssistBtn.UseVisualStyleBackColor = True
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox5.Image = Global.CPS613_Project_GroupB2.My.Resources.Resources.back
        Me.PictureBox5.Location = New System.Drawing.Point(0, 335)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 16
        Me.PictureBox5.TabStop = False
        '
        'KitchenBtn
        '
        Me.KitchenBtn.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.KitchenBtn.Location = New System.Drawing.Point(38, 247)
        Me.KitchenBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.KitchenBtn.Name = "KitchenBtn"
        Me.KitchenBtn.Size = New System.Drawing.Size(300, 40)
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
        Me.PictureBox6.Location = New System.Drawing.Point(-1, 247)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(40, 40)
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
        Me.IncTempBtn.Location = New System.Drawing.Point(248, 42)
        Me.IncTempBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.IncTempBtn.Name = "IncTempBtn"
        Me.IncTempBtn.Size = New System.Drawing.Size(46, 39)
        Me.IncTempBtn.TabIndex = 1
        Me.IncTempBtn.UseVisualStyleBackColor = True
        '
        'DecTempBtn
        '
        Me.DecTempBtn.BackgroundImage = Global.CPS613_Project_GroupB2.My.Resources.Resources.dec
        Me.DecTempBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.DecTempBtn.Location = New System.Drawing.Point(293, 42)
        Me.DecTempBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.DecTempBtn.Name = "DecTempBtn"
        Me.DecTempBtn.Size = New System.Drawing.Size(46, 39)
        Me.DecTempBtn.TabIndex = 2
        Me.DecTempBtn.UseVisualStyleBackColor = True
        '
        'TempLabel
        '
        Me.TempLabel.AutoSize = True
        Me.TempLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TempLabel.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TempLabel.Location = New System.Drawing.Point(183, 49)
        Me.TempLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TempLabel.Name = "TempLabel"
        Me.TempLabel.Size = New System.Drawing.Size(34, 28)
        Me.TempLabel.TabIndex = 21
        Me.TempLabel.Text = "25"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'ControlApartment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 415)
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
        Me.Margin = New System.Windows.Forms.Padding(2)
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
    Friend WithEvents NotifyIcon1 As NotifyIcon
End Class

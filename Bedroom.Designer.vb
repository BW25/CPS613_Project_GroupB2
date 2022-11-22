<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bedroom
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bedroom))
        Me.Title = New System.Windows.Forms.Label()
        Me.ControlAptBtn = New System.Windows.Forms.Button()
        Me.CallAssistBtn = New System.Windows.Forms.Button()
        Me.WakeUpBtn = New System.Windows.Forms.Button()
        Me.GoToBedBtn = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.BlindsBtn = New System.Windows.Forms.Button()
        Me.WindowsBtn = New System.Windows.Forms.Button()
        Me.LightsBtn = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Title2 = New System.Windows.Forms.Label()
        Me.FloorBtn = New System.Windows.Forms.Button()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
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
        Me.Title.TabIndex = 2
        Me.Title.Text = "Bedroom"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ControlAptBtn
        '
        Me.ControlAptBtn.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ControlAptBtn.Location = New System.Drawing.Point(-1, 335)
        Me.ControlAptBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ControlAptBtn.Name = "ControlAptBtn"
        Me.ControlAptBtn.Size = New System.Drawing.Size(340, 40)
        Me.ControlAptBtn.TabIndex = 6
        Me.ControlAptBtn.Text = "Control Apartment >"
        Me.ControlAptBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ControlAptBtn.UseVisualStyleBackColor = True
        '
        'CallAssistBtn
        '
        Me.CallAssistBtn.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CallAssistBtn.Location = New System.Drawing.Point(-1, 376)
        Me.CallAssistBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CallAssistBtn.Name = "CallAssistBtn"
        Me.CallAssistBtn.Size = New System.Drawing.Size(340, 40)
        Me.CallAssistBtn.TabIndex = 7
        Me.CallAssistBtn.Tag = "1"
        Me.CallAssistBtn.Text = "Call For Assistance"
        Me.CallAssistBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CallAssistBtn.UseVisualStyleBackColor = True
        '
        'WakeUpBtn
        '
        Me.WakeUpBtn.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.WakeUpBtn.Location = New System.Drawing.Point(40, 199)
        Me.WakeUpBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.WakeUpBtn.Name = "WakeUpBtn"
        Me.WakeUpBtn.Size = New System.Drawing.Size(300, 40)
        Me.WakeUpBtn.TabIndex = 4
        Me.WakeUpBtn.Text = "Get out of bed"
        Me.WakeUpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.WakeUpBtn.UseVisualStyleBackColor = True
        '
        'GoToBedBtn
        '
        Me.GoToBedBtn.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GoToBedBtn.Location = New System.Drawing.Point(40, 160)
        Me.GoToBedBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GoToBedBtn.Name = "GoToBedBtn"
        Me.GoToBedBtn.Size = New System.Drawing.Size(300, 40)
        Me.GoToBedBtn.TabIndex = 3
        Me.GoToBedBtn.Text = "Go to bed"
        Me.GoToBedBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GoToBedBtn.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = Global.CPS613_Project_GroupB2.My.Resources.Resources.sun
        Me.PictureBox2.Location = New System.Drawing.Point(0, 199)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.CPS613_Project_GroupB2.My.Resources.Resources.moon
        Me.PictureBox1.Location = New System.Drawing.Point(0, 160)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'BlindsBtn
        '
        Me.BlindsBtn.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BlindsBtn.Location = New System.Drawing.Point(39, 121)
        Me.BlindsBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BlindsBtn.Name = "BlindsBtn"
        Me.BlindsBtn.Size = New System.Drawing.Size(300, 40)
        Me.BlindsBtn.TabIndex = 2
        Me.BlindsBtn.Tag = "Blinds"
        Me.BlindsBtn.Text = "Blinds- (Opened)"
        Me.BlindsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BlindsBtn.UseVisualStyleBackColor = True
        '
        'WindowsBtn
        '
        Me.WindowsBtn.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.WindowsBtn.Location = New System.Drawing.Point(39, 80)
        Me.WindowsBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.WindowsBtn.Name = "WindowsBtn"
        Me.WindowsBtn.Size = New System.Drawing.Size(300, 40)
        Me.WindowsBtn.TabIndex = 1
        Me.WindowsBtn.Tag = "Windows"
        Me.WindowsBtn.Text = "Windows- (Opened)"
        Me.WindowsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.WindowsBtn.UseVisualStyleBackColor = True
        '
        'LightsBtn
        '
        Me.LightsBtn.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LightsBtn.Location = New System.Drawing.Point(39, 41)
        Me.LightsBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LightsBtn.Name = "LightsBtn"
        Me.LightsBtn.Size = New System.Drawing.Size(300, 40)
        Me.LightsBtn.TabIndex = 0
        Me.LightsBtn.Tag = "Lights"
        Me.LightsBtn.Text = "Lights- (On)"
        Me.LightsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LightsBtn.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Image = Global.CPS613_Project_GroupB2.My.Resources.Resources.blinds_icon
        Me.PictureBox3.Location = New System.Drawing.Point(-1, 121)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 24
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox4.Image = Global.CPS613_Project_GroupB2.My.Resources.Resources.window_icon
        Me.PictureBox4.Location = New System.Drawing.Point(-1, 80)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 23
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox5.Image = Global.CPS613_Project_GroupB2.My.Resources.Resources.lights_icon
        Me.PictureBox5.Location = New System.Drawing.Point(-1, 41)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 22
        Me.PictureBox5.TabStop = False
        '
        'Title2
        '
        Me.Title2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Title2.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Title2.Location = New System.Drawing.Point(-1, 243)
        Me.Title2.Name = "Title2"
        Me.Title2.Size = New System.Drawing.Size(340, 40)
        Me.Title2.TabIndex = 28
        Me.Title2.Text = "Navigate To:"
        Me.Title2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FloorBtn
        '
        Me.FloorBtn.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FloorBtn.Location = New System.Drawing.Point(38, 284)
        Me.FloorBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FloorBtn.Name = "FloorBtn"
        Me.FloorBtn.Size = New System.Drawing.Size(300, 40)
        Me.FloorBtn.TabIndex = 5
        Me.FloorBtn.Text = "Floor 5 Hallway"
        Me.FloorBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FloorBtn.UseVisualStyleBackColor = True
        '
        'PictureBox6
        '
        Me.PictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox6.Image = Global.CPS613_Project_GroupB2.My.Resources.Resources.entrance_icon
        Me.PictureBox6.Location = New System.Drawing.Point(-1, 284)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 30
        Me.PictureBox6.TabStop = False
        '
        'Bedroom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 415)
        Me.Controls.Add(Me.FloorBtn)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.Title2)
        Me.Controls.Add(Me.BlindsBtn)
        Me.Controls.Add(Me.WindowsBtn)
        Me.Controls.Add(Me.LightsBtn)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.WakeUpBtn)
        Me.Controls.Add(Me.GoToBedBtn)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ControlAptBtn)
        Me.Controls.Add(Me.CallAssistBtn)
        Me.Controls.Add(Me.Title)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Bedroom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bedroom"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Title As Label
    Friend WithEvents ControlAptBtn As Button
    Friend WithEvents CallAssistBtn As Button
    Friend WithEvents WakeUpBtn As Button
    Friend WithEvents GoToBedBtn As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents BlindsBtn As Button
    Friend WithEvents WindowsBtn As Button
    Friend WithEvents LightsBtn As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Title2 As Label
    Friend WithEvents FloorBtn As Button
    Friend WithEvents PictureBox6 As PictureBox
End Class

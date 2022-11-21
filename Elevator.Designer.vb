<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Elevator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Elevator))
        Me.ControlAptBtn = New System.Windows.Forms.Button()
        Me.CallAssistBtn = New System.Windows.Forms.Button()
        Me.LobbyB = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Title = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.F5 = New System.Windows.Forms.Button()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.F4 = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.F3 = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.F2 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ControlAptBtn
        '
        Me.ControlAptBtn.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ControlAptBtn.Location = New System.Drawing.Point(-1, 335)
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
        Me.CallAssistBtn.Location = New System.Drawing.Point(-1, 375)
        Me.CallAssistBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CallAssistBtn.Name = "CallAssistBtn"
        Me.CallAssistBtn.Size = New System.Drawing.Size(340, 40)
        Me.CallAssistBtn.TabIndex = 22
        Me.CallAssistBtn.Text = "Call For Assistance"
        Me.CallAssistBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CallAssistBtn.UseVisualStyleBackColor = True
        '
        'LobbyB
        '
        Me.LobbyB.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LobbyB.Location = New System.Drawing.Point(39, 40)
        Me.LobbyB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LobbyB.Name = "LobbyB"
        Me.LobbyB.Size = New System.Drawing.Size(300, 40)
        Me.LobbyB.TabIndex = 19
        Me.LobbyB.Text = "Floor 1"
        Me.LobbyB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LobbyB.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 40)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Title
        '
        Me.Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Title.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Title.Location = New System.Drawing.Point(-1, 0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(340, 40)
        Me.Title.TabIndex = 14
        Me.Title.Text = "Elevator"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'F5
        '
        Me.F5.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.F5.Location = New System.Drawing.Point(39, 200)
        Me.F5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.F5.Name = "F5"
        Me.F5.Size = New System.Drawing.Size(300, 40)
        Me.F5.TabIndex = 37
        Me.F5.Text = "Floor 5"
        Me.F5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.F5.UseVisualStyleBackColor = True
        '
        'PictureBox6
        '
        Me.PictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox6.Location = New System.Drawing.Point(-1, 200)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox6.TabIndex = 36
        Me.PictureBox6.TabStop = False
        '
        'F4
        '
        Me.F4.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.F4.Location = New System.Drawing.Point(39, 160)
        Me.F4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.F4.Name = "F4"
        Me.F4.Size = New System.Drawing.Size(300, 40)
        Me.F4.TabIndex = 35
        Me.F4.Text = "Floor 4"
        Me.F4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.F4.UseVisualStyleBackColor = True
        '
        'PictureBox5
        '
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox5.Location = New System.Drawing.Point(-1, 160)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox5.TabIndex = 34
        Me.PictureBox5.TabStop = False
        '
        'F3
        '
        Me.F3.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.F3.Location = New System.Drawing.Point(39, 120)
        Me.F3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.F3.Name = "F3"
        Me.F3.Size = New System.Drawing.Size(300, 40)
        Me.F3.TabIndex = 33
        Me.F3.Text = "Floor 3"
        Me.F3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.F3.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox4.Location = New System.Drawing.Point(-1, 120)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox4.TabIndex = 32
        Me.PictureBox4.TabStop = False
        '
        'F2
        '
        Me.F2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.F2.Location = New System.Drawing.Point(39, 80)
        Me.F2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.F2.Name = "F2"
        Me.F2.Size = New System.Drawing.Size(300, 40)
        Me.F2.TabIndex = 31
        Me.F2.Text = "Floor 2"
        Me.F2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.F2.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Location = New System.Drawing.Point(-1, 80)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox3.TabIndex = 30
        Me.PictureBox3.TabStop = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Elevator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 415)
        Me.Controls.Add(Me.F5)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.F4)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.F3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.F2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.ControlAptBtn)
        Me.Controls.Add(Me.CallAssistBtn)
        Me.Controls.Add(Me.LobbyB)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Title)
        Me.Name = "Elevator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elevator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ControlAptBtn As Button
    Friend WithEvents CallAssistBtn As Button
    Friend WithEvents LobbyB As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Title As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents F5 As Button
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents F4 As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents F3 As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents F2 As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents NotifyIcon1 As NotifyIcon
End Class

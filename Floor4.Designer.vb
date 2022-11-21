<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Floor4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Floor4))
        Me.CallAssistBtn = New System.Windows.Forms.Button()
        Me.RM401 = New System.Windows.Forms.Button()
        Me.CallE = New System.Windows.Forms.Button()
        Me.Pic401 = New System.Windows.Forms.PictureBox()
        Me.Room = New System.Windows.Forms.Label()
        Me.ElevatorIcon = New System.Windows.Forms.PictureBox()
        Me.Title = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RM402 = New System.Windows.Forms.Button()
        Me.Pic402 = New System.Windows.Forms.PictureBox()
        Me.RM403 = New System.Windows.Forms.Button()
        Me.Pic403 = New System.Windows.Forms.PictureBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.DisconnectBtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.Pic401, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElevatorIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic402, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic403, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CallAssistBtn
        '
        Me.CallAssistBtn.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CallAssistBtn.Location = New System.Drawing.Point(-1, 375)
        Me.CallAssistBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CallAssistBtn.Name = "CallAssistBtn"
        Me.CallAssistBtn.Size = New System.Drawing.Size(340, 40)
        Me.CallAssistBtn.TabIndex = 42
        Me.CallAssistBtn.Text = "Call For Assistance"
        Me.CallAssistBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CallAssistBtn.UseVisualStyleBackColor = True
        '
        'RM401
        '
        Me.RM401.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RM401.Location = New System.Drawing.Point(39, 124)
        Me.RM401.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RM401.Name = "RM401"
        Me.RM401.Size = New System.Drawing.Size(300, 40)
        Me.RM401.TabIndex = 41
        Me.RM401.Text = "Room 401"
        Me.RM401.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RM401.UseVisualStyleBackColor = True
        '
        'CallE
        '
        Me.CallE.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CallE.Location = New System.Drawing.Point(39, 40)
        Me.CallE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CallE.Name = "CallE"
        Me.CallE.Size = New System.Drawing.Size(300, 40)
        Me.CallE.TabIndex = 39
        Me.CallE.Text = "Call Elevator"
        Me.CallE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CallE.UseVisualStyleBackColor = True
        '
        'Pic401
        '
        Me.Pic401.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic401.Image = Global.CPS613_Project_GroupB2.My.Resources.Resources.doorbell
        Me.Pic401.Location = New System.Drawing.Point(-1, 124)
        Me.Pic401.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Pic401.Name = "Pic401"
        Me.Pic401.Size = New System.Drawing.Size(40, 40)
        Me.Pic401.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic401.TabIndex = 38
        Me.Pic401.TabStop = False
        '
        'Room
        '
        Me.Room.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Room.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Room.Location = New System.Drawing.Point(-1, 82)
        Me.Room.Name = "Room"
        Me.Room.Size = New System.Drawing.Size(340, 40)
        Me.Room.TabIndex = 37
        Me.Room.Text = "Room"
        Me.Room.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ElevatorIcon
        '
        Me.ElevatorIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ElevatorIcon.Image = Global.CPS613_Project_GroupB2.My.Resources.Resources.elevator
        Me.ElevatorIcon.Location = New System.Drawing.Point(-1, 40)
        Me.ElevatorIcon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ElevatorIcon.Name = "ElevatorIcon"
        Me.ElevatorIcon.Size = New System.Drawing.Size(40, 40)
        Me.ElevatorIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ElevatorIcon.TabIndex = 35
        Me.ElevatorIcon.TabStop = False
        '
        'Title
        '
        Me.Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Title.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Title.Location = New System.Drawing.Point(-1, 0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(340, 40)
        Me.Title.TabIndex = 34
        Me.Title.Text = "Floor 4"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'RM402
        '
        Me.RM402.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RM402.Location = New System.Drawing.Point(39, 167)
        Me.RM402.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RM402.Name = "RM402"
        Me.RM402.Size = New System.Drawing.Size(300, 40)
        Me.RM402.TabIndex = 45
        Me.RM402.Text = "Room 402"
        Me.RM402.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RM402.UseVisualStyleBackColor = True
        '
        'Pic402
        '
        Me.Pic402.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic402.Image = Global.CPS613_Project_GroupB2.My.Resources.Resources.doorbell
        Me.Pic402.Location = New System.Drawing.Point(-1, 167)
        Me.Pic402.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Pic402.Name = "Pic402"
        Me.Pic402.Size = New System.Drawing.Size(40, 40)
        Me.Pic402.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic402.TabIndex = 44
        Me.Pic402.TabStop = False
        '
        'RM403
        '
        Me.RM403.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RM403.Location = New System.Drawing.Point(39, 211)
        Me.RM403.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RM403.Name = "RM403"
        Me.RM403.Size = New System.Drawing.Size(300, 40)
        Me.RM403.TabIndex = 47
        Me.RM403.Text = "Room 403"
        Me.RM403.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RM403.UseVisualStyleBackColor = True
        '
        'Pic403
        '
        Me.Pic403.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic403.Image = Global.CPS613_Project_GroupB2.My.Resources.Resources.doorbell
        Me.Pic403.Location = New System.Drawing.Point(-1, 211)
        Me.Pic403.Name = "Pic403"
        Me.Pic403.Size = New System.Drawing.Size(40, 40)
        Me.Pic403.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic403.TabIndex = 0
        Me.Pic403.TabStop = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'DisconnectBtn
        '
        Me.DisconnectBtn.Location = New System.Drawing.Point(240, 211)
        Me.DisconnectBtn.Name = "DisconnectBtn"
        Me.DisconnectBtn.Size = New System.Drawing.Size(99, 40)
        Me.DisconnectBtn.TabIndex = 48
        Me.DisconnectBtn.Text = "Disconnect"
        Me.DisconnectBtn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(331, 315)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 49
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Floor4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 415)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DisconnectBtn)
        Me.Controls.Add(Me.Pic403)
        Me.Controls.Add(Me.RM403)
        Me.Controls.Add(Me.RM402)
        Me.Controls.Add(Me.Pic402)
        Me.Controls.Add(Me.CallAssistBtn)
        Me.Controls.Add(Me.RM401)
        Me.Controls.Add(Me.CallE)
        Me.Controls.Add(Me.Pic401)
        Me.Controls.Add(Me.Room)
        Me.Controls.Add(Me.ElevatorIcon)
        Me.Controls.Add(Me.Title)
        Me.Name = "Floor4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "  "
        CType(Me.Pic401, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElevatorIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic402, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic403, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CallAssistBtn As Button
    Friend WithEvents RM401 As Button
    Friend WithEvents CallE As Button
    Friend WithEvents Pic401 As PictureBox
    Friend WithEvents Room As Label
    Friend WithEvents ElevatorIcon As PictureBox
    Friend WithEvents Title As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents RM402 As Button
    Friend WithEvents Pic402 As PictureBox
    Friend WithEvents RM403 As Button
    Friend WithEvents Pic403 As PictureBox
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents DisconnectBtn As Button
    Friend WithEvents Button1 As Button
End Class

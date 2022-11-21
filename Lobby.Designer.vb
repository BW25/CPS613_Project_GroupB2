<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lobby
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
        Me.CallAssistBtn = New System.Windows.Forms.Button()
        Me.CallE = New System.Windows.Forms.Button()
        Me.Front = New System.Windows.Forms.Button()
        Me.ElevatorIcon = New System.Windows.Forms.PictureBox()
        Me.FrontIcon = New System.Windows.Forms.PictureBox()
        Me.Title = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        CType(Me.ElevatorIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FrontIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'CallE
        '
        Me.CallE.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CallE.Location = New System.Drawing.Point(39, 80)
        Me.CallE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CallE.Name = "CallE"
        Me.CallE.Size = New System.Drawing.Size(300, 40)
        Me.CallE.TabIndex = 20
        Me.CallE.Text = "Call Elevator"
        Me.CallE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CallE.UseVisualStyleBackColor = True
        '
        'Front
        '
        Me.Front.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Front.Location = New System.Drawing.Point(39, 40)
        Me.Front.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Front.Name = "Front"
        Me.Front.Size = New System.Drawing.Size(300, 40)
        Me.Front.TabIndex = 19
        Me.Front.Text = "Open Front Door"
        Me.Front.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Front.UseVisualStyleBackColor = True
        '
        'ElevatorIcon
        '
        Me.ElevatorIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ElevatorIcon.Image = Global.CPS613_Project_GroupB2.My.Resources.Resources.elevator
        Me.ElevatorIcon.Location = New System.Drawing.Point(0, 80)
        Me.ElevatorIcon.Name = "ElevatorIcon"
        Me.ElevatorIcon.Size = New System.Drawing.Size(40, 40)
        Me.ElevatorIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ElevatorIcon.TabIndex = 24
        Me.ElevatorIcon.TabStop = False
        '
        'FrontIcon
        '
        Me.FrontIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FrontIcon.Image = Global.CPS613_Project_GroupB2.My.Resources.Resources.slidingclosed
        Me.FrontIcon.Location = New System.Drawing.Point(0, 40)
        Me.FrontIcon.Name = "FrontIcon"
        Me.FrontIcon.Size = New System.Drawing.Size(40, 40)
        Me.FrontIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.FrontIcon.TabIndex = 25
        Me.FrontIcon.TabStop = False
        '
        'Title
        '
        Me.Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Title.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Title.Location = New System.Drawing.Point(-1, 0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(340, 40)
        Me.Title.TabIndex = 14
        Me.Title.Text = "Lobby"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Lobby
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 415)
        Me.Controls.Add(Me.CallAssistBtn)
        Me.Controls.Add(Me.CallE)
        Me.Controls.Add(Me.Front)
        Me.Controls.Add(Me.ElevatorIcon)
        Me.Controls.Add(Me.FrontIcon)
        Me.Controls.Add(Me.Title)
        Me.Name = "Lobby"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lobby"
        CType(Me.ElevatorIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FrontIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CallAssistBtn As Button
    Friend WithEvents CallE As Button
    Friend WithEvents Front As Button
    Friend WithEvents ElevatorIcon As PictureBox
    Friend WithEvents FrontIcon As PictureBox
    Friend WithEvents Title As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents NotifyIcon1 As NotifyIcon
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Floor5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Floor5))
        Me.CallAssistBtn = New System.Windows.Forms.Button()
        Me.RM502 = New System.Windows.Forms.Button()
        Me.CallE = New System.Windows.Forms.Button()
        Me.Pic502 = New System.Windows.Forms.PictureBox()
        Me.Title2 = New System.Windows.Forms.Label()
        Me.ElevatorIcon = New System.Windows.Forms.PictureBox()
        Me.Title = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RM501 = New System.Windows.Forms.Button()
        Me.Pic501 = New System.Windows.Forms.PictureBox()
        Me.RM503 = New System.Windows.Forms.Button()
        Me.Pic503 = New System.Windows.Forms.PictureBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        CType(Me.Pic502, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElevatorIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic501, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic503, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CallAssistBtn
        '
        Me.CallAssistBtn.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CallAssistBtn.Location = New System.Drawing.Point(-1, 375)
        Me.CallAssistBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CallAssistBtn.Name = "CallAssistBtn"
        Me.CallAssistBtn.Size = New System.Drawing.Size(340, 40)
        Me.CallAssistBtn.TabIndex = 32
        Me.CallAssistBtn.Text = "Call For Assistance"
        Me.CallAssistBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CallAssistBtn.UseVisualStyleBackColor = True
        '
        'RM502
        '
        Me.RM502.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RM502.Location = New System.Drawing.Point(39, 167)
        Me.RM502.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RM502.Name = "RM502"
        Me.RM502.Size = New System.Drawing.Size(300, 40)
        Me.RM502.TabIndex = 31
        Me.RM502.Text = "Room 502"
        Me.RM502.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RM502.UseVisualStyleBackColor = True
        '
        'CallE
        '
        Me.CallE.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CallE.Location = New System.Drawing.Point(39, 40)
        Me.CallE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CallE.Name = "CallE"
        Me.CallE.Size = New System.Drawing.Size(300, 40)
        Me.CallE.TabIndex = 29
        Me.CallE.Text = "Call Elevator"
        Me.CallE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CallE.UseVisualStyleBackColor = True
        '
        'Pic502
        '
        Me.Pic502.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic502.Image = Global.CPS613_Project_GroupB2.My.Resources.Resources.doorbell
        Me.Pic502.Location = New System.Drawing.Point(-1, 167)
        Me.Pic502.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Pic502.Name = "Pic502"
        Me.Pic502.Size = New System.Drawing.Size(40, 40)
        Me.Pic502.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic502.TabIndex = 28
        Me.Pic502.TabStop = False
        '
        'Title2
        '
        Me.Title2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Title2.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Title2.Location = New System.Drawing.Point(-1, 82)
        Me.Title2.Name = "Title2"
        Me.Title2.Size = New System.Drawing.Size(340, 40)
        Me.Title2.TabIndex = 27
        Me.Title2.Text = "Room"
        Me.Title2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.ElevatorIcon.TabIndex = 25
        Me.ElevatorIcon.TabStop = False
        '
        'Title
        '
        Me.Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Title.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Title.Location = New System.Drawing.Point(-1, 0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(340, 40)
        Me.Title.TabIndex = 24
        Me.Title.Text = "Floor 5"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'RM501
        '
        Me.RM501.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RM501.Location = New System.Drawing.Point(39, 124)
        Me.RM501.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RM501.Name = "RM501"
        Me.RM501.Size = New System.Drawing.Size(300, 40)
        Me.RM501.TabIndex = 35
        Me.RM501.Text = "Room 501"
        Me.RM501.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RM501.UseVisualStyleBackColor = True
        '
        'Pic501
        '
        Me.Pic501.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic501.Image = Global.CPS613_Project_GroupB2.My.Resources.Resources.doorbell
        Me.Pic501.Location = New System.Drawing.Point(-1, 124)
        Me.Pic501.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Pic501.Name = "Pic501"
        Me.Pic501.Size = New System.Drawing.Size(40, 40)
        Me.Pic501.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic501.TabIndex = 34
        Me.Pic501.TabStop = False
        '
        'RM503
        '
        Me.RM503.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RM503.Location = New System.Drawing.Point(39, 211)
        Me.RM503.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RM503.Name = "RM503"
        Me.RM503.Size = New System.Drawing.Size(300, 40)
        Me.RM503.TabIndex = 37
        Me.RM503.Text = "Room 503"
        Me.RM503.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RM503.UseVisualStyleBackColor = True
        '
        'Pic503
        '
        Me.Pic503.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic503.Image = Global.CPS613_Project_GroupB2.My.Resources.Resources.entrance_icon
        Me.Pic503.Location = New System.Drawing.Point(-1, 211)
        Me.Pic503.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Pic503.Name = "Pic503"
        Me.Pic503.Size = New System.Drawing.Size(40, 40)
        Me.Pic503.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic503.TabIndex = 36
        Me.Pic503.TabStop = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Floor5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 415)
        Me.Controls.Add(Me.RM503)
        Me.Controls.Add(Me.Pic503)
        Me.Controls.Add(Me.RM501)
        Me.Controls.Add(Me.Pic501)
        Me.Controls.Add(Me.CallAssistBtn)
        Me.Controls.Add(Me.RM502)
        Me.Controls.Add(Me.CallE)
        Me.Controls.Add(Me.Pic502)
        Me.Controls.Add(Me.Title2)
        Me.Controls.Add(Me.ElevatorIcon)
        Me.Controls.Add(Me.Title)
        Me.Name = "Floor5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Floor5"
        CType(Me.Pic502, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElevatorIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic501, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic503, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CallAssistBtn As Button
    Friend WithEvents RM502 As Button
    Friend WithEvents CallE As Button
    Friend WithEvents Pic502 As PictureBox
    Friend WithEvents Title2 As Label
    Friend WithEvents ElevatorIcon As PictureBox
    Friend WithEvents Title As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents RM501 As Button
    Friend WithEvents Pic501 As PictureBox
    Friend WithEvents RM503 As Button
    Friend WithEvents Pic503 As PictureBox
    Friend WithEvents NotifyIcon1 As NotifyIcon
End Class

Public Class Floor5

    ' This section of Code handles the scanning activity
    ' Adjust it so all of your buttons are listed in Form1_Load in the order you want to scan through them
    ' TODO: Add handlers for each button.Click- This is what happens when space is tapped over the button

    ' List of buttons to move through on key press
    Shared Buttons() As Button

    ' Currently selected button
    Shared SelectedButton As Integer

    'Checks if the timer has already ticked. Used to differentiate between scanning and clicking a button
    Shared HasTicked As Boolean

    ' Set up timer that triggers when a button is held
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Set up timer to go off when a button is held for half a second
        Timer1.Interval = 500
        Timer1.Stop()

        'Set up buttons on this page to iterate through
        ' TODO: Change for each page
        Buttons = {CallE, RM501, RM502, RM503, ControlAptBtn, CallAssistBtn}
        SelectedButton = 0
    End Sub

    'A key has been held for more 500msec
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        SelectedButton = (SelectedButton + 1) Mod Buttons.Length
        Buttons(SelectedButton).Focus()
        HasTicked = True
    End Sub


    'Check if a key has been tapped
    Private Sub KeyUp(sender As Object, e As KeyEventArgs) Handles CallE.KeyUp, RM502.KeyUp, ControlAptBtn.KeyUp, CallAssistBtn.KeyUp, RM501.KeyUp, RM503.KeyUp
        ' If the HoldTimer hasn't gone off yet and the key is raised, the button was tapped
        If Timer1.Enabled Then
            Timer1.Stop()
            HasTicked = False
        End If

    End Sub


    ' Handles key pushed down, starts timer to determine if it is being tapped or held
    ' TODO: Make sure all of the buttons in your form are have their KeyDown event being handled here
    Private Sub KeyDown(sender As Object, e As KeyEventArgs) Handles CallE.KeyDown, RM502.KeyDown, ControlAptBtn.KeyDown, CallAssistBtn.KeyDown, RM501.KeyDown, RM503.KeyDown
        Timer1.Start()
    End Sub

    ' TODO: This is a template of how to implement a button click
    ' Be sure all code is inside the If statement given to differentiate between scanning and clicking
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CallE.Click
        If Not HasTicked Then
            Buttons(SelectedButton).Text = "Front Door Opened"
            Elevator.Show()
            Close()


        End If
    End Sub

    Private Sub CallAssistBtn_Click(sender As Object, e As EventArgs) Handles CallAssistBtn.Click
        If Not HasTicked Then
            If CallAssistBtn.Tag = 1 Then
                CallAssistBtn.BackColor = Color.Red
                CallAssistBtn.Tag = 0
                NotifyIcon1.BalloonTipText = "ASSISTANCE REQUEST SENT"
                NotifyIcon1.BalloonTipTitle = "ASSISTANCE"
                NotifyIcon1.Visible = True
                NotifyIcon1.ShowBalloonTip(0)
            Else
                CallAssistBtn.BackColor = System.Drawing.SystemColors.Control
                CallAssistBtn.Tag = 1
                NotifyIcon1.BalloonTipText = "ASSISTANCE REQUEST CANCELED"
                NotifyIcon1.BalloonTipTitle = "ASSISTANCE"
                NotifyIcon1.Visible = True
                NotifyIcon1.ShowBalloonTip(0)
            End If
        End If
    End Sub
End Class

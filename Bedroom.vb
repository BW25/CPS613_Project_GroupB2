Public Class Bedroom
    Shared Buttons() As Button

    Shared SelectedButton As Integer

    'Checks if the timer has already ticked. Used to differentiate between scanning and clicking a button
    Shared HasTicked As Boolean

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Set up timer to go off when a button is held for half a second
        Timer1.Interval = 500
        Timer1.Stop()

        'Set up buttons on this page to iterate through
        ' TODO: Change for each page
        Buttons = {GoToBedBtn, WakeUpBtn, KitchenBtn, ControlAptBtn, CallAssistBtn}
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
    Private Sub KeyUp(sender As Object, e As KeyEventArgs) Handles GoToBedBtn.KeyUp, WakeUpBtn.KeyUp, KitchenBtn.KeyUp, ControlAptBtn.KeyUp, CallAssistBtn.KeyUp
        ' If the HoldTimer hasn't gone off yet and the key is raised, the button was tapped
        If Timer1.Enabled Then
            Timer1.Stop()
            HasTicked = False
        End If
    End Sub


    ' Handles key pushed down, starts timer to determine if it is being tapped or held
    ' TODO: Make sure all of the buttons in your form are have their KeyDown event being handled here
    Private Sub KeyDown(sender As Object, e As KeyEventArgs) Handles GoToBedBtn.KeyDown, WakeUpBtn.KeyDown, KitchenBtn.KeyDown, ControlAptBtn.KeyDown, CallAssistBtn.KeyDown
        Timer1.Start()
    End Sub

    ' TODO: This is a template of how to implement a button click
    ' Be sure all code is inside the If statement given to differentiate between scanning and clicking
    Private Sub GoToBedBtn_Click(sender As Object, e As EventArgs) Handles GoToBedBtn.Click
        If Not HasTicked Then
            MessageBox.Show("Assistant has been called", "Declare intention to sleep", MessageBoxButtons.OK)
            SelectedButton = 0
            Buttons(SelectedButton).Focus()
        End If
    End Sub

    Private Sub WakeUpBtnBtn_Click(sender As Object, e As EventArgs) Handles WakeUpBtn.Click
        If Not HasTicked Then
            MessageBox.Show("Assistant has been called", "Declare intention to get up", MessageBoxButtons.OK)
            SelectedButton = 1
            Buttons(SelectedButton).Focus()
        End If
    End Sub

    Private Sub ControlAptBtn_Click(sender As Object, e As EventArgs) Handles ControlAptBtn.Click
        If Not HasTicked Then
            ControlAptBtn.Show()
            Hide()
        End If
    End Sub
End Class
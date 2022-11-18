Imports System.Threading

Public Class ControlApartment
    Shared Buttons() As Button

    ' Currently selected button
    Shared SelectedButton As Integer

    'Checks if the timer has already ticked. Used to differentiate between scanning and clicking a button
    Shared HasTicked As Boolean

    ' Set up timer that triggers when a button is held

    'temperature status
    Dim tempStatus As Integer = 25
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Set up timer to go off when a button is held for half a second
        Timer1.Interval = 500
        Timer1.Stop()

        'Set up buttons on this page to iterate through
        ' TODO: Change for each page
        Buttons = {IncTempBtn, DecTempBtn, HumidityBtn, FanBtn, BedroomBtn, KitchenBtn, BackBtn, CallAssistBtn}
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
    Private Sub KeyUp(sender As Object, e As KeyEventArgs) Handles IncTempBtn.KeyUp, DecTempBtn.KeyUp, HumidityBtn.KeyUp, FanBtn.KeyUp, BedroomBtn.KeyUp, KitchenBtn.KeyUp, BackBtn.KeyUp, CallAssistBtn.KeyUp
        ' If the HoldTimer hasn't gone off yet and the key is raised, the button was tapped
        If Timer1.Enabled Then
            Timer1.Stop()
            HasTicked = False
        End If
    End Sub


    ' Handles key pushed down, starts timer to determine if it is being tapped or held
    ' TODO: Make sure all of the buttons in your form are have their KeyDown event being handled here
    Private Sub KeyDown(sender As Object, e As KeyEventArgs) Handles IncTempBtn.KeyDown, DecTempBtn.KeyDown, HumidityBtn.KeyDown, FanBtn.KeyDown, BedroomBtn.KeyDown, KitchenBtn.KeyDown, BackBtn.KeyDown, CallAssistBtn.KeyDown
        Timer1.Start()
    End Sub

    ' TODO: This is a template of how to implement a button click
    ' Be sure all code is inside the If statement given to differentiate between scanning and clicking
    Private Sub IncTempBtn_Click(sender As Object, e As EventArgs) Handles IncTempBtn.Click
        If Not HasTicked Then
            tempStatus += 1
            TempLabel.Text = tempStatus
        End If
    End Sub

    Private Sub DecTempBtn_Click(sender As Object, e As EventArgs) Handles DecTempBtn.Click
        If Not HasTicked Then
            tempStatus -= 1
            TempLabel.Text = tempStatus
        End If
    End Sub

    Private Sub HumidityBtn_Click(sender As Object, e As EventArgs) Handles HumidityBtn.Click
        If Not HasTicked Then
            If HumidityBtn.Text = "Humidity- (On)" Then
                HumidityBtn.Text = "Humidity- (Off)"
            Else
                HumidityBtn.Text = "Humidity- (On)"
            End If
        End If
    End Sub

    Private Sub FanBtn_Click(sender As Object, e As EventArgs) Handles FanBtn.Click
        If Not HasTicked Then
            If FanBtn.Text = "Fans- (On)" Then
                FanBtn.Text = "Fans- (Off)"
            Else
                FanBtn.Text = "Fans- (On)"
            End If
        End If
    End Sub

    Private Sub BedroomBtn_Click(sender As Object, e As EventArgs) Handles BedroomBtn.Click, KitchenBtn.Click
        If Not HasTicked Then
            Bedroom.Show()
            Close()
        End If
    End Sub

End Class
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class doorbell

    ' This section of Code handles the scanning activity
    ' Adjust it so all of your buttons are listed in Form1_Load in the order you want to scan through them
    ' TODO: Add handlers for each button.Click- This is what happens when space is tapped over the button

    ' List of buttons to move through on key press
    Shared Buttons() As System.Windows.Forms.Button

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
        Buttons = {respondbtn, ignorebtn, endbtn}
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
    Private Sub KeyUp(sender As Object, e As KeyEventArgs) Handles respondbtn.KeyUp, ignorebtn.KeyUp, endbtn.KeyUp
        ' If the HoldTimer hasn't gone off yet and the key is raised, the button was tapped
        If Timer1.Enabled Then
            Timer1.Stop()
            HasTicked = False
        End If

    End Sub


    ' Handles key pushed down, starts timer to determine if it is being tapped or held
    ' TODO: Make sure all of the buttons in your form are have their KeyDown event being handled here
    Private Sub KeyDown(sender As Object, e As KeyEventArgs) Handles respondbtn.KeyDown, ignorebtn.KeyDown, endbtn.KeyDown
        Timer1.Start()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles respondbtn.Click

        MyBase.BackColor = Color.Red
        info.Text = "TALKING"
        respondbtn.Visible = False
        ignorebtn.Visible = False
        endbtn.Visible = True


    End Sub

    Private Sub doorbell_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.Beep(200, 1000)
        respondbtn.Visible = True
        ignorebtn.Visible = True
        endbtn.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ignorebtn.Click
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles endbtn.Click
        Me.Close()
    End Sub
End Class
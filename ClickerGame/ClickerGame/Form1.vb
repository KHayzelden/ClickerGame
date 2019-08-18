Public Class Form1

    Dim RandomNumber As Integer 'the variable for the x cordinate of picture 1
    Dim RandomNumber2 As Integer 'the variable for the y cordiante of picture 1

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        Dim RandomClass As New Random()

        RandomNumber = RandomClass.Next(750)
        'Creates number for the x axis
        RandomNumber2 = RandomClass.Next(450)
        'Creates number for the y axis

        PictureBox1.Location = New Point(RandomNumber, RandomNumber2) 'sends the "bug" to the new x,y cordinates        Score.Text += 1 'adds one to the score
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        TimeLeft.Text -= 1 'removes 1 digit from the timer count


        If (TimeLeft.Text = 0) Then 'checks for when the time left counter hits 0
            Timer1.Enabled = False 'stops the timer
            PictureBox1.Visible = False 'hides the "bug"
            MsgBox("TIME UP ~ LOL N00B U GOT " & Score.Text & " PNTS") 'prints a game over message and the score
        End If

    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click

        StartButton.Visible = False 'hides the start button when the game begins
        PictureBox1.Visible = True 'shows the "bug"
        Timer1.Enabled = True 'starts the timer


    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        Dim Counter As Integer = 0
        Dim RandomDirection As New Random()

        If (RandomNumber > 750 Or RandomNumber2 > 450) Then
            RandomNumber += RandomDirection.Next(20) 'generates a new random direction to go to if the x or y is too high (which would take it off screen) 
            RandomNumber2 += RandomDirection.Next(20)
        Else
            RandomNumber += 10
            RandomNumber2 += 10
        End If

        PictureBox1.Location = New Point(RandomNumber, RandomNumber2) 'slides the bug gradually to the cordinate

    End Sub
End Class

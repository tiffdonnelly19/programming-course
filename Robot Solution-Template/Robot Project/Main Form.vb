' Project name:         Robot Project
' Project purpose:      Guess where a robot is hiding
' Created/revised by:   Tiffany Donnelly on 10/5/2018

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    ' class-level variable 
    Private randomInteger As Integer

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub hideButton_Click(sender As Object, e As EventArgs) Handles hideButton.Click
        ' prepares the interface
        Dim robot As New Random


        ' generate a random integer from 1 through 3
        randomInteger = robot.Next(1, 4)
 


        ' display the closed door image
        door1PictureBox.Image = closedPictureBox.Image
        door2PictureBox.Image = closedPictureBox.Image
        door3PictureBox.Image = closedPictureBox.Image

    End Sub

    Private Sub door1PictureBox_Click(sender As Object, e As EventArgs) Handles door1PictureBox.Click
        ' displays the appropriate image
        If randomInteger = 1 Then
            door1PictureBox.Image = robotPictureBox.Image
        Else
            door1PictureBox.Image = openPictureBox.Image

        End If

    End Sub

    Private Sub door2PictureBox_Click(sender As Object, e As EventArgs) Handles door2PictureBox.Click
        ' displays the appropriate image
        If randomInteger = 2 Then
            door2PictureBox.Image = robotPictureBox.Image
        Else
            door2PictureBox.Image = openPictureBox.Image

        End If

    End Sub

    Private Sub door3PictureBox_Click(sender As Object, e As EventArgs) Handles door3PictureBox.Click
        ' displays the appropriate image
        If randomInteger = 3 Then
            door3PictureBox.Image = robotPictureBox.Image
        Else
            door3PictureBox.Image = openPictureBox.Image

        End If

    End Sub

	Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

    Private Sub closedPictureBox_Click(sender As Object, e As EventArgs) Handles closedPictureBox.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class

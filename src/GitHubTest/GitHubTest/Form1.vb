﻿Public Class Form1

    Public Sub SayHello()
        Me.SayHello(String.Format("{0} {1}", Me.txtName.Text, Me.txtLastName.Text))
    End Sub

    Private Sub SayHello(name As String)
        Dim hw As New HelloWorld
        hw.SayHelloToWorld(name)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.SayHello()
    End Sub

    Private Sub txtName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtName.KeyDown, txtLastName.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SayHello()
        End If
    End Sub

End Class

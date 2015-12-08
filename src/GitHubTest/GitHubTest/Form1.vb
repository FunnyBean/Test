Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim hw As New HelloWorld
        hw.SayHelloToWorld(Me.txtName.Text)
    End Sub

End Class

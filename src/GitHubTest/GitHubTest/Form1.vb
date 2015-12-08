Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim hw As New HelloWorld
        hw.SayHelloToWorld(String.Format("{0} {1}", Me.txtName.Text, Me.txtLastName.Text))
    End Sub

End Class

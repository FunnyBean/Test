Public Class HelloWorld

    Public Sub SayHelloToWorld()
        MessageBox.Show("Hello World")
    End Sub

    Public Sub SayHelloToWorld(name As String)
        MessageBox.Show("Hello World", String.Format("{0} says", If(String.IsNullOrEmpty(name), "Who", name)))
    End Sub

End Class

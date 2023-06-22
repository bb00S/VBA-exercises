Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim random As New Random()
        Dim chars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*"
        Dim password As String = New String(Enumerable.Repeat(chars, 10).[Select](Function(s) s(random.[Next](s.Length))).ToArray())
        TextBox1.Text = password
    End Sub
End Class

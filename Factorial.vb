Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim number As Integer = Convert.ToInt32(TextBox1.Text)
        Dim factorial As Integer = 1
        For i As Integer = 1 To number
            factorial = factorial * i
        Next
        TextBox2.Text = factorial.ToString()
    End Sub
End Class 

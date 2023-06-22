Public Class Form1
    Private Sub Button1Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim broj, X, Y, C, suma As Integer
        broj = Int(TextBox1.Text)
        If broj < 1 Then
            MessageBox.Show("Broj nije prirodan!")
        End If
        X = (broj - (broj Mod 100)) / 100
        Y = ((broj Mod 100) - (broj Mod 10)) / 10
        C = (broj Mod 10)
        suma = (X * X * X) + (Y * Y * Y) + (C * C * C)
        If suma = broj Then
            TextBox2.Text = "Broj je Armstrongov."
        Else
            TextBox2.Text = "Broj nije Armstrongov."
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class

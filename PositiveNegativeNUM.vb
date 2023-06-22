Public Class Form1
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a As Integer
        a = Val(TextBox1.Text)
        If (a >= 0) Then
            MsgBox("Dati broj  " & a & " je POZITIVAN BROJ.")
        Else
            MsgBox("Dati broj  " & a & " je NEGATIVAN BROJ.")
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox1.Focus()
    End Sub
End Class

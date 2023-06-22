Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim y As Integer
        y = Val(TextBox1.Text)
        If y Mod 100 = 0 Then
            If y Mod 400 = 0 Then
                Label2.Text = "Data godina " & y & " je PRESTUPNA."
            Else
                Label2.Text = "Data godina " & y & " NIJE PRESTUPNA."
            End If
        Else
            If y Mod 4 = 0 Then
                Label2.Text = "Data godina " & y & " je PRESTUPNA."
            Else
                Label2.Text = "Data godina " & y & " NIJE PRESTUPNA."
            End If
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        Label2.Text = ""
        TextBox1.Focus()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As  System.EventArgs) Handles Button3.Click
        End
    End Sub
End Class 

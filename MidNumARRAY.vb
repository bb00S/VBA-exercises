Public Class Form1
	Dim i As Integer
	Dim suma As Integer
	Dim granica As Integer
	Dim j As Integer
	Dim niz(100) As Double
	Dim ars As Double
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		granica = TextBox1.Text
		For i = 1 To granica
			niz(i) = InputBox(“unesi vrijednost člana niza: ”)
			ListBox1.Items.Add(niz(i))
		Next
	End Sub
	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		suma = 0
		For i = 1 To granica
			suma = suma + niz(i)
		Next
		ars = suma / granica
		TextBox2.Text = ars.ToString
	End Sub
	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		For i = 1 To granica
			If niz(i) > ars Then
				Label2.Text = Label2.Text + “,” + niz(i).ToString
			End If
		Next
	End Sub
End Class

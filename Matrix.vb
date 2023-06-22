Public Class Form1
	Dim M(10, 10) As Double
	Dim M1(10, 10) As Double
	Dim M2(10, 10) As Double
	Dim i, j, n, s As Integer
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		n = InputBox(“unesi broj redova i kolona matrice”, ”velicina matrice”)
		For i = 1 To n
			For j = 1 To n
				M(i, j) = InputBox(“unesi broj za element u” + CStr(i) + ”redu i” + CStr(j) + ”koloni”)
				ListBox1.Items.Add(CStr(i) + ”.” + CStr(j) + ”=” + CStr(M(i, j)))
			Next
		Next
	End Sub
	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		s = InputBox(“unesi broj redova i kolona matrice”, ”velicina matrice”)
		If n <> s Then
			MessageBox.Show(“broj redova i kolona matrice nece biti jednak!”)
		Else
			For i = 1 To s
				For j = 1 To s
					M1(i, j) = InputBox(“unesi broj za element u” + CStr(i) + ”redu i” + CStr(j) + ”koloni”)
					ListBox2.Items.Add(CStr(i) + ”.” + CStr(j) + ”=” + CStr(M1(i, j)))
				Next
			Next
		End If
	End Sub
	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		For i = 1 To n
			For j = 1 To n
				ListBox3.Items.Add(CStr(i) + ”.” + CStr(j) + ”=” + CStr(M(i, j) + M1(i, j)))
			Next
		Next
	End Sub
Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
		For i = 1 To n
			For j = 1 To n
				ListBox4.Items.Add(CStr(i) + ”.” + CStr(j) + ”=” + CStr(M(i, j) - M1(i, j)))
			Next
		Next
	End Sub
End Class

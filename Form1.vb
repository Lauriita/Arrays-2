Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim a = New Integer() {-1, -2, -3, -4, 1, 2, 4, 8, 9}
        Dim linea As Integer = 0
        Dim cadena As String
        Dim guardar As String



        For i As Integer = 0 To 8

            linea = linea + 1
            cadena = (guardar & i & "=" & a(i) & " El cuadrado es = " & a(i) ^ 2 & "  cubo es = " & a(i) ^ 3 & vbNewLine)
            guardar = cadena

        Next

        TextBox1.Text = cadena




    End Sub
End Class

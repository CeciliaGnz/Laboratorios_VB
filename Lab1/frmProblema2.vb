Public Class frmProblema2
    Dim hombresPorc, mujeresPorc As Double
    Dim conducTot, contH, contM As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim genero, edad As Integer
        genero = Val(txtGenero.Text)
        edad = Val(txtEdad.Text)
        If genero <> 0 Then
            If (genero = 1) Then
                contM += 1
                If (edad > 18 And edad < 25) Then
                    mujeresPorc += 1
                End If
            ElseIf (genero = 2) Then
                contH += 1
                If (edad > 40) Then
                    hombresPorc += 1
                End If
            End If
            txtEdad.Clear()
            txtGenero.Clear()
        Else
            conducTot = contH + contM
            hombresPorc = (CDbl(hombresPorc / conducTot)) * 100
            mujeresPorc = (CDbl(mujeresPorc / conducTot)) * 100
            txtHombres.Text = (hombresPorc & "%")
            txtMujeres.Text = (mujeresPorc & "%")
            txtTotales.Text = "Total de mujeres: " & contM & "     Total de hombres: " & contH
        End If
    End Sub
End Class

Public Class frmProblema1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim costoInicial As Double
        Dim costoFinal As Double
        costoInicial = Val(txtCostoInicial.Text)

        costoFinal = costoInicial + ((costoInicial * 0.12) + (costoInicial * 0.06))

        txtCostoTotal.Text = costoFinal
    End Sub
End Class
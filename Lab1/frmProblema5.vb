Public Class frmProblema5

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim costoInicial, cantidadA, montoI, montoD, montoF As Double
        costoInicial = Val(txtPrecioU.Text)
        cantidadA = Val(txtCantA.Text)
        If rdbOpcE.Checked = True Then
            montoI = costoInicial * cantidadA
            montoD = montoI * (12.4 / 100)
            montoF = montoI - montoD
            txtMontoI.Text = "$" & montoI
            txtMontoD.Text = "$" & montoD
            txtMontoF.Text = "$" & montoF

        ElseIf rdbOpcCh.Checked = True Then
            montoI = costoInicial * cantidadA
            montoD = montoI * (8.6 / 100)
            montoF = montoI - montoD
            txtMontoI.Text = "$" & montoI
            txtMontoD.Text = "$" & montoD
            txtMontoF.Text = "$" & montoF

        ElseIf rdbOpcTC.Checked = True Then
            montoI = costoInicial * cantidadA
            montoD = montoI * (4.5 / 100)
            montoF = montoI - montoD
            txtMontoI.Text = "$" & montoI
            txtMontoD.Text = "$" & montoD
            txtMontoF.Text = "$" & montoF

        ElseIf rdbOpcTD.Checked = True Then
            montoI = costoInicial * cantidadA
            montoD = montoI * (2.5 / 100)
            montoF = montoI - montoD
            txtMontoI.Text = "$" & montoI
            txtMontoD.Text = "$" & montoD
            txtMontoF.Text = "$" & montoF
        End If
    End Sub

End Class
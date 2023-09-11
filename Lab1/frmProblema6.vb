Public Class frmProblema6
    Dim votosJuan, votosAneth, votosRamses, votosCecilia As Integer

    Private Sub btnCecilia_Click(sender As Object, e As EventArgs) Handles btnCecilia.Click
        votosCecilia += 1
    End Sub

    Private Sub btnRamses_Click(sender As Object, e As EventArgs) Handles btnRamses.Click
        votosRamses += 1
    End Sub

    Private Sub btnAneth_Click(sender As Object, e As EventArgs) Handles btnAneth.Click
        votosAneth += 1
    End Sub

    Private Sub btnJuan_Click(sender As Object, e As EventArgs) Handles btnJuan.Click
        votosJuan += 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim candidatos As New Dictionary(Of String, Integer)()
        Dim nombreGanador, nombrePerdedor As String
        Dim votosGanador, votosPerdedor As Integer
        candidatos.Add("Cecilia", votosCecilia)
        candidatos.Add("Juan", votosJuan)
        candidatos.Add("Ramses", votosRamses)
        candidatos.Add("Aneth", votosAneth)
        votosGanador = candidatos.Values.Max()
        votosPerdedor = candidatos.Values.Min()
        nombreGanador = candidatos.FirstOrDefault(Function(x) x.Value = votosGanador).Key
        nombrePerdedor = candidatos.FirstOrDefault(Function(x) x.Value = votosPerdedor).Key

        txtGanador.Text = nombreGanador
        txtPerdedor.Text = nombrePerdedor
        txtVotosG.Text = votosGanador
        txtVotosP.Text = votosPerdedor

    End Sub

End Class
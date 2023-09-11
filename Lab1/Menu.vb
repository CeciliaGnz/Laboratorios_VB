Public Class Menu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmProblema1.Show()
        frmProblema2.Close()
        frmProblema3.Close()
        frmProblema4.Close()
        frmProblema5.Close()
        frmProblema6.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmProblema2.Show()
        frmProblema1.Close()
        frmProblema3.Close()
        frmProblema4.Close()
        frmProblema5.Close()
        frmProblema6.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmProblema3.Show()
        frmProblema1.Close()
        frmProblema2.Close()
        frmProblema4.Close()
        frmProblema5.Close()
        frmProblema6.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        frmProblema4.Show()
        frmProblema1.Close()
        frmProblema2.Close()
        frmProblema3.Close()
        frmProblema5.Close()
        frmProblema6.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        frmProblema5.Show()
        frmProblema1.Close()
        frmProblema2.Close()
        frmProblema3.Close()
        frmProblema4.Close()
        frmProblema6.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        frmProblema6.Show()
        frmProblema1.Close()
        frmProblema2.Close()
        frmProblema3.Close()
        frmProblema4.Close()
        frmProblema5.Close()
    End Sub

End Class
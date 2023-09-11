Public Class frmProblema3

    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click
        Dim num, sumDiv As Integer
        num = Val(txtNum.Text)
        sumDiv = 0
        For i = 1 To num - 1
            If num Mod i = 0 Then
                sumDiv += i
            End If
        Next
        If sumDiv = num Then
            MsgBox("Este es un numero perfecto")
        Else
            MsgBox("Este no es un numero perfecto")
        End If

    End Sub
End Class
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar

Public Class frmProblema4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numero As Integer
        numero = Val(txtNumero.Text)

        Dim secuencia As New List(Of Integer)
        secuencia.Add(numero)

        While numero <> 1
            If numero Mod 2 = 0 Then ' par dividir por 2.
                numero = numero \ 2
            Else 'impar, multiplicar por 3 y sumar 1.
                numero = (numero * 3) + 1
            End If
            secuencia.Add(numero)
        End While

        lstNumeros.Items.Clear()

        'cantidad de elementos en la lista secuencia.
        Dim count As Integer = secuencia.Count
        For i As Integer = 0 To count - 1
            lstNumeros.Items.Add(secuencia(i))
        Next
    End Sub
End Class

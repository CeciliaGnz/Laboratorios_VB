<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProblema3
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        txtNum = New TextBox()
        btnValidar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(318, 51)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(299, 25)
        Label1.TabIndex = 0
        Label1.Text = "Validador de Numeros Perfectos"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(330, 172)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 21)
        Label2.TabIndex = 1
        Label2.Text = "Numero"
        ' 
        ' txtNum
        ' 
        txtNum.Location = New Point(427, 170)
        txtNum.Margin = New Padding(4, 3, 4, 3)
        txtNum.Name = "txtNum"
        txtNum.Size = New Size(116, 23)
        txtNum.TabIndex = 2
        ' 
        ' btnValidar
        ' 
        btnValidar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnValidar.Location = New Point(427, 231)
        btnValidar.Margin = New Padding(4, 3, 4, 3)
        btnValidar.Name = "btnValidar"
        btnValidar.Size = New Size(112, 39)
        btnValidar.TabIndex = 3
        btnValidar.Text = "Validar"
        btnValidar.UseVisualStyleBackColor = True
        ' 
        ' frmProblema3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(933, 519)
        Controls.Add(btnValidar)
        Controls.Add(txtNum)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(4, 3, 4, 3)
        Name = "frmProblema3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNum As TextBox
    Friend WithEvents btnValidar As Button
End Class

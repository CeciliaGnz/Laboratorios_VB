<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProblema1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCostoInicial = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCostoTotal = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Costo del Vehículo"
        '
        'txtCostoInicial
        '
        Me.txtCostoInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostoInicial.Location = New System.Drawing.Point(316, 111)
        Me.txtCostoInicial.Name = "txtCostoInicial"
        Me.txtCostoInicial.Size = New System.Drawing.Size(100, 29)
        Me.txtCostoInicial.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(148, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Costo total "
        '
        'txtCostoTotal
        '
        Me.txtCostoTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostoTotal.Location = New System.Drawing.Point(316, 215)
        Me.txtCostoTotal.Name = "txtCostoTotal"
        Me.txtCostoTotal.ReadOnly = True
        Me.txtCostoTotal.Size = New System.Drawing.Size(100, 29)
        Me.txtCostoTotal.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(255, 284)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 34)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Problema1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtCostoTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCostoInicial)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Problema1"
        Me.Text = "Problema1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCostoInicial As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCostoTotal As TextBox
    Friend WithEvents Button1 As Button
End Class

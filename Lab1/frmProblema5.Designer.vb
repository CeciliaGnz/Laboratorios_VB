<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProblema5
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbOpcTD = New System.Windows.Forms.RadioButton()
        Me.rdbOpcTC = New System.Windows.Forms.RadioButton()
        Me.rdbOpcCh = New System.Windows.Forms.RadioButton()
        Me.rdbOpcE = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrecioU = New System.Windows.Forms.TextBox()
        Me.txtCantA = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMontoI = New System.Windows.Forms.TextBox()
        Me.txtMontoD = New System.Windows.Forms.TextBox()
        Me.txtMontoF = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbOpcTD)
        Me.GroupBox1.Controls.Add(Me.rdbOpcTC)
        Me.GroupBox1.Controls.Add(Me.rdbOpcCh)
        Me.GroupBox1.Controls.Add(Me.rdbOpcE)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 269)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(318, 169)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "OPCIONES DE PAGO"
        '
        'rdbOpcTD
        '
        Me.rdbOpcTD.AutoSize = True
        Me.rdbOpcTD.Location = New System.Drawing.Point(7, 137)
        Me.rdbOpcTD.Name = "rdbOpcTD"
        Me.rdbOpcTD.Size = New System.Drawing.Size(135, 19)
        Me.rdbOpcTD.TabIndex = 3
        Me.rdbOpcTD.TabStop = True
        Me.rdbOpcTD.Text = "TARJETA DE DEBITO"
        Me.rdbOpcTD.UseVisualStyleBackColor = True
        '
        'rdbOpcTC
        '
        Me.rdbOpcTC.AutoSize = True
        Me.rdbOpcTC.Location = New System.Drawing.Point(7, 103)
        Me.rdbOpcTC.Name = "rdbOpcTC"
        Me.rdbOpcTC.Size = New System.Drawing.Size(143, 19)
        Me.rdbOpcTC.TabIndex = 2
        Me.rdbOpcTC.TabStop = True
        Me.rdbOpcTC.Text = "TARJETA DE CREDITO"
        Me.rdbOpcTC.UseVisualStyleBackColor = True
        '
        'rdbOpcCh
        '
        Me.rdbOpcCh.AutoSize = True
        Me.rdbOpcCh.Location = New System.Drawing.Point(7, 69)
        Me.rdbOpcCh.Name = "rdbOpcCh"
        Me.rdbOpcCh.Size = New System.Drawing.Size(74, 19)
        Me.rdbOpcCh.TabIndex = 1
        Me.rdbOpcCh.TabStop = True
        Me.rdbOpcCh.Text = "CHEQUE"
        Me.rdbOpcCh.UseVisualStyleBackColor = True
        '
        'rdbOpcE
        '
        Me.rdbOpcE.AutoSize = True
        Me.rdbOpcE.Location = New System.Drawing.Point(7, 32)
        Me.rdbOpcE.Name = "rdbOpcE"
        Me.rdbOpcE.Size = New System.Drawing.Size(81, 19)
        Me.rdbOpcE.TabIndex = 0
        Me.rdbOpcE.TabStop = True
        Me.rdbOpcE.Text = "EFECTIVO"
        Me.rdbOpcE.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(183, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(410, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "VENTAS DE ARTICULOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(311, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "PRECIO DEL ARTICULO UNITARIO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(436, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(243, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "CANTIDAD DE ARTICULOS"
        '
        'txtPrecioU
        '
        Me.txtPrecioU.BackColor = System.Drawing.SystemColors.Window
        Me.txtPrecioU.Location = New System.Drawing.Point(136, 148)
        Me.txtPrecioU.Name = "txtPrecioU"
        Me.txtPrecioU.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecioU.TabIndex = 6
        '
        'txtCantA
        '
        Me.txtCantA.Location = New System.Drawing.Point(526, 148)
        Me.txtCantA.Name = "txtCantA"
        Me.txtCantA.Size = New System.Drawing.Size(100, 20)
        Me.txtCantA.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(355, 272)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(238, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "MONTO INICIAL DEL ARTICULO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(355, 343)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(180, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "MONTO FINAL A PAGAR"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(355, 305)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(271, 19)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "TOTAL CON DESCUENTO APLICADO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(587, 272)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 11
        '
        'txtMontoI
        '
        Me.txtMontoI.Location = New System.Drawing.Point(608, 269)
        Me.txtMontoI.Name = "txtMontoI"
        Me.txtMontoI.ReadOnly = True
        Me.txtMontoI.Size = New System.Drawing.Size(100, 20)
        Me.txtMontoI.TabIndex = 12
        '
        'txtMontoD
        '
        Me.txtMontoD.Location = New System.Drawing.Point(646, 306)
        Me.txtMontoD.Name = "txtMontoD"
        Me.txtMontoD.ReadOnly = True
        Me.txtMontoD.Size = New System.Drawing.Size(100, 20)
        Me.txtMontoD.TabIndex = 13
        '
        'txtMontoF
        '
        Me.txtMontoF.Location = New System.Drawing.Point(577, 344)
        Me.txtMontoF.Name = "txtMontoF"
        Me.txtMontoF.ReadOnly = True
        Me.txtMontoF.Size = New System.Drawing.Size(100, 20)
        Me.txtMontoF.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(321, 190)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 38)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtMontoF)
        Me.Controls.Add(Me.txtMontoD)
        Me.Controls.Add(Me.txtMontoI)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCantA)
        Me.Controls.Add(Me.txtPrecioU)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form5"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbOpcTD As RadioButton
    Friend WithEvents rdbOpcTC As RadioButton
    Friend WithEvents rdbOpcCh As RadioButton
    Friend WithEvents rdbOpcE As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPrecioU As TextBox
    Friend WithEvents txtCantA As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMontoI As TextBox
    Friend WithEvents txtMontoD As TextBox
    Friend WithEvents txtMontoF As TextBox
    Friend WithEvents Button1 As Button
End Class

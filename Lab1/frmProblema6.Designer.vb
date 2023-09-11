<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProblema6
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnJuan = New System.Windows.Forms.Button()
        Me.btnRamses = New System.Windows.Forms.Button()
        Me.btnCecilia = New System.Windows.Forms.Button()
        Me.btnAneth = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtVotosP = New System.Windows.Forms.TextBox()
        Me.txtPerdedor = New System.Windows.Forms.TextBox()
        Me.txtVotosG = New System.Windows.Forms.TextBox()
        Me.txtGanador = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(311, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ELECCIONES 2023"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(348, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Candidatos"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnAneth)
        Me.GroupBox1.Controls.Add(Me.btnCecilia)
        Me.GroupBox1.Controls.Add(Me.btnRamses)
        Me.GroupBox1.Controls.Add(Me.btnJuan)
        Me.GroupBox1.Location = New System.Drawing.Point(84, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(619, 139)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Candidatos"
        '
        'btnJuan
        '
        Me.btnJuan.Location = New System.Drawing.Point(42, 63)
        Me.btnJuan.Name = "btnJuan"
        Me.btnJuan.Size = New System.Drawing.Size(75, 23)
        Me.btnJuan.TabIndex = 0
        Me.btnJuan.Text = "Juan"
        Me.btnJuan.UseVisualStyleBackColor = True
        '
        'btnRamses
        '
        Me.btnRamses.Location = New System.Drawing.Point(351, 63)
        Me.btnRamses.Name = "btnRamses"
        Me.btnRamses.Size = New System.Drawing.Size(75, 23)
        Me.btnRamses.TabIndex = 1
        Me.btnRamses.Text = "Ramses"
        Me.btnRamses.UseVisualStyleBackColor = True
        '
        'btnCecilia
        '
        Me.btnCecilia.Location = New System.Drawing.Point(506, 63)
        Me.btnCecilia.Name = "btnCecilia"
        Me.btnCecilia.Size = New System.Drawing.Size(75, 23)
        Me.btnCecilia.TabIndex = 2
        Me.btnCecilia.Text = "Cecilia"
        Me.btnCecilia.UseVisualStyleBackColor = True
        '
        'btnAneth
        '
        Me.btnAneth.Location = New System.Drawing.Point(208, 63)
        Me.btnAneth.Name = "btnAneth"
        Me.btnAneth.Size = New System.Drawing.Size(75, 23)
        Me.btnAneth.TabIndex = 3
        Me.btnAneth.Text = "Aneth"
        Me.btnAneth.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(244, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Seleccione un candidado"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtVotosP)
        Me.GroupBox2.Controls.Add(Me.txtPerdedor)
        Me.GroupBox2.Controls.Add(Me.txtVotosG)
        Me.GroupBox2.Controls.Add(Me.txtGanador)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(63, 254)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(676, 122)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "RESULTADOS"
        '
        'txtVotosP
        '
        Me.txtVotosP.Location = New System.Drawing.Point(541, 84)
        Me.txtVotosP.Name = "txtVotosP"
        Me.txtVotosP.ReadOnly = True
        Me.txtVotosP.Size = New System.Drawing.Size(100, 20)
        Me.txtVotosP.TabIndex = 9
        '
        'txtPerdedor
        '
        Me.txtPerdedor.Location = New System.Drawing.Point(541, 46)
        Me.txtPerdedor.Name = "txtPerdedor"
        Me.txtPerdedor.ReadOnly = True
        Me.txtPerdedor.Size = New System.Drawing.Size(100, 20)
        Me.txtPerdedor.TabIndex = 8
        '
        'txtVotosG
        '
        Me.txtVotosG.Location = New System.Drawing.Point(134, 87)
        Me.txtVotosG.Name = "txtVotosG"
        Me.txtVotosG.ReadOnly = True
        Me.txtVotosG.Size = New System.Drawing.Size(100, 20)
        Me.txtVotosG.TabIndex = 7
        '
        'txtGanador
        '
        Me.txtGanador.Location = New System.Drawing.Point(134, 49)
        Me.txtGanador.Name = "txtGanador"
        Me.txtGanador.ReadOnly = True
        Me.txtGanador.Size = New System.Drawing.Size(100, 20)
        Me.txtGanador.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(474, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 13)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "PERDEDOR"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(45, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 13)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "GANADOR"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(424, 87)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 13)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Votos en total"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(424, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(111, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Nombre del candidato"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 87)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Votos en total"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 49)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Nombre del candidato"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(339, 393)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 35)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form6_Ramses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form6_Ramses"
        Me.Text = "Form6_Ramses"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAneth As Button
    Friend WithEvents btnCecilia As Button
    Friend WithEvents btnRamses As Button
    Friend WithEvents btnJuan As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtVotosP As TextBox
    Friend WithEvents txtPerdedor As TextBox
    Friend WithEvents txtVotosG As TextBox
    Friend WithEvents txtGanador As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
End Class

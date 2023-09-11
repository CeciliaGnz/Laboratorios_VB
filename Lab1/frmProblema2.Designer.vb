<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProblema2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        txtGenero = New TextBox()
        Label3 = New Label()
        txtEdad = New TextBox()
        Label4 = New Label()
        txtMujeres = New TextBox()
        txtHombres = New TextBox()
        Label5 = New Label()
        Button1 = New Button()
        Label6 = New Label()
        txtTotales = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(152, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(499, 32)
        Label1.TabIndex = 0
        Label1.Text = "Estadistica de Accidentes Automovilisticos"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(193, 112)
        Label2.Name = "Label2"
        Label2.Size = New Size(196, 25)
        Label2.TabIndex = 1
        Label2.Text = "Genero del conductor"
        ' 
        ' txtGenero
        ' 
        txtGenero.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtGenero.Location = New Point(467, 109)
        txtGenero.Name = "txtGenero"
        txtGenero.Size = New Size(100, 33)
        txtGenero.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(260, 171)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 25)
        Label3.TabIndex = 4
        Label3.Text = "Edad"
        ' 
        ' txtEdad
        ' 
        txtEdad.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtEdad.Location = New Point(467, 168)
        txtEdad.Name = "txtEdad"
        txtEdad.Size = New Size(100, 33)
        txtEdad.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(48, 230)
        Label4.Name = "Label4"
        Label4.Size = New Size(159, 25)
        Label4.TabIndex = 6
        Label4.Text = "Mujeres de 18-25"
        ' 
        ' txtMujeres
        ' 
        txtMujeres.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtMujeres.Location = New Point(251, 222)
        txtMujeres.Name = "txtMujeres"
        txtMujeres.ReadOnly = True
        txtMujeres.Size = New Size(100, 33)
        txtMujeres.TabIndex = 7
        ' 
        ' txtHombres
        ' 
        txtHombres.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtHombres.Location = New Point(616, 222)
        txtHombres.Name = "txtHombres"
        txtHombres.ReadOnly = True
        txtHombres.Size = New Size(100, 33)
        txtHombres.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(408, 230)
        Label5.Name = "Label5"
        Label5.Size = New Size(152, 25)
        Label5.TabIndex = 8
        Label5.Text = "Hombres de 40+"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(331, 347)
        Button1.Name = "Button1"
        Button1.Size = New Size(155, 52)
        Button1.TabIndex = 10
        Button1.Text = "Leer Datos"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(606, 122)
        Label6.Name = "Label6"
        Label6.Size = New Size(124, 15)
        Label6.TabIndex = 11
        Label6.Text = "Mujer (1) - Hombre(2)"
        ' 
        ' txtTotales
        ' 
        txtTotales.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtTotales.Location = New Point(251, 285)
        txtTotales.Multiline = True
        txtTotales.Name = "txtTotales"
        txtTotales.Size = New Size(312, 47)
        txtTotales.TabIndex = 12
        ' 
        ' frmProblema2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtTotales)
        Controls.Add(Label6)
        Controls.Add(Button1)
        Controls.Add(txtHombres)
        Controls.Add(Label5)
        Controls.Add(txtMujeres)
        Controls.Add(Label4)
        Controls.Add(txtEdad)
        Controls.Add(Label3)
        Controls.Add(txtGenero)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frmProblema2"
        Text = "frmProblema2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtGenero As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMujeres As TextBox
    Friend WithEvents txtHombres As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTotales As TextBox
End Class

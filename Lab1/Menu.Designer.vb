<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(106, 135)
        Button1.Name = "Button1"
        Button1.Size = New Size(125, 55)
        Button1.TabIndex = 0
        Button1.Text = "Problema 1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(325, 135)
        Button2.Name = "Button2"
        Button2.Size = New Size(125, 55)
        Button2.TabIndex = 1
        Button2.Text = "Problema 2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(552, 135)
        Button3.Name = "Button3"
        Button3.Size = New Size(125, 55)
        Button3.TabIndex = 2
        Button3.Text = "Problema 3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(106, 300)
        Button4.Name = "Button4"
        Button4.Size = New Size(125, 55)
        Button4.TabIndex = 3
        Button4.Text = "Problema 4"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(325, 300)
        Button5.Name = "Button5"
        Button5.Size = New Size(125, 55)
        Button5.TabIndex = 4
        Button5.Text = "Problema 5"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(552, 300)
        Button6.Name = "Button6"
        Button6.Size = New Size(125, 55)
        Button6.TabIndex = 5
        Button6.Text = "Problema 6"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(21, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(132, 84)
        Label1.TabIndex = 6
        Label1.Text = "Ramses Gutierrez" & vbCrLf & "Aneth Acosta" & vbCrLf & "Juan Ospina" & vbCrLf & "Cecilia Gonzalez" & vbCrLf
        ' 
        ' Menu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(812, 428)
        Controls.Add(Label1)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Menu"
        Text = "Menu"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label1 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Anais_Window
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
        Btn_Regresar = New Button()
        SuspendLayout()
        ' 
        ' Btn_Regresar
        ' 
        Btn_Regresar.Location = New Point(602, 348)
        Btn_Regresar.Name = "Btn_Regresar"
        Btn_Regresar.Size = New Size(94, 29)
        Btn_Regresar.TabIndex = 0
        Btn_Regresar.Text = "regresar"
        Btn_Regresar.UseVisualStyleBackColor = True
        ' 
        ' Anais_Window
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Btn_Regresar)
        Name = "Anais_Window"
        Text = "Anais_Window"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Btn_Regresar As Button
End Class

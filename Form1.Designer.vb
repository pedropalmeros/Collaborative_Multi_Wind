<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Btn_Pedro = New Button()
        SuspendLayout()
        ' 
        ' Btn_Pedro
        ' 
        Btn_Pedro.Location = New Point(677, 381)
        Btn_Pedro.Name = "Btn_Pedro"
        Btn_Pedro.Size = New Size(75, 23)
        Btn_Pedro.TabIndex = 0
        Btn_Pedro.Text = "Pedro"
        Btn_Pedro.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Btn_Pedro)
        Btn_Anais = New Button()
        SuspendLayout()
        ' 
        ' Btn_Anais
        ' 
        Btn_Anais.Location = New Point(159, 63)
        Btn_Anais.Name = "Btn_Anais"
        Btn_Anais.Size = New Size(94, 29)
        Btn_Anais.TabIndex = 0
        Btn_Anais.Text = "Anais "
        Btn_Anais.UseVisualStyleBackColor = True

        Controls.Add(Btn_Anais)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub


    Friend WithEvents Btn_Pedro As Button

    Friend WithEvents Btn_Anais As Button

End Class

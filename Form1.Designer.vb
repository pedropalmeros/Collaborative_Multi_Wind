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
        Me.btn_alex = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_alex
        '
        Me.btn_alex.Location = New System.Drawing.Point(532, 12)
        Me.btn_alex.Name = "btn_alex"
        Me.btn_alex.Size = New System.Drawing.Size(75, 23)
        Me.btn_alex.TabIndex = 0
        Me.btn_alex.Text = "Alex"
        Me.btn_alex.UseVisualStyleBackColor = True

        btn_roberto = New Button()
        SuspendLayout()
        ' 
        ' btn_roberto
        ' 
        btn_roberto.Location = New Point(125, 225)
        btn_roberto.Name = "btn_roberto"
        btn_roberto.Size = New Size(75, 23)
        btn_roberto.TabIndex = 0
        btn_roberto.Text = "Roberto"
        btn_roberto.UseVisualStyleBackColor = True
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
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)

        Controls.Add(btn_roberto)
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

        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 469)
        Me.Controls.Add(Me.btn_alex)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_alex As Button

    Friend WithEvents btn_roberto As Button

    Friend WithEvents Btn_Pedro As Button

    Friend WithEvents Btn_Anais As Button


End Class

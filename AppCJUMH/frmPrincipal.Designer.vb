<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BotonUsuarios = New System.Windows.Forms.Button()
        Me.BotonRoles = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(108, 228)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Form1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(225, 228)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 29)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "From2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(343, 228)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 29)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Form3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(462, 228)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(94, 29)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Form4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(591, 228)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(94, 29)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Form5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(269, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(305, 41)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Formulario Principal"
        '
        'BotonUsuarios
        '
        Me.BotonUsuarios.Location = New System.Drawing.Point(679, 29)
        Me.BotonUsuarios.Name = "BotonUsuarios"
        Me.BotonUsuarios.Size = New System.Drawing.Size(94, 29)
        Me.BotonUsuarios.TabIndex = 6
        Me.BotonUsuarios.Text = "Usuarios"
        Me.BotonUsuarios.UseVisualStyleBackColor = True
        '
        'BotonRoles
        '
        Me.BotonRoles.Location = New System.Drawing.Point(679, 78)
        Me.BotonRoles.Name = "BotonRoles"
        Me.BotonRoles.Size = New System.Drawing.Size(94, 29)
        Me.BotonRoles.TabIndex = 7
        Me.BotonRoles.Text = "Roles"
        Me.BotonRoles.UseVisualStyleBackColor = True
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BotonRoles)
        Me.Controls.Add(Me.BotonUsuarios)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmPrincipal"
        Me.Text = "frmPrincipal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BotonUsuarios As Button
    Friend WithEvents BotonRoles As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUsuario
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
        Me.Usuarios = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbRol = New System.Windows.Forms.ComboBox()
        Me.Salir = New System.Windows.Forms.Button()
        Me.Guardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Usuarios
        '
        Me.Usuarios.AutoSize = True
        Me.Usuarios.Location = New System.Drawing.Point(331, 29)
        Me.Usuarios.Name = "Usuarios"
        Me.Usuarios.Size = New System.Drawing.Size(190, 20)
        Me.Usuarios.TabIndex = 0
        Me.Usuarios.Text = "Administracion de Usuarios"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombres: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(458, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Apellidos: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(84, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Usuario:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(458, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Contrasena:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(84, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "DNI:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(458, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Email: "
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(155, 89)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(215, 27)
        Me.txtNombres.TabIndex = 7
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(543, 89)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(194, 27)
        Me.txtApellidos.TabIndex = 8
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(155, 137)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(215, 27)
        Me.txtDNI.TabIndex = 9
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(543, 137)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(194, 27)
        Me.txtCorreo.TabIndex = 10
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(155, 185)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(215, 27)
        Me.txtUser.TabIndex = 11
        '
        'txtContrasena
        '
        Me.txtContrasena.Location = New System.Drawing.Point(543, 185)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(194, 27)
        Me.txtContrasena.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(84, 237)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Rol: "
        '
        'cbRol
        '
        Me.cbRol.FormattingEnabled = True
        Me.cbRol.Location = New System.Drawing.Point(155, 229)
        Me.cbRol.Name = "cbRol"
        Me.cbRol.Size = New System.Drawing.Size(215, 28)
        Me.cbRol.TabIndex = 14
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(632, 487)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(94, 29)
        Me.Salir.TabIndex = 15
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'Guardar
        '
        Me.Guardar.Location = New System.Drawing.Point(543, 218)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(194, 39)
        Me.Guardar.TabIndex = 16
        Me.Guardar.Text = "Guardar"
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'frmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 561)
        Me.Controls.Add(Me.Guardar)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.cbRol)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtContrasena)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.txtDNI)
        Me.Controls.Add(Me.txtApellidos)
        Me.Controls.Add(Me.txtNombres)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Usuarios)
        Me.Name = "frmUsuario"
        Me.Text = "frmUsuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Usuarios As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents txtDNI As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbRol As ComboBox
    Friend WithEvents Salir As Button
    Friend WithEvents Guardar As Button
End Class

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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Salir = New System.Windows.Forms.Button()
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(155, 89)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(215, 27)
        Me.TextBox1.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(543, 89)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(194, 27)
        Me.TextBox2.TabIndex = 8
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(155, 137)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(215, 27)
        Me.TextBox3.TabIndex = 9
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(543, 137)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(194, 27)
        Me.TextBox4.TabIndex = 10
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(155, 185)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(215, 27)
        Me.TextBox5.TabIndex = 11
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(543, 185)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(194, 27)
        Me.TextBox6.TabIndex = 12
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
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(155, 229)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(215, 28)
        Me.ComboBox1.TabIndex = 14
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
        'frmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 561)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Salir As Button
End Class

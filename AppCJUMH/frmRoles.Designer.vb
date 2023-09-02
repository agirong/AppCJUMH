<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRoles
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
        Me.Usuarios = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Salir = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Usuarios
        '
        Me.Usuarios.AutoSize = True
        Me.Usuarios.Location = New System.Drawing.Point(328, 36)
        Me.Usuarios.Name = "Usuarios"
        Me.Usuarios.Size = New System.Drawing.Size(170, 20)
        Me.Usuarios.TabIndex = 1
        Me.Usuarios.Text = "Administracion de Roles"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Seleccione el rol y agregue los permisos:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(88, 129)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(273, 28)
        Me.ComboBox1.TabIndex = 3
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(13, 42)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(73, 24)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Form1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.CheckBox7)
        Me.Panel1.Controls.Add(Me.CheckBox6)
        Me.Panel1.Controls.Add(Me.CheckBox5)
        Me.Panel1.Controls.Add(Me.CheckBox4)
        Me.Panel1.Controls.Add(Me.CheckBox3)
        Me.Panel1.Controls.Add(Me.CheckBox2)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Location = New System.Drawing.Point(88, 188)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(450, 310)
        Me.Panel1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Permisos de este rol"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 263)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Location = New System.Drawing.Point(13, 222)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(121, 24)
        Me.CheckBox7.TabIndex = 6
        Me.CheckBox7.Text = "FormUsuarios"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(13, 192)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(101, 24)
        Me.CheckBox6.TabIndex = 5
        Me.CheckBox6.Text = "FormRoles"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(13, 162)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(73, 24)
        Me.CheckBox5.TabIndex = 4
        Me.CheckBox5.Text = "Form5"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(13, 132)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(73, 24)
        Me.CheckBox4.TabIndex = 3
        Me.CheckBox4.Text = "Form4"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(13, 102)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(73, 24)
        Me.CheckBox3.TabIndex = 2
        Me.CheckBox3.Text = "Form3"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(13, 72)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(73, 24)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "Form2"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(653, 500)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(94, 29)
        Me.Salir.TabIndex = 5
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'frmRoles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 559)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Usuarios)
        Me.Name = "frmRoles"
        Me.Text = "frmRoles"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Usuarios As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Salir As Button
End Class

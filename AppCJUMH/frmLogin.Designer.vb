<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUsuarioLogin = New System.Windows.Forms.TextBox()
        Me.txtContrasenaLogin = New System.Windows.Forms.TextBox()
        Me.btnIngresarLogin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(177, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(177, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contrasena:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(290, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "SISTEMA CJUMH"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(110, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(462, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Favor Ingrese con sus credenciales autorizadas por la Administracion"
        '
        'txtUsuarioLogin
        '
        Me.txtUsuarioLogin.Location = New System.Drawing.Point(278, 152)
        Me.txtUsuarioLogin.Name = "txtUsuarioLogin"
        Me.txtUsuarioLogin.Size = New System.Drawing.Size(199, 27)
        Me.txtUsuarioLogin.TabIndex = 4
        '
        'txtContrasenaLogin
        '
        Me.txtContrasenaLogin.Location = New System.Drawing.Point(278, 211)
        Me.txtContrasenaLogin.Name = "txtContrasenaLogin"
        Me.txtContrasenaLogin.Size = New System.Drawing.Size(199, 27)
        Me.txtContrasenaLogin.TabIndex = 5
        '
        'btnIngresarLogin
        '
        Me.btnIngresarLogin.Location = New System.Drawing.Point(177, 253)
        Me.btnIngresarLogin.Name = "btnIngresarLogin"
        Me.btnIngresarLogin.Size = New System.Drawing.Size(300, 41)
        Me.btnIngresarLogin.TabIndex = 6
        Me.btnIngresarLogin.Text = "Ingresar"
        Me.btnIngresarLogin.UseVisualStyleBackColor = True
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 450)
        Me.Controls.Add(Me.btnIngresarLogin)
        Me.Controls.Add(Me.txtContrasenaLogin)
        Me.Controls.Add(Me.txtUsuarioLogin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLogin"
        Me.Text = "frmLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtUsuarioLogin As TextBox
    Friend WithEvents txtContrasenaLogin As TextBox
    Friend WithEvents btnIngresarLogin As Button
End Class

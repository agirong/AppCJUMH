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
        Me.btnFicha = New System.Windows.Forms.Button()
        Me.btnSeguimiento = New System.Windows.Forms.Button()
        Me.btnDelegacion = New System.Windows.Forms.Button()
        Me.btnAudiencias = New System.Windows.Forms.Button()
        Me.btnCasosPPS = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BotonUsuarios = New System.Windows.Forms.Button()
        Me.BotonRoles = New System.Windows.Forms.Button()
        Me.lbUsuarioActual = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnFicha
        '
        Me.btnFicha.Location = New System.Drawing.Point(57, 261)
        Me.btnFicha.Name = "btnFicha"
        Me.btnFicha.Size = New System.Drawing.Size(103, 29)
        Me.btnFicha.TabIndex = 0
        Me.btnFicha.Text = "Ficha"
        Me.btnFicha.UseVisualStyleBackColor = True
        '
        'btnSeguimiento
        '
        Me.btnSeguimiento.Location = New System.Drawing.Point(193, 261)
        Me.btnSeguimiento.Name = "btnSeguimiento"
        Me.btnSeguimiento.Size = New System.Drawing.Size(123, 29)
        Me.btnSeguimiento.TabIndex = 1
        Me.btnSeguimiento.Text = "Seguimiento"
        Me.btnSeguimiento.UseVisualStyleBackColor = True
        '
        'btnDelegacion
        '
        Me.btnDelegacion.Location = New System.Drawing.Point(345, 261)
        Me.btnDelegacion.Name = "btnDelegacion"
        Me.btnDelegacion.Size = New System.Drawing.Size(113, 29)
        Me.btnDelegacion.TabIndex = 2
        Me.btnDelegacion.Text = "Delegaciones"
        Me.btnDelegacion.UseVisualStyleBackColor = True
        '
        'btnAudiencias
        '
        Me.btnAudiencias.Location = New System.Drawing.Point(496, 261)
        Me.btnAudiencias.Name = "btnAudiencias"
        Me.btnAudiencias.Size = New System.Drawing.Size(94, 29)
        Me.btnAudiencias.TabIndex = 3
        Me.btnAudiencias.Text = "Audiencias"
        Me.btnAudiencias.UseVisualStyleBackColor = True
        '
        'btnCasosPPS
        '
        Me.btnCasosPPS.Location = New System.Drawing.Point(629, 261)
        Me.btnCasosPPS.Name = "btnCasosPPS"
        Me.btnCasosPPS.Size = New System.Drawing.Size(94, 29)
        Me.btnCasosPPS.TabIndex = 4
        Me.btnCasosPPS.Text = "Casos PPS"
        Me.btnCasosPPS.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(215, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(384, 41)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Consultorio Jurídico UMH"
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
        'lbUsuarioActual
        '
        Me.lbUsuarioActual.AutoSize = True
        Me.lbUsuarioActual.Location = New System.Drawing.Point(98, 41)
        Me.lbUsuarioActual.Name = "lbUsuarioActual"
        Me.lbUsuarioActual.Size = New System.Drawing.Size(53, 20)
        Me.lbUsuarioActual.TabIndex = 8
        Me.lbUsuarioActual.Text = "Label2"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AppCJUMH.My.Resources.Resources.usuario
        Me.PictureBox1.Location = New System.Drawing.Point(46, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbUsuarioActual)
        Me.Controls.Add(Me.BotonRoles)
        Me.Controls.Add(Me.BotonUsuarios)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCasosPPS)
        Me.Controls.Add(Me.btnAudiencias)
        Me.Controls.Add(Me.btnDelegacion)
        Me.Controls.Add(Me.btnSeguimiento)
        Me.Controls.Add(Me.btnFicha)
        Me.Name = "frmPrincipal"
        Me.Text = "frmPrincipal"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFicha As Button
    Friend WithEvents btnSeguimiento As Button
    Friend WithEvents btnDelegacion As Button
    Friend WithEvents btnAudiencias As Button
    Friend WithEvents btnCasosPPS As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BotonUsuarios As Button
    Friend WithEvents BotonRoles As Button
    Friend WithEvents lbUsuarioActual As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class

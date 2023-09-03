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
        Me.ComboBoxRoles = New System.Windows.Forms.ComboBox()
        Me.CBfichaAtencion = New System.Windows.Forms.CheckBox()
        Me.PanelPermisos = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.CBusuarios = New System.Windows.Forms.CheckBox()
        Me.CBroles = New System.Windows.Forms.CheckBox()
        Me.CBcasosPPS = New System.Windows.Forms.CheckBox()
        Me.CBaudienciasVigentes = New System.Windows.Forms.CheckBox()
        Me.CBdelegacionesProcuradores = New System.Windows.Forms.CheckBox()
        Me.CBseguimientoPPS = New System.Windows.Forms.CheckBox()
        Me.Salir = New System.Windows.Forms.Button()
        Me.PanelPermisos.SuspendLayout()
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
        'ComboBoxRoles
        '
        Me.ComboBoxRoles.FormattingEnabled = True
        Me.ComboBoxRoles.Location = New System.Drawing.Point(88, 129)
        Me.ComboBoxRoles.Name = "ComboBoxRoles"
        Me.ComboBoxRoles.Size = New System.Drawing.Size(273, 28)
        Me.ComboBoxRoles.TabIndex = 3
        '
        'CBfichaAtencion
        '
        Me.CBfichaAtencion.AutoSize = True
        Me.CBfichaAtencion.Location = New System.Drawing.Point(13, 42)
        Me.CBfichaAtencion.Name = "CBfichaAtencion"
        Me.CBfichaAtencion.Size = New System.Drawing.Size(149, 24)
        Me.CBfichaAtencion.TabIndex = 0
        Me.CBfichaAtencion.Text = "Ficha de Atencion"
        Me.CBfichaAtencion.UseVisualStyleBackColor = True
        '
        'PanelPermisos
        '
        Me.PanelPermisos.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.PanelPermisos.Controls.Add(Me.Label2)
        Me.PanelPermisos.Controls.Add(Me.BtnGuardar)
        Me.PanelPermisos.Controls.Add(Me.CBusuarios)
        Me.PanelPermisos.Controls.Add(Me.CBroles)
        Me.PanelPermisos.Controls.Add(Me.CBcasosPPS)
        Me.PanelPermisos.Controls.Add(Me.CBaudienciasVigentes)
        Me.PanelPermisos.Controls.Add(Me.CBdelegacionesProcuradores)
        Me.PanelPermisos.Controls.Add(Me.CBseguimientoPPS)
        Me.PanelPermisos.Controls.Add(Me.CBfichaAtencion)
        Me.PanelPermisos.Location = New System.Drawing.Point(88, 188)
        Me.PanelPermisos.Name = "PanelPermisos"
        Me.PanelPermisos.Size = New System.Drawing.Size(450, 310)
        Me.PanelPermisos.TabIndex = 4
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
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(13, 263)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(94, 29)
        Me.BtnGuardar.TabIndex = 5
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'CBusuarios
        '
        Me.CBusuarios.AutoSize = True
        Me.CBusuarios.Location = New System.Drawing.Point(13, 222)
        Me.CBusuarios.Name = "CBusuarios"
        Me.CBusuarios.Size = New System.Drawing.Size(87, 24)
        Me.CBusuarios.TabIndex = 6
        Me.CBusuarios.Text = "Usuarios"
        Me.CBusuarios.UseVisualStyleBackColor = True
        '
        'CBroles
        '
        Me.CBroles.AutoSize = True
        Me.CBroles.Location = New System.Drawing.Point(13, 192)
        Me.CBroles.Name = "CBroles"
        Me.CBroles.Size = New System.Drawing.Size(67, 24)
        Me.CBroles.TabIndex = 5
        Me.CBroles.Text = "Roles"
        Me.CBroles.UseVisualStyleBackColor = True
        '
        'CBcasosPPS
        '
        Me.CBcasosPPS.AutoSize = True
        Me.CBcasosPPS.Location = New System.Drawing.Point(13, 162)
        Me.CBcasosPPS.Name = "CBcasosPPS"
        Me.CBcasosPPS.Size = New System.Drawing.Size(97, 24)
        Me.CBcasosPPS.TabIndex = 4
        Me.CBcasosPPS.Text = "Casos PPS"
        Me.CBcasosPPS.UseVisualStyleBackColor = True
        '
        'CBaudienciasVigentes
        '
        Me.CBaudienciasVigentes.AutoSize = True
        Me.CBaudienciasVigentes.Location = New System.Drawing.Point(13, 132)
        Me.CBaudienciasVigentes.Name = "CBaudienciasVigentes"
        Me.CBaudienciasVigentes.Size = New System.Drawing.Size(164, 24)
        Me.CBaudienciasVigentes.TabIndex = 3
        Me.CBaudienciasVigentes.Text = "Audiencias Vigentes"
        Me.CBaudienciasVigentes.UseVisualStyleBackColor = True
        '
        'CBdelegacionesProcuradores
        '
        Me.CBdelegacionesProcuradores.AutoSize = True
        Me.CBdelegacionesProcuradores.Location = New System.Drawing.Point(13, 102)
        Me.CBdelegacionesProcuradores.Name = "CBdelegacionesProcuradores"
        Me.CBdelegacionesProcuradores.Size = New System.Drawing.Size(212, 24)
        Me.CBdelegacionesProcuradores.TabIndex = 2
        Me.CBdelegacionesProcuradores.Text = "Delegaciones Procuradores"
        Me.CBdelegacionesProcuradores.UseVisualStyleBackColor = True
        '
        'CBseguimientoPPS
        '
        Me.CBseguimientoPPS.AutoSize = True
        Me.CBseguimientoPPS.Location = New System.Drawing.Point(13, 72)
        Me.CBseguimientoPPS.Name = "CBseguimientoPPS"
        Me.CBseguimientoPPS.Size = New System.Drawing.Size(143, 24)
        Me.CBseguimientoPPS.TabIndex = 1
        Me.CBseguimientoPPS.Text = "Seguimiento PPS"
        Me.CBseguimientoPPS.UseVisualStyleBackColor = True
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
        Me.Controls.Add(Me.PanelPermisos)
        Me.Controls.Add(Me.ComboBoxRoles)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Usuarios)
        Me.Name = "frmRoles"
        Me.Text = "frmRoles"
        Me.PanelPermisos.ResumeLayout(False)
        Me.PanelPermisos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Usuarios As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxRoles As ComboBox
    Friend WithEvents CBfichaAtencion As CheckBox
    Friend WithEvents PanelPermisos As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents CBusuarios As CheckBox
    Friend WithEvents CBroles As CheckBox
    Friend WithEvents CBcasosPPS As CheckBox
    Friend WithEvents CBaudienciasVigentes As CheckBox
    Friend WithEvents CBdelegacionesProcuradores As CheckBox
    Friend WithEvents CBseguimientoPPS As CheckBox
    Friend WithEvents Salir As Button
End Class

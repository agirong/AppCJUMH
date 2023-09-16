Public Class frmRoles
    Private Sub frmRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarRoles()
        PanelPermisos.Visible = False

        ' YM. Código para centar frmRoles
        Dim medirPantalla As Size = Screen.PrimaryScreen.WorkingArea.Size
        Dim xPosicion As Integer = (medirPantalla.Width - Me.Width) / 2
        Dim yPosicion As Integer = (medirPantalla.Height - Me.Height) / 2
        ' Establecer la posición del formulario
        Me.Location = New Point(xPosicion, yPosicion)
    End Sub

    'Ym. Hacer una funcion para llenar el combobox de roles
    Private Sub cargarRoles()
        Try

            Dim dt As DataTable = ConexionDB.GetDataTable("SELECT id, rolNombre FROM roles")

            ' Crea un nuevo DataRow para representar el elemento "Seleccione..."
            Dim selectRow As DataRow = dt.NewRow()
            selectRow("id") = 0
            selectRow("rolNombre") = "Seleccione..."

            ' Agrega el elemento "Seleccione..." al principio de la DataTable
            dt.Rows.InsertAt(selectRow, 0)

            ' Asigna la DataTable como origen de datos
            ComboBoxRoles.DataSource = dt


            ComboBoxRoles.DisplayMember = "rolNombre"
            ComboBoxRoles.ValueMember = "id"

        Catch ex As Exception

        End Try
    End Sub

    Private Sub limpiarCheckBox()
        PanelPermisos.Visible = False
        CBfichaAtencion.Checked = False
        CBseguimientoPPS.Checked = False
        CBdelegacionesProcuradores.Checked = False
        CBaudienciasVigentes.Checked = False
        CBcasosPPS.Checked = False
        CBroles.Checked = False
        CBusuarios.Checked = False
    End Sub


    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        'YM. Crear una instancia del formulario que deseas mostrar
        Dim frmPrin As New frmPrincipal()

        'YM. Mostrar el formulario
        frmPrin.Show()

        Me.Hide()
    End Sub

    Private Sub ComboBoxRoles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxRoles.SelectedIndexChanged
        Try
            limpiarCheckBox()

            Dim idRol As Integer
            idRol = Convert.ToInt32(ComboBoxRoles.SelectedValue)
            If (idRol = 0) Then
                PanelPermisos.Visible = False
            Else
                Dim rolPermisos As New DataTable()
                rolPermisos = ConexionDB.GetDataTableRoles(idRol)
                PanelPermisos.Visible = True

                ' Recorre las filas del DataTable de rolPermisos
                For Each row As DataRow In rolPermisos.Rows
                    ' Accede a los datos de cada fila por columna
                    Dim vFichaAtencion As Boolean = row("fichaAtencion")
                    Dim vSeguimientoPPS As Boolean = row("seguimientoPPS")
                    Dim vdelegacionesProcuradores As Boolean = row("delegacionesProcuradores")
                    Dim vaudienciasVigentes As Boolean = row("audienciasVigentes")
                    Dim vcasosPPS As Boolean = row("casosPPS")
                    Dim vroles As Boolean = row("roles")
                    Dim vusuarios As Boolean = row("usuarios")

                    CBfichaAtencion.Checked = vFichaAtencion
                    CBseguimientoPPS.Checked = vSeguimientoPPS
                    CBdelegacionesProcuradores.Checked = vdelegacionesProcuradores
                    CBaudienciasVigentes.Checked = vaudienciasVigentes
                    CBcasosPPS.Checked = vcasosPPS
                    CBroles.Checked = vroles
                    CBusuarios.Checked = vusuarios
                Next

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            Dim idRol As Integer
            idRol = Convert.ToInt32(ComboBoxRoles.SelectedValue)

            'Obtener los valores de los combobox 
            Dim vFichaAtencion As Boolean = CBfichaAtencion.Checked
            Dim vSeguimientoPPS As Boolean = CBseguimientoPPS.Checked
            Dim vdelegacionesProcuradores As Boolean = CBdelegacionesProcuradores.Checked
            Dim vaudienciasVigentes As Boolean = CBaudienciasVigentes.Checked
            Dim vcasosPPS As Boolean = CBcasosPPS.Checked
            Dim vroles As Boolean = CBroles.Checked
            Dim vusuarios As Boolean = CBusuarios.Checked

            'Llamar a la funcion que guardara los datos. 
            ConexionDB.UpdatePermisosRol(idRol, vFichaAtencion, vSeguimientoPPS, vdelegacionesProcuradores, vaudienciasVigentes, vcasosPPS, vroles, vusuarios)

            MessageBox.Show("El rol se actualizó exitosamente")
        Catch ex As Exception

        End Try
    End Sub
End Class
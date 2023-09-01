Imports System.Data.SqlClient

Public Class Form4
    Dim comando As SqlCommand
    Dim connectionString As String = "Data Source=.;Initial Catalog=CJUMH;Integrated Security=True"
    Dim connection As New SqlConnection(connectionString)

    'Private Function ObtenerDatos1() As DataTable
    '    Dim datos As New DataTable()

    '    Using connection As New SqlConnection(connectionString)
    '        connection.Open()
    '        Dim query As String = "SELECT nombre_y_apellidos FROM usuario"
    '        Using command As New SqlCommand(query, connection)
    '            Dim adapter As New SqlDataAdapter(command)
    '            adapter.Fill(datos)
    '        End Using
    '    End Using

    '    Return datos
    'End Function

    'Private Function ObtenerDatos2() As DataTable
    '    Dim datos As New DataTable()

    '    Using connection As New SqlConnection(connectionString)
    '        connection.Open()
    '        Dim query As String = "SELECT nombre_procurador FROM casos"
    '        Using command As New SqlCommand(query, connection)
    '            Dim adapter As New SqlDataAdapter(command)
    '            adapter.Fill(datos)
    '        End Using
    '    End Using

    '    Return datos
    'End Function

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadComboBoxData()
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message)
        End Try
    End Sub
    'YM: Crear un metodo nuevo para cargar la data a los combobox 
    Private Sub LoadComboBoxData()
        Try
            ComboBox3.DataSource = ConexionDB.GetDataTable("SELECT nombre_y_apellidos FROM usuario")
            ComboBox3.DisplayMember = "nombre_y_apellidos"
            ComboBox3.ValueMember = "nombre_y_apellidos"

            ComboBox2.DataSource = ConexionDB.GetDataTable("SELECT nombre_procurador FROM casos")
            ComboBox2.DisplayMember = "nombre_procurador"
            ComboBox2.ValueMember = "nombre_procurador"

        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message)
        End Try
    End Sub


    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try

            'connection.Open()
            Dim parametros As SqlParameter() = {
            New SqlParameter("@número_expediente", Int64.Parse(txtnumeroexpediente.Text)),
            New SqlParameter("@materia", ComboBox1.SelectedItem.ToString),
            New SqlParameter("@procurador_asignado", ComboBox2.SelectedValue.ToString),
            New SqlParameter("@carnet", Integer.Parse(txtcarnet.Text)),
            New SqlParameter("@cuenta_institucional", Int64.Parse(txtcuenta.Text)),
            New SqlParameter("@teléfono_procurador", Integer.Parse(txttelefonoprocurador.Text)),
            New SqlParameter("@nombre_usuario", ComboBox3.SelectedValue.ToString),
            New SqlParameter("@teléfono_usuario", Integer.Parse(txttelefonousuario.Text)),
            New SqlParameter("@observación", txtobservacion.Text),
            New SqlParameter("@fecha_audiencia", txtfechaaudiencia.Text)
            }
            Dim consulta As String = "INSERT INTO audiencias_vigentes (número_expediente, materia, procurador_asignado, carnet, cuenta_institucional, teléfono_procurador, nombre_usuario, teléfono_usuario, observación, fecha_audiencia) VALUES (@número_expediente, @materia, @procurador_asignado, @carnet, @cuenta_institucional, @teléfono_procurador, @nombre_usuario, @teléfono_usuario, @observación, @fecha_audiencia)"
            ConexionDB.InsertData(consulta, parametros)

            MsgBox("Datos guardados correctamente")
        Catch ex As Exception
            MessageBox.Show("Error al guardar los datos: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        MsgBox("Se dirige al menu principal, los dato no guardados se perderan.")
        'YM. Crear una instancia del formulario que deseas mostrar
        Dim frmPrincipal As New frmPrincipal()
        'YM. Mostrar el formulario
        frmPrincipal.Show()

        Me.Close()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Dim selectedNombreApellidos As String = ComboBox3.SelectedValue.ToString()
        Dim numeroCelular As String = ConexionDB.GetNumeroCelular(selectedNombreApellidos)
        txttelefonousuario.Text = numeroCelular
    End Sub

    Private Sub txtnumeroexpediente_TextChanged(sender As Object, e As EventArgs) Handles txtnumeroexpediente.TextChanged

    End Sub
    Private Sub txtnumeroexpediente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnumeroexpediente.KeyPress, txtnumeroexpediente.KeyPress
        ' Verificar si el carácter ingresado no es un número
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Cancelar el evento de tecla presionada
            e.Handled = True
        End If
    End Sub

    Private Sub txtcarnet_TextChanged(sender As Object, e As EventArgs) Handles txtcarnet.TextChanged

    End Sub
    Private Sub txtcarnet_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcarnet.KeyPress, txtcarnet.KeyPress
        ' Verificar si el carácter ingresado no es un número
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Cancelar el evento de tecla presionada
            e.Handled = True
        End If
    End Sub

    Private Sub txtcuenta_TextChanged(sender As Object, e As EventArgs) Handles txtcuenta.TextChanged

    End Sub
    Private Sub txtcuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcuenta.KeyPress, txtcuenta.KeyPress
        ' Verificar si el carácter ingresado no es un número
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Cancelar el evento de tecla presionada
            e.Handled = True
        End If
    End Sub

    Private Sub txttelefonoprocurador_TextChanged(sender As Object, e As EventArgs) Handles txttelefonoprocurador.TextChanged

    End Sub
    Private Sub txttelefonoprocurador_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttelefonoprocurador.KeyPress, txttelefonoprocurador.KeyPress
        ' Verificar si el carácter ingresado no es un número
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Cancelar el evento de tecla presionada
            e.Handled = True
        End If
    End Sub

    Private Sub txttelefonousuario_TextChanged(sender As Object, e As EventArgs) Handles txttelefonousuario.TextChanged

    End Sub
    Private Sub txttelefonousuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttelefonousuario.KeyPress, txttelefonousuario.KeyPress
        ' Verificar si el carácter ingresado no es un número
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Cancelar el evento de tecla presionada
            e.Handled = True
        End If
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        'Call Limpia_objetos(Me)
    End Sub
End Class





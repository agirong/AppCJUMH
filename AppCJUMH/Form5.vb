Imports System.Data.SqlClient

Public Class Form5
    Dim comando As SqlCommand
    Dim connection As SqlConnection

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Establecer la conexión con la base de datos
        Dim connectionString As String = "Data Source=LAPTOP-DLNMBOV3\SQLEXPRESS;Initial Catalog=CJUMH;Integrated Security=True"
        connection = New SqlConnection(connectionString)

        ' Llenar ComboBox1 con los nombres y apellidos de la tabla usuario
        Dim query1 As String = "SELECT nombre_y_apellidos FROM usuario"
        Dim command1 As SqlCommand = New SqlCommand(query1, connection)

        Dim adapter1 As New SqlDataAdapter(command1)
        Dim dataTable1 As New DataTable()
        adapter1.Fill(dataTable1)

        ComboBox1.DisplayMember = "nombre_y_apellidos"
        ComboBox1.ValueMember = "nombre_y_apellidos"
        ComboBox1.DataSource = dataTable1

        ' Llenar ComboBox4 con los procuradores que delegan de la tabla delegaciones_procuradores
        Dim query2 As String = "SELECT procurador_que_delega FROM delegaciones_procuradores"
        Dim command2 As SqlCommand = New SqlCommand(query2, connection)

        Dim adapter2 As New SqlDataAdapter(command2)
        Dim dataTable2 As New DataTable()
        adapter2.Fill(dataTable2)

        ComboBox4.DisplayMember = "procurador_que_delega"
        ComboBox4.ValueMember = "procurador_que_delega"
        ComboBox4.DataSource = dataTable2

        ' Llenar ComboBox5 con los nuevos procuradores de la tabla delegaciones_procuradores
        Dim query3 As String = "SELECT nuevo_procurador FROM delegaciones_procuradores"
        Dim command3 As SqlCommand = New SqlCommand(query3, connection)

        Dim adapter3 As New SqlDataAdapter(command3)
        Dim dataTable3 As New DataTable()
        adapter3.Fill(dataTable3)

        ComboBox5.DisplayMember = "nuevo_procurador"
        ComboBox5.ValueMember = "nuevo_procurador"
        ComboBox5.DataSource = dataTable3
    End Sub

    Private Function ObtenerCorreoElectronico(ByVal nombreApellidos As String) As String
        Dim correoElectronico As String = ""

        Dim query As String = "SELECT correo_electronico FROM usuario WHERE nombre_y_apellidos = @NombreApellidos"
        Dim command As SqlCommand = New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@NombreApellidos", nombreApellidos)

        connection.Open()
        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.Read() Then
            correoElectronico = reader("correo_electronico").ToString()
        End If

        reader.Close()
        connection.Close()

        Return correoElectronico
    End Function

    Private Function ObtenerNumeroCelular(ByVal nombreApellidos As String) As String
        Dim numeroCelular As String = ""

        Dim query As String = "SELECT telefono_movil FROM usuario WHERE nombre_y_apellidos = @NombreApellidos"
        Dim command As SqlCommand = New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@NombreApellidos", nombreApellidos)

        connection.Open()
        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.Read() Then
            numeroCelular = reader("telefono_movil").ToString()
        End If

        reader.Close()
        connection.Close()

        Return numeroCelular
    End Function

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim selectedNombreApellidos As String = ComboBox1.SelectedValue.ToString()

        Dim correoElectronico As String = ObtenerCorreoElectronico(selectedNombreApellidos)
        txtcorreoelectronico.Text = correoElectronico

        Dim numeroCelular As String = ObtenerNumeroCelular(selectedNombreApellidos)
        txtnumerocelular.Text = numeroCelular
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim connectionString As String = "Data Source=LAPTOP-DLNMBOV3\SQLEXPRESS;Initial Catalog=CJUMH;Integrated Security=True"

        Try
            Using conexion As New SqlConnection(connectionString)
                conexion.Open()

                Dim consulta As String = "INSERT INTO casos_judiciales (nombre_usuario, celular_usuario, correo_usuario, nombre_demandado, nombre_demandante, tipo_caso, categoria, número_expediente, número_juez, estado, nombre_procurador_que_delega, nombre_procurador_delegado, carnet_procurador_que_delega, carnet_procurador_delegado, fecha_primera_atención, fecha_ultima_atención, zona_consultorio, descripción, delegar_caso) VALUES (@nombre_usuario, @celular_usuario, @correo_usuario, @nombre_demandado, @nombre_demandante, @tipo_caso, @categoria, @número_expediente, @número_juez, @estado, @nombre_procurador_que_delega, @nombre_procurador_delegado, @carnet_procurador_que_delega, @carnet_procurador_delegado, @fecha_primera_atención, @fecha_ultima_atención, @zona_consultorio, @descripción, @delegar_caso)"

                comando = New SqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@nombre_usuario", ComboBox1.SelectedValue.ToString())
                comando.Parameters.AddWithValue("@celular_usuario", Integer.Parse(txtnumerocelular.Text))
                comando.Parameters.AddWithValue("@correo_usuario", txtcorreoelectronico.Text)
                comando.Parameters.AddWithValue("@nombre_demandado", txtdemandado.Text)
                comando.Parameters.AddWithValue("@nombre_demandante", txtdemandante.Text)
                comando.Parameters.AddWithValue("@tipo_caso", txttipocaso.Text)
                comando.Parameters.AddWithValue("@categoria", ComboBox2.SelectedItem.ToString)
                comando.Parameters.AddWithValue("@número_expediente", Int64.Parse(txtnumeroexpediente.Text))
                comando.Parameters.AddWithValue("@número_juez", txtjuez.Text)
                comando.Parameters.AddWithValue("@estado", ComboBox3.SelectedItem.ToString)
                comando.Parameters.AddWithValue("@nombre_procurador_que_delega", ComboBox4.SelectedValue.ToString)
                comando.Parameters.AddWithValue("@nombre_procurador_delegado", ComboBox5.SelectedValue.ToString)
                comando.Parameters.AddWithValue("@carnet_procurador_que_delega", txtcarnetquedelega.Text)
                comando.Parameters.AddWithValue("@carnet_procurador_delegado", txtcarnetdelegado.Text)
                comando.Parameters.AddWithValue("@fecha_primera_atención", DateTimePicker1.Value.ToString("yyyy-MM-dd"))
                comando.Parameters.AddWithValue("@fecha_ultima_atención", DateTimePicker1.Value.ToString("yyyy-MM-dd"))
                comando.Parameters.AddWithValue("@zona_consultorio", ComboBox6.SelectedItem.ToString)
                comando.Parameters.AddWithValue("@descripción", txtdescripcion.Text)
                comando.Parameters.AddWithValue("@delegar_caso", ComboBox7.SelectedItem.ToString)
                comando.ExecuteNonQuery()
                MsgBox("Datos guardados correctamente")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al guardar los datos: " & ex.Message)
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

    Private Sub txtdescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtdescripcion.TextChanged

    End Sub

    Private Sub txtcarnetquedelega_TextChanged(sender As Object, e As EventArgs) Handles txtcarnetquedelega.TextChanged

    End Sub
    Private Sub txtcarnetquedelega_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcarnetquedelega.KeyPress, txtcarnetquedelega.KeyPress
        ' Verificar si el carácter ingresado no es un número
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Cancelar el evento de tecla presionada
            e.Handled = True
        End If
    End Sub
    Private Sub txtnumerocelular_TextChanged(sender As Object, e As EventArgs) Handles txtnumerocelular.TextChanged

    End Sub
    Private Sub txtnumerocelular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnumerocelular.KeyPress, txtnumerocelular.KeyPress
        ' Verificar si el carácter ingresado no es un número
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Cancelar el evento de tecla presionada
            e.Handled = True
        End If
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

    Private Sub txtcarnetdelegado_TextChanged(sender As Object, e As EventArgs) Handles txtcarnetdelegado.TextChanged

    End Sub
    Private Sub txtcarnetdelegado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcarnetdelegado.KeyPress, txtcarnetdelegado.KeyPress
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


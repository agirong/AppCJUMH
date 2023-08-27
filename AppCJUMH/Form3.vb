Imports System.Collections.ObjectModel
Imports System.Data.SqlClient

Public Class Form3
    'YM. Definir una sola cadena de conexion para el Form3
    Private Const ConnectionString As String = "Data Source=.;Initial Catalog=CJUMH;Integrated Security=True"
    Dim comando As SqlCommand
    Dim connection As SqlConnection

    Private datos1 As DataTable
    Private datos2 As DataTable

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "Data Source=.;Initial Catalog=CJUMH;Integrated Security=True"
        connection = New SqlConnection(connectionString)

        Try
            'YM. Llama r la funcion que Cargara los datos en los combobox 
            LoadComboBoxData()
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message)
        End Try
    End Sub
    'YM. Definir una funcion para cargar los datos en los combobox
    Private Sub LoadComboBoxData()
        Using connection As New SqlConnection(ConnectionString)
            connection.Open()
            ComboBox3.DataSource = GetDataTable("SELECT nombre_y_apellidos FROM usuario", connection)
            ComboBox3.DisplayMember = "nombre_y_apellidos"
            ComboBox3.ValueMember = "nombre_y_apellidos"

            ComboBox1.DataSource = GetDataTable("SELECT procurador_que_delega FROM delegaciones_procuradores", connection)
            ComboBox1.DisplayMember = "procurador_que_delega"
            ComboBox1.ValueMember = "procurador_que_delega"

            ComboBox3.SelectedIndex = -1
        End Using
    End Sub
    'YM. La función GetDataTable se ha creado para reutilizar el patrón de obtener datos de la base de datos en forma de tabla
    Private Function GetDataTable(query As String, connection As SqlConnection) As DataTable
        Dim dataTable As New DataTable()
        Using command As New SqlCommand(query, connection)
            Dim adapter As New SqlDataAdapter(command)
            adapter.Fill(dataTable)
        End Using
        Return dataTable
    End Function

    Private Sub HandleError(message As String)
        ' Aquí podrías realizar un registro de errores o mostrar un MessageBox
        MessageBox.Show(message)
    End Sub

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

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim connectionString As String = "Data Source=.;Initial Catalog=CJUMH;Integrated Security=True"

        Try
            Using conexion As New SqlConnection(connectionString)
                conexion.Open()

                Dim consulta As String = "INSERT INTO delegaciones_procuradores (procurador_que_delega, número_expediente, numero_juez, caso, materia, usuario, teléfono_usuario, estado_actual, observación, nuevo_iniciado, nuevo_procurador) VALUES (@procurador_que_delega, @número_expediente, @numero_juez, @caso, @materia, @usuario, @teléfono_usuario, @estado_actual, @observación, @nuevo_iniciado, @nuevo_procurador)"

                comando = New SqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@procurador_que_delega", ComboBox1.SelectedValue.ToString)
                comando.Parameters.AddWithValue("@número_expediente", Int64.Parse(txtnumeroexpediente.Text))
                comando.Parameters.AddWithValue("@numero_juez", txtnumerojuez.Text)
                comando.Parameters.AddWithValue("@caso", txtcaso.Text)
                comando.Parameters.AddWithValue("@materia", ComboBox2.SelectedItem.ToString)
                comando.Parameters.AddWithValue("@usuario", ComboBox3.SelectedValue.ToString)
                comando.Parameters.AddWithValue("@teléfono_usuario", Integer.Parse(txttelefono.Text))
                comando.Parameters.AddWithValue("@estado_actual", txtestadoactual.Text)
                comando.Parameters.AddWithValue("@observación", txtobservacion.Text)
                comando.Parameters.AddWithValue("@nuevo_iniciado", If(rbtnnuevo.Checked, "Nuevo", "Iniciado"))
                comando.Parameters.AddWithValue("@nuevo_procurador", txtnuevoprocurador.Text)

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

    Private Sub txtnumeroexpediente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnumeroexpediente.KeyPress, txtnumeroexpediente.KeyPress
        ' Verificar si el carácter ingresado no es un número
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Cancelar el evento de tecla presionada
            e.Handled = True
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Try
            If ComboBox3.SelectedIndex <> -1 Then
                Dim selectedNombreApellidos As String = ComboBox3.SelectedValue.ToString()
                Dim numeroCelular As String = ObtenerNumeroCelular(selectedNombreApellidos)
                txttelefono.Text = numeroCelular
            End If
        Catch ex As Exception
            MessageBox.Show("Error al obtener el número de celular: " & ex.Message)
        End Try
    End Sub

    Private Sub txttelefono_TextChanged(sender As Object, e As EventArgs) Handles txttelefono.TextChanged

    End Sub
    Private Sub txttelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttelefono.KeyPress, txttelefono.KeyPress
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






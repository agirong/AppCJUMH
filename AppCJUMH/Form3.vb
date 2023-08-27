Imports System.Collections.ObjectModel
Imports System.Data.SqlClient

Public Class Form3
    Dim comando As SqlCommand
    Dim connection As SqlConnection

    Private datos1 As DataTable
    Private datos2 As DataTable

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "Data Source=LAPTOP-DLNMBOV3\SQLEXPRESS;Initial Catalog=CJUMH;Integrated Security=True"
        connection = New SqlConnection(connectionString)

        Try
            connection.Open()
            datos1 = ObtenerDatos1()
            datos2 = ObtenerDatos2()

            ComboBox3.DisplayMember = "nombre_y_apellidos"
            ComboBox3.ValueMember = "nombre_y_apellidos"
            ComboBox3.DataSource = datos1

            ComboBox1.DisplayMember = "procurador_que_delega"
            ComboBox1.ValueMember = "procurador_que_delega"
            ComboBox1.DataSource = datos2

            ComboBox3.SelectedIndex = -1

            connection.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message)
        End Try
    End Sub

    Private Function ObtenerDatos1() As DataTable
        Dim datos As New DataTable()
        Dim connectionString As String = "Data Source=LAPTOP-DLNMBOV3\SQLEXPRESS;Initial Catalog=CJUMH;Integrated Security=True"

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT nombre_y_apellidos FROM usuario"
            Using command As New SqlCommand(query, connection)
                Dim adapter As New SqlDataAdapter(command)
                adapter.Fill(datos)
            End Using
        End Using

        Return datos
    End Function

    Private Function ObtenerDatos2() As DataTable
        Dim datos As New DataTable()
        Dim connectionString As String = "Data Source=LAPTOP-DLNMBOV3\SQLEXPRESS;Initial Catalog=CJUMH;Integrated Security=True"

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT procurador_que_delega FROM delegaciones_procuradores"
            Using command As New SqlCommand(query, connection)
                Dim adapter As New SqlDataAdapter(command)
                adapter.Fill(datos)
            End Using
        End Using

        Return datos
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

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim connectionString As String = "Data Source=LAPTOP-DLNMBOV3\SQLEXPRESS;Initial Catalog=CJUMH;Integrated Security=True"

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
        MsgBox("Se va a cerrar el formulario")
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






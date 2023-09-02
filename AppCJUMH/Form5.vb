Imports System.Data.SqlClient

Public Class Form5
    Dim comando As SqlCommand
    Dim connection As SqlConnection

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '' Establecer la conexión con la base de datos
        Dim connectionString As String = "Data Source=.;Initial Catalog=CJUMH;Integrated Security=True"
        connection = New SqlConnection(connectionString)

        LoadComboBoxData()
    End Sub

    'YM: Crear un metodo nuevo para cargar la data a los combobox 
    Private Sub LoadComboBoxData()
        Try
            ' Llenar ComboBox1 con los nombres y apellidos de la tabla usuario
            ComboBox1.DataSource = ConexionDB.GetDataTable("SELECT nombre_y_apellidos FROM usuario")
            ComboBox1.DisplayMember = "nombre_y_apellidos"
            ComboBox1.ValueMember = "nombre_y_apellidos"

            ' Llenar ComboBox4 con los procuradores que delegan de la tabla delegaciones_procuradores
            ComboBox4.DataSource = ConexionDB.GetDataTable("SELECT procurador_que_delega FROM delegaciones_procuradores")
            ComboBox4.DisplayMember = "procurador_que_delega"
            ComboBox4.ValueMember = "procurador_que_delega"

            ' Llenar ComboBox5 con los nuevos procuradores de la tabla delegaciones_procuradores
            ComboBox5.DataSource = ConexionDB.GetDataTable("SELECT nuevo_procurador FROM delegaciones_procuradores")
            ComboBox5.DisplayMember = "nuevo_procurador"
            ComboBox5.ValueMember = "nuevo_procurador"

        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message)
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim selectedNombreApellidos As String = ComboBox1.SelectedValue.ToString()

        Dim correoElectronico As String = ConexionDB.GetCorreo(selectedNombreApellidos)
        txtcorreoelectronico.Text = correoElectronico

        Dim numeroCelular As String = ConexionDB.GetNumeroCelular(selectedNombreApellidos)
        txtnumerocelular.Text = numeroCelular
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim connectionString As String = "Data Source=.;Initial Catalog=CJUMH;Integrated Security=True"

        Try

            'Ym:         Hacer el insert usando la clase ConexionDB
            Dim parametros As SqlParameter() = {
            New SqlParameter("@nombre_usuario", ComboBox1.SelectedValue.ToString()),
            New SqlParameter("@celular_usuario", Integer.Parse(txtnumerocelular.Text)),
            New SqlParameter("@correo_usuario", txtcorreoelectronico.Text),
            New SqlParameter("@nombre_demandado", txtdemandado.Text),
            New SqlParameter("@nombre_demandante", txtdemandante.Text),
            New SqlParameter("@tipo_caso", txttipocaso.Text),
            New SqlParameter("@categoria", ComboBox2.SelectedItem.ToString),
            New SqlParameter("@número_expediente", Int64.Parse(txtnumeroexpediente.Text)),
            New SqlParameter("@número_juez", txtjuez.Text),
            New SqlParameter("@estado", ComboBox3.SelectedItem.ToString),
            New SqlParameter("@nombre_procurador_que_delega", ComboBox4.SelectedValue.ToString),
            New SqlParameter("@nombre_procurador_delegado", ComboBox5.SelectedValue.ToString),
            New SqlParameter("@carnet_procurador_que_delega", txtcarnetquedelega.Text),
            New SqlParameter("@carnet_procurador_delegado", txtcarnetdelegado.Text),
            New SqlParameter("@fecha_primera_atención", DateTimePicker1.Value.ToString("yyyy-MM-dd")),
            New SqlParameter("@fecha_ultima_atención", DateTimePicker1.Value.ToString("yyyy-MM-dd")),
            New SqlParameter("@zona_consultorio", ComboBox6.SelectedItem.ToString),
            New SqlParameter("@descripción", txtdescripcion.Text),
            New SqlParameter("@delegar_caso", ComboBox7.SelectedItem.ToString)
            }

            Dim consulta As String = "INSERT INTO casos_judiciales (nombre_usuario, celular_usuario, correo_usuario, nombre_demandado, nombre_demandante, tipo_caso, categoria, número_expediente, número_juez, estado, nombre_procurador_que_delega, nombre_procurador_delegado, carnet_procurador_que_delega, carnet_procurador_delegado, fecha_primera_atención, fecha_ultima_atención, zona_consultorio, descripción, delegar_caso) VALUES (@nombre_usuario, @celular_usuario, @correo_usuario, @nombre_demandado, @nombre_demandante, @tipo_caso, @categoria, @número_expediente, @número_juez, @estado, @nombre_procurador_que_delega, @nombre_procurador_delegado, @carnet_procurador_que_delega, @carnet_procurador_delegado, @fecha_primera_atención, @fecha_ultima_atención, @zona_consultorio, @descripción, @delegar_caso)"
            ConexionDB.InsertData(consulta, parametros)

            MsgBox("Datos guardados correctamente")

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


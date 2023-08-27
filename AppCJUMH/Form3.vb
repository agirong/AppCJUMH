Imports System.Collections.ObjectModel
Imports System.Data.SqlClient

Public Class Form3
    'YM. Definir una sola cadena de conexion para el Form3
    Private Const ConnectionString As String = "Data Source=.;Initial Catalog=CJUMH;Integrated Security=True"
    Dim comando As SqlCommand

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            'YM. Llama r la funcion que Cargara los datos en los combobox 
            LoadComboBoxData()
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message)
        End Try
    End Sub
    'YM. Definir una funcion para cargar los datos en los combobox
    Private Sub LoadComboBoxData()
        Try
            ComboBox3.DataSource = ConexionDB.GetDataTable("SELECT nombre_y_apellidos FROM usuario")
            ComboBox3.DisplayMember = "nombre_y_apellidos"
            ComboBox3.ValueMember = "nombre_y_apellidos"

            ComboBox1.DataSource = ConexionDB.GetDataTable("SELECT procurador_que_delega FROM delegaciones_procuradores")
            ComboBox1.DisplayMember = "procurador_que_delega"
            ComboBox1.ValueMember = "procurador_que_delega"

            ComboBox3.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message)
        End Try
    End Sub
    'YM. Mejorar la conexión del metodó guardar.
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try
            Dim parametros As SqlParameter() = {
                New SqlParameter("@procurador_que_delega", ComboBox1.SelectedValue.ToString),
                New SqlParameter("@número_expediente", Int64.Parse(txtnumeroexpediente.Text)),
                New SqlParameter("@numero_juez", txtnumerojuez.Text),
                New SqlParameter("@caso", txtcaso.Text),
                New SqlParameter("@materia", ComboBox2.SelectedItem.ToString),
                New SqlParameter("@usuario", ComboBox3.SelectedValue.ToString),
                New SqlParameter("@teléfono_usuario", Integer.Parse(txttelefono.Text)),
                New SqlParameter("@estado_actual", txtestadoactual.Text),
                New SqlParameter("@observación", txtobservacion.Text),
                New SqlParameter("@nuevo_iniciado", If(rbtnnuevo.Checked, "Nuevo", "Iniciado")),
                New SqlParameter("@nuevo_procurador", txtnuevoprocurador.Text)
            }

            Dim consulta As String = "INSERT INTO delegaciones_procuradores (procurador_que_delega, número_expediente, numero_juez, caso, materia, usuario, teléfono_usuario, estado_actual, observación, nuevo_iniciado, nuevo_procurador) VALUES (@procurador_que_delega, @número_expediente, @numero_juez, @caso, @materia, @usuario, @teléfono_usuario, @estado_actual, @observación, @nuevo_iniciado, @nuevo_procurador)"
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
                Dim numeroCelular As String = ConexionDB.GetNumeroCelular(selectedNombreApellidos)
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






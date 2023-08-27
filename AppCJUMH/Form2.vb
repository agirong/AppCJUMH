Imports System.Data.SqlClient

Public Class Form2
    Dim comando As SqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim connectionString As String = "Data Source=LAPTOP-DLNMBOV3\SQLEXPRESS;Initial Catalog=CJUMH;Integrated Security=True"

        Try
            Using conexion As New SqlConnection(connectionString)
                conexion.Open()

                Dim consulta As String = "INSERT INTO seguimiento_PPS (nombre_procurador, teléfono_procurador, número_de_cuenta, modalidad_institución, nombre_institución, teléfono_institución, correo_institución, nombre_encargado_del_procurador, teléfono_encargado_del_procurador, cargo_que_ostenta) VALUES (@nombre_procurador, @teléfono_procurador, @número_de_cuenta, @modalidad_institución, @nombre_institución, @teléfono_institución, @correo_institución, @nombre_encargado_del_procurador, @teléfono_encargado_del_procurador, @cargo_que_ostenta)"

                comando = New SqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@nombre_procurador", txtnombreprocurador.Text)
                comando.Parameters.AddWithValue("@teléfono_procurador", Integer.Parse(txttelefonoprocurador.Text))
                comando.Parameters.AddWithValue("@número_de_cuenta", Int64.Parse(txtnumerocuenta.Text))
                comando.Parameters.AddWithValue("@modalidad_institución", ComboBox2.SelectedItem.ToString)
                comando.Parameters.AddWithValue("@nombre_institución", txtinstitucion.Text)
                comando.Parameters.AddWithValue("@teléfono_institución", Integer.Parse(txttelefonoinstitucion.Text))
                comando.Parameters.AddWithValue("@correo_institución", txtcorreoelectronico.Text)
                comando.Parameters.AddWithValue("@nombre_encargado_del_procurador", txtnombrencargado.Text)
                comando.Parameters.AddWithValue("@teléfono_encargado_del_procurador", Integer.Parse(txttelefonoencargado.Text))
                comando.Parameters.AddWithValue("@cargo_que_ostenta", txtcargoqueostenta.Text)

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

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        'Call Limpia_objetos(Me)
    End Sub

    Private Sub txtnumerocuenta_TextChanged(sender As Object, e As EventArgs) Handles txtnumerocuenta.TextChanged

    End Sub
    Private Sub txtnumerocuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnumerocuenta.KeyPress
        ' Verificar si el carácter ingresado no es un número
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Cancelar el evento de tecla presionada
            e.Handled = True
        End If
    End Sub

    Private Sub txttelefonoprocurador_TextChanged(sender As Object, e As EventArgs) Handles txttelefonoprocurador.TextChanged

    End Sub
    Private Sub txttelefonoprocurador_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttelefonoprocurador.KeyPress
        ' Verificar si el carácter ingresado no es un número
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Cancelar el evento de tecla presionada
            e.Handled = True
        End If
    End Sub

    Private Sub txttelefonoinstitucion_TextChanged(sender As Object, e As EventArgs) Handles txttelefonoinstitucion.TextChanged

    End Sub
    Private Sub txttelefonoinstitucion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttelefonoinstitucion.KeyPress
        ' Verificar si el carácter ingresado no es un número
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Cancelar el evento de tecla presionada
            e.Handled = True
        End If
    End Sub

    Private Sub txttelefonoencargado_TextChanged(sender As Object, e As EventArgs) Handles txttelefonoencargado.TextChanged

    End Sub
    Private Sub txttelefonoencargado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttelefonoencargado.KeyPress
        ' Verificar si el carácter ingresado no es un número
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Cancelar el evento de tecla presionada
            e.Handled = True
        End If
    End Sub
End Class

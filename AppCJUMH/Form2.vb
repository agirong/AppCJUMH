Imports System.Data.SqlClient

Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnguardar.Click

        Try
            Dim Parametros As SqlParameter() = {
                New SqlParameter("@nombre_procurador", txtnombreprocurador.Text),
                New SqlParameter("@teléfono_procurador", Integer.Parse(txttelefonoprocurador.Text)),
                New SqlParameter("@número_de_cuenta", Int64.Parse(txtnumerocuenta.Text)),
                New SqlParameter("@modalidad_institución", ComboBox2.SelectedItem.ToString),
                New SqlParameter("@nombre_institución", txtinstitucion.Text),
                New SqlParameter("@teléfono_institución", Integer.Parse(txttelefonoinstitucion.Text)),
                New SqlParameter("@correo_institución", txtcorreoelectronico.Text),
                New SqlParameter("@nombre_encargado_del_procurador", txtnombrencargado.Text),
                New SqlParameter("@teléfono_encargado_del_procurador", Integer.Parse(txttelefonoencargado.Text)),
                New SqlParameter("@cargo_que_ostenta", txtcargoqueostenta.Text)
                }

            Dim consulta As String = "INSERT INTO seguimiento_PPS (nombre_procurador, teléfono_procurador, número_de_cuenta, modalidad_institución, nombre_institución, teléfono_institución, correo_institución, nombre_encargado_del_procurador, teléfono_encargado_del_procurador, cargo_que_ostenta) VALUES (@nombre_procurador, @teléfono_procurador, @número_de_cuenta, @modalidad_institución, @nombre_institución, @teléfono_institución, @correo_institución, @nombre_encargado_del_procurador, @teléfono_encargado_del_procurador, @cargo_que_ostenta)"
            ConexionDB.InsertData(consulta, Parametros)
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

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

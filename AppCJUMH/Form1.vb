Imports System.Data.SqlClient

Public Class Form1
    Dim comando As SqlCommand

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.HorizontalScroll.Maximum = 0
        Me.AutoScroll = True
        Dim horaActual As New DateTime(DateTime.Now.TimeOfDay.Ticks)
        txthora.Text = horaActual


        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = "Data Source=.;Initial Catalog=CJUMH;Integrated Security=True"
        conexion.Open()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lbltitulo3.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles lblprocurador.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles lblservicio.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles lblgenero.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles lblnombreuser.Click

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles lbldocumentacion.Click

    End Sub




    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles txtotro1.TextChanged

    End Sub

    Private Sub lblescolaridad_Click(sender As Object, e As EventArgs) Handles lblescolaridad.Click

    End Sub

    Private Sub lbloficio_Click(sender As Object, e As EventArgs) Handles lbloficio.Click
    End Sub

    Private Sub lbllugartrabajo_Click(sender As Object, e As EventArgs) Handles lbllugartrabajo.Click
    End Sub


    Private Sub lbldocurecibida_Click(sender As Object, e As EventArgs) Handles lbldocurecibida.Click
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnno1.CheckedChanged

    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try
            'YM: INSERTAR LOS DATOS A LA TABLA casos 
            Dim vMedioServicio As String = ""

            If Len(Trim(txtotro.Text)) = 0 Then
                vMedioServicio = ComboBox2.SelectedItem.ToString()
            Else
                vMedioServicio = txtotro.Text
            End If

            Dim parametros As SqlParameter() = {
                New SqlParameter("@nombre_director", txtdirector.Text),
                New SqlParameter("@nombre_procurador", txtprocurador.Text),
                New SqlParameter("@fecha", DateTimePicker1.Value.Date),
                New SqlParameter("@hora", txthora.Text),
                New SqlParameter("@metodo_servicio", ComboBox1.SelectedItem.ToString),
                New SqlParameter("@documentación_recibida", txtdocureci.Text),
                New SqlParameter("@hechos_del_caso", txthechos.Text),
                New SqlParameter("@ciudad", ComboBox5.SelectedItem.ToString),
                New SqlParameter("@medio_servicio", vMedioServicio)
            }
            Dim consulta As String = "INSERT INTO casos (nombre_director, nombre_procurador, fecha, hora, metodo_servicio, medio_servicio, documentación_recibida, hechos_del_caso, ciudad) VALUES (@nombre_director, @nombre_procurador, @fecha, @hora, @metodo_servicio, @medio_servicio, @documentación_recibida, @hechos_del_caso, @ciudad)"
            ConexionDB.InsertData(consulta, parametros)

            'YM: INSERTAR LOS DATOS A LA TABLA casos 
            Dim parametrosUsuario As SqlParameter() = {
                New SqlParameter("@genero", ComboBox2.SelectedItem.ToString()),
                New SqlParameter("@nombre_y_apellidos", txtnombreuser.Text),
                New SqlParameter("@profesion", txtprofesion.Text),
                New SqlParameter("@telefono_fijo", Integer.Parse(txtfijo.Text)),
                New SqlParameter("@telefono_movil", Integer.Parse(txtmovil.Text)),
                New SqlParameter("@nombre_y_telefono_de_alguien_de_confianza", txtnombreytelefonoconfianza.Text),
                New SqlParameter("@correo_electronico", txtcorreo.Text),
                New SqlParameter("@tipo_documentacion", txtdocumentacion.Text),
                New SqlParameter("@DNI", Int64.Parse(txtidentidad.Text)),
                New SqlParameter("@nacionalidad", txtnacionalidad.Text),
                New SqlParameter("@domicilio", txtdomicilio.Text),
                New SqlParameter("@lugar_nacimiento", txtlugarnaci.Text),
                New SqlParameter("@fecha_nacimiento", DateTimePicker2.Value.ToString("yyyy-MM-dd")),
                New SqlParameter("@edad", Integer.Parse(txtedad.Text)),
                New SqlParameter("@etnia", txtetnia.Text),
                New SqlParameter("@estado_civil", ComboBox4.SelectedItem.ToString()),
                New SqlParameter("@sabe_leer", If(rbtnsi0.Checked, "Si", "No")),
                New SqlParameter("@sabe_escribir", If(rbtnsi1.Checked, "Si", "No")),
                New SqlParameter("@escolaridad", txtescolaridad.Text),
                New SqlParameter("@trabaja", If(RadioButton1.Checked, "Si", "No")),
                New SqlParameter("@profesion_u_oficio", txtprofesion.Text),
                New SqlParameter("@lugar_de_trabajo", txtlugartrabajo.Text)
            }

            Dim consulta1 As String = "INSERT INTO usuario (genero, nombre_y_apellidos, profesion, telefono_fijo, telefono_movil, nombre_y_telefono_de_alguien_de_confianza, correo_electronico, tipo_documentacion, DNI, nacionalidad, domicilio, lugar_nacimiento, fecha_nacimiento, edad, etnia, estado_civil, sabe_leer, sabe_escribir, escolaridad, trabaja, profesion_u_oficio, lugar_de_trabajo) " &
                             "VALUES (@genero, @nombre_y_apellidos, @profesion, @telefono_fijo, @telefono_movil, @nombre_y_telefono_de_alguien_de_confianza, @correo_electronico, @tipo_documentacion, @DNI, @nacionalidad, @domicilio, @lugar_nacimiento, @fecha_nacimiento, @edad, @etnia, @estado_civil, @sabe_leer, @sabe_escribir, @escolaridad, @trabaja, @profesion_u_oficio, @lugar_de_trabajo)"
            ConexionDB.InsertData(consulta1, parametrosUsuario)

        Catch ex As Exception
            MessageBox.Show("Error al guardar los datos: " & ex.Message)
        End Try

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedItem.ToString() = "Otro" Then
            txtotro.Visible = True
        Else
            txtotro.Visible = False
        End If

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.SelectedItem.ToString() = "Otro" Then
            txtotro1.Visible = True
        Else
            txtotro1.Visible = False
        End If
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        'Call Limpia_objetos(Me)


    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        MsgBox("Se dirige al menu principal, los dato no guardados se perderan.")
        'YM. Crear una instancia del formulario que deseas mostrar
        Dim frmPrincipal As New frmPrincipal()
        'YM. Mostrar el formulario
        frmPrincipal.Show()

        Me.Close()

    End Sub

    Private Sub txtfijo_TextChanged(sender As Object, e As EventArgs) Handles txtfijo.TextChanged

    End Sub
    Private Sub txtfijo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtfijo.KeyPress
        ' Verificar si el carácter ingresado no es un número
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Cancelar el evento de tecla presionada
            e.Handled = True
        End If
    End Sub

    Private Sub txtmovil_TextChanged(sender As Object, e As EventArgs) Handles txtmovil.TextChanged

    End Sub
    Private Sub txtmovil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmovil.KeyPress
        ' Verificar si el carácter ingresado no es un número
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Cancelar el evento de tecla presionada
            e.Handled = True
        End If
    End Sub

    Private Sub txtedad_TextChanged(sender As Object, e As EventArgs) Handles txtedad.TextChanged

    End Sub
    Private Sub txtedad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtedad.KeyPress
        ' Verificar si el carácter ingresado no es un número
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Cancelar el evento de tecla presionada
            e.Handled = True
        End If
    End Sub

    Private Sub txtidentidad_TextChanged(sender As Object, e As EventArgs) Handles txtidentidad.TextChanged

    End Sub
    Private Sub txtidentidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtidentidad.KeyPress
        ' Verificar si el carácter ingresado no es un número
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Cancelar el evento de tecla presionada
            e.Handled = True
        End If
    End Sub

    Private Sub txthora_TextChanged(sender As Object, e As EventArgs) Handles txthora.TextChanged

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblnombreytelefonodealguiendeconfianza.Click

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub txtdirector_TextChanged(sender As Object, e As EventArgs) Handles txtdirector.TextChanged

    End Sub
End Class

Imports System.Data.SqlClient

Public Class ConexionDB
    Private Const ConnectionString As String = "Data Source=.;Initial Catalog=CJUMH;Integrated Security=True"

    Public Shared Function GetDataTable(query As String) As DataTable
        Using connection As New SqlConnection(ConnectionString)
            Dim dataTable As New DataTable()
            Using command As New SqlCommand(query, connection)
                Dim adapter As New SqlDataAdapter(command)
                adapter.Fill(dataTable)
            End Using
            Return dataTable
        End Using
    End Function

    Public Shared Sub InsertData(consulta As String, parametros As SqlParameter())
        Using connection As New SqlConnection(ConnectionString)
            connection.Open()
            Using command As New SqlCommand(consulta, connection)
                command.Parameters.AddRange(parametros)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    'YM. FUNCION del Form3.vb para buscar el numero de celular en funcion del usuario seleccionado. 
    Public Shared Function GetNumeroCelular(nombreApellidos As String) As String
        Dim numeroCelular As String = ""

        Try
            Using connection As New SqlConnection(ConnectionString)
                connection.Open()

                Dim query As String = "SELECT telefono_movil FROM usuario WHERE nombre_y_apellidos = @NombreApellidos"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@NombreApellidos", nombreApellidos)
                    Dim reader As SqlDataReader = command.ExecuteReader()

                    If reader.Read() Then
                        numeroCelular = reader("telefono_movil").ToString()
                    End If

                    reader.Close()
                End Using
            End Using
        Catch ex As Exception
            ' Manejo de errores aquí
        End Try

        Return numeroCelular
    End Function

    'YM. FUNCION PARA OBTENER CORREO
    Public Shared Function GetCorreo(nombreApellidos As String) As String
        Dim correoElectronico As String = ""

        Try
            Using connection As New SqlConnection(ConnectionString)
                connection.Open()

                Dim query As String = "SELECT correo_electronico FROM usuario WHERE nombre_y_apellidos = @NombreApellidos"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@NombreApellidos", nombreApellidos)
                    Dim reader As SqlDataReader = command.ExecuteReader()

                    If reader.Read() Then
                        correoElectronico = reader("correo_electronico").ToString()
                    End If

                    reader.Close()
                End Using
            End Using
        Catch ex As Exception
            ' Manejo de errores aquí
        End Try

        Return correoElectronico
    End Function

    'YM: Obtener los permisos especificos de un rol usado en frmRoles para recuperar los permisos del rol seleccioando
    Public Shared Function GetDataTableRoles(id As Integer) As DataTable
        Using connection As New SqlConnection(ConnectionString)
            connection.Open()
            Dim dataTable As New DataTable()
            Dim consulta As String = "SELECT * FROM roles WHERE id = @id"
            Using command As New SqlCommand(consulta, connection)
                command.Parameters.AddWithValue("@id", id) ' Pasar el valor del parámetro "id"
                Dim adapter As New SqlDataAdapter(command)
                adapter.Fill(dataTable)
            End Using
            Return dataTable
        End Using
    End Function
    'YM: Actualizar los permisos de un rol en especifico. 
    Public Shared Sub UpdatePermisosRol(id As Integer, pfichaAtencion As Boolean, pseguimientoPPS As Boolean, pdelegacionesProcuradores As Boolean, paudienciasVigentes As Boolean, pcasosPPS As Boolean, proles As Boolean, pusuarios As Boolean)
        Using connection As New SqlConnection(ConnectionString)
            connection.Open()
            Dim consulta As String = "UPDATE roles SET fichaAtencion = @fichaAtencion, seguimientoPPS = @seguimientoPPS, delegacionesProcuradores = @delegacionesProcuradores, audienciasVigentes = @audienciasVigentes, casosPPS = @casosPPS, roles = @roles, usuarios = @usuarios   WHERE id = @id"
            Using command As New SqlCommand(consulta, connection)
                command.Parameters.AddWithValue("@id", id)
                command.Parameters.AddWithValue("@fichaAtencion", pfichaAtencion)
                command.Parameters.AddWithValue("@seguimientoPPS", pseguimientoPPS)
                command.Parameters.AddWithValue("@delegacionesProcuradores", pdelegacionesProcuradores)
                command.Parameters.AddWithValue("@audienciasVigentes", paudienciasVigentes)
                command.Parameters.AddWithValue("@casosPPS", pcasosPPS)
                command.Parameters.AddWithValue("@roles", proles)
                command.Parameters.AddWithValue("@usuarios", pusuarios)
                ' Ejecutar la consulta de actualización
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    'YM: Hacer una funcion que permita autenticar al usuario. 
    Public Shared Function AutenticarUsuario(pUsuario As String, pContrasena As String) As Boolean
        Dim existeUsuario = False
        Using connection As New SqlConnection(ConnectionString)
            connection.Open()
            Dim dataTable As New DataTable()
            Dim consulta As String = "SELECT COUNT (*) FROM usuarios_umh WHERE user_umh = @user_umh AND contrasena =@contrasena"
            Using command As New SqlCommand(consulta, connection)
                command.Parameters.AddWithValue("@user_umh", pUsuario)
                command.Parameters.AddWithValue("@contrasena", pContrasena)
                ' Utilizar ExecuteScalar para obtener el valor de recuento
                Dim recuento As Integer = CInt(command.ExecuteScalar())

                ' Si el recuento es mayor que cero, significa que el usuario existe
                If recuento > 0 Then
                    existeUsuario = True
                End If

            End Using
            Return existeUsuario
        End Using
    End Function
End Class

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
End Class

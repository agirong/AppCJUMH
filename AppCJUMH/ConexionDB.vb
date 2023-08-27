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
End Class

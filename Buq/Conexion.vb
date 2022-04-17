Imports MySql.Data.MySqlClient

Friend Class Conexion
    Private Shared server As String = "localhost"
    Private Shared database As String = "bdbuqsucmatprim"
    Private Shared username As String = "root"
    Private Shared password As String = "root"
    Private Shared _cnn As String = "Server=" & server & ";Uid=" & username & ";Pwd=" & password & ";Database=" & database & ";SslMode=None"

    Friend Shared Function conexion() As MySqlConnection
        Try
            Dim cnn As MySqlConnection = New MySqlConnection(_cnn)
            Return cnn
        Catch ex As Exception
            Throw New Exception("Error al conectar a MySQL " & ex.Message)
        End Try
    End Function
End Class


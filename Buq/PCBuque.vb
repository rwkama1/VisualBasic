Imports MySql.Data.MySqlClient

Public Class PCBuque

    Friend Shared Function buscarBuq(matprim As Integer, mano As Integer) As CBuq
        Dim consulta As String = $"select Buq.Codigo,Buq.Nombre from Buq inner join SucMatPrimBuq on Buq.Codigo=SucMatPrimBuq.Buq
                                   inner join Mano on SucMatPrimBuq.Suc=Mano.Suc 
                                   inner join Suc on Mano.Suc=Suc.Codigo inner join MatPrim on MatPrim.Codigo=SucMatPrimBuq.MatPrim 
                                  where Mano.Codigo={mano} and MatPrim.Codigo={matprim}"
        Dim cnn As MySqlConnection = Conexion.conexion()
        Dim comand As MySqlCommand = New MySqlCommand(consulta, cnn)
        Dim cbuq As CBuq = Nothing

        Try
            cnn.Open()
            Dim _lector As MySqlDataReader = comand.ExecuteReader()

            If _lector.HasRows Then

                If _lector.Read() Then
                    Dim codigo As Integer = Convert.ToInt32((_lector("Codigo")))
                    Dim nombre As String = CStr(_lector("Nombre"))

                    cbuq = New CBuq()
                    cbuq.Codigo1 = codigo
                    cbuq.Nombre1 = nombre

                End If


            End If

            _lector.Close()
        Catch ex As Exception
            Throw New Exception("No se pudo buscar " & ex.Message)
        Finally
            cnn.Close()
        End Try

        Return cbuq
    End Function
End Class
'select Buq.Codigo,Buq.Nombre from Buq inner join SucMatPrimBuq on Buq.Codigo=SucMatPrimBuq.Buq
'                                   inner join Mano on SucMatPrimBuq.Suc=Mano.Suc 
'                                   inner join Suc on Mano.Suc=Suc.Codigo inner join MatPrim on MatPrim.Codigo=SucMatPrimBuq.MatPrim 
'                                  where Mano.Codigo=1 and MatPrim.Codigo=2;

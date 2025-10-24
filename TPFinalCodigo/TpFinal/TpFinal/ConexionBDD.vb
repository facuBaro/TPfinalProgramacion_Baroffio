Imports MySql.Data.MySqlClient
Public Class ConexionBDD

    Protected conexion As MySqlConnection = New MySqlConnection()
    Private cadenaConexion As String = "server=localhost;port=3000;user id=root;password=;database=proyectofinalbdd"

    Function establecerConexion() As MySqlConnection

        Try
            conexion.ConnectionString = cadenaConexion
            conexion.Open()

        Catch ex As Exception
            MessageBox.Show("No se conecto a la base de datos" + ex.ToString)

        End Try
        Return conexion
    End Function
    Public Sub cerrarConexion()
        Try
            If (conexion.State <> ConnectionState.Closed) Then
                conexion.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Se produjo un error al cerrar la conexion" + ex.ToString)
        End Try
    End Sub
End Class

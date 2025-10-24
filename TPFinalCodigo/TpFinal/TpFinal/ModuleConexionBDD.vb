Imports MySql.Data.MySqlClient

Module ModuleConexionBDD
    'En este modulo voy a realizar la conexion a mi base de datos

    Private conexion As String = "server=localhost;user id=root;password=root;database=proyectofinalbdd"
    Public Function ConectarBDD() As MySqlConnection
        Return New MySqlConnection(conexion)
    End Function


End Module

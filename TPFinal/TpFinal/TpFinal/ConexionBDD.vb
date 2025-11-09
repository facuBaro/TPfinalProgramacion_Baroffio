Imports MySql.Data.MySqlClient
Imports System.IO

Public Class ConexionBDD

    Protected conexion As MySqlConnection = New MySqlConnection()
    Private cadenaConexion As String

    Public Sub New()
        Dim puerto As String = LeerPuertoDesdeTxt()

        ' Si el archivo no existe o está vacío, uso el valor por defecto (3306)
        If String.IsNullOrEmpty(puerto) Then
            puerto = "3306"
        End If

        cadenaConexion = $"server=localhost;port={puerto};user id=root;password=;database=proyectofinalbdd"
    End Sub

    Private Function LeerPuertoDesdeTxt() As String
        Try
            Dim ruta As String = Path.Combine(Application.StartupPath, "configPuerto.txt")

            If File.Exists(ruta) Then
                Return File.ReadAllText(ruta).Trim()
            Else
                ' Si no existe, lo crea con el valor por defecto
                File.WriteAllText(ruta, "3306")
                Return "3306"
            End If

        Catch ex As Exception
            MessageBox.Show("Error al leer el archivo de configuración del puerto: " & ex.Message)
            Return "3306"
        End Try
    End Function

    Function establecerConexion() As MySqlConnection
        Try
            conexion.ConnectionString = cadenaConexion
            conexion.Open()
        Catch ex As Exception
            MessageBox.Show("No se conectó a la base de datos: " & vbCrLf &
                    ex.Message & vbCrLf & vbCrLf &
                     "Cadena usada: " & cadenaConexion)
        End Try
        Return conexion
    End Function

    Public Sub cerrarConexion()
        Try
            If (conexion.State <> ConnectionState.Closed) Then
                conexion.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Se produjo un error al cerrar la conexión: " & ex.ToString)
        End Try
    End Sub
End Class

Imports System.Net
Imports System.Runtime.InteropServices.JavaScript.JSType
Imports System.Runtime.Intrinsics.X86
Imports MySql.Data.MySqlClient
Public Class LogueoUsuarios
    Inherits ConexionBDD
    Private usuario As String
    Private contraseña As String
    Public Property usuario2 As String
        Get
            Return usuario
        End Get
        Set(value As String)


            usuario = value



        End Set
    End Property
    Public Property contraseña2 As String
        Get
            Return contraseña
        End Get
        Set(value As String)

            If (Me.usuario = value) Then
                MessageBox.Show("Error, verifique que el usuario y contraseña no sean iguales ")
            Else
                contraseña = value
            End If

        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(usuario As String, contraseña As String)
        Me.usuario2 = usuario
        Me.contraseña2 = contraseña
    End Sub
    Public Overridable Function CorroborarDatos() As Boolean
        Dim resultado As Boolean = False
        Dim lector As MySqlDataReader = Nothing
        Try
            establecerConexion()
            Dim consulta As String = "SELECT * FROM login WHERE usuario=@usuario and contraseña=@contraseña"
            Dim comando As New MySqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@usuario", Me.usuario)
            comando.Parameters.AddWithValue("@contraseña", Me.contraseña)

            lector = comando.ExecuteReader()
            If lector.HasRows() Then
                resultado = True
            End If
        Catch ex As Exception
            MessageBox.Show("Se produjo un error " + ex.ToString)
        Finally
            If lector IsNot Nothing Then lector.Close()
            cerrarConexion()
        End Try
        Return resultado
    End Function


End Class

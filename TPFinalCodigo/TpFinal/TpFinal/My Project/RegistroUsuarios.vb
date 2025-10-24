Imports MySql.Data.MySqlClient

Public Class RegistroUsuarios
    Inherits LogueoUsuarios
    Private usuario As String
    Private contraseña As String
    Public Property usuario2 As String
        Get
            Return usuario
        End Get
        Set(value As String)

            Dim longitud As Integer = Len(value)

            If (longitud < 3) Then
                MessageBox.Show("Error, nombre de usuario demasiado corto, minimo 3 caracteres")
            Else
                usuario = value
            End If


        End Set
    End Property
    Public Property contraseña2 As String
        Get
            Return contraseña
        End Get
        Set(value As String)
            Dim longitud As Integer = Len(value)
            If (Me.usuario = value Or longitud < 3) Then
                MessageBox.Show("Error, verifique que el usuario y contraseña no sean iguales y que ambos contengan al menos 3 caracteres")
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
    Public Overrides Function CorroborarDatos() As Boolean
        Dim resultado As Boolean = False
        Dim lector As MySqlDataReader = Nothing
        Try
            establecerConexion()
            Dim consulta As String = "SELECT * FROM login WHERE usuario=@usuario"
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
    Public Sub RegistrarUsuarios()
        If (CorroborarDatos() = False And Not String.IsNullOrEmpty(Me.contraseña) And Not String.IsNullOrEmpty(Me.usuario)) Then
            Dim objetoConexion As ConexionBDD = New ConexionBDD()
            Try
                Dim consulta As String = "INSERT INTO login(usuario,contraseña)VALUES(@usuario,@contraseña);"
                Dim comando As MySqlCommand = New MySqlCommand(consulta, objetoConexion.establecerConexion())

                comando.Parameters.AddWithValue("@usuario", Me.usuario)
                comando.Parameters.AddWithValue("@contraseña", Me.contraseña)
                comando.ExecuteNonQuery()
                MessageBox.Show("Se registro al usuario correctamente, por favor vuelva hacia atras e inicie sesion con su cuenta")
            Catch ex As Exception
                MessageBox.Show("Error al registrar el usuario," + ex.ToString)
            Finally
                objetoConexion.cerrarConexion()
            End Try
        Else
            If CorroborarDatos() = True Then
                MessageBox.Show("Error,Usuario ya registrado")
            Else
                MessageBox.Show("Error,Datos invalidos")
            End If
        End If
    End Sub
End Class

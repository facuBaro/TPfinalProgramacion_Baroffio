Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient

Public Class clientes
    Inherits ConexionBDD
    Private id_cliente As Integer
    Private nombre As String
    Private telefono As Long
    Private correo As String

    Public Property id_cliente2 As Integer
        Get
            Return id_cliente
        End Get
        Set(value As Integer)
            If (value < 0) Then
                MessageBox.Show("Error al ingresar id_cliente, es menor a 0")
            Else
                id_cliente = value
            End If


        End Set
    End Property

    Public Property nombre2 As String
        Get
            Return nombre
        End Get
        Set(value As String)
            Dim longitud As Integer
            Dim aux As Integer

            longitud = Len(value)
            For i = 0 To longitud - 1

                If IsNumeric(value(i)) Then
                    aux = aux + 1
                End If
            Next i
            If aux >= 1 Then
                MessageBox.Show("Nombre invalido, no debe contener valores numericos")

            Else
                nombre = value
            End If
        End Set
    End Property
    Public Property telefono2 As Long
        Get
            Return telefono
        End Get
        Set(value As Long)
            If telefono < 0 Then
                MessageBox.Show("Error al ingresar el telefono, no puede ser menor a 0.")
            Else
                telefono = value
            End If
        End Set
    End Property
    Public Property correo2 As String
        Get
            Return correo
        End Get
        Set(value As String)
            Dim longitud As Integer
            Dim aux As Integer

            longitud = Len(value)
            For i = 0 To longitud - 1

                If value(i) = "@" Then
                    aux = aux + 1
                End If
            Next i
            If aux < 1 Then
                MsgBox("Correo invalido, no contiene ningun simbolo de @ .")

            Else
                correo = value
            End If
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(nombre As String, telefono As Long, correo As String)
        Me.nombre2 = nombre
        Me.telefono2 = telefono
        Me.correo2 = correo
    End Sub
    'muestra los clientes en datagrid
    Public Sub mostrarClientes(tablaClientes As DataGridView)
        Try
            tablaClientes.DataSource = Nothing
            Dim consulta As String = "SELECT * FROM clientes"
            Dim adaptador As MySqlDataAdapter = New MySqlDataAdapter(consulta, establecerConexion())
            Dim tabla As DataTable = New DataTable()
            adaptador.Fill(tabla)
            tablaClientes.DataSource = tabla

        Catch ex As Exception
            MessageBox.Show("Error al mostrar los clientes" + ex.ToString)
        Finally
            cerrarConexion()
        End Try
    End Sub

    'Alta de clientes
    Public Sub altaCliente()
        If (CorroborarCliente() = False And Not String.IsNullOrWhiteSpace(Me.nombre) And Me.telefono > 0 And Not String.IsNullOrWhiteSpace(Me.correo)) Then
            Try
                Dim consulta As String = "INSERT INTO clientes(nombre,telefono,correo)VALUES(@nombre,@telefono,@correo)"
                Dim comando As MySqlCommand = New MySqlCommand(consulta, establecerConexion())
                comando.Parameters.AddWithValue("@nombre", Me.nombre)
                comando.Parameters.AddWithValue("@telefono", Me.telefono)
                comando.Parameters.AddWithValue("@correo", Me.correo)
                comando.ExecuteNonQuery()
                MessageBox.Show("El cliente fue registrado con exito")
            Catch ex As Exception
                MessageBox.Show("Error al registrar el cliente" + ex.ToString)
            Finally
                cerrarConexion()
            End Try
        Else
            If CorroborarCliente() = True Then
                MessageBox.Show("Error, el datos ya existentes")
            Else
                MessageBox.Show("Error, datos invalidos")
            End If
        End If


    End Sub

    'Verificar que no este el cliente a cargar
    Public Function CorroborarCliente() As Boolean
        Dim resultado As Boolean = False
        Dim lector As MySqlDataReader = Nothing
        Try
            Dim consulta As String = "SELECT * FROM clientes WHERE telefono=@telefono or correo=@correo"
            Dim comando As MySqlCommand = New MySqlCommand(consulta, establecerConexion())
            comando.Parameters.AddWithValue("@telefono", Me.telefono)
            comando.Parameters.AddWithValue("@correo", Me.correo)
            lector = comando.ExecuteReader()
            If lector.HasRows() Then
                resultado = True

            End If
        Catch ex As Exception
            MessageBox.Show("Se produjo un error al corroborar cliente ", ex.ToString)
        Finally
            If lector IsNot Nothing Then lector.Close()
            cerrarConexion()
        End Try
        Return resultado
    End Function

    'seleccionar datos de datagrid para luego modificar
    Public Sub SeleccionarCliente(tabla As DataGridView, txtIdcliente As TextBox, txtNombreCliente As TextBox, txtTelefonoCliente As TextBox, txtCorreoCliente As TextBox, txtActivo As TextBox)
        Try
            txtIdcliente.Text = tabla.CurrentRow.Cells(0).Value.ToString()
            txtNombreCliente.Text = tabla.CurrentRow.Cells(1).Value.ToString()
            txtTelefonoCliente.Text = tabla.CurrentRow.Cells(2).Value.ToString()
            txtCorreoCliente.Text = tabla.CurrentRow.Cells(3).Value.ToString()
            txtActivo.Text = tabla.CurrentRow.Cells(4).Value.ToString()
        Catch ex As Exception
            MessageBox.Show("No se logro seleccionar el registro " + ex.ToString)
        End Try
    End Sub

    'Modificar Clientes
    Public Sub ModificarCliente(tabla As DataGridView)
        If (Not String.IsNullOrWhiteSpace(Me.nombre) And Me.telefono > 0 And Not String.IsNullOrWhiteSpace(Me.correo)) Then
            Try
                Dim consulta As String = "UPDATE clientes SET nombre=@nombre,telefono=@telefono,correo=@correo WHERE id_cliente=@id_cliente;"
                Dim comando As MySqlCommand = New MySqlCommand(consulta, establecerConexion())
                Dim id_cliente As Integer = tabla.CurrentRow.Cells(0).Value
                comando.Parameters.AddWithValue("@id_cliente", id_cliente)
                comando.Parameters.AddWithValue("@nombre", Me.nombre)
                comando.Parameters.AddWithValue("@telefono", Me.telefono)
                comando.Parameters.AddWithValue("@correo", Me.correo)
                comando.ExecuteNonQuery()
                MessageBox.Show("El cliente fue modificado con exito")
            Catch ex As MySqlException
                If ex.Number = 1062 Then
                    MessageBox.Show("Error: ya existe un cliente con ese telefono o correo.")

                Else
                    MessageBox.Show("Error al modificar el cliente: " & ex.Message)

                End If

            Catch ex As Exception
                MessageBox.Show("Ocurrió un error inesperado: " & ex.Message)
            Finally
                cerrarConexion()
            End Try
        Else

            MessageBox.Show("Error, datos invalidos")

        End If


    End Sub


    'Eliminar Cliente
    Public Sub EliminarCliente(tabla As DataGridView, txtActivo As String)
        If (CorroborarCliente() = True And Not String.IsNullOrWhiteSpace(Me.nombre) And Me.telefono > 0 And Not String.IsNullOrWhiteSpace(Me.correo)) Then
            Try
                Dim consulta As String = "UPDATE clientes SET activo=@activo WHERE id_cliente=@id_cliente;"
                Dim comando As MySqlCommand = New MySqlCommand(consulta, establecerConexion())
                Dim id_cliente As Integer = tabla.CurrentRow.Cells(0).Value
                comando.Parameters.AddWithValue("@id_cliente", id_cliente)
                If (txtActivo = "si") Then
                    comando.Parameters.AddWithValue("@activo", "no")
                Else
                    comando.Parameters.AddWithValue("@activo", "si")
                End If
                comando.ExecuteNonQuery()
                MessageBox.Show("El cliente fue eliminado con exito")
            Catch ex As Exception
                MessageBox.Show("Error al eliminar el cliente" + ex.ToString)
            Finally
                cerrarConexion()
            End Try
        Else
            If CorroborarCliente() = False Then
                MessageBox.Show("Error, el cliente no existe")
            Else
                MessageBox.Show("Error, seleccione un cliente valido para eliminar")
            End If
        End If


    End Sub

    'Buscar cliente por nombre
    Public Sub BuscaCliente(tablaclientes As DataGridView, nombreClienteBuscado As String)


        Try
            tablaclientes.DataSource = Nothing
            Dim consulta As String = "SELECT * FROM clientes WHERE Nombre LIKE @nombre"
            Dim comando As MySqlCommand = New MySqlCommand(consulta, establecerConexion())
            comando.Parameters.AddWithValue("@nombre", "%" & nombreClienteBuscado & "%")
            Dim adaptador As MySqlDataAdapter = New MySqlDataAdapter(comando)
            Dim tabla As New DataTable
            adaptador.Fill(tabla)
            tablaclientes.DataSource = tabla
            If (tabla.Rows.Count > 0) Then
                MessageBox.Show("Se realizo la busqueda con exito.")

            Else
                MessageBox.Show("El cliente buscado no esta registrado.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al realizar la busqueda " + ex.ToString)
        Finally
            cerrarConexion()
        End Try

    End Sub
End Class

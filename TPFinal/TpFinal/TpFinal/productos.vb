Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud

Public Class productos
    Inherits ConexionBDD
    Private id_producto As Integer
    Private nombre As String
    Private precio As Integer
    Private categoria As String

    Public Property id_producto2 As Integer
        Get
            Return id_producto
        End Get
        Set(value As Integer)
            If (value < 0) Then
                MessageBox.Show("Error al ingresar id_producto, es menor a 0")
            Else
                id_producto = value
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
    Public Property precio2 As Integer
        Get
            Return precio

        End Get
        Set(value As Integer)
            If (value <= 0) Then
                MessageBox.Show("Error al ingresar el precio, no puede ser negativo ó 0")
            Else
                precio = value
            End If
        End Set
    End Property
    Public Property categoria2 As String
        Get
            Return categoria
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
                MessageBox.Show("Categoria invalida, no debe contener valores numericos")

            Else
                categoria = value
            End If
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(nombre As String, precio As Integer, categoria As String)

        Me.nombre2 = nombre
        Me.precio2 = precio
        Me.categoria2 = categoria
    End Sub
    'Muestra de productos en datagrid
    Public Sub mostrarProductos(tablaProductos As DataGridView)
        Try
            tablaProductos.DataSource = Nothing
            Dim consulta As String = "SELECT * FROM productos"
            Dim adaptador As MySqlDataAdapter = New MySqlDataAdapter(consulta, establecerConexion())
            Dim tabla As DataTable = New DataTable()
            adaptador.Fill(tabla)
            tablaProductos.DataSource = tabla

        Catch ex As Exception
            MessageBox.Show("Error al mostrar los productos" + ex.ToString)
        Finally
            cerrarConexion()
        End Try
    End Sub
    'Alta de productos
    Public Sub altaProducto()
        If (CorroborarProducto() = False And Not String.IsNullOrWhiteSpace(Me.nombre) And Me.precio > 0 And Not String.IsNullOrWhiteSpace(Me.categoria)) Then
            Try
                Dim consulta As String = "INSERT INTO productos(Nombre,Precio,categoria)VALUES(@Nombre,@Precio,@categoria)"
                Dim comando As MySqlCommand = New MySqlCommand(consulta, establecerConexion())
                comando.Parameters.AddWithValue("@Nombre", Me.nombre)
                comando.Parameters.AddWithValue("@Precio", Me.precio)
                comando.Parameters.AddWithValue("@categoria", Me.categoria)
                comando.ExecuteNonQuery()
                MessageBox.Show("El producto fue registrado con exito")
            Catch ex As Exception
                MessageBox.Show("Error al registrar el producto" + ex.ToString)
            Finally
                cerrarConexion()
            End Try
        Else
            If CorroborarProducto() = True Then
                MessageBox.Show("Error, el producto ya existe")
            Else
                MessageBox.Show("Error, datos invalidos")
            End If
        End If


    End Sub
    'Verificar que no este el producto a cargar
    Public Function CorroborarProducto() As Boolean
        Dim resultado As Boolean = False
        Dim lector As MySqlDataReader = Nothing
        Try
            Dim consulta As String = "SELECT * FROM productos WHERE Nombre=@Nombre"
            Dim comando As MySqlCommand = New MySqlCommand(consulta, establecerConexion())
            comando.Parameters.AddWithValue("@Nombre", Me.nombre)
            lector = comando.ExecuteReader()
            If lector.HasRows() Then
                resultado = True

            End If
        Catch ex As Exception
            MessageBox.Show("Se produjo un error al corroborar Producto ", ex.ToString)
        Finally
            If lector IsNot Nothing Then lector.Close()
            cerrarConexion()
        End Try
        Return resultado
    End Function
    'seleccionar datos de datagrid para luego modificar
    Public Sub SeleccionarProducto(tabla As DataGridView, txtIdproducto As TextBox, txtNombre As TextBox, txtPrecio As TextBox, txtCategoria As TextBox, txtActivo As TextBox)
        Try
            txtIdproducto.Text = tabla.CurrentRow.Cells(0).Value.ToString()
            txtNombre.Text = tabla.CurrentRow.Cells(1).Value.ToString()
            txtPrecio.Text = tabla.CurrentRow.Cells(2).Value.ToString()
            txtCategoria.Text = tabla.CurrentRow.Cells(3).Value.ToString()
            txtActivo.Text = tabla.CurrentRow.Cells(4).Value.ToString()
        Catch ex As Exception
            MessageBox.Show("No se logro seleccionar el registro " + ex.ToString)
        End Try
    End Sub

    'Modificar Productos
    Public Sub ModificarProducto(tabla As DataGridView)
        If (Not String.IsNullOrWhiteSpace(Me.nombre) And Me.precio > 0 And Not String.IsNullOrWhiteSpace(Me.categoria)) Then
            Try
                Dim consulta As String = "UPDATE productos SET Nombre=@Nombre,Precio=@Precio,categoria=@categoria WHERE id_producto=@id_producto;"
                Dim comando As MySqlCommand = New MySqlCommand(consulta, establecerConexion())
                Dim id_producto As Integer = tabla.CurrentRow.Cells(0).Value
                comando.Parameters.AddWithValue("@id_producto", id_producto)
                comando.Parameters.AddWithValue("@Nombre", Me.nombre)
                comando.Parameters.AddWithValue("@Precio", Me.precio)
                comando.Parameters.AddWithValue("@categoria", Me.categoria)
                comando.ExecuteNonQuery()
                MessageBox.Show("El producto fue modificado con exito")
            Catch ex As MySqlException
                If ex.Number = 1062 Then
                    MessageBox.Show("Error: ya existe un producto con ese nombre.")

                Else
                    MessageBox.Show("Error al modificar el producto: " & ex.Message)

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

    'Eliminar Producto
    Public Sub EliminarProducto(tabla As DataGridView, Activo As String)
        If (CorroborarProducto() = True And Not String.IsNullOrWhiteSpace(Me.nombre) And Me.precio > 0 And Not String.IsNullOrWhiteSpace(Me.categoria)) Then
            Try
                Dim consulta As String = "UPDATE productos SET activo=@activo WHERE id_producto=@id_producto;"
                Dim comando As MySqlCommand = New MySqlCommand(consulta, establecerConexion())
                Dim id_producto As Integer = tabla.CurrentRow.Cells(0).Value
                comando.Parameters.AddWithValue("@id_producto", id_producto)
                If Activo = "si" Then
                    comando.Parameters.AddWithValue("@activo", "no")
                Else
                    comando.Parameters.AddWithValue("@activo", "si")
                End If

                comando.ExecuteNonQuery()
                MessageBox.Show("El estado del producto fue modificado con exito")
            Catch ex As Exception
                MessageBox.Show("Error al eliminar el producto" + ex.ToString)
            Finally
                cerrarConexion()
            End Try
        Else
            If CorroborarProducto() = False Then
                MessageBox.Show("Error, el producto no existe")
            Else
                MessageBox.Show("Error, seleccione un producto valido para eliminar")
            End If
        End If


    End Sub

    'Buscar Producto por nombre
    Public Sub BuscaProducto(tablaproductos As DataGridView, nombreProductoBuscado As String)


        Try
            tablaproductos.DataSource = Nothing
            Dim consulta As String = "SELECT * FROM productos WHERE Nombre LIKE @Nombre"
            Dim comando As MySqlCommand = New MySqlCommand(consulta, establecerConexion())
            comando.Parameters.AddWithValue("@Nombre", "%" & nombreProductoBuscado & "%")
            Dim adaptador As MySqlDataAdapter = New MySqlDataAdapter(comando)
            Dim tabla As New DataTable
            adaptador.Fill(tabla)
            tablaproductos.DataSource = tabla
            If (tabla.Rows.Count > 0) Then
                MessageBox.Show("Se realizo la busqueda con exito.")

            Else
                MessageBox.Show("El producto buscado no esta registrado.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al realizar la busqueda " + ex.ToString)
        Finally
            cerrarConexion()
        End Try

    End Sub
    'Mostrar Productos con activo=si , para ventasItems
    Public Sub MostrarProductosActivos(tablaClientes As DataGridView)
        Try
            tablaClientes.DataSource = Nothing
            Dim consulta As String = "SELECT Nombre,Precio FROM productos where activo='si'"
            Dim adaptador As MySqlDataAdapter = New MySqlDataAdapter(consulta, establecerConexion())
            Dim tabla As DataTable = New DataTable()
            adaptador.Fill(tabla)
            tablaClientes.DataSource = tabla

        Catch ex As Exception
            MessageBox.Show("Error al mostrar los productos" + ex.ToString)
        Finally
            cerrarConexion()
        End Try
    End Sub
    'Seleccionar Producto para VentasItems
    Public Sub SeleccionarProductoAvender(tabla As DataGridView, txtNombre As TextBox, txtPrecio As TextBox)
        Try
            txtNombre.Text = tabla.CurrentRow.Cells(0).Value.ToString()
            txtPrecio.Text = tabla.CurrentRow.Cells(1).Value.ToString()
        Catch ex As Exception
            MessageBox.Show("No se logro seleccionar el registro " + ex.ToString)
        End Try
    End Sub
    'Encuentro el id del producto segun el nombre
    Public Function EncontrarIDproducto(nombreProducto As String) As Integer
        Dim Id_Obtenido As Integer
        Try

            Dim consulta As String = "SELECT id_producto FROM productos where Nombre=@Nombre"
            Dim comando As MySqlCommand = New MySqlCommand(consulta, establecerConexion())
            comando.Parameters.AddWithValue("@Nombre", nombreProducto)
            Dim resultado As Object = comando.ExecuteScalar()
            If resultado IsNot Nothing Then
                Id_Obtenido = Convert.ToInt32(resultado)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al mostrar los productos" + ex.ToString)
        Finally
            cerrarConexion()
        End Try
        Return Id_Obtenido
    End Function
    'Buscar Producto Activo para VentasItems
    Public Sub BuscaProductoActivo(tablaproductos As DataGridView, nombreProductoBuscado As String)


        Try
            tablaproductos.DataSource = Nothing
            Dim consulta As String = "SELECT Nombre,Precio FROM productos WHERE Nombre LIKE @Nombre AND activo='si'"
            Dim comando As MySqlCommand = New MySqlCommand(consulta, establecerConexion())
            comando.Parameters.AddWithValue("@Nombre", "%" & nombreProductoBuscado & "%")
            Dim adaptador As MySqlDataAdapter = New MySqlDataAdapter(comando)
            Dim tabla As New DataTable
            adaptador.Fill(tabla)
            tablaproductos.DataSource = tabla
            If (tabla.Rows.Count > 0) Then
                MessageBox.Show("Se realizo la busqueda con exito.")

            Else
                MessageBox.Show("El producto buscado no esta registrado.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al realizar la busqueda " + ex.ToString)
        Finally
            cerrarConexion()
        End Try

    End Sub
End Class

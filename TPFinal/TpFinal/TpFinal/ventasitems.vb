Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient

Public Class ventasitems
    Inherits ConexionBDD
    Private id_ventasitems As Integer
    Private id_venta As Integer
    Private id_producto As Integer
    Private preciounitario As Integer
    Private cantidad As Integer
    Private preciototal As Integer 'Lo calculo con cantidad*precioUnitario

    Public Property id_ventasitems2 As Integer
        Get
            Return id_ventasitems
        End Get
        Set(value As Integer)
            If (value < 0) Then
                MessageBox.Show("Error al ingresar id_ventasitems, es menor a 0")
            Else
                id_ventasitems = value
            End If
        End Set
    End Property
    Public Property idventa2 As Integer
        Get
            Return id_venta
        End Get
        Set(value As Integer)
            If (value < 0) Then
                MessageBox.Show("Error al ingresar id_venta, es menor a 0")
            Else
                id_venta = value
            End If
        End Set
    End Property
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

    Public Property preciounitario2 As Integer
        Get
            Return preciounitario
        End Get
        Set(value As Integer)
            If (value < 0) Then
                MessageBox.Show("El precio unitario no puede ser negativo, ERROR!")
            Else
                preciounitario = value
            End If
        End Set
    End Property
    Public Property cantidad2 As Integer
        Get
            Return cantidad
        End Get
        Set(value As Integer)
            If (value < 0) Then
                MessageBox.Show("La cantidad no puede ser negativa, ERROR!")
            Else
                cantidad = value
            End If
        End Set
    End Property
    Public Property preciototal2 As Integer
        Get
            Return preciototal
        End Get
        Set(value As Integer)
            If (value < 0) Then
                MessageBox.Show("Error al cargar el preciototal, no debe ser negativo")
            Else
                preciototal = value
            End If
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(id_producto As Integer, preciounitario As Integer, cantidad As Integer)

        Me.id_producto2 = id_producto
        Me.preciounitario2 = preciounitario
        Me.cantidad2 = cantidad
        Me.preciototal2 = Me.cantidad * Me.preciounitario
    End Sub

    'Crear columnas en tabla Temporal 
    Public Function CrearTablaTemporalVentas() As DataTable
        Dim tabla As New DataTable("Venta Temporal")
        tabla.Columns.Add("id_producto", GetType(Integer))
        tabla.Columns.Add("nombre_producto", GetType(String))
        tabla.Columns.Add("preciounitario", GetType(Integer))
        tabla.Columns.Add("cantidad", GetType(Integer))
        tabla.Columns.Add("preciototal", GetType(Integer))
        Return tabla

    End Function
    'Guardar Ventas Items
    Public Sub GuardarVentaItems(id_venta As Integer)
        Try
            Dim consulta As String = "INSERT INTO ventasitems(id_ventas,id_producto,preciounitario,cantidad,preciototal)VALUES(@id_ventas,@id_producto,@preciounitario,@cantidad,@preciototal)"
            Dim comando As MySqlCommand = New MySqlCommand(consulta, establecerConexion())
            comando.Parameters.AddWithValue("@id_ventas", id_venta)
            comando.Parameters.AddWithValue("@id_producto", Me.id_producto)
            comando.Parameters.AddWithValue("@preciounitario", Me.preciounitario)
            comando.Parameters.AddWithValue("@cantidad", Me.cantidad)
            comando.Parameters.AddWithValue("@preciototal", Me.preciototal)
            comando.ExecuteNonQuery()
            MessageBox.Show("La venta se realizo con exito")
        Catch ex As Exception
            MessageBox.Show("Error al registrar la venta" + ex.ToString)
        Finally
            cerrarConexion()
        End Try
    End Sub



End Class

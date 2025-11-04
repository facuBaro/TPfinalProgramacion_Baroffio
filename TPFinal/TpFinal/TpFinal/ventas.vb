Imports System.Numerics
Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient

Public Class ventas
    Inherits ConexionBDD

    Private id_venta As Integer
    Private id_cliente As Integer
    Private fecha As Date 'tiene que ser YYYY-MM-DD
    Private total As Integer

    Public Property id_venta2 As Integer
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
    Public Property fecha2 As Date
        Get
            Return fecha
        End Get
        Set(value As Date)
            If (value > DateTime.Today) Then
                MessageBox.Show("Error al ingresar la fecha, no puede ser futura")
            Else
                fecha = value
            End If
        End Set
    End Property

    Public Property total2 As Integer
        Get
            Return total
        End Get
        Set(value As Integer)
            If (value < 0) Then
                MessageBox.Show("Error al ingresar el total, no puede ser negativo")
            Else
                total = value
            End If
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(id_cliente As Integer, fecha As Date, total As Integer)
        Me.id_cliente2 = id_cliente
        Me.fecha2 = fecha
        Me.total2 = total
    End Sub
    'Guardar Venta en tabla Ventas
    Public Function GuardarVenta() As Integer
        Dim idVentaGenerado As Integer
        Try
            Dim consulta As String = "INSERT INTO ventas(id_cliente,fecha,total)VALUES(@id_cliente,@fecha,@total); SELECT LAST_INSERT_ID();"
            Dim comando As MySqlCommand = New MySqlCommand(consulta, establecerConexion())
            comando.Parameters.AddWithValue("@id_cliente", Me.id_cliente)
            comando.Parameters.AddWithValue("@fecha", Me.fecha)
            comando.Parameters.AddWithValue("@total", Me.total)
            idVentaGenerado = Convert.ToInt32(comando.ExecuteScalar())
            MessageBox.Show("La venta  fue registrada con exito, ID de Venta: " & idVentaGenerado)
        Catch ex As Exception
            MessageBox.Show("Error al registrar la venta" + ex.ToString)
        Finally
            cerrarConexion()
        End Try
        Return idVentaGenerado
    End Function
    'Buscar ventas entre 2 fechas y cargarlas
    Public Function BuscarVentas(datagridVentas As DataGridView, fechaDesde As Date, fechaHasta As Date) As Integer
        Dim totalVendido As Integer = 0
        Try
            datagridVentas.DataSource = Nothing
            Dim consulta As String = "SELECT v.id_ventas,c.nombre,v.fecha,v.total
                                  FROM ventas v
                                  INNER JOIN clientes c ON v.id_cliente = c.id_cliente
                                  WHERE v.fecha >= @Desde AND v.fecha<=@Hasta
                                  ORDER BY v.fecha DESC"
            Dim comando As New MySqlCommand(consulta, establecerConexion())
            comando.Parameters.AddWithValue("@Desde", fechaDesde.ToString("yyyy-MM-dd"))
            comando.Parameters.AddWithValue("@Hasta", fechaHasta.ToString("yyyy-MM-dd"))
            Dim adaptador As MySqlDataAdapter = New MySqlDataAdapter(comando)
            Dim tabla As DataTable = New DataTable()
            adaptador.Fill(tabla)
            datagridVentas.DataSource = tabla

            For Each fila As DataRow In tabla.Rows
                totalVendido = totalVendido + Convert.ToInt32(fila("total"))
            Next

        Catch ex As Exception
            MessageBox.Show("Error al mostrar las ventas realizadas" + ex.ToString)
        Finally
            cerrarConexion()
        End Try

        Return totalVendido
    End Function
    Public Sub MostrarDetalleVenta(datagriDetalleVenta As DataGridView, id_venta As Integer)
        Try
            datagriDetalleVenta.DataSource = Nothing
            Dim consulta As String = "SELECT p.nombre,vi.preciounitario,vi.cantidad,vi.preciototal
                                  FROM ventasitems vi
                                  INNER JOIN productos p ON vi.id_producto = p.id_producto
                                  WHERE vi.id_ventas=@id_venta"
            Dim comando As New MySqlCommand(consulta, establecerConexion())
            comando.Parameters.AddWithValue("@id_venta", id_venta)
            Dim adaptador As MySqlDataAdapter = New MySqlDataAdapter(comando)
            Dim tabla As DataTable = New DataTable()
            adaptador.Fill(tabla)
            datagriDetalleVenta.DataSource = tabla



        Catch ex As Exception
            MessageBox.Show("Error al mostrar los detalles de la venta realizada" + ex.ToString)
        Finally
            cerrarConexion()
        End Try

    End Sub

End Class

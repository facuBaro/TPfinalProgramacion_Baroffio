Imports Google.Protobuf.WellKnownTypes

Public Class ventasitems
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

    Public Sub New(id_ventasitems As Integer, id_venta As Integer, id_producto As Integer, preciounitario As Integer, cantidad As Integer)
        Me.id_ventasitems2 = id_ventasitems
        Me.idventa2 = id_venta
        Me.id_producto2 = id_producto
        Me.preciounitario2 = preciounitario
        Me.cantidad2 = cantidad
        Me.preciototal2 = Me.cantidad * Me.preciounitario
    End Sub


End Class

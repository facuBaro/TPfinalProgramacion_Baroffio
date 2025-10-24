Imports System.Numerics
Imports Google.Protobuf.WellKnownTypes

Public Class ventas


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
            If (value > DateTime.Now) Then
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

    Public Sub New(id_venta As Integer, id_cliente As Integer, fecha As Date, total As Integer)
        Me.id_venta2 = id_venta
        Me.id_cliente2 = id_cliente
        Me.fecha2 = fecha
        Me.total2 = total
    End Sub
End Class

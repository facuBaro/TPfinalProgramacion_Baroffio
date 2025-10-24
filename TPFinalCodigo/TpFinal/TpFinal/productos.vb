Imports Google.Protobuf.WellKnownTypes

Public Class productos
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
            If (value < 0) Then
                MessageBox.Show("Error al ingresar el precio, no puede ser negativo")
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

    Public Sub New(id_producto As Integer, nombre As String, precio As Integer, categoria As String)
        Me.id_producto2 = id_producto
        Me.nombre2 = nombre
        Me.precio2 = precio
        Me.categoria2 = categoria
    End Sub
End Class

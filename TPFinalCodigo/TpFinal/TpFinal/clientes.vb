Imports Google.Protobuf.WellKnownTypes

Public Class clientes
    Private id_cliente As Integer
    Private nombre As String
    Private telefono As Integer
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
    Public Property telefono2 As Integer
        Get
            Return telefono
        End Get
        Set(value As Integer)
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

    Public Sub New(id_cliente As Integer, nombre As String, telefono As Integer, correo As String)
        Me.id_cliente2 = id_cliente
        Me.nombre2 = nombre
        Me.telefono2 = telefono
        Me.correo2 = correo
    End Sub
End Class

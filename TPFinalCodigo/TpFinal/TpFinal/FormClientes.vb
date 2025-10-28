Public Class FormClientes
    Private Sub FormClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cliente As clientes = New clientes()
        cliente.mostrarClientes(DataGridViewClientes)
        txtIdCliente.Enabled = False
        txtActivoCliente.Enabled = False
    End Sub

    Private Sub btnAtrasClientes_Click(sender As Object, e As EventArgs) Handles btnAtrasClientes.Click
        Dim cliente As clientes = New clientes()
        cliente.mostrarClientes(DataGridViewClientes)
        txtIdCliente.Clear()
        txtNombreCliente.Clear()
        txtCorreoCliente.Clear()
        txtTelefonoCliente.Clear()
        txtActivoCliente.Clear()
        MenuInicial.Show()
        Me.Hide()
    End Sub

    Private Sub btnAltaCliente_Click(sender As Object, e As EventArgs) Handles btnAltaCliente.Click
        Dim telefono As Long
        If Not String.IsNullOrWhiteSpace(txtNombreCliente.Text) And Long.TryParse(txtTelefonoCliente.Text, telefono) = True And Not String.IsNullOrWhiteSpace(txtCorreoCliente.Text) Then
            Dim cliente As clientes = New clientes(txtNombreCliente.Text, telefono, txtCorreoCliente.Text)
            cliente.altaCliente()
            cliente.mostrarClientes(DataGridViewClientes)
            txtNombreCliente.Clear()
            txtTelefonoCliente.Clear()
            txtCorreoCliente.Clear()
            txtIdCliente.Clear()
            txtActivoCliente.Clear()
        Else
            MessageBox.Show("Complete todos los datos requeridos")
        End If
    End Sub

    Private Sub DataGridViewClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewClientes.CellClick
        Dim cliente As clientes = New clientes
        cliente.SeleccionarCliente(DataGridViewClientes, txtIdCliente, txtNombreCliente, txtTelefonoCliente, txtCorreoCliente, txtActivoCliente)
    End Sub

    Private Sub btnModificarCliente_Click(sender As Object, e As EventArgs) Handles btnModificarCliente.Click
        Dim telefono As Long
        If (Not String.IsNullOrWhiteSpace(txtIdCliente.Text)) Then
            If Not String.IsNullOrWhiteSpace(txtNombreCliente.Text) And Long.TryParse(txtTelefonoCliente.Text, telefono) = True And Not String.IsNullOrWhiteSpace(txtCorreoCliente.Text) Then
                Dim cliente As clientes = New clientes(txtNombreCliente.Text, telefono, txtCorreoCliente.Text)
                cliente.ModificarCliente(DataGridViewClientes)
                cliente.mostrarClientes(DataGridViewClientes)
                txtNombreCliente.Clear()
                txtTelefonoCliente.Clear()
                txtCorreoCliente.Clear()
                txtIdCliente.Clear()
                txtActivoCliente.Clear()
            Else
                MessageBox.Show("Complete todos los datos requeridos (telefono solo con numeros)")
            End If
        Else
            MessageBox.Show("Seleccione un cliente para modificar")
        End If
    End Sub

    Private Sub btnBajaCliente_Click(sender As Object, e As EventArgs) Handles btnBajaCliente.Click
        Dim telefono As Long
        If (Not String.IsNullOrWhiteSpace(txtIdCliente.Text)) Then
            If Not String.IsNullOrWhiteSpace(txtNombreCliente.Text) And Long.TryParse(txtTelefonoCliente.Text, telefono) = True And Not String.IsNullOrWhiteSpace(txtCorreoCliente.Text) And Not String.IsNullOrWhiteSpace(txtActivoCliente.Text) Then
                Dim cliente As clientes = New clientes(txtNombreCliente.Text, telefono, txtCorreoCliente.Text)
                cliente.EliminarCliente(DataGridViewClientes, txtActivoCliente.Text)
                cliente.mostrarClientes(DataGridViewClientes)
                txtNombreCliente.Clear()
                txtTelefonoCliente.Clear()
                txtCorreoCliente.Clear()
                txtIdCliente.Clear()
                txtActivoCliente.Clear()
            Else
                MessageBox.Show("Seleccione un cliente valido para eliminar")
            End If
        Else
            MessageBox.Show("Seleccione un cliente para eliminar")
        End If
    End Sub

    Private Sub btnClienteXnombre_Click(sender As Object, e As EventArgs) Handles btnClienteXnombre.Click
        Dim cliente As clientes = New clientes()
        Dim clienteAbuscar As String
        clienteAbuscar = InputBox("Ingrese el nombre del cliente a Buscar:")
        cliente.BuscaCliente(DataGridViewClientes, clienteAbuscar)
    End Sub

    Private Sub btnEliminarFiltroClientes_Click(sender As Object, e As EventArgs) Handles btnEliminarFiltroClientes.Click
        Dim cliente As clientes = New clientes()
        cliente.mostrarClientes(DataGridViewClientes)
    End Sub
End Class
Public Class FormVentasItem

    Private Sub FormVentasItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNomCliente.Enabled = False
        txtFecha.Text = Date.Today.ToString("yyyy-MM-dd")
        txtFecha.Enabled = False
        txtNomProducto.Enabled = False
        txtPrecioUnitario.Enabled = False
        Dim cliente As clientes = New clientes()
        cliente.MostrarClientesActivos(DataGridClientes)
        Dim producto As productos = New productos()
        producto.MostrarProductosActivos(DataGridProductos)
        Dim ventasDeitems As ventasitems = New ventasitems()
        DataGridVentasItems.DataSource = ventasDeitems.CrearTablaTemporalVentas()
        DataGridVentasItems.Columns("id_producto").Visible = False
        DataGridVentasItems.Columns("cantidad").ReadOnly = False
        DataGridVentasItems.Columns("preciototal").ReadOnly = True
        DataGridVentasItems.Columns("id_producto").ReadOnly = True
        DataGridVentasItems.Columns("nombre_producto").ReadOnly = True
        DataGridVentasItems.Columns("preciounitario").ReadOnly = True
    End Sub

    Private Sub btnAtrasVentasItems_Click(sender As Object, e As EventArgs) Handles btnAtrasVentasItems.Click
        MenuInicial.Show()
        Me.Close()
    End Sub

    Private Sub DataGridProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridProductos.CellClick
        Dim productoSeleccionado As productos = New productos()
        productoSeleccionado.SeleccionarProductoAvender(DataGridProductos, txtNomProducto, txtPrecioUnitario)
    End Sub

    Private Sub DataGridClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridClientes.CellClick
        Dim clienteSeleccionado As clientes = New clientes()
        clienteSeleccionado.SeleccionarClienteAvender(DataGridClientes, txtNomCliente)
    End Sub

    Private Sub btnCargarProducto_Click(sender As Object, e As EventArgs) Handles btnCargarProducto.Click
        Dim Cantidad As Integer
        Dim productoExiste As Boolean = False
        If (String.IsNullOrWhiteSpace(txtNomCliente.Text) Or String.IsNullOrWhiteSpace(txtNomProducto.Text) Or String.IsNullOrWhiteSpace(txtPrecioUnitario.Text) Or String.IsNullOrWhiteSpace(txtFecha.Text) Or Integer.TryParse(txtCantidadProducto.Text, Cantidad) = False) Then
            MessageBox.Show("Por favor, asegurese de cargar todos los datos correctamente")
        Else

            Dim productoSeleccionado As productos = New productos()
            Dim idProducto As Integer = productoSeleccionado.EncontrarIDproducto(txtNomProducto.Text)
            Dim NombreProducto As String = txtNomProducto.Text
            Dim PrecioUnitario As Integer = Convert.ToInt32(txtPrecioUnitario.Text)
            Dim PrecioTotal As Integer = PrecioUnitario * Cantidad
            Dim tabla As DataTable = CType(DataGridVentasItems.DataSource, DataTable)
            For Each fila As DataRow In tabla.Rows
                If Convert.ToInt32(fila("ID_Producto")) = idProducto Then
                    productoExiste = True
                    Exit For
                End If
            Next
            If productoExiste = True Then
                MessageBox.Show("El producto ya fue agregado, si desea puede cambiar su cantidad")


            Else
                Dim nuevaFila As DataRow = tabla.NewRow()
                nuevaFila("id_producto") = idProducto
                nuevaFila("nombre_producto") = NombreProducto
                nuevaFila("preciounitario") = PrecioUnitario
                nuevaFila("cantidad") = Cantidad
                nuevaFila("preciototal") = PrecioTotal
                tabla.Rows.Add(nuevaFila)
                GroupBoxCliente.Visible = False
                btnEliminarFiltroCliente.Visible = False
                btnBuscarClienteVitems.Visible = False
                'Calculo para subtotal
                Dim subtotal As Integer = 0
                For Each f As DataGridViewRow In DataGridVentasItems.Rows
                    subtotal = subtotal + Convert.ToInt32(f.Cells("preciototal").Value)
                Next
                lblSubTotal.Text = Convert.ToString(subtotal)
            End If

        End If

    End Sub

    Private Sub DataGridVentasItems_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridVentasItems.CellValueChanged
        If e.ColumnIndex = DataGridVentasItems.Columns("cantidad").Index Then
            Dim fila As DataGridViewRow = DataGridVentasItems.Rows(e.RowIndex)
            Dim precioUnitario As Integer = Convert.ToDecimal(fila.Cells("preciounitario").Value)
            Dim cantidad As Integer = Convert.ToInt32(fila.Cells("cantidad").Value)

            fila.Cells("preciototal").Value = precioUnitario * cantidad

            'Recalcular subtotal
            Dim subtotal As Integer = 0
            For Each f As DataGridViewRow In DataGridVentasItems.Rows
                subtotal = subtotal + Convert.ToInt32(f.Cells("preciototal").Value)
            Next
            lblSubTotal.Text = Convert.ToString(subtotal)
        End If

    End Sub

    Private Sub btnCancelarVenta_Click(sender As Object, e As EventArgs) Handles btnCancelarVenta.Click
        Dim tabla As DataTable = CType(DataGridVentasItems.DataSource, DataTable)
        tabla.Clear()
        txtCantidadProducto.Clear()
        txtNomCliente.Clear()
        txtNomProducto.Clear()
        txtPrecioUnitario.Clear()
        lblSubTotal.Text = "-"
        GroupBoxCliente.Visible = True
        btnBuscarClienteVitems.Visible = True
        btnEliminarFiltroCliente.Visible = True
    End Sub

    Private Sub btnBuscarClienteVitems_Click(sender As Object, e As EventArgs) Handles btnBuscarClienteVitems.Click
        Dim cliente As clientes = New clientes()
        Dim clienteAbuscar As String
        clienteAbuscar = InputBox("Ingrese el nombre del cliente a Buscar:")
        cliente.BuscaClienteActivo(DataGridClientes, clienteAbuscar)
    End Sub

    Private Sub btnBuscarProductoVitems_Click(sender As Object, e As EventArgs) Handles btnBuscarProductoVitems.Click
        Dim Producto As productos = New productos()
        Dim productoAbuscar As String
        productoAbuscar = InputBox("Ingrese el nombre del producto a Buscar:")
        Producto.BuscaProductoActivo(DataGridProductos, productoAbuscar)
    End Sub

    Private Sub btnEliminarFiltroProducto_Click(sender As Object, e As EventArgs) Handles btnEliminarFiltroProducto.Click
        Dim producto As productos = New productos()
        producto.MostrarProductosActivos(DataGridProductos)
    End Sub

    Private Sub btnEliminarFiltroCliente_Click(sender As Object, e As EventArgs) Handles btnEliminarFiltroCliente.Click
        Dim clienteAvender As clientes = New clientes()
        clienteAvender.MostrarClientesActivos(DataGridClientes)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnFinalizarCompra.Click
        If DataGridVentasItems.Rows.Count = 0 Or Val(lblSubTotal.Text) = 0 Then
            MessageBox.Show("Debe cargar por lo menos un producto")
        Else

            'Guardo los datos en mi tabla Ventas
            Dim clienteAvender As clientes = New clientes()
            Dim id_cliente As Integer = clienteAvender.EncontrarIDCliente(txtNomCliente.Text)
            Dim fecha As Date = Convert.ToDateTime(txtFecha.Text)
            Dim total As Integer = Convert.ToInt32(lblSubTotal.Text)
            Dim ventaRealizada As ventas = New ventas(id_cliente, fecha, total)
            Dim Id_Venta = ventaRealizada.GuardarVenta()

            'Guardo los datos en mi tabla VentasItems

            For Each fila As DataGridViewRow In DataGridVentasItems.Rows
                If Not fila.IsNewRow Then
                    Dim idProducto As Integer = Convert.ToInt32(fila.Cells("id_producto").Value)
                    Dim cantidad As Integer = Convert.ToInt32(fila.Cells("cantidad").Value)
                    Dim precioUnitario As Integer = Convert.ToInt32(fila.Cells("preciounitario").Value)
                    Dim precioTotal As Integer = Convert.ToInt32(fila.Cells("preciototal").Value)
                    Dim ventaItem As ventasitems = New ventasitems(idProducto, precioUnitario, cantidad)
                    ventaItem.GuardarVentaItems(Id_Venta)
                End If
            Next
            Dim tabla As DataTable = CType(DataGridVentasItems.DataSource, DataTable)
            tabla.Clear()
            txtCantidadProducto.Clear()
            txtNomCliente.Clear()
            txtNomProducto.Clear()
            txtPrecioUnitario.Clear()
            lblSubTotal.Text = "-"
            GroupBoxCliente.Visible = True
            btnBuscarClienteVitems.Visible = True
            btnEliminarFiltroCliente.Visible = True
        End If


    End Sub
End Class
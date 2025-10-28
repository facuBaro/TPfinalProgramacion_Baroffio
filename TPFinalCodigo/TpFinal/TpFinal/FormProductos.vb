Public Class FormProductos

    Private Sub btnAtrasProductos_Click(sender As Object, e As EventArgs) Handles btnAtrasProductos.Click
        Me.Hide()
        Dim Producto As productos = New productos()
        Producto.mostrarProductos(DataGridProductos)
        txtNombreProducto.Clear()
        txtCategoriaProducto.Clear()
        txtPrecioProducto.Clear()
        txtActivo.Clear()
        txtIDproducto.Clear()
        MenuInicial.Show()
    End Sub

    Private Sub FormProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Producto As productos = New productos()
        Producto.mostrarProductos(DataGridProductos)
        txtIDproducto.Enabled = False
        txtActivo.Enabled = False
    End Sub

    Private Sub btnAltaProducto_Click(sender As Object, e As EventArgs) Handles btnAltaProducto.Click
        Dim precio As Integer
        If Not String.IsNullOrWhiteSpace(txtNombreProducto.Text) And Integer.TryParse(txtPrecioProducto.Text, precio) = True And Not String.IsNullOrWhiteSpace(txtCategoriaProducto.Text) Then
            Dim Producto As productos = New productos(txtNombreProducto.Text, precio, txtCategoriaProducto.Text)
            Producto.altaProducto()
            Producto.mostrarProductos(DataGridProductos)
            txtCategoriaProducto.Clear()
            txtNombreProducto.Clear()
            txtPrecioProducto.Clear()
            txtIDproducto.Clear()
            txtActivo.Clear()

        Else
            MessageBox.Show("Complete todos los datos requeridos")
        End If


    End Sub

    Private Sub DataGridProductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridProductos.CellContentClick

    End Sub

    Private Sub DataGridProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridProductos.CellClick
        Dim Producto As productos = New productos()
        Producto.SeleccionarProducto(DataGridProductos, txtIDproducto, txtNombreProducto, txtPrecioProducto, txtCategoriaProducto, txtActivo)
    End Sub

    Private Sub btnModificarProductos_Click(sender As Object, e As EventArgs) Handles btnModificarProductos.Click
        Dim precio As Integer
        If (Not String.IsNullOrWhiteSpace(txtIDproducto.Text)) Then
            If Not String.IsNullOrWhiteSpace(txtNombreProducto.Text) And Integer.TryParse(txtPrecioProducto.Text, precio) = True And Not String.IsNullOrWhiteSpace(txtCategoriaProducto.Text) Then
                Dim Producto As productos = New productos(txtNombreProducto.Text, precio, txtCategoriaProducto.Text)
                Producto.ModificarProducto(DataGridProductos)
                Producto.mostrarProductos(DataGridProductos)
                txtCategoriaProducto.Clear()
                txtNombreProducto.Clear()
                txtPrecioProducto.Clear()
                txtIDproducto.Clear()
                txtActivo.Clear()
            Else
                MessageBox.Show("Complete todos los datos requeridos")
            End If
        Else
            MessageBox.Show("Seleccione un producto para modificar")
        End If


    End Sub

    Private Sub btnBajaProductos_Click(sender As Object, e As EventArgs) Handles btnBajaProductos.Click
        Dim precio As Integer
        If (Not String.IsNullOrWhiteSpace(txtIDproducto.Text)) Then
            If Not String.IsNullOrWhiteSpace(txtNombreProducto.Text) And Integer.TryParse(txtPrecioProducto.Text, precio) = True And Not String.IsNullOrWhiteSpace(txtCategoriaProducto.Text) And Not String.IsNullOrWhiteSpace(txtActivo.Text) Then
                Dim Producto As productos = New productos(txtNombreProducto.Text, precio, txtCategoriaProducto.Text)
                Producto.EliminarProducto(DataGridProductos, txtActivo.Text)
                Producto.mostrarProductos(DataGridProductos)
                txtCategoriaProducto.Clear()
                txtNombreProducto.Clear()
                txtPrecioProducto.Clear()
                txtIDproducto.Clear()
                txtActivo.Clear()
            Else
                MessageBox.Show("Seleccione un producto valido para eliminar")
            End If
        Else
            MessageBox.Show("Seleccione un producto para eliminar")
        End If

    End Sub

    Private Sub btnProductoXnombre_Click(sender As Object, e As EventArgs) Handles btnProductoXnombre.Click
        Dim Producto As productos = New productos()
        Dim productoAbuscar As String
        productoAbuscar = InputBox("Ingrese el nombre del producto a Buscar:")
        Producto.BuscaProducto(DataGridProductos, productoAbuscar)
    End Sub

    Private Sub btnEliminarFiltroProducto_Click(sender As Object, e As EventArgs) Handles btnEliminarFiltroProducto.Click
        Dim Producto As productos = New productos()
        Producto.mostrarProductos(DataGridProductos)
    End Sub
End Class
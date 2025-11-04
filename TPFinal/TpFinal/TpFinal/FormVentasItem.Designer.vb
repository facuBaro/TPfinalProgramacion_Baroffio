<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVentasItem
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtNomCliente = New TextBox()
        txtFecha = New TextBox()
        txtNomProducto = New TextBox()
        txtCantidadProducto = New TextBox()
        GroupBoxCliente = New GroupBox()
        DataGridClientes = New DataGridView()
        GroupBoxProducto = New GroupBox()
        DataGridProductos = New DataGridView()
        btnCargarProducto = New Button()
        btnFinalizarCompra = New Button()
        Label5 = New Label()
        lblSubTotal = New Label()
        DataGridVentasItems = New DataGridView()
        btnAtrasVentasItems = New Button()
        btnCancelarVenta = New Button()
        btnBuscarClienteVitems = New Button()
        btnBuscarProductoVitems = New Button()
        Label6 = New Label()
        txtPrecioUnitario = New TextBox()
        btnEliminarFiltroProducto = New Button()
        btnEliminarFiltroCliente = New Button()
        GroupBoxCliente.SuspendLayout()
        CType(DataGridClientes, ComponentModel.ISupportInitialize).BeginInit()
        GroupBoxProducto.SuspendLayout()
        CType(DataGridProductos, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridVentasItems, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(299, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(94, 15)
        Label1.TabIndex = 0
        Label1.Text = "Nombre Cliente:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(299, 54)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 15)
        Label2.TabIndex = 1
        Label2.Text = "Fecha:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(294, 84)
        Label3.Name = "Label3"
        Label3.Size = New Size(106, 15)
        Label3.TabIndex = 2
        Label3.Text = "Nombre Producto:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(299, 138)
        Label4.Name = "Label4"
        Label4.Size = New Size(101, 15)
        Label4.TabIndex = 3
        Label4.Text = "Cantidad a Llevar:"
        ' 
        ' txtNomCliente
        ' 
        txtNomCliente.Location = New Point(399, 22)
        txtNomCliente.Name = "txtNomCliente"
        txtNomCliente.Size = New Size(100, 23)
        txtNomCliente.TabIndex = 4
        ' 
        ' txtFecha
        ' 
        txtFecha.Location = New Point(399, 51)
        txtFecha.Name = "txtFecha"
        txtFecha.Size = New Size(100, 23)
        txtFecha.TabIndex = 5
        ' 
        ' txtNomProducto
        ' 
        txtNomProducto.Location = New Point(399, 80)
        txtNomProducto.Name = "txtNomProducto"
        txtNomProducto.Size = New Size(100, 23)
        txtNomProducto.TabIndex = 6
        ' 
        ' txtCantidadProducto
        ' 
        txtCantidadProducto.Location = New Point(399, 135)
        txtCantidadProducto.Name = "txtCantidadProducto"
        txtCantidadProducto.Size = New Size(100, 23)
        txtCantidadProducto.TabIndex = 7
        ' 
        ' GroupBoxCliente
        ' 
        GroupBoxCliente.BackColor = Color.Gray
        GroupBoxCliente.Controls.Add(DataGridClientes)
        GroupBoxCliente.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        GroupBoxCliente.Location = New Point(12, 12)
        GroupBoxCliente.Name = "GroupBoxCliente"
        GroupBoxCliente.Size = New Size(265, 200)
        GroupBoxCliente.TabIndex = 8
        GroupBoxCliente.TabStop = False
        GroupBoxCliente.Text = "Seleccione Un Cliente"
        ' 
        ' DataGridClientes
        ' 
        DataGridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridClientes.Location = New Point(6, 44)
        DataGridClientes.Name = "DataGridClientes"
        DataGridClientes.Size = New Size(253, 150)
        DataGridClientes.TabIndex = 0
        ' 
        ' GroupBoxProducto
        ' 
        GroupBoxProducto.BackColor = Color.Gray
        GroupBoxProducto.Controls.Add(DataGridProductos)
        GroupBoxProducto.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        GroupBoxProducto.Location = New Point(549, 12)
        GroupBoxProducto.Name = "GroupBoxProducto"
        GroupBoxProducto.Size = New Size(238, 200)
        GroupBoxProducto.TabIndex = 9
        GroupBoxProducto.TabStop = False
        GroupBoxProducto.Text = "Seleccione Un Producto"
        ' 
        ' DataGridProductos
        ' 
        DataGridProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridProductos.Location = New Point(6, 44)
        DataGridProductos.Name = "DataGridProductos"
        DataGridProductos.Size = New Size(226, 150)
        DataGridProductos.TabIndex = 0
        ' 
        ' btnCargarProducto
        ' 
        btnCargarProducto.Location = New Point(299, 192)
        btnCargarProducto.Name = "btnCargarProducto"
        btnCargarProducto.Size = New Size(117, 23)
        btnCargarProducto.TabIndex = 10
        btnCargarProducto.Text = "Cargar Producto"
        btnCargarProducto.UseVisualStyleBackColor = True
        ' 
        ' btnFinalizarCompra
        ' 
        btnFinalizarCompra.Location = New Point(424, 192)
        btnFinalizarCompra.Name = "btnFinalizarCompra"
        btnFinalizarCompra.Size = New Size(117, 23)
        btnFinalizarCompra.TabIndex = 11
        btnFinalizarCompra.Text = "Finalizar Compra"
        btnFinalizarCompra.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(304, 165)
        Label5.Name = "Label5"
        Label5.Size = New Size(55, 15)
        Label5.TabIndex = 12
        Label5.Text = "SubTotal:"
        ' 
        ' lblSubTotal
        ' 
        lblSubTotal.AutoSize = True
        lblSubTotal.Location = New Point(410, 165)
        lblSubTotal.Name = "lblSubTotal"
        lblSubTotal.Size = New Size(12, 15)
        lblSubTotal.TabIndex = 13
        lblSubTotal.Text = "-"
        ' 
        ' DataGridVentasItems
        ' 
        DataGridVentasItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridVentasItems.Location = New Point(51, 261)
        DataGridVentasItems.Name = "DataGridVentasItems"
        DataGridVentasItems.Size = New Size(702, 138)
        DataGridVentasItems.TabIndex = 14
        ' 
        ' btnAtrasVentasItems
        ' 
        btnAtrasVentasItems.Location = New Point(18, 405)
        btnAtrasVentasItems.Name = "btnAtrasVentasItems"
        btnAtrasVentasItems.Size = New Size(75, 23)
        btnAtrasVentasItems.TabIndex = 15
        btnAtrasVentasItems.Text = "Atras"
        btnAtrasVentasItems.UseVisualStyleBackColor = True
        ' 
        ' btnCancelarVenta
        ' 
        btnCancelarVenta.Location = New Point(368, 223)
        btnCancelarVenta.Name = "btnCancelarVenta"
        btnCancelarVenta.Size = New Size(108, 23)
        btnCancelarVenta.TabIndex = 16
        btnCancelarVenta.Text = "Cancelar Venta"
        btnCancelarVenta.UseVisualStyleBackColor = True
        ' 
        ' btnBuscarClienteVitems
        ' 
        btnBuscarClienteVitems.Location = New Point(148, 218)
        btnBuscarClienteVitems.Name = "btnBuscarClienteVitems"
        btnBuscarClienteVitems.Size = New Size(97, 23)
        btnBuscarClienteVitems.TabIndex = 17
        btnBuscarClienteVitems.Text = "Buscar Cliente"
        btnBuscarClienteVitems.UseVisualStyleBackColor = True
        ' 
        ' btnBuscarProductoVitems
        ' 
        btnBuscarProductoVitems.Location = New Point(567, 218)
        btnBuscarProductoVitems.Name = "btnBuscarProductoVitems"
        btnBuscarProductoVitems.Size = New Size(107, 23)
        btnBuscarProductoVitems.TabIndex = 18
        btnBuscarProductoVitems.Text = "Buscar Producto"
        btnBuscarProductoVitems.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(299, 111)
        Label6.Name = "Label6"
        Label6.Size = New Size(88, 15)
        Label6.TabIndex = 19
        Label6.Text = "Precio Unitario:"
        ' 
        ' txtPrecioUnitario
        ' 
        txtPrecioUnitario.Location = New Point(399, 106)
        txtPrecioUnitario.Name = "txtPrecioUnitario"
        txtPrecioUnitario.Size = New Size(100, 23)
        txtPrecioUnitario.TabIndex = 20
        ' 
        ' btnEliminarFiltroProducto
        ' 
        btnEliminarFiltroProducto.Location = New Point(680, 218)
        btnEliminarFiltroProducto.Name = "btnEliminarFiltroProducto"
        btnEliminarFiltroProducto.Size = New Size(94, 23)
        btnEliminarFiltroProducto.TabIndex = 21
        btnEliminarFiltroProducto.Text = "Eliminar Filtro "
        btnEliminarFiltroProducto.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarFiltroCliente
        ' 
        btnEliminarFiltroCliente.Location = New Point(38, 218)
        btnEliminarFiltroCliente.Name = "btnEliminarFiltroCliente"
        btnEliminarFiltroCliente.Size = New Size(88, 23)
        btnEliminarFiltroCliente.TabIndex = 22
        btnEliminarFiltroCliente.Text = "Eliminar Filtro"
        btnEliminarFiltroCliente.UseVisualStyleBackColor = True
        ' 
        ' FormVentasItem
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(799, 432)
        ControlBox = False
        Controls.Add(btnEliminarFiltroCliente)
        Controls.Add(btnEliminarFiltroProducto)
        Controls.Add(txtPrecioUnitario)
        Controls.Add(Label6)
        Controls.Add(btnBuscarProductoVitems)
        Controls.Add(btnBuscarClienteVitems)
        Controls.Add(btnCancelarVenta)
        Controls.Add(btnAtrasVentasItems)
        Controls.Add(DataGridVentasItems)
        Controls.Add(lblSubTotal)
        Controls.Add(Label5)
        Controls.Add(btnFinalizarCompra)
        Controls.Add(btnCargarProducto)
        Controls.Add(GroupBoxProducto)
        Controls.Add(GroupBoxCliente)
        Controls.Add(txtCantidadProducto)
        Controls.Add(txtNomProducto)
        Controls.Add(txtFecha)
        Controls.Add(txtNomCliente)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "FormVentasItem"
        Text = "FormVentasItem"
        GroupBoxCliente.ResumeLayout(False)
        CType(DataGridClientes, ComponentModel.ISupportInitialize).EndInit()
        GroupBoxProducto.ResumeLayout(False)
        CType(DataGridProductos, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridVentasItems, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNomCliente As TextBox
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents txtNomProducto As TextBox
    Friend WithEvents txtCantidadProducto As TextBox
    Friend WithEvents GroupBoxCliente As GroupBox
    Friend WithEvents DataGridClientes As DataGridView
    Friend WithEvents GroupBoxProducto As GroupBox
    Friend WithEvents DataGridProductos As DataGridView
    Friend WithEvents btnCargarProducto As Button
    Friend WithEvents btnFinalizarCompra As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents DataGridVentasItems As DataGridView
    Friend WithEvents btnAtrasVentasItems As Button
    Friend WithEvents btnCancelarVenta As Button
    Friend WithEvents btnBuscarClienteVitems As Button
    Friend WithEvents btnBuscarProductoVitems As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPrecioUnitario As TextBox
    Friend WithEvents btnEliminarFiltroProducto As Button
    Friend WithEvents btnEliminarFiltroCliente As Button
End Class

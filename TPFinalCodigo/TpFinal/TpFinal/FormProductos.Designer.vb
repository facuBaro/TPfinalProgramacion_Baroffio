<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProductos
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
        txtNombreProducto = New TextBox()
        txtPrecioProducto = New TextBox()
        txtCategoriaProducto = New TextBox()
        DataGridProductos = New DataGridView()
        btnAltaProducto = New Button()
        btnBajaProductos = New Button()
        btnModificarProductos = New Button()
        btnAtrasProductos = New Button()
        txtIDproducto = New TextBox()
        Label5 = New Label()
        btnProductoXnombre = New Button()
        btnEliminarFiltroProducto = New Button()
        Label6 = New Label()
        txtActivo = New TextBox()
        CType(DataGridProductos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(75, 74)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 15)
        Label1.TabIndex = 0
        Label1.Text = "Nombre:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(217, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(166, 15)
        Label2.TabIndex = 1
        Label2.Text = "Ingrese los datos del producto"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(75, 103)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 15)
        Label3.TabIndex = 2
        Label3.Text = "Precio:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(75, 129)
        Label4.Name = "Label4"
        Label4.Size = New Size(61, 15)
        Label4.TabIndex = 3
        Label4.Text = "Categoria:"
        ' 
        ' txtNombreProducto
        ' 
        txtNombreProducto.Location = New Point(166, 71)
        txtNombreProducto.Name = "txtNombreProducto"
        txtNombreProducto.Size = New Size(100, 23)
        txtNombreProducto.TabIndex = 4
        ' 
        ' txtPrecioProducto
        ' 
        txtPrecioProducto.Location = New Point(166, 98)
        txtPrecioProducto.Name = "txtPrecioProducto"
        txtPrecioProducto.Size = New Size(100, 23)
        txtPrecioProducto.TabIndex = 5
        ' 
        ' txtCategoriaProducto
        ' 
        txtCategoriaProducto.Location = New Point(166, 127)
        txtCategoriaProducto.Name = "txtCategoriaProducto"
        txtCategoriaProducto.Size = New Size(100, 23)
        txtCategoriaProducto.TabIndex = 6
        ' 
        ' DataGridProductos
        ' 
        DataGridProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridProductos.Location = New Point(12, 184)
        DataGridProductos.Name = "DataGridProductos"
        DataGridProductos.Size = New Size(550, 125)
        DataGridProductos.TabIndex = 7
        ' 
        ' btnAltaProducto
        ' 
        btnAltaProducto.Location = New Point(371, 51)
        btnAltaProducto.Name = "btnAltaProducto"
        btnAltaProducto.Size = New Size(75, 23)
        btnAltaProducto.TabIndex = 8
        btnAltaProducto.Text = "Alta"
        btnAltaProducto.UseVisualStyleBackColor = True
        ' 
        ' btnBajaProductos
        ' 
        btnBajaProductos.Location = New Point(348, 81)
        btnBajaProductos.Name = "btnBajaProductos"
        btnBajaProductos.Size = New Size(127, 40)
        btnBajaProductos.TabIndex = 9
        btnBajaProductos.Text = "Activar/Desactivar" & vbCrLf
        btnBajaProductos.UseVisualStyleBackColor = True
        ' 
        ' btnModificarProductos
        ' 
        btnModificarProductos.Location = New Point(371, 125)
        btnModificarProductos.Name = "btnModificarProductos"
        btnModificarProductos.Size = New Size(75, 23)
        btnModificarProductos.TabIndex = 10
        btnModificarProductos.Text = "Modificar"
        btnModificarProductos.UseVisualStyleBackColor = True
        ' 
        ' btnAtrasProductos
        ' 
        btnAtrasProductos.Location = New Point(12, 315)
        btnAtrasProductos.Name = "btnAtrasProductos"
        btnAtrasProductos.Size = New Size(75, 23)
        btnAtrasProductos.TabIndex = 11
        btnAtrasProductos.Text = "Atras"
        btnAtrasProductos.UseVisualStyleBackColor = True
        ' 
        ' txtIDproducto
        ' 
        txtIDproducto.Location = New Point(166, 42)
        txtIDproducto.Name = "txtIDproducto"
        txtIDproducto.Size = New Size(100, 23)
        txtIDproducto.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(80, 43)
        Label5.Name = "Label5"
        Label5.Size = New Size(20, 15)
        Label5.TabIndex = 13
        Label5.Text = "Id:"
        ' 
        ' btnProductoXnombre
        ' 
        btnProductoXnombre.Location = New Point(384, 315)
        btnProductoXnombre.Name = "btnProductoXnombre"
        btnProductoXnombre.Size = New Size(178, 23)
        btnProductoXnombre.TabIndex = 14
        btnProductoXnombre.Text = "Buscar producto por Nombre"
        btnProductoXnombre.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarFiltroProducto
        ' 
        btnEliminarFiltroProducto.Location = New Point(217, 315)
        btnEliminarFiltroProducto.Name = "btnEliminarFiltroProducto"
        btnEliminarFiltroProducto.Size = New Size(161, 23)
        btnEliminarFiltroProducto.TabIndex = 15
        btnEliminarFiltroProducto.Text = "Eliminar Filtro de busqueda "
        btnEliminarFiltroProducto.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(77, 155)
        Label6.Name = "Label6"
        Label6.Size = New Size(44, 15)
        Label6.TabIndex = 16
        Label6.Text = "Activo:"
        ' 
        ' txtActivo
        ' 
        txtActivo.Location = New Point(166, 155)
        txtActivo.Name = "txtActivo"
        txtActivo.Size = New Size(100, 23)
        txtActivo.TabIndex = 17
        ' 
        ' FormProductos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(574, 342)
        ControlBox = False
        Controls.Add(txtActivo)
        Controls.Add(Label6)
        Controls.Add(btnEliminarFiltroProducto)
        Controls.Add(btnProductoXnombre)
        Controls.Add(Label5)
        Controls.Add(txtIDproducto)
        Controls.Add(btnAtrasProductos)
        Controls.Add(btnModificarProductos)
        Controls.Add(btnBajaProductos)
        Controls.Add(btnAltaProducto)
        Controls.Add(DataGridProductos)
        Controls.Add(txtCategoriaProducto)
        Controls.Add(txtPrecioProducto)
        Controls.Add(txtNombreProducto)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "FormProductos"
        Text = "FormProductos"
        CType(DataGridProductos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombreProducto As TextBox
    Friend WithEvents txtPrecioProducto As TextBox
    Friend WithEvents txtCategoriaProducto As TextBox
    Friend WithEvents DataGridProductos As DataGridView
    Friend WithEvents btnAltaProducto As Button
    Friend WithEvents btnBajaProductos As Button
    Friend WithEvents btnModificarProductos As Button
    Friend WithEvents btnAtrasProductos As Button
    Friend WithEvents txtIDproducto As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnProductoXnombre As Button
    Friend WithEvents btnEliminarFiltroProducto As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtActivo As TextBox
End Class

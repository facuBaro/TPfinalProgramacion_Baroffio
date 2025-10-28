<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClientes
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
        txtNombreCliente = New TextBox()
        txtTelefonoCliente = New TextBox()
        txtCorreoCliente = New TextBox()
        btnAltaCliente = New Button()
        btnBajaCliente = New Button()
        btnModificarCliente = New Button()
        DataGridViewClientes = New DataGridView()
        Label5 = New Label()
        txtIdCliente = New TextBox()
        btnAtrasClientes = New Button()
        btnClienteXnombre = New Button()
        btnEliminarFiltroClientes = New Button()
        Label6 = New Label()
        txtActivoCliente = New TextBox()
        CType(DataGridViewClientes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(224, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(157, 15)
        Label1.TabIndex = 0
        Label1.Text = "Ingrese los datos del Cliente:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(200, 68)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 15)
        Label2.TabIndex = 1
        Label2.Text = "Nombre:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(199, 97)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 15)
        Label3.TabIndex = 2
        Label3.Text = "Teléfono:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(199, 126)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 15)
        Label4.TabIndex = 3
        Label4.Text = "Correo:"
        ' 
        ' txtNombreCliente
        ' 
        txtNombreCliente.Location = New Point(260, 65)
        txtNombreCliente.Name = "txtNombreCliente"
        txtNombreCliente.Size = New Size(100, 23)
        txtNombreCliente.TabIndex = 4
        ' 
        ' txtTelefonoCliente
        ' 
        txtTelefonoCliente.Location = New Point(260, 94)
        txtTelefonoCliente.Name = "txtTelefonoCliente"
        txtTelefonoCliente.Size = New Size(100, 23)
        txtTelefonoCliente.TabIndex = 5
        ' 
        ' txtCorreoCliente
        ' 
        txtCorreoCliente.Location = New Point(260, 123)
        txtCorreoCliente.Name = "txtCorreoCliente"
        txtCorreoCliente.Size = New Size(100, 23)
        txtCorreoCliente.TabIndex = 6
        ' 
        ' btnAltaCliente
        ' 
        btnAltaCliente.Location = New Point(481, 36)
        btnAltaCliente.Name = "btnAltaCliente"
        btnAltaCliente.Size = New Size(75, 23)
        btnAltaCliente.TabIndex = 7
        btnAltaCliente.Text = "Alta"
        btnAltaCliente.UseVisualStyleBackColor = True
        ' 
        ' btnBajaCliente
        ' 
        btnBajaCliente.Location = New Point(444, 65)
        btnBajaCliente.Name = "btnBajaCliente"
        btnBajaCliente.Size = New Size(151, 23)
        btnBajaCliente.TabIndex = 8
        btnBajaCliente.Text = "Activar/Desactivar"
        btnBajaCliente.UseVisualStyleBackColor = True
        ' 
        ' btnModificarCliente
        ' 
        btnModificarCliente.Location = New Point(481, 94)
        btnModificarCliente.Name = "btnModificarCliente"
        btnModificarCliente.Size = New Size(75, 23)
        btnModificarCliente.TabIndex = 9
        btnModificarCliente.Text = "Modificar"
        btnModificarCliente.UseVisualStyleBackColor = True
        ' 
        ' DataGridViewClientes
        ' 
        DataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewClientes.Location = New Point(12, 190)
        DataGridViewClientes.Name = "DataGridViewClientes"
        DataGridViewClientes.Size = New Size(620, 123)
        DataGridViewClientes.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(199, 40)
        Label5.Name = "Label5"
        Label5.Size = New Size(60, 15)
        Label5.TabIndex = 11
        Label5.Text = "Id Cliente:"
        ' 
        ' txtIdCliente
        ' 
        txtIdCliente.Location = New Point(260, 38)
        txtIdCliente.Name = "txtIdCliente"
        txtIdCliente.Size = New Size(100, 23)
        txtIdCliente.TabIndex = 12
        ' 
        ' btnAtrasClientes
        ' 
        btnAtrasClientes.Location = New Point(12, 319)
        btnAtrasClientes.Name = "btnAtrasClientes"
        btnAtrasClientes.Size = New Size(75, 23)
        btnAtrasClientes.TabIndex = 13
        btnAtrasClientes.Text = "Atras"
        btnAtrasClientes.UseVisualStyleBackColor = True
        ' 
        ' btnClienteXnombre
        ' 
        btnClienteXnombre.Location = New Point(454, 321)
        btnClienteXnombre.Name = "btnClienteXnombre"
        btnClienteXnombre.Size = New Size(178, 23)
        btnClienteXnombre.TabIndex = 14
        btnClienteXnombre.Text = "Buscar Cliente Por Nombre"
        btnClienteXnombre.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarFiltroClientes
        ' 
        btnEliminarFiltroClientes.Location = New Point(260, 321)
        btnEliminarFiltroClientes.Name = "btnEliminarFiltroClientes"
        btnEliminarFiltroClientes.Size = New Size(175, 23)
        btnEliminarFiltroClientes.TabIndex = 15
        btnEliminarFiltroClientes.Text = "Eliminar Filtro de Busqueda"
        btnEliminarFiltroClientes.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(199, 156)
        Label6.Name = "Label6"
        Label6.Size = New Size(44, 15)
        Label6.TabIndex = 16
        Label6.Text = "Activo:"
        ' 
        ' txtActivoCliente
        ' 
        txtActivoCliente.Location = New Point(260, 152)
        txtActivoCliente.Name = "txtActivoCliente"
        txtActivoCliente.Size = New Size(100, 23)
        txtActivoCliente.TabIndex = 17
        ' 
        ' FormClientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(644, 352)
        ControlBox = False
        Controls.Add(txtActivoCliente)
        Controls.Add(Label6)
        Controls.Add(btnEliminarFiltroClientes)
        Controls.Add(btnClienteXnombre)
        Controls.Add(btnAtrasClientes)
        Controls.Add(txtIdCliente)
        Controls.Add(Label5)
        Controls.Add(DataGridViewClientes)
        Controls.Add(btnModificarCliente)
        Controls.Add(btnBajaCliente)
        Controls.Add(btnAltaCliente)
        Controls.Add(txtCorreoCliente)
        Controls.Add(txtTelefonoCliente)
        Controls.Add(txtNombreCliente)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "FormClientes"
        Text = "FormClientes"
        CType(DataGridViewClientes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents txtTelefonoCliente As TextBox
    Friend WithEvents txtCorreoCliente As TextBox
    Friend WithEvents btnAltaCliente As Button
    Friend WithEvents btnBajaCliente As Button
    Friend WithEvents btnModificarCliente As Button
    Friend WithEvents DataGridViewClientes As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents btnAtrasClientes As Button
    Friend WithEvents btnClienteXnombre As Button
    Friend WithEvents btnEliminarFiltroClientes As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtActivoCliente As TextBox
End Class

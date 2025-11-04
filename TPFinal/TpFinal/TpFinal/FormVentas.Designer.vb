<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVentas
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
        DateTimePickerInicial = New DateTimePicker()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        DateTimePickerFinal = New DateTimePicker()
        btnBuscarFecha = New Button()
        DataGridVentas = New DataGridView()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        DataGridVentaDetalle = New DataGridView()
        btnAtrasBuscaVentas = New Button()
        Label4 = New Label()
        Label5 = New Label()
        lblTotalVendido = New Label()
        CType(DataGridVentas, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(DataGridVentaDetalle, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DateTimePickerInicial
        ' 
        DateTimePickerInicial.Format = DateTimePickerFormat.Custom
        DateTimePickerInicial.Location = New Point(274, 74)
        DateTimePickerInicial.Name = "DateTimePickerInicial"
        DateTimePickerInicial.Size = New Size(104, 23)
        DateTimePickerInicial.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(257, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(308, 25)
        Label1.TabIndex = 1
        Label1.Text = "Busqueda de Ventas entre Fechas:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(153, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(115, 15)
        Label2.TabIndex = 2
        Label2.Text = "Fecha Inicial(Desde):"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(406, 77)
        Label3.Name = "Label3"
        Label3.Size = New Size(107, 15)
        Label3.TabIndex = 3
        Label3.Text = "Fecha Final(Hasta):"
        ' 
        ' DateTimePickerFinal
        ' 
        DateTimePickerFinal.Format = DateTimePickerFormat.Custom
        DateTimePickerFinal.Location = New Point(519, 74)
        DateTimePickerFinal.Name = "DateTimePickerFinal"
        DateTimePickerFinal.Size = New Size(107, 23)
        DateTimePickerFinal.TabIndex = 4
        ' 
        ' btnBuscarFecha
        ' 
        btnBuscarFecha.Location = New Point(662, 76)
        btnBuscarFecha.Name = "btnBuscarFecha"
        btnBuscarFecha.Size = New Size(75, 23)
        btnBuscarFecha.TabIndex = 5
        btnBuscarFecha.Text = "Buscar"
        btnBuscarFecha.UseVisualStyleBackColor = True
        ' 
        ' DataGridVentas
        ' 
        DataGridVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridVentas.Location = New Point(14, 28)
        DataGridVentas.Name = "DataGridVentas"
        DataGridVentas.Size = New Size(584, 101)
        DataGridVentas.TabIndex = 6
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Silver
        GroupBox1.Controls.Add(DataGridVentas)
        GroupBox1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(113, 164)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(624, 158)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        GroupBox1.Text = "Ventas Realizadas"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Silver
        GroupBox2.Controls.Add(DataGridVentaDetalle)
        GroupBox2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(113, 328)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(624, 158)
        GroupBox2.TabIndex = 8
        GroupBox2.TabStop = False
        GroupBox2.Text = "Detalle de Venta"
        ' 
        ' DataGridVentaDetalle
        ' 
        DataGridVentaDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridVentaDetalle.Location = New Point(19, 28)
        DataGridVentaDetalle.Name = "DataGridVentaDetalle"
        DataGridVentaDetalle.Size = New Size(584, 115)
        DataGridVentaDetalle.TabIndex = 0
        ' 
        ' btnAtrasBuscaVentas
        ' 
        btnAtrasBuscaVentas.Location = New Point(12, 463)
        btnAtrasBuscaVentas.Name = "btnAtrasBuscaVentas"
        btnAtrasBuscaVentas.Size = New Size(75, 23)
        btnAtrasBuscaVentas.TabIndex = 9
        btnAtrasBuscaVentas.Text = "Atras"
        btnAtrasBuscaVentas.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(302, 129)
        Label4.Name = "Label4"
        Label4.Size = New Size(177, 15)
        Label4.TabIndex = 10
        Label4.Text = "Total Vendido entre estas fechas:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(485, 129)
        Label5.Name = "Label5"
        Label5.Size = New Size(13, 15)
        Label5.TabIndex = 11
        Label5.Text = "$"
        ' 
        ' lblTotalVendido
        ' 
        lblTotalVendido.AutoSize = True
        lblTotalVendido.Location = New Point(494, 129)
        lblTotalVendido.Name = "lblTotalVendido"
        lblTotalVendido.Size = New Size(13, 15)
        lblTotalVendido.TabIndex = 12
        lblTotalVendido.Text = "0"
        ' 
        ' FormVentas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 498)
        ControlBox = False
        Controls.Add(lblTotalVendido)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(btnAtrasBuscaVentas)
        Controls.Add(GroupBox2)
        Controls.Add(btnBuscarFecha)
        Controls.Add(DateTimePickerFinal)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DateTimePickerInicial)
        Controls.Add(GroupBox1)
        Name = "FormVentas"
        Text = "FormVentas"
        CType(DataGridVentas, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        CType(DataGridVentaDetalle, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DateTimePickerInicial As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePickerFinal As DateTimePicker
    Friend WithEvents btnBuscarFecha As Button
    Friend WithEvents DataGridVentas As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridVentaDetalle As DataGridView
    Friend WithEvents btnAtrasBuscaVentas As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotalVendido As Label
End Class

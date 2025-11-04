<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuInicial
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
        btnABMproductos = New Button()
        btnABMclientes = New Button()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        Label1 = New Label()
        btnSalirMenu = New Button()
        GroupBox3 = New GroupBox()
        Button1 = New Button()
        GroupBox4 = New GroupBox()
        btnGestionarEstadísticas = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnABMproductos
        ' 
        btnABMproductos.Location = New Point(23, 29)
        btnABMproductos.Name = "btnABMproductos"
        btnABMproductos.Size = New Size(106, 41)
        btnABMproductos.TabIndex = 0
        btnABMproductos.Text = "Gestionar Productos"
        btnABMproductos.UseVisualStyleBackColor = True
        ' 
        ' btnABMclientes
        ' 
        btnABMclientes.Location = New Point(23, 29)
        btnABMclientes.Name = "btnABMclientes"
        btnABMclientes.Size = New Size(106, 41)
        btnABMclientes.TabIndex = 3
        btnABMclientes.Text = "Gestionar Clientes"
        btnABMclientes.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Gray
        GroupBox1.Controls.Add(btnABMproductos)
        GroupBox1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        GroupBox1.Location = New Point(125, 350)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(156, 76)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "Productos"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Gray
        GroupBox2.Controls.Add(btnABMclientes)
        GroupBox2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        GroupBox2.Location = New Point(125, 268)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(156, 76)
        GroupBox2.TabIndex = 5
        GroupBox2.TabStop = False
        GroupBox2.Text = "Clientes"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 20.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(48, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(292, 37)
        Label1.TabIndex = 6
        Label1.Text = "Acciones Disponibles"
        ' 
        ' btnSalirMenu
        ' 
        btnSalirMenu.Location = New Point(3, 363)
        btnSalirMenu.Name = "btnSalirMenu"
        btnSalirMenu.Size = New Size(75, 35)
        btnSalirMenu.TabIndex = 7
        btnSalirMenu.Text = "Salir"
        btnSalirMenu.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.Gray
        GroupBox3.Controls.Add(Button1)
        GroupBox3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        GroupBox3.Location = New Point(125, 186)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(156, 76)
        GroupBox3.TabIndex = 8
        GroupBox3.TabStop = False
        GroupBox3.Text = "Ventas"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(23, 29)
        Button1.Name = "Button1"
        Button1.Size = New Size(106, 41)
        Button1.TabIndex = 3
        Button1.Text = "Gestionar Ventas"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackColor = Color.Gray
        GroupBox4.Controls.Add(btnGestionarEstadísticas)
        GroupBox4.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        GroupBox4.Location = New Point(125, 103)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(156, 77)
        GroupBox4.TabIndex = 9
        GroupBox4.TabStop = False
        GroupBox4.Text = "Estadísticas"
        ' 
        ' btnGestionarEstadísticas
        ' 
        btnGestionarEstadísticas.Location = New Point(23, 32)
        btnGestionarEstadísticas.Name = "btnGestionarEstadísticas"
        btnGestionarEstadísticas.Size = New Size(106, 41)
        btnGestionarEstadísticas.TabIndex = 3
        btnGestionarEstadísticas.Text = "Gestionar Ventas"
        btnGestionarEstadísticas.UseVisualStyleBackColor = True
        ' 
        ' MenuInicial
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(375, 430)
        ControlBox = False
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(btnSalirMenu)
        Controls.Add(Label1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "MenuInicial"
        Text = "MenuInicial"
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox4.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnABMproductos As Button
    Friend WithEvents btnABMclientes As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSalirMenu As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnGestionarEstadísticas As Button
End Class

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
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnABMproductos
        ' 
        btnABMproductos.Location = New Point(6, 29)
        btnABMproductos.Name = "btnABMproductos"
        btnABMproductos.Size = New Size(106, 41)
        btnABMproductos.TabIndex = 0
        btnABMproductos.Text = "Gestionar Productos"
        btnABMproductos.UseVisualStyleBackColor = True
        ' 
        ' btnABMclientes
        ' 
        btnABMclientes.Location = New Point(6, 32)
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
        GroupBox1.Location = New Point(124, 287)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(118, 76)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "Productos"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Gray
        GroupBox2.Controls.Add(btnABMclientes)
        GroupBox2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        GroupBox2.Location = New Point(124, 205)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(118, 76)
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
        btnSalirMenu.Location = New Point(1, 328)
        btnSalirMenu.Name = "btnSalirMenu"
        btnSalirMenu.Size = New Size(75, 35)
        btnSalirMenu.TabIndex = 7
        btnSalirMenu.Text = "Salir"
        btnSalirMenu.UseVisualStyleBackColor = True
        ' 
        ' MenuInicial
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(375, 367)
        ControlBox = False
        Controls.Add(btnSalirMenu)
        Controls.Add(Label1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "MenuInicial"
        Text = "MenuInicial"
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnABMproductos As Button
    Friend WithEvents btnABMclientes As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSalirMenu As Button
End Class

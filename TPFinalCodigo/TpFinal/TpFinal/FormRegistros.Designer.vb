<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRegistros))
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtUsuarioRegistro = New TextBox()
        txtContraseñaRegistro = New TextBox()
        txtConfirContrRegistro = New TextBox()
        btnRegistrar = New Button()
        btnAtrasRegistrar = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(72, 65)
        Label1.Name = "Label1"
        Label1.Size = New Size(117, 25)
        Label1.TabIndex = 0
        Label1.Text = "Registrarse"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(105, 15)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(50, 47)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(56, 132)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 15)
        Label2.TabIndex = 6
        Label2.Text = "Usuario:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(56, 166)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 15)
        Label3.TabIndex = 7
        Label3.Text = "Contraseña:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 228)
        Label4.Name = "Label4"
        Label4.Size = New Size(127, 15)
        Label4.TabIndex = 8
        Label4.Text = "Confirmar Contraseña:"
        ' 
        ' txtUsuarioRegistro
        ' 
        txtUsuarioRegistro.Location = New Point(132, 129)
        txtUsuarioRegistro.Name = "txtUsuarioRegistro"
        txtUsuarioRegistro.Size = New Size(100, 23)
        txtUsuarioRegistro.TabIndex = 9
        ' 
        ' txtContraseñaRegistro
        ' 
        txtContraseñaRegistro.Location = New Point(132, 163)
        txtContraseñaRegistro.Name = "txtContraseñaRegistro"
        txtContraseñaRegistro.Size = New Size(100, 23)
        txtContraseñaRegistro.TabIndex = 10
        ' 
        ' txtConfirContrRegistro
        ' 
        txtConfirContrRegistro.Location = New Point(132, 225)
        txtConfirContrRegistro.Name = "txtConfirContrRegistro"
        txtConfirContrRegistro.Size = New Size(100, 23)
        txtConfirContrRegistro.TabIndex = 11
        ' 
        ' btnRegistrar
        ' 
        btnRegistrar.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        btnRegistrar.FlatStyle = FlatStyle.Popup
        btnRegistrar.Location = New Point(118, 269)
        btnRegistrar.Name = "btnRegistrar"
        btnRegistrar.Size = New Size(126, 30)
        btnRegistrar.TabIndex = 12
        btnRegistrar.Text = "Registrar"
        btnRegistrar.UseVisualStyleBackColor = False
        ' 
        ' btnAtrasRegistrar
        ' 
        btnAtrasRegistrar.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        btnAtrasRegistrar.FlatStyle = FlatStyle.Popup
        btnAtrasRegistrar.Location = New Point(12, 273)
        btnAtrasRegistrar.Name = "btnAtrasRegistrar"
        btnAtrasRegistrar.Size = New Size(42, 23)
        btnAtrasRegistrar.TabIndex = 13
        btnAtrasRegistrar.Text = "Atras"
        btnAtrasRegistrar.UseVisualStyleBackColor = False
        ' 
        ' FormRegistros
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(275, 311)
        Controls.Add(btnAtrasRegistrar)
        Controls.Add(btnRegistrar)
        Controls.Add(txtConfirContrRegistro)
        Controls.Add(txtContraseñaRegistro)
        Controls.Add(txtUsuarioRegistro)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Name = "FormRegistros"
        Text = "FormRegistros"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtUsuarioRegistro As TextBox
    Friend WithEvents txtContraseñaRegistro As TextBox
    Friend WithEvents txtConfirContrRegistro As TextBox
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnAtrasRegistrar As Button
End Class

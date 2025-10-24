<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LogIn
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogIn))
        Label1 = New Label()
        Label2 = New Label()
        txtUsuarioLogIn = New TextBox()
        txtContraseñaLogIn = New TextBox()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        btnIniciarSesion = New Button()
        Label4 = New Label()
        LinkLabelRegistrarse = New LinkLabel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(56, 139)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 21)
        Label1.TabIndex = 0
        Label1.Text = "Usuario:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(58, 172)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 21)
        Label2.TabIndex = 1
        Label2.Text = "Contraseña:"
        ' 
        ' txtUsuarioLogIn
        ' 
        txtUsuarioLogIn.Location = New Point(155, 141)
        txtUsuarioLogIn.Name = "txtUsuarioLogIn"
        txtUsuarioLogIn.Size = New Size(100, 23)
        txtUsuarioLogIn.TabIndex = 2
        ' 
        ' txtContraseñaLogIn
        ' 
        txtContraseñaLogIn.Location = New Point(155, 173)
        txtContraseñaLogIn.Name = "txtContraseñaLogIn"
        txtContraseñaLogIn.PasswordChar = "*"c
        txtContraseñaLogIn.Size = New Size(100, 23)
        txtContraseñaLogIn.TabIndex = 3
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(133, 28)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(50, 47)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(87, 92)
        Label3.Name = "Label3"
        Label3.Size = New Size(148, 25)
        Label3.TabIndex = 5
        Label3.Text = "Inicio de Sesion"
        ' 
        ' btnIniciarSesion
        ' 
        btnIniciarSesion.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        btnIniciarSesion.FlatStyle = FlatStyle.Popup
        btnIniciarSesion.Location = New Point(98, 227)
        btnIniciarSesion.Name = "btnIniciarSesion"
        btnIniciarSesion.Size = New Size(126, 30)
        btnIniciarSesion.TabIndex = 6
        btnIniciarSesion.Text = "Iniciar Sesion"
        btnIniciarSesion.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(72, 271)
        Label4.Name = "Label4"
        Label4.Size = New Size(172, 15)
        Label4.TabIndex = 7
        Label4.Text = "Si todavia no tiene una cuenta: "
        ' 
        ' LinkLabelRegistrarse
        ' 
        LinkLabelRegistrarse.AutoSize = True
        LinkLabelRegistrarse.Location = New Point(250, 271)
        LinkLabelRegistrarse.Name = "LinkLabelRegistrarse"
        LinkLabelRegistrarse.Size = New Size(64, 15)
        LinkLabelRegistrarse.TabIndex = 8
        LinkLabelRegistrarse.TabStop = True
        LinkLabelRegistrarse.Text = "Registrarse"
        ' 
        ' LogIn
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(315, 307)
        Controls.Add(LinkLabelRegistrarse)
        Controls.Add(Label4)
        Controls.Add(btnIniciarSesion)
        Controls.Add(Label3)
        Controls.Add(PictureBox1)
        Controls.Add(txtContraseñaLogIn)
        Controls.Add(txtUsuarioLogIn)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "LogIn"
        Text = "Iniciar Sesion"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsuarioLogIn As TextBox
    Friend WithEvents txtContraseñaLogIn As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnIniciarSesion As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents LinkLabelRegistrarse As LinkLabel

End Class

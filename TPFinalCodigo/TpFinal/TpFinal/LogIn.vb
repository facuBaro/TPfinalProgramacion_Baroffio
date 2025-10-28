Public Class LogIn
    Dim UsuarioLogueado As LogueoUsuarios
    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        If Not String.IsNullOrWhiteSpace(txtUsuarioLogIn.Text) And Not String.IsNullOrWhiteSpace(txtContraseñaLogIn.Text) Then
            UsuarioLogueado = New LogueoUsuarios(txtUsuarioLogIn.Text, txtContraseñaLogIn.Text)

            If UsuarioLogueado.CorroborarDatos() = True Then
                MessageBox.Show("Se inicio sesion correctamente")
                MenuInicial.Show()
                Me.Hide()
            Else
                MessageBox.Show("Error al iniciar sesion, usuario no registrado")
            End If
        Else
            MessageBox.Show("Complete los datos requeridos")
        End If

    End Sub

    Private Sub LinkLabelRegistrarse_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelRegistrarse.LinkClicked
        FormRegistros.Show()
        txtContraseñaLogIn.Clear()
        txtUsuarioLogIn.Clear()
        Me.Hide()
    End Sub
End Class

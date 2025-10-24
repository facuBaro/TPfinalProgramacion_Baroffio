Public Class FormRegistros
    Dim UsuarioRegistrado As RegistroUsuarios
    Private Sub btnAtrasRegistrar_Click(sender As Object, e As EventArgs) Handles btnAtrasRegistrar.Click
        txtUsuarioRegistro.Clear()
        txtConfirContrRegistro.Clear()
        LogIn.Show()
        Me.Hide()
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If txtConfirContrRegistro.Text <> txtContraseñaRegistro.Text Then
            MessageBox.Show("Las contraseñas no coinciden")
        Else
            UsuarioRegistrado = New RegistroUsuarios(txtUsuarioRegistro.Text, txtConfirContrRegistro.Text)
            UsuarioRegistrado.RegistrarUsuarios()

        End If
    End Sub
End Class
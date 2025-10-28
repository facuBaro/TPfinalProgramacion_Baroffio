Public Class FormRegistros
    Dim UsuarioRegistrado As RegistroUsuarios
    Private Sub btnAtrasRegistrar_Click(sender As Object, e As EventArgs) Handles btnAtrasRegistrar.Click
        txtUsuarioRegistro.Clear()
        txtConfirContrRegistro.Clear()
        txtContraseñaRegistro.Clear()
        LogIn.Show()
        Me.Hide()
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If txtConfirContrRegistro.Text <> txtContraseñaRegistro.Text Then
            MessageBox.Show("Las contraseñas no coinciden")
        Else
            If (Not String.IsNullOrWhiteSpace(txtUsuarioRegistro.Text) And Not String.IsNullOrWhiteSpace(txtConfirContrRegistro.Text) And Not String.IsNullOrWhiteSpace(txtContraseñaRegistro.Text)) Then
                UsuarioRegistrado = New RegistroUsuarios(txtUsuarioRegistro.Text, txtConfirContrRegistro.Text)
                UsuarioRegistrado.RegistrarUsuarios()
            Else
                MessageBox.Show("Ingrese los datos requeridos")
            End If


        End If
    End Sub
End Class
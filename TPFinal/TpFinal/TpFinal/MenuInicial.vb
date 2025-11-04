Public Class MenuInicial

    Private Sub btnABMproductos_Click(sender As Object, e As EventArgs) Handles btnABMproductos.Click
        FormProductos.Show()
        Me.Hide()
    End Sub

    Private Sub btnABMclientes_Click(sender As Object, e As EventArgs) Handles btnABMclientes.Click
        FormClientes.Show()
        Me.Hide()
    End Sub

    Private Sub btnSalirMenu_Click(sender As Object, e As EventArgs) Handles btnSalirMenu.Click
        End

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormVentasItem.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnGestionarEstadísticas.Click
        FormVentas.Show()
        Me.Hide()
    End Sub
End Class
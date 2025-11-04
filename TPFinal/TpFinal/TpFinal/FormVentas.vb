Public Class FormVentas
    Private Sub btnBuscarFecha_Click(sender As Object, e As EventArgs) Handles btnBuscarFecha.Click
        DataGridVentaDetalle.DataSource = Nothing
        Dim fechaInicial As Date = DateTimePickerInicial.Value
        Dim fechaFinal As Date = DateTimePickerFinal.Value
        Dim ventaBuscada As ventas = New ventas()

        lblTotalVendido.Text = ventaBuscada.BuscarVentas(DataGridVentas, fechaInicial, fechaFinal)
    End Sub

    Private Sub btnAtrasBuscaVentas_Click(sender As Object, e As EventArgs) Handles btnAtrasBuscaVentas.Click
        MenuInicial.Show()
        Me.Close()
    End Sub

    Private Sub DataGridVentas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridVentas.CellClick
        If e.RowIndex >= 0 Then
            Dim valorCelda As Object = DataGridVentas.Rows(e.RowIndex).Cells("id_ventas").Value
            If (valorCelda IsNot Nothing And Not IsDBNull(valorCelda)) Then
                Dim idVenta As Integer = Convert.ToInt32(DataGridVentas.Rows(e.RowIndex).Cells("id_ventas").Value)
                Dim ventaDetallada As ventas = New ventas()
                ventaDetallada.MostrarDetalleVenta(DataGridVentaDetalle, idVenta)
            End If

        End If
    End Sub
End Class
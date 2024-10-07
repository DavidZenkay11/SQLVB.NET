Public Class FormMenu

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Dim frmClientes As New FormClientes()
        frmClientes.Show()
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        Dim frmProductos As New FormProductos()
        frmProductos.Show()
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        Dim frmVentas As New FormVentas()
        frmVentas.Show()
    End Sub

End Class
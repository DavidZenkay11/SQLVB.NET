Public Class FormMenu
    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim frmClientes As New FormClientes()
        frmClientes.Show()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        Dim frmProductos As New FormProductos()
        frmProductos.Show()
    End Sub

    Private Sub VentasItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasItemsToolStripMenuItem.Click
        Dim frmVentas As New FormVentas()
        frmVentas.Show()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        Dim frmMostrarVentas As New FormMostrarVentas()
        frmMostrarVentas.Show()
    End Sub
End Class
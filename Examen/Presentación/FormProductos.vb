Public Class FormProductos
    Private Sub FormProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarProductos()
    End Sub
    Private Sub CargarProductos()
        Dim datos As New ProductoDatos()
        Dim dataTable As DataTable = datos.ObtenerProductos()
        dgvProductos.DataSource = dataTable
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim producto As New Producto()
        producto.Nombre = txtNombre.Text
        producto.Precio = Convert.ToDecimal(txtPrecio.Text)
        producto.Categoria = txtCategoria.Text

        Dim datos As New ProductoDatos()
        datos.InsertarProducto(producto)

        MessageBox.Show("Producto agregado exitosamente")
        CargarProductos()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If dgvProductos.SelectedRows.Count > 0 Then

            Dim producto As New Producto()
            producto.Id = Convert.ToInt32(dgvProductos.SelectedRows(0).Cells("Id").Value)
            producto.Nombre = txtNombre.Text

            Dim precio As Decimal
            If Decimal.TryParse(txtPrecio.Text, precio) Then
                producto.Precio = precio
            Else
                MessageBox.Show("Por favor, ingrese un precio válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            producto.Categoria = txtCategoria.Text


            Dim datos As New ProductoDatos()
            datos.EditarProducto(producto)

            MessageBox.Show("Producto editado exitosamente")
            CargarProductos()
        Else
            MessageBox.Show("Seleccione un producto para editar")
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvProductos.SelectedRows.Count > 0 Then
            Dim productoId As Integer = Convert.ToInt32(dgvProductos.SelectedRows(0).Cells("Id").Value)

            Dim datos As New ProductoDatos()
            datos.EliminarProducto(productoId)

            MessageBox.Show("Producto eliminado exitosamente")
            CargarProductos()
        Else
            MessageBox.Show("Seleccione un producto para eliminar")
        End If
    End Sub

    Private Sub txtBuscarProducto_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarProducto.TextChanged

        Dim filtroSeleccionado As String = cmbFiltroProducto.SelectedItem.ToString()
        Dim valorBusqueda As String = txtBuscarProducto.Text
        Dim datos As New ProductoDatos()

        If filtroSeleccionado = "Nombre" Then
            dgvProductos.DataSource = datos.BuscarProductosPorNombre(valorBusqueda)
        ElseIf filtroSeleccionado = "Categoría" Then
            dgvProductos.DataSource = datos.BuscarProductosPorCategoria(valorBusqueda)
        End If
    End Sub


    Private Sub cmbFiltroProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbFiltroProducto.KeyPress
        e.Handled = True
    End Sub
End Class
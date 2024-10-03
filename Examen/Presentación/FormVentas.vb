Public Class FormVentas
    Private Sub CargarVentas()
        Dim datos As New VentaDatos()
        Dim dataTable As DataTable = datos.ObtenerVentas()
        dgvVentas.DataSource = dataTable
    End Sub
    Private Sub FormVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarVentas()
    End Sub
    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        ' Obtener el producto seleccionado
        Dim productoId As Integer = Convert.ToInt32(cmbProducto.SelectedValue)
        Dim cantidad As Integer = Convert.ToInt32(txtCantidad.Text)
        Dim precioUnitario As Decimal = Convert.ToDecimal(txtPrecioUnitario.Text)
        Dim precioTotal As Decimal = cantidad * precioUnitario

        ' Agregar el producto al DataGridView
        dgvVentas.Rows.Add(productoId, cmbProducto.Text, cantidad, precioUnitario, precioTotal)

        ' Actualizar el total de la venta
        ActualizarTotal()
    End Sub

    Private Sub btnGuardarVenta_Click(sender As Object, e As EventArgs) Handles btnGuardarVenta.Click
        Dim venta As New Venta()
        venta.ClienteId = Convert.ToInt32(cmbCliente.SelectedValue)
        venta.Fecha = DateTime.Now
        venta.Total = Convert.ToDecimal(txtTotal.Text)

        ' Recorrer los productos en el DataGridView y agregarlos a la lista de productos de la venta
        venta.Productos = New List(Of VentaProducto)
        For Each row As DataGridViewRow In dgvVentas.Rows
            If Not row.IsNewRow Then
                Dim producto As New VentaProducto()
                producto.ProductoId = Convert.ToInt32(row.Cells("ProductoId").Value)
                producto.Cantidad = Convert.ToInt32(row.Cells("Cantidad").Value)
                producto.PrecioUnitario = Convert.ToDecimal(row.Cells("PrecioUnitario").Value)
                producto.PrecioTotal = Convert.ToDecimal(row.Cells("PrecioTotal").Value)
                venta.Productos.Add(producto)
            End If
        Next

        ' Guardar la venta en la base de datos
        Dim datos As New VentaDatos()
        datos.InsertarVenta(venta)

        MessageBox.Show("Venta guardada exitosamente")
        CargarVentas()
    End Sub

    Private Sub btnEditarVenta_Click(sender As Object, e As EventArgs) Handles btnEditarVenta.Click
        If dgvVentas.SelectedRows.Count > 0 Then
            ' Obtener el ID de la venta seleccionada
            Dim ventaId As Integer = Convert.ToInt32(dgvVentas.SelectedRows(0).Cells("Id").Value)

            ' Cargar los datos de la venta para editar
            Dim venta As New Venta()
            venta.Id = ventaId
            venta.ClienteId = Convert.ToInt32(cmbCliente.SelectedValue)
            venta.Fecha = DateTime.Now
            venta.Total = Convert.ToDecimal(txtTotal.Text)

            ' Obtener los productos desde el DataGridView
            venta.Productos = New List(Of VentaProducto)
            For Each row As DataGridViewRow In dgvVentas.Rows
                If Not row.IsNewRow Then
                    Dim producto As New VentaProducto()
                    producto.ProductoId = Convert.ToInt32(row.Cells("ProductoId").Value)
                    producto.Cantidad = Convert.ToInt32(row.Cells("Cantidad").Value)
                    producto.PrecioUnitario = Convert.ToDecimal(row.Cells("PrecioUnitario").Value)
                    producto.PrecioTotal = Convert.ToDecimal(row.Cells("PrecioTotal").Value)
                    venta.Productos.Add(producto)
                End If
            Next

            ' Actualizar la venta en la base de datos
            Dim datos As New VentaDatos()
            datos.EditarVenta(venta)

            MessageBox.Show("Venta editada exitosamente")

            ' Recargar las ventas para reflejar los cambios
            CargarVentas()
        Else
            MessageBox.Show("Seleccione una venta para editar")
        End If
    End Sub


    Private Sub ActualizarTotal()
        Dim total As Decimal = 0
        For Each row As DataGridViewRow In dgvVentas.Rows
            If Not row.IsNewRow Then
                total += Convert.ToDecimal(row.Cells("PrecioTotal").Value)
            End If
        Next
        txtTotal.Text = total.ToString("F2")
    End Sub


End Class
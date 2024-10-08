Public Class FormVentas
    Private Sub FormVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvItemsVenta.Columns.Add("ProductoId", "ID Producto")
        dgvItemsVenta.Columns.Add("NombreProducto", "Nombre del Producto")
        dgvItemsVenta.Columns.Add("Cantidad", "Cantidad")
        dgvItemsVenta.Columns.Add("PrecioUnitario", "Precio Unitario")
        dgvItemsVenta.Columns.Add("PrecioTotal", "Precio Total del Ítem")


        PoblarComboClientes()

        PoblarComboProductos()
    End Sub
    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click

        Dim productoId As Integer = Convert.ToInt32(cmbProducto.SelectedValue)
        Dim nombreProducto As String = cmbProducto.Text
        Dim cantidad As Integer = Convert.ToInt32(txtCantidad.Text)
        Dim precioUnitario As Decimal = Convert.ToDecimal(txtPrecioUnitario.Text)
        Dim precioTotal As Decimal = cantidad * precioUnitario


        dgvItemsVenta.Rows.Add(productoId, nombreProducto, cantidad, precioUnitario.ToString("F2"), precioTotal.ToString("F2"))


        ActualizarTotalGeneral()
    End Sub
    Private Sub ActualizarTotalGeneral()
        Dim totalGeneral As Decimal = 0
        For Each row As DataGridViewRow In dgvItemsVenta.Rows
            If Not row.IsNewRow Then
                totalGeneral += Convert.ToDecimal(row.Cells("PrecioTotal").Value)
            End If
        Next


        txtTotalGeneral.Text = totalGeneral.ToString("F2")
    End Sub
    Private Sub btnGuardarVenta_Click(sender As Object, e As EventArgs) Handles btnGuardarVenta.Click

        Dim clienteId As Integer = Convert.ToInt32(cmbCliente.SelectedValue)
        Dim fechaVenta As DateTime = DateTime.Now
        Dim totalGeneral As Decimal = Convert.ToDecimal(txtTotalGeneral.Text)


        Dim datosVenta As New VentaDatos()
        Dim ventaId As Integer = datosVenta.InsertarVenta(clienteId, fechaVenta, totalGeneral)

        GuardarProductosEnVenta(ventaId)
    End Sub

    Private Sub GuardarProductosEnVenta(ventaId As Integer)
        Dim datosVenta As New VentaDatos()

        For Each row As DataGridViewRow In dgvItemsVenta.Rows
            If Not row.IsNewRow Then
                Dim productoId As Integer = Convert.ToInt32(row.Cells("ProductoId").Value)
                Dim cantidad As Integer = Convert.ToInt32(row.Cells("Cantidad").Value)
                Dim precioUnitario As Decimal = Convert.ToDecimal(row.Cells("PrecioUnitario").Value)
                Dim precioTotal As Decimal = Convert.ToDecimal(row.Cells("PrecioTotal").Value)

                datosVenta.InsertarProductoEnVenta(ventaId, productoId, cantidad, precioUnitario, precioTotal)
            End If
        Next
    End Sub
    Private Sub PoblarComboClientes()
        Dim datosCliente As New ClienteDatos()
        Dim dtClientes As DataTable = datosCliente.ObtenerClientes()


        cmbCliente.DataSource = dtClientes
        cmbCliente.DisplayMember = "Cliente"
        cmbCliente.ValueMember = "ID"
    End Sub

    Private Sub PoblarComboProductos()
        Dim datosProducto As New ProductoDatos()
        Dim dtProductos As DataTable = datosProducto.ObtenerProductos()

        cmbProducto.DataSource = dtProductos
        cmbProducto.DisplayMember = "Nombre"
        cmbProducto.ValueMember = "ID"
    End Sub

    Private Sub cmbProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProducto.SelectedIndexChanged

        Dim productoSeleccionado As DataRowView = CType(cmbProducto.SelectedItem, DataRowView)

        Dim precioUnitario As Decimal = Convert.ToDecimal(productoSeleccionado("Precio"))

        txtPrecioUnitario.Text = precioUnitario.ToString("F2")

        txtCantidad.Text = "1"

        Dim cantidad As Integer = 1
        txtTotalGeneral.Text = (cantidad * precioUnitario).ToString("F2")
    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        Dim cantidad As Integer
        Dim precioUnitario As Decimal = Convert.ToDecimal(txtPrecioUnitario.Text)

        If Integer.TryParse(txtCantidad.Text, cantidad) AndAlso cantidad > 0 Then

            txtTotalGeneral.Text = (cantidad * precioUnitario).ToString("F2")
        Else

            txtCantidad.Text = "1"
            txtTotalGeneral.Text = (1 * precioUnitario).ToString("F2")
        End If
    End Sub
End Class
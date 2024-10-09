Public Class FormMostrarVentas
    Private Sub FormMostrarVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim datosVenta As New VentaDatos()
        Dim dtVentas As DataTable = datosVenta.ObtenerVentas()
        dgvVentas.DataSource = dtVentas

        ConfigurarDataGridView()
        cmbFiltro.SelectedIndex = 0

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

        Dim filtroSeleccionado As String = cmbFiltro.SelectedItem.ToString()


        Dim valorBusqueda As String = txtBuscar.Text


        Dim datos As New VentaDatos()


        If filtroSeleccionado = "ID de Venta" Then

            Dim ventaId As Integer
            If Integer.TryParse(valorBusqueda, ventaId) Then

                dgvVentas.DataSource = datos.BuscarVentas("ID de Venta", valorBusqueda)
            Else
                Restablecer()
            End If

        ElseIf filtroSeleccionado = "Cliente" Then

            If Not String.IsNullOrWhiteSpace(valorBusqueda) Then

                dgvVentas.DataSource = datos.BuscarVentas("Cliente", valorBusqueda)
            Else
                Restablecer()

            End If
        Else
            Restablecer()
        End If

    End Sub

    Private Sub ConfigurarDataGridView()
        dgvVentas.AutoGenerateColumns = False
        dgvVentas.AllowUserToAddRows = False
        dgvVentas.AllowUserToDeleteRows = False
        dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvVentas.ReadOnly = True

        dgvVentas.Columns.Clear()


        Dim colVentaId As New DataGridViewTextBoxColumn()
        colVentaId.Name = "VentaId"
        colVentaId.HeaderText = "ID Venta"
        colVentaId.DataPropertyName = "VentaId"
        colVentaId.Width = 50
        dgvVentas.Columns.Add(colVentaId)

        Dim colNombreCliente As New DataGridViewTextBoxColumn()
        colNombreCliente.Name = "NombreCliente"
        colNombreCliente.HeaderText = "Cliente"
        colNombreCliente.DataPropertyName = "NombreCliente"
        colNombreCliente.Width = 150
        dgvVentas.Columns.Add(colNombreCliente)


        Dim colFecha As New DataGridViewTextBoxColumn()
        colFecha.Name = "Fecha"
        colFecha.HeaderText = "Fecha de la Venta"
        colFecha.DataPropertyName = "Fecha"
        colFecha.Width = 120
        colFecha.DefaultCellStyle.Format = "d"
        dgvVentas.Columns.Add(colFecha)


        Dim colTotal As New DataGridViewTextBoxColumn()
        colTotal.Name = "Total"
        colTotal.HeaderText = "Total de Venta"
        colTotal.DataPropertyName = "Total"
        colTotal.Width = 100
        colTotal.DefaultCellStyle.Format = "C2"
        dgvVentas.Columns.Add(colTotal)


        Dim colNombreProducto As New DataGridViewTextBoxColumn()
        colNombreProducto.Name = "NombreProducto"
        colNombreProducto.HeaderText = "Producto"
        colNombreProducto.DataPropertyName = "NombreProducto"
        colNombreProducto.Width = 150
        dgvVentas.Columns.Add(colNombreProducto)


        Dim colCantidad As New DataGridViewTextBoxColumn()
        colCantidad.Name = "Cantidad"
        colCantidad.HeaderText = "Cantidad"
        colCantidad.DataPropertyName = "Cantidad"
        colCantidad.Width = 80
        dgvVentas.Columns.Add(colCantidad)


        Dim colPrecioUnitario As New DataGridViewTextBoxColumn()
        colPrecioUnitario.Name = "PrecioUnitario"
        colPrecioUnitario.HeaderText = "Precio Unitario"
        colPrecioUnitario.DataPropertyName = "PrecioUnitario"
        colPrecioUnitario.Width = 100
        colPrecioUnitario.DefaultCellStyle.Format = "C2"
        dgvVentas.Columns.Add(colPrecioUnitario)


        Dim colPrecioTotal As New DataGridViewTextBoxColumn()
        colPrecioTotal.Name = "PrecioTotal"
        colPrecioTotal.HeaderText = "Total del Producto"
        colPrecioTotal.DataPropertyName = "PrecioTotal"
        colPrecioTotal.Width = 100
        colPrecioTotal.DefaultCellStyle.Format = "C2"
        dgvVentas.Columns.Add(colPrecioTotal)
    End Sub

    Private Sub Restablecer()
        Dim datosVenta As New VentaDatos()
        Dim dtVentas As DataTable = datosVenta.ObtenerVentas()
        dgvVentas.DataSource = dtVentas
    End Sub
    Private Sub CargarVentasConProductos()

        Dim datosVenta As New VentaDatos()


        Dim dtVentas As DataTable = datosVenta.ObtenerVentasConProductos()


        dgvVentas.DataSource = dtVentas
    End Sub

    Private Sub cmbFiltro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbFiltro.KeyPress
        e.Handled = True
    End Sub


End Class
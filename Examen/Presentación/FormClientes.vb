Public Class FormClientes
    Private Sub FormClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarClientes()
        If cmbFiltroCliente.Items.Count > 0 Then
            cmbFiltroCliente.SelectedIndex = 0
        End If
        cmbFiltroCliente.SelectedIndex = 0
    End Sub
    Private Sub CargarClientes()
        Dim datos As New ClienteDatos()
        Dim dataTable As DataTable = datos.ObtenerClientes()


        dgvClientes.DataSource = dataTable
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim cliente As New Cliente()
        cliente.Nombre = txtNombre.Text
        cliente.Correo = txtCorreo.Text
        cliente.Telefono = txtTelefono.Text

        Dim datos As New ClienteDatos()
        datos.InsertarCliente(cliente)

        MessageBox.Show("Cliente agregado exitosamente")
        CargarClientes()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If dgvClientes.SelectedRows.Count > 0 Then
            Dim cliente As New Cliente()
            cliente.Id = Convert.ToInt32(dgvClientes.SelectedRows(0).Cells("Id").Value)
            cliente.Nombre = txtNombre.Text
            cliente.Correo = txtCorreo.Text
            cliente.Telefono = txtTelefono.Text

            Dim datos As New ClienteDatos()
            datos.EditarCliente(cliente)

            MessageBox.Show("Cliente editado exitosamente")
            CargarClientes()
        Else
            MessageBox.Show("Seleccione un cliente para editar")
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvClientes.SelectedRows.Count > 0 Then
            Dim clienteId As Integer = Convert.ToInt32(dgvClientes.SelectedRows(0).Cells("Id").Value)

            Dim datos As New ClienteDatos()
            datos.EliminarCliente(clienteId)

            MessageBox.Show("Cliente eliminado exitosamente")


            CargarClientes()
        Else
            MessageBox.Show("Seleccione un cliente para eliminar")
        End If
    End Sub

    Private Sub txtBuscarCliente_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarCliente.TextChanged


        Dim filtroSeleccionado As String = cmbFiltroCliente.SelectedItem.ToString()

        Dim valorBusqueda As String = txtBuscarCliente.Text

        Dim datos As New ClienteDatos()

        If filtroSeleccionado = "Nombre" Then
            dgvClientes.DataSource = datos.BuscarClientesPorNombre(valorBusqueda)
        ElseIf filtroSeleccionado = "Teléfono" Then
            dgvClientes.DataSource = datos.BuscarClientesPorTelefono(valorBusqueda)
        End If
    End Sub

    Private Sub cmbFiltroCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbFiltroCliente.KeyPress
        e.Handled = True
    End Sub
End Class
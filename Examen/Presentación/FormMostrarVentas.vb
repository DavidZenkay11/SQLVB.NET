Public Class FormMostrarVentas
    Private Sub FormMostrarVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim datosVenta As New VentaDatos()
        Dim dtVentas As DataTable = datosVenta.ObtenerVentas()
        dgvVentas.DataSource = dtVentas
    End Sub


End Class
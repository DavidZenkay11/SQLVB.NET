Imports System.Data.SqlClient

Public Class VentaDatos
    Dim conexion As New ConexionDB()
    Public Function InsertarVenta(clienteId As Integer, fecha As DateTime, total As Decimal) As Integer
        Dim query As String = "INSERT INTO Ventas (IDCliente, Fecha, Total) OUTPUT INSERTED.ID VALUES (@ClienteId, @Fecha, @Total)"
        Dim cmd As New SqlCommand(query, conexion.AbrirConexion())
        cmd.Parameters.AddWithValue("@ClienteId", clienteId)
        cmd.Parameters.AddWithValue("@Fecha", fecha)
        cmd.Parameters.AddWithValue("@Total", total)

        Dim ventaId As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        conexion.CerrarConexion()

        Return ventaId
    End Function
    Public Sub InsertarProductoEnVenta(ventaId As Integer, productoId As Integer, cantidad As Integer, precioUnitario As Decimal, precioTotal As Decimal)
        Dim query As String = "INSERT INTO VentasItems (IDVenta, IDProducto, PrecioUnitario, Cantidad, PrecioTotal) VALUES (@VentaId, @ProductoId, @PrecioUnitario, @Cantidad, @PrecioTotal)"
        Dim cmd As New SqlCommand(query, conexion.AbrirConexion())
        cmd.Parameters.AddWithValue("@VentaId", ventaId)
        cmd.Parameters.AddWithValue("@ProductoId", productoId)
        cmd.Parameters.AddWithValue("@PrecioUnitario", precioUnitario)
        cmd.Parameters.AddWithValue("@Cantidad", cantidad)
        cmd.Parameters.AddWithValue("@PrecioTotal", precioTotal)

        cmd.ExecuteNonQuery()
        conexion.CerrarConexion()
    End Sub
    Public Function ObtenerVentas() As DataTable
        Dim query As String = "SELECT V.ID AS VentaId, C.Cliente AS NombreCliente, V.Fecha, V.Total FROM Ventas V INNER JOIN Clientes C ON V.IDCliente = C.ID"

        Dim cmd As New SqlCommand(query, conexion.AbrirConexion())
        Dim dataTable As New DataTable()
        Dim adapter As New SqlDataAdapter(cmd)

        adapter.Fill(dataTable)
        conexion.CerrarConexion()
        Return dataTable
    End Function
End Class

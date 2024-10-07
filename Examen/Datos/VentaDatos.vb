Imports System.Data.SqlClient

Public Class VentaDatos
    Dim conexion As New ConexionDB()
    Public Sub InsertarVenta(venta As Venta)
        Dim queryVenta As String = "INSERT INTO Ventas (IDCliente, Total, Fecha) OUTPUT INSERTED.ID VALUES (@IDCliente, @Total, @Fecha)"
        Dim cmdVenta As New SqlCommand(queryVenta, conexion.AbrirConexion())
        cmdVenta.Parameters.AddWithValue("@IDCliente", venta.IDCliente)
        cmdVenta.Parameters.AddWithValue("@Total", venta.Total)
        cmdVenta.Parameters.AddWithValue("@Fecha", venta.Fecha)

        ' Obtener el ID de la venta recién insertada
        Dim ventaId As Integer = Convert.ToInt32(cmdVenta.ExecuteScalar())

        ' Insertar los productos asociados a la venta
        For Each producto In venta.Productos
            Dim queryProducto As String = "INSERT INTO VentaProductos (VentaId, ProductoId, Cantidad, PrecioUnitario, PrecioTotal) VALUES (@VentaId, @ProductoId, @Cantidad, @PrecioUnitario, @PrecioTotal)"
            Dim cmdProducto As New SqlCommand(queryProducto, conexion.AbrirConexion())
            cmdProducto.Parameters.AddWithValue("@VentaId", ventaId)
            cmdProducto.Parameters.AddWithValue("@ProductoId", producto.ProductoId)
            cmdProducto.Parameters.AddWithValue("@Cantidad", producto.Cantidad)
            cmdProducto.Parameters.AddWithValue("@PrecioUnitario", producto.PrecioUnitario)
            cmdProducto.Parameters.AddWithValue("@PrecioTotal", producto.PrecioTotal)
            cmdProducto.ExecuteNonQuery()
        Next

        conexion.CerrarConexion()
    End Sub
    Public Function ObtenerVentas() As DataTable
        Dim query As String = "SELECT V.Id, C.Cliente, V.Total, V.Fecha FROM Ventas V INNER JOIN Clientes C ON V.IDCliente = C.Id"
        Dim cmd As New SqlCommand(query, conexion.AbrirConexion())
        Dim dataTable As New DataTable()
        Dim adapter As New SqlDataAdapter(cmd)
        adapter.Fill(dataTable)
        conexion.CerrarConexion()
        Return dataTable
    End Function

    Public Sub EliminarVenta(ventaId As Integer)

        Dim queryProductos As String = "DELETE FROM VentaProductos WHERE VentaId = @VentaId"
        Dim cmdProductos As New SqlCommand(queryProductos, conexion.AbrirConexion())
        cmdProductos.Parameters.AddWithValue("@VentaId", ventaId)
        cmdProductos.ExecuteNonQuery()


        Dim queryVenta As String = "DELETE FROM Ventas WHERE Id = @VentaId"
        Dim cmdVenta As New SqlCommand(queryVenta, conexion.AbrirConexion())
        cmdVenta.Parameters.AddWithValue("@VentaId", ventaId)
        cmdVenta.ExecuteNonQuery()

        conexion.CerrarConexion()
    End Sub

    Public Sub EditarVenta(venta As Venta)
        ' Primero, eliminar los productos asociados a la venta antes de agregar los actualizados
        Dim queryEliminarProductos As String = "DELETE FROM VentaProductos WHERE VentaId = @VentaId"
        Dim cmdEliminarProductos As New SqlCommand(queryEliminarProductos, conexion.AbrirConexion())
        cmdEliminarProductos.Parameters.AddWithValue("@VentaId", venta.Id)
        cmdEliminarProductos.ExecuteNonQuery()

        ' Actualizar la información de la venta (total)
        Dim queryVenta As String = "UPDATE Ventas SET Total = @Total, Fecha = @Fecha WHERE Id = @VentaId"
        Dim cmdVenta As New SqlCommand(queryVenta, conexion.AbrirConexion())
        cmdVenta.Parameters.AddWithValue("@Total", venta.Total)
        cmdVenta.Parameters.AddWithValue("@Fecha", venta.Fecha)
        cmdVenta.Parameters.AddWithValue("@VentaId", venta.Id)
        cmdVenta.ExecuteNonQuery()

        ' Volver a insertar los productos actualizados
        For Each producto In venta.Productos
            Dim queryProducto As String = "INSERT INTO VentaProductos (VentaId, ProductoId, Cantidad, PrecioUnitario, PrecioTotal) VALUES (@VentaId, @ProductoId, @Cantidad, @PrecioUnitario, @PrecioTotal)"
            Dim cmdProducto As New SqlCommand(queryProducto, conexion.AbrirConexion())
            cmdProducto.Parameters.AddWithValue("@VentaId", venta.Id)
            cmdProducto.Parameters.AddWithValue("@ProductoId", producto.ProductoId)
            cmdProducto.Parameters.AddWithValue("@Cantidad", producto.Cantidad)
            cmdProducto.Parameters.AddWithValue("@PrecioUnitario", producto.PrecioUnitario)
            cmdProducto.Parameters.AddWithValue("@PrecioTotal", producto.PrecioTotal)
            cmdProducto.ExecuteNonQuery()
        Next

        conexion.CerrarConexion()
    End Sub

    Public Function ObtenerReporteVentas() As DataTable
        Dim query As String = "SELECT V.Id, C.Cliente, V.Total, V.Fecha FROM Ventas V INNER JOIN Clientes C ON V.IDCliente = C.Id"
        Dim cmd As New SqlCommand(query, conexion.AbrirConexion())
        Dim dataTable As New DataTable()
        Dim adapter As New SqlDataAdapter(cmd)
        adapter.Fill(dataTable)
        conexion.CerrarConexion()
        Return dataTable
    End Function


End Class

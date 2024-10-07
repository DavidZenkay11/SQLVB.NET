Imports System.Data.SqlClient

Public Class ProductoDatos
    Dim conexion As New ConexionDB()

    Public Function ObtenerProductos() As DataTable
        Dim query As String = "SELECT * FROM Productos"
        Dim cmd As New SqlCommand(query, conexion.AbrirConexion())
        Dim dataTable As New DataTable()
        Dim adapter As New SqlDataAdapter(cmd)
        adapter.Fill(dataTable)
        conexion.CerrarConexion()
        Return dataTable
    End Function

    Public Function BuscarProductos(filtro As String) As DataTable
        Dim query As String = "SELECT * FROM Productos WHERE Nombre LIKE @Filtro OR Categoria LIKE @Filtro"
        Dim cmd As New SqlCommand(query, conexion.AbrirConexion())
        cmd.Parameters.AddWithValue("@Filtro", "%" & filtro & "%")
        Dim dataTable As New DataTable()
        Dim adapter As New SqlDataAdapter(cmd)
        adapter.Fill(dataTable)
        conexion.CerrarConexion()
        Return dataTable
    End Function

    Public Sub InsertarProducto(producto As Producto)
        Dim query As String = "INSERT INTO Productos (Nombre, Precio, Categoria) VALUES (@Nombre, @Precio, @Categoria)"
        Dim cmd As New SqlCommand(query, conexion.AbrirConexion())
        cmd.Parameters.AddWithValue("@Nombre", producto.Nombre)
        cmd.Parameters.AddWithValue("@Precio", producto.Precio)
        cmd.Parameters.AddWithValue("@Categoria", producto.Categoria)
        cmd.ExecuteNonQuery()
        conexion.CerrarConexion()
    End Sub

    Public Sub EditarProducto(producto As Producto)
        Dim query As String = "UPDATE Productos SET Nombre = @Nombre, Precio = @Precio, Categoria = @Categoria WHERE Id = @Id"
        Dim cmd As New SqlCommand(query, conexion.AbrirConexion())
        cmd.Parameters.AddWithValue("@Nombre", producto.Nombre)
        cmd.Parameters.AddWithValue("@Precio", producto.Precio)
        cmd.Parameters.AddWithValue("@Categoria", producto.Categoria)
        cmd.Parameters.AddWithValue("@Id", producto.Id)
        cmd.ExecuteNonQuery()
        conexion.CerrarConexion()
    End Sub

    Public Sub EliminarProducto(productoId As Integer)
        Dim query As String = "DELETE FROM Productos WHERE Id = @Id"
        Dim cmd As New SqlCommand(query, conexion.AbrirConexion())
        cmd.Parameters.AddWithValue("@Id", productoId)
        cmd.ExecuteNonQuery()
        conexion.CerrarConexion()
    End Sub

    Public Function ObtenerReporteProductos() As DataTable
        Dim query As String = "SELECT Nombre, Precio, Categoria FROM Productos"
        Dim cmd As New SqlCommand(query, conexion.AbrirConexion())
        Dim dataTable As New DataTable()
        Dim adapter As New SqlDataAdapter(cmd)
        adapter.Fill(dataTable)
        conexion.CerrarConexion()
        Return dataTable
    End Function

    ' Método para buscar productos por nombre
    Public Function BuscarProductosPorNombre(nombre As String) As DataTable
        Dim query As String = "SELECT * FROM Productos WHERE Nombre LIKE @Nombre"
        Dim cmd As New SqlCommand(query, conexion.AbrirConexion())
        cmd.Parameters.AddWithValue("@Nombre", "%" & nombre & "%")
        Dim dataTable As New DataTable()
        Dim adapter As New SqlDataAdapter(cmd)
        adapter.Fill(dataTable)
        conexion.CerrarConexion()
        Return dataTable
    End Function

    ' Método para buscar productos por categoría
    Public Function BuscarProductosPorCategoria(categoria As String) As DataTable
        Dim query As String = "SELECT * FROM Productos WHERE Categoria LIKE @Categoria"
        Dim cmd As New SqlCommand(query, conexion.AbrirConexion())
        cmd.Parameters.AddWithValue("@Categoria", "%" & categoria & "%")
        Dim dataTable As New DataTable()
        Dim adapter As New SqlDataAdapter(cmd)
        adapter.Fill(dataTable)
        conexion.CerrarConexion()
        Return dataTable
    End Function

End Class

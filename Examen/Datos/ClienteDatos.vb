Imports System.Data.SqlClient

Public Class ClienteDatos
    Dim conexion As New ConexionDB()
    Public Function ObtenerClientes() As DataTable
        Dim query As String = "SELECT * FROM Clientes"
        Dim cmd As New SqlCommand(query, conexion.AbrirConexion())
        Dim dataTable As New DataTable()
        Dim adapter As New SqlDataAdapter(cmd)
        adapter.Fill(dataTable)
        conexion.CerrarConexion()
        Return dataTable
    End Function
    Public Sub InsertarCliente(cliente As Cliente)
        Dim query As String = "INSERT INTO clientes (Cliente, Telefono, Correo) VALUES (@Cliente, @Telefono, @Correo)"
        Dim cmd As New SqlCommand(query, conexion.AbrirConexion())
        cmd.Parameters.AddWithValue("@Cliente", cliente.Nombre)
        cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono)
        cmd.Parameters.AddWithValue("@Correo", cliente.Correo)
        cmd.ExecuteNonQuery()
        conexion.CerrarConexion()

    End Sub

    Public Sub EditarCliente(cliente As Cliente)
        Dim query As String = "UPDATE Clientes SET Cliente = @Cliente, Correo = @Correo, Telefono = @Telefono WHERE Id = @Id"
        Dim cmd As New SqlCommand(query, conexion.AbrirConexion())
        cmd.Parameters.AddWithValue("@Cliente", cliente.Nombre)
        cmd.Parameters.AddWithValue("@Correo", cliente.Correo)
        cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono)
        cmd.Parameters.AddWithValue("@Id", cliente.Id)
        cmd.ExecuteNonQuery()
        conexion.CerrarConexion()
    End Sub

    Public Sub EliminarCliente(clienteId As Integer)
        Dim query As String = "DELETE FROM Clientes WHERE Id = @Id"
        Dim cmd As New SqlCommand(query, conexion.AbrirConexion())
        cmd.Parameters.AddWithValue("@Id", clienteId)
        cmd.ExecuteNonQuery()
        conexion.CerrarConexion()
    End Sub

End Class

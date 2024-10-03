Imports System.Data.SqlClient
Imports System.Configuration
Public Class ConexionDB
    Private connectionString As String = ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString
    Private conexion As SqlConnection

    Public Sub New()
        conexion = New SqlConnection(connectionString)
    End Sub

    Public Function AbrirConexion() As SqlConnection
        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
        End If
        Return conexion
    End Function

    Public Sub CerrarConexion()
        If conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If
    End Sub
End Class

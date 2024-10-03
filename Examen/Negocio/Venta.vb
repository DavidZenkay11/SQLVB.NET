Public Class Venta
    Public Property Id As Integer
    Public Property ClienteId As Integer
    Public Property Total As Decimal
    Public Property Fecha As Date
    Public Property Productos As List(Of VentaProducto)
End Class

Public Class VentaProducto
    Public Property ProductoId As Integer
    Public Property Cantidad As Integer
    Public Property PrecioUnitario As Decimal
    Public Property PrecioTotal As Decimal
End Class

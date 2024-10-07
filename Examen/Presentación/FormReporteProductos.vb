Imports Microsoft.Reporting.WinForms

Public Class FormReporteProductos
    Private Sub FormReporteProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Crear el control ReportViewer
        Dim reportViewer As New ReportViewer()
        reportViewer.Dock = DockStyle.Fill
        Me.Controls.Add(reportViewer)

        ' Configurar el ReportViewer
        reportViewer.LocalReport.ReportEmbeddedResource = "TuProyecto.ReporteProductos.rdlc" ' El nombre del archivo .rdlc
        reportViewer.LocalReport.DataSources.Clear()

        ' Obtener los datos de productos
        Dim datos As New ProductoDatos()
        Dim productosDataTable As DataTable = datos.ObtenerReporteProductos()

        ' Asignar el DataTable como origen de datos
        Dim reportDataSource As New ReportDataSource("ProductosDataSet", productosDataTable)
        reportViewer.LocalReport.DataSources.Add(reportDataSource)

        ' Refrescar el ReportViewer para mostrar los datos
        reportViewer.RefreshReport()
    End Sub

End Class
Public Class FormReporteVentas

    Private Sub FormReporteVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim datos As New VentaDatos()
        Dim ventasDataTable As DataTable = datos.ObtenerReporteVentas()


        ReportViewer1.LocalReport.ReportEmbeddedResource = "Examen.ReporteVentas.rdlc"
        ReportViewer1.LocalReport.DataSources.Clear()


        Dim reportDataSource As New Microsoft.Reporting.WinForms.ReportDataSource("VentasDataSet", ventasDataTable)
        ReportViewer1.LocalReport.DataSources.Add(reportDataSource)


        ReportViewer1.RefreshReport()
    End Sub


End Class
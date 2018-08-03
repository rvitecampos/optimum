Public Class ReportePrecios

    Private Sub ReportePrecios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DespensaDataSet.Reporte_Precios' Puede moverla o quitarla según sea necesario.
        Me.Reporte_PreciosTableAdapter.Fill(Me.DespensaDataSet.Reporte_Precios)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
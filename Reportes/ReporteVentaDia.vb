Public Class ReporteVentaDia

    Private Sub ReporteVentaDia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DespensaDataSet1.Reporte_VentaDia' Puede moverla o quitarla según sea necesario.
        
        Me.Reporte_VentaDiaTableAdapter.Fill(Me.DespensaDataSet1.Reporte_VentaDia)
        
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
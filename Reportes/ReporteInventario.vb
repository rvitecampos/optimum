Public Class ReporteInventario

    Private Sub ReporteInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DespensaDataSet.Reporte_Inventario' Puede moverla o quitarla según sea necesario.
        Me.Reporte_InventarioTableAdapter.Fill(Me.DespensaDataSet.Reporte_Inventario)
  
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
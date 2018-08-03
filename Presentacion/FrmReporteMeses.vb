Public Class FrmReporteMeses

    Private Sub btnGenerarReporte_Click(sender As Object, e As EventArgs) Handles btnGenerarReporte.Click
       
        ReporteMeses.Show()
        Me.Close()
    End Sub
End Class
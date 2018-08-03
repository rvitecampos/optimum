Public Class ReporteMeses

    Private Sub ReporteMeses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DespensaDataSet2.Reporte_Meses' Puede moverla o quitarla según sea necesario.

        Dim fecha1 As String
        fecha1 = FrmReporteMeses.DateTimePicker1.Text


        Me.Reporte_MesesTableAdapter.Fill(Me.DespensaDataSet2.Reporte_Meses, PrimerMes:=fecha1)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
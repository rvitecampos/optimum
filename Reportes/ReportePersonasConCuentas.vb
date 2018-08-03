Public Class ReportePersonasConCuentas

    Private Sub ReportePersonasConCuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DespensaDataSet.Mostrar_PersonasCuentas' Puede moverla o quitarla según sea necesario.
        Me.Mostrar_PersonasCuentasTableAdapter.Fill(Me.DespensaDataSet.Mostrar_PersonasCuentas)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
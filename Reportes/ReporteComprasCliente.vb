Public Class ReporteComprasCliente

    Private Sub ReporteComprasCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DespensaDataSet.mostrar_venta' Puede moverla o quitarla según sea necesario.
        Me.mostrar_ventaTableAdapter.Fill(Me.DespensaDataSet.mostrar_venta, Cod_venta:=FrmVenta.datalistadoVenta.SelectedCells.Item(1).Value)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
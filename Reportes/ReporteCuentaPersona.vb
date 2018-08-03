Public Class ReporteCuentaPersona

    Private Sub ReporteCuentaPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        Try
            Me.Mostrar_PagosTableAdapter.Fill(Me.DespensaDataSet.Mostrar_Pagos, Cood_cliente:=FrmCuentas.txtCod_cliente.Text)

            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            Me.ReportViewer1.RefreshReport()
        End Try


    End Sub
End Class
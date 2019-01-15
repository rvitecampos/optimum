Public Class ReporteServicios

    Private Property dt As DataTable

    Private Sub Reporte_Ingresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
 

        mostrar()

    End Sub


    Public Sub mostrar()
        Try
            Dim func As New fServicios
            dt = func.mostrar



            If dt.Rows.Count <> 0 Then

                cmbServicio.DataSource = dt
                cmbServicio.ValueMember = "Nombre_Servicio"
            Else
                cmbServicio.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim Servi As String
        Servi = cmbServicio.Text
        'TODO: This line of code loads data into the 'DespensaDataSet.mostrar_servicios' table. You can move, or remove it, as needed.
        Me.mostrar_serviciosTableAdapter.Fill(Me.DespensaDataSet.mostrar_servicios)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
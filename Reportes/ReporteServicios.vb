Public Class ReporteServicios
    Private Property dt As DataTable
    Public Sub mostrar()
        Try
            Dim func As New fServicios
            dt = func.mostrar2



            If dt.Rows.Count <> 0 Then

                cmbServicio.DataSource = dt
                cmbServicio.ValueMember = "Cod_servicio"
                cmbServicio.DisplayMember = "Nombre_Servicio"

            Else
                cmbServicio.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub



    Private Sub ReporteServicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DespensaDataSet.Servicio_Items' table. You can move, or remove it, as needed.
        mostrar()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim Servi As Integer
        Servi = cmbServicio.SelectedValue
        Me.Servicio_ItemsTableAdapter.Fill(Me.DespensaDataSet.Servicio_Items, Servi)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
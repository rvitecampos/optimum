Public Class Reporte_Ingresos
    Private dt As New DataTable
    Private Sub Reporte_Ingresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        mostrar()

      



    End Sub
    Private Sub mostrar()
        Try
            Dim func As New FCaja
            dt = func.mostrar


            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt

                datalistado.ColumnHeadersVisible = True

            Else
                datalistado.DataSource = Nothing

                datalistado.ColumnHeadersVisible = False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Close()
    End Sub

   
End Class
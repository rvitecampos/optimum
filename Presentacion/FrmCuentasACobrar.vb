Public Class FrmCuentasACobrar
    Private dt As New DataTable
    Private Sub FrmCuentasACobrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DespensaDataSet.Mostrar_Pagos' Puede moverla o quitarla según sea necesario.

        limpiar()
        'TODO: esta línea de código carga datos en la tabla 'DespensaDataSet.Mostrar_Pagos' Puede moverla o quitarla según sea necesario.
        'Me.Mostrar_PagosTableAdapter.Fill(Me.DespensaDataSet.Mostrar_Pagos, Cood_cliente:=txtCod_cliente.Text)

        'Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub mostrar()
        Dim func As New fDetalle_Venta
        Dim dts As New VDetalle_venta

        dts.gCood_Cliente = txtCod_cliente.Text

        dt = func.mostrar_vuelto(dts)


        If dt.Rows.Count <> 0 Then
            datalistado.DataSource = dt

            datalistado.ColumnHeadersVisible = True

        Else
            datalistado.DataSource = Nothing

            datalistado.ColumnHeadersVisible = False

        End If

    End Sub

    Private Sub BtnCobrar_Click(sender As Object, e As EventArgs) Handles BtnCobrar.Click



        Try
            If txtCod_cliente.Text <> "" Then

                Dim dts As New VDetalle_venta
                Dim fun As New fDetalle_Venta


                dts.gCood_Cliente = txtCod_cliente.Text
                dts.gPagando = TxtMontoACobrar.Text

                If fun.Actualizar_Pagando(dts) Then
                    mostrar()
                    Me.Mostrar_PagosTableAdapter.Fill(Me.DespensaDataSet.Mostrar_Pagos, Cood_cliente:=txtCod_cliente.Text)

                    Me.ReportViewer1.RefreshReport()
                End If

            Else
                MsgBox("Ingrese al Cliente Primero")
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub limpiar()

        TxtNombre.Text = ""
        txtCod_cliente.Text = ""
    End Sub

    Private Sub BtnBuscarCliente_Click(sender As Object, e As EventArgs) Handles BtnBuscarCliente.Click
        Cliente.txtflag.Text = "1"
        Cliente.ShowDialog()
        Me.Mostrar_PagosTableAdapter.Fill(Me.DespensaDataSet.Mostrar_Pagos, Cood_cliente:=txtCod_cliente.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FillToolStripButton_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub FillToolStripButton_Click_2(sender As Object, e As EventArgs)

    End Sub
End Class
Public Class StockMovimiento
    Private dt As New DataTable

    Private Sub StockLista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mostrar()

    End Sub
    Private Shared Function EmailValido(strEmail As String) As Boolean
        ' Retorna verdadero si strEmail es un formato de E-mail valido.
        Return System.Text.RegularExpressions.Regex.IsMatch(strEmail, "^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" & "(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$")
    End Function

    'FUNCION PARA PERMITIR SOLO NUMEROS DECIMALES
    Function Fg_SoloNumeros(ByVal Digito As String, ByVal Texto As String) As Boolean
        Dim Dt_Entero As Integer = CInt(Asc(Digito))
        If Dt_Entero = 8 Then
            Fg_SoloNumeros = False
        Else
            If InStr("1234567890", Digito) = 0 Then
                Fg_SoloNumeros = True
            ElseIf IsNumeric(Texto) = True Then
                Fg_SoloNumeros = False
            ElseIf IsNumeric(Texto) = False Then
                Fg_SoloNumeros = True
            End If
        End If
        Return Fg_SoloNumeros
    End Function
    '-----------------------------------------------------------

    Private Sub mostrar()
        Try

            Dim func As New fStockMovimiento
            Dim dts As New vStockMovimiento
            dts.gCood_Producto = txtCodProducto.Text

            dt = func.mostrar(dts)
            datalistadoStockMovimiento.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                datalistadoStockMovimiento.DataSource = dt
                Txtbuscar.Enabled = True
                datalistadoStockMovimiento.ColumnHeadersVisible = True
                inexistente.Visible = False
            Else
                datalistadoStockMovimiento.DataSource = Nothing
                Txtbuscar.Enabled = False
                datalistadoStockMovimiento.ColumnHeadersVisible = False
                inexistente.Visible = True
            End If


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
 

    End Sub



    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))


            dv.RowFilter = cbocampos.Text & " like '" & Txtbuscar.Text & "%'"
            If dv.Count <> 0 Then
                inexistente.Visible = False
                datalistadoStockMovimiento.DataSource = dv
                ' ocultar_columnas()
            Else
                inexistente.Visible = True
                datalistadoStockMovimiento.DataSource = Nothing
            End If

        Catch ex As Exception



        End Try
    End Sub




    Private Sub datalistadoStockLista_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistadoStockMovimiento.CellContentClick
        If e.ColumnIndex = Me.datalistadoStockMovimiento.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistadoStockMovimiento.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value

        End If
    End Sub







    Private Sub datalistadoStockLista_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistadoStockMovimiento.CellDoubleClick
        If txtflag.Text = "1" Then
            Productos.TxtCodProveedor.Text = datalistadoStockMovimiento.SelectedCells.Item(1).Value
            Productos.TxtProveedor.Text = datalistadoStockMovimiento.SelectedCells.Item(2).Value


            frmCompra.txtCod_Proveedor.Text = datalistadoStockMovimiento.SelectedCells.Item(1).Value
            frmCompra.TxtProveedor.Text = datalistadoStockMovimiento.SelectedCells.Item(2).Value

            Me.Close()


        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        buscar()
    End Sub


End Class
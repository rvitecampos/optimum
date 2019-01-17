Public Class FrmCuentas
    Dim dt As New DataTable
    Private Sub BtnBuscarCliente_Click(sender As Object, e As EventArgs) Handles BtnBuscarCliente.Click
        Cliente.txtflag.Text = "1"
        Cliente.ShowDialog()
        mostrar()
        If inexistente.Visible = False Then
            txtSobra.Text = datalistadoCuentas.SelectedCells.Item(11).Value
        End If

    End Sub
    Private Sub mostrar()

        Dim func As New FCobrar
        Dim dts As New VCobrar

        dts.gCood_cliente = txtCod_cliente.Text

        dt = func.mostrar(dts)
        datalistadoCuentas.Columns.Item("Eliminar").Visible = False

        If dt.Rows.Count <> 0 Then
            datalistadoCuentas.DataSource = dt

            datalistadoCuentas.ColumnHeadersVisible = True
            inexistente.Visible = False
        Else
            datalistadoCuentas.DataSource = Nothing

            datalistadoCuentas.ColumnHeadersVisible = False
            inexistente.Visible = True
        End If






    End Sub
    Sub limpiar()
        txtCod_cliente.Text = ""
        TxtMontoACobrar.Text = ""
        TxtNombre.Text = ""
        txtSobra.Text = "0,00"
        txtVuelto.Text = "0,00"
    End Sub
    'FUNCION PARA PERMITIR SOLO NUMEROS DECIMALES
    Function Fg_SoloNumeros(ByVal Digito As String, ByVal Texto As String) As Boolean
        Dim Dt_Entero As Integer = CInt(Asc(Digito))
        If Dt_Entero = 8 Then
            Fg_SoloNumeros = False
        Else
            If InStr("1234567890,", Digito) = 0 Then
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
    Public Sub TxtMontoACobrar_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TxtMontoACobrar.KeyPress
        eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, TxtMontoACobrar.Text & CChar(eventArgs.KeyChar))

    End Sub
    Public Sub BtnCobrar_Click(sender As Object, e As EventArgs) Handles BtnCobrar.Click
        Try
            FrmBloqueo.ShowDialog()
            If FrmBloqueo.txtPermiso.Text = "1" Then


                If inexistente.Visible = False Then

                    If txtCod_cliente.Text <> "" Then

                        Dim dts As New VDetalle_venta
                        Dim fun As New fDetalle_Venta
                        If Val(TxtMontoACobrar.Text) > Val(txtSobra.Text) Then
                            txtVuelto.Text = Val(TxtMontoACobrar.Text) - Val(txtSobra.Text)
                        Else
                            txtVuelto.Text = "0,00"
                        End If

                        dts.gCood_Cliente = txtCod_cliente.Text
                        '    dts.gPagando = TxtMontoACobrar.Text

                        If fun.Actualizar_Pagando(dts) Then

                            mostrar()
                            If inexistente.Visible = False Then
                                txtSobra.Text = datalistadoCuentas.SelectedCells.Item(11).Value
                            Else
                                txtSobra.Text = "0,00"
                            End If

                        End If

                    Else
                        MsgBox("Ingrese al Cliente Primero")
                    End If
                Else
                    MsgBox("NO POSEE CUENTAS")
                End If
            Else

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

 
  
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        limpiar()
        Me.Close()
    End Sub

End Class
Public Class FrmInicioCaja
    Private dt As New DataTable
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try

            Dim dt As New VCaja
            Dim func As New FCaja
            

            dt.ginicial = txtInicial.Text

            If func.insertar_caja(dt) = True Then
                MsgBox("Registrado correctamente")
            End If

            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
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

    Public Sub txtInicial_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtInicial.KeyPress
        eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, txtInicial.Text & CChar(eventArgs.KeyChar))
    End Sub


   
End Class
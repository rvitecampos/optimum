Public Class FrmBloqueo
    Sub limpiar()
        txtPassword.Text = ""
    End Sub
    Public Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Try

            Dim func As New FBloqueo
            Dim dts As New VBloqueo
            dts.gPassword = txtPassword.Text
            If func.validar_usuario(dts) Then
                MsgBox("CÓDIGO ACEPTADO", MsgBoxStyle.Information, "PUEDE INGRESAR")
                txtPermiso.Text = "1"
                limpiar()
                Me.Close()
            Else
                txtPermiso.Text = "0"
                limpiar()
                MsgBox("CÓDIGO ERRONEO", MsgBoxStyle.Critical, "NO PUEDE INGRESAR")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        txtPermiso.Text = "0"
        Me.Close()
    End Sub

    Private Sub FrmBloqueo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
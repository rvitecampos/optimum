Public Class credencialesCorreo
    Private Shared Function EmailValido(strEmail As String) As Boolean
        ' Retorna verdadero si strEmail es un formato de E-mail valido.
        Return System.Text.RegularExpressions.Regex.IsMatch(strEmail, "^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" & "(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$")
    End Function

    Private Sub TxtCorreo_LostFocus(sender As Object, e As EventArgs) Handles TxtCorreo.LostFocus
        If (EmailValido(TxtCorreo.Text) = False) Then
            MsgBox("Correo no válido")
        End If
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click

        If txtflag.Text = "1" Then
            'CredencialesCorreo
            FrmListFactura.txtEmisor.Text = txtCorreo.Text
            FrmListFactura.txtPassword.Text = txtPassword.Text
            Me.Close()
        End If

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        txtflag.Text = "0"
        Me.Close()
    End Sub
End Class
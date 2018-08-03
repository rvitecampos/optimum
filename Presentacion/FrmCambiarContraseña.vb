Public Class FrmCambiarContraseña

    Private Sub FrmCambiarContraseña_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Private Sub txtConfirmar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConfirmar.KeyPress

    '    If txtContraseña.Text = txtConfirmar.Text Then
    '        LCoinciden.Text = "LAS CONTRASEÑAS COINCIDEN"
    '    Else
    '        LCoinciden.Text = "LAS CONTRASEÑAS NO COINCIDEN"
    '    End If
    'End Sub
    Sub limpiar()
        txtActual.Text = ""
        txtLogin.Text = ""
        txtContraseña.Text = ""
        txtConfirmar.Text = ""
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If txtContraseña.Text = txtConfirmar.Text Then

            Dim func As New FCambiarContraseña
            Dim dts As New VCambiarContraseña
            dts.gLogin = txtLogin.Text
            dts.gPassword = txtActual.Text
            dts.gConfirmacion = txtConfirmar.Text

            If func.Cambiar_contraseña(dts) Then
                MsgBox("Contraseña cambiada correctamente", MsgBoxStyle.Information, "CAMBIADO")
                Me.Close()
            Else
                MsgBox("Algunos datos estan incorrectos", MsgBoxStyle.Critical, "ERROR")
            End If
        Else
            MsgBox("Las contraseñas deben coincidir", MsgBoxStyle.OkOnly, "INCORRECTO")
        End If
    End Sub
End Class
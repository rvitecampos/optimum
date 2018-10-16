Public Class frmLogin

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblHora.Text = TimeOfDay

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblHora.Text = TimeOfDay


    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Try
            Dim dts As New VUsuario
            Dim func As New fUsuario
            Dim dt As New VCaja
            Dim funcC As New FCaja
            'Dim fecha As String
            'Usuario
            dts.glogin = txtLogin.Text
            dts.gpassword = txtPassword.Text

            'Caja
            'fecha = DateString

            'dt.gfecha = DateString.ToString
            If func.validar_usuario(dts) = True Then
                frmPrincipal.txtLogin.Text = txtLogin.Text
                frmPrincipal.txtPassword.Text = txtPassword.Text
                frmPrincipal.Show()
                

                Me.Hide()
                If funcC.validar_caja(dt) = True Then

                Else
                    '  FrmInicioCaja.ShowDialog()
                End If

            Else
                MsgBox("Datos incorrectos", MsgBoxStyle.Critical, "Acceso Denegado")
                txtPassword.Clear()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End
    End Sub

    'Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
    '    Try
    '        Dim dts As New VUsuario
    '        Dim func As New fUsuario
    '        Dim dt As New VCaja
    '        Dim funcC As New FCaja



    '        dts.glogin = txtLogin.Text
    '        dts.gpassword = txtPassword.Text
    '        If func.usuario(dts) = True Then
    '            frmPrincipal.Show()
    '            Me.Hide()
    '            If funcC.validar_caja(dt) = True Then

    '            Else
    '                FrmInicioCaja.ShowDialog()
    '            End If
    '        Else
    '            MsgBox("Datos Incorrectos", MsgBoxStyle.Information)
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try






    'End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub
End Class
Public Class frmBackup

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim func As New FBackup

            If func.BackupBase Then
                MessageBox.Show("El BACKUP ha sido generado satisfactoriamente", "COPIA DE SEGURIDAD", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("El BACKUP no se ha generado", "COPIA DE SEGURIDAD", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
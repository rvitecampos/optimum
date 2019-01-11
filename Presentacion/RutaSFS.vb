Public Class RutaSFS
    Dim folder As New FolderBrowserDialog
    Dim ruta As String = String.Empty
    Private dt As New DataTable


    Private Sub RutaSFS_Load(sender As Object, e As EventArgs) Handles Me.Load
        mostrar()


    End Sub


    Private Sub mostrar()
        Try
            Dim func As New fRutaSFS
            dt = func.mostrar
            Dim row As DataRow = dt.Rows(dt.Rows.Count - 1)
            lblRuta.Text = row.Item("rutasfs")
            If Trim(lblRuta.Text) = "" Then
                lblRuta.Text = "No se ha ingresado Ruta"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    Private Sub btnRuta_Click(sender As Object, e As EventArgs) Handles btnRuta.Click

        If folder.ShowDialog = Windows.Forms.DialogResult.OK Then
            ruta = folder.SelectedPath
        End If
        If Trim(ruta) <> "" Then
            If Trim(ruta) <> Trim(lblRuta.Text) Then
                Dim cadena As String = Trim(ruta)
                Dim buscaSFS As String = "SFS"
                Dim buscaBarra As String = "\"
                Dim POS1 As Integer
                Dim POS2 As Integer
                POS1 = InStr(1, cadena, buscaSFS, CompareMethod.Text)


                If (POS1 > 0) Then
                    'If (cadena.Contains("SFS")) Then
                    POS2 = InStr(POS1, cadena, buscaBarra, CompareMethod.Text)
                    If (POS2 > 0) Then
                        MessageBox.Show("Ruta no modificado", "Carpeta no válida", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        Dim result As DialogResult
                        result = MessageBox.Show("Realmente desea cambiar la Ruta?", "Modificando ...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                        If result = DialogResult.OK Then

                            Try
                                Dim dts As New vRutaSFS
                                Dim func As New fRutaSFS
                                dts.grutasfs = Trim(ruta)

                                If func.editar(dts) Then
                                    MessageBox.Show("Ruta editada correctamente", "Modificado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Else
                                    MessageBox.Show("Ruta no modificado", "Ingrese de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End If
                            Catch ex As Exception
                                MsgBox(ex.Message)

                            End Try


                            mostrar()

                        End If
                    End If
                Else

                    MessageBox.Show("Ruta no modificado", "Carpeta SFS no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
                Else
                    MessageBox.Show("Ruta no modificado", "Ruta antigua y nueva son iguales", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Else
                MessageBox.Show("Ruta no modificado", "NO ESCOGIO FOLDER", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        '        MessageBox.Show(ruta)
    End Sub









End Class
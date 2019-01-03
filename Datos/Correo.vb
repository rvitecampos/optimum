
Imports System.Net
Imports System.Net.Mail

Module Correo

    Private correos As New MailMessage
    Private envios As New SmtpClient


    Sub enviarCorreo(ByVal emisor As String, ByVal password As String, ByVal mensaje As String, ByVal asunto As String, ByVal destinatario As String, ByVal ruta1 As String, ByVal ruta2 As String)
        Try
            correos.To.Clear()
            correos.Attachments.Clear()
            correos.Body = ""
            correos.Subject = ""
            correos.Body = mensaje
            correos.Subject = asunto
            correos.IsBodyHtml = True
            correos.To.Add(Trim(destinatario))
            correos.Priority = System.Net.Mail.MailPriority.Normal

            If ruta1 <> "" Then
                Dim archivo1 As Net.Mail.Attachment = New Net.Mail.Attachment(ruta1)
                correos.Attachments.Add(archivo1)
            End If

            If ruta2 <> "" Then
                Dim archivo2 As Net.Mail.Attachment = New Net.Mail.Attachment(ruta2)
                correos.Attachments.Add(archivo2)
            End If

            correos.From = New MailAddress(emisor)
            envios.Credentials = New NetworkCredential(emisor, password)

            'Datos importantes no modificables para tener acceso a las cuentas

            envios.Host = "smtp-mail.outlook.com"
            envios.Port = 587
            envios.EnableSsl = True

            envios.Send(correos)
            MsgBox("El mensaje fue enviado correctamente. ", MsgBoxStyle.Information, "Mensaje")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en Envio, Intente nuevamente...", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Module

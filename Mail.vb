Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Net
Imports System.Net.Mail

Public Module Mail

    Public Sub sendmail(ByVal to_address As String, ByVal title As String, ByVal body As String)
        Try
            Dim SmtpServer As New SmtpClient()
            Dim mail As New MailMessage()
            SmtpServer.Credentials = New Net.NetworkCredential("mailalerts.info@gmail.com", "qwerty!@#$%")
            SmtpServer.Port = 587
            SmtpServer.Host = "smtp.gmail.com"
            SmtpServer.EnableSsl = True
            mail = New MailMessage()
            mail.From = New MailAddress("mailalerts.info@gmail.com")
            mail.To.Add(to_address)
            mail.Subject = title
            mail.Body = body
            SmtpServer.Send(mail)
            MsgBox("Mail Send Successfully")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Module

Imports System.Net
Imports System.Net.Mail

Imports System.Data.SqlClient
Module ModDB
    Public con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Mally\Desktop\LibraryFinal\database\LMS_Data.MDF;Integrated Security=True;Connect Timeout=30;User Instance=True") 'Jet SQL:Database Password=a")
    Public cmd As New SQLCommand("", con)
    Public da As New SQLDataAdapter(cmd)
    Public dt As New DataTable

    Public Username As String = ""
    Public UserType As String = ""
    Public BranchCode As String = ""

    Structure students
        Dim MemberID As String
        Dim mobileno As String
        Dim isbnno As String
        Dim returndate As DateTime

    End Structure
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

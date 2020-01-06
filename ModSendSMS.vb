Imports System.Net
Module ModSendSMS
    Public smsusername As String = "deepamuthu" '"sridharsreesh" '"jaierode" '"meenachi"
    Public smspassword As String = "66158703" '"67332533" ' 
    Public mobileno As String = "" '9941272957"
    Public Sub SendSMS(ByVal typ As Short, ByRef mymessage As String, ByVal MemberID As String, ByRef mobileno As String)
        ' Dim webreq As HttpWebRequest = WebRequest.Create("http://75.125.154.74/messageapi.asp?username=" & smsusername & "&password=" & smspassword & "&sender=leno-sms&mobile=" & mobileno & "&message=" & mymessage)
        Try

            If con.State <> ConnectionState.Open Then con.Open()
            cmd.CommandText = "Select SMSMessage From SMSSettings Where SMSTypeId=" & typ
            Dim message As String = ""
            If cmd.ExecuteScalar Is DBNull.Value Then
            Else
                message = cmd.ExecuteScalar
            End If
            mymessage = message & "." & mymessage
            ''''   ModCreateSms.SendSMS("+91" & mobileno, mymessage)
            ''''  Dim webreq As HttpWebRequest = WebRequest.Create("http://india.timessms.com/http-api/receiverall.asp?username=" & smsusername & "&password=" & smspassword & "&sender=Demo&cdmasender=9566997571&to=" & mobileno & "&message=" & mymessage)



            'Send sms coding starts here
            'Dim webreq As HttpWebRequest = WebRequest.Create("http://india.timessms.com/http-api/receiverall.asp?username=" & smsusername & "&password=" & smspassword & "&sender=Demo&cdmasender=9952515706&to=" & mobileno & "&message=" & mymessage)
            'jai
            ' Dim webreq As HttpWebRequest = WebRequest.Create("http://india.timessms.com/http-api/receiverall.asp?username=" & smsusername & "&password=" & smspassword & "&sender=Demo&cdmasender=9750638655&to=" & mobileno & "&message=" & mymessage)
            'Dim webres As HttpWebResponse = webreq.GetResponse
            'Dim ms As System.IO.Stream = webres.GetResponseStream()

            'jai
            'Send sms coding ends here


            'MsgBox(ms.ToString)
            '  If con.State <> ConnectionState.Open Then con.Open()
            ' cmd.CommandText = "insert into SMSLog(SMSTime,Messagetype,MessageText) values ('" & Format(DateTime.Now, "dd/MM/yyyy hh:mm:ss tt") & "'," & typ & ",'" & mymessage & "')"
            'cmd.ExecuteNonQuery()
            'con.Close()

            'jai
            'cmd.CommandText = "Insert into SMSLog(EntryTime,MemberID,SMSType) Values('" & Format(DateTime.Now, "MM-dd-yyyy hh:mm tt") & "','" & MemberID & "'," & typ & ")"
            'cmd.ExecuteNonQuery()
            'jai

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Module

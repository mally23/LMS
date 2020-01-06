Imports AXMMCFGLib
Module ModCreateSms
    Sub SendSMS(ByVal strRecipient As String, ByVal strBody As String)
        Dim objMessageDB As XMessageDB = New XMessageDB()
        Dim objConstants As XConstants = New XConstants()
        Dim objMessage As IXMessage
        '  Dim strRecipient, strBody As String

        Console.WriteLine("API Module: {0}" & vbCrLf & "API Build: {1}" & vbCrLf, objMessageDB.Module, objMessageDB.Build)

        objMessageDB.Open()
        Console.WriteLine("Open, result: {0} ({1})", objMessageDB.LastError, objMessageDB.GetErrorDescription(objMessageDB.LastError))
        If (objMessageDB.LastError <> 0) Then
            Exit Sub
        End If

        Console.WriteLine("Enter recipient's mobile number (like: +4412345678): ")
        ' strRecipient = Console.ReadLine()

        Console.WriteLine("Enter body of the message: ")
        '  strBody = Console.ReadLine()

        objMessage = objMessageDB.Create()
        Console.WriteLine("Create, result: {0} ({1})", objMessageDB.LastError, objMessageDB.GetErrorDescription(objMessageDB.LastError))
        If (objMessageDB.LastError <> 0) Then
            Exit Sub
        End If

        Console.WriteLine("RecordID: {0}", objMessage.ID)

        objMessage.DirectionID = objConstants.MESSAGEDIRECTION_OUT
        objMessage.TypeID = objConstants.MESSAGETYPE_SMS
        objMessage.StatusID = objConstants.MESSAGESTATUS_PENDING
        objMessage.ChannelID = 0
        objMessage.ScheduledTime = ""
        objMessage.ToAddress = strRecipient
        objMessage.Body = strBody

        objMessageDB.Save(objMessage)
        Console.WriteLine("Save, result: {0} ({1})", objMessageDB.LastError, objMessageDB.GetErrorDescription(objMessageDB.LastError))
        If (objMessageDB.LastError = 0) Then
            PrintMessage(objMessage)
        End If

        objMessageDB.Close()
        Console.WriteLine("Closed.")
        MsgBox("SMS Sent.", MsgBoxStyle.Information)
        Console.WriteLine("Ready.")
    End Sub

    Sub PrintMessage(ByVal objMessage)
        Console.WriteLine("  ID               : " & objMessage.ID)
        Console.WriteLine("  DirectionID      : " & objMessage.DirectionID)
        Console.WriteLine("  TypeID           : " & objMessage.TypeID)
        Console.WriteLine("  StatusID         : " & objMessage.StatusID)
        Console.WriteLine("  StatusDetailsID  : " & objMessage.StatusDetailsID)
        Console.WriteLine("  ChannelID        : " & objMessage.ChannelID)
        Console.WriteLine("  MessageReference : " & objMessage.MessageReference)
        Console.WriteLine("  ScheduledTime    : " & objMessage.GetScheduledTimeString())
        Console.WriteLine("  LastUpdate       : " & objMessage.GetLastUpdateString())
        Console.WriteLine("  Sender           : " & objMessage.FromAddress)
        Console.WriteLine("  Recipient        : " & objMessage.ToAddress)
        Console.WriteLine("  Subject          : " & objMessage.Subject)
        Console.WriteLine("  BodyFormat       : " & objMessage.BodyFormatID)
        Console.WriteLine("  Body             : " & objMessage.Body)
        Console.WriteLine("  Trace            : " & objMessage.Trace)
    End Sub

End Module

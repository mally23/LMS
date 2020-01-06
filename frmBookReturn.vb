Imports System.Data.SQLClient

Public Class frmBookReturn


    Private Sub frmBooks_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If con.State <> ConnectionState.Closed Then con.Close()

    End Sub

    Private Sub frmBooks_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Return Then
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub frmBooks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If con.State <> ConnectionState.Open Then con.Open()
        Dim R As SQLDataReader
        cmd.CommandText = "Select BookId,MemberId From Issue Where Returned=" & 0
        R = cmd.ExecuteReader
        While R.Read
            If Not ComboBox1.Items.Contains(R(0) & ":" & R(1)) Then
                ComboBox1.Items.Add(R(0) & ":" & R(1))
            End If
        End While
        R.Close()
    End Sub
    Sub ClearControls()

        Dim x As Control
        For Each x In GroupBox1.Controls
            If TypeOf x Is TextBox Then
                x.Text = ""
            End If
        Next


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click


        Dim saved As Boolean = False
        Dim tran As SQLTransaction = Nothing
        Try
            tran = con.BeginTransaction
            cmd.Transaction = tran

            cmd.CommandText = "Update Issue Set Returned=" & 1 & ", ReturnDate='" & Format(dtp2.Value, "MM-dd-yyyy") & "',LateDays='" & Val(TextBox2.Text) & "',FineTotal='" & Val(TextBox3.Text) & "' Where MemberID='" & ComboBox2.Text & "' and BookId='" & ComboBox1.Text.Split(":")(0) & "' and REturned=0 and BranchCode='" & BranchCode & "'"
            If cmd.ExecuteNonQuery() > 0 Then
                'cmd.CommandText = "Update Books Set Available=Available+1 Where BookId='" & ComboBox1.Text & "'"
                'cmd.ExecuteNonQuery()
                cmd.CommandText = "Update BooksinBranches Set Quantity=Quantity+1 Where BookId='" & ComboBox1.Text.Split(":")(0) & "' and BranchCode='" & BranchCode & "'"
                cmd.ExecuteNonQuery()


                tran.Commit()
                MsgBox("Book Return Details Saved.", MsgBoxStyle.Information)
            Else
                MsgBox("Book Return Details Not Saved.", MsgBoxStyle.Information)
            End If
            saved = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            saved = False
            Try
                tran.Rollback()
            Catch ex2 As Exception

            End Try

        End Try


        If saved Then

            '===========================
            'Alert to Book Reserved Students 
            cmd.CommandText = "Select Quantity From BooksinBranches Where BookId='" & ComboBox1.Text.Split(":")(0) & "' and BranchCode='" & BranchCode & "'"
            If cmd.ExecuteScalar = 1 Then

                Dim MemberIDreserved As String

                cmd.CommandText = "Select MemberID From Reservation where smssent=" & 0 & " and BookId='" & ComboBox1.Text & "' and ReservationDate in (Select Min(ReservationDate) From Reservation Where BookId='" & ComboBox1.Text & "' and SMSSent =" & 0 & " and BranchCode='" & BranchCode & "')"

                If cmd.ExecuteScalar Is DBNull.Value Then
                ElseIf cmd.ExecuteScalar Is Nothing Then
                Else
                    MemberIDreserved = cmd.ExecuteScalar
                    cmd.CommandText = "Select mobile from Members where memberid='" & MemberIDreserved & "'"

                    ' Dim sr As New LibrarySMSStudents.Service
                    Dim mobileno As String = cmd.ExecuteScalar ' sr.GetMobileNumber(MemberIDreserved)
                    ModSendSMS.SendSMS(2, "Register No." & cmd.ExecuteScalar & ". Your Reservation For Book with ISBN No." & ComboBox1.Text & " is available.", MemberIDreserved, mobileno)
                    cmd.CommandText = "Select SNo From Reservation where smssent=" & 0 & " and BookId='" & ComboBox1.Text & "' and ReservationDate in (Select Min(ReservationDate) From Reservation Where BookId='" & ComboBox1.Text & "' and SMSSent =" & 0 & " and BranchCode='" & BranchCode & "')"
                    Dim sno As Integer
                    sno = cmd.ExecuteScalar
                    cmd.CommandText = "Update Reservation Set SMSSent=" & 1 & " Where SNo=" & sno
                    cmd.ExecuteNonQuery()
                    MsgBox("Book Reservation Alert Sent to Register No." & MemberIDreserved, MsgBoxStyle.Information)
                    NotifyIcon1.BalloonTipTitle = "Book Reservation Reminder"
                    NotifyIcon1.BalloonTipText = "SMS Sent to Register No." & MemberIDreserved & " to get book"
                    NotifyIcon1.ShowBalloonTip(5000)


                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        ClearControls()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim f As New frmViewRecords
        f.viewtype = 4
        f.Show()

        'Dim acode As String
        'acode = InputBox("Enter ISBN Number")
        'cmd.CommandText = "Delete from Books where BookId='" & acode & "'"
        'If cmd.ExecuteNonQuery > 0 Then
        '    MsgBox("Book Record deleted.", MsgBoxStyle.Information)
        '    ClearControls()
        'Else
        '    MsgBox("Book Record not deleted.", MsgBoxStyle.Information)
        'End If
    End Sub

    'Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
    '    Dim acode As String
    '    acode = InputBox("Enter ISBN Number")
    '    cmd.CommandText = "Select * from Books where BookId='" & acode & "'"

    '    Dim r As SQLDataReader = cmd.ExecuteReader

    '    If r.Read Then
    '        If IsDBNull(r(0)) Then
    '            T1.Text = ""
    '        Else
    '            T1.Text = r(0)
    '        End If
    '        If IsDBNull(r(1)) Then
    '            ComboBox1.Text = ""
    '        Else
    '            ComboBox1.Text = r(1)
    '        End If

    '        If IsDBNull(r(2)) Then
    '            T3.Text = ""
    '        Else
    '            T3.Text = r(2)
    '        End If
    '        If IsDBNull(r(3)) Then
    '            T4.Text = ""
    '        Else
    '            T4.Text = r(3)
    '        End If
    '        If IsDBNull(r(4)) Then
    '            T5.Text = ""
    '        Else
    '            T5.Text = r(4)
    '        End If
    '        If IsDBNull(r(5)) Then
    '            T6.Text = ""
    '        Else
    '            T6.Text = r(5)
    '        End If
    '    Else
    '        MsgBox("Book Record not found.", MsgBoxStyle.Information)
    '    End If
    '    r.Close()
    'End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub




    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If con.State <> ConnectionState.Open Then con.Open()
        cmd.CommandText = "select BookName From Books Where BookId='" & ComboBox1.Text.Split(":")(0) & "'" '  and BranchCode='" & BranchCode & "'"
        If cmd.ExecuteScalar Is DBNull.Value Then
            T3.Text = ""
        Else
            T3.Text = cmd.ExecuteScalar()
        End If
        cmd.CommandText = "Select MemberID From Issue Where BookId='" & ComboBox1.Text.Split(":")(0) & "' and Returned=" & 0 & " and BranchCode='" & BranchCode & "'"

        Dim r As SQLDataReader = cmd.ExecuteReader

        ComboBox2.Items.Clear()
        While r.Read
            ComboBox2.Items.Add(r(0))
        End While
        r.Close()

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp1.ValueChanged
        dtp2.Value = DateAdd(DateInterval.Day, 17, dtp1.Value)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim f As New frmViewRecords
        f.viewtype = 4
        f.Show()

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If con.State <> ConnectionState.Open Then con.Open()
        cmd.CommandText = "select MemberName from Members Where MemberID='" & ComboBox2.Text & "'"
        If cmd.ExecuteScalar Is DBNull.Value Then
            TextBox1.Text = ""
        Else
            TextBox1.Text = cmd.ExecuteScalar()
        End If


        cmd.CommandText = "Select IssueDate From Issue Where BookId='" & ComboBox1.Text.Split(":")(0) & "' and MemberID='" & ComboBox2.Text & "' and BranchCode='" & BranchCode & "'"
        If cmd.ExecuteScalar Is DBNull.Value Then
        ElseIf cmd.ExecuteScalar Is Nothing Then
        Else
            dtp1.Value = cmd.ExecuteScalar

        End If

    End Sub

    Private Sub dtp2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp2.ValueChanged
        Dim diff As Integer = DateDiff(DateInterval.Day, dtp1.Value, dtp2.Value) - 17
        If diff > 0 Then
            TextBox2.Text = diff
            TextBox3.Text = Format(Val(TextBox2.Text) * 0.5, "0.00")
        Else
            TextBox2.Text = "0"
            TextBox3.Text = "0.00"
        End If

    End Sub
End Class
Imports System.Data.SQLClient
Public Class frmMain
    Dim r As SQLDataReader

    Dim sl As New List(Of students)

    Private Sub ViewBooksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewBooksToolStripMenuItem.Click
        Dim f As New frmViewRecords
        f.Label1.Text = "BOOKS LIST"
        f.viewtype = 2
        f.Show()

    End Sub

    Private Sub ViewStudentsListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewStudentsListToolStripMenuItem.Click
        Dim f As New frmViewRecords
        f.Label1.Text = "MEMBERS LIST"
        f.viewtype = 3
        f.Show()

    End Sub

    Private Sub AddBookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBookToolStripMenuItem.Click
        Dim f As New frmBooks
        f.lblHeader.Text = "BOOK DETAILS"
        f.Show()

    End Sub

    'Private Sub DownloadStudentListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Dim s As New LibrarySMSStudents.Service
    '        Dim ds As DataSet = s.GetStudentsDetails()
    '        Dim cnt As Integer
    '        If con.State <> ConnectionState.Open Then con.Open()
    '        cmd.CommandText = "Delete from Members "
    '        cmd.ExecuteNonQuery()

    '        For Each dr As DataRow In ds.Tables(0).Rows
    '            cmd.CommandText = "Insert into Members values('" & dr(0) & "','" & dr(1) & "','" & dr(2) & "','" & dr(3) & "')"
    '            cnt += cmd.ExecuteNonQuery()
    '        Next
    '        MsgBox(cnt & " Students Records Downloaded.", MsgBoxStyle.Information)
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Information)
    '    End Try
    'End Sub

    Private Sub AddStudentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddStudentsToolStripMenuItem.Click
        Dim f As New frmMember
        f.lblHeader.Text = "MEMBERS DETAILS"
        f.Show()

    End Sub

    Private Sub BookIssueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New frmBookIssues
        f.lblHeader.Text = "BOOK ISSUE DETAILS"
        f.Show()

    End Sub

    Private Sub BookReturnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New frmBookReturn
        f.lblHeader.Text = "BOOK RETURN DETAILS"
        f.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Exit Sub
        If con.State <> ConnectionState.Open Then con.Open()


        'Alert to return book tomorrow
        cmd.CommandText = "Select * From Issue Where Returned =" & 0
        r = cmd.ExecuteReader
        Dim s As students
        'Dim sr As New LibrarySMSStudents.Service
        While r.Read
            s = New students
            s.MemberID = r("MemberID")
            s.isbnno = r("BookId")
            s.returndate = r("ReturnDate")
            's.mobileno = sr.GetMobileNumber(s.MemberID) '.Tables(0).Rows(0).Item(0)
            sl.Add(s)
        End While
        r.Close()

        For Each st As students In sl
            cmd.CommandText = "select mobile from Members where memberid='" & st.MemberID & "'"
            st.mobileno = cmd.ExecuteScalar
            If DateDiff(DateInterval.Day, DateTime.Today, st.returndate) = 1 Then
                ModSendSMS.SendSMS(1, "Register No." & st.MemberID & ". Your return date for Book with ISBN No." & st.isbnno & " is tomorrow.", st.MemberID, st.mobileno)
                NotifyIcon1.BalloonTipTitle = "Book Return Reminder"
                NotifyIcon1.BalloonTipText = "SMS Sent to Register No." & st.MemberID & " to return book"
                NotifyIcon1.ShowBalloonTip(5000)
            End If

        Next
        sl.Clear()

        '============
        'Alert to return book if not returned in given return date
        cmd.CommandText = "Select * From Issue Where Returned =" & 0
        r = cmd.ExecuteReader
        While r.Read
            If DateDiff(DateInterval.Day, r("ReturnDate"), DateTime.Today) > 0 Then
                s = New students
                s.MemberID = r("MemberID")
                s.isbnno = r("BookId")
                s.returndate = r("ReturnDate")
                's.mobileno = sr.GetMobileNumber(s.MemberID) '.Tables(0).Rows(0).Item(0)
                sl.Add(s)
            End If
        End While
        r.Close()

        For Each st As students In sl
            cmd.CommandText = "select mobile from Members where memberid='" & st.MemberID & "'"
            st.mobileno = cmd.ExecuteScalar
            If DateDiff(DateInterval.Day, st.returndate, DateTime.Today) > 0 Then

                Dim mobileno As String = st.mobileno
                ModSendSMS.SendSMS(3, "Register No." & st.MemberID & ". You have crossed the Due date limit for Book with ISBN No." & st.isbnno & ".", st.MemberID, mobileno)
                NotifyIcon1.BalloonTipTitle = "Book Return Reminder"
                NotifyIcon1.BalloonTipText = "SMS Sent to Register No." & st.MemberID & " to return book"
                NotifyIcon1.ShowBalloonTip(5000)

            End If

        Next

    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Try
        '    ModCreateSms.SendSMS("+919941272957", "Amman")
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical)
        'End Try


        Me.Visible = False
        Dim f As New frmLogin
        f.ShowDialog()
        If f.success = True Then
            Me.Visible = True
        Else
            End
        End If

        Timer1_Tick(Timer1, e)

        If UserType = "Admin" Then
            BranchToolStripMenuItem.Visible = True
            IssueToolStripMenuItem.Visible = False
            ReturnsToolStripMenuItem.Visible = False
            ReservationToolStripMenuItem.Visible = False
        Else
            BooksToolStripMenuItem.Text = "Books"
            ReportsToolStripMenuItem.Visible = False
            BranchToolStripMenuItem.Visible = False
            AddBookToolStripMenuItem.Visible = False
        End If

        If con.State <> ConnectionState.Open Then
            con.Open()
        End If

        cmd.CommandText = "Select EmailId From Issue LEFT JOIN Members On Members.MemberID = Issue.MemberID Where ReturnDate < '" & DateTime.Now & "' and Returned != 1 "

        Dim r As SqlDataReader = cmd.ExecuteReader
        While r.Read
            Mail.sendmail(r(0), "alert mail", " Your due date has been finished( date 20/03/2019 ")
        End While
        r.Close()

        con.Close()

    End Sub

    Private Sub BookReservationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New frmReservation
        f.lblHeader.Text = "BOOK RESERVATION DETAILS"
        f.Show()

    End Sub

    Private Sub ViewBookIssuesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New frmViewRecords

        f.viewtype = 4
        f.Show()

    End Sub

    Private Sub ViewBookReservationsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New frmViewRecords

        f.viewtype = 5
        f.Show()

    End Sub

    Private Sub ViewSMSLogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New frmViewRecords
        f.viewtype = 6
        f.Show()
    End Sub

    Private Sub AuthorsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New frmReports
        f.reporttype = 1
        f.Show()

    End Sub

    Private Sub BooksToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BooksToolStripMenuItem1.Click
        Dim f As New frmReports
        f.reporttype = 2
        f.Show()


    End Sub

    Private Sub StudentsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsToolStripMenuItem1.Click
        Dim f As New frmReports
        f.reporttype = 3
        f.Show()

    End Sub

    Private Sub BookIssuesReturnsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookIssuesReturnsToolStripMenuItem.Click
        Dim f As New frmReports
        f.reporttype = 4
        f.Show()
        


    End Sub

    Private Sub BookReservationsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookReservationsToolStripMenuItem.Click
        Dim f As New frmReports
        f.reporttype = 5
        f.Show()

    End Sub

    Private Sub SMSLogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New frmReports
        f.reporttype = 6
        f.Show()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub AboutProjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BranchProjectToolStripMenuItem.Click
        Dim f As New frmBranch
        f.Show()

        'MsgBox("Library SMS Management System Version 1.0.", MsgBoxStyle.Information)
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        Dim f As New frmChangePassword
        f.Show()

    End Sub

    Private Sub ViewBookIssuesToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewBookIssuesToolStripMenuItem.Click
        Dim f As New frmViewRecords
        f.viewtype = 4
        f.Show()

    End Sub

    Private Sub BookIssueToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookIssueToolStripMenuItem.Click

        Dim f As New frmBookIssues
        f.Show()

    End Sub

    Private Sub BookReturnToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookReturnToolStripMenuItem.Click
        Dim f As New frmBookReturn
        f.Show()

    End Sub

    Private Sub BookReservationToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookReservationToolStripMenuItem.Click
        Dim f As New frmReservation
        f.Show()

    End Sub

    Private Sub ViewBookReservationsToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewBookReservationsToolStripMenuItem.Click
        Dim f As New frmViewRecords
        f.viewtype = 5
        f.Show()

    End Sub

    Private Sub ViewSMSLogToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New frmViewRecords
        f.viewtype = 6
        f.Show()
    End Sub

    Private Sub BookRenewalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookRenewalToolStripMenuItem.Click
        Dim f As New frmBookRenewal
        f.Show()

    End Sub

    Private Sub IssueBooksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IssueBooksToolStripMenuItem.Click
        Dim f As New frmBookIssues
        f.Show()

    End Sub

    Private Sub ReturnBooksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturnBooksToolStripMenuItem.Click
        Dim f As New frmBookIssuesBranch
        f.Text = "Book Return From Branch Details"
        f.lblHeader.Text = "BOOK RETURN DETAILS"
        f.transtype = 2
        f.Show()
    End Sub

    Private Sub BooksCountInBranchesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BooksCountInBranchesToolStripMenuItem.Click
        Dim f As New frmViewRecords
        f.viewtype = 101
        f.Show()

    End Sub

    Private Sub BranchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BranchToolStripMenuItem.Click

    End Sub

    Private Sub BooksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BooksToolStripMenuItem.Click

    End Sub

    Private Sub StudentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsToolStripMenuItem.Click

    End Sub

    Private Sub IssueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IssueToolStripMenuItem.Click

    End Sub
End Class
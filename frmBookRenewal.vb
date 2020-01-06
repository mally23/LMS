Imports System.Data.SQLClient

Public Class frmBookRenewal


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

            cmd.CommandText = "Update Issue Set Returned=" & 1 & ", ReturnDate='" & Format(dtp2.Value, "MM-dd-yyyy") & "',LateDays='" & Val(TextBox2.Text) & "',FineTotal='" & Val(TextBox3.Text) & "' Where MemberID='" & ComboBox2.Text & "' and BookId='" & ComboBox1.Text.Split(":")(0) & "' and REturned=0"
            If cmd.ExecuteNonQuery() > 0 Then
                cmd.CommandText = "Update BooksinBranches Set Quantity=Quantity+1 Where BookId='" & ComboBox1.Text.Split(":")(0) & "' and BranchCode='" & BranchCode & "'"
                cmd.ExecuteNonQuery()


                cmd.CommandText = "Insert into Issue (MemberID,BookId,IssueDate,ReturnDate,Returned,LateDays,FineTotal,BranchCode) values('" & ComboBox2.Text & "','" & ComboBox1.Text.Split(":")(0) & "','" & Format(dtp2.Value, "MM-dd-yyyy") & "','" & Format(DateAdd(DateInterval.Day, 17, dtp2.Value), "MM-dd-yyyy") & "'," & 0 & ",0,0,'" & BranchCode & "')"
                cmd.ExecuteNonQuery()

                'cmd.CommandText = "Update Books Set Available=Available-1 Where BookId='" & ComboBox1.Text.Split(":")(0) & "'"
                'cmd.ExecuteNonQuery()
                cmd.CommandText = "Update BooksinBranches Set Quantity=Quantity-1 Where BookId='" & ComboBox1.Text.Split(":")(0) & "' and BranchCode='" & BranchCode & "'"
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
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        ClearControls()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim f As New frmViewRecords
        f.viewtype = 4
        f.Show()
    End Sub

    

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub




    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If con.State <> ConnectionState.Open Then con.Open()
        cmd.CommandText = "select BookName From Books Where BookId='" & ComboBox1.Text.Split(":")(0) & "'"
        If cmd.ExecuteScalar Is DBNull.Value Then
            T3.Text = ""
        Else
            T3.Text = cmd.ExecuteScalar()
        End If
        cmd.CommandText = "Select MemberID From Issue Where BookId='" & ComboBox1.Text.Split(":")(0) & "' and Returned=" & 0 & " and MemberId='" & ComboBox1.Text.Split(":")(1) & "' and BranchCode='" & BranchCode & "'"

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


        cmd.CommandText = "Select IssueDate From Issue Where BookId='" & ComboBox1.Text.Split(":")(0) & "' and MemberID='" & ComboBox2.Text & "'"
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
Imports System.Data.SQLClient

Public Class frmBookIssuesBranch

    Public transtype As Integer = 1 ' 1 for issue 2 for return

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
        Dim R As SqlDataReader
        cmd.CommandText = "Select BookId From Books" ' Where Available>0"

        R = cmd.ExecuteReader
        While R.Read
            ComboBox1.Items.Add(R(0))
        End While
        R.Close()
        cmd.CommandText = "Select BranchCode from Branches"

        R = cmd.ExecuteReader
        While R.Read
            ComboBox2.Items.Add(R(0))
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
        '  dtp1.Value = DateTime.Today
        '        dtp2.Value = DateAdd(DateInterval.Day, 14, DateTime.Today)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim saved As Boolean = False
        Dim tran As SqlTransaction = Nothing
        Try
            tran = con.BeginTransaction
            cmd.Transaction = tran
            'cmd.CommandText = "Delete from Books where BookId='" & T1.Text & "'"
            'cmd.ExecuteNonQuery()

            If transtype = 2 Then
                cmd.CommandText = "SELECT Quantity from BooksinBranches where BranchCode='" & ComboBox2.Text & "' and BookId='" & ComboBox1.Text & "'"
                If cmd.ExecuteScalar Is Nothing Then
                    MsgBox("Book Not Available", MsgBoxStyle.Information)
                    Exit Sub
                ElseIf cmd.ExecuteScalar Is DBNull.Value Then
                    MsgBox("Book Not Available", MsgBoxStyle.Information)
                    Exit Sub
                Else
                    If Val(TextBox2.Text) < cmd.ExecuteScalar Then
                    Else
                        MsgBox("Only " & cmd.ExecuteScalar & " Books Available", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                End If
            End If

            cmd.CommandText = "SELECT Count(*) from BooksinBranches where BranchCode='" & ComboBox2.Text & "' and BookId='" & ComboBox1.Text & "'"
            If cmd.ExecuteScalar > 0 Then
                If transtype = 1 Then
                    cmd.CommandText = "Update BooksinBranches  Set Quantity=Quantity+" & Val(TextBox2.Text) & " where BranchCode='" & ComboBox2.Text & "' and BookId='" & ComboBox1.Text & "'"
                Else
                    cmd.CommandText = "Update BooksinBranches  Set Quantity=Quantity-" & Val(TextBox2.Text) & " where BranchCode='" & ComboBox2.Text & "' and BookId='" & ComboBox1.Text & "'"
                End If
                cmd.ExecuteNonQuery()
            Else

                cmd.CommandText = "Insert  into BooksinBranches (BranchCode,BookId,Quantity) values('" & ComboBox2.Text & "','" & ComboBox1.Text & "'," & TextBox2.Text & ")"
                cmd.ExecuteNonQuery()
            End If
            '  cmd.CommandText = "Update Books Set Available=Available-1 Where BookId='" & ComboBox1.Text & "'"
            '  cmd.ExecuteNonQuery()

            tran.Commit()
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
                If transtype = 1 Then
                    MsgBox("Book Issue Record saved.", MsgBoxStyle.Information)
                Else
                    MsgBox("Book Return Record saved.", MsgBoxStyle.Information)

                End If
            Else

                If transtype = 1 Then
                    MsgBox("Book Issue Record not saved.", MsgBoxStyle.Information)
                Else
                    MsgBox("Book Return Record not saved.", MsgBoxStyle.Information)

                End If
            End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        ClearControls()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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


    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If con.State <> ConnectionState.Open Then con.Open()
        cmd.CommandText = "select BranchName from Branches Where BranchCode='" & ComboBox2.Text & "'"
        If cmd.ExecuteScalar Is DBNull.Value Then
            TextBox1.Text = ""
        Else
            TextBox1.Text = cmd.ExecuteScalar()
        End If

        If transtype = 2 Then
            cmd.CommandText = "SELECT Quantity from BooksinBranches where BranchCode='" & ComboBox2.Text & "' and BookId='" & ComboBox1.Text & "'"
            If cmd.ExecuteScalar Is Nothing Then
                MsgBox("Book Not Available", MsgBoxStyle.Information)
            ElseIf cmd.ExecuteScalar Is DBNull.Value Then
                MsgBox("Book Not Available", MsgBoxStyle.Information)
            Else
                If Val(TextBox2.Text) < cmd.ExecuteScalar Then
                Else
                    MsgBox("Only " & cmd.ExecuteScalar & " Books Available", MsgBoxStyle.Information)
                End If
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If con.State <> ConnectionState.Open Then con.Open()
        cmd.CommandText = "select BookName From Books Where BookId='" & ComboBox1.Text & "'"
        If cmd.ExecuteScalar Is DBNull.Value Then
            T3.Text = ""
        Else
            T3.Text = cmd.ExecuteScalar()
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'dtp2.Value = DateAdd(DateInterval.Day, 14, dtp1.Value)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Dim f As New frmViewRecords
        ' f.viewtype = 4
        ' f.Show()

    End Sub
End Class
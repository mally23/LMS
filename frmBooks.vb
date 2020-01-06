Imports System.Data.SQLClient

Public Class frmBooks


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
    End Sub
    Sub ClearControls()

        Dim x As Control
        For Each x In GroupBox1.Controls
            If TypeOf x Is TextBox Then
                x.Text = ""
            End If
        Next

        T1.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim saved As Boolean = False
        cmd.CommandText = "Select Count(*) From Books where BookId='" & T1.Text & "'"
        If cmd.ExecuteScalar > 0 Then
            If MsgBox("ISBN Number already found. Do you want to overwrite?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                Dim tran As SQLTransaction = Nothing
                Try
                    tran = con.BeginTransaction
                    cmd.Transaction = tran
                    cmd.CommandText = "Delete from Books where BookId='" & T1.Text & "'"
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = "Insert  into Books values('" & T1.Text & "','" & TextBox1.Text & "','" & T3.Text & "','" & T4.Text & "','" & ComboBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')"
                    cmd.ExecuteNonQuery()
                    tran.Commit()
                    saved = True

                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                    saved = False
                    tran.Rollback()
                End Try
            End If
        Else

            cmd.CommandText = "Insert  into Books values('" & T1.Text & "','" & TextBox1.Text & "','" & T3.Text & "','" & T4.Text & "','" & ComboBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')"
            cmd.ExecuteNonQuery()
            saved = True

        End If
        If saved Then
            MsgBox("Book Record saved.", MsgBoxStyle.Information)
        Else
            MsgBox("Book Record not saved.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        ClearControls()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim acode As String
        acode = InputBox("Enter ISBN Number")
        cmd.CommandText = "Delete from Books where BookId='" & acode & "'"
        If cmd.ExecuteNonQuery > 0 Then
            MsgBox("Book Record deleted.", MsgBoxStyle.Information)
            ClearControls()
        Else
            MsgBox("Book Record not deleted.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim acode As String
        acode = InputBox("Enter Bar Code Number")
        cmd.CommandText = "Select * from Books where BookId='" & acode & "'"

        Dim r As SQLDataReader = cmd.ExecuteReader

        If r.Read Then
            If IsDBNull(r(0)) Then
                T1.Text = ""
            Else
                T1.Text = r(0)
            End If
            If IsDBNull(r(1)) Then
                TextBox1.Text = ""
            Else
                TextBox1.Text = r(1)
            End If

            If IsDBNull(r(2)) Then
                T3.Text = ""
            Else
                T3.Text = r(2)
            End If
            If IsDBNull(r(3)) Then
                T4.Text = ""
            Else
                T4.Text = r(3)
            End If
            'If IsDBNull(r(4)) Then
            '    T5.Text = ""
            'Else
            '    T5.Text = r(4)
            'End If
            'If IsDBNull(r(5)) Then
            '    T6.Text = ""
            'Else
            '    T6.Text = r(5)
            'End If
            If IsDBNull(r(4)) Then
                ComboBox1.Text = ""
            Else
                ComboBox1.Text = r(4)
            End If

        Else
            MsgBox("Book Record not found.", MsgBoxStyle.Information)
        End If
        r.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub T5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T5.TextChanged
        T6.Text = T5.Text


    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Dim da As New SqlDataAdapter(cmd)
    Dim dt As New DataTable
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        dt.Rows.Clear()
        cmd.CommandText = "select * From Books Where ISBNNo Like '%" & TextBox5.Text & "%' or BookName Like '%" & TextBox5.Text & "%' or Publications Like '%" & TextBox5.Text & "%' or Category Like '%" & TextBox5.Text & "%'"
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
End Class
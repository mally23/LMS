Imports System.Data.OleDb

Public Class frmAuthor


    Private Sub frmAuthor_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If con.State <> ConnectionState.Closed Then con.Close()

    End Sub

    Private Sub frmAuthor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Return Then
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub frmAuthor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If con.State <> ConnectionState.Open Then con.Open()
    End Sub
    Sub ClearControls()

        Dim x As Control
        For Each x In GroupBox1.Controls
            If TypeOf x Is TextBox Then
                x.Text = ""
            End If
        Next

        txtAuthorCode.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim saved As Boolean = False
        cmd.CommandText = "Select Count(*) From Authors where AuthorId='" & txtAuthorCode.Text & "'"
        If cmd.ExecuteScalar > 0 Then
            If MsgBox("Author ID already found. Do you want to overwrite?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                Dim tran As OleDbTransaction = Nothing
                Try
                    tran = con.BeginTransaction
                    cmd.Transaction = tran
                    cmd.CommandText = "Delete from Authors where AuthorId='" & txtAuthorCode.Text & "'"
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = "Insert  into Authors values('" & txtAuthorCode.Text & "','" & txtAuthorName.Text & "','" & txtMailID.Text & "')"
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
            cmd.CommandText = "Insert  into Authors values('" & txtAuthorCode.Text & "','" & txtAuthorName.Text & "','" & txtMailID.Text & "')"
            cmd.ExecuteNonQuery()
            saved = True
        End If

        If saved Then
            MsgBox("Author Record saved.", MsgBoxStyle.Information)
        Else
            MsgBox("Author Record not saved.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        ClearControls()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim acode As String
        acode = InputBox("Enter Author Id")
        cmd.CommandText = "Delete from Authors where AuthorId='" & acode & "'"
        If cmd.ExecuteNonQuery > 0 Then
            MsgBox("Author Record deleted.", MsgBoxStyle.Information)
            ClearControls()
        Else
            MsgBox("Author Record not deleted.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim acode As String
        acode = InputBox("Enter customercode")
        cmd.CommandText = "Select * from Authors where AuthorId='" & acode & "'"

        Dim r As OleDbDataReader = cmd.ExecuteReader

        If r.Read Then
            If IsDBNull(r(0)) Then
                txtAuthorCode.Text = ""
            Else
                txtAuthorCode.Text = r(0)
            End If
            If IsDBNull(r(1)) Then
                txtAuthorName.Text = ""
            Else
                txtAuthorName.Text = r(1)
            End If

            If IsDBNull(r(2)) Then
                txtMailID.Text = ""
            Else
                txtMailID.Text = r(2)
            End If
        Else
            MsgBox("Author Record not found.", MsgBoxStyle.Information)
        End If
        r.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class
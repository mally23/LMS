Imports System.Data.SQLClient

Public Class frmMember


    Private Sub frmStudents_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If con.State <> ConnectionState.Closed Then con.Close()

    End Sub

    Private Sub frmStudents_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Return Then
            SendKeys.Send("{tab}")
        End If
    End Sub


    Private Sub _Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If con.State <> ConnectionState.Open Then con.Open()
        'Dim R As SQLDataReader
        'cmd.CommandText = "Select AuthorId From Authors"

        'R = cmd.ExecuteReader
        'While R.Read
        '    ComboBox1.Items.Add(R(0))
        'End While
        'R.Close()

    End Sub
    Sub ClearControls()

        Dim x As Control
        For Each x In GroupBox1.Controls
            If TypeOf x Is TextBox Then
                x.Text = ""
            End If
        Next
        cmd.CommandText = "Select Count(MemberId) From Members"
        Dim acode As Integer
        If cmd.ExecuteScalar Is DBNull.Value Then
            acode = 1
        Else
            acode = cmd.ExecuteScalar + 1
        End If
        T1.Text = "EL" & Format(acode, "000")

        'T1.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim saved As Boolean = False

        Dim img As Image = PictureBox1.Image ' Image.FromFile(TextBox5.Text)

        Dim fpath As String
        img.Save(Application.StartupPath & "\..\..\Memberimages\" & TextBox1.Text & ".jpg")
        fpath = T1.Text & ".jpg"

        cmd.CommandText = "Select Count(*) From Members where MemberID='" & T1.Text & "'"
        If cmd.ExecuteScalar > 0 Then
            If MsgBox("Register No. already found. Do you want to overwrite?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                Dim tran As SQLTransaction = Nothing
                Try
                    tran = con.BeginTransaction
                    cmd.Transaction = tran
                    cmd.CommandText = "Delete from Members where MemberID='" & T1.Text & "'"
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = "Insert  into Members values('" & T1.Text & "','" & TextBox1.Text & "','" & T3.Text & "','" & T4.Text & "','" & Format(DateTimePicker1.Value, "MM/dd/yyyy") & "','" & TextBox2.Text & "','" & Format(DateTimePicker2.Value, "MM/dd/yyyy") & "'," & Val(TextBox3.Text) & ",'" & ComboBox2.Text & "'," & Val(TextBox4.Text) & ",'" & fpath & "')"
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

            cmd.CommandText = "Insert  into Members values('" & T1.Text & "','" & TextBox1.Text & "','" & T3.Text & "','" & T4.Text & "','" & Format(DateTimePicker1.Value, "MM/dd/yyyy") & "','" & TextBox2.Text & "','" & Format(DateTimePicker2.Value, "MM/dd/yyyy") & "'," & Val(TextBox3.Text) & ",'" & ComboBox2.Text & "'," & Val(TextBox4.Text) & ",'" & fpath & "')"
            cmd.ExecuteNonQuery()
            saved = True

        End If
        If saved Then
            MsgBox("Record saved.", MsgBoxStyle.Information)
        Else
            MsgBox("Record not saved.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        ClearControls()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim acode As String
        acode = InputBox("Enter Members No.")
        cmd.CommandText = "Delete from Members where MemberID='" & acode & "'"
        If cmd.ExecuteNonQuery > 0 Then
            MsgBox("Record deleted.", MsgBoxStyle.Information)
            ClearControls()
        Else
            MsgBox("Record not deleted.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim acode As String
        acode = InputBox("Enter Members No.")
        cmd.CommandText = "Select * from Members where MemberID='" & acode & "'"

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
            If IsDBNull(r(4)) Then

            Else
                DateTimePicker1.Value = r(4)
            End If
            If IsDBNull(r(5)) Then
                TextBox2.Text = ""
            Else
                TextBox2.Text = r(5)
            End If
            If IsDBNull(r(6)) Then
                DateTimePicker2.Value = DateTime.Today
            Else
                DateTimePicker2.Text = r(6)
            End If

            If IsDBNull(r(7)) Then
                TextBox3.Text = ""
            Else
                TextBox3.Text = r(7)
            End If
            If IsDBNull(r(8)) Then
                ComboBox2.Text = ""
            Else
                ComboBox2.Text = r(8)
            End If
            If IsDBNull(r(9)) Then
                TextBox4.Text = ""
            Else
                TextBox4.Text = r(9)
            End If
        Else
            MsgBox("Record not found.", MsgBoxStyle.Information)
        End If
        r.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "Yes" Then
            TextBox4.Enabled = True
        Else
            TextBox4.Enabled = False

        End If
    End Sub

   
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim f As New frmMember
        f.lblHeader.Text = "MEMBERS DETAILS"
        f.Show()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox5.Text = OpenFileDialog1.FileName
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)

        End If
    End Sub
End Class
Imports System.Data.SQLClient

Public Class frmReservation


    Private Sub frmBookReservation_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If con.State <> ConnectionState.Closed Then con.Close()

    End Sub

    Private Sub frmBookReservation_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Return Then
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub frmBookReservation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If con.State <> ConnectionState.Open Then con.Open()
        Dim R As SQLDataReader
        cmd.CommandText = "Select BookId From BooksinBranches Where BranchCode='" & BranchCode & "' and Quantity=0"

        R = cmd.ExecuteReader
        While R.Read
            ComboBox1.Items.Add(R(0))
        End While
        R.Close()

        cmd.CommandText = "Select MemberID from Members Where MemberID Not in (Select MemberID From Issue Where Returned=" & 0 & ")"

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
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim saved As Boolean = False
        Dim tran As SqlTransaction = Nothing
        Try
            tran = con.BeginTransaction
            cmd.Transaction = tran
            'cmd.CommandText = "Delete from Books where BookId='" & T1.Text & "'"
            'cmd.ExecuteNonQuery()

            cmd.CommandText = "Insert  into Reservation (MemberID,BookId,ReservationDate,SMSSent) values('" & ComboBox2.Text & "','" & ComboBox1.Text & "','" & Format(dtp1.Value, "MM-dd-yyyy") & "'," & 0 & ")"
            cmd.ExecuteNonQuery()
            tran.Commit()
            saved = True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            saved = False
            tran.Rollback()
        End Try

        If saved Then
            MsgBox("Book Reservation Record saved.", MsgBoxStyle.Information)
        Else
            MsgBox("Book Reservation Record not saved.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        ClearControls()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim f As New frmViewRecords
        f.viewtype = 5
        f.Show()


    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub


    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If con.State <> ConnectionState.Open Then con.Open()
        cmd.CommandText = "select MemberName from Members Where MemberID='" & ComboBox2.Text & "'"
        If cmd.ExecuteScalar Is DBNull.Value Then
            TextBox1.Text = ""
        Else
            TextBox1.Text = cmd.ExecuteScalar()
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



    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim f As New frmViewRecords
        f.viewtype = 5
        f.Show()

    End Sub
End Class
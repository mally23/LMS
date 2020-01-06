Imports System.Data.SQLClient
Imports System.Data
Public Class frmChangePassword
   
    Public success As Boolean
    Sub ClearControls()
        Dim X As Control
        For Each X In GroupBox1.Controls
            If TypeOf X Is TextBox Then
                X.Text = ""
            ElseIf TypeOf X Is ComboBox Then
                CType(X, ComboBox).SelectedIndex = 0
            ElseIf TypeOf X Is DateTimePicker Then
                CType(X, DateTimePicker).Value = DateTime.Today
            End If
        Next
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtUser.Text.Trim = "" Then
            MsgBox("Old Password is empty.", MsgBoxStyle.Critical)
            txtUser.Focus()
            Exit Sub
        End If


        If txtPass.Text.Trim = "" Then
            MsgBox("New Password is empty.", MsgBoxStyle.Critical)
            txtPass.Focus()
            Exit Sub
        End If


        Try

            If con.State <> ConnectionState.Open Then con.Open()

            cmd.CommandText = "Select Count(*) From Admin Where [Password]='" & txtUser.Text.Trim.Replace("'", "''") & "' and UserName='" & ModDB.username & "'"

            If cmd.ExecuteScalar = 0 Then
                MsgBox("Invalid Old Password.", MsgBoxStyle.Information)
                txtUser.Focus()

            Else
                cmd.CommandText = "Update Admin Set [Password]='" & txtPass.Text.Replace("'", "") & "' Where UserName='" & ModDB.username & "'"
                If cmd.ExecuteNonQuery > 0 Then
                    MsgBox("Password Updated.", MsgBoxStyle.Information)

                Else
                    MsgBox("Error in updating password. Retry", MsgBoxStyle.Exclamation)
                End If
                Me.Close()
            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical)

        Finally


            If con.State <> ConnectionState.Closed Then con.Close()

        End Try

    End Sub

    Private Sub frmChangePassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = 13 Then
            SendKeys.Send("{tab}")
        End If
    End Sub





    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub frmChangePassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class

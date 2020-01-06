Imports System.Data.SQLClient
Imports System.Data
Public Class frmLogin
   
    Public success As Boolean
    
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtUser.Text.Trim = "" Then
            MsgBox("Please Enter UserName.", MsgBoxStyle.Information)
            txtUser.Focus()
            Exit Sub
        End If


        If txtPass.Text.Trim = "" Then
            MsgBox("Please Enter Password.", MsgBoxStyle.Information)
            txtPass.Focus()
            Exit Sub
        End If



        Try

            If con.State <> ConnectionState.Open Then con.Open()

            '    If ComboBox1.Text = "Admin" Then


            cmd.CommandText = "Select Count(*) From Admin Where UserName='" & txtUser.Text.Trim.Replace("'", "''") & "' and [Password]='" & txtPass.Text.Trim.Replace("'", "''") & "'"
            If cmd.ExecuteScalar = 0 Then
                MsgBox("Invalid UserName/Password.", MsgBoxStyle.Critical)
                txtUser.Focus()

            Else
                ModDB.Username = txtUser.Text
                UserType = "Admin"
                success = True
                Me.Close()

            End If
            ' ElseIf ComboBox1.Text = "User" Then
            'cmd.CommandText = "Select Count(*) From Branches Where BranchCode='" & txtUser.Text.Trim.Replace("'", "''") & "' and [Password]='" & txtPass.Text.Trim.Replace("'", "''") & "'"
            'If cmd.ExecuteScalar = 0 Then
            '    MsgBox("Invalid Username/Password.", MsgBoxStyle.Critical)
            '    txtUser.Focus()

            'Else

            '    BranchCode = txtUser.Text

            '    ModDB.Username = txtUser.Text
            '    UserType = ComboBox1.Text()
            '    success = True
            '    Me.Close()


            'End If
            'End If


        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical)

        Finally


            If con.State <> ConnectionState.Closed Then con.Close()

        End Try

    End Sub

    Private Sub frmLocation_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Me.WindowState = FormWindowState.Maximized

        If Asc(e.KeyChar) = 13 Then
            SendKeys.Send("{tab}")
        End If
    End Sub





    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class

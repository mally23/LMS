Imports System.Data.sqlClient

Public Class frmBranch

    Private Sub frmLocation_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If con.State <> ConnectionState.Closed Then con.Close()
    End Sub

    Private Sub frmLocation_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Return Then
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub frmLocation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If con.State <> ConnectionState.Open Then con.Open()
        '    Me.Text = Company_Name & "-" & Me.Text
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click

        ClearControls()
        txtBranchName.Focus()

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        Dim saved As Boolean = False
        cmd.CommandText = "Select Count(*) From Branches where BranchCode='" & txtBranchCode.Text & "'"
        If cmd.ExecuteScalar > 0 Then
            If MsgBox("Branch Code already found. Do you want to overwrite?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                Dim tran As SqlTransaction = Nothing
                Try
                    tran = con.BeginTransaction
                    cmd.Transaction = tran
                    cmd.CommandText = "Delete from Branches where BranchCode='" & txtBranchCode.Text & "'"
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = "Insert  into Branches values('" & txtBranchCode.Text & "','" & txtBranchName.Text & "','" & txtAddress.Text & "','" & txtCity.Text & "','" & txtPhone.Text & "','" & TextBox1.Text & "')"
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
            cmd.CommandText = "Insert  into Branches values('" & txtBranchCode.Text & "','" & txtBranchName.Text & "','" & txtAddress.Text & "','" & txtCity.Text & "','" & txtPhone.Text & "','" & TextBox1.Text & "')"
            cmd.ExecuteNonQuery()
            saved = True
        End If

        If saved Then
            MsgBox("Branch Record inserted.", MsgBoxStyle.Information)
        Else
            MsgBox("Branch Record not inserted.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim acode As String
        acode = InputBox("Enter BranchCode")
        cmd.CommandText = "Delete from Branches where BranchCode='" & acode & "'"
        If cmd.ExecuteNonQuery > 0 Then
            MsgBox("Branch Record deleted.", MsgBoxStyle.Information)
            ClearControls()
        Else
            MsgBox("Branch Record not deleted.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        Dim acode As String
        acode = InputBox("Enter Branch Code")
        cmd.CommandText = "Select * from Branches where BranchCode='" & acode & "'"

        Dim r As SqlDataReader = cmd.ExecuteReader

        If r.Read Then
            If IsDBNull(r(0)) Then
                txtBranchCode.Text = ""
            Else
                txtBranchCode.Text = r(0)
            End If
            If IsDBNull(r(1)) Then
                txtBranchName.Text = ""
            Else
                txtBranchName.Text = r(1)
            End If
            If IsDBNull(r(2)) Then
                txtAddress.Text = ""
            Else
                txtAddress.Text = r(2)
            End If
            If IsDBNull(r(3)) Then
                txtCity.Text = ""
            Else
                txtCity.Text = r(3)
            End If
            
            If IsDBNull(r(4)) Then
                txtPhone.Text = ""
            Else
                txtPhone.Text = r(4)
            End If
            r.Close()
        Else
            MsgBox("Branch Record not found.", MsgBoxStyle.Information)
            r.Close()
            ClearControls()
        End If

    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()

    End Sub
    Sub ClearControls()
        cmd.CommandText = "Select Count(BranchCode) From Branches"
        Dim acode As Integer
        If cmd.ExecuteScalar Is DBNull.Value Then
            acode = 1
        Else
            acode = cmd.ExecuteScalar + 1
        End If

        Dim x As Control
        For Each x In GroupBox1.Controls
            If TypeOf x Is TextBox Then
                x.Text = ""
            End If
        Next

        txtBranchCode.Text = "L" & Format(acode, "000")
    End Sub




    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim f As New frmView
        'f.viewtype = 2
        'f.Show()

    End Sub
End Class
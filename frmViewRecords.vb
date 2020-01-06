
Imports System.Data.SQLClient
Imports System.Data

Public Class frmViewRecords

    Dim da As New SQLDataAdapter(cmd)
    Dim dt As New System.Data.DataTable

    Public viewtype As Short

    Dim per As Single

    Private Sub frmViewRecords_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'con.Open()


        'BACK END DATABASE TO FRONT END DATA TABLE



        'Dim R As SQLDataReader

        'R = cmd.ExecuteReader() 'FORWARD ONLY READ ONLY CURSOR
        'While R.Read
        '    COMBOBX1.ITEMS.ADD(R("ENAME"))

        'End While
        'R.Close()
        'con.Close()

        loadForm()
    End Sub
    Public Sub loadForm()

        Try
            'If con.State <> ConnectionState.Open Then con.Open()
            Select Case viewtype

                Case 2

                    Me.Text = "BOOKS DETAILS"
                    Label1.Text = "BOOKS DETAILS"
                    If BranchCode <> "" Then
                        cmd.CommandText = "Select * From Books Where BookId in (Select BookId From BooksinBranches Where BranchCode='" & BranchCode & "')"
                    Else
                        cmd.CommandText = "Select * From Books Order By BookId"
                    End If

                    da.Fill(dt)
                    '---------------------------------------------------------------
                Case 3
                    Me.Text = "MEMBER DETAILS"
                    Label1.Text = "MEMBER DETAILS"
                    cmd.CommandText = "Select * from Members Order By MemberID"
                    da.Fill(dt)
                    '---------------------------------------------------------------
                Case 4
                    Me.Text = "BOOK ISSUE/RETURN DETAILS"
                    Label1.Text = "BOOK ISSUE/RETURN DETAILS"
                    cmd.CommandText = "Select * From Issue Order By SNo"
                    da.Fill(dt)
                    Button1.Visible = True
                    '---------------------------------------------------------------
                Case 5
                    Me.Text = "BOOK RESERVATION DETAILS"
                    Label1.Text = "BOOK RESERVATION DETAILS"
                    cmd.CommandText = "Select * From Reservation Order By SNo"
                    da.Fill(dt)
                    Button1.Visible = True
                    '---------------------------------------------------------------
                Case 6
                    Me.Text = "SMS LOG DETAILS"
                    Label1.Text = "SMS LOG DETAILS"
                    cmd.CommandText = "Select A.*,B.EntryTime,B.MemberID From SMSSettings A,SMSLog B Where A.SMSTypeId=B.SMSType"
                    da.Fill(dt)
                    Button1.Visible = False
                    '---------------------------------------------------------------
                Case 101
                    Me.Text = "BOOK STOCK DETAILS"
                    Label1.Text = "BOOK STOCK DETAILS"
                    cmd.CommandText = "Select B.*,A.Quantity From BooksInBranches A,Books B Where A.BookId=B.BookId"
                    da.Fill(dt)
                    Button1.Visible = True
                    '---------------------------------------------------------------
            End Select
            DataGridView1.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally

            'If con.State <> ConnectionState.Closed Then con.Close()

        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()

    End Sub

    Public Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim f As New frmReport
        'f.ReportType = 1
        'f.Show()

        'Dim f As New frmReport
        'f.ReportType = 3
        ''Dim r As New ReportDocument
        ''r.Load(Application.StartupPath & "\..\..\rptView.rpt")
        ''CType(r, rptView).Section1.ReportObjects("Text4").Border.BottomLineStyle = LineStyle.DashLine
        'Dim r As New rptView
        'r.SetDataSource(dt)
        ''r.Section2.ReportObjects.Item("Text4")
        'Select Case RecordType

        '    Case RecordTypes.LastTradingPriceIncreased
        '        r.SetParameterValue(0, "Last Trading Price Increased Companies")
        '    Case RecordTypes.LastTradingPriceDecreased
        '        r.SetParameterValue(0, "Last Trading Price Decreased Companies")

        '    Case RecordTypes.LastTradingPriceIncreasedByPercent
        '        r.SetParameterValue(0, "Last Trading Price Increased By " & per & "%")

        '    Case RecordTypes.LastTradingPriceDecreasedByPercent
        '        r.SetParameterValue(0, "Last Trading Price Decreased By " & per & "%")
        '    Case RecordTypes.LastTradingPriceNotChanged
        '        r.SetParameterValue(0, "Last Trading Price Not Changed Companies")
        '    Case RecordTypes.ContinuouslyIncreasedThisMonth
        '        r.SetParameterValue(0, "Last Trading Price Continuously Increased in " & Format(DateTime.Today, "MMM/yyyy"))
        '    Case RecordTypes.ContinuouslyDecreasedThisMonth
        '        r.SetParameterValue(0, "Last Trading Price Not Continuously Decreased in " & Format(DateTime.Today, "MMM/yyyy"))
        'End Select

        'f.CrystalReportViewer1.ReportSource = r

        'f.Show()

    End Sub

    Public Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        'dt.Rows.Clear()

        'If con.State <> ConnectionState.Open Then con.Open()
        'Select Case RecordType
        '    Case RecordTypes.SalesCustomerwise
        '        cmd.CommandText = "Select * From Sales Where CustomerCode in (Select CustomerCode From Customer Where CustomerName='" & cboSelect.Text & "')"
        '        da.Fill(dt)
        '        Label1.Text = "SALES DETAILS FOR " & UCase(cboSelect.Text)
        '    Case RecordTypes.ServiceCustomerwise
        '        cmd.CommandText = "Select * From Services Where CustomerCode in (Select CustomerCode From Customer Where CustomerName='" & cboSelect.Text & "')"
        '        da.Fill(dt)
        '        Label1.Text = "SERVICE DETAILS FOR " & UCase(cboSelect.Text)
        'End Select


        'con.Close()

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        da.Update(dt)
        Exit Sub


        Dim obj As New SQLCommandBuilder(da)
        da.UpdateCommand = obj.GetUpdateCommand
        da.DeleteCommand = obj.GetDeleteCommand
        da.InsertCommand = obj.GetInsertCommand

        Dim r As Integer = da.Update(dt)
        If r > 0 Then
            MsgBox(r & " Records updated.", MsgBoxStyle.Information)
        Else
            MsgBox("Nothing Changed.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
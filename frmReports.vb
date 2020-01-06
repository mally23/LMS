Public Class frmReports
    Public reporttype As Short
    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        Select Case ReportType
            Case 1
                CrystalReportViewer1.ReportSource = Application.StartupPath & "\..\..\rptAuthors.rpt"
            Case 2
                CrystalReportViewer1.ReportSource = Application.StartupPath & "\..\..\rptBooks.rpt"
            Case 3
                CrystalReportViewer1.ReportSource = Application.StartupPath & "\..\..\rptStudents.rpt"

            Case 4
                CrystalReportViewer1.ReportSource = Application.StartupPath & "\..\..\rptIssues.rpt"
            Case 5
                CrystalReportViewer1.ReportSource = Application.StartupPath & "\..\..\rptReservations.rpt"
            Case 6
                CrystalReportViewer1.ReportSource = Application.StartupPath & "\..\..\rptSMSLog.rpt"
        End Select
    End Sub
End Class
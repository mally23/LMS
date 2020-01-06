<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddStudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewStudentsListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BranchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BranchProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator()
        Me.IssueBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripSeparator()
        Me.BooksCountInBranchesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IssueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookIssueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewBookIssuesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookReturnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookRenewalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReservationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookReservationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewBookReservationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BooksToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BookIssuesReturnsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookReservationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.rptIssues1 = New LibrarySMS.rptIssues()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentsToolStripMenuItem, Me.BranchToolStripMenuItem, Me.BooksToolStripMenuItem, Me.IssueToolStripMenuItem, Me.ReturnsToolStripMenuItem, Me.ReservationToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.PasswordToolStripMenuItem, Me.ExitToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(10, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1028, 29)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StudentsToolStripMenuItem
        '
        Me.StudentsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddStudentsToolStripMenuItem, Me.ViewStudentsListToolStripMenuItem})
        Me.StudentsToolStripMenuItem.Name = "StudentsToolStripMenuItem"
        Me.StudentsToolStripMenuItem.Size = New System.Drawing.Size(87, 23)
        Me.StudentsToolStripMenuItem.Text = "&Member"
        '
        'AddStudentsToolStripMenuItem
        '
        Me.AddStudentsToolStripMenuItem.Name = "AddStudentsToolStripMenuItem"
        Me.AddStudentsToolStripMenuItem.Size = New System.Drawing.Size(223, 24)
        Me.AddStudentsToolStripMenuItem.Text = "Add Members"
        '
        'ViewStudentsListToolStripMenuItem
        '
        Me.ViewStudentsListToolStripMenuItem.Name = "ViewStudentsListToolStripMenuItem"
        Me.ViewStudentsListToolStripMenuItem.Size = New System.Drawing.Size(223, 24)
        Me.ViewStudentsListToolStripMenuItem.Text = "View Member List"
        Me.ViewStudentsListToolStripMenuItem.Visible = False
        '
        'BranchToolStripMenuItem
        '
        Me.BranchToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BranchProjectToolStripMenuItem, Me.ToolStripMenuItem6, Me.IssueBooksToolStripMenuItem, Me.ReturnBooksToolStripMenuItem, Me.ToolStripMenuItem7, Me.BooksCountInBranchesToolStripMenuItem})
        Me.BranchToolStripMenuItem.Name = "BranchToolStripMenuItem"
        Me.BranchToolStripMenuItem.Size = New System.Drawing.Size(117, 23)
        Me.BranchToolStripMenuItem.Text = "Transaction"
        '
        'BranchProjectToolStripMenuItem
        '
        Me.BranchProjectToolStripMenuItem.Name = "BranchProjectToolStripMenuItem"
        Me.BranchProjectToolStripMenuItem.Size = New System.Drawing.Size(188, 24)
        Me.BranchProjectToolStripMenuItem.Text = "Add Branch"
        Me.BranchProjectToolStripMenuItem.Visible = False
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(185, 6)
        '
        'IssueBooksToolStripMenuItem
        '
        Me.IssueBooksToolStripMenuItem.Name = "IssueBooksToolStripMenuItem"
        Me.IssueBooksToolStripMenuItem.Size = New System.Drawing.Size(188, 24)
        Me.IssueBooksToolStripMenuItem.Text = "Issue Books"
        '
        'ReturnBooksToolStripMenuItem
        '
        Me.ReturnBooksToolStripMenuItem.Name = "ReturnBooksToolStripMenuItem"
        Me.ReturnBooksToolStripMenuItem.Size = New System.Drawing.Size(188, 24)
        Me.ReturnBooksToolStripMenuItem.Text = "Return Books"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(185, 6)
        '
        'BooksCountInBranchesToolStripMenuItem
        '
        Me.BooksCountInBranchesToolStripMenuItem.Name = "BooksCountInBranchesToolStripMenuItem"
        Me.BooksCountInBranchesToolStripMenuItem.Size = New System.Drawing.Size(188, 24)
        Me.BooksCountInBranchesToolStripMenuItem.Text = "Books Count "
        '
        'BooksToolStripMenuItem
        '
        Me.BooksToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddBookToolStripMenuItem, Me.ViewBooksToolStripMenuItem})
        Me.BooksToolStripMenuItem.Name = "BooksToolStripMenuItem"
        Me.BooksToolStripMenuItem.Size = New System.Drawing.Size(175, 23)
        Me.BooksToolStripMenuItem.Text = "Stock Maintenance"
        '
        'AddBookToolStripMenuItem
        '
        Me.AddBookToolStripMenuItem.Name = "AddBookToolStripMenuItem"
        Me.AddBookToolStripMenuItem.Size = New System.Drawing.Size(172, 24)
        Me.AddBookToolStripMenuItem.Text = "Add Book"
        '
        'ViewBooksToolStripMenuItem
        '
        Me.ViewBooksToolStripMenuItem.Name = "ViewBooksToolStripMenuItem"
        Me.ViewBooksToolStripMenuItem.Size = New System.Drawing.Size(172, 24)
        Me.ViewBooksToolStripMenuItem.Text = "View Books"
        '
        'IssueToolStripMenuItem
        '
        Me.IssueToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BookIssueToolStripMenuItem, Me.ViewBookIssuesToolStripMenuItem})
        Me.IssueToolStripMenuItem.Name = "IssueToolStripMenuItem"
        Me.IssueToolStripMenuItem.Size = New System.Drawing.Size(64, 23)
        Me.IssueToolStripMenuItem.Text = "Issue"
        '
        'BookIssueToolStripMenuItem
        '
        Me.BookIssueToolStripMenuItem.Name = "BookIssueToolStripMenuItem"
        Me.BookIssueToolStripMenuItem.Size = New System.Drawing.Size(298, 24)
        Me.BookIssueToolStripMenuItem.Text = "Book Issue"
        '
        'ViewBookIssuesToolStripMenuItem
        '
        Me.ViewBookIssuesToolStripMenuItem.Name = "ViewBookIssuesToolStripMenuItem"
        Me.ViewBookIssuesToolStripMenuItem.Size = New System.Drawing.Size(298, 24)
        Me.ViewBookIssuesToolStripMenuItem.Text = "View Book Issues/ Returns"
        '
        'ReturnsToolStripMenuItem
        '
        Me.ReturnsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BookReturnToolStripMenuItem, Me.BookRenewalToolStripMenuItem})
        Me.ReturnsToolStripMenuItem.Name = "ReturnsToolStripMenuItem"
        Me.ReturnsToolStripMenuItem.Size = New System.Drawing.Size(85, 23)
        Me.ReturnsToolStripMenuItem.Text = "Returns"
        '
        'BookReturnToolStripMenuItem
        '
        Me.BookReturnToolStripMenuItem.Name = "BookReturnToolStripMenuItem"
        Me.BookReturnToolStripMenuItem.Size = New System.Drawing.Size(195, 24)
        Me.BookReturnToolStripMenuItem.Text = "Book Return"
        '
        'BookRenewalToolStripMenuItem
        '
        Me.BookRenewalToolStripMenuItem.Name = "BookRenewalToolStripMenuItem"
        Me.BookRenewalToolStripMenuItem.Size = New System.Drawing.Size(195, 24)
        Me.BookRenewalToolStripMenuItem.Text = "Book Renewal"
        '
        'ReservationToolStripMenuItem
        '
        Me.ReservationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BookReservationToolStripMenuItem, Me.ViewBookReservationsToolStripMenuItem})
        Me.ReservationToolStripMenuItem.Name = "ReservationToolStripMenuItem"
        Me.ReservationToolStripMenuItem.Size = New System.Drawing.Size(119, 23)
        Me.ReservationToolStripMenuItem.Text = "Reservation"
        '
        'BookReservationToolStripMenuItem
        '
        Me.BookReservationToolStripMenuItem.Name = "BookReservationToolStripMenuItem"
        Me.BookReservationToolStripMenuItem.Size = New System.Drawing.Size(275, 24)
        Me.BookReservationToolStripMenuItem.Text = "Book Reservation"
        '
        'ViewBookReservationsToolStripMenuItem
        '
        Me.ViewBookReservationsToolStripMenuItem.Name = "ViewBookReservationsToolStripMenuItem"
        Me.ViewBookReservationsToolStripMenuItem.Size = New System.Drawing.Size(275, 24)
        Me.ViewBookReservationsToolStripMenuItem.Text = "View Book Reservations"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BooksToolStripMenuItem1, Me.StudentsToolStripMenuItem1, Me.ToolStripMenuItem2, Me.BookIssuesReturnsToolStripMenuItem, Me.BookReservationsToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(85, 23)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'BooksToolStripMenuItem1
        '
        Me.BooksToolStripMenuItem1.Name = "BooksToolStripMenuItem1"
        Me.BooksToolStripMenuItem1.Size = New System.Drawing.Size(336, 24)
        Me.BooksToolStripMenuItem1.Text = "Books"
        '
        'StudentsToolStripMenuItem1
        '
        Me.StudentsToolStripMenuItem1.Name = "StudentsToolStripMenuItem1"
        Me.StudentsToolStripMenuItem1.Size = New System.Drawing.Size(336, 24)
        Me.StudentsToolStripMenuItem1.Text = "Members"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(333, 6)
        '
        'BookIssuesReturnsToolStripMenuItem
        '
        Me.BookIssuesReturnsToolStripMenuItem.Name = "BookIssuesReturnsToolStripMenuItem"
        Me.BookIssuesReturnsToolStripMenuItem.Size = New System.Drawing.Size(336, 24)
        Me.BookIssuesReturnsToolStripMenuItem.Text = "Book Issues/Returns/Renewals"
        '
        'BookReservationsToolStripMenuItem
        '
        Me.BookReservationsToolStripMenuItem.Name = "BookReservationsToolStripMenuItem"
        Me.BookReservationsToolStripMenuItem.Size = New System.Drawing.Size(336, 24)
        Me.BookReservationsToolStripMenuItem.Text = "Book Reservations"
        '
        'PasswordToolStripMenuItem
        '
        Me.PasswordToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangePasswordToolStripMenuItem})
        Me.PasswordToolStripMenuItem.Name = "PasswordToolStripMenuItem"
        Me.PasswordToolStripMenuItem.Size = New System.Drawing.Size(99, 23)
        Me.PasswordToolStripMenuItem.Text = "Password"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(222, 24)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(53, 23)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(12, 23)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(12, 23)
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(12, 23)
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(12, 23)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 120000
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Library"
        Me.NotifyIcon1.Visible = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(1028, 733)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents BooksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddBookToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewBooksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewStudentsListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddStudentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BooksToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BookIssuesReturnsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookReservationsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BranchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BranchProjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IssueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReturnsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReservationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookIssueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewBookIssuesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookReturnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookReservationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewBookReservationsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookRenewalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents IssueBooksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReturnBooksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BooksCountInBranchesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rptIssues1 As LibrarySMS.rptIssues
End Class

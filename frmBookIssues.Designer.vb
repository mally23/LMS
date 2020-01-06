<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookIssues
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
        Dim Label2 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim CompanyNameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.T3 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BooksBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibrarySMSDataSet2 = New LibrarySMS.LibrarySMSDataSet2()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtp2 = New System.Windows.Forms.DateTimePicker()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.MembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibrarySMSDataSet1 = New LibrarySMS.LibrarySMSDataSet1()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LibrarySMSDataSet = New LibrarySMS.LibrarySMSDataSet()
        Me.BooksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BooksTableAdapter = New LibrarySMS.LibrarySMSDataSetTableAdapters.BooksTableAdapter()
        Me.MembersTableAdapter = New LibrarySMS.LibrarySMSDataSet1TableAdapters.MembersTableAdapter()
        Me.BooksTableAdapter1 = New LibrarySMS.LibrarySMSDataSet2TableAdapters.BooksTableAdapter()
        Label2 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CompanyNameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        CType(Me.BooksBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibrarySMSDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibrarySMSDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibrarySMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Label2.Location = New System.Drawing.Point(22, 65)
        Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(96, 20)
        Label2.TabIndex = 44
        Label2.Text = "BookName"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Label1.Location = New System.Drawing.Point(22, 211)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(108, 20)
        Label1.TabIndex = 28
        Label1.Text = "Return Date"
        '
        'CompanyNameLabel
        '
        CompanyNameLabel.AutoSize = True
        CompanyNameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        CompanyNameLabel.Location = New System.Drawing.Point(22, 31)
        CompanyNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CompanyNameLabel.Name = "CompanyNameLabel"
        CompanyNameLabel.Size = New System.Drawing.Size(71, 20)
        CompanyNameLabel.TabIndex = 26
        CompanyNameLabel.Text = "Book Id"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        AddressLabel.Location = New System.Drawing.Point(22, 103)
        AddressLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(97, 20)
        AddressLabel.TabIndex = 28
        AddressLabel.Text = "Member ID"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Label3.Location = New System.Drawing.Point(22, 175)
        Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(97, 20)
        Label3.TabIndex = 26
        Label3.Text = "Issue Date"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Label4.Location = New System.Drawing.Point(21, 138)
        Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(124, 20)
        Label4.TabIndex = 28
        Label4.Text = "Member Name"
        '
        'lblHeader
        '
        Me.lblHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblHeader.Location = New System.Drawing.Point(0, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(524, 32)
        Me.lblHeader.TabIndex = 62
        Me.lblHeader.Text = "BOOK ISSUE DETAILS"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(230, 342)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 26)
        Me.Button4.TabIndex = 59
        Me.Button4.Text = "&Delete"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'T3
        '
        Me.T3.ForeColor = System.Drawing.Color.OrangeRed
        Me.T3.Location = New System.Drawing.Point(173, 67)
        Me.T3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.T3.Name = "T3"
        Me.T3.Size = New System.Drawing.Size(164, 26)
        Me.T3.TabIndex = 6
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(311, 342)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 26)
        Me.Button5.TabIndex = 60
        Me.Button5.Text = "&Find"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(149, 342)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 26)
        Me.Button3.TabIndex = 58
        Me.Button3.Text = "&Save"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(68, 342)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 26)
        Me.Button2.TabIndex = 56
        Me.Button2.Text = "&Add"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(173, 31)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(164, 28)
        Me.ComboBox1.TabIndex = 45
        '
        'BooksBindingSource1
        '
        Me.BooksBindingSource1.DataMember = "Books"
        Me.BooksBindingSource1.DataSource = Me.LibrarySMSDataSet2
        '
        'LibrarySMSDataSet2
        '
        Me.LibrarySMSDataSet2.DataSetName = "LibrarySMSDataSet2"
        Me.LibrarySMSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtp2)
        Me.GroupBox1.Controls.Add(Me.dtp1)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.T3)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Label3)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(CompanyNameLabel)
        Me.GroupBox1.Controls.Add(Label4)
        Me.GroupBox1.Controls.Add(AddressLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(77, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(370, 263)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        '
        'dtp2
        '
        Me.dtp2.CustomFormat = "dd/MM/yyyy"
        Me.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp2.Location = New System.Drawing.Point(173, 205)
        Me.dtp2.Name = "dtp2"
        Me.dtp2.Size = New System.Drawing.Size(164, 26)
        Me.dtp2.TabIndex = 46
        '
        'dtp1
        '
        Me.dtp1.CustomFormat = "dd/MM/yyyy"
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp1.Location = New System.Drawing.Point(173, 175)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(164, 26)
        Me.dtp1.TabIndex = 46
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(173, 103)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(164, 28)
        Me.ComboBox2.TabIndex = 45
        '
        'MembersBindingSource
        '
        Me.MembersBindingSource.DataMember = "Members"
        Me.MembersBindingSource.DataSource = Me.LibrarySMSDataSet1
        '
        'LibrarySMSDataSet1
        '
        Me.LibrarySMSDataSet1.DataSetName = "LibrarySMSDataSet1"
        Me.LibrarySMSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.ForeColor = System.Drawing.Color.OrangeRed
        Me.TextBox1.Location = New System.Drawing.Point(173, 139)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(164, 26)
        Me.TextBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(392, 342)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 26)
        Me.Button1.TabIndex = 61
        Me.Button1.Text = "&Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LibrarySMSDataSet
        '
        Me.LibrarySMSDataSet.DataSetName = "LibrarySMSDataSet"
        Me.LibrarySMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BooksBindingSource
        '
        Me.BooksBindingSource.DataMember = "Books"
        Me.BooksBindingSource.DataSource = Me.LibrarySMSDataSet
        '
        'BooksTableAdapter
        '
        Me.BooksTableAdapter.ClearBeforeFill = True
        '
        'MembersTableAdapter
        '
        Me.MembersTableAdapter.ClearBeforeFill = True
        '
        'BooksTableAdapter1
        '
        Me.BooksTableAdapter1.ClearBeforeFill = True
        '
        'frmBookIssues
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(524, 408)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmBookIssues"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Book Issue Details"
        CType(Me.BooksBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibrarySMSDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibrarySMSDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibrarySMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents T3 As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents dtp1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents LibrarySMSDataSet As LibrarySMS.LibrarySMSDataSet
    Friend WithEvents BooksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BooksTableAdapter As LibrarySMS.LibrarySMSDataSetTableAdapters.BooksTableAdapter
    Friend WithEvents LibrarySMSDataSet1 As LibrarySMS.LibrarySMSDataSet1
    Friend WithEvents MembersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MembersTableAdapter As LibrarySMS.LibrarySMSDataSet1TableAdapters.MembersTableAdapter
    Friend WithEvents LibrarySMSDataSet2 As LibrarySMS.LibrarySMSDataSet2
    Friend WithEvents BooksBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BooksTableAdapter1 As LibrarySMS.LibrarySMSDataSet2TableAdapters.BooksTableAdapter
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBooks
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
        Dim Label2 As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim CompanyNameLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Me.lblHeader = New System.Windows.Forms.Label
        Me.T1 = New System.Windows.Forms.TextBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.T3 = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.T6 = New System.Windows.Forms.TextBox
        Me.T4 = New System.Windows.Forms.TextBox
        Me.T5 = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Button6 = New System.Windows.Forms.Button
        Label2 = New System.Windows.Forms.Label
        AddressLabel = New System.Windows.Forms.Label
        CompanyNameLabel = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        Label4 = New System.Windows.Forms.Label
        Label5 = New System.Windows.Forms.Label
        Label7 = New System.Windows.Forms.Label
        Label6 = New System.Windows.Forms.Label
        Label8 = New System.Windows.Forms.Label
        Label9 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Label2.Location = New System.Drawing.Point(22, 145)
        Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(96, 20)
        Label2.TabIndex = 44
        Label2.Text = "BookName"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        AddressLabel.Location = New System.Drawing.Point(22, 69)
        AddressLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(97, 20)
        AddressLabel.TabIndex = 28
        AddressLabel.Text = "Author List"
        '
        'CompanyNameLabel
        '
        CompanyNameLabel.AutoSize = True
        CompanyNameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        CompanyNameLabel.Location = New System.Drawing.Point(22, 31)
        CompanyNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CompanyNameLabel.Name = "CompanyNameLabel"
        CompanyNameLabel.Size = New System.Drawing.Size(74, 20)
        CompanyNameLabel.TabIndex = 26
        CompanyNameLabel.Text = "Book ID"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Label1.Location = New System.Drawing.Point(22, 221)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(98, 20)
        Label1.TabIndex = 28
        Label1.Text = "BookCount"
        Label1.Visible = False
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Label3.Location = New System.Drawing.Point(22, 183)
        Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(106, 20)
        Label3.TabIndex = 26
        Label3.Text = "Publications"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Label4.Location = New System.Drawing.Point(22, 259)
        Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(81, 20)
        Label4.TabIndex = 44
        Label4.Text = "Available"
        Label4.Visible = False
        AddHandler Label4.Click, AddressOf Me.Label4_Click
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Label5.Location = New System.Drawing.Point(375, 31)
        Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(81, 20)
        Label5.TabIndex = 28
        Label5.Text = "Category"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Label7.Location = New System.Drawing.Point(375, 72)
        Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(110, 20)
        Label7.TabIndex = 26
        Label7.Text = "Publish Year"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Label6.Location = New System.Drawing.Point(375, 113)
        Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(71, 20)
        Label6.TabIndex = 26
        Label6.Text = "Amount"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Label8.Location = New System.Drawing.Point(375, 163)
        Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(78, 20)
        Label8.TabIndex = 26
        Label8.Text = "ISBN No"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Label9.Location = New System.Drawing.Point(78, 449)
        Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(112, 20)
        Label9.TabIndex = 44
        Label9.Text = "Book Search"
        AddHandler Label9.Click, AddressOf Me.Label4_Click
        '
        'lblHeader
        '
        Me.lblHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblHeader.Location = New System.Drawing.Point(0, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(747, 32)
        Me.lblHeader.TabIndex = 55
        Me.lblHeader.Text = "BOOK DETAILS"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'T1
        '
        Me.T1.ForeColor = System.Drawing.Color.OrangeRed
        Me.T1.Location = New System.Drawing.Point(173, 25)
        Me.T1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.T1.Name = "T1"
        Me.T1.Size = New System.Drawing.Size(164, 26)
        Me.T1.TabIndex = 0
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(406, 292)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 26)
        Me.Button5.TabIndex = 53
        Me.Button5.Text = "&Find"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(325, 292)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 26)
        Me.Button4.TabIndex = 52
        Me.Button4.Text = "&Delete"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'T3
        '
        Me.T3.ForeColor = System.Drawing.Color.OrangeRed
        Me.T3.Location = New System.Drawing.Point(173, 141)
        Me.T3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.T3.Name = "T3"
        Me.T3.Size = New System.Drawing.Size(164, 26)
        Me.T3.TabIndex = 6
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(244, 292)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 26)
        Me.Button3.TabIndex = 51
        Me.Button3.Text = "&Save"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(163, 292)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 26)
        Me.Button2.TabIndex = 49
        Me.Button2.Text = "&Add"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(487, 292)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 26)
        Me.Button1.TabIndex = 54
        Me.Button1.Text = "&Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.T6)
        Me.GroupBox1.Controls.Add(Me.T3)
        Me.GroupBox1.Controls.Add(Label4)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Me.T4)
        Me.GroupBox1.Controls.Add(Label3)
        Me.GroupBox1.Controls.Add(Me.T1)
        Me.GroupBox1.Controls.Add(Label5)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Label8)
        Me.GroupBox1.Controls.Add(Label6)
        Me.GroupBox1.Controls.Add(Label7)
        Me.GroupBox1.Controls.Add(CompanyNameLabel)
        Me.GroupBox1.Controls.Add(Me.T5)
        Me.GroupBox1.Controls.Add(AddressLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(24, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(697, 336)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        '
        'TextBox4
        '
        Me.TextBox4.ForeColor = System.Drawing.Color.OrangeRed
        Me.TextBox4.Location = New System.Drawing.Point(493, 163)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(164, 26)
        Me.TextBox4.TabIndex = 49
        '
        'TextBox3
        '
        Me.TextBox3.ForeColor = System.Drawing.Color.OrangeRed
        Me.TextBox3.Location = New System.Drawing.Point(493, 122)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(164, 26)
        Me.TextBox3.TabIndex = 48
        '
        'TextBox2
        '
        Me.TextBox2.ForeColor = System.Drawing.Color.OrangeRed
        Me.TextBox2.Location = New System.Drawing.Point(493, 69)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(164, 26)
        Me.TextBox2.TabIndex = 47
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(493, 28)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(164, 28)
        Me.ComboBox1.TabIndex = 46
        '
        'TextBox1
        '
        Me.TextBox1.ForeColor = System.Drawing.Color.OrangeRed
        Me.TextBox1.Location = New System.Drawing.Point(173, 61)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(164, 72)
        Me.TextBox1.TabIndex = 45
        '
        'T6
        '
        Me.T6.Enabled = False
        Me.T6.ForeColor = System.Drawing.Color.OrangeRed
        Me.T6.Location = New System.Drawing.Point(173, 258)
        Me.T6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.T6.Name = "T6"
        Me.T6.Size = New System.Drawing.Size(164, 26)
        Me.T6.TabIndex = 6
        Me.T6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.T6.Visible = False
        '
        'T4
        '
        Me.T4.ForeColor = System.Drawing.Color.OrangeRed
        Me.T4.Location = New System.Drawing.Point(173, 180)
        Me.T4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.T4.Name = "T4"
        Me.T4.Size = New System.Drawing.Size(164, 26)
        Me.T4.TabIndex = 0
        '
        'T5
        '
        Me.T5.ForeColor = System.Drawing.Color.OrangeRed
        Me.T5.Location = New System.Drawing.Point(173, 219)
        Me.T5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.T5.Name = "T5"
        Me.T5.Size = New System.Drawing.Size(164, 26)
        Me.T5.TabIndex = 1
        Me.T5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.T5.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(82, 490)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(599, 150)
        Me.DataGridView1.TabIndex = 56
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.ForeColor = System.Drawing.Color.OrangeRed
        Me.TextBox5.Location = New System.Drawing.Point(222, 449)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(258, 26)
        Me.TextBox5.TabIndex = 57
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(487, 447)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 26)
        Me.Button6.TabIndex = 58
        Me.Button6.Text = "Search"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'frmBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(747, 661)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Label9)
        Me.Name = "frmBooks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Book Details"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents T1 As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents T3 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents T6 As System.Windows.Forms.TextBox
    Friend WithEvents T4 As System.Windows.Forms.TextBox
    Friend WithEvents T5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class

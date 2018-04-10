<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.lstTextBook = New System.Windows.Forms.ListBox()
        Me.lstBorrow = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdRefresh = New System.Windows.Forms.Button()
        Me.cmdConfirm = New System.Windows.Forms.Button()
        Me.cmdReturn = New System.Windows.Forms.Button()
        Me.cmdBorrow = New System.Windows.Forms.Button()
        Me.cmdEnterBook = New System.Windows.Forms.Button()
        Me.txtTextBook = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdLogout = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNoBorrow = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblmode = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lstConfirmList = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstTextBook
        '
        Me.lstTextBook.FormattingEnabled = True
        Me.lstTextBook.ItemHeight = 18
        Me.lstTextBook.Location = New System.Drawing.Point(34, 196)
        Me.lstTextBook.Margin = New System.Windows.Forms.Padding(4)
        Me.lstTextBook.Name = "lstTextBook"
        Me.lstTextBook.Size = New System.Drawing.Size(217, 238)
        Me.lstTextBook.TabIndex = 0
        '
        'lstBorrow
        '
        Me.lstBorrow.FormattingEnabled = True
        Me.lstBorrow.ItemHeight = 18
        Me.lstBorrow.Location = New System.Drawing.Point(471, 196)
        Me.lstBorrow.Margin = New System.Windows.Forms.Padding(4)
        Me.lstBorrow.Name = "lstBorrow"
        Me.lstBorrow.Size = New System.Drawing.Size(194, 112)
        Me.lstBorrow.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdRefresh)
        Me.GroupBox2.Controls.Add(Me.cmdConfirm)
        Me.GroupBox2.Controls.Add(Me.cmdReturn)
        Me.GroupBox2.Controls.Add(Me.cmdBorrow)
        Me.GroupBox2.Location = New System.Drawing.Point(303, 240)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(131, 187)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRefresh.Location = New System.Drawing.Point(7, 136)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(115, 36)
        Me.cmdRefresh.TabIndex = 20
        Me.cmdRefresh.Text = "Refresh"
        Me.cmdRefresh.UseVisualStyleBackColor = True
        '
        'cmdConfirm
        '
        Me.cmdConfirm.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConfirm.Location = New System.Drawing.Point(8, 94)
        Me.cmdConfirm.Name = "cmdConfirm"
        Me.cmdConfirm.Size = New System.Drawing.Size(115, 36)
        Me.cmdConfirm.TabIndex = 19
        Me.cmdConfirm.Text = "Confirm"
        Me.cmdConfirm.UseVisualStyleBackColor = True
        '
        'cmdReturn
        '
        Me.cmdReturn.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReturn.Location = New System.Drawing.Point(8, 55)
        Me.cmdReturn.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdReturn.Name = "cmdReturn"
        Me.cmdReturn.Size = New System.Drawing.Size(115, 32)
        Me.cmdReturn.TabIndex = 1
        Me.cmdReturn.Text = "Return"
        Me.cmdReturn.UseVisualStyleBackColor = True
        '
        'cmdBorrow
        '
        Me.cmdBorrow.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBorrow.Location = New System.Drawing.Point(8, 15)
        Me.cmdBorrow.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdBorrow.Name = "cmdBorrow"
        Me.cmdBorrow.Size = New System.Drawing.Size(115, 32)
        Me.cmdBorrow.TabIndex = 0
        Me.cmdBorrow.Text = "Borrow"
        Me.cmdBorrow.UseVisualStyleBackColor = True
        '
        'cmdEnterBook
        '
        Me.cmdEnterBook.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEnterBook.Location = New System.Drawing.Point(259, 101)
        Me.cmdEnterBook.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdEnterBook.Name = "cmdEnterBook"
        Me.cmdEnterBook.Size = New System.Drawing.Size(71, 25)
        Me.cmdEnterBook.TabIndex = 4
        Me.cmdEnterBook.Text = "Add"
        Me.cmdEnterBook.UseVisualStyleBackColor = True
        '
        'txtTextBook
        '
        Me.txtTextBook.Location = New System.Drawing.Point(90, 101)
        Me.txtTextBook.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTextBook.Name = "txtTextBook"
        Me.txtTextBook.Size = New System.Drawing.Size(161, 25)
        Me.txtTextBook.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 104)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "TextBook"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 21)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 18)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "User :"
        '
        'cmdLogout
        '
        Me.cmdLogout.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLogout.Location = New System.Drawing.Point(34, 464)
        Me.cmdLogout.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdLogout.Name = "cmdLogout"
        Me.cmdLogout.Size = New System.Drawing.Size(75, 32)
        Me.cmdLogout.TabIndex = 9
        Me.cmdLogout.Text = "LogOut"
        Me.cmdLogout.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNoBorrow)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(471, 316)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(198, 54)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'txtNoBorrow
        '
        Me.txtNoBorrow.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoBorrow.Location = New System.Drawing.Point(135, 18)
        Me.txtNoBorrow.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNoBorrow.Name = "txtNoBorrow"
        Me.txtNoBorrow.Size = New System.Drawing.Size(48, 25)
        Me.txtNoBorrow.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Fuchsia
        Me.Label3.Location = New System.Drawing.Point(8, 22)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "No.Books Borrowed"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 56)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 18)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Location = New System.Drawing.Point(512, 174)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 18)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Borrowed Books"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblName)
        Me.GroupBox3.Controls.Add(Me.lblmode)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtTextBook)
        Me.GroupBox3.Controls.Add(Me.cmdEnterBook)
        Me.GroupBox3.Location = New System.Drawing.Point(27, 27)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(344, 142)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(87, 56)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(45, 18)
        Me.lblName.TabIndex = 15
        Me.lblName.Text = "Name"
        '
        'lblmode
        '
        Me.lblmode.AutoSize = True
        Me.lblmode.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmode.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblmode.Location = New System.Drawing.Point(88, 21)
        Me.lblmode.Name = "lblmode"
        Me.lblmode.Size = New System.Drawing.Size(72, 21)
        Me.lblmode.TabIndex = 14
        Me.lblmode.Text = "user here"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Location = New System.Drawing.Point(460, 27)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(199, 121)
        Me.GroupBox4.TabIndex = 16
        Me.GroupBox4.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(8, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(180, 90)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Note !!!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Maximum Books Borrowed:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "* Student    2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "* Staff          3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "* Faclty  " & _
            "     4"
        '
        'lstConfirmList
        '
        Me.lstConfirmList.FormattingEnabled = True
        Me.lstConfirmList.ItemHeight = 18
        Me.lstConfirmList.Location = New System.Drawing.Point(460, 402)
        Me.lstConfirmList.Margin = New System.Windows.Forms.Padding(4)
        Me.lstConfirmList.Name = "lstConfirmList"
        Me.lstConfirmList.Size = New System.Drawing.Size(217, 94)
        Me.lstConfirmList.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(457, 380)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 18)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Confirmation List"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(565, 513)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(130, 18)
        Me.LinkLabel1.TabIndex = 19
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Designed by Mcben"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label8.Location = New System.Drawing.Point(44, 174)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 18)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Books Available"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(699, 529)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lstConfirmList)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdLogout)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lstBorrow)
        Me.Controls.Add(Me.lstTextBook)
        Me.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Library Management System"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstTextBook As System.Windows.Forms.ListBox
    Friend WithEvents lstBorrow As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdReturn As System.Windows.Forms.Button
    Friend WithEvents cmdBorrow As System.Windows.Forms.Button
    Friend WithEvents cmdEnterBook As System.Windows.Forms.Button
    Friend WithEvents txtTextBook As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdLogout As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNoBorrow As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lstConfirmList As System.Windows.Forms.ListBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmdConfirm As System.Windows.Forms.Button
    Friend WithEvents cmdRefresh As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents lblmode As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
End Class

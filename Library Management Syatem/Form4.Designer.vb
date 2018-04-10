<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.cmdAddBook = New System.Windows.Forms.Button()
        Me.cmdBorrow = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdAddBook
        '
        Me.cmdAddBook.Location = New System.Drawing.Point(124, 12)
        Me.cmdAddBook.Name = "cmdAddBook"
        Me.cmdAddBook.Size = New System.Drawing.Size(96, 34)
        Me.cmdAddBook.TabIndex = 0
        Me.cmdAddBook.Text = "Add Books"
        Me.cmdAddBook.UseVisualStyleBackColor = True
        '
        'cmdBorrow
        '
        Me.cmdBorrow.Location = New System.Drawing.Point(124, 95)
        Me.cmdBorrow.Name = "cmdBorrow"
        Me.cmdBorrow.Size = New System.Drawing.Size(96, 34)
        Me.cmdBorrow.TabIndex = 1
        Me.cmdBorrow.Text = "Borrow"
        Me.cmdBorrow.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(124, 183)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(96, 34)
        Me.cmdClose.TabIndex = 2
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(339, 293)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdBorrow)
        Me.Controls.Add(Me.cmdAddBook)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Library Management System"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdAddBook As System.Windows.Forms.Button
    Friend WithEvents cmdBorrow As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
End Class

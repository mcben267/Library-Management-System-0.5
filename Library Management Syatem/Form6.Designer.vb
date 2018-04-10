<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.UserDatabaseDataSet = New Library_Management_Syatem.UserDatabaseDataSet()
        Me.UserDatabaseDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserDatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.DataSource = Me.UserDatabaseDataSetBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(7, 21)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(586, 336)
        Me.DataGridView1.TabIndex = 0
        '
        'UserDatabaseDataSet
        '
        Me.UserDatabaseDataSet.DataSetName = "UserDatabaseDataSet"
        Me.UserDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserDatabaseDataSetBindingSource
        '
        Me.UserDatabaseDataSetBindingSource.DataSource = Me.UserDatabaseDataSet
        Me.UserDatabaseDataSetBindingSource.Position = 0
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 399)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form6"
        Me.Text = "Form6"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserDatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents UserDatabaseDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserDatabaseDataSet As Library_Management_Syatem.UserDatabaseDataSet
End Class

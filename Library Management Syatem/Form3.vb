Imports System.Data.OleDb
Public Class Form3
    Dim Username, Password, User As String
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click

        'database
        provider = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source ="

        'access database location
        dataFile = "\\192.168.11.254\Labs.users.users\16-0128\Library Management System 0.5\Library Management Syatem\UserDatabase.mdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString

        'method
        myConnection.Open()
        'the query:
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [Users] WHERE [Name] = '" & txtUsername.Text & "' AND [Password] = '" & txtPassword.Text & "'", myConnection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        ' the following variable is hold true if user is found, and false if user is not found 
        Dim userFound As Boolean = False
        ' the following variables will hold the user first and last name if found.
        Dim Username As String = ""
        Dim Password As String = ""

        'if found:
        While dr.Read
            userFound = True
            Username = dr("Name").ToString
            Password = dr("Password").ToString
            User = dr("User").ToString
        End While

        'checking the result
        If userFound = True Then

            'radiobuttons()
            If User = "Student" Then
                MsgBox("Hello, you have succefully logged on!")
                Form5.lblmode.Text = "Student"
                Form5.lblName.Text = txtUsername.Text
                Me.Hide()
                Form4.Show()

            ElseIf User = "Staff" Then
                MsgBox("Hello, you have succefully logged on!")
                Form5.lblmode.Text = "Staff"
                Form5.lblName.Text = txtUsername.Text
                Me.Hide()
                Form4.Show()

            ElseIf User = "Faculty" Then
                MsgBox("Hello, you have succefully logged on!")
                Form5.lblmode.Text = "Faculty"
                Form5.lblName.Text = txtUsername.Text
                Me.Hide()
                Form4.Show()
            End If

            txtPassword.Clear()
            txtUsername.Clear()

        Else
            MsgBox("In Valide Loging Details.")
        End If
        myConnection.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click

        txtPassword.Clear()
        txtUsername.Clear()
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub Form3_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtUsername.Focus()
    End Sub
End Class
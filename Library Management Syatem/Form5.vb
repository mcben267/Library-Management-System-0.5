Public Class Form5
    Dim num As Single

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.cboUser.Items.Add("Student")        adding items on combobox
        'Me.cboUser.Items.Add("Staff")
        'Me.cboUser.Items.Add("Faclty")

        lstTextBook.Items.Add("VB.1")
        lstTextBook.Items.Add("VB.2")
        lstTextBook.Items.Add("VB.3")
        lstTextBook.Items.Add("VB.6")
        lstTextBook.Items.Add("Calculus")
        lstTextBook.Items.Add("Lab Report.")
        lstTextBook.Items.Add("Physics Course book")
        lstTextBook.Items.Add("Intoduction to Java")
    End Sub

    Private Sub cmdEnterBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEnterBook.Click
        If txtTextBook.Text = Nothing Then
            MsgBox("Enter item.")
        Else
            lstTextBook.Items.Add(txtTextBook.Text)
            txtTextBook.Clear()
            txtTextBook.Focus()
        End If
    End Sub

    Private Sub cmdLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogout.Click

        lstBorrow.Items.Clear()
        lstConfirmList.Items.Clear()
        txtNoBorrow.Clear()
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub cmdBorrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrow.Click
        Dim Members As String
        ' Members = cboUser.Text
        Members = lblmode.Text
        num = num + 1

        'Student Case 1:
        If Members = "Student" Then

            If num > 0 And num = 1 Then
                lstBorrow.Items.Add(lstTextBook.SelectedItem)
                lstTextBook.Items.Remove(lstTextBook.SelectedItem)

                txtNoBorrow.Text = num
            ElseIf num = 2 Then
                lstBorrow.Items.Add(lstTextBook.SelectedItem)
                lstTextBook.Items.Remove(lstTextBook.SelectedItem)
                txtNoBorrow.Text = num
                MsgBox("You have Reached the Limite.")

                'promte message
            ElseIf num > 2 Then
                num = 2
                MsgBox("You have Execced the Limite.")
            End If

            'Staff case 2:
        ElseIf Members = "Staff" Then

            If num > 0 And num = 1 Then
                lstBorrow.Items.Add(lstTextBook.SelectedItem)
                lstTextBook.Items.Remove(lstTextBook.SelectedItem)
                txtNoBorrow.Text = num

            ElseIf num = 2 Then
                lstBorrow.Items.Add(lstTextBook.SelectedItem)
                lstTextBook.Items.Remove(lstTextBook.SelectedItem)
                txtNoBorrow.Text = num

            ElseIf num = 3 Then
                lstBorrow.Items.Add(lstTextBook.SelectedItem)
                lstTextBook.Items.Remove(lstTextBook.SelectedItem)
                txtNoBorrow.Text = num
                MsgBox("You have Reached the Limite.")

                'promted message
            ElseIf num > 3 Then
                num = 3
                MsgBox("You have Execced the Limite.")
            End If


            'Faclty case 3:
        ElseIf Members = "Faculty" Then

            If num > 0 And num = 1 Then
                lstBorrow.Items.Add(lstTextBook.SelectedItem)
                lstTextBook.Items.Remove(lstTextBook.SelectedItem)
                txtNoBorrow.Text = num

            ElseIf num = 2 Then
                lstBorrow.Items.Add(lstTextBook.SelectedItem)
                lstTextBook.Items.Remove(lstTextBook.SelectedItem)
                txtNoBorrow.Text = num

            ElseIf num = 3 Then
                lstBorrow.Items.Add(lstTextBook.SelectedItem)
                lstTextBook.Items.Remove(lstTextBook.SelectedItem)
                txtNoBorrow.Text = num

            ElseIf num = 4 Then
                lstBorrow.Items.Add(lstTextBook.SelectedItem)
                lstTextBook.Items.Remove(lstTextBook.SelectedItem)
                txtNoBorrow.Text = num
                MsgBox("You have Reached the Limite.")
                'promted message
            ElseIf num > 4 Then
                num = 4
                MsgBox("You have Execced the Limite.")
            End If

            'Default Statement case:
        Else
            MsgBox("Select User first.")
        End If

    End Sub

    Private Sub cmdReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReturn.Click
        num = num - 1
        lstTextBook.Items.Add(lstBorrow.SelectedItem)
        lstBorrow.Items.Remove(lstBorrow.SelectedItem)      '
        txtNoBorrow.Text = num
        'promt message
        If num <= 0 Then
            MsgBox("List is Empty.")
        End If

    End Sub

    Private Sub cboUser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmdConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConfirm.Click
        Dim Name, user As String
        user = lblmode.Text


        Name = lblName.Text
        lstConfirmList.Items.Add(lstBorrow.SelectedItem + "  " + Name + "  " + user)
        lstBorrow.Items.Remove(lstBorrow.SelectedItem)

    End Sub


    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click

        txtNoBorrow.Clear()
        'cboUser.Text = ""
        lstBorrow.Items.Clear()
        lstConfirmList.Items.Clear()
        num = 0

    End Sub

   
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("https://mcben267.wordpress.com/")

    End Sub

End Class
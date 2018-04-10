Public Class Form4

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub cmdAddBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddBook.Click
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub cmdBorrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrow.Click
        Me.Hide()
        Form5.Show()
    End Sub
End Class